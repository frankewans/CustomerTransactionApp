using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace CustomerTransactionApp.Service.Models
{
    public class TransactionItem
    {        
        public string? TransactionId { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }
        public string? CreditDebitIndicator { get; set; }
        public string? Status { get; set; }
        public DateTime BookingDate { get; set; }
    }
}
