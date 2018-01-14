#ifndef D_LINKEDLIST_H
#define D_LINKEDLIST_H
#include"Node.h"
class D_LinkedList
{
public:
	D_LinkedList();
	~D_LinkedList();
	Node* GetFirst();
	Node* GetLast();
	void AddLast(int value);
	void AddFirst(int value);
	void Show();
private:
	Node* first;
	Node* last;
};
#endif