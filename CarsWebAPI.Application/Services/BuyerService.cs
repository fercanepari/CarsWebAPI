using CarsWebAPI.Domain.Entities;
using CarsWebAPI.Domain.Repositories;
using CarsWebAPI.Domain.Services;

namespace CarsWebAPI.Application.Services
{
    public class BuyerService : IBuyerService
    {
        private readonly IBuyerRepository _buyerRepository;

        public BuyerService(IBuyerRepository buyerRepository)
        {
            _buyerRepository = buyerRepository;
        }

        public IEnumerable<Buyer> GetAllBuyers()
        {
            return _buyerRepository.GetAllBuyers();
        }

        public Buyer GetBuyerById(int buyerId)
        {
            return _buyerRepository.GetBuyerById(buyerId);
        }

        public void AddBuyer(Buyer buyer)
        {
            _buyerRepository.AddBuyer(buyer);
        }

        public void UpdateBuyer(Buyer buyer)
        {
            _buyerRepository.UpdateBuyer(buyer);
        }

        public void DeleteBuyer(int buyerId)
        {
            _buyerRepository.DeleteBuyer(buyerId);
        }
    }
}

