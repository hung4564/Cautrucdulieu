#ifndef BINARYTREE_H
#define BINARYTREE_H
#include"Node.h"
class BinaryTree
{
public:
	BinaryTree();
	~BinaryTree();
	void Add(int value);
	void Delete(int value);
	Node* Search(int value);
	void Show();
private:
	Node * root;
	void RTLtraverse(Node* root);
};
#endif // !BINARYTREE_H


