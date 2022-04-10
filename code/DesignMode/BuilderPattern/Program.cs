// See https://aka.ms/new-console-template for more information
using BuilderPattern;

Console.WriteLine("Hello, World!");

///建造者模式
///

Director director = new Director();
var builder1 = new Builder1();
var builder2 = new Builder2();

director.Construct(builder1);

var computer1 = builder1.GetComputer();
computer1.Show();

director.Construct(builder2);
var computer2 = builder2.GetComputer();
computer2.Show();

///在建造者模式中，指挥者和客户打交道，
///建造者模式中，是把具体的产品抽象出来进行解耦。