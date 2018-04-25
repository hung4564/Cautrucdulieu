#include "BinaryTree.h"
#include<iostream>
using namespace std;

BinaryTree::BinaryTree()
{
	root = NULL;
}


BinaryTree::~BinaryTree()
{
}

void BinaryTree::Add(int value)
{
	Node* temp = new Node(value);
	if (root == NULL)
	{
		root = temp;
	}
	else
	{
		Node* p = root;
		Node* q = p;
		while (p != NULL)
		{
			q = p;
			if (p->getData() < value)
			{
				p = p->getRight();
			}
			else if (p->getData() > value)
			{
				p = p->getLeft();
			}
			else
			{
				delete temp;
				return;
			}
		}
		if (q->getData() > value) q->setLeft(temp);
		else q->setRight(temp);
	}
}

void BinaryTree::Delete(int x)
{
	if (root == NULL) return;
	else
	{
		Node* delete_node = root;
		Node* parent = NULL;
		//tim kiem node chua gia tri can xoa
		while (delete_node != NULL)
		{
			if (delete_node->getData() == x) break;
			parent = delete_node;//parent luu node cha truoc khi chuyen
			if (delete_node->getData() < x) delete_node = delete_node->getRight();
			else delete_node = delete_node->getLeft();
		}
		if (delete_node != NULL)
		{
			// nếu node chứa giá trị cần xóa là Lá hoặc chỉ chứa 1 con
			if (delete_node->getLeft() == NULL || delete_node->getRight() == NULL)
			{
				if (parent == NULL)
				{
					root = delete_node->getLeft() == NULL ? delete_node->getRight() : delete_node->getLeft();
				}
				else
					if (delete_node->getLeft() != NULL) if (parent->getData() > delete_node->getData()) parent->setLeft(delete_node->getLeft()); else parent->setRight(delete_node->getLeft());
					else if (parent->getData() > delete_node->getData()) parent->setLeft(delete_node->getRight()); else parent->setRight(delete_node->getRight());
			}
			//chứa 2 con
			else
			{
				Node*temp = delete_node->getRight();
				//Nếu nút bên phải là nút chứa giá trị gần nhất với delete_node
				if (temp->getLeft() == NULL)
				{
					if (parent == NULL)
					{
						root = temp;
					}
					else
						//Gán lại liên kết giữa nút cha vs nút mới
						if (parent->getData() > delete_node->getData())
						{
							parent->setLeft(temp);
						}
						else
						{
							parent->setRight(temp);
						}
					temp->setLeft(delete_node->getLeft());
				}
				else
				{
					//tìm giá trị nhỏ nhất ở nhánh bên phải của node cần xóa- tức giá trị gần nhất
					while (temp->getLeft()->getLeft() != NULL)
					{
						temp = temp->getLeft();
					}
					//temp chứa node gần node có giá trị nhỏ nhất ở nhanh bên phải
					Node* temp0 = temp->getLeft();
					temp->setLeft(temp0->getRight());
					//Gán lại giá trị
					temp0->setLeft(delete_node->getLeft());
					temp0->setRight(delete_node->getRight());
					//Gán lại liên kết giữa nút cha vs nút mới
					if (parent == NULL) root = temp0;//tức nút xóa là Root của cây
					else
						if (parent->getData() > delete_node->getData()) parent->setLeft(temp0);
						else parent->setRight(temp0);
				}
			}
			delete delete_node;
		}
	}
}

Node * BinaryTree::Search(int value)
{
	Node* temp = root;
	while (temp != NULL)
	{
		if (temp->getData() < value)
		{
			temp = temp->getRight();
		}
		else if (temp->getData() > value)
		{
			temp = temp->getLeft();
		}
		else
		{
			return temp;
		}
	}
	return temp;
}

void BinaryTree::Show()
{
	RTLtraverse(root);
}
void BinaryTree::RTLtraverse(Node* node)
{
	if (node == NULL)     //Cay rong
		return;
	else
	{
		RTLtraverse(node->getRight());    //Duyet cay con phai theo thu tu giua
		cout << node->getData() << "; ";                //Tham nut
		RTLtraverse(node->getLeft());     //Duyet cay con trai theo thu tu giua
	}
}