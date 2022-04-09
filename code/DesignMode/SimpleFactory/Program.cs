// See https://aka.ms/new-console-template for more information
using SimpleFactory;

Console.WriteLine("Hello, World!");

Customer customer = new Customer();
var food1 = customer.Cook("西红柿炒蛋");
food1.Print();

var food2 = customer.Cook("土豆肉丝");
food2 .Print();


var factory = new FoodSimpleFactory();
var food3 = factory.CreateFood("西红柿炒蛋");
food3.Print();


//优点
//客户端不直接创建对象，直接消费产品，简单工厂模式对责任的分割

//缺点
//工厂类继承了所有的逻辑，一旦出现问题就是影响到其他的，如果加很多产品就会造成工厂类过于复杂


//应用场景
//如果只是简单的几个对象创建可以考虑简单工厂类