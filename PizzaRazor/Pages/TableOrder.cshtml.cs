using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Models;
using PizzaRazor.Data;

namespace PizzaRazor.Pages
{
    public class TableOrderModel : PageModel
    {

        public List<PizzaOrder> orders = new List<PizzaOrder>();

        private readonly ApplicationDBContext _context;


        public TableOrderModel(ApplicationDBContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            orders = _context.PizzaOrders.ToList();
        }
    }
}
