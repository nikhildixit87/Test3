using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class UnitPrice //Class for specifying unit price of SKU Ids
    {
        public Dictionary<char, double> dictUnitPrice = new Dictionary<char, double>();

        public UnitPrice()
        {
            dictUnitPrice.Add('A', 50);
            dictUnitPrice.Add('B', 30);
            dictUnitPrice.Add('C', 20);
            dictUnitPrice.Add('D', 15);
            dictUnitPrice.Add('E', 10);
            dictUnitPrice.Add('F', 8);
        }
    }
}
