using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TricentisProject.PageObjectModel;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace TricentisProject.StepDefinitions
{ 
    [Binding]
    public sealed class PaymentWorkflowSteps : UICommonSelenium
    {
        [Given(@"a jewelry product is selected")]
        public void GivenAJewelryProductIsSelected()
        {
            CommonPage.JewelryPage.SelectJewelryProduct();
        }

        [Given(@"the user click's on checkout")]
        public void GivenTheUserClicksOnCheckout()
        {
            CommonPage.ShoppingCartPage.SelectConditionalCheckBox();
            CommonPage.ShoppingCartPage.Checkout();
        }

        [Given(@"the user selects In Shop Pickup")]
        public void GivenTheUserSelectsInShopPickup()
        {
            CommonPage.CheckoutPage.SelectBillingAddress();
            CommonPage.CheckoutPage.SelectPickupFromStore();
            CommonPage.CheckoutPage.SelectShippingAddress();
        }

        [When(@"the Payment method is selected as Cash on Delivery")]
        public void WhenThePaymentMethodIsSelectedAsCashOnDelivery()
        {
            CommonPage.CheckoutPage.SelectCOD();
            CommonPage.CheckoutPage.SelectPaymentToContinue();
            CommonPage.CheckoutPage.SelectPaymentInfoToContinue();
        }

        [When(@"the user confirms the order")]
        public void WhenTheUserConfirmsTheOrder()
        {
            CommonPage.CheckoutPage.ConfirmOrder();
        }

        [Then(@"the confirmation message is '([^']*)'")]
        public void ThenTheConfirmationMessageIs(string expectedMessage)
        {
            string actualMessage = CommonPage.CheckoutPage.OrderConfirmationMessage();
            Assert.That(actualMessage, Is.EqualTo(expectedMessage), "");
        }

        [Then(@"the new order number is created")]
        public void ThenTheNewOrderNumberIsCreated()
        {
            string actualMessage = CommonPage.CheckoutPage.OrderConfirmationNumber();
            Assert.That(actualMessage, Is.Not.Null, "");
        }


    }
}
