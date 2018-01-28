#include "Array.h"
#include <iostream>
using namespace std;


Array::Array()
{
	max = max_count;
	count = 0;
}

Array::Array(int max)
{
	Array::max = max;
	count = 0;
}


Array::~Array()
{
}

int Array::Count()
{
	return count;
}

int Array::Capacity()
{
	return max;
}

int Array::At(int index)
{
	if (index >= 0 && index < max) return mang[index];
	return 0;
}

void Array::Push(int value)
{
	if (count < max)
	{
		mang[count] = value;
		count++;
	}
}
