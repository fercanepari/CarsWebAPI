using CarsWebAPI.Domain.Entities;
using CarsWebAPI.Domain.Repositories;

namespace CarsWebAPI.Infrastructure.DataAccess
{
    public class BuyerRepository : IBuyerRepository
    {
        private readonly CarsDbContext _context;

        public BuyerRepository(CarsDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Buyer> GetAllBuyers()
        {
            return _context.Buyers.ToList();
        }

        public Buyer GetBuyerById(int buyerId)
        {
            return _context.Buyers.FirstOrDefault(b => b.BuyerId == buyerId);
        }

        public void AddBuyer(Buyer buyer)
        {
            _context.Buyers.Add(buyer);
            _context.SaveChanges();
        }

        public void UpdateBuyer(Buyer buyer)
        {
            _context.Buyers.Update(buyer);
            _context.SaveChanges();
        }

        public void DeleteBuyer(int buyerId)
        {
            var buyerToDelete = _context.Buyers.FirstOrDefault(b => b.BuyerId == buyerId);
            if (buyerToDelete != null)
            {
                _context.Buyers.Remove(buyerToDelete);
                _context.SaveChanges();
            }
        }
    }
}
