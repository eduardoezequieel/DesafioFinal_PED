using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PED.Models
{
    internal class UserType
    {
        private int id;
        private string userTypeName;

        public UserType(int id, string userTypeName)
        {
            this.id = id;
            this.userTypeName = userTypeName;
        }

        public int Id { get => id; set => id = value; }
        public string UserTypeName { get => userTypeName; set => userTypeName = value; }
    }
}
