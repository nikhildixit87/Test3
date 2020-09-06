using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionType_twoDifferentItems : IPromotions //Class for specifying promotion details for two different SKU IDs with total value
    {
        public char _SKU1;
        public char _SKU2;
        public double _clubValue;

        public PromotionType_twoDifferentItems(char SKU1, char SKU2, double clubValue)
        {
            _SKU1 = SKU1;
            _SKU2 = SKU2;
            _clubValue = clubValue;
        }

        public double ApplyPromotion(Cart objCart, UnitPrice objUnitPrice, double cartValue)
        {
            double promotionValue = 0;

            int quantitySKU1 = 0;
            int quantitySKU2 = 0;

            foreach (SKUs obj in objCart.objSKUs)
            {
                if (obj.SKUId == _SKU1)
                    quantitySKU1 = obj.quantity;
                if (obj.SKUId == _SKU2)
                    quantitySKU2 = obj.quantity;
            }

            if (quantitySKU1 == quantitySKU2)
            {
                promotionValue = quantitySKU1 * _clubValue;
            }
            else if (quantitySKU1 > quantitySKU2)
            {
                int i = quantitySKU1 - quantitySKU2;
                promotionValue = (quantitySKU1 - i) * _clubValue + i * objUnitPrice.dictUnitPrice[_SKU1];
            }
            else
            {
                int i = quantitySKU2 - quantitySKU1;
                promotionValue = (quantitySKU2 - i) * _clubValue + i * objUnitPrice.dictUnitPrice[_SKU2];
            }

            return cartValue + promotionValue;
        }
    }
}
