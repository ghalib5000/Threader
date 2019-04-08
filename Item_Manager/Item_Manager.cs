using System.Threading;
using System;
namespace RandonNumberThingy
{
    public class Item_Manager
    { 
        private  int _Item_Count=0;
     //   private static int countchecker=0;
        private object locker = new object();
         public int Item_Count
        {
            get{
                return this._Item_Count;
            }
            set{
                lock(locker)
               {
                this._Item_Count= value;
              //  countchecker=_Item_Count;
                }
            }
        }
        public void Item_Checker()
        {
            if(_Item_Count<=0)
            {
                _Item_Count=0;
            }
        }
    }
}