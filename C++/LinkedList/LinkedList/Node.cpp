#pragma once
#include "Node.h"
using namespace std;
#include <iostream>
Node::Node()
{
	left = NULL;
	right = NULL;
}
Node::Node(int value)
{
	data = value;
	left = NULL;
	right = NULL;
}
Node::~Node()
{
}
void Node::show()
{
	cout << "dia chi cua node la " << &data << "\n";
	cout << "Gia tri cua node la " << data << endl;
	cout << "dia chi cua node tiep la " << left << "\n";
}

void Node::setData(int value)
{
	data = value;
}
int Node::getData()
{
	return data;
}
Node * Node::getNext()
{
	return right;
}
Node * Node::getPrevious()
{
	return left;
}

void Node::setNext(Node * next)
{
	this->right = next;
}

void Node::setPrevious(Node * next)
{
	this->left = next;
}

