# Cấu trúc dữ liệu và giải thuật - Data Structure and Algorithms
## Mục Lục
- [Cấu trúc dữ liệu](#cấu-trúc-dữ-liệu)
    - [Arrays](#arrays)
    - [Linked Lists](#linked-lists)
    - [Stack](#stack)
    - [Queue](#queue)
    - [Hash table](#hash-table)
- [Kiến thức bổ sung](#kiến-thức-bổ-sung)
    - [Tìm kiếm nhị phân](#tìm-kiếm-nhị-phân)
    - [Toán tử trên bit](#toán-tử-trên-bit)
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
    - có hướng
    - vô hướng
    - ma trận kề
    - danh sách kề
    - duyệt đồ thị: BFS, DFS
## Cấu trúc dữ liệu
- ### Arrays
    - Cấp phát mảng vector tự động tùy biến kích cỡ.
    - [ ] Miêu tả, tên gốc được giữ nguyên kèm với bản dịch sang tiếng Việt:
        - [Arrays - Mảng (video)](https://www.coursera.org/learn/data-structures/lecture/OsBSF/arrays)
        - [UCBerkley CS61B - Linear and Multi-Dim Arrays - Mảng tuyến tính và mảng đa chiều(video)](https://youtu.be/Wp8oiO_CZZE?t=15m32s)
        - [Basic Arrays - Mảng cơ bản (video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Basic-arrays/149042/177104-4.html)
        - [Multi-dim - Đa chiều(video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Multidimensional-arrays/149042/177105-4.html)
        - [Dynamic Arrays - Mảng tùy biến (video)](https://www.coursera.org/learn/data-structures/lecture/EwbnV/dynamic-arrays)
        - [Jagged Arrays - Mảng trong mảng (video)](https://www.youtube.com/watch?v=1jtrQqYpt7g)
        - [Jagged Arrays - Mảng trong mảng (video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Jagged-arrays/149042/177106-4.html)
        - [Resizing arrays - Mảng có thể tùy biến kích thước (video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Resizable-arrays/149042/177108-4.html)
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
    - [ ] Thời gian thực thi
        - O(1) để thêm/xóa tại vị trí cuối (tính luôn cả cấp phát lại để có thêm không gian lưu trữ), đánh chỉ mục, hay cập nhật
        - O(n) để thêm/xóa tại bất cứ đâu
    - [ ] Không gian
        - Liên tục trong bộ nhớ, giúp cải thiện hiệu suất
        - Không gian cần thiết = (Kích cở của mảng, thường >= n)* kích thước của 1 phần tử, cho dù là 2n, vẫn xem như O(n)

- ### Linked Lists
    - [X] Miêu tả:
        - [X] [Singly Linked Lists - Danh sách liên kết đơn](./docs)
		- [X] [Doubly Linked Lists - Danh sách liên kết đôi](./docs/Linked-list.md)
		- [X] [Circular Linked List - Danh sách liên kết vòng](./docs/Linked-list.md)
    - [ ] Danh sách liên kết so sánh với Mảng:
    	- [X] [So sánh](./docs/so-sanh-mang vs-list.md)
        - [Core Linked Lists Vs Arrays - Danh sách liên kết Vs Mảng (video)](https://www.coursera.org/learn/data-structures-optimizing-performance/lecture/rjBs9/core-linked-lists-vs-arrays)
        - [In The Real World Linked Lists Vs Arrays - Trong thực tế, Danh sách liên kết Vs Mảng (video)](https://www.coursera.org/learn/data-structures-optimizing-performance/lecture/QUaUd/in-the-real-world-lists-vs-arrays)
    - [ ] [Why you should avoid linked lists - Tại sao bạn nên tránh danh sách liên kết(video)](https://www.youtube.com/watch?v=YQs6IC-vgmo)
    - [ ] Ghi chú: Bạn cần kiến thức về con trỏ trỏ về con trỏ:
        (Khi bạn chuyển một con trỏ vào trong 1 thân hàm khiến thay đổi địa chỉ mà con trỏ trỏ về)
        Trang này giúp bạn có cái nhìn khái quát về con trỏ trỏ tới con trỏ. Tôi không khuyến khích đọc lướt qua danh sách này. Đề tài này rất khó đọc và nắm bắt.
        - [Pointers to Pointers - Con trỏ trỏ tới con trỏ](https://www.eskimo.com/~scs/cclass/int/sx8.html)
    - [ ] Cài đặt (Tôi đã thực hiện với con trỏ đuôi và không dùng con trỏ đuôi):
        - [ ] size() - Trả về số lượng các phần tử trong danh sách
        - [ ] empty() - Giá trị luận lý logic, true nếu rỗng
        - [ ] value_at(index) - Trả về phần tử tại vị trí thứ n (danh sách bắt đầu từ 0)
        - [ ] push_front(value) - Thêm phần tử mới vào đầu danh sách
        - [ ] pop_front() - Xóa phần tử đầu tiên và trả về giá trị này
        - [ ] push_back(value) - Thêm phần tử tại cuối danh sách
        - [ ] pop_back() - Xóa phần tử cuối và trả về giá trị
        - [ ] front() - Lấy giá trị của phần tử đầu tiền
        - [ ] back() - Lấy giá trị của phần tử cuối cùng
        - [ ] insert(index, value) - Thêm phần tử mới tại vị trí chỉ mục, phần tử hiện tại sẽ trỏ về phần tử mới tại vị trí chỉ mục này (A->B->C, thêm N tại vị trí B, A->D->B->C, A hiện giờ sẽ trỏ tới D, chỉ mục 1 sẽ trỏ tới D thay vì B)
        - [ ] erase(index) - Xóa node tại vị trí chỉ mục
        - [ ] value_n_from_end(n) - Trả về danh sách từ vị trí thứ n đến cuối danh sách
        - [ ] reverse() - đảo ngược danh sách
        - [ ] remove_value(value) - Xóa dữ liệu đầu tiên được tìm thấy khớp với giá trị được cho
    - [ ] Doubly-linked List
        - [Description - Miêu tả danh sách liên kết đôi (video)](https://www.coursera.org/learn/data-structures/lecture/jpGKD/doubly-linked-lists)
        - Không cần phải cài đặt
- ### Stack
    - [ ] [Stacks (video)](https://www.coursera.org/learn/data-structures/lecture/UdKzQ/stacks)
    - [ ] [Using Stacks Last-In First-Out - Sử dụng stack Vào-Cuối-Ra-Trước (video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Using-stacks-last-first-out/149042/177120-4.html)
    - [ ] Sẽ không cài đặt. Cài đặt với mảng là điều hiển nhiên.

- ### Queue
    - [ ] [Using Queues First-In First-Out -  Sử dụng hàng đợi Vào-Trước-Ra-Trước(video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Using-queues-first-first-out/149042/177122-4.html)
    - [ ] [Queue (video)](https://www.coursera.org/learn/data-structures/lecture/EShpq/queue)
    - [ ] [Circular buffer/FIFO](https://en.wikipedia.org/wiki/Circular_buffer)
    - [ ] [Priority Queues - Hàng đợi ưu tiên (video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Priority-queues-deques/149042/177123-4.html)
    - [ ] Cài đặt sử dụng danh sách liên kết, áp dụng con trỏ đuôi:
        - enqueue(value) - Thêm giá trị ở đuôi
        - dequeue() - Trả về giá trị của dữ liệu được thêm vào xa nhất (thông thường là dữ liệu đầu tiên trong danh sách)
        - empty()
    - [ ] Sử dụng mảng cố định kích thước:
        - enqueue(value) - Thêm giá trị vào cuối mảng
        - dequeue() - Trả về giá trị của dữ liệu được thêm vào xa nhất
        - empty()
        - full()
    - [ ] Chi phí:
        - Không cài đặt đúng việc sử dụng danh sách liên kết khi enqueue tại đầu và dequeue tại đuôi sẽ có chi phí là O(n) bởi vì bạn cần con trỏ next tới giá trị cuối cùng, khiến việc phải chạy qua toàn danh sách mỗi lần dequeue
        - enqueue: O(1) (Không đáng kể, danh sách liên kết và mảng [probing])
        - dequeue: O(1) (danh sách liên kết và mảng)
        - empty: O(1) (danh sách liên kết và mảng)
- ### Hash table
    - [ ] Video:
        - [ ] [Hashing with Chaining (video)](https://www.youtube.com/watch?v=0M_kIqhwbFo&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb&index=8)
        - [ ] [Table Doubling, Karp-Rabin (video)](https://www.youtube.com/watch?v=BRO7mVIFt08&index=9&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb)
        - [ ] [Open Addressing, Cryptographic Hashing (video)](https://www.youtube.com/watch?v=rvdJDijO2Ro&index=10&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb)
        - [ ] [PyCon 2010: The Mighty Dictionary (video)](https://www.youtube.com/watch?v=C4Kc8xzcA68)
        - [ ] [(Advanced) Randomization: Universal & Perfect Hashing (video)](https://www.youtube.com/watch?v=z0lJ2k0sl1g&list=PLUl4u3cNGP6317WaSNfmCvGym2ucw3oGp&index=11)
        - [ ] [(Advanced) Perfect hashing (video)](https://www.youtube.com/watch?v=N0COwN14gt0&list=PL2B4EEwhKD-NbwZ4ezj7gyc_3yNrojKM9&index=4)
	    - [ ] Các khóa học online:
        - [ ] [Understanding Hash Functions - Hiểu hàm băm (video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Understanding-hash-functions/149042/177126-4.html)
        - [ ] [Using Hash Tables - Sử dụng bảng băm (video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Using-hash-tables/149042/177127-4.html)
        - [ ] [Supporting Hashing - Hỗ trợ băm(video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Supporting-hashing/149042/177128-4.html)
        - [ ] [Language Support Hash Tables - Ngôn ngữ hỗ trợ bảng băm (video)](https://www.lynda.com/Developer-Programming-Foundations-tutorials/Language-support-hash-tables/149042/177129-4.html)
        - [ ] [Core Hash Tables - Cơ bản về bảng băm (video)](https://www.coursera.org/learn/data-structures-optimizing-performance/lecture/m7UuP/core-hash-tables)
        - [ ] [Data Structures - Cấu trúc dữ liệu (video)](https://www.coursera.org/learn/data-structures/home/week/3)
        - [ ] [Phone Book Problem - Vấn đề sổ điện thoại (video)](https://www.coursera.org/learn/data-structures/lecture/NYZZP/phone-book-problem)
        - [ ] Phân phối bảng băm:
            - [Instant Uploads And Storage Optimization In Dropbox - Tải nhanh và tối ưu lưu trữ trong Dropbox (video)](https://www.coursera.org/learn/data-structures/lecture/DvaIb/instant-uploads-and-storage-optimization-in-dropbox)
            - [Distributed Hash Tables - Phân phối bảng băm(video)](https://www.coursera.org/learn/data-structures/lecture/tvH8H/distributed-hash-tables)

    - [ ] Cài đặt với mảng sử dụng thăm dò tuyến tính:
        - hash(k, m) - m là kích thước của bảng băm
        - add(key, value) - nếu khóa đã tồn tại, cập nhật giá trị
        - exists(key)
        - get(key)
        - remove(key)




## Kiến thức ngoài
- ### Tìm kiếm nhị phân
    - [ ] [Tìm kiếm nhị phân (Binary Search) - video](https://www.youtube.com/watch?v=D5SrAga1pno)
    - [ ] [Tìm kiếm nhị phân - Khan Academy (Binary Search) - video](https://www.khanacademy.org/computing/computer-science/algorithms/binary-search/a/binary-search)
    - [ ] [giải thích chi tiết](https://www.topcoder.com/community/data-science/data-science-tutorials/binary-search/)
    - [ ] Cài đặt:
        - Tìm kiếm nhị phân (trên mảng số nguyên đã sắp xếp)
        - Tìm kiếm nhị phân sử dụng đệ quy

- ### Toán tử trên bit
    - [ ] [Bits cheat sheet](/extras/cheat%20sheets/bits-cheat-cheet.pdf) - bạn nên thuộc lòng nhiều lũy thừa của 2 (từ 2^1 đến 2^16 và 2^32)
    - [ ] Hãy chuẩn bị một nền tảng tốt về các biến đổi bit với các toán tử: &, |, ^, ~, >>, <<
        - [ ] [words (thuật ngữ trong kiến trúc máy tính)](https://en.wikipedia.org/wiki/Word_(computer_architecture) )
        - [ ] Bài mở đầu:
            [Thao tác bit (Bit Manipulation) - video](https://www.youtube.com/watch?v=7jkIUgLC29I)
        - [ ] [C Programming Tutorial 2-10: Bitwise Operators (video)](https://www.youtube.com/watch?v=d0AwjSpNXR0)
        - [ ] [Thao tác bit (Bit Manipulation)](https://en.wikipedia.org/wiki/Bit_manipulation)
        - [ ] [Toán tử trên bit (Bitwise Operation)](https://en.wikipedia.org/wiki/Bitwise_operation)
        - [ ] [Bithacks](https://graphics.stanford.edu/~seander/bithacks.html)
        - [ ] [The Bit Twiddler](http://bits.stephan-brumme.com/)
        - [ ] [The Bit Twiddler Interactive](http://bits.stephan-brumme.com/interactive.html)
    - [ ] Phần bù 2 và phần bù 1 (2s and 1s complement)
        - [Nhị phân: Cộng và trừ (Tại sao chúng ta sử dụng phần bù 2) - video](https://www.youtube.com/watch?v=lKTsv6iVxV4)
        - [Phần bù 1 (1s Complement)](https://en.wikipedia.org/wiki/Ones%27_complement)
        - [Phần bù 2 (2s Complement)](https://en.wikipedia.org/wiki/Two%27s_complement)
    - [ ] Đếm tập hợp của các bit
        - [4 cách đê đếm các bit trong một byte - video](https://youtu.be/Hzuzo9NJrlc)
        - [Đếm bit](https://graphics.stanford.edu/~seander/bithacks.html#CountBitsSetKernighan)
        - [Làm thế nào để đếm số lượng các bit 1 trong một số 32 bit](http://stackoverflow.com/questions/109023/how-to-count-the-number-of-set-bits-in-a-32-bit-integer)
    - [ ] Làm tròn đến lũy thừa gần nhất của 2:
        - [Làm tròn lên lũy thừa kế tiếp của 2](http://bits.stephan-brumme.com/roundUpToNextPowerOfTwo.html)
    - [ ] Đôi giá trị:
        - [Swap](http://bits.stephan-brumme.com/swap.html)
    - [ ] Giá trị tuyệt đối:
        - [Giá trị tuyết đối của số nguyên](http://bits.stephan-brumme.com/absInteger.html)


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


## Sắp xếp

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

Nếu bạn muốn biết thêm chi tiết trong chủ đề này, xem qua phần "Sắp xếp" trong [Đọc thêm về một số đề tài](đọc-thêm-về-một-số-đề-tài)

## Đồ thị

Đồ thị có thể được sử dụng để miêu tả nhiều bài toán trong khoa học máy tính, vậy nên phần này cũng khá dài, tương đương với [Cây](#cây) và [Sắp xếp](#sắp-xếp).

- Ghi chú từ Yegge:
    - Có 3 cách cơ bản để thể hiện một đồ thị trong bộ nhớ:
        - Các đối tượng (objects) và con trỏ (pointers)
        - Ma trận
        - Danh sách kề (adjacency list)
    - Hãy làm quen với mỗi cách thể hiện và nắm vững ưu, nhược của nó.
    - BFS và DFS - biết về độ phức tạp tính toán của chúng, ước lượng những sự được và mất khi sử dụng, và cài đặt chúng như thế nào
    - Khi được trao cho một bài toán, hãy thử tìm một giải thuật sử dụng đồ thị trước khi nghĩ đến các hướng giải quyết khác.

- [ ] Các bài giảng của giáo sư Skiena, tốt để dẫn nhập:
    - [ ] [CSE373 2012 - Lecture 11 - Graph Data Structures (video)](https://www.youtube.com/watch?v=OiXxhDrFruw&list=PLOtl7M3yp-DV69F32zdK7YJcNXpTunF2b&index=11)
    - [ ] [CSE373 2012 - Lecture 12 - Breadth-First Search (video)](https://www.youtube.com/watch?v=g5vF8jscteo&list=PLOtl7M3yp-DV69F32zdK7YJcNXpTunF2b&index=12)
    - [ ] [CSE373 2012 - Lecture 13 - Graph Algorithms (video)](https://www.youtube.com/watch?v=S23W6eTcqdY&list=PLOtl7M3yp-DV69F32zdK7YJcNXpTunF2b&index=13)
    - [ ] [CSE373 2012 - Lecture 14 - Graph Algorithms (con't) (video)](https://www.youtube.com/watch?v=WitPBKGV0HY&index=14&list=PLOtl7M3yp-DV69F32zdK7YJcNXpTunF2b)
    - [ ] [CSE373 2012 - Lecture 15 - Graph Algorithms (con't 2) (video)](https://www.youtube.com/watch?v=ia1L30l7OIg&index=15&list=PLOtl7M3yp-DV69F32zdK7YJcNXpTunF2b)
    - [ ] [CSE373 2012 - Lecture 16 - Graph Algorithms (con't 3) (video)](https://www.youtube.com/watch?v=jgDOQq6iWy8&index=16&list=PLOtl7M3yp-DV69F32zdK7YJcNXpTunF2b)

- [ ] Đồ thị (ôn tập và mở rộng) (tên video được giữ nguyên vì có quá nhiều thuật ngữ và viết tắt):
    - [ ] [6.006 Single-Source Shortest Paths Problem (video)](https://www.youtube.com/watch?v=Aa2sqUhIn-E&index=15&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb)
    - [ ] [6.006 Dijkstra (video)](https://www.youtube.com/watch?v=2E7MmKv0Y24&index=16&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb)
    - [ ] [6.006 Bellman-Ford (video)](https://www.youtube.com/watch?v=ozsuci5pIso&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb&index=17)
    - [ ] [6.006 Speeding Up Dijkstra (video)](https://www.youtube.com/watch?v=CHvQ3q_gJ7E&list=PLUl4u3cNGP61Oq3tWYp6V_F-5jb5L2iHb&index=18)
    - [ ] [Aduni: Graph Algorithms I - Topological Sorting, Minimum Spanning Trees, Prim's Algorithm -  Lecture 6 (video)]( https://www.youtube.com/watch?v=i_AQT_XfvD8&index=6&list=PLFDnELG9dpVxQCxuD-9BSy2E7BWY3t5Sm)
    - [ ] [Aduni: Graph Algorithms II - DFS, BFS, Kruskal's Algorithm, Union Find Data Structure - Lecture 7 (video)]( https://www.youtube.com/watch?v=ufj5_bppBsA&list=PLFDnELG9dpVxQCxuD-9BSy2E7BWY3t5Sm&index=7)
    - [ ] [Aduni: Graph Algorithms III: Shortest Path - Lecture 8 (video)](https://www.youtube.com/watch?v=DiedsPsMKXc&list=PLFDnELG9dpVxQCxuD-9BSy2E7BWY3t5Sm&index=8)
    - [ ] [Aduni: Graph Alg. IV: Intro to geometric algorithms - Lecture 9 (video)](https://www.youtube.com/watch?v=XIAQRlNkJAw&list=PLFDnELG9dpVxQCxuD-9BSy2E7BWY3t5Sm&index=9)
    - [ ] [CS 61B 2014 (starting at 58:09) (video)](https://youtu.be/dgjX4HdMI-Q?list=PL-XXv-cvA_iAlnI-BQr9hjqADPBtujFJd&t=3489)
    - [ ] [CS 61B 2014: Weighted graphs (video)](https://www.youtube.com/watch?v=aJjlQCFwylA&list=PL-XXv-cvA_iAlnI-BQr9hjqADPBtujFJd&index=19)
    - [ ] [Greedy Algorithms: Minimum Spanning Tree (video)](https://www.youtube.com/watch?v=tKwnms5iRBU&index=16&list=PLUl4u3cNGP6317WaSNfmCvGym2ucw3oGp)
    - [ ] [Strongly Connected Components Kosaraju's Algorithm Graph Algorithm (video)](https://www.youtube.com/watch?v=RpgcYiky7uw)

- Khóa học đầy đủ về đồ thị trên Coursera:
    - [ ] [Các thuật toán trên đồ thị (video)](https://www.coursera.org/learn/algorithms-on-graphs/home/welcome)

- Yegge: Nếu bạn có cơ hội, hãy thử nghiên cứu các thuật toán đẹp hơn:
    - [ ] Thuật toán tìm đường đi ngắn nhất của Dijkstra - xem phần trên - 6.006
    - [ ] A*
        - [ ] [Thuật toán tìm kiếm A sao (A*)](https://en.wikipedia.org/wiki/A*_search_algorithm)
        - [ ] [Hướng dẫn cài đặt thuật toán tìm đường đi A* - video](https://www.youtube.com/watch?v=KNXfSOx4eEE)
        - [ ] [Thuật toán tìm đường A* (E01: giải thích thuật toán) - video](https://www.youtube.com/watch?v=-L-WgKMFuhE)

- Tôi sẽ viết mã cài đặt:
    - [ ] DFS với danh sách kề (đệ quy)
    - [ ] DFS với danh sách kề (lặp với stack)
    - [ ] DFS với ma trận kề (adjacency matrix) (đệ quy)
    - [ ] DFS với ma trận kề (adjacency matrix) (lặp với stack)
    - [ ] BFS với danh sách kề
    - [ ] BFS với ma trận kề
    - [ ] Đường đi ngắn nhất từ một nút đến các nút khác (single-source shortest path) (Dijkstra)
    - [ ] Cây khung (spanning tree) nhỏ nhất
    - Các thuật toán dựa trên DFS (xem lại các video của Aduni):
        - [ ] tìm chu trình (đường đi mà trên đó tồn tại một nút được ghé qua ít nhất 2 lần) trong đồ thị (cần thiết cho sắp xếp topo (topological sort), vì tôi sẽ kiểm tra có chu trình không trước khi bắt đầu sắp xếp)
        - [ ] Sắp xếp topo (topological sort)
        - [ ] Đếm các thành phần liên thông trong một đồ thị
        - [ ] Liệt kê các thành phần liên thông mạnh
        - [ ] Kiểm tra tính song phương của đồ thị (Bipartite graph: dạng đồ thị mà tập định có thể chia thành 2 tập con không chứa phần tử chung, sao cho không có cặp 2 điểm nào trong cùng một tập hợp là kề nhau).

Bạn sẽ biết thêm nhiều ứng dụng của đồ thị trong sách của Skiena (xem danh mục sách bên dưới) và các sách về phỏng vấn.

