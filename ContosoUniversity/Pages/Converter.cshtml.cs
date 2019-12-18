using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoUniversity.Pages
{
    public class ConverterModel : PageModel
    {
        public Decimal Pounds { get; set; }

        public Decimal Euros { get; set; }

        public CultureInfo France = new CultureInfo("fr-FR");

        public string currencyFormat = "C2";

        public void OnGet()
        {
            Pounds = 0m;
            Euros = 0m;
        }


        public void OnPost()
        {
            string value = Request.Form["Pounds"];
            Pounds = Convert.ToDecimal(value);

            Euros = Pounds * 1.12m;
        }        
    }
}