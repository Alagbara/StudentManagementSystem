using System;
using System.Collections.Generic;
using StudentmanagementSystem.ClientApp.Data;

namespace StudentmanagementSystem.Models
{
    public class SQLUserRepository : IUserReppository
    {
        private ApplicationDbContext context;

        public SQLUserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public object Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            User user = context.Users.Find(id);
            if(user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            return user;
        }

        public IEnumerable<User> GetAllUser()
        {
            return context.Users;
        }

        public User GetUser(int id)
        {
            return context.Users.Find(id);
           
        }

        public User Update(User Userchanges)
        {
            var user = context.Users.Attach(Userchanges);
            user.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return Userchanges;
        }

        //User IUserReppository.Add(User user)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
