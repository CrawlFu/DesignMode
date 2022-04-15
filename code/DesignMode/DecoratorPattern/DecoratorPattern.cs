using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Phone
    {
        public abstract void Print();
    }

    public class Apple : Phone
    {
        public override void Print() 
        {

        }
    }

    public abstract class Decorator : Phone
    {
        private Phone _phone;
        public Decorator(Phone phone)
        {
            _phone = phone;
        }

        public override void Print()
        {
            _phone.Print();
        }
    }

    public class Stick : Decorator
    {
        public Stick(Phone phone) :base(phone)
        { 
        }

        public override void Print()
        {
            base.Print();

            AddAccessories();

        }

        public void AddAccessories()
        {
            Console.WriteLine("现在苹果手机有漂亮的挂件了");
        }
    }

    public class XII : Decorator
    {
        public XII(Phone phone) : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();

            AddAccessories();

        }

        public void AddAccessories()
        {
            Console.WriteLine("现在苹果手机有漂亮的MO了");
        }
    }
}
