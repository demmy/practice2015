﻿using System;
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
            copy.Project = this.Project;
            copy.City = this.City;
            copy.Status = this.Status;
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
        public Vacancy(string name, Project project, City city, Status status)
        {
            Title = name;
            Project = project.GetProjectName();
            City = city.GetCityName();
            Status = status;
        }
        public Vacancy(Project project, City city, ResponsiblePerson responsiblePerson, string name, DateTime dateStart, DateTime dateFinish, TypeEmployment typeEmployment, LevelEnglish levelEnglish, Status status, string description, Dictionary<DateTime, string> listComment, int vacancyId = -1)
        {
            Project = project.GetProjectName();
            City = city.GetCityName();
            ResponsiblePersons = responsiblePerson.GetResponsiblePersonName();
            Title = name;
            DateStart = dateStart;
            DateFinish = dateFinish;
            TypeEmployment = typeEmployment;
            LevelEnglish = levelEnglish;
            Status = status;
            Description = description;
            ListComment = listComment;
            VacancyId = vacancyId;
        }

        public int VacancyId { get; private set; }

        public string Project { get; set; }

        public string City { get; set; }

        public string ResponsiblePersons { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateFinish { get; set; }

        public TypeEmployment TypeEmployment { get; set; }

        public LevelEnglish LevelEnglish { get; set; }

        public Status Status { get; set; }

        public string Description { get; set; }

        public Dictionary<DateTime, string> ListComment { get; set; }
    }
}
