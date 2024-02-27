using OpenQA.Selenium;

namespace NativeSingleton.Pages
{
    public class DashboardPage(bool openByURL) : BasePage(openByURL)
    {
        private const string END_POINT = "index.php?/dashboard";
        
        // Описание элементов
        public DashboardPage() : this(false)
        {
        }

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
    }
}