using Task2.Containers;

var coolQue = new PriorityQue<string>([
    new PQueItem<string>("Cool", 1),
    new PQueItem<string>("Cooler", 2),
    new PQueItem<string>("Coolest", 3),
]);

coolQue.Print();

string max = coolQue.ExtractMax();
Console.WriteLine($"Max value: {max}");
string min = coolQue.ExtractMin();
Console.WriteLine($"Min value: {min}");

Console.WriteLine("--- Que without max and min: ---");
coolQue.Print();
coolQue.Append(new PQueItem<string>("NotCool", -1));
coolQue.Append(new PQueItem<string>("VERYCool", 1488));

Console.WriteLine("--- Que with new items: ---");
coolQue.Print();

coolQue.Pop();
Console.WriteLine("--- Que without pashalochka: ---");
coolQue.Print();
