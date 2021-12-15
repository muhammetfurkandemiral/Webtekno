
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Webtekno;

public class HomePage : BaseTest
{

    public HomePage()
    {
        PageFactory.InitElements(Driver.get(), this);
    }
    [FindsBy(How = How.Id, Using = "onesignal-slidedown-cancel-button")]
    private IWebElement notification;

    [FindsBy(How = How.LinkText, Using = "ANLADIM")]
    private IWebElement cookie;

    public void closeNotification()
    {
        notification.Click();
    }
    public void closeCookie()
    {
        cookie.Click();
    }
    public void chooseMenu(string menu)
    {
        string selectMenu = menu.ToUpper();
        Driver.get().FindElement(By.LinkText(selectMenu)).Click();
    }

    public void chooseMenuItem(string menuItem)
    {
        string selectMenuItem = menuItem;
        Driver.get().FindElement(By.LinkText(selectMenuItem)).Click();

    }

   
}