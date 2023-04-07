using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisProject.PageObjectModel
{
    public sealed class HomePage : CommonPage    
    {
        #region Locators
        string imgtitle = "xpath=//img[@alt = 'Tricentis Demo Web Shop']";
        string icons = "xpath=//div[@class = 'header-menu']//ul[@class = 'top-menu']/li/a";
        string Homepageheader = "xpath=//h2[contains(text(), ' Welcome to our store')]";
        string ProductSelected = "xpath=//div[@class = 'details']//a[text()='Computing and Internet']//following::input[@type = 'button' ][1]";
        // "//div[@class='details']//a[text() = 'Simple Computer']//following::input[@type = 'button' ]";
        string JewelryBtn = "xpath=//ul[@class= 'top-menu']//descendant::a[contains(text(),'Jewelry')]";
        string ShoppingCartBtn = "xpath=//li[@id='topcartlink']//a";
        #endregion


        public List<string> IconsValidation()
        {
            return GetElementListTexts(icons, 3);
        }

        public string HomePageheader()
        {
            return GetElementText(Homepageheader);
        }

        public HomePage SelectedProduct()
        {
            Click(ProductSelected, 3, ClickType.Click);
            return new HomePage();
        }

        public HomePage JewelrySection()
        {
            Click(JewelryBtn, 3, ClickType.Click);
            return new HomePage();
        }

        public HomePage ShoppingCart()
        {
            Click(ShoppingCartBtn, 3, ClickType.Click);
            return new HomePage();
        }
    }

    
}
