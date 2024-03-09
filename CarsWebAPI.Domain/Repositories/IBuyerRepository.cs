using CarsWebAPI.Domain.Entities;

namespace CarsWebAPI.Domain.Repositories
{
    public interface IBuyerRepository
    {
        IEnumerable<Buyer> GetAllBuyers();
        Buyer GetBuyerById(int buyerId);
        void AddBuyer(Buyer buyer);
        void UpdateBuyer(Buyer buyer);
        void DeleteBuyer(int buyerId);
    }
}
