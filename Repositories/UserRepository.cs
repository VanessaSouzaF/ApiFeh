using ApiFeh.Models;
using System.Linq;
using System.Collections.Generic; 

namespace ApiFeh.Repositories

{
    public static class UserRepository
    {
        public static User Get(string Username, string Password)
        {
            var users = new List<User>();
            users.Add(new User {Id = 1, Username = "Fernando", Password = "fernando", Role = "admin"});
            users.Add(new User {Id = 2, Username = "Vanessa", Password = "vanessa", Role = "usuario"});
            return users.Where(x => x.Username.ToLower() == Username.ToLower() && x.Password == x.Password).FirstOrDefault();
        }
    }
}