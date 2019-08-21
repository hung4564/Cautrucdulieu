# Cấu trúc dữ liệu và giải thuật - Data Structure and Algorithms

## Cấu trúc dữ liệu

### Arrays

- Array
  - Miêu tả
    - [x] [Arrays - Mảng](./docs/Array.md)
  - [x] Cài đặt
    - [x] capacity() - Số lượng tối đa các phần tử mà mảng có thể lưu trữ
    - [x] at(index) - Trả về phần tử ở vị trí chỉ mục (index), hoặc lỗi nếu rơi ra ngoài chỉ mục
    - [x] push(item) Thêm vào một phần tử mới
    - [x] insert(index, item) - Thêm một phần tử mới tại vị trí của chỉ mục, điều chỉnh lại chỉ mục và đưa các phần tử còn lại dịch chuyển theo
    - [x] prepend(item) - Thêm tại vị trí chỉ mục 0, hay đầu tiên
    - [x] pop() - trả về phần tử cuối cùng
    - [x] delete(index) - Xóa phần tử tại chỉ mục, dịch chuyển lại các phần tử trong mảng
    - [x] remove(item) - Tìm theo giá trị của phần tử và xóa chỉ mục đang lưu trữ cho phần tử này (áp dụng với việc nhiều phần tử có cùng giá trị)
    - [x] find(item) - Tìm theo giá trị của phần tử và trả về chỉ mục đầu tiên tìm được, -1 nếu không tìm thấy
- Vector
  - Miêu tả:
    - Cấp phát mảng vector tự động tùy biến kích cỡ
      - [ ] [Vector](./docs/Array.md)
  - [ ] Cài đặt
    - [ ] Cấp phát vector (Mảng có thể thay đổi với khả năng tự điều chỉnh kích cỡ):
    - [ ] Tập sử dụng mảng và con trỏ, dùng phép toán con trỏ để nhảy tới một chỉ mục (index) thay vì sử dụng chỉ mục.
    - [ ] Tạo mảng mới với vùng nhớ được cấp phát sẵn
      - Có thể triển khai mảng số nguyên một cách nhanh chóng, nhưng không sử dụng các tính năng sẵn có
      - Bắt đầu với 16, hoặc số lớn hơn, với cấp số nhân của 2 - 16, 32, 64, 128
    - [ ] size() - Số lượng của các thành phần trong mảng
    - [ ] capacity() - Số lượng tối đa các phần tử mà mảng có thể lưu trữ
    - [ ] is_empty() - Kiểm tra mảng rỗng
    - [ ] at(index) - Trả về phần tử ở vị trí chỉ mục (index), hoặc lỗi nếu rơi ra ngoài chỉ mục
    - [ ] push(item) Thêm vào một phần tử mới
    - [ ] insert(index, item) - Thêm một phần tử mới tại vị trí của chỉ mục, điều chỉnh lại chỉ mục và đưa các phần tử còn lại dịch chuyển theo
    - [ ] prepend(item) - Thêm tại vị trí chỉ mục 0, hay đầu tiên
    - [ ] pop() - trả về phần tử cuối cùng
    - [ ] delete(index) - Xóa phần tử tại chỉ mục, dịch chuyển lại các phần tử trong mảng
    - [ ] remove(item) - Tìm theo giá trị của phần tử và xóa chỉ mục đang lưu trữ cho phần tử này (áp dụng với việc nhiều phần tử có cùng giá trị)
    - [ ] find(item) - Tìm theo giá trị của phần tử và trả về chỉ mục đầu tiên tìm được, -1 nếu không tìm thấy
    - [ ] resize(new_capacity) // private function
      - Khi tới giới hạn của mảng, tăng gấp đôi giá trị độ dài mảng để thay đổi kích thước
      - Khi xóa 1 thành phần, nếu kích thước hiện tại chỉ bằng 1/4 kích thước được cấp phát, thay đổi thành 1/2

### Linked Lists

