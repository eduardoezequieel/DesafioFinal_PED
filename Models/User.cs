using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PED.Models
{
    public class User
    {
        private int id;
        private string username;
        private string password;
        private int userType;
        private string userTypeName;

        public User(int id, string username, string password, int userType, string userTypeName)
        {
            this.id = id;
            this.username = username;
            this.password = password;
            this.userType = userType;
            this.userTypeName = userTypeName;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetUsername()
        {
            return this.username;
        }

        public string GetPassword()
        {
            return this.password;
        }

        public int GetUserType()
        {
            return this.userType;
        }

        public string GetUserTypeName()
        {
            return this.userTypeName;
        }
    }
}
