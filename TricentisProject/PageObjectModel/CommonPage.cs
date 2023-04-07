using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TricentisProject.PageObjectModel
{
    public class CommonPage : UICommonActions
    {
        private static T GetPage<T>() where T : new() => new T();
        public static HomePage HomePage => GetPage<HomePage>();
        public static LoginPage LoginPage => GetPage<LoginPage>();
        public static LogoutPage LogoutPage => GetPage<LogoutPage>();
        public static JewelryPage JewelryPage => GetPage<JewelryPage>(); 
        public static ShoppingCartPage ShoppingCartPage => GetPage<ShoppingCartPage>();
        public static CheckoutPage CheckoutPage => GetPage<CheckoutPage>();
    }
}
