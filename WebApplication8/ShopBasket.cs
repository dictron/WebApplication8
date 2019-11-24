using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class ShopBasket
    {
        public Dictionary<string, int> BasketList = new Dictionary<string, int> { };

        public void ChangeList(string id, int number)
        {
            if (BasketList.ContainsKey(id))
            {
                BasketList[id] = BasketList[id] + number;
            }
            else
            {
                BasketList.Add(id, number);
            }
            BasketList.Add(id, number);
        }
    }
}
