using System;
using System.Collections.Generic;

namespace StudentmanagementSystem.Models
{
    public interface IUserReppository
    {
        User GetUser(int id);
        IEnumerable<User> GetAllUser();
        User Add(User user);
        User Update(User Userchanges);
        User Delete(int id);
    }
}
