// See https://aka.ms/new-console-template for more information
using AdapterPattern;

Console.WriteLine("Hello, World!");


ThreeHole threeHole = new AdapteHole();
threeHole.Request();

Console.ReadKey();

///开闭原则，对扩展开放，对修改关闭
///适配器模式分为类适配器，对象适配器
///