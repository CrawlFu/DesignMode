using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class RemoteControl
    {
        private TV implement;

        public TV Implement
        {
            get { return implement; }
            set { implement = value; }
        }

        public virtual void On()
        {
            implement.On();
        }

        public virtual void Off()
        {
            implement.Off();
        }
    }

    public class ConcreteRemote : RemoteControl
    {
        public override void Off()
        {
            Console.WriteLine("---------------------");
            base.Off();
            Console.WriteLine("---------------------");
        }
    }

    public abstract class TV
    {
        public abstract void On();
        public abstract void Off();

        public virtual void test()
        { 
        }
    }

    public class XiaoMi : TV
    {
        public override void test()
        {
            base.test();
        }

        public override void On()
        {
            Console.WriteLine("xiao mi on");
        }

        public override void Off()
        {
            Console.WriteLine("xiao mi off");
        }
    }
}
