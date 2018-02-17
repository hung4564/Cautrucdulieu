# Giải thuật sặp xếp - Sort

- [Interchange Sort - sắp xếp đổi chỗ trực tiếp](#interchange_sort)
- [Selection Sort - Sắp xếp chọn](#selection_sort)
- [Bubble Sort - Sắp xếp nổi bọt](#bubble_sort)
- [Insertion Sort - Sắp xếp chèn](#insertion_sort)
- [Shell Sort](#shell_sort)

## Interchange Sort - sắp xếp đổi chỗ trực tiếp  <a name="interchange_sort"></a>

- [Nghịch thế](#nghịch-thế)
- [Ý tưởng giải thuật](#interchange_sort-ytuong)
- [Cài đặt](#interchange_sort-setup)
- [Độ phức tạp thuật toán](#interchange_sort-dpt)

### Nghịch thế

Một cặp giá trị (a,b) được gọi là nghịch thế khi a và b không thỏa mãn điều kiện sắp thứ tự.

VD: Liệt kê các cặp nghịch thế trong mảng {14,29,-1,1-,5,23}, yêu cầu sắp xếp tăng dần.
Kết quả:

- (14,-1),(14,10),(14,5)
- (29,-1),(29,10),(29,23)
- (10,5)

### Ý tưởng giải thuật <a name="interchange_sort-ytuong"></a>

Giải thuật được thực hiện bằng cách duyệt qua tất các các cặp giá trị trong mảng và néu gặp cặp nghịch thế sẽ thực hiện viiệc hoán vị(đổi chỗ) cho nhau.

### Cài đặt <a name="interchange_sort-setup"></a>

``` C++
void Sort_Interchange(int a[], int n)
{
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = i + 1; j < n; j++)
        {
        // sắp xếp tăng dần
            if (a[j] < a[i]) Hoanvi(a[j], a[i]);
        }
    }
}
```

### Độ phức tạp thuật toán <a name="interchange_sort-dpt"></a>

- Số bước so sánh: thuật toán gồm n-1 bước, ở bước thứ i có n-i phép so sánh -> có tổng cộng 1+2+...+n-1=n(n-1)/2  phép so sánh
- Số bước hoán vị
  - Tốt nhất: 0(mảng đã được sắp xếp)
  - Xấu nhất: n(n-1)/2(mảng sắp xếp ngược với yêu cầu)
- Độ phức tạp(N^2)

## Selection Sort - Sắp xếp chọn <a name="selection_sort"></a>

- [Ý tưởng giải thuật](#selection_sort-ytuong)
- [Cài đặt](#selection_sort-setup)
- [Độ phức tạp thuật toán](#selection_sort-dpt)

### Ý tưởng giải thuật <a name="selection_sort-ytuong"></a>

- Chọn phần tử nhó nhất trong N phần tự trong dãy ban đầu.
- Đưa phần từ này về vị trí đầu dãy hiền hành
- Xem dãy hiện hành chỉ còn N-1 phần tử và lặp lại các bước đến khi chỉ còn 1 phần tử.

### Cài đặt <a name="selection_sort-setup"></a>

``` C++
void Sort_Selection(int a[], int n)
{
    int min;//chi muc cua phan tu nho nhat
    for (int i = 0; i < n-1; i++)
    {
        min = i;
        for (int j = i+1; j < n; j++)
        {
            if (a[min] > a[j])
            {
            in = j;
            }
        }
        Hoanvi(a[min], a[i]);
    }
}
```

### Độ phức tạp thuật toán <a name="selection_sort-dpt"></a>

- Số bước so sánh: thuật toán gồm n-1 bước, ở bước thứ i có n-i phép so sánh -> có tổng cộng 1+2+...+n-1=n(n-1)/2  phép so sánh
- Số bước hoán vị
  - Tốt nhất: 0(mảng đã được sắp xếp)
  - Xấu nhất: 3*n*(n-1)/2
- Độ phức tạp: (N^2)

## Bubble Sort - Sắp xếp nổi bọt <a name="bubble_sort"></a>

- [Ý tưởng giải thuật](#bubble_sort-ytuong)
- [Cài đặt](#bubble_sort-setup)
- [Độ phức tạp thuật toán](#bubble_sort-dpt)

### Ý tưởng giải thuật <a name="bubble_sort-ytuong"></a>

- Xuất phát từ cuối dãy, đổi chỗ các cặp phần tử kế cận để đưa phần tử nhỏ hơn trong cặp phẩn tử đó về vị trí đứng đầu dãy hiện hành, sau đó sẽ không xét đến nó ở bước kế tiếp, do vậy ở lần xử lý thứu i sẽ có vị trí đầu dãy là i.
- lặp lại xử lý trên đến khi không còn cặp phần từ nào để xét.

### Cài đặt <a name="bubble_sort-setup"></a>

``` C++
void Sort_Bubble(int a[], int n)
{
    int j=n-1, i=0;
    for(i=0;i<n-1;i++)
    {
        for(j=n-1;j>i;j--)
        {
            if(a[j]<a[j-1]) Hoanvi(a[j],a[j-1]);
        }
    }
}
```

### Độ phức tạp thuật toán <a name="bubble_sort-dpt"></a>

- Số bước so sánh: thuật toán gồm n-1 bước, ở bước thứ i có n-i phép so sánh -> có tổng cộng 1+2+...+n-1=n(n-1)/2  phép so sánh
- Số bước hoán vị
  - Tốt nhất: 0(mảng đã được sắp xếp)
  - Xấu nhất: n(n-1)/2(mảng sắp xếp ngược với yêu cầu)
- Độ phức tạp(N^2)

## Insertion Sort - Sắp xếp chèn <a name="insertion_sort"></a>

- [Ý tưởng giải thuật](#insertion_sort-ytuong)
- [Cài đặt](#insertion_sort-setup)
- [Độ phức tạp thuật toán](#insertion_sort-dpt)

### Ý tưởng giải thuật <a name="insertion_sort-ytuong"></a>

- giả sử mảng đã có i phần tử đầu tiên **đã có thứ tự**
- Tìm cách chèn phần tử thứ i vào vị trị thích hợp của đoạn đã được sắp trước đó, khiến mảng mới trở nên có thứ tự.

### Cài đặt <a name="insertion_sort-setup"></a>

```C++
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
```

### Độ phức tạp thuật toán <a name="insertion_sort-dpt"></a>

|Trường hợp|Số phép so sánh|Số phép gán|
|---|---|---|
|Tốt  nhất|n-1|2(n-1)|
|Xấu nhất|(n-1)/2|n*(n+1)/2-1|

- Độ phức tạp(N^2)

## Shell Sort <a name="shell_sort"></a>

- [Ý tưởng giải thuật](#shell_sort-ytuong)
- [Cài đặt](#shell_sort-setup)
- [Độ phức tạp thuật toán](#shell_sort-dpt)

### Ý tưởng giải thuật <a name="shell_sort-ytuong"></a>

- Cải tiến từ phướng pháp [Insertion Sort](#insertion_sort)
- Phân hoạch dãy thành các dãy con ở cách nhau **h** vị trí
  - chọn **h** một cách hợp lý:
    - h = h * 3 + 1(công thức Knuth)
    - h=h/2 và h đầu bằng n/2
    - h=h/3 và h đều bằng n/3
    - h là dãy fibonaci
    - h là dãy các ngtố giảm dần
- Sắp xếp các con theo phương pháp chèn trực tiếp
- Dùng phương pháp [Insertion Sort](#insertion_sort) sắp xếp lại cả dãy

### Cài đặt <a name="shell_sort-setup"></a>

```C++
void Sort_Shell(int a[], int n, int divideBy)
{
    int i, j, x, gap;
    for (gap = n / divideBy; gap > 0; gap /= divideBy)
    {
        for (i = gap; i < n; i++)
        {
            x = a[i];
            j = i - gap; //a[j] đừng kề trước a[i] trong cùng 1 dãy còn
            while ((x < a[j]) && (j >= 0))  // sắp xếp các dãy con chứa x
            {                               // bằng phương pháp Insertion Sort
                a[j + gap] = a[j];
                j = j - gap;
            }
            a[j + gap] = x;
        }
    }
}
```

### Độ phức tạp thuật toán <a name="shell_sort-dpt"></a>
