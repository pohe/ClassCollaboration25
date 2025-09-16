using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollaboration25
{
    public class Engine
    {
        private int _hp;

        public string Fuel { get; set; }
        public int HP
        {

            get { return _hp; }
        }

        public double Co2FromProduction { get; set; }

        public Engine(int hp, string fuel)
        {
            Co2FromProduction = 200;
            _hp = hp;
            Fuel = fuel;
        }

        public void Start()
        {
            Console.WriteLine("Engine has started.");
        }
        public override string ToString()
        {
            string value = " Fuel " + Fuel + "HP" +  _hp + "CO2fromProduction " + Co2FromProduction;
            return value;
        }


    }
}
