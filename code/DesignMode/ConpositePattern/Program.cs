// See https://aka.ms/new-console-template for more information
using ConpositePattern;

Console.WriteLine("Hello, World!");



        ComplexGraphics complexGraphics = new ComplexGraphics("一个复杂图形和两条线段组成的复杂图形");
        complexGraphics.Add(new Line("线段A"));
        ComplexGraphics CompositeCG = new ComplexGraphics("一个圆和一条线组成的复杂图形");
        CompositeCG.Add(new Circle("圆"));
        CompositeCG.Add(new Circle("线段B"));
        complexGraphics.Add(CompositeCG);
        Line l = new Line("线段C");
        complexGraphics.Add(l);

        // 显示复杂图形的画法
        Console.WriteLine("复杂图形的绘制如下：");
        Console.WriteLine("---------------------");
        complexGraphics.Draw();
        Console.WriteLine("复杂图形绘制完成");
        Console.WriteLine("---------------------");
        Console.WriteLine();

        // 移除一个组件再显示复杂图形的画法
        complexGraphics.Remove(l);
        Console.WriteLine("移除线段C后，复杂图形的绘制如下：");
        Console.WriteLine("---------------------");
        complexGraphics.Draw();
        Console.WriteLine("复杂图形绘制完成");
        Console.WriteLine("---------------------");
        Console.Read();

///z组合模式可能像树形接口
///