using KognitAPI.Models;
using UserWalletApi.Data;

namespace KognitAPI.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly AppDbContext _context;
        public WalletRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Wallet wallet)
        {
            _context.Wallets.Add(wallet);
            _context.SaveChanges();
        }

        public IEnumerable<Wallet> GetByUserId(int userId) =>
            _context.Wallets.Where(w => w.UserID == userId).ToList();
    }
}
