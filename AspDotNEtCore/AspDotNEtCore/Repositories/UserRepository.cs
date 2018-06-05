using System;
using System.Collections.Generic;
using System.Linq;

namespace AspDotNEtCore.Repositories
{
    public class UserRepository
    {
        private List<User> users;

        public UserRepository()
        {
            users = new List<User>();
            users.Add(new User { ID = "T", Password = "1" });
        }

        public User GetUser(string id) {
            return users.Where((user) => user.ID == id).FirstOrDefault();
        }
    }

    public class User {
        public string ID { get; set; }
        public string Password { get; set; }
    }
}
