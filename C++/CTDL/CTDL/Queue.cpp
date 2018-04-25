#include "Queue.h"
#include<iostream>
using namespace std;


Queue::Queue()
{
	first = 0;
	last = -1;
	count = 0;
}


Queue::~Queue()
{
}

bool Queue::IsEmpty()
{
	if (count == 0) return true;
	return false;
}

bool Queue::IsFull()
{
	if (count == max) return true;
	return false;
}

int Queue::Dequeue()
{
	if (IsEmpty())
	{
		cout << "hang doi rong" << endl;
		return NULL;
	}
	else
	{
		int data = queue[first];
		queue[first] = 0;
		first = (first + 1) % max;
		count--;
		return data;
	}
}

void Queue::Enqueue(int value)
{
	if (IsFull())
	{
		cout << "hang doi day" << endl;
	}
	else
	{
		last = (last + 1) % max;
		queue[last] = value;
		count++;
	}
}

int Queue::Peek()
{
	if (first > 0)
		return queue[first];
	else return NULL;
}
