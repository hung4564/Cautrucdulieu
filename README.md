# Cấu trúc dữ liệu và giải thuật

- [Cấu trúc dữ liệu và giải thuật](#c%e1%ba%a5u-tr%c3%bac-d%e1%bb%af-li%e1%bb%87u-v%c3%a0-gi%e1%ba%a3i-thu%e1%ba%adt)
  - [Tài liệu ghi chép](#t%c3%a0i-li%e1%bb%87u-ghi-ch%c3%a9p)
    - [Cấu trúc dữ liệu](#c%e1%ba%a5u-tr%c3%bac-d%e1%bb%af-li%e1%bb%87u)
    - [Giải thuật](#gi%e1%ba%a3i-thu%e1%ba%adt)
  - [Mục tiêu](#m%e1%bb%a5c-ti%c3%aau)
    - [Mục tiêu Cấu trúc dữ liệu](#m%e1%bb%a5c-ti%c3%aau-c%e1%ba%a5u-tr%c3%bac-d%e1%bb%af-li%e1%bb%87u)
    - [Mục tiêu Thuật toán](#m%e1%bb%a5c-ti%c3%aau-thu%e1%ba%adt-to%c3%a1n)
  - [Code](#code)

## Tài liệu ghi chép

### Cấu trúc dữ liệu

- Arrays
  - [x] [Arrays - Mảng](./docs/Array.md)
- Linked Lists:
  - [x] [Singly Linked List - Danh sách liên kết đơn](./docs/Linked%20list.md#single-linked-list)
  - [x] [Doubly Linked List - Danh sách liên kết đôi](./docs/Linked%20list.md#doubly-linked-list)
  - [x] [Circular Linked List - Danh sách liên kết vòng](./docs/Linked%20list.md#circular-linked-list)
- [x] Danh sách liên kết so sánh với Mảng:
  - [x] [Bảng So sánh](.docs/so%20sanh%20mang%20vs%20list.md)
- Tree
  - [x] [Tree - cây](./docs/Tree.md#Tree%20-%20Cây)
  - [x] [Binary tree - cây nhị phân](./docs/Tree.md#Binary%20tree%20-%20cây%20nhị%20phân)

### Giải thuật

- Sắp xếp
  - [Sort - Sắp xếp](./docs/Sort.md)

## Mục tiêu

### Mục tiêu Cấu trúc dữ liệu

#### Arrays

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

#### Linked Lists

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

#### Stack

#### Queue

#### Hash table

#### Cây

##### Cây tìm kiếm nhị phân

- [ ] Cài đặt:
  - [x] `insert` // thêm giá trị vào cây
  - [ ] `get_node_count` // lấy số lượng nút trong cây
  - [ ] `print_values` // In ra gíá trị trong cây, từ nhỏ nhất đến lớn nhất
  - [x] `delete_tree` // Xóa cây
  - [ ] `is_in_tree` // cho biết giá trị cho trước có tồn tại trong cây hay không
  - [ ] `get_height` // cho biết chiều cao của cây
  - [ ] `get_min` // cho biết giá trị nhỏ nhất trong cây
  - [ ] `get_max` // cho biết giá trị lớn nhất trong cây
  - [ ] `is_binary_search_tree` // kiểm tra xem cây cho trước có thỏa mãn điều kiện của một BST không.
  - [x] `delete_value` // xóa một giá trị trong cây
  - [ ] `get_successor` // Trả về phần tử cao nhất trong cây liền sau một gíá trị cho trước hoặc -1 nếu không tìm được
  - [x] `traveres` //Duyệt cây
  - [x] `RTLtraverse` //Đưa ra danh sách theo chiều giảm dần
  - [x] `LTRtraverse` //Đưa ra danh sách theo chiều tăng dần
  - [x] `Travere_Inorder` //Inorder duyệt theo thứ tự bên trái của node - duyệt node - duyệt bên phải của node
  - [x] `Travere_Postorder` //Postorder duyệt theo thứ tự bên trái của node - duyệt bên phải của node - duyệt node
  - [ ] `Travere_Pretorder` //Pretorder duyệt theo thứ tự duyệt node - cây bên trái của node - duyệt cây bên phải của node

#### Heap / Priority Queue / Binary Heap

- [ ] Tự cài đặt max-heap:
  - [ ] `insert`
  - [ ] `sift_up` - cần thiết cho hàm `insert`.
  - [ ] `get_max` - trả về phần tử lớn nhất mà không xóa nó khỏi heap
  - [ ] `get_size()` - trả về số lượng các phần từ trong một heap
  - [ ] `is_empty()` - trả về `true` nếu heap rỗng
  - [ ] `extract_max` - trà về phần tử lớn nhất và đồng thời xóa nó khỏi heap
  - [ ] `sift_down` - cần thiết cho hàm `extract_max`
  - [ ] `remove(i)` - xóa phần tử tại một vị trí `i` cho trước
  - [ ] `heapify` - tạo một heap từ một mảng các phần tử, cần thiết cho hàm `heap_sort`
  - [ ] `heap_sort()` - nhận vào một mảng chưa sắp xếp, sắp xếp nó tại chỗ (không tốn thêm bộ nhớ) bằng một kỹ thuật sử dụng heap
  - Chú ý: sử dụng min-heap sẽ tiết kiệm được một phép tính (giảm thời gian thực thi thuật toán), nhưng lại tốn gấp đôi bộ nhớ (để chứa kết quả phụ)

#### Đồ thị

### Mục tiêu Thuật toán

#### Sắp xếp

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

## Code

- Arrays
  - [x] C\C++
- Linked Lists
  - [x] C\C++
  - [x] C#
- Tree
  - [x] C#
