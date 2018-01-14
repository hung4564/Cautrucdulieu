#ifndef Node_H
#define Node_H
class Node
{
public:
	Node();
	Node(int value);

public:
	void show();
	void setData(int value);
	int getData();
	Node* getNext();
	Node* getPrevious();
	void setNext(Node* next);
	void setPrevious(Node* next);
private:
	int data;
	Node *left;
	Node *right;
};
#endif