using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaRazor.Models;

namespace PizzaRazor.Pages
{
    public class pizzaSelectModel : PageModel
    {

        public List<PizzaModel> fakePizzaDB = new List<PizzaModel>
        {
            new PizzaModel()
            {
                PizzaImageTitle="pizza1",
                PizzaName = "Magerita",
                BasePrice = 2.0f,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4.9f
            },

            new PizzaModel()
            {
                PizzaImageTitle="pizza2",
                PizzaName = "Hawaiian",
                BasePrice = 2.0f,
                TomatoSauce = true,
                Beef = true,
                FinalPrice = 3.7f
            },

            new PizzaModel()
            {
                PizzaImageTitle="pizza3",
                PizzaName = "Vegetarian",
                BasePrice = 2.0f,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4.9f
            },

            new PizzaModel()
            {
                PizzaImageTitle="pizza4",
                PizzaName = "Super Cheesy",
                BasePrice = 2.0f,
                Cheese = true,
                FinalPrice = 2.5f
            },

            new PizzaModel()
            {
                PizzaImageTitle="pizza5",
                PizzaName = "Super Fruit",
                BasePrice = 2.0f,
                Peperoni = true,
                Beef = true,
                FinalPrice = 3.5f
            },

            new PizzaModel()
            {
                PizzaImageTitle="pizza6",
                PizzaName = "Peperoni",
                BasePrice = 2.0f,
                TomatoSauce = true,
                Peperoni = true,
                FinalPrice = 6.2f
            },



        };
        public void OnGet(){}
    }
}
