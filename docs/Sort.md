# Giải thuật sặp xếp - Sort

- [Interchange Sort - Đổi chỗ trực tiếp](#interchange_sort)
- [Selection Sort - Chọn trục tiếp](#selection_sort)

## Interchange Sort - Đổi chỗ trực tiếp

<a name="interchange_sort"></a>

- [Nghịch thế](#nghịch-thế)
- [Ý tưởng giải thuật](#interchange_sort-ytuong)
- [Cài đặt](#interchange_sort-setup)
- [Độ phức tạp thuật toán](#interchange_sort-dpt)

### Nghịch thế

Một cặp giá trị (a,b) được gọi là nghịch thế khi a và b không thỏa mãn điều kiện sắp thứ tự

VD: Liệt kê các cặp nghịch thế trong mảng {14,29,-1,1-,5,23}, yêu cầu sắp xếp tăng dần.
Kết quả:

- (14,-1),(14,10),(14,5)
- (29,-1),(29,10),(29,23)
- (10,5)

### Ý tưởng giải thuật

<a name="interchange_sort-ytuong"></a>

Giải thuật được thực hiện bằng cách duyệt qua tất các các cặp giá trị trong mảng và néu gặp cặp nghịch thế sẽ thực hiện viiệc hoán vị(đổi chỗ) cho nhau.

### Cài đặt

<a name="interchange_sort-setup"></a>

```C++
- b1: i=0;   // bắt đầu từ đầu dãy
- b2: j=i+1; // tìm các nghịch thế với a[i]
- b3:
    Trong khi j<N thực hiện
        If a[j]<a[i]
            Đổi chỗ(a[i],a[j])
    j=j+1;
- b4: i=i+1;
    if i<N-1: lặp lại b2;
    else Dừng
```

### Độ phức tạp thuật toán

<a name="interchange_sort-dpt"></a>

- Số bước so sánh: thuật toán gồm n-1 bước, ở bước thứ i có n-i phép so sánh -> có tổng cộng 1+2+...+n-1=n(n-1)/2  phép so sánh
- Số bước hoán vị
  - Tốt nhất: 0(mảng đã được sắp xếp)
  - Xấu nhất: n(n-1)/2(mảng sắp xếp ngược với yêu cầu)
- Độ phức tạp(N^2)

## Selection Sort - Chọn trục tiếp

<a name="selection_sort"></a>

- [Ý tưởng giải thuật](#selection_sort-ytuong)
- [Cài đặt](#selection_sort-setup)
- [Độ phức tạp thuật toán](#selection_sort-dpt)

### Ý tưởng giải thuật

<a name="selection_sort-ytuong"></a>

- Chọn phần tử nhó nhất trong N phần tự trong dãy ban đầu.
- Đưa phần từ này về vị trí đầu dãy hiền hành
- Xem dãy hiện hành chỉ còn N-1 phần tử và lặp lại các bước đến khi chỉ còn 1 phần tử.

### Cài đặt

<a name="selection_sort-setup"></a>

```C++
- b1: i=0;   // bắt đầu từ đầu dãy
- b2: Tìm phần tử nhỏ nhất trong dãy hiện hành từ i tới n
- b3: Đổi chỗ a[min] và a[i]
    j=j+1;
- b4: i=i+1;
    if i<N-1: lặp lại b2;
    else Dừng
```

### Độ phức tạp thuật toán

<a name="selection_sort-dpt"></a>

- Số bước so sánh: thuật toán gồm n-1 bước, ở bước thứ i có n-i phép so sánh -> có tổng cộng 1+2+...+n-1=n(n-1)/2  phép so sánh
- Số bước hoán vị
  - Tốt nhất: 0(mảng đã được sắp xếp)
  - Xấu nhất: 3*n*(n-1)/2
- Độ phức tạp: (N^2)
