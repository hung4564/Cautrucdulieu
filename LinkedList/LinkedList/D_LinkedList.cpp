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

void D_LinkedList::AddAffter(int value_node, int value_them)
{
	if (first != NULL)
	{
		Node* temp = Find(value_node);
		if (temp != NULL)
		{
			Node* p = new Node(value_them);
			if (temp->getNext() != NULL) temp->getNext()->setPrevious(p);
			p->setNext(temp->getNext());
			p->setPrevious(temp);
			temp->setNext(p);
		}
	}
}

void D_LinkedList::AddBefore(int value_node, int value_them)
{
	if (first != NULL)
	{
		Node* temp = Find(value_node);
		if (temp != NULL)
		{
			Node* p = new Node(value_them);
			if (temp->getPrevious() != NULL) temp->getPrevious()->setNext(p);
			p->setPrevious(temp->getPrevious());
			p->setNext(temp);
			temp->setPrevious(p);
		}
	}
}


void D_LinkedList::Delete(int value_node)
{
	if(first!=NULL)
	if (first->getData() == value_node)DeleteFirst();
	else if (last->getData() == value_node)DeleteLast();
	else
	{
		Node* temp = Find(value_node);
		if (temp != NULL)
		{
			temp->getPrevious()->setNext(temp->getNext());
			temp->getNext()->setPrevious(temp->getPrevious());
			free(temp);
		}
	}
}

void D_LinkedList::DeleteFirst()
{
	if (first != NULL)
	{
		if (first == last)
		{
			first = NULL;
			last = NULL;
		}
		else
		{
			Node*q = first;
			first = q->getNext();
			first->setPrevious(NULL);
			free(q);
		}
	}
}

void D_LinkedList::DeleteLast()
{
	if (last != NULL)
	{
		if (first == last)
		{
			first = NULL;
			last = NULL;
		}
		else
		{
			Node*q = last;
			last = q->getPrevious();
			last->setNext(NULL);
			free(q);
		}
	}
}

Node* D_LinkedList::Find(int value)
{
	Node* temp = first;
	while (temp != NULL)
	{
		if (temp->getData() == value) break;
		temp = temp->getNext();
	}
	return temp;
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