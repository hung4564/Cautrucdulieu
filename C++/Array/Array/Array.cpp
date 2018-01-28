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

void Array::Insert(int index, int item)
{
	if (index < max&&index >= 0)
	{
		if (count < max - 1)
		{
			for (size_t i = count - 1; i >= index - 1; i--)
			{
				mang[i + 1] = mang[i];
			}
			mang[index - 1] = item;
			count++;
		}
	}
}

void Array::Prepend(int item)
{
	if (count < max - 1)
	{
		for (size_t i = count - 1; i > 0; i--)
		{
			mang[i + 1] = mang[i];
		}
		mang[0] = item;
		count++;
	}
}

int Array::Pop()
{
	if (count > 0) return mang[count - 1];
	return 0;
}

int Array::Find(int item)
{
	for (int i = 0; i < count; i++)
	{
		if (item == mang[i]) return i;
	}
	return -1;
}

void Array::Delete(int index)
{
	if (index >= 0 && index < count)
	{
		for (size_t i = index; i < count - 1; i++)
		{
			mang[i] = mang[i + 1];
		}
		count--;
	}
}

void Array::Remove(int item)
{
	if (count > 0)
	{
		int index = 0;
		while (true)
		{
			index = Find(item);
			if (index > -1)Delete(index);
			else break;
		}
	}
}
