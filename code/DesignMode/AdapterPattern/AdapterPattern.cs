using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    //public interface IThreeHole
    //{
    //    void Request();
    //}

    //public abstract class TwoHole
    //{
    //    public void SpecialRequest()
    //    {
    //        Console.WriteLine("这是个二的接口");
    //    }
    //}

    //public class AdapterHole : TwoHole,IThreeHole
    //{
    //    public void Request()
    //    {
    //        base.SpecialRequest();
    //    }
    //}

    public class TwoHole
    {
        public void SpecificRequest()
        {
            Console.WriteLine("这是二的端口");
        }
    }

    public class ThreeHole
    {
        public virtual void Request()
        {
            Console.WriteLine("这是个三的端口");
        }
    }

    public class AdapteHole : ThreeHole
    {
        private readonly TwoHole twoHole;

        public AdapteHole()
        {
            twoHole = new TwoHole();
        }
        public override void Request()
        {
            twoHole.SpecificRequest();
        }
    }
}
