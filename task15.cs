Console.WriteLine("Input number of day of week");
int num1 = int.Parse(Console.ReadLine());
if (num1 == 6 || num1 == 7) Console.WriteLine("it's a weekend");
else if (num1 > 0 && num1 < 6) Console.WriteLine("it's not a weekend");
else Console.WriteLine("There is no such day");