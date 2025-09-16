using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollaboration25
{
    public class Wheel
    {
        private double _co2FromProduction;

        public int Year { get; private  set;  }
        public string Type { get; set; }
        public double Co2FromProduction
        {
            get { return _co2FromProduction; }
            set { _co2FromProduction = value; }
        }
        public Wheel(double co2FromProduction, int year, string type)
        {
            _co2FromProduction = co2FromProduction;
            Year = year;
            Type = type;
        }

        public override string ToString()
        {
            return $"Type {Type} Year  {Year} co2FromProduction {_co2FromProduction}  ";
        }

        
    }

}
