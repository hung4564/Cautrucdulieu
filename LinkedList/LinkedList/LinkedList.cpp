#pragma once
#include "LinkedList.h"
#include <iostream>
using namespace std;
LinkedList::LinkedList()
{
	first = NULL;
}
void LinkedList::Add(int value)
{
	Node *temp = new Node(value);
	if (first == NULL)
	{
		first = temp;
	}
	else
	{
		Node *p;
		p = first;
		while (p->getNext() != NULL)
		{
			p = p->getNext();
		}
		p->setNext(value);
	}
}
void LinkedList::AddBefore(int value_node, int value_them)
{
	Node* p;
	Node* q;
	p = first;
	q = p;
	if (first != NULL)
	{
		while (p != NULL)
		{
			if (p->getData() == value_node)break;
			q = p;
			p = p->getNext();
		}
		q->setNext(value_them);
		q->getNext()->setNext(p);
	}
}
void LinkedList::Show()
{
	Node *p;
	p = first;
	while (p != NULL)
	{
		cout << p->getData() << ";";
		p = p->getNext();

	}
}
void LinkedList::AddFirst(int value)
{
	Node* temp = new Node(value);
	if (first == NULL)
	{
		first = temp;
	}
	else
	{
		temp->setNext(first);
		first = temp;
	}
}
void LinkedList::AddAfter(int value_node, int value_add)
{
	if (first != NULL)
	{
		Node* p;
		Node* q = new Node(value_add);
		p = Find(value_node);
		if (p != NULL)
		{
			q->setNext(p->getNext());
			p->setNext(q);
		}
	}
}
void LinkedList::DeleteFirst()
{
	if (first != NULL)
	{
		Node* p = first;
		first = p->getNext();
		delete p;
	}
}
void LinkedList::DeleteLast()
{
	if (first != NULL)
	{
		Node *p;
		p = first;
		while (p->getNext() != NULL)
		{
			p = p->getNext();
		}
		delete p->getNext();
		p->setNext(NULL);

	}
}

void LinkedList::DeleteNode(int value)
{
	Node* p;
	Node* q;
	p = first;
	q = p;
	if (first != NULL)
	{
		while (p != NULL)
		{
			if (p->getData() == value)break;
			q = p;
			p = p->getNext();
		}
		q->setNext(p->getNext());
		delete p;
	}
}

Node * LinkedList::Find(int value)
{
	Node* p;
	p = first;
	if (first != NULL)
	{
		while (p != NULL)
		{
			if (p->getData() == value)break;
			p = p->getNext();
		}
	}
	return p;
}

Node * LinkedList::GetFirst()
{
	return first;
}
