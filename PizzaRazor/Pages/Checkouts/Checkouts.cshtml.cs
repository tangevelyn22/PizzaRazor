using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Models;
using PizzaRazor.Data;

namespace PizzaRazor.Pages.Checkouts
{
    [BindProperties(SupportsGet = true)] // you must set the names to be the same variable name and parameters if you use this method
    public class CheckoutsModel : PageModel
    {
        // note that you do not need a pizza object because you only want to pass those information to the next page
        
        [BindProperty(SupportsGet = true)]
        public string PizzaName { get; set; } // same parameter name as name in models
        [BindProperty(SupportsGet = true)]
        public string PizzaImageTitle { get; set; }

        [BindProperty(SupportsGet = true)]
        public float PizzaPrice { get; set; }



        public void OnGet()
        {
            // check user input here, instead of setting value when initialize
            if (string.IsNullOrWhiteSpace(PizzaName))
            {
                PizzaName = "CustomPizza";
            }
            
            if (string.IsNullOrWhiteSpace(PizzaImageTitle))
            {
                PizzaImageTitle = "makeown";
            }
            
        }
        
    }
}
