// See https://aka.ms/new-console-template for more information
using DecoratorPattern;

Console.WriteLine("Hello, World!");


Phone phone = new Apple();


// 现在想贴膜了
Decorator applePhoneWithSticker = new Stick(phone);
// 扩展贴膜行为
applePhoneWithSticker.Print();
Console.WriteLine("----------------------\n");

// 现在我想有挂件了
Decorator applePhoneWithAccessories = new XII(phone);
// 扩展手机挂件行为
applePhoneWithAccessories.Print();
Console.WriteLine("----------------------\n");

// 现在我同时有贴膜和手机挂件了
Stick sticker = new Stick(phone);
XII applePhoneWithAccessoriesAndSticker = new XII(sticker);
applePhoneWithAccessoriesAndSticker.Print();
Console.ReadLine();