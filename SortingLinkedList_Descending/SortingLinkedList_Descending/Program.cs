using SortingLinkedList_Ascending;

var list = new LinkedList();

list.Insert(30);
list.Insert(4);
list.Insert(90);
list.Insert(4444);
list.Insert(100000000);

list.SortByDescending();

list.Print();

Console.ReadKey();