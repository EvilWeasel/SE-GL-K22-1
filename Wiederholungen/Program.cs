using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");

Console.WriteLine("---Array---");

int[] numbers = new int[10];
//int[] numbers = new int[] { };
//Console.WriteLine(RuntimeHelpers.GetHashCode(numbers));
//numbers = numbers.Append(10).ToArray();
//Console.WriteLine(RuntimeHelpers.GetHashCode(numbers));
//Console.WriteLine(RuntimeHelpers.GetHashCode(numbers));

//Console.ReadKey();

for (int i = 0; i < 10; i++)
{
  numbers[i] = i;
}

foreach (var number in numbers)
{
  Console.WriteLine(number);
}

Console.WriteLine("---List---");

// List<int> numbersList = new List<int>();
List<int> numbersList = new List<int>() { 42 };

//numbersList.Add(10);

//for (int i = 0; i < 10; i++)
//{
//  numbersList[i] = i;
//}
for (int i = 0; i < 10; i++)
{
  numbersList.Add(i);
  //numbersList.Append(i);
}

foreach (var number in numbersList)
{
  Console.WriteLine(number);
}
Console.ReadKey();

// wird nur ausgeführt, wenn true
while (true)
{
  Console.WriteLine();
}

// do => mindestens einmal ausgeführt.
do
{
  Console.WriteLine();
} while (true);