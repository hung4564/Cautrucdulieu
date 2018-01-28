#ifndef ARRAY_H
#define ARRAY_H
#define max_count 50
class Array
{
public:
	Array();
	Array(int max);
	~Array();
	int Count();
	int Capacity();
	int At(int index);
	void Push(int value);
	void Insert(int index, int item);
	void Prepend(int item);
	int Pop();
	int Find(int item);
	void Delete(int index);
	void Remove(int item);
private:
	int count;
	int max;
	int mang[max_count];
};

#endif // !ARRAY_H

