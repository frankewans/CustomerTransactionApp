using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerTransactionApp.Service.Helpers
{
    public static class GlobalHelper
    {
        /// <summary>
		/// Formats this value as a currency amount.
		/// </summary>
		/// <param name="value">The Decimal value to be formatted.</param>
		/// <param name="currency"> The currency symbol (defaults to the HTML entity for Naira).</param>
		/// <returns></returns>
		public static IHtmlContent ToCurrency(this decimal value, string currency = "&#x24;")
        {
            //var symbol = currency.GetCurrencyCode();
            return new HtmlString($"{currency}{value:N}");
        }
    }
}
