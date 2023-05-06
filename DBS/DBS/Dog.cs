using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBS
{
    internal class Dog
    {
        private String name { get; set; }
        private String race { get; set; }
        private int id { get; set; }

        public Dog(string name, string race, int id)
        {
            this.name = name;
            this.race = race;
            this.id = id;
        }


    }
}
