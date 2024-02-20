namespace BuilderPattern.Models;

public class Project
{
    public int ID { get; }
    public string ProjectName { get; }
    public string Announcement { get; }
    public bool Flag { get; }
    public int ProjectType { get; }
    public DateTime CreateDate { get; }
    
    // Приватный конструктор для создания объекта проекта
    private Project(int id, string projectName, string announcement, bool flag, int projectType, DateTime createDate)
    {
        ID = id;
        ProjectName = projectName;
        Announcement = announcement;
        Flag = flag;
        ProjectType = projectType;
        CreateDate = createDate;
    }
    
    // Вложенный Builder класс для создания объекта Project
    public class Builder
    {
        private int ID { get; set; }
        private string ProjectName { get; set; }
        private string Announcement { get; set; }
        private bool Flag { get; set; }
        private int ProjectType { get; set; }
        private DateTime CreateDate { get; set; }

        // Методы для установки значений полей и возвращения Builder'а для дальнейшего цепочного вызова
        public Builder SetProjectName(string projectName)
        {
            ProjectName = projectName;
            return this;
        }

        public Builder SetID(int id)
        {
            ID = id;
            return this;
        }

        public Builder SetAnnouncement(string announcement)
        {
            Announcement = announcement;
            return this;
        }

        public Builder SetFlag(bool flag)
        {
            Flag = flag;
            return this;
        }
        
        public Builder SetCreateDate(DateTime date)
        {
            CreateDate = date;
            return this;
        }

        public Builder SetProjectType(int type)
        {
            ProjectType = type;
            return this;
        }

        // Метод для построения объекта Project
        public Project Build()
        {
            // Валидация полей
            if (string.IsNullOrEmpty(ProjectName))
                throw new InvalidOperationException("Name must be set");
            if (ID == 0)
                throw new InvalidOperationException("ID must be set");

            return new Project(ID, ProjectName, Announcement, Flag, ProjectType, CreateDate);
        }
    }
}