void Sort_Insertion(int a[], int n)
{
	int pos;//vị trí cần chèn
	int i;
	int x; // lưu phần từ a[i] tránh bị đè khi đổi chỗ các phần từ về sau
	for(i=1;i<n;i++)
	{
		x=a[i];
		pos=i-1;
		// tìm vị trí để chèn x vào đoạn trước
		while((pos>=0)&&a[pos]>x)
		{
			a[pos+1]=a[pos];
			pos--;
		}
		a[pos+1]=x;
	}
}