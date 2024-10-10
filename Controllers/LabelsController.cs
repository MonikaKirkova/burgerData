using BurgersData.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgersData.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LabelsController : ControllerBase
    {
        private readonly Restaurant _myRestaurants;
        public LabelsController(Restaurant myRestaurants)
        {
            _myRestaurants = myRestaurants;
        }


        [HttpGet("{id}")]
        public List<Review> GetLabels(string id)
        {
            List<Review> labels = new List<Review>();
            List<Restaurant> restaurants = _myRestaurants.getRestaurants();
            foreach (var restaurant in restaurants)
            {
                var burger = restaurant.Burgers.FirstOrDefault(x => x.Id == id);
                if (burger != null)
                {
                    Type labelsType = burger.Labels.GetType();

                    // Get all properties of the object that are of type bool
                    var booleanProperties = labelsType.GetProperties();

                    // Loop through and print the names and types of boolean properties
                    foreach (var prop in booleanProperties)
                    {
                        object value = prop.GetValue(burger.Labels);
                        if (value.Equals(true))
                        {
                            labels.Add(new Review { Info = prop.Name });
                        }
                        //Console.WriteLine($"Property: {prop.Name}, Type: {prop.PropertyType}");
                    }
                }
            }
            return labels;
            //return NotFound("Student not found");
        }


    }
}
