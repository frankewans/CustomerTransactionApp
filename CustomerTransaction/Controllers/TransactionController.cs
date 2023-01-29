using Microsoft.AspNetCore.Mvc;
using CustomerTransaction.Models;
using System.Diagnostics;
using CustomerTransactionApp.Service.Interface;

namespace CustomerTransaction.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransaction _transactionService;

        public TransactionController(ITransaction transaction)
        {
            _transactionService = transaction;
        }
        public IActionResult Index()
        {
            return View(_transactionService.GetCustomers());
        }
        public IActionResult Details(string id , DateTime? search)
        {

            ViewBag.Search = search?.ToString("MM/dd/yyyy");

            return View(_transactionService.GetTransactions(id,search));
        }
        
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
