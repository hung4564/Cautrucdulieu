#include<iostream>
#include "Array.h"
using namespace std;
void array_main()
{
	Array arrary;
	arrary.Push(5);
	arrary.Push(3);
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
}
int main()
{
	array_main();
	cout << endl;
	system("pause");
	return 0;
}