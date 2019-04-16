using System.Threading;
using System;
namespace RandonNumberThingy.ItemManager
{
    public class ItemRepository
    { 
        private Item item;
        private readonly Random random;

        public ItemRepository(Random random)
        {
            item = new Item();
            this.random = random;
        }

        public void UpdateQuantity(int count)
        {
            Thread.Sleep(random.Next(500,1000));
            lock(item)
            {
                if (count < 0 && item.Quantity < 0)
                {
                    return;
                }
                if (item.Quantity + count < 0)
                {
                    return;
                }
                item.Quantity+=count;
            }
        }
        public int GetQuantity()
        {
            Thread.Sleep(random.Next(500, 1000));
            lock(item)
            {
                return item.Quantity;
            }
        }
    }
}