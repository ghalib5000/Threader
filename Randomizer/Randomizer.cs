using System;
namespace RandonNumberThingy 
{    public class Randomizer 
    { 
        Random r = new Random();
        public int create_Randomizer(int i)
        {
        int rand = r.Next(0,i);
        return rand;
        }
        public int create_Randomizer(int f,int s)
        {
        int rand = r.Next(f,s);
        return rand;
        }
    }
}