using OpenQA.Selenium;

namespace BDD_Project.Pages
{
    public class DashboardPage(IWebDriver? driver, bool openByURL = false) : BasePage(driver, openByURL)
    {
        private const string END_POINT = "index.php?/dashboard";
        
        // Описание элементов
        private static readonly By SidebarProjectsAddButtonBy = By.Id("sidebar-projects-add");
        
        protected override bool EvaluateLoadedStatus()
        {
            try
            {
                return SidebarProjectsAddButton.Displayed;
            }
            catch (Exception)
            {
                return false;
            }
        }
        
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public IWebElement SidebarProjectsAddButton => WaitsHelper.WaitForExists(SidebarProjectsAddButtonBy);
        
        public List<string> GetProjectIDsFromTable()
        {
            return Driver.FindElements(By.CssSelector(".row.project[id]")).Select(element => element.GetAttribute("id").Split("-")[1]).ToList();
        }
    }
}