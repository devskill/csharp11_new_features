using GenericMathSupport;

Point<double> p1 = new Point<double>() { X = 5, Y = 9 };
Point<double> p2 = new Point<double>() { X = 5, Y = 9 };

var p3 = p1.Sum(p2);
Console.WriteLine($"{p3.X}, {p3.Y}");

int x = 5;
int y = x >>> 1;
Console.WriteLine(y);


