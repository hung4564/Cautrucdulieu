#ifndef C_LINKEDLIST_H
#define C_LINKEDLIST_H
#include"Node.h"
class C_LinkedList
{
public:
	C_LinkedList();
	~C_LinkedList();
	void Show();
	Node* GetRoot();
	void Add(int value);
	void Delete(int value_node);
	Node* Find(int value_node);
private:
	Node * root;
};
#endif

