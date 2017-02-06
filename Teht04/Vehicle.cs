using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht04
{
    class Vehicle
    {
        private string name;
        private string model;
        private int modelYear;
        private string color;

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

        public int ModelYear
        {
            get
            {
                return modelYear;
            }
            set
            {
                modelYear = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public override string ToString()
        {
            return "Name: " + name + " " + "Model: " + model + " " +"ModelYear: " + ModelYear + " " + "Color: " + color + " ";
        }
    }
}
