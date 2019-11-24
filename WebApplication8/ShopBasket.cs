using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8
{
    public class ShopBasket
    {
        public Dictionary<int, int> BasketList = new Dictionary<int, int> { };

        public void ChangeList(int id, int number)
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
