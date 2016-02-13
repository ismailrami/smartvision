using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartVision
{
    class Person
    {
        public string name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public int id { get; set; }
        public Person(string name , string email,string gender, int id)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.id = id;
        }
        public string ToString()
        {
            return this.name + " " + this.email;
        }

    }
}
