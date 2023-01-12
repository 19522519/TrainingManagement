using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TrainingManagement.Controller
{
    class UserController
    {
        TrainingManagementEntities entities = new TrainingManagementEntities();

        public dynamic getAll()
        {
            var data = from c in entities.users
                       select new
                       {
                           ID = c.id,
                           EMAIL = c.email,
                           USERNAME = c.username,
                           RIGHT = c.access_right,
                           AVATAR = c.avatar
                       };
            return data.ToList();
        }

        public dynamic All()
        {
            var data = entities.users;
            return data.ToList();
        }

        public users getUserById(int id)
        {
            return entities.users.Find(id);
        }

        public int login(string username, string password)
        {
            var existingUser = entities.users.FirstOrDefault(m => m.username.Equals(username));

            if (existingUser != null)
            {
                if (existingUser.pass.Equals(password))
                    return existingUser.id;
                else
                    return -1;
            }
            return -1;
        }

        public void addUser(users user)
        {
            entities.users.Add(user);
            entities.SaveChanges();
        }

        public users getUserByUsername(String username)
        {
            var existingUser = entities.users.FirstOrDefault(m => m.username.Equals(username));

            if (existingUser != null)
                return this.getUserById(existingUser.id);
            else
                return null;
        }
    }
}
