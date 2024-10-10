using BurgersData.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgersData.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RestaurantsController : ControllerBase
    {
        private readonly Restaurant _myRestaurants;
        public RestaurantsController(Restaurant myRestaurants)
        {
            _myRestaurants = myRestaurants;
        }

        [HttpGet]
        public List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> restaurants = _myRestaurants.getRestaurants();
            return restaurants;
        }


        [HttpGet("{restaurantName}")]
        public List<Burger> GetRestaurantBurgers(string restaurantName)
        {
            List<Burger> burgers = new List<Burger>();
            List<Restaurant> restaurants = _myRestaurants.getRestaurants();
            var restaurant = restaurants.Find(x => x.Name == restaurantName);
            if (restaurant != null)
            {
                foreach (var burger in restaurant.Burgers)
                {
                    burgers.Add(new Burger { Name = burger.Name, Price = burger.Price });
                }
            }
            return burgers;
        }

        //[HttpPost]
        //public IActionResult CreateStudent(Student student)
        //{
        //    students.Add(student);
        //    return Ok(student);
        //}

        //[HttpPut]
        //public IActionResult UpdateStudent(Student student)
        //{
        //    var studentInList = students.Find(x => x.Id == student.Id);
        //    if (student == null)
        //    {
        //        return NotFound("Invalid student details");
        //    }
        //    studentInList.FirstName = student.FirstName;
        //    studentInList.LastName = student.LastName;
        //    studentInList.Age = student.Age;
        //    studentInList.City = student.City;
        //    return Ok(studentInList);
        //}

        //[HttpDelete]
        //public IActionResult DeleteStudent(int id)
        //{
        //    var student = students.Find(x => x.Id == id);
        //    if (student == null)
        //    {
        //        return NotFound("Invalid student details");
        //    }
        //    students.Remove(student);
        //    return Ok(students);
        //}

    }
}
