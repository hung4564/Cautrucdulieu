#ifndef LINKEDLIST_H
#define LINKEDLIST_H
#include"Node.h"
class LinkedList
{
public:
	LinkedList();
	~LinkedList();
	int Size();
	bool Empty();
	void Show();
	void AddFirst(int value);
	void Add(int value);
	void AddBefore(int value_node, int value_them);
	void AddAfter(int value_node, int value_them);
	void DeleteFirst();
	void DeleteLast();
	void DeleteNode(int value);
	void Erase(int index);
	Node* Find(int value);
	Node* GetFirst();
private:
	Node * first;
};
#endif