namespace RandonNumberThingy
{ 
    public class Add_or_Subtract
    {
        public int Get_Number(int i)
        {
            Randomizer r = new Randomizer();
            int num=0;
            if(i%2==0)
            {//ADD
              num=  r.create_Randomizer(1,6);
              System.Console.WriteLine("Added {0}",num);
            }
            else
            {//SUBTRACT
                 num=  r.create_Randomizer(1,6);
                 num=num-(num*2);
                 
              System.Console.WriteLine("Subtracted {0}",num);
            }
            return num;
        }  
    }
}