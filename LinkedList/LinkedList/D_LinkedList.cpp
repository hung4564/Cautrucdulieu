#include "D_LinkedList.h"
#include <iostream>
using namespace std;


D_LinkedList::D_LinkedList()
{
	first = NULL;
	last = NULL;
}



D_LinkedList::~D_LinkedList()
{
}

Node * D_LinkedList::GetFirst()
{
	return first;
}

Node * D_LinkedList::GetLast()
{
	return last;
}

void D_LinkedList::AddLast(int value)
{
	Node* temp = new Node(value);
	if (last == NULL)
	{
		first = temp;
		last = temp;
	}
	else
	{
		last->setNext(temp);
		temp->setPrevious(last);
		last = temp;
	}
}

void D_LinkedList::AddFirst(int value)
{
	Node* temp = new Node(value);
	if (first == NULL)
	{
		first = temp;
		last = temp;
	}
	else
	{
		first->setPrevious(temp);
		temp->setNext(first);
		first = temp;
	}
}

void D_LinkedList::Show()
{
	Node *p;
	p = first;
	while (p != NULL)
	{
		cout << p->getData() << ";";
		p = p->getNext();

	}
}