# Linked List - Danh sách liên kết

## Mục Lục

- [Single Linked List](#single-linked-list)
- [Doubly Linked List](#doubly-linked-list)
- [Circular Linked List](#circular-linked-list)

## Single Linked List

Một Danh sách liên kết (Linked List) là một dãy các cấu trúc dữ liệu được kết nối với nhau thông qua các liên kết (link). Hiểu một cách đơn giản thì Danh sách liên kết là một cấu trúc dữ liệu bao gồm một nhóm các nút (node) tạo thành một chuỗi. Mỗi nút gồm dữ liệu ở nút đó và tham chiếu đến nút kế tiếp trong chuỗi.

Danh sách liên kết là cấu trúc dữ liệu được sử dụng phổ biến thứ hai sau mảng. Dưới đây là các khái niệm cơ bản liên quan tới Danh sách liên kết:

- Link (liên kết): mỗi link của một Danh sách liên kết có thể lưu giữ một dữ liệu được gọi là một phần tử.
- Next: Mỗi liên kết của một Danh sách liên kết chứa một link tới next link được gọi là Next.
- First: một Danh sách liên kết bao gồm các link kết nối tới first link được gọi là First.

## Doubly Linked List

Danh sách liên kết đôi (Doubly Linked List) là một biến thể của Danh sách liên kết (Linked List), trong đó hoạt động duyệt qua các nút có thể được thực hiện theo hai chiều: về trước và về sau một cách dễ dàng khi so sánh với Danh sách liên kết đơn. Dưới đây là một số khái niệm quan trọng cần ghi nhớ về Danh sách liên kết đôi.

- Link: mỗi link của một Danh sách liên kết có thể lưu giữ một dữ liệu và được gọi là một phần tử.
- Next: mỗi link của một Danh sách liên kết có thể chứa một link tới next link và được gọi là Next.
- Prev: mỗi link của một Danh sách liên kết có thể chứa một link tới previous link và được gọi là Prev.
- First và Last: một Danh sách liên kết chứa link kết nối tới first link được gọi là First và tới last link được gọi là Last.

## Circular Linked List

Danh sách liên kết vòng (Circular Linked List) là một biến thể của Danh sách liên kết (Linked List), trong đó phần tử đầu tiên trỏ tới phần tử cuối cùng và phần tử cuối cùng trỏ tới phần tử đầu tiên.

Cả hai loại Danh sách liên kết đơn (Singly Linked List) và Danh sách liên kết đôi (Doubly Linked List) đều có thể được tạo thành dạng Danh sách liên kết vòng.
