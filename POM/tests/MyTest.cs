
using NUnit.Framework;
using Webtekno;

[TestFixture]
public class MyTest : BaseTest
{
    HomePage homePage = new HomePage();
    CategoryPage categoryPage = new CategoryPage();

    [Test]
    public void myTest()
    {
        homePage.closeNotification();
        homePage.closeCookie();

        homePage.chooseMenu("kategoriler");
        homePage.chooseMenuItem("Yazılım");

        categoryPage.verifyResult("Yazılım");
        categoryPage.filterTimeline("video");
        categoryPage.verifyUrl("video");
    }
}