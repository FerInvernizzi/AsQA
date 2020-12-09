using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User
    {
        private string name;
        private int id;
        private static int lastId = 1;
        private string password;


        #region Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public static int LastId
        {
            get { return lastId; }
        }


        public string Password
        {
            get { return password; }
            set { password = value; }
        } 
        #endregion

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
            this.id = lastId;
            lastId++;
        }
    }
}
