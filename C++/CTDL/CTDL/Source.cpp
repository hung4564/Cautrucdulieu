#include<iostream>
#include "Array.h"
#include"Queue.h"
#include"Stack.h"
#include "LinkedList.h"
#include "D_LinkedList.h"
#include "C_LinkedList.h"
#include "Node.h"
using namespace std;
void main_linkedlist()
{
	LinkedList list;
	for (int i = 0; i<3; i++)
	{
		list.Add(i);
	}
	list.Show();
	cout << "\n";
	list.AddFirst(-10);
	list.AddAfter(-10, 2);
	list.AddBefore(2, 3);
	list.DeleteNode(1);
	list.Show();
}
void main_D_linkedlist()
{
	D_LinkedList list;
	for (size_t i = 0; i < 4; i++)
	{
		list.AddLast(i);
	}
	list.Show();
	cout << "\n";
	list.AddFirst(4);
	list.AddLast(-1);
	list.Show();
	cout << "\n";
	list.DeleteFirst();
	list.DeleteLast();
	list.Show();
	cout << "\n";
	list.AddAffter(2, 12);
	list.Show();
	cout << "\n";
	list.AddBefore(2, 11);
	list.Show();
	cout << "\n";
}
void main_C_linkedlist()
{
	C_LinkedList list;
	for (int i = 0; i <10; i++)
	{
		list.Add(i);
	}
	for (int i = 0; i < 5; i++)
	{
		list.Delete(i);
	}
	list.Show();
	cout << "\n";
}
void main_stack()
{
	Stack stack;
	for (size_t i = 0; i < 10; i++)
	{
		stack.Push(i);
	}
	while (!stack.IsEmpty())
	{
		cout << stack.Pop() << "; ";
	}
}
void main_queue()
{
	Queue queue;
	for (int i = 0; i < 10; i++)
	{
		queue.Enqueue(i);
	}
	while (!queue.IsEmpty())
	{
		cout << queue.Dequeue() << ";";
	}
}
void array_main()
{
	Array arrary;
	arrary.Push(5);
	arrary.Push(3);
	arrary.Push(2);
	arrary.Push(1);
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	arrary.Insert(2, -1);
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	arrary.Prepend(-2);
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	cout << endl;
	cout << arrary.Find(-2);
	arrary.Delete(5);
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	for (size_t i = 0; i < 3; i++)
	{
		arrary.Push(7);
	}
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	arrary.Remove(7);
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
}
int main()
{
	array_main();
	cout << endl;
	system("pause");
	return 0;
}