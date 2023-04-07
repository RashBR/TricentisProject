using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisProject.PageObjectModel
{
    public sealed class CheckoutPage : CommonPage
    {
        #region Locator
        string PickupFromStore = "xpath=//input[@id='PickUpInStore']";
        string BillingAddressContinue = "xpath=//div[@id='checkout-step-billing']//child::input[@type='button']";
        string ShippingAddressContinue = "xpath=//div[@id='shipping-buttons-container']//child::input[@type='button']";
        string COD = "xpath=//input[@id='paymentmethod_0']";
        string PaymentContinueBtn = "xpath=//div[@id='payment-method-buttons-container']//input[@type='button']";
        string PaymentInfoBtn = "xpath=//div[@id='payment-info-buttons-container']//input[@type='button']";
        string ConfirmOrderBtn = "xpath=//div[@id='confirm-order-buttons-container']//input[@type='button']";
        string ConfirmMesage = "xpath=//div[@class= 'title']//strong";
        string OrderNumber = "xpath=//ul[@class= 'details']//li";
        //string AfterOrderConfirmContinue = "xpath=//div[@class='buttons']//input";
        #endregion


        public CheckoutPage SelectBillingAddress()
        {
            Click(BillingAddressContinue, 3, ClickType.Click);
            return new CheckoutPage();
        }

        public CheckoutPage SelectPickupFromStore()
        {
            Click(PickupFromStore, 3, ClickType.Click);
            return new CheckoutPage();
        }

        public CheckoutPage SelectShippingAddress()
        {
            Click(ShippingAddressContinue, 3, ClickType.Click);
            return new CheckoutPage();
        }

        public CheckoutPage SelectCOD()
        {
            Click(COD, 3, ClickType.Click);
            return new CheckoutPage();
        }

        public CheckoutPage SelectPaymentToContinue()
        {
            Click(PaymentContinueBtn, 3, ClickType.Click);
            return new CheckoutPage();
        }

        public CheckoutPage SelectPaymentInfoToContinue()
        {
            Click(PaymentInfoBtn, 3, ClickType.Click);
            return new CheckoutPage();
        }
        public CheckoutPage ConfirmOrder()
        {
            Click(ConfirmOrderBtn, 3, ClickType.Click);
            return new CheckoutPage();
        }

        public string OrderConfirmationMessage()
        {
            return GetElementText(ConfirmMesage, 3);
        }

        public string OrderConfirmationNumber()
        {
            return GetElementText(OrderNumber, 3);
        }
    }
}
