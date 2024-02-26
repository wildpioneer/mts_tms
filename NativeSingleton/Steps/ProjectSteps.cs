using NativeSingleton.Models;
using NativeSingleton.Pages.ProjectPages;

namespace NativeSingleton.Steps;

public class ProjectSteps : BaseStep
{
    public ProjectsPage AddProject(Project project)
    {
        AddProjectPage = new AddProjectPage(true);
        
        AddProjectPage.NameInput.SendKeys(project.ProjectName);
        AddProjectPage.AnnouncementTextArea.SendKeys(project.Announcement);
        AddProjectPage.TypeRadioButton.SelectByIndex(project.ProjectType);
        AddProjectPage.AddButton.Click();
        
        return new ProjectsPage();
    }
}