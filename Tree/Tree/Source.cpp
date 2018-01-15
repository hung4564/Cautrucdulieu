#include<iostream>
#include"BinaryTree.h"
using namespace std;
void main_BST()
{
	BinaryTree tree;
	tree.Add(50);
	tree.Add(30);
	tree.Add(20);
	tree.Add(40);
	tree.Add(35);
	tree.Add(32);
	tree.Show();
	cout << endl;
	tree.Delete(30);
	tree.Delete(40);
	cout << endl;
	tree.Show();
}
int main()
{
	main_BST();
	cout << endl;
	system("pause");
	return 0;
}