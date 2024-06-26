using System.Diagnostics;
using Bogus;
using TestRail.Fakers;
using TestRail.Models;

namespace TestRail.Tests;

public class ProjectFakerApiTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project = null!;
    private static Faker<Project> Project => new ProjectFakerApi();
    
    [Test]
    [Order(1)]
    [Category("Smoke")]
    [Category("Regression")]
    public void AddProjectTest()
    {
        _project = Project.Generate();

        _project = ProjectService!.AddProject(_project).Result;
        _logger.Info(_project.ToString());
    }

    [Test]
    [Order(2)]
    [Category("Smoke")]
    [Category("Regression")]
    public void GetProjectTest()
    {
        _logger.Info(ProjectService?.GetProject(_project.Id.ToString()).Result.ToString());
    }
    
    [Test]
    [Order(3)]
    [Category("Smoke")]
    public void DeleteProjectTest()
    {
        Debug.Assert(ProjectService != null, nameof(ProjectService) + " != null");
        _logger.Info(ProjectService.DeleteProject(_project.Id.ToString()));
    }
}