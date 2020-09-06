using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionType_NA : IPromotions //Class for specifying SKU Ids on which no promotion is applicable
    {
        List<string> lstPromoNA = new List<string>();

        public PromotionType_NA(string strSKUs)
        {
            lstPromoNA = strSKUs.Split(',').ToList<string>();
        }

        public double ApplyPromotion(Cart objCart, UnitPrice objUnitPrice, double cartValue)
        {
            double promotionValue = 0;

            foreach (SKUs obj in objCart.objSKUs)
            {
                if (lstPromoNA.Contains(obj.SKUId.ToString()))
                {
                    promotionValue += obj.quantity * objUnitPrice.dictUnitPrice[obj.SKUId];
                }
            }

            return cartValue + promotionValue;
        }
    }
}
