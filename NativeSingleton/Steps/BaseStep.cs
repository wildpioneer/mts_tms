using NativeSingleton.Core;
using NativeSingleton.Pages;
using NativeSingleton.Pages.ProjectPages;
using OpenQA.Selenium;

namespace NativeSingleton.Steps;

public class BaseStep
{
    protected LoginPage? LoginPage { get; set; }
    protected DashboardPage? DashboardPage { get; set; }
    protected AddProjectPage? AddProjectPage { get; set; }
}