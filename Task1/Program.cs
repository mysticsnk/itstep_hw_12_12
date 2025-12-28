using Task1.UtilMethods;

int firstInt = 1488;
int secondInt = 69;
Console.WriteLine($"First int: {firstInt}, Second int: {secondInt}");

Utils.Swap<int>(ref firstInt, ref secondInt);
Console.WriteLine($"First int: {firstInt}, Second int: {secondInt}");