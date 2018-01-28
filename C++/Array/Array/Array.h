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
private:
	int count;
	int max;
	int mang[max_count];
};

#endif // !ARRAY_H

