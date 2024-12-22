using KognitAPI.Models;
using KognitAPI.Repositories;

namespace KognitAPI.Services
{
    public class WalletService
    {
        private readonly IWalletRepository _repository;

        public WalletService(IWalletRepository repository)
        {
            _repository = repository;
        }

        public void AddWallet(Wallet wallet) => _repository.Add(wallet);
        public IEnumerable<Wallet> GetWalletsByUserId(int userId) => _repository.GetByUserId(userId);
    }
}
