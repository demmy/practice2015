using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class UniqueItem
    {
        public Guid Id { get; private set; }

        public UniqueItem()
        {
            Id = Guid.NewGuid();
        }
    }
}
