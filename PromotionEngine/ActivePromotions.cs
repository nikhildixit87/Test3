using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ActivePromotions //Class to maintain list of all active promotions
    {
        public List<IPromotions> lstPromotions = new List<IPromotions>();

        public ActivePromotions()
        {
            PromotionType_nSimilarItems obj3SimilarItems = new PromotionType_nSimilarItems('A', 3, 130);
            PromotionType_nSimilarItems obj2SimilarItems = new PromotionType_nSimilarItems('B', 2, 45);
            PromotionType_twoDifferentItems objtwoDifferentItems = new PromotionType_twoDifferentItems('C', 'D', 30);
            //PromotionType_NA objNA = new PromotionType_NA("E,F");

            lstPromotions.Add(obj3SimilarItems);
            lstPromotions.Add(obj2SimilarItems);
            lstPromotions.Add(objtwoDifferentItems);
            //lstPromotions.Add(objNA);
        }
    }
}
