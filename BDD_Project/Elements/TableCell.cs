using OpenQA.Selenium;

namespace BDD_Project.Elements;

public class TableCell
{
    private UIElement _uiElement;
    
    public TableCell(UIElement uiElement)
    {
        _uiElement = uiElement;
    }

    public UIElement GetLink() => _uiElement.FindUIElement(By.TagName("a"));
    public string Text => _uiElement.Text;
}