// See https://aka.ms/new-console-template for more information
using Factory;

Console.WriteLine("Hello, World!");


Creator shreddedPorkWithPotatoesFactory = new ShreddedPorkWithPotatoesFactory();
Creator tomatoScrambledEggsFactory = new TomatoScrambledEggsFactory();

// 开始做西红柿炒蛋
Food tomatoScrambleEggs = tomatoScrambledEggsFactory.CreateFoddFactory();
tomatoScrambleEggs.Print();

//开始做土豆肉丝
Food shreddedPorkWithPotatoes = shreddedPorkWithPotatoesFactory.CreateFoddFactory();
shreddedPorkWithPotatoes.Print();

Console.Read();

///如果想加新的菜系，就不需要更改工厂类了
///直接加个新的工厂做菜
///

///抽象工厂的原理，跟工厂一样
///如果加一个工厂的话我们就可以新增了，符合了开闭原则
///对扩展开放，对修改关闭
///实际的例子中，DbProviderFactory 就是一个抽象工厂，SqlClientFactory 继承他
///
