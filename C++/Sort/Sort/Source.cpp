#include <iostream>
using namespace std;
void NhapMang(int a[], int n);
void XuatMang(int a[], int n);
void Sort_Interchange(int a[],int n);
void Hoanvi(int &a, int &b);
int main()
{
	int n = 5;
	int a[10];
	NhapMang(a, n);
	XuatMang(a, n);
	Sort_Interchange(a, n);
	XuatMang(a,n);
	cout << endl;
	system("pause");
	return 0;
}
/// <summary>
/// Nhaps the mang.
/// </summary>
/// <param name="a">Mảng cần nhập</param>
/// <param name="n">Số lượng phần tử</param>
void NhapMang(int a[], int n)
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
void XuatMang(int a[], int n)
{
	cout << endl <<"gia tri cac phan tu trong mang la"<<endl;
	for (int i = 0; i < n; i++)
	{
		cout <<a[i]<<";";
	}
}
/// <summary>
/// Interchange Sort - Đổi chỗ trực tiếp tăng dần
/// </summary>
/// <param name="a">Mảng cần sắp xếp</param>
/// <param name="n">Số lượng phần tử</param>
void Sort_Interchange(int a[], int n)
{
	for (int i = 0; i < n-1; i++)
	{
		for (int j = i + 1; j < n; j++)
		{
			// sắp xếp tăng dần
			if (a[j] < a[i]) Hoanvi(a[j], a[i]);
		}
	}
}
/// <summary>
/// Hoán vị 2 phần tử
/// </summary>
/// <param name="a">Phần tử đầu tiên</param>
/// <param name="b">Phần tử thứ hai</param>
void Hoanvi(int &a, int &b)
{
	int c;
	c = a;
	a = b;
	b = c;
}