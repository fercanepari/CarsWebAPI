using CarsWebAPI.Domain.Entities;
using CarsWebAPI.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CarsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyerController : ControllerBase
    {
        private readonly IBuyerRepository _buyerRepository;

        public BuyerController(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Buyer>> GetAllBuyers()
        {
            var buyers = _buyerRepository.GetAllBuyers();
            return Ok(buyers);
        }

        [HttpGet("{id}")]
        public ActionResult<Buyer> GetBuyerById(int id)
        {
            var buyer = _buyerRepository.GetBuyerById(id);
            if (buyer == null)
            {
                return NotFound();
            }
            return Ok(buyer);
        }

        [HttpPost]
        public ActionResult<Buyer> CreateBuyer([FromBody] Buyer buyer)
        {
            _buyerRepository.AddBuyer(buyer);
            return CreatedAtAction(nameof(GetBuyerById), new { id = buyer.BuyerId }, buyer);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateBuyer(int id, [FromBody] Buyer buyer)
        {
            if (id != buyer.BuyerId)
            {
                return BadRequest();
            }

            _buyerRepository.UpdateBuyer(buyer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBuyer(int id)
        {
            var existingBuyer = _buyerRepository.GetBuyerById(id);
            if (existingBuyer == null)
            {
                return NotFound();
            }

            _buyerRepository.DeleteBuyer(id);
            return NoContent();
        }
    }
}
