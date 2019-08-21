# Cấu trúc dữ liệu - Data Structure

## Mục Lục

- [Cấu trúc dữ liệu - Data Structure](#c%e1%ba%a5u-tr%c3%bac-d%e1%bb%af-li%e1%bb%87u---data-structure)
  - [Mục Lục](#m%e1%bb%a5c-l%e1%bb%a5c)
  - [Cấu trúc dữ liệu](#c%e1%ba%a5u-tr%c3%bac-d%e1%bb%af-li%e1%bb%87u)
    - [Arrays](#arrays)
    - [Linked Lists](#linked-lists)
    - [Stack](#stack)
    - [Queue](#queue)
    - [Hash table](#hash-table)
  - [Cây](#c%c3%a2y)
    - [Cây - Ghi chú và kiến thức nền](#c%c3%a2y---ghi-ch%c3%ba-v%c3%a0-ki%e1%ba%bfn-th%e1%bb%a9c-n%e1%bb%81n)
    - [Cây tìm kiếm nhị phân](#c%c3%a2y-t%c3%acm-ki%e1%ba%bfm-nh%e1%bb%8b-ph%c3%a2n)
    - [Heap / Priority Queue / Binary Heap](#heap--priority-queue--binary-heap)
  - [Đồ thị](#%c4%90%e1%bb%93-th%e1%bb%8b)

## Cấu trúc dữ liệu

### Arrays

### Linked Lists

- [ ] Miêu tả:
  - [ ] [Singly Linked List - Danh sách liên kết đơn](../../docs/Linked%20list.md#single-linked-list)
  - [ ] [Doubly Linked List - Danh sách liên kết đôi](../../docs/Linked%20list.md#doubly-linked-list)
  - [ ] [Circular Linked List - Danh sách liên kết vòng](../../docs/Linked%20list.md#circular-linked-list)
- [ ] Danh sách liên kết so sánh với Mảng:
  - [ ] [Bảng So sánh](../../docs/so%20sanh%20mang%20vs%20list.md)
- [ ] Singly-linked List
  - [ ] Cài đặt
    - [ ] Show() - Hiện giá trị của danh sách trên màn hình console
    - [ ] size() - Trả về số lượng các phần tử trong danh sách
    - [ ] empty() - Giá trị luận lý logic, true nếu rỗng
    - [ ] AddFirst(value) - Thêm phần tử mới vào đầu danh sách
    - [ ] DeleteFirst() - Xóa phần tử đầu tiên và trả về giá trị này
    - [ ] Add(value) - Thêm phần tử tại cuối danh sách
    - [ ] DeleteLast() - Xóa phần tử cuối và trả về giá trị
    - [ ] GetFirst() - Lấy giá trị của phần tử đầu tiền
    - [ ] AddBefore(value_node,value_them) - thêm phần từ mới trước giá trị node(nếu có)
    - [ ] AddAfter(int value_node, int value_them) - thêm phần từ mới sau giá trị node(nếu có)
    - [ ] DeleteNode(value) - Xóa dữ liệu đầu tiên được tìm thấy khớp với giá trị được cho
    - [ ] Find(value) - Trả về phần tử chứa giá trị cần tìm
    - [ ] insert(index, value) - Thêm phần tử mới tại vị trí chỉ mục, phần tử hiện tại sẽ trỏ về phần tử mới tại vị trí chỉ mục này (A->B->C, thêm N tại vị trí B, A->D->B->C, A hiện giờ sẽ trỏ tới D, chỉ mục 1 sẽ trỏ tới D thay vì B)
    - [ ] Erase(index) - Xóa node tại vị trí chỉ mục
    - [ ] value_n_from_end(n) - Trả về danh sách từ vị trí thứ n đến cuối danh sách
    - [ ] reverse() - đảo ngược danh sách
    - [ ] value_at(index) - Trả về phần tử tại vị trí thứ n (danh sách bắt đầu từ 0)
  - [ ] Doubly-linked List
    - [ ] Cài đặt
      - [ ] Show() - Hiện giá trị của danh sách trên màn hình console
      - [ ] size() - Trả về số lượng các phần tử trong danh sách
      - [ ] empty() - Giá trị luận lý logic, true nếu rỗng
      - [ ] value_at(index) - Trả về phần tử tại vị trí thứ n (danh sách bắt đầu từ 0)
      - [ ] AddFirst(value) - Thêm phần tử mới vào đầu danh sách
      - [ ] DeleteFirst() - Xóa phần tử đầu tiên và trả về giá trị này
      - [ ] Find(value) - Trả về phần tử chứa giá trị cần tìm
      - [ ] AddLast(value) - Thêm phần tử tại cuối danh sách
      - [ ] AddBefore(value_node,value_them) - thêm phần từ mới trước giá trị node(nếu có)
      - [ ] AddAfter(int value_node, int value_them) - thêm phần từ mới sau giá trị node(nếu có)
      - [ ] DeleteLast() - Xóa phần tử cuối và trả về giá trị
      - [ ] GetFirst() - Lấy giá trị của phần tử đầu tiền
      - [ ] GetLast() - Lấy giá trị của phần tử cuối cùng
      - [ ] Delete(vaule) -Xóa phần tử chứa giá trị cho sẵn
      - [ ] insert(index, value) - Thêm phần tử mới tại vị trí chỉ mục, phần tử hiện tại sẽ trỏ về phần tử mới tại vị trí chỉ mục này (A->B->C, thêm N tại vị trí B, A->D->B->C, A hiện giờ sẽ trỏ tới D, chỉ mục 1 sẽ trỏ tới D thay vì B)
      - [ ] erase(index) - Xóa node tại vị trí chỉ mục
      - [ ] value_n_from_end(n) - Trả về danh sách từ vị trí thứ n đến cuối danh sách
      - [ ] reverse() - đảo ngược danh sách
      - [ ] remove_value(value) - Xóa dữ liệu đầu tiên được tìm thấy khớp với giá trị được cho
  - [ ] Circular-linked List
    - [ ] Cài đặt
      - [ ] Show() - Hiện giá trị của danh sách trên màn hình console
      - [ ] size() - Trả về số lượng các phần tử trong danh sách
      - [ ] empty() - Giá trị luận lý logic, true nếu rỗng
      - [ ] GetRoot() - Lấy giá trị của phần tử gốc
      - [ ] Delete(vaule) -Xóa phần tử chứa giá trị cho sẵn
      - [ ] Find(value) - Trả về phần tử chứa giá trị cần tìm

### Stack

### Queue

### Hash table

## Cây

### Cây - Ghi chú và kiến thức nền

### Cây tìm kiếm nhị phân

- [ ] Cài đặt:

  - [ ] `insert` // thêm giá trị vào cây
  - [ ] `get_node_count` // lấy số lượng nút trong cây
  - [ ] `print_values` // In ra gíá trị trong cây, từ nhỏ nhất đến lớn nhất
  - [ ] `delete_tree` // Xóa cây
  - [ ] `is_in_tree` // cho biết giá trị cho trước có tồn tại trong cây hay không
  - [ ] `get_height` // cho biết chiều cao của cây
  - [ ] `get_min` // cho biết giá trị nhỏ nhất trong cây
  - [ ] `get_max` // cho biết giá trị lớn nhất trong cây
  - [ ] `is_binary_search_tree` // kiểm tra xem cây cho trước có thỏa mãn điều kiện của một BST không.
  - [ ] `delete_value` // xóa một giá trị trong cây
  - [ ] `get_successor` // Trả về phần tử cao nhất trong cây liền sau một gíá trị cho trước hoặc -1 nếu không tìm được

### Heap / Priority Queue / Binary Heap

- [ ] Tự cài đặt max-heap:
  - [ ] `insert`
  - [ ] `sift_up` - cần thiết cho hàm `insert` .
  - [ ] `get_max` - trả về phần tử lớn nhất mà không xóa nó khỏi heap
  - [ ] `get_size()` - trả về số lượng các phần từ trong một heap
  - [ ] `is_empty()` - trả về `true` nếu heap rỗng
  - [ ] `extract_max` - trà về phần tử lớn nhất và đồng thời xóa nó khỏi heap
  - [ ] `sift_down` - cần thiết cho hàm `extract_max`
  - [ ] `remove(i)` - xóa phần tử tại một vị trí `i` cho trước
  - [ ] `heapify` - tạo một heap từ một mảng các phần tử, cần thiết cho hàm `heap_sort`
  - [ ] `heap_sort()` - nhận vào một mảng chưa sắp xếp, sắp xếp nó tại chỗ (không tốn thêm bộ nhớ) bằng một kỹ thuật sử dụng heap
  - Chú ý: sử dụng min-heap sẽ tiết kiệm được một phép tính (giảm thời gian thực thi thuật toán), nhưng lại tốn gấp đôi bộ nhớ (để chứa kết quả phụ)

## Đồ thị
