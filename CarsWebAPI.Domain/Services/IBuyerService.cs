using CarsWebAPI.Domain.Entities;

namespace CarsWebAPI.Domain.Services
{
    public interface IBuyerService
    {
        IEnumerable<Buyer> GetAllBuyers();
        Buyer GetBuyerById(int buyerId);
        void AddBuyer(Buyer buyer);
        void UpdateBuyer(Buyer buyer);
        void DeleteBuyer(int buyerId);
    }
}
