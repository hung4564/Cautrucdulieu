# Cấu trúc dữ liệu và giải thuật - Data Structure and Algorithms

## Mục Lục

- [Cấu trúc dữ liệu](#cấu-trúc-dữ-liệu)
  - [Arrays](#arrays)
  - [Linked Lists](#linked-lists)
  - [Stack](#stack)
  - [Queue](#queue)
  - [Hash table](#hash-table)
  - [Cây](#cây)
    - [Cây - Ghi chú và kiến thức nền](#cây---ghi-chú-và-kiến-thức-nền)
    - [Cây tìm kiếm nhị phân](#cây-tìm-kiếm-nhị-phân)
    - [Heap / Priority Queue / Binary Heap](#heap--priority-queue--binary-heap)
    - Cây tìm kiếm cân bằng (một chủ đề chung, không đi sâu vào chi tiết)
    - Duyệt cây: preorder, inorder, postorder, BFS, DFS
  - [Đồ thị](#đồ-thị)
- [Thuật toán](#thuật-toán)
  - [Sắp xếp](#sắp-xếp)
    - Sắp xếp chọn (Selection Sort)
    - Sắp xếp chèn (Insertion Sort)
    - Sắp xếp chọn vun đống (Heapsort)
    - Sắp xếp nhanh (Quicksort)
    - Sắp xếp trộn (Merge Sort)
  - [Tìm kiếm chuỗi](#tìm-kiếm-chuỗi)

## Cấu trúc dữ liệu

- ### Arrays

  - Array
    - Miêu tả
      - [X] [Arrays - Mảng](./docs/Array.md)
        - [X] Cài đặt 
          - [X] capacity() - Số lượng tối đa các phần tử mà mảng có thể lưu trữ
          - [X] at(index) - Trả về phần tử ở vị trí chỉ mục (index), hoặc lỗi nếu rơi ra ngoài chỉ mục
          - [X] push(item) Thêm vào một phần tử mới
          - [X] insert(index, item) - Thêm một phần tử mới tại vị trí của chỉ mục, điều chỉnh lại chỉ mục và đưa các phần tử còn lại dịch chuyển theo
          - [X] prepend(item) - Thêm tại vị trí chỉ mục 0, hay đầu tiên
          - [X] pop() - trả về phần tử cuối cùng
          - [X] delete(index) - Xóa phần tử tại chỉ mục, dịch chuyển lại các phần tử trong mảng
          - [X] remove(item) - Tìm theo giá trị của phần tử và xóa chỉ mục đang lưu trữ cho phần tử này (áp dụng với việc nhiều phần tử có cùng giá trị)
          - [X] find(item) - Tìm theo giá trị của phần tử và trả về chỉ mục đầu tiên tìm được, -1 nếu không tìm thấy
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

- ### Linked Lists
  - [X] Miêu tả:
    - [X] [Singly Linked List - Danh sách liên kết đơn](./docs/Linked%20list.md#single-linked-list)
    - [X] [Doubly Linked List - Danh sách liên kết đôi](./docs/Linked%20list.md#doubly-linked-list)
    - [X] [Circular Linked List - Danh sách liên kết vòng](./docs/Linked%20list.md#circular-linked-list)
  - [ ] Danh sách liên kết so sánh với Mảng:
    - [X] [Bảng So sánh](./docs/so%20sanh%20mang%20vs%20list.md)
    - [Core Linked Lists Vs Arrays - Danh sách liên kết Vs Mảng (video)](https://www.coursera.org/learn/data-structures-optimizing-performance/lecture/rjBs9/core-linked-lists-vs-arrays)- [In The Real World Linked Lists Vs Arrays - Trong thực tế, Danh sách liên kết Vs Mảng (video)](https://www.coursera.org/learn/data-structures-optimizing-performance/lecture/QUaUd/in-the-real-world-lists-vs-arrays)
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

- ### Stack

- ### Queue

- ### Hash table

## Cây

- ### Cây - Ghi chú và kiến thức nền

- ### Cây tìm kiếm nhị phân
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

- ### Heap / Priority Queue / Binary Heap
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

## Thuật toán

### Sắp xếp

### Tìm kiếm chuỗi