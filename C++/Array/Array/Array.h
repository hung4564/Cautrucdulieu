#ifndef ARRAY_H
#define ARRAY_H
class Array
{
public:
	Array(int max);
	~Array();
private:
	int count;
	int max;
	int* array = nullptr;
};

#endif // !ARRAY_H

