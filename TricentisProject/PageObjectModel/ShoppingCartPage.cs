using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisProject.PageObjectModel
{
    public sealed class ShoppingCartPage : CommonPage
    {
        #region Locator
        string CountryUS = "xpath=//select[@id ='CountryId']//option[text() ='United States']";
        string CountrySelection = "xpath=//select[@id ='CountryId']";
        string ConditionalCheckbox = "xpath=//input[@id='termsofservice']";
        string CheckoutBtn = "xpath=//button[@id='checkout']";

        #endregion

        
        public ShoppingCartPage SelectConditionalCheckBox()
        {
            Click(ConditionalCheckbox, 3, ClickType.Click);
            return new ShoppingCartPage();
        }

        public ShoppingCartPage Checkout()
        {
            Click(CheckoutBtn, 3, ClickType.Click);
            return new ShoppingCartPage();
        }

    }
}
