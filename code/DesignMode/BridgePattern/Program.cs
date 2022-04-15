// See https://aka.ms/new-console-template for more information
using BridgePattern;

Console.WriteLine("Hello, World!");
// 创建一个遥控器
RemoteControl remoteControl = new ConcreteRemote();
// 长虹电视机
remoteControl.Implementor = new ChangHong();
remoteControl.On();
remoteControl.SetChannel();
remoteControl.Off();
Console.WriteLine();
