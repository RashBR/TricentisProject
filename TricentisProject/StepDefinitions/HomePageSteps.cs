using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TricentisProject.PageObjectModel;
using TechTalk.SpecFlow;

namespace TricentisProject.StepDefinitions
{
    [Binding]
    public sealed class HomePageSteps : UICommonSelenium
    {
        public List<string> actualIconList = new List<string>();

        [Given(@"the user in the is the application")]
        [When(@"the user in the is the application")]
        public void WhenTheUserInTheIsTheApplication()
        {
            CommonPage.HomePage.NavigateToApplication();
        }

        [Given(@"a product is selected")]
        public void GivenAProductIsSelected()
        {
            CommonPage.HomePage.SelectedProduct();
        }

        [Given(@"the user in Jewelry page")]
        public void GivenTheUserInJewelryPage()
        {
            CommonPage.HomePage.JewelrySection();
        }

        [Given(@"the user clicks on ShoppingCart")]
        public void GivenTheUserClicksOnShoppingCart()
        {
            CommonPage.HomePage.ShoppingCart();
        }


        [Then(@"the header in the homepage is '([^']*)'")]
        public void ThenTheHeaderInTheHomepageIs(string expectedHeader)
        {
            string actualHeader = CommonPage.HomePage.HomePageheader();
            Assert.That(actualHeader, Is.EqualTo(expectedHeader), "The headers different");
        }

        [Then(@"the following group of icons is displayed")]
        public void ThenTheFollowingGroupOfIconsIsDisplayed(Table table)
        {
            
            actualIconList =  CommonPage.HomePage.IconsValidation();
            var expectedIconList = table.Rows.Select(x=>x.Values.FirstOrDefault()).ToList();
            var IconsExpectedNotAppearing = expectedIconList.Where(expected => !actualIconList.Any(actual => expected.Contains(actual))).ToList();
            //Assert.That(actualIconList, Is.EqualTo(expectedIconList), "Home Screen doesn't contain all the icons");
           Assert.That(IconsExpectedNotAppearing, Is.Empty, "Home Screen doesn't contain all the icons");
        }

            
         

       

    }
}
