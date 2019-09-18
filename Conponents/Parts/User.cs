using System;
namespace Conponents.Parts
{
    public class User
    {
      

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public int PhoneNumber { get; set; }
            public string Password { get; set; }
            public string PasswordHash { get; set; }

            public virtual Role Role { get; set; }


        
    }
}
