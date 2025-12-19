using Task3.Containers;

var coolQue = new CircularQue<int>(7);
coolQue.Enque(1);
coolQue.Enque(2);
coolQue.Enque(3);
coolQue.Enque(4);
coolQue.Enque(5);
coolQue.Enque(6);
coolQue.Enque(7);
Console.WriteLine("--- Original Que ---");
coolQue.Print();

Console.WriteLine("--- First two elements ---");
Console.WriteLine(coolQue.Peek());
Console.WriteLine(coolQue.Peek());

coolQue.Enque(8);
coolQue.Enque(9);
Console.WriteLine("--- Changed Que ---");
coolQue.Print();