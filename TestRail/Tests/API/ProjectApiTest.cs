using System.Diagnostics;
using Bogus;
using NLog;
using NUnit.Framework;
using TestRail.Fakers;
using TestRail.Models;

namespace TestRail.Tests;

public class ProjectApiTest : BaseApiTest
{
    private readonly Logger _logger = LogManager.GetCurrentClassLogger();
    private Project _project = null!;
    
    [Test]
    [Order(1)]
    [Category("Smoke")]
    [Category("Regression")]
    public void AddProjectTest()
    {
        _project = new Project
        {
            Name = "WP Test 1",
            Announcement = "Some description!!!",
            ShowAnnouncement = true,
            SuiteMode = 1
        };

        var actualProject = ProjectService!.AddProject(_project);
        _project = actualProject.Result;
        _logger.Info(_project.ToString());
    }

    [Test]
    [Order(2)]
    [Category("Regression")]
    public void GetProjectTest()
    {
        _logger.Info(ProjectService?.GetProject(_project.Id.ToString()).Result.ToString());
    }

    public void GetProjectsTest()
    {
        var projects = ProjectService?.GetProjects().Result;
        _logger.Info(projects.Size);
        foreach (var project in projects.ProjectsList)
        {
            _logger.Info(project.ToString);
        }
    }

    [Test]
    [Order(4)]
    [Category("Regression")]
    public void UpdateAddProjectTest()
    {
        var project = new Project
        {
            Id = _project.Id,
            Name = "WP Test 1 Updated",
            Announcement = "Some description!!! Updated",
            ShowAnnouncement = false,
            SuiteMode = 2
        };

        var actualProject = ProjectService!.UpdateProject(project);
        project = actualProject.Result;
        _logger.Info(project.ToString());
    }
    
    [Test]
    [Order(5)]
    [Category("Regression")]
    public void DeleteProjectTest()
    {
        Debug.Assert(ProjectService != null, nameof(ProjectService) + " != null");
        _logger.Info(ProjectService.DeleteProject(_project.Id.ToString()));
    }
}