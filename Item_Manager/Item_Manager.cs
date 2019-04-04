namespace RandonNumberThingy
{
    public class Item_Manager
    {
        private  int _Item_Count=0;
        public int Item_Count
        {
            get{
                return this._Item_Count;
            }
            set{
                this._Item_Count= value;
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