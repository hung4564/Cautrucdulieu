﻿#include "Sort.h"
#include <iostream>
using namespace std;

Sort::Sort()
{
}


void Sort::NhapMang(int a[], int n)
{
	cout << "Nhap cac gia tri cho cac phan tu trong mang" << endl;
	for (int i = 0; i < n; i++)
	{
		cout << "a[" << i << "]= ";
		cin >> a[i];
	}
}
/// <summary>
/// Xuats the mang.
/// </summary>
/// <param name="a">Mảng cần xem</param>
/// <param name="n">Số lượng phần tử</param>
void Sort::XuatMang(int a[], int n)
{
	cout << endl
		<< "gia tri cac phan tu trong mang la" << endl;
	for (int i = 0; i < n; i++)
	{
		cout << a[i] << ";";
	}
}
/// <summary>
/// Hoán vị 2 phần tử
/// </summary>
/// <param name="a">Phần tử đầu tiên</param>
/// <param name="b">Phần tử thứ hai</param>
void Sort::Hoanvi(int &a, int &b)
{
	int c;
	c = a;
	a = b;
	b = c;
}

/// <summary>
/// Interchange Sort - sắp xếp đổi chỗ trực tiếp tăng dần
/// </summary>
/// <param name="a">Mảng cần sắp xếp</param>
/// <param name="n">Số lượng phần tử</param>
void Sort::Sort_Interchange(int a[], int n)
{
	for (int i = 0; i < n - 1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			// sắp xếp tăng dần
			if (a[j] < a[i])
				Hoanvi(a[j], a[i]);
		}
	}
}

/// <summary>
/// Selection Sort - Sắp xếp chọn tăng dần
/// </summary>
/// <param name="a">Mảng cần sắp xếp</param>
/// <param name="n">Số lượng phần tử</param>
void Sort::Sort_Selection(int a[], int n)
{
	int min; //chi muc cua phan tu nho nhat
	for (int i = 0; i < n - 1; i++)
	{
		min = i;
		for (int j = i + 1; j < n; j++)
		{
			if (a[min] > a[j])
			{
				min = j;
			}
		}
		Hoanvi(a[min], a[i]);
	}
}
/// <summary>
/// Bubble Sort - Sắp xếp nổi bọt
/// </summary>
/// <param name="a">Mảng cần sắp xếp</param>
/// <param name="n">Số lượng phần tử</param>
void Sort::Sort_Bubble(int a[], int n)
{
	int j = n - 1, i = 0;
	for (i = 0; i < n - 1; i++)
	{
		for (j = n - 1; j > i; j--)
		{
			if (a[j] < a[j - 1])
				Hoanvi(a[j], a[j - 1]);
		}
	}
}
/// <summary>
/// Insertion Sort - Sắp xếp chèn
/// </summary>
/// <param name="a">Mảng cần sắp xếp</param>
/// <param name="n">Số lượng phần tử</param>
void Sort::Sort_Insertion(int a[], int n)
{
	int pos; //vị trí cần chèn
	int i;
	int x; // lưu phần từ a[i] tránh bị đè khi đổi chỗ các phần từ về sau
	for (i = 1; i < n; i++)
	{
		x = a[i];
		pos = i - 1;
		// tìm vị trí để chèn x vào đoạn trước
		while ((pos >= 0) && a[pos] > x)
		{
			a[pos + 1] = a[pos];
			pos--;
		}
		a[pos + 1] = x;
	}
}
/// <summary>
/// Shell Sort
/// </summary>
/// <param name="a">Mảng cần sắp xếp</param>
/// <param name="n">Số lượng phần tử</param>
void Sort::Sort_Shell(int a[], int n, int divideBy)
{
	int i, j, x, gap;
	for (gap = n / divideBy; gap > 0; gap /= divideBy)
	{
		for (i = gap; i < n; i++)
		{
			x = a[i];
			j = i - gap; //a[j] đừng kề trước a[i] trong cùng 1 dãy còn
			while ((x < a[j]) && (j >= 0))	// sắp xếp các dãy con chứa x
			{								// bằng phương pháp Insertion Sort
				a[j + gap] = a[j];
				j = j - gap;
			}
			a[j + gap] = x;
		}
	}
}
Sort::~Sort()
{
}
