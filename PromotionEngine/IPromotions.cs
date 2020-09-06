using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public interface IPromotions // Interface to be inherited by each promotion type class to calculate promotion value
    {
        double ApplyPromotion(Cart objCart, UnitPrice objUnitPrice, double cartValue);
    }
}
