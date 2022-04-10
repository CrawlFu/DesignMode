using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 小王和小李难道会自愿地去组装嘛，谁不想休息的，这必须有一个人叫他们去组装才会去的
    /// 这个人当然就是老板了，也就是建造者模式中的指挥者
    /// 指挥创建过程类
    /// </summary>
    public class Director
    {
        //组装电脑
        public void Construct(Builder builder)
        {
            builder.BuilderMainBoard();
            builder.BuilderCPU();
        }
    }

    public class Computer
    {
        private IList<string> parts = new List<string>();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑开始在组装.......");
            foreach (string part in parts)
            {
                Console.WriteLine("组件" + part + "已装好");
            }

            Console.WriteLine("电脑组装好了");
        }

    }

    //建造者
    public abstract class Builder
    {
        public abstract void BuilderCPU();
        public abstract void BuilderMainBoard();
        public abstract Computer GetComputer();
    }

    public class Builder1 : Builder
    {
        Computer computer = new Computer();
        public override void BuilderCPU()
        {
            computer.Add("CPU1");
        }

        public override void BuilderMainBoard()
        {
            computer.Add("Main Board1");
        }

        public override Computer GetComputer()
        {
            return computer;
        }

    }
    public class Builder2 : Builder
    {
        Computer computer = new Computer();
        public override void BuilderCPU()
        {
            computer.Add("CPU2");
        }

        public override void BuilderMainBoard()
        {
            computer.Add("Main Board2");
        }

        public override Computer GetComputer()
        {
            return computer;
        }
    }
}
