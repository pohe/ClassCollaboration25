using ClassCollaboration25;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollaboration25
{
    public class Car
    {
        // Instance fields
        private string _modelName;
        private NavigationSystem _theNavigationSystem;
        private Engine _theEngine;
        private Wheel _wheel;
        // Properties
        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }
        public NavigationSystem NavigationSystem
        {
            get
            {
                return _theNavigationSystem;
            }
        }

        public Wheel Wheel
        {
            get { return _wheel; }
        }
        public double Co2FromProduction
        {
            get; set;
        }
        public Engine TheEngine
        {
            get { return _theEngine; }
        }

        public Car(string modelName, Wheel wheel)
        {
            _modelName = modelName;
            _theEngine = new Engine(200, "Gasoline");
            _theNavigationSystem = new NavigationSystem("Google navi", "Atari", "GPR", 300);
            _wheel = wheel;
            Co2FromProduction = 500;

        }

        public void Start()
        {
            _theEngine.Start();
            _theNavigationSystem.Start();
        }

        public void ChangeWheels(Wheel aWheel)
        {
            _wheel = aWheel;
        }

        public double CalCo2Emission()
        {
            return _theEngine.Co2FromProduction + _theNavigationSystem.Co2FromProduction + _wheel.Co2FromProduction + this.Co2FromProduction;
            
        }

        public override string ToString()
        {
            return $"Modelnavn {_modelName}  \n\tengine: { _theEngine } \n\tnavigationsystem {_theNavigationSystem.ToString()} \n\twheel {_wheel.ToString()}   ";
        }

    }
}
