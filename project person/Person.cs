using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_person
{
    internal class Person
    {
        public string name;
        public string family;
        public string id;
        public string website;


        public Person(string name,string family,string id,string website)
        {
            this.name = name;
            this.family = family;
            this.id = id;
            this.website = website;
        }
    }
}
