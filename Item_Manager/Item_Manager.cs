using System.Threading;
using System;
namespace RandonNumberThingy
{
    public class Item_Manager
    { 
        private  int _Item_Count=0;
        private static int cc=0;
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
                cc=_Item_Count;
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
        public void add(int i)
        {

        }
    }
}