using Task5.Containers;

var coolerList = new DoubleLinkedList<int>();

coolerList.Insert(0, 0);
coolerList.Insert(1, 1);
coolerList.Insert(2, 2);
coolerList.Insert(3, 3);
coolerList.Insert(4, 4);
coolerList.Insert(5, 5);
coolerList.Print();

coolerList.Insert(1, 9);

coolerList.Print();

Console.WriteLine();
coolerList.Delete(0);
coolerList.Print();
coolerList.PrintReverse();
coolerList.Delete(5);
coolerList.Print();
coolerList.PrintReverse();


