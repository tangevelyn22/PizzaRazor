namespace PizzaRazor.Models
{
    public class PizzaModel
    {
        public string PizzaImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; } = 2.0f;
        public int PizzaId { get; set; }
        public float Price { get; set; }
        public bool Cheese { get; set; }
        public bool TomatoSauce { get; set; }
        public bool Beef { get; set; }
        public bool Peperoni { get; set; }


        public float FinalPrice { get; set; } = 2.0f;
    }
}
