using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class Vacancy : UniqueItem, IDeepCopy<Vacancy>
    {
        public string Title { get; set; }

        public Vacancy CreateDeepCopy()
        {
            Vacancy copy = new Vacancy();
            copy.Title = this.Title;
            return copy;
        }
    }
}
