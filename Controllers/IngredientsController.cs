using BurgersData.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgersData.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private readonly Restaurant _myRestaurants;
        public IngredientsController(Restaurant myRestaurants)
        {
            _myRestaurants = myRestaurants;
        }


        [HttpGet("{id}")]
        public List<Review> GetIngredients(string id)
        {
            List<Review> ingredients = new List<Review>();
            List<Restaurant> restaurants = _myRestaurants.getRestaurants();
            foreach (var restaurant in restaurants)
            {
                var burger = restaurant.Burgers.FirstOrDefault(x => x.Id == id);
                if (burger != null)
                {
                    Type burgerType = burger.GetType();

                    // Get all properties of the object that are of type bool
                    var booleanProperties = burgerType.GetProperties()
                        .Where(p => p.PropertyType == typeof(bool));

                    // Loop through and print the names and types of boolean properties
                    foreach (var prop in booleanProperties)
                    {
                        object value = prop.GetValue(burger);
                        if (value.Equals(true))
                        {
                            ingredients.Add(new Review { Info = prop.Name });
                        }
                        //Console.WriteLine($"Property: {prop.Name}, Type: {prop.PropertyType}");
                    }
                }
            }
            return ingredients;
            //return NotFound("Student not found");
        }


    }
}