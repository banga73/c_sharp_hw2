Console.WriteLine("Input number ");
int num1 = int.Parse(Console.ReadLine());
if (num1 < 100 && num1 > -100) Console.WriteLine("There is no third dight");
else
{
	int rez = Math.Abs((num1 / 100) % 10);
	Console.WriteLine($"Third dight is {rez}");
}