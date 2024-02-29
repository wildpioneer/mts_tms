using BDD_Project.Core;
using BDD_Project.Helpers.Configuration;
using NUnit.Framework;

namespace AdvancedSpecFlowProject.Steps;

[Binding]
public class SettingsSteps : BaseSteps
{
    public SettingsSteps(Browser browser) : base(browser)
    {
    }

    [Then(@"settings page is opened")]
    public void IsSettingsPageOpened()
    {
        Driver.Navigate().GoToUrl(Configurator.AppSettings.URL + 
                                  "index.php?/admin/site_settings");
        Assert.That(Driver.Title, Is.EqualTo("Site Settings - TestRail"));
    }

}