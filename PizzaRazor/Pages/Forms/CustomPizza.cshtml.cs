using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Models; // only import up to the folder, do not include filename that level

namespace PizzaRazor.Pages.Forms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzaModel MyPizza { get; set; } // property bind should be in front of property, not methods
        public float PizzaPrice { get; set; }
        public void OnGet(){}


        // this is called when user click the button
        
        public IActionResult OnPost()
        {
            // will not pop up windows when you use console.writeline
            PizzaPrice = MyPizza.BasePrice;
            if (MyPizza.Cheese) PizzaPrice += 2.5f;
            if (MyPizza.TomatoSauce) PizzaPrice += 1.5f;
            if (MyPizza.Beef) PizzaPrice += 5.0f;
            if (MyPizza.Peperoni) PizzaPrice += 1.0f;
            // redirect from custom pizza page to the checkout page
            // send name, price to the page
            return RedirectToPage("/Checkouts/Checkouts", new {MyPizza.PizzaName, MyPizza.PizzaImageTitle, PizzaPrice });
        }
    }
}
