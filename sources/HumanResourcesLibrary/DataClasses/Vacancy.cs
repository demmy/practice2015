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

        public string Project { get; set; }

        public string City { get; set; }

        public string ResponsiblePerson { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateFinish { get; set; }

        public TypeEmployment TypeEmployment { get; set; }

        public LevelEnglish LevelEnglish { get; set; }

        public Status Status { get; set; }

        public string Skills { get; set; }

        public string Description { get; set; }

        public Dictionary<DateTime, string> ListComment { get; set; }
		
        public Vacancy CreateDeepCopy()
        {
            Vacancy copy = new Vacancy();
            copy.Title = this.Title;
            copy.Project = this.Project;
            copy.City = this.City;
            copy.Status = this.Status;
            copy.Skills = this.Skills;
            copy.ResponsiblePerson = this.ResponsiblePerson;
            copy.LevelEnglish = this.LevelEnglish;
            copy.TypeEmployment = this.TypeEmployment;
            copy.DateFinish = this.DateFinish;
            copy.DateStart = this.DateStart;
            copy.Description = this.Description;
            return copy;
        }
		
        public Vacancy()
        {
            /*ProjectId = 0;
            CityId = 0;
            ResponsiblePersonId = 0;
            Title = System.String.Empty;
            DateStart = new DateTime();
            DateFinish = new DateTime();
            TypeEmployment = TypeEmployment.FullEmployment;
            LevelEnglish = LevelEnglish.Beginner;
            Status = Status.Open;
            Description = System.String.Empty;
            ListComment = new Dictionary<DateTime, string>();*/
        }
		
        public Vacancy(string name, Project project, City city, Status status, ResponsiblePerson responsiblePerson, DateTime dateStart, DateTime dateFinish, 
            TypeEmployment typeEmployment, LevelEnglish levelEnglish, string skills, string description)
        {
            Project = project.GetProjectName();
            City = city.GetCityName();
            ResponsiblePerson = responsiblePerson.GetResponsiblePersonName();
            Title = name;
            DateStart = dateStart;
            DateFinish = dateFinish;
            TypeEmployment = typeEmployment;
            LevelEnglish = levelEnglish;
            Status = status;
            Skills = skills;
            Description = description;
            //ListComment = listComment;
            //VacancyId = vacancyId;
        }
    }
}
