#include "Stack.h"
#include <iostream>
using namespace std;


Stack::Stack()
{
	top = -1;
}


Stack::~Stack()
{
}

bool Stack::IsEmpty()
{
	if (top == -1) return true;
	else
		return false;
}

bool Stack::IsFull()
{
	if (top == MaxSize - 1) return true;
	else
		return false;
}

void Stack::Push(int value)
{
	if (IsFull()) cout << "Stack day" << endl;
	else {
		top++;
		stack[top] = value;
	}
}

int Stack::Pop()
{
	if (IsEmpty())
	{
		cout << "stack trong" << endl;
	}
	else
	{
		top--;
		return stack[top + 1];
	}
}

int Stack::Peek()
{
	return stack[top];
}