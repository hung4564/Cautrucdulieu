#include <iostream>
#include "LinkedList.h"
#include "D_LinkedList.h"
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
int main()
{
	cout << "Day la ham main" << endl;
	main_D_linkedlist();
	cout << "\n";
	system("pause");
	return 0;
}