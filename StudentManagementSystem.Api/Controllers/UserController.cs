using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentManagementSystem.Models.Entities;

namespace StudentmanagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        //private readonly ApplicationDbContext _db;

        public UserController()
        {
           // _db = db;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            //return Ok(_db.Users.ToList());
            return null;
        }

        [HttpPost]
        public async Task<IActionResult> AddUser([FromBody] User objUser)
        {
            //if (!ModelState.IsValid)
            //{
            //    return new JsonResult("Error while creating a user");
            //}
            //_db.Users.Add(objUser);
            //await _db.SaveChangesAsync();

            return new JsonResult("User created sucessfully");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser([FromRoute] int id, [FromBody] User objUser)
        {
            //if(objUser == null || id != objUser.Id)
            //{
            //    return new JsonResult("user not found");
            //}
            //else
            //{
            //    _db.Users.Update(objUser);
            //    await _db.SaveChangesAsync();

            //    return new JsonResult("User updated");
            //}
            return null;

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser ([FromRoute] int id)
        {
            //var findUser = await _db.Users.FindAsync(id);
            //if(findUser == null)
            //{
            //    return NotFound();
            //}
            //else
            //{
            //    _db.Users.Remove(findUser);
            //    await _db.SaveChangesAsync();

            //    return new JsonResult("User deleted");

            //}
            return null;
        }
    }
}
