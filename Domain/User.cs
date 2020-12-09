using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        private static int lastId = 1;
        private int id;

        private string username;
        private string password;
        private int reputation;


        #region Properties
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Reputation
        {
            get { return reputation; }
            set { reputation = value; }
        }
        
        #endregion

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            this.reputation = 0;
            this.id = lastId;
            lastId++;
        }
    }
}
