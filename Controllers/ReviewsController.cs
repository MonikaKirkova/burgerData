using BurgersData.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgersData.Controllers
{
    [Route("[controller]")]
        [ApiController]
        public class ReviewsController : ControllerBase
        {
        private readonly Restaurant _myRestaurants;
        public ReviewsController(Restaurant myRestaurants)
        {
            _myRestaurants = myRestaurants;
        }

        [HttpGet("{id}")]
            public List<Review> GetReviews(string id)
            {
                List<Review> reviews = new List<Review>();
                List<Restaurant> restaurants = _myRestaurants.getRestaurants();
                foreach (var restaurant in restaurants)
                {
                    var burger = restaurant.Burgers.FirstOrDefault(x => x.Id == id);
                    if (burger != null)
                    {
                        foreach (var review in burger.Reviews)
                        {
                            reviews.Add(review);
                        }
                        //burgers.Add(burger);
                        //return burger;
                    }
                }
                return reviews;
                //return NotFound("Student not found");
            }


        }
    }