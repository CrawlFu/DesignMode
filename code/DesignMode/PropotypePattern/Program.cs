// See https://aka.ms/new-console-template for more information
using PropotypePattern;

Console.WriteLine("Hello, World!");


MonkeyPropotype prototypeMonkeyKing = new ConcertePropotype("MonkeyKing");

// 变一个
var cloneMonkeyKing = prototypeMonkeyKing.Clone();
Console.WriteLine("Cloned1:\t" + cloneMonkeyKing.Name);

// 变两个
MonkeyPropotype cloneMonkeyKing2 = prototypeMonkeyKing.Clone() as ConcertePropotype;
Console.WriteLine("Cloned2:\t" + cloneMonkeyKing2.Name);


cloneMonkeyKing.Name = "test";

var test = cloneMonkeyKing.Equals(cloneMonkeyKing2);

Console.ReadLine();

///原型模式向客户隐藏了创建新实例的复杂性
///原型模式允许动态增加或较少产品类。
///原型模式简化了实例的创建结构，工厂方法模式需要有一个与产品类等级结构相同的等级结构，而原型模式不需要这样。
///产品类不需要事先确定产品的等级结构，因为原型模式适用于任何的等级结构
///

///以上的都是创建型模式，单例模式，工厂模式，抽象工厂模式，建造者模式，原型模式
///
