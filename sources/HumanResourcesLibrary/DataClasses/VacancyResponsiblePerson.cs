using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class ResponsiblePerson
    {
        private string responsiblePersonName { get; set; }
        private int responsiblePersonId { get; set; }
        public ResponsiblePerson(int id, string name)
        {
            responsiblePersonId = id;
            responsiblePersonName = name;
        }
        public string GetResponsiblePersonName()
        {
            return responsiblePersonName;
        }
    }
}
