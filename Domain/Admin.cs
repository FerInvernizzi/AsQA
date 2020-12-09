using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Admin
    {
        private static Admin instance;
        private List<User> users;


        #region Properties

        public List<User> Users
        {
            get { return users; }
            set { users = value; }
        }

        public static Admin Instance
        {
            get
            {
                if (instance == null) instance = new Admin();
                return instance;
            }
        } 
        #endregion


        private Admin() {
            this.users = LoadUsers();
        }

        private List<User> LoadUsers()
        {
            List<User> ret = new List<User>();
            ret.Add(CreateUser("Fernando", "Password1"));
            ret.Add(CreateUser("Natalia", "nat_nat5"));
            return ret;
        }

        public User CreateUser(string username, string password)
        {
            User ret = new User(username, password);
            return ret;
        }
        
    }
}
