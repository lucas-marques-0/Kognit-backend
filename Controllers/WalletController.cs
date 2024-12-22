using KognitAPI.Models;
using KognitAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace KognitAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalletController : ControllerBase
    {
        private readonly WalletService _walletService;

        public WalletController(WalletService walletService)
        {
            _walletService = walletService;
        }

        [HttpPost]
        public IActionResult CreateWallet(Wallet wallet)
        {
            _walletService.AddWallet(wallet);
            return Ok("Carteira criada com sucesso!!!");
        }

        [HttpGet("{userId}")]
        public IActionResult GetWallets(int userId)
        {
            var wallets = _walletService.GetWalletsByUserId(userId);
            return Ok(wallets);
        }
    }

}
