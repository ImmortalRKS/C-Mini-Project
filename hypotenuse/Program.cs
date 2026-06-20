Console.WriteLine("This Program will allow you to find hypotenuse of a traingle");
Console.WriteLine("Enter both sides of the traingle");

Console.Write("Enter side A : ");
double a = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter side B : ");
double b = Convert.ToDouble(Console.ReadLine());

double c = Math.Sqrt((a*a) + (b*b));
Console.WriteLine("The hypotenuse of the given side is : " + c);

// This program help us to find hypotenuse of the traingle