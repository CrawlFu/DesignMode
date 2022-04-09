using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class Customer
    {
        public Food Cook(string type)
        {
            Food food = null;

            if(type.Equals("西红柿炒蛋"))
            {
                food = new TomatoScrambleEgg();
            }

            if(type.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoes();
            }

            return food;
        }
    }

    //也可以用接口
    public abstract class Food
    {
        public abstract void Print();
    }

    public class TomatoScrambleEgg : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份西红柿炒蛋");
        }
    }
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("一份土豆肉丝");
        }
    }

    public class FoodSimpleFactory
    {
        public Food CreateFood (string type)
        {
            Food food = null;

            if (type.Equals("西红柿炒蛋"))
            {
                food = new TomatoScrambleEgg();
            }

            if (type.Equals("土豆肉丝"))
            {
                food = new ShreddedPorkWithPotatoes();
            }

            return food;
        }
    }

    public struct TEst
    {
        public string Name;
        public void SS()
        { 
        }
    }
}
