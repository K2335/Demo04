using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht07
{
    class Varsi
    {
        private string name;
        private string model;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        

        public override string ToString()
        {
            return "Name: " + name + " " + "Model: " + model + " ";
        }
    }
}
