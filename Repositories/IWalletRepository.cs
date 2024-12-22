using KognitAPI.Models;

namespace KognitAPI.Repositories
{
    public interface IWalletRepository
    {
        void Add(Wallet wallet);
        IEnumerable<Wallet> GetByUserId(int userId);
    }
}
