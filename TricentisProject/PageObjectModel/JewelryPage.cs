using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisProject.PageObjectModel
{
    public class JewelryPage : CommonPage
    {
        #region Locators
        string Product = "xpath=//div[@class='details']//a[text()='Black & White Diamond Heart']//following::input[@type = 'button' ]";
        #endregion

        public JewelryPage SelectJewelryProduct()
        {
            Click(Product, 3, ClickType.Click);
            return new JewelryPage();
        }
            
    }
}
