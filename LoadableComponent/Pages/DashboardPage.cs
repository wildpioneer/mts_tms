using OpenQA.Selenium;

namespace PageFactory.Pages
{
    public class DashboardPage(IWebDriver? driver) : BasePage(driver)
    {
        private static string END_POINT = "index.php?/dashboard";
        
        // Описание элементов
        private static readonly By SidebarProjectsAddButtonBy = By.Id("sidebar-projects-add");

        // Инициализация класса
        protected override string GetEndpoint()
        {
            return END_POINT;
        }

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
        
        // Методы
        public IWebElement SidebarProjectsAddButton => Driver.FindElement(SidebarProjectsAddButtonBy);
    }
}