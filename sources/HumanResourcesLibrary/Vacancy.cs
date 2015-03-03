using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Vacancy
    {
        public Vacancy()
        {
            ProjectId = 0;
            CityId = 0;
            ResponsiblePersonId = 0;
            Name = System.String.Empty;
            DateStart = new DateTime();
            DateFinish = new DateTime();
            TypeEmployment = TypeEmployment.FullEmployment;
            LevelEnglish = LevelEnglish.Beginner;
            Status = Status.Open;
            Description = System.String.Empty;
            ListComment = new Dictionary<DateTime, string>();
        }

        public Vacancy(int projectId, int cityId, int responsiblePersonId, string name, DateTime dateStart, DateTime dateFinish, TypeEmployment typeEmployment, LevelEnglish levelEnglish, Status status, string description, Dictionary<DateTime, string> listComment, int vacancyId = -1)
        {
            this.ProjectId = projectId;
            this.CityId = cityId;
            this.ResponsiblePersonId = responsiblePersonId;
            this.Name = name;
            this.DateStart = dateStart;
            this.DateFinish = dateFinish;
            this.TypeEmployment = typeEmployment;
            this.LevelEnglish = levelEnglish;
            this.Status = status;
            this.Description = description;
            this.ListComment = listComment;
            this.VacancyId = vacancyId;
        }

        public int VacancyId { get; private set; }

        public int ProjectId{ get; set; }

        public int CityId { get; set; }

        public int ResponsiblePersonId { get; set; }

        public string Name { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateFinish { get; set; }

        public TypeEmployment TypeEmployment { get; set; }

        public LevelEnglish LevelEnglish { get; set; }

        public Status Status { get; set; }

        public string Description { get; set; }

        public Dictionary<DateTime, string> ListComment { get; set; }
    }
}
