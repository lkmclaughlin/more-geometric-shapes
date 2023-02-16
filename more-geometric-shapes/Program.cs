using more_geometric_shapes;

Sqr s1 = new Sqr(11);
Console.Write("Square with 11in sides: ");
Console.WriteLine($"Perimeter is {s1.Perimeter()} Area is {s1.Area()}");

Rect r1 = new Rect(7, 9);

Console.Write("Rectangle with 7in and 9in sides: ");
Console.WriteLine($"Perimeter is {r1.Perimeter()} Area is {r1.Area()}");

Triangle t1 = new Triangle(9, 11, 6, 5);
Console.Write("Triangle: ");
Console.WriteLine($"Perimeter is {r1.Perimeter()} Area is {r1.Area()}");

