using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Cart // Class to hold SKU Ids with quantity and calculate total cart value post applying all active promotions
    {
        public List<SKUs> objSKUs = new List<SKUs>();

        public static double CalculateCartValue(Cart objCart, UnitPrice objUnitPrice)
        {
            double cartValue = 0;

            ActivePromotions objActivePromos = new ActivePromotions();

            foreach (var promo in objActivePromos.lstPromotions)
            {
                cartValue = promo.ApplyPromotion(objCart, objUnitPrice, cartValue);
            }

            return cartValue;
        }
    }
}
