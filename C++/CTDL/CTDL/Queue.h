#ifndef QUEUE_H
#define QUEUE_H
int const max = 50;
class Queue
{
public:
	Queue();
	~Queue();
	bool IsEmpty();
	bool IsFull();
	int Dequeue();
	void Enqueue(int value);
	int Peek();
private:
	int first;
	int last;
	int queue[max];
	int count;
};
#endif // !QUEUE_H


