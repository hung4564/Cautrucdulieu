#include <iostream>
#include"Queue.h"
#include"Stack.h"
using namespace std;
void main_stack()
{
	Stack stack;
	for (size_t i = 0; i < 10; i++)
	{
		stack.Push(i);
	}
	while (!stack.IsEmpty())
	{
		cout << stack.Pop()<<"; ";
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
		cout << queue.Dequeue()<<";";
	}
}
int main()
{
	main_queue();
	cout << endl;
	system("pause");
	return 0;
}