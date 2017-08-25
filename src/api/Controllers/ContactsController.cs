using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        public IActionResult Get()
        {
            var results = new[]
            {
                new {FirstName = "John", LastName = "Doe"},
                new {FirstName = "Mike", LastName = "Smith"}
            };

            return Ok(results);
        }
    }
}
