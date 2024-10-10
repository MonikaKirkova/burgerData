namespace BurgersData.Models
{
    public class Burger
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public double Price { get; set; }
        public string Image {  get; set; }
        public List<Review> Reviews { get; set; }
        public bool Beef { get; set; }
        public bool PulledPork { get; set; }
        public bool Chicken { get; set; }
        public bool Tomato { get; set; }
        public bool Iceberg { get; set; }
        public bool Mayo { get; set; }
        public bool HotSause { get; set; }
        public bool Aioli { get; set; }
        public bool Pesto { get; set; }
        public bool BurgerSauce { get; set; }
        public bool Cheddar { get; set; }
        public bool BlueCheese { get; set; }
        public bool Bri { get; set; }
        public bool Jam { get; set; }
        public bool Jalapenos { get; set; }
        public bool Avocado { get; set; }
        public bool CaramelisedOnion { get; set; }
        public bool Egg { get; set; }
        public bool Rocket { get; set; }
        public bool Bbq { get; set; }
        public bool Pickels { get; set; }
        public bool VeggieBurger { get; set; }
        public bool Bacon { get; set; }
        public bool RedOnion { get; set; }
        public bool Coleslaw { get; set; }
        public bool Ranch { get; set; }
        public bool MozarellaSticks { get; set; }
        public Label Labels { get; set; }
    }
}
