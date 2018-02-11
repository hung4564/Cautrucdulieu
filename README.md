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
- [Sắp xếp](#sắp-xếp)
    - Sắp xếp chọn (Selection Sort)
    - Sắp xếp chèn (Insertion Sort)
    - Sắp xếp chọn vun đống (Heapsort)
    - Sắp xếp nhanh (Quicksort)
    - Sắp xếp trộn (Merge Sort)
- [Đồ thị](#đồ-thị)

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
  - [ ] [Chuỗi bài giảng: Căn bản về cây](https://www.coursera.org/learn/data-structures-optimizing-performance/lecture/ovovP/core-trees)
    - [ ] [Chuỗi bài giảng: Cây](https://www.coursera.org/learn/data-structures/lecture/95qda/trees)
    - Xây dựng cây cơ bản.
    - Duyệt cây.
    - Các thuật toán biến đổi.
    - BFS - Tìm kiếm ưu tiên chiều rộng (breadth-first search)
      - [MIT (video)](https://www.youtube.com/watch?v=s-CYnVz-uh4&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb&index=13)
      - Các thứ tự duyết (BFS, sử dụng `queue`)
            Độ phức tạp thời gian: O(n)
            Độ phức tạp không gian: tốt nhất: O(1), tệ nhất: O(n/2)=O(n)
    - DFS - Tìm kiếm ưu tiên chiều sâu (depth-first search)
      - [MIT (video)](https://www.youtube.com/watch?v=AfSk24UTFS8&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb&index=14)
      - Ghi chú:
            Độ phức tạp thời gian: O(n)
            Độ phức tạp không gian:
                tốt nhất: O(log n) - trung bình: bằng chiều cao của cây
                tệ nhất: O(n)
      - theo thứ tự (inorder) - (DFS: left, self, right)
      - nhánh con trước (postorder) - (DFS: left, right, self)
      - nhánh con sau (preorder) - (DFS: self, left, right)

- ### Cây tìm kiếm nhị phân
    BST: Binary search tree - cây tìm kiếm nhị phân.
    - [ ] [Ôn lại cây tìm kiếm nhị phân - video](https://www.youtube.com/watch?v=x6At0nzX92o&index=1&list=PLA5Lqm4uh9Bbq-E0ZnqTIa8LRaL77ica6)
    - [ ] [Chuỗi video](https://www.coursera.org/learn/data-structures-optimizing-performance/lecture/p82sw/core-introduction-to-binary-search-trees)
      - Khởi đầu với bảng ký hiệu và đi xuyên suốt các ứng dụng của BST (Binary search tree).
    - [ ] [Dẫn nhập - video](https://www.coursera.org/learn/data-structures/lecture/E7cXP/introduction)
    - [ ] [MIT - video](https://www.youtube.com/watch?v=9Jry5-82I68)
    - C/C++:
        - [ ] [Cây tìm kiếm nhị phân - Cài đặt trên C/C++ - video](https://www.youtube.com/watch?v=COZK7NATh4k&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=28)
        - [ ] [Cài đặt BST - cấp phát bộ nhớ trên `stack` và `heap` - video](https://www.youtube.com/watch?v=hWokyBoo0aI&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=29)
        - [ ] [Tìm phần tử nhỏ nhất và lớn nhất trong BST - video](https://www.youtube.com/watch?v=Ut90klNN264&index=30&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P)
        - [ ] [Tìm chiều cao của BST - video](https://www.youtube.com/watch?v=_pnqMz5nrRs&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=31)
        - [ ] [Duyệt cây nhị phân - các chiến lược BFS và DFS - video](https://www.youtube.com/watch?v=9RHO6jU--GU&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=32)
        - [ ] [Cây nhị phân: duyệt theo cấp - video](https://www.youtube.com/watch?v=86g8jAQug04&index=33&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P)
        - [ ] [Duyệt cây nhị phân: Preorder, Inorder, Postorder - video](https://www.youtube.com/watch?v=gm8DUJJhmY4&index=34&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P)
        - [ ] [Kiểm tra một cậy nhị phân có phải là BST không - video](https://www.youtube.com/watch?v=yEwSGhSsT0U&index=35&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P)
        - [ ] [Xóa một nút trong BST - video](https://www.youtube.com/watch?v=gcULXE7ViZw&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P&index=36)
        - [ ] [Xác định nút tiếp theo một nút cho trước khi duyệt cây inorder (Inorder Successor in a binary search tree) - video](https://www.youtube.com/watch?v=5cPbNCrdotA&index=37&list=PL2_aWCzGMAwI3W_JlcBbtYTwiQSsOTa6P)
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
    - hình thức thể hiện như một cây, nhưng chúng thường được lưu trữ theo kiểu tuyến tính (mảng, danh sách liên kết)
    - [ ] [Heap](https://en.wikipedia.org/wiki/Heap_(data_structure))
    - [ ] [Dẫn nhập - video](https://www.coursera.org/learn/data-structures/lecture/2OpTs/introduction)
    - [ ] [Cài đặt căn bản - video](https://www.coursera.org/learn/data-structures/lecture/z3l9N/naive-implementations)
    - [ ] [Cây nhị phân - video](https://www.coursera.org/learn/data-structures/lecture/GRV2q/binary-trees)
    - [ ] [Các lưu ý về chiều cao của cây - video](https://www.coursera.org/learn/data-structures/supplement/S5xxz/tree-height-remark)
    - [ ] [Các toán tử cơ bản - video](https://www.coursera.org/learn/data-structures/lecture/0g1dl/basic-operations)
    - [ ] [Cây nhị phân đầy đủ - video](https://www.coursera.org/learn/data-structures/lecture/gl5Ni/complete-binary-trees)
    - [ ] [Mã giả - video](https://www.coursera.org/learn/data-structures/lecture/HxQo9/pseudocode)
    - [ ] [Heap Sort - video](https://youtu.be/odNJmw5TOEE?list=PLFDnELG9dpVxQCxuD-9BSy2E7BWY3t5Sm&t=3291)
    - [ ] [Heap Sort - coursera - video](https://www.coursera.org/learn/data-structures/lecture/hSzMO/heap-sort)
    - [ ] [Xây dựng một heap - video](https://www.coursera.org/learn/data-structures/lecture/dwrOS/building-a-heap)
    - [ ] [MIT: Heaps và Heap Sort - video](https://www.youtube.com/watch?v=B7hVxCmfPtM&index=4&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb)
    - [ ] [CS 61B Lecture 24: Priority Queues - video](https://www.youtube.com/watch?v=yIUFT6AKBGE&index=24&list=PL4BBB74C7D2A1049C)
    - [ ] [Xây dựng Heap với thời gian tuyến tính `O(n)`](https://www.youtube.com/watch?v=MiyLo8adrWw)
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

### Sắp xếp

- [ ] Ghi chú:
  - Cài đặt các thuật toán sắp xếp và với mỗi thuật toán, nắm vững độ phức tạp trong các trường hợp tốt nhất, xấu nhất và trung bình:
    - Bỏ qua sắp xếp nổi bọt (bubble sort) - thực thi thảm hại - O(n^2), trừ khi n <= 16
    - [ ] Tính ổn định của các thuật toán sắp xếp ("Sắp xếp nhanh (Quicksort) có ổn định không?")
      - [Tính ổn định của các thuật toán sắp xếp](https://en.wikipedia.org/wiki/Sorting_algorithm#Stability) (wiki)
      - [Tính ổn định trong các thuật toán sắp xếp](http://stackoverflow.com/questions/1517793/stability-in-sorting-algorithms) (stackoverflow)
      - [Tính ổn định trong các thuật toán sắp xếp](http://www.geeksforgeeks.org/stability-in-sorting-algorithms/) (geeksforgeeks)
      - [Các thuật toán sắp xếp - Tính ổn định](http://homepages.math.uic.edu/~leon/cs-mcs401-s08/handouts/stability.pdf) (pdf)
    - [ ] Các thuật toán nào có thể được sử dụng trên danh sách liên kết? mảng? cả hai?
        - Tôi không khuyến khích sắp xếp một danh sách liên kết, nhưng sắp xếp trộn (Merge Sort) có vẻ hữu dụng trong trường hợp đó.
        - [Sắp xếp trộn trên danh sách liên kết](http://www.geeksforgeeks.org/merge-sort-for-linked-list/)

- Với sắp xếp vun đống (Heapsort), xem lại see cấu trúc Heap ở trên. Sắp xếp vun đống tốt, nhưng không ổn định.

- [ ] [Sedgewick - Mergesort (5 videos)](https://www.youtube.com/watch?v=4nKwesx_c8E&list=PLe-ggMe31CTeunC6GZHFBmQx7EKtjbGf9)
    - [ ] [1. Mergesort](https://www.youtube.com/watch?v=4nKwesx_c8E&list=PLe-ggMe31CTeunC6GZHFBmQx7EKtjbGf9&index=1)
    - [ ] [2. Sắp xếp trộn từ dưới lên (Bottom up Mergesort)](https://www.youtube.com/watch?v=HGOIGUYjeyk&list=PLe-ggMe31CTeunC6GZHFBmQx7EKtjbGf9&index=2)
    - [ ] [3. Độ phức tạp của các thuật toán sắp xếp (Sorting Complexity)](https://www.youtube.com/watch?v=WvU_mIWo0Ac&index=3&list=PLe-ggMe31CTeunC6GZHFBmQx7EKtjbGf9)
    - [ ] [4. Các hàm so sánh (Comparators)](https://www.youtube.com/watch?v=7MvC1kmBza0&index=4&list=PLe-ggMe31CTeunC6GZHFBmQx7EKtjbGf9)
    - [ ] [5. Tính ổn định (Stability)](https://www.youtube.com/watch?v=XD_5iINB5GI&index=5&list=PLe-ggMe31CTeunC6GZHFBmQx7EKtjbGf9)

- [ ] [Sedgewick - Quicksort (4 videos)](https://www.youtube.com/playlist?list=PLe-ggMe31CTeE3x2-nF1-toca1QpuXwE1)
    - [ ] [1. Quicksort](https://www.youtube.com/watch?v=5M5A7qPWk84&index=1&list=PLe-ggMe31CTeE3x2-nF1-toca1QpuXwE1)
    - [ ] [2. Cách chọn (Selection)](https://www.youtube.com/watch?v=CgVYfSyct_M&index=2&list=PLe-ggMe31CTeE3x2-nF1-toca1QpuXwE1)
    - [ ] [3. Lặp khóa (Duplicate Keys)](https://www.youtube.com/watch?v=WBFzOYJ5ybM&index=3&list=PLe-ggMe31CTeE3x2-nF1-toca1QpuXwE1)
    - [ ] [4. Các hệ thống sắp xếp (System Sorts)](https://www.youtube.com/watch?v=rejpZ2htBjE&index=4&list=PLe-ggMe31CTeE3x2-nF1-toca1QpuXwE1)

- [ ] UC Berkeley (chuỗi video bài giảng):
    - [ ] [CS 61B Lecture 29: Sorting I (video)](https://www.youtube.com/watch?v=EiUvYS2DT6I&list=PL4BBB74C7D2A1049C&index=29)
    - [ ] [CS 61B Lecture 30: Sorting II (video)](https://www.youtube.com/watch?v=2hTY3t80Qsk&list=PL4BBB74C7D2A1049C&index=30)
    - [ ] [CS 61B Lecture 32: Sorting III (video)](https://www.youtube.com/watch?v=Y6LOLpxg6Dc&index=32&list=PL4BBB74C7D2A1049C)
    - [ ] [CS 61B Lecture 33: Sorting V (video)](https://www.youtube.com/watch?v=qNMQ4ly43p4&index=33&list=PL4BBB74C7D2A1049C)

- [ ] [Sắp xếp nổi bọt (Bubble Sort) - video](https://www.youtube.com/watch?v=P00xJgWzz2c&index=1&list=PL89B61F78B552C1AB)
- [ ] [Phân tích thuật toán sắp xếp nổi bọt (Analyzing Bubble Sort) - video](https://www.youtube.com/watch?v=ni_zk257Nqo&index=7&list=PL89B61F78B552C1AB)
- [ ] [Sắp xếp chèn và sắp xếp trộn (Insertion Sort, Merge Sort) - video](https://www.youtube.com/watch?v=Kg4bqzAqRBM&index=3&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb)
- [ ] [Sắp xếp chèn (Insertion Sort) - video](https://www.youtube.com/watch?v=c4BRHC7kTaQ&index=2&list=PL89B61F78B552C1AB)
- [ ] [Sắp xếp trộn (Merge Sort) - video](https://www.youtube.com/watch?v=GCae1WNvnZM&index=3&list=PL89B61F78B552C1AB)
- [ ] [Sắp xếp nhanh (Quicksort) - video](https://www.youtube.com/watch?v=y_G9BkAm6B8&index=4&list=PL89B61F78B552C1AB)
- [ ] [Sắp xếp chọn (Selection Sort) - video](https://www.youtube.com/watch?v=6nDMgr0-Yyo&index=8&list=PL89B61F78B552C1AB)

- [ ] Cài đặt cho sắp xếp trộn:
    - [ ] [Sử dụng mảng đệm (C)](http://www.cs.yale.edu/homes/aspnes/classes/223/examples/sorting/mergesort.c)
    - [ ] [Sử dụng mảng đệm (Python)](https://github.com/jwasham/practice-python/blob/master/merge_sort/merge_sort.py)
    - [ ] [Sắp xếp tại chỗ, không dùng mảng đệm (C++)](https://github.com/jwasham/practice-cpp/blob/master/merge_sort/merge_sort.cc)
- [ ] Cài đặt cho sắp xếp nhanh:
    - [ ] [C](http://www.cs.yale.edu/homes/aspnes/classes/223/examples/randomization/quick.c)
    - [ ] [Cài đặt khác dùng C](https://github.com/jwasham/practice-c/blob/master/quick_sort/quick_sort.c)
    - [ ] [Python](https://github.com/jwasham/practice-python/blob/master/quick_sort/quick_sort.py)

- [ ] Bài tập cài đặt:
    - [ ] Sắp xếp trộn: O(n log n) trường hợp trung bình và xấu nhất
    - [ ] Sắp xếp nhanh O(n log n) trường hợp trung bình
    - Sắp xếp chọn và sắp xếp chèn đều là O(n^2) cho trường hợp trung bình và xấu nhất.
    - Với sắp xếp vun đống, xem lại cấu trúc Heap ở trên.

- [ ] Không nhất thiết, nhưng tôi khuyến khích xem các phần sau:
    - [ ] [Sedgewick - Sắp xếp theo cơ số (Radix Sorts) (6 videos)](https://www.youtube.com/playlist?list=PLe-ggMe31CTcNvUX9E3tQeM6ntrdR8e53)
      - [ ] [1. Chuỗi trong Java (Strings in Java)](https://www.youtube.com/watch?v=zRzU-FWsjNU&list=PLe-ggMe31CTcNvUX9E3tQeM6ntrdR8e53&index=6)
      - [ ] [2. Đếm các khóa đã được lập chỉ mục (Key Indexed Counting)](https://www.youtube.com/watch?v=CtgKYmXs62w&list=PLe-ggMe31CTcNvUX9E3tQeM6ntrdR8e53&index=5)
      - [ ] [3. Sắp xếp cơ số ưu tiên chữ số thấp nhất (Least Significant Digit First String Radix Sort)](https://www.youtube.com/watch?v=2pGVq_BwPKs&list=PLe-ggMe31CTcNvUX9E3tQeM6ntrdR8e53&index=4)
      - [ ] [4. Sắp xếp cơ số ưu tiên chữ số cao nhất (Most Significant Digit First String Radix Sort)](https://www.youtube.com/watch?v=M3cYNY90R6c&index=3&list=PLe-ggMe31CTcNvUX9E3tQeM6ntrdR8e53)
      - [ ] [5. 3-way Radix Quicksort](https://www.youtube.com/watch?v=YVl58kfE6i8&index=2&list=PLe-ggMe31CTcNvUX9E3tQeM6ntrdR8e53):  Sắp xếp cơ số kết hợp sắp xếp nhanh, trong đó, chỉ chia mảng ban đầu thành 3 nhóm (thay vì chia theo R nhóm trong sắp xếp cơ số thông thường).
      - [ ] [6. Mảng hậu tố (Suffix Arrays)](https://www.youtube.com/watch?v=HKPrVm5FWvg&list=PLe-ggMe31CTcNvUX9E3tQeM6ntrdR8e53&index=1)
    - [ ] [Sắp xếp cơ số](http://www.cs.yale.edu/homes/aspnes/classes/223/notes.html#radixSort)
    - [ ] [Sắp xếp cơ số (video)](https://www.youtube.com/watch?v=xhr26ia4k38)
    - [ ] [Sắp xếp cơ số, sắp xếp đếm (Counting Sort, thực thi thời gian tuyến tính, nhưng có nhiều giới hạn đối với dự liệu)- video](https://www.youtube.com/watch?v=Nz1KZXbghj8&index=7&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb)
    - [ ] [Sự ngẫu nhiên: Phép nhân ma trận, Sắp xếp nhanh và thuật toán của Freivalds - video](https://www.youtube.com/watch?v=cNB2lADK3_s&index=8&list=PLUl4u3cNGP6317WaSNfmCvGym2ucw3oGp)
    - [ ] [Sắp xếp trong thời gian tuyến tính (Sorting in Linear Time) - video](https://www.youtube.com/watch?v=pOKy3RZbSws&list=PLUl4u3cNGP61hsJNdULdudlRL493b-XZf&index=14)