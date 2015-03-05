using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class City
    {
        private string cityName { get; set; }
        private int cityId { get; set; }   
        public City(int id, string name)
        {
            cityId = id;
            cityName = name;
        }
        public string GetCityName()
        {
            return cityName;
        }
    } 
}
