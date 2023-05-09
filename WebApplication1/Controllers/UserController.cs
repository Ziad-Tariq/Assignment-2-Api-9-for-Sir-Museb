using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Model;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("webapi/[controller]")]
    public class UserController : Controller
    {
        private readonly UserDbContext _UserDbContext;

        public UserController(UserDbContext UserDbContext)
        {
            _UserDbContext = UserDbContext;
        }
        [HttpGet]
        public IActionResult GetProduct()
        {
            return Ok();
        }
        [HttpPost]
        public IActionResult Save(User ziad)
        {
             
            // Save the product to the database
            _UserDbContext.UserCredentials.Add(ziad);
            _UserDbContext.SaveChanges();
            
            return Ok();
        }
    }
}
