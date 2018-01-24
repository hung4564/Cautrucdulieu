﻿# Cấu trúc dữ liệu và giải thuật - Data Structure and Algorithms
## Mục Lục
- [Cấu trúc dữ liệu](#cấu-trúc-dữ-liệu)
	- [Arrays](#arrays)
 	- [Linked List](#linked-Lists)
	- [Stack](#stack)
	- [Queue](#queue)
	- [Hash table](#hash-table)
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
    - [ ] Miêu tả:
        - [ ] [Singly Linked Lists - Danh sách liên kết (video)](https://www.coursera.org/learn/data-structures/lecture/kHhgK/singly-linked-lists)
        - [ ] [CS 61B - Linked Lists - Danh sách liên kết (video)](https://www.youtube.com/watch?v=sJtJOtXCW_M&list=PL-XXv-cvA_iAlnI-BQr9hjqADPBtujFJd&index=5)
    - [ ] [C Code (video)](https://www.youtube.com/watch?v=QN6FPiD0Gzo)
            - Không cần xem toàn bộ video, chỉ phần cấu trúc Node và cấp phát vùng nhớ.
    - [ ] Danh sách liên kết so sánh với Mảng:
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



