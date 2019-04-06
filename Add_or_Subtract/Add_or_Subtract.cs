namespace RandonNumberThingy
{ 
    public class Add_or_Subtract
    {
      static public  Item_Manager item = new Item_Manager();

        public void Get_Number(int i)
        {
            Randomizer r = new Randomizer();
            int num=0;
            if(i%2==0)
            {//ADD
            num=  r.create_Randomizer(1,6);
            System.Console.WriteLine("Added {0}",num);
            item.Item_Count = item.Item_Count+num;
            }
            
            else
            {//SUBTRACT
            num=  r.create_Randomizer(1,6);
            num=num-(num*2);
            
            if(item.Item_Count+num<0)
            {
            System.Console.WriteLine("Sorry the item count is to small");
            item.Item_Count=0;
            }
            else
            {
            item.Item_Count = item.Item_Count+num;
            System.Console.WriteLine("Subtracted {0}",num);
               
            }
            item.Item_Checker();
            }
            //return num;
        }  
    }
}