using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class PromotionType_nSimilarItems : IPromotions //Class for specifying promotion details for n number of similar SKU IDs with total value
    {
        public char _SKU;
        public int _nItems;
        public double _clubValue;

        public PromotionType_nSimilarItems(char SKU, int nItems, double clubValue)
        {
            _SKU = SKU;
            _nItems = nItems;
            _clubValue = clubValue;
        }

        public double ApplyPromotion(Cart objCart, UnitPrice objUnitPrice, double cartValue)
        {
            double promotionValue = 0;

            foreach (SKUs obj in objCart.objSKUs)
            {
                if (obj.SKUId == _SKU)
                {
                    int i = obj.quantity / _nItems;
                    int j = obj.quantity % _nItems;

                    promotionValue = i * _clubValue + j * objUnitPrice.dictUnitPrice[_SKU];
                }
            }

            return cartValue + promotionValue;
        }
    }
}
