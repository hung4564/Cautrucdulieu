#include "Array.h"



Array::Array(int max)
{
	Array::max = max;
	Array::array = new int[max];
}


Array::~Array()
{
}
