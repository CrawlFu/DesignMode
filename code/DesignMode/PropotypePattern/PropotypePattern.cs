using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropotypePattern
{
    /// <summary>
    /// 原型类
    /// </summary>
    public abstract class MonkeyPropotype
    {
        public string Name { get; set; }

        public MonkeyPropotype(string name)
        {
            Name = name;
        }

        public abstract MonkeyPropotype Clone();
    }

    public class ConcertePropotype : MonkeyPropotype
    {
        public ConcertePropotype(string name) : base(name)
        {
            
        }
        public override MonkeyPropotype Clone()
        {
            return (MonkeyPropotype)this.MemberwiseClone();
        }
    }
}
