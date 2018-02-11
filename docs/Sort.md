# Giải thuật sặp xếp - Sort

## Interchange Sort - Đổi chỗ trực tiếp

- [Nghịch thế](#nghịch-thế)
- [Ý tưởng giải thuật](#ý-tưởng-giải-thuật)
- [Cài đặt](#cài-đặt)
- [Độ phức tạp thuật toán](#độ-phức-tạp-thuật-toán)

### Nghịch thế

Một cặp giá trị (a,b) được gọi là nghịch thế khi a và b không thỏa mãn điều kiện sắp thứ tự

VD: Liệt kê các cặp nghịch thế trong mảng {14,29,-1,1-,5,23}, yêu cầu sắp xếp tăng dần.
Kết quả:

- (14,-1),(14,10),(14,5)
- (29,-1),(29,10),(29,23)
- (10,5)

### Ý tưởng giải thuật

Giải thuật được thực hiện bằng cách duyệt qua tất các các cặp giá trị trong mảng và néu gặp cặp nghịch thế sẽ thực hiện viiệc hoán vị(đổi chỗ) cho nhau.

### Cài đặt

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

- Số bước so sánh: thuật toán gồm n-1 bước, ở bước thứ i có n-i phép so sánh -> có tổng cộng 1+2+...+n-1=n(n-1)/2  phép so sánh
- Số bước hoán vị
  - Tốt nhất: 0(mảng đã được sắp xếp)
  - Xấu nhất: n(n-1)/2(mảng sắp xếp ngược với yêu cầu)
- Độ phức tạp(N^2)