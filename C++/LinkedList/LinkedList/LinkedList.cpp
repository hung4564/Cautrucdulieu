#pragma once
#include "LinkedList.h"
#include <iostream>
using namespace std;
LinkedList::LinkedList()
{
	first = NULL;
}
LinkedList::~LinkedList()
{
}
int LinkedList::Size()
{
	if(first==NULL)
	return 0;
	else
	{
		int n = 0;
		Node *p;
		p = first;
		while (p != NULL)
		{
			n++;
			p = p->getNext();
		}
		return n;
	}
}
bool LinkedList::Empty()
{
	if (first == NULL) return true;
	return false;
}
void LinkedList::Add(int value)
{
	Node* temp = new Node(value);
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
		p->setNext(temp);
	}
}
void LinkedList::AddBefore(int value_node, int value_them)
{
	Node* p;
	Node* q;
	p = first;
	q = p;
	Node* temp = new Node(value_them);
	if (first != NULL)
	{
		while (p != NULL)
		{
			if (p->getData() == value_node)break;
			q = p;
			p = p->getNext();
		}
		q->setNext(temp);
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

void LinkedList::Erase(int index)
{
	if (Empty())
		return;
	else
	{
		if (index == 1) DeleteFirst();
		else
		{
			Node* p;
			p = first;
			while (p != NULL)
			{
				p = p->getNext();
				index--;
				if (index == 1) break;
			}
			if (index == 1)
			{
				Node*q = p->getNext();
				p->setNext(q->getNext());
				delete q;
			}
		}
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
