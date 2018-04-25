#include<iostream>
#include "Array.h"
using namespace std;
void array_main()
{
	Array arrary;
	arrary.Push(5);
	arrary.Push(3);
	arrary.Push(2);
	arrary.Push(1);
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	arrary.Insert(2, -1);
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	arrary.Prepend(-2);
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	cout << endl;
	cout << arrary.Find(-2);
	arrary.Delete(5);
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	for (size_t i = 0; i < 3; i++)
	{
		arrary.Push(7);
	}
	cout << endl;
	for (int i = 0; i < arrary.Count(); i++)
	{
		cout << arrary.At(i) << ";";
	}
	arrary.Remove(7);
	cout << endl;
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