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

    public abstract class TV
    {
        public virtual void On();
        public virtual void Off();
    }
}