- [x] Miêu tả:
  - [x] [Singly Linked List - Danh sách liên kết đơn](./docs/Linked%20list.md#single-linked-list)
  - [x] [Doubly Linked List - Danh sách liên kết đôi](./docs/Linked%20list.md#doubly-linked-list)
  - [x] [Circular Linked List - Danh sách liên kết vòng](./docs/Linked%20list.md#circular-linked-list)
- [ ] Danh sách liên kết so sánh với Mảng:
  - [x] [Bảng So sánh](./docs/so%20sanh%20mang%20vs%20list.md)
- [ ] Singly-linked List
  - [ ] Cài đặt
    - [x] Show() - Hiện giá trị của danh sách trên màn hình console
    - [x] size() - Trả về số lượng các phần tử trong danh sách
    - [x] empty() - Giá trị luận lý logic, true nếu rỗng
    - [x] AddFirst(value) - Thêm phần tử mới vào đầu danh sách
    - [x] DeleteFirst() - Xóa phần tử đầu tiên và trả về giá trị này
    - [x] Add(value) - Thêm phần tử tại cuối danh sách
    - [x] DeleteLast() - Xóa phần tử cuối và trả về giá trị
    - [x] GetFirst() - Lấy giá trị của phần tử đầu tiền
    - [x] AddBefore(value_node,value_them) - thêm phần từ mới trước giá trị node(nếu có)
    - [x] AddAfter(int value_node, int value_them) - thêm phần từ mới sau giá trị node(nếu có)
    - [x] DeleteNode(value) - Xóa dữ liệu đầu tiên được tìm thấy khớp với giá trị được cho
    - [x] Find(value) - Trả về phần tử chứa giá trị cần tìm
    - [ ] insert(index, value) - Thêm phần tử mới tại vị trí chỉ mục, phần tử hiện tại sẽ trỏ về phần tử mới tại vị trí chỉ mục này (A->B->C, thêm N tại vị trí B, A->D->B->C, A hiện giờ sẽ trỏ tới D, chỉ mục 1 sẽ trỏ tới D thay vì B)
    - [x] Erase(index) - Xóa node tại vị trí chỉ mục
    - [ ] value_n_from_end(n) - Trả về danh sách từ vị trí thứ n đến cuối danh sách
    - [ ] reverse() - đảo ngược danh sách
    - [ ] value_at(index) - Trả về phần tử tại vị trí thứ n (danh sách bắt đầu từ 0)
  - [ ] Doubly-linked List
    - [ ] Cài đặt
      - [x] Show() - Hiện giá trị của danh sách trên màn hình console
      - [ ] size() - Trả về số lượng các phần tử trong danh sách
      - [ ] empty() - Giá trị luận lý logic, true nếu rỗng
      - [ ] value_at(index) - Trả về phần tử tại vị trí thứ n (danh sách bắt đầu từ 0)
      - [x] AddFirst(value) - Thêm phần tử mới vào đầu danh sách
      - [x] DeleteFirst() - Xóa phần tử đầu tiên và trả về giá trị này
      - [x] Find(value) - Trả về phần tử chứa giá trị cần tìm
      - [x] AddLast(value) - Thêm phần tử tại cuối danh sách
      - [x] AddBefore(value_node,value_them) - thêm phần từ mới trước giá trị node(nếu có)
      - [x] AddAfter(int value_node, int value_them) - thêm phần từ mới sau giá trị node(nếu có)
      - [x] DeleteLast() - Xóa phần tử cuối và trả về giá trị
      - [x] GetFirst() - Lấy giá trị của phần tử đầu tiền
      - [x] GetLast() - Lấy giá trị của phần tử cuối cùng
      - [x] Delete(vaule) -Xóa phần tử chứa giá trị cho sẵn
      - [ ] insert(index, value) - Thêm phần tử mới tại vị trí chỉ mục, phần tử hiện tại sẽ trỏ về phần tử mới tại vị trí chỉ mục này (A->B->C, thêm N tại vị trí B, A->D->B->C, A hiện giờ sẽ trỏ tới D, chỉ mục 1 sẽ trỏ tới D thay vì B)
      - [ ] erase(index) - Xóa node tại vị trí chỉ mục
      - [ ] value_n_from_end(n) - Trả về danh sách từ vị trí thứ n đến cuối danh sách
      - [ ] reverse() - đảo ngược danh sách
      - [ ] remove_value(value) - Xóa dữ liệu đầu tiên được tìm thấy khớp với giá trị được cho
  - [ ] Circular-linked List
    - [ ] Cài đặt
      - [x] Show() - Hiện giá trị của danh sách trên màn hình console
      - [ ] size() - Trả về số lượng các phần tử trong danh sách
      - [ ] empty() - Giá trị luận lý logic, true nếu rỗng
      - [x] GetRoot() - Lấy giá trị của phần tử gốc
      - [x] Delete(vaule) -Xóa phần tử chứa giá trị cho sẵn
      - [x] Find(value) - Trả về phần tử chứa giá trị cần tìm

## Thuật toán

### Sắp xếp

- Miêu tả
  - [Sort - Sắp xếp](./docs/Sort.md)
- [ ] Cài đặt
  - Simple sorts
    - [x] Sắp xếp chọn (Selection Sort)
    - [x] Sắp xếp đổi chỗ trực tiếp (Interchange Sort)
    - [x] Sắp xếp chèn (Insertion Sort)
  - Efficient sorts
    - [ ] Sắp xếp chọn vun đống (Heapsort)
    - [ ] Sắp xếp nhanh (Quicksort)
    - [ ] Sắp xếp trộn (Merge Sort)
  - Bubble sort and variants
    - [x] Sắp xếp nổi bọt (Bubble Sort)
    - [ ] (Shell Sort)
    - [ ] Comb sort
  - Distribution sort
    - [ ] Counting sort
    - [ ] Bucket sort
    - [ ] Radix sort
