using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResourcesLibrary.DataClasses
{
    public class Project
    {
        private string projectName { get; set; }
        private int projectId { get; set; }

        public Project(int id, string name)
        {
            projectId = id;
            projectName = name;
        }
        public string GetProjectName()
        {
            return projectName;
        }
    }
}
