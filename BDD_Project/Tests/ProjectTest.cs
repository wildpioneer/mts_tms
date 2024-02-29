using BDD_Project.Models;

namespace BDD_Project.Tests;

public class ProjectTest : BaseTest
{
    [Test]
    public void SuccessfulAddProjectTest()
    {
        _navigationSteps.SuccessfulLogin(Admin);

        Project expectedProject = new Project()
        {
            ProjectName = "WP Test 01",
            Announcement = "Test Details",
            Flag = false,
            ProjectType = 1
        };

        Assert.That(_projectSteps.AddProject(expectedProject).SuccessMessage.Text.Trim(),
            Is.EqualTo("Successfully added the new project."));
    }
}