using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS
{
    public class Dog
    {
        public String name  { get; set; }
        public String race { get; set; }
        public int id { get; set; }

        public Dog(string name, string race, int id)
        {
            this.name = name;
            this.race = race;
            this.id = id;
        }
    }
}
