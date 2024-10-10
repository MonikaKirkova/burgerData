using BurgersData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace BurgersData.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BurgersController : ControllerBase
    {
        private readonly Restaurant _myRestaurants;

        public BurgersController(Restaurant myRestaurants)
        {
            _myRestaurants = myRestaurants;
        }
        

        [HttpGet]
        public List<Burger> GetAllBurgers()
        {
            List<Burger> burgers = new List<Burger>();
            List<Restaurant> restaurants = _myRestaurants.getRestaurants();
            restaurants.ForEach(restaurant =>
            {
                burgers.AddRange(restaurant.Burgers);
            });
            burgers = burgers.OrderByDescending(burger => burger.Rating).ToList();
            return burgers;
        }

        [HttpGet("{id}")]
        public List<Burger> GetBurger(string id)
        {
            List<Burger> burgers = new List<Burger>();
            List<Restaurant> restaurants = _myRestaurants.getRestaurants();
            foreach (var restaurant in restaurants)
            {
                var burger = restaurant.Burgers.FirstOrDefault(x => x.Id == id);
                if (burger != null)
                {
                    burgers.Add(burger);
                    //return burger;
                }
            }
            return burgers;
            //return NotFound("Student not found");
        }

        //[HttpGet("{restaurantName}")]
        //public IActionResult GetRestaurantBurgers(string restaurantName)
        //{
        //    var restaurant = restaurants.Find(x => x.Name == restaurantName);
        //    if (restaurant == null)
        //    {
        //        return NotFound("Student not found");
        //    }
        //    return Ok(restaurant.Burgers);
        //}

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