using System.Collections.ObjectModel;
using System.Drawing;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Wrappers.Helpers;
using Wrappers.Helpers.Configuration;

namespace Wrappers.Wrappers
{
    public class UIElement : IWebElement
    {
        private IWebElement _webElementImplementation;
        private Actions _actions;
        protected WaitsHelper _waitHelper;
        
        private UIElement(IWebDriver webDriver)
        {
            _waitHelper = new WaitsHelper(webDriver, TimeSpan.FromSeconds(Configurator.WaitsTimeout));
            _actions = new Actions(webDriver);
        }

        public UIElement(IWebDriver webDriver, By @by) : this(webDriver)
        {
            _webElementImplementation = _waitHelper.WaitForExists(by);
        }

        public UIElement(IWebDriver webDriver, IWebElement webElement)  : this(webDriver)
        {
            _webElementImplementation = webElement;
        }
        
        public IWebElement FindElement(By @by)
        {
            return _webElementImplementation.FindElement(@by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By @by)
        {
            return _webElementImplementation.FindElements(@by);
        }

        public void Clear()
        {
            _webElementImplementation.Clear();
        }

        public void SendKeys(string text)
        {
            _webElementImplementation.SendKeys(text);
        }

        public void Submit()
        {
            _webElementImplementation.Submit();
        }

        public void Click()
        {
            _webElementImplementation.Click();
        }

        public string GetAttribute(string attributeName)
        {
            return _webElementImplementation.GetAttribute(attributeName);
        }

        public string GetDomAttribute(string attributeName)
        {
            throw new NotImplementedException();
        }

        public string GetDomProperty(string propertyName)
        {
            return _webElementImplementation.GetDomProperty(propertyName);
        }
        
        public string GetCssValue(string propertyName)
        {
            return _webElementImplementation.GetCssValue(propertyName);
        }

        public ISearchContext GetShadowRoot()
        {
            throw new NotImplementedException();
        }

        public void Hover()
        {
            _actions.MoveToElement(_webElementImplementation).Build().Perform();
        }

        public string TagName => _webElementImplementation.TagName;

        public string Text => _webElementImplementation.Text;

        public bool Enabled => _webElementImplementation.Enabled;

        public bool Selected => _webElementImplementation.Selected;

        public Point Location => _webElementImplementation.Location;

        public Size Size => _webElementImplementation.Size;

        public bool Displayed => _webElementImplementation.Displayed;
    }
}