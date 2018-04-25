#pragma once
class Sort
{
public:
	Sort();
	void NhapMang(int a[], int n);
	void XuatMang(int a[], int n);
	void Hoanvi(int &a, int &b);
	void Sort_Interchange(int a[], int n);
	void Sort_Selection(int a[], int n);
	void Sort_Bubble(int a[], int n);
	void Sort_Insertion(int a[], int n);
	void Sort_Shell(int a[], int n, int divideBy);
	~Sort();
};

