using Task4.Containers;

var coolList = new SingleLinkedList<int>();

coolList.Insert(0, 0);
coolList.Insert(1, 1);
coolList.Insert(2, 2);
coolList.Insert(3, 3);
coolList.Insert(4, 4);

coolList.Insert(1, 9);

coolList.Print();

coolList.Delete(0);
coolList.Delete(4);

coolList.Print();