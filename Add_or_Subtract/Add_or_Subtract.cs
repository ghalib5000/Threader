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
              num=  r.create_Randomizer(0,5);
            }
            else
            {//SUBTRACT
                 num=  r.create_Randomizer(0,5);
                 num=num-(num*2);
            }
            return num;
         
    }
}