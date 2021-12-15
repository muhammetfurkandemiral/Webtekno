using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using Webtekno;

public class CategoryPage : BaseTest
{
    SelectElement selectElement;
    public CategoryPage()
    {
        PageFactory.InitElements(Driver.get(), this);
    }

    [FindsBy(How = How.TagName, Using = "h1")]
    private IWebElement resultText;

    [FindsBy(How = How.Id, Using = "timeline-filter")]
    private IWebElement filter;

    public void verifyResult(string result)
    {
        string expected = result.ToLower();
        string actual = resultText.Text.ToLower();
        Assert.AreEqual(actual, expected);
    }
    public void filterTimeline(string filterText) {
        filter.Click();
        string option = filterText.ToUpper();
        selectElement = new SelectElement(filter);
        selectElement.SelectByText(option);
    }

    public void verifyUrl(string text)
    {
        string expected = text.ToLower();
        string actual = Driver.get().Url;
        Assert.IsTrue(actual.Contains(expected));
    }

}