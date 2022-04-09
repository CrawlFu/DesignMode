using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public  class Singleton
    {
        public static Singleton Instance;

        private static readonly object locker = new object();
        private Singleton()
        {

        }

        public static Singleton GetSingleton()
        {
            if (Instance == null)
            {
                lock (locker)
                {
                    if (Instance == null)
                    {
                        Instance = new Singleton();
                    }
                }
            }

            return Instance;
        }

    }

    public class Test
    {
        public void S()
        {

            Singleton.GetSingleton();
        }
    }
}
