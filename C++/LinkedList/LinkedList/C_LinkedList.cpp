#include "C_LinkedList.h"
#include <iostream>
using namespace std;



C_LinkedList::C_LinkedList()
{
	root = NULL;
}


C_LinkedList::~C_LinkedList()
{
}

void C_LinkedList::Show()
{
	Node* p = root;
	do
	{
		cout << p->getData() << ";";
		p = p->getNext();
	} while (p != root);
}

Node* C_LinkedList::GetRoot()
{
	return root;
}

void C_LinkedList::Add(int value)
{
	Node* temp = new Node(value);
	if (root == NULL)
	{
		root = temp;
		temp->setNext(temp);
		temp->setPrevious(temp);
	}
	else if (root->getNext() == root)
	{
		temp->setNext(root);
		temp->setPrevious(root);
		root->setNext(temp);
		root->setPrevious(temp);
		root = temp;
	}
	else
	{
		temp->setNext(root);
		temp->setPrevious(root->getPrevious());
		root->getPrevious()->setNext(temp);
		root->setPrevious(temp);
		root = temp;
	}
}

void C_LinkedList::Delete(int value_node)
{
	Node* temp = Find(value_node);
	if (temp != NULL)
	{
		if (temp->getNext() == temp)
		{
			root = NULL;
		}
		else
		{
			temp->getPrevious()->setNext(temp->getNext());
			temp->getNext()->setPrevious(temp->getPrevious());
			delete temp;
		}
	}
}

Node * C_LinkedList::Find(int value_node)
{
	Node* p = root;
	do
	{
		if (p->getData() == value_node)
			return p;
		p = p->getNext();
	} while (p != root);
	return NULL;
}
