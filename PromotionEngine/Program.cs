using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            UnitPrice objUnitPrice = new UnitPrice();

            SKUs obj1 = new SKUs();
            obj1.SKUId = 'A';
            obj1.quantity = 3;

            SKUs obj2 = new SKUs();
            obj2.SKUId = 'B';
            obj2.quantity = 5;

            SKUs obj3 = new SKUs();
            obj3.SKUId = 'C';
            obj3.quantity = 1;

            SKUs obj4 = new SKUs();
            obj4.SKUId = 'D';
            obj4.quantity = 1;

            //SKUs obj5 = new SKUs();
            //obj5.SKUId = 'E';
            //obj5.quantity = 2;

            //SKUs obj6 = new SKUs();
            //obj6.SKUId = 'F';
            //obj6.quantity = 5;

            Cart objCart = new Cart();
            objCart.objSKUs.Add(obj1);
            objCart.objSKUs.Add(obj2);
            objCart.objSKUs.Add(obj3);
            objCart.objSKUs.Add(obj4);
            //objCart.objSKUs.Add(obj5);
            //objCart.objSKUs.Add(obj6);

            double cartValue = Cart.CalculateCartValue(objCart, objUnitPrice);
            #endregion
        }
    }
}
