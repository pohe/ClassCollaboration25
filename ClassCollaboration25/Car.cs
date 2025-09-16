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
        public void Start()
        {

        }
        public void ChangeWheels(Wheel aWheel)
        {
        }

        public double CalCo2Emission()
        {
            return 0;
        }

    }
}
