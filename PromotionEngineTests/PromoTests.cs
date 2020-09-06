using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineTests
{
    [TestClass]
    public class PromoTests
    {
        [TestMethod] //Test case to cover scenario 1
        public void TestMethod1()
        {
            UnitPrice objUnitPrice = new UnitPrice();

            SKUs obj1 = new SKUs();
            obj1.SKUId = 'A';
            obj1.quantity = 1;

            SKUs obj2 = new SKUs();
            obj2.SKUId = 'B';
            obj2.quantity = 1;

            SKUs obj3 = new SKUs();
            obj3.SKUId = 'C';
            obj3.quantity = 1;

            Cart objCart = new Cart();
            objCart.objSKUs.Add(obj1);
            objCart.objSKUs.Add(obj2);
            objCart.objSKUs.Add(obj3);

            Assert.AreEqual(100, Cart.CalculateCartValue(objCart, objUnitPrice));
        }

        [TestMethod] //Test case to cover scenario 2
        public void TestMethod2()
        {
            UnitPrice objUnitPrice = new UnitPrice();

            SKUs obj1 = new SKUs();
            obj1.SKUId = 'A';
            obj1.quantity = 5;

            SKUs obj2 = new SKUs();
            obj2.SKUId = 'B';
            obj2.quantity = 5;

            SKUs obj3 = new SKUs();
            obj3.SKUId = 'C';
            obj3.quantity = 1;

            Cart objCart = new Cart();
            objCart.objSKUs.Add(obj1);
            objCart.objSKUs.Add(obj2);
            objCart.objSKUs.Add(obj3);

            Assert.AreEqual(370, Cart.CalculateCartValue(objCart, objUnitPrice));
        }

        [TestMethod] //Test case to cover scenario 3
        public void TestMethod3()
        {
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

            Cart objCart = new Cart();
            objCart.objSKUs.Add(obj1);
            objCart.objSKUs.Add(obj2);
            objCart.objSKUs.Add(obj3);
            objCart.objSKUs.Add(obj4);

            Assert.AreEqual(280, Cart.CalculateCartValue(objCart, objUnitPrice));
        }
    }
}
