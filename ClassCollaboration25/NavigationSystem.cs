using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassCollaboration25
{
    public class NavigationSystem
    {
        #region instance field
        private string _description;
        #endregion
        #region properties
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string Producer { get; set; }
        public string DisplayType { get; set; }
        public double Co2FromProduction { get; }
        #endregion
        #region constructor
        public NavigationSystem(string givenDescription, string givenProducer, string givenDisplayType, double givenCo2FromProduction)
        {
            _description = givenDescription;
            Producer = givenProducer;
            DisplayType = givenDisplayType;
            Co2FromProduction = givenCo2FromProduction;
        }

        public override string ToString()
        {
            return $"_description {_description} Producer  {Producer} DisplayType {DisplayType}  Co2FromProduction {Co2FromProduction} ";
        }  
        #endregion

        public void Start()
        {
            Console.WriteLine("Navigationsystem started");
        }
    }
}
