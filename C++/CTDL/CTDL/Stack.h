#ifndef  STACK_H
#define STACK_H
int const MaxSize = 50;
class Stack
{
public:
	Stack();
	~Stack();
	bool IsEmpty();
	bool IsFull();
	void Push(int value);
	int Pop();
	int Peek();
private:
	int top;
	int stack[MaxSize];
};
#endif // ! STACK_H

