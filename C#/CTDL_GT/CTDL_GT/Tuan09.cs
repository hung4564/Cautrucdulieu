using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT
{
    class Tuan09
    {
        /// <summary>
        /// singly linked list node
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class LLKSTT_60_S_node<T>
        {

            #region Khởi tạo
            public LLKSTT_60_S_node()
            {
                this.Next = null;
            }
            public LLKSTT_60_S_node(T value)
            {
                this.Value = value;
                this.Next = null;
            }
            #endregion
            #region Thuộc tính
            private LLKSTT_60_S_node<T> next;

            private T value;

            public T Value
            {
                get
                {
                    return value;
                }

                set
                {
                    this.value = value;
                }
            }

            public LLKSTT_60_S_node<T> Next
            {
                get
                {
                    return next;
                }

                set
                {
                    next = value;
                }
            }

            #endregion
        }
        class LLKSTT_60_S<T>
        {
            #region Khởi tạo
            public LLKSTT_60_S()
            {
                First = null;
            }
            public LLKSTT_60_S(LLKSTT_60_S_node<T> node)
            {
                First = node;
            }
            #endregion
            #region Thuộc tính
            LLKSTT_60_S_node<T> first;
            public LLKSTT_60_S_node<T> First
            {
                get
                {
                    return first;
                }

                set
                {
                    first = value;
                }
            }
            public bool IsEmpty
            {
                get
                {
                    return First == null;
                }
            }
            public int Count
            {
                get
                {
                    return dodai();
                }
            }
            #endregion
            #region Phương thức
            public void AddFirst(LLKSTT_60_S_node<T> node)
            {
                if (First == null) First = node;
                else
                {
                    node.Next = First;
                    First = node;
                }
            }
            public void AddLast(LLKSTT_60_S_node<T> node)
            {
                if (First == null) First = node;
                else
                {
                    LLKSTT_60_S_node<T> temp = First;
                    while (temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    temp.Next = node;
                }
            }
            public LLKSTT_60_S_node<T> AddFirst(T value)
            {
                LLKSTT_60_S_node<T> temp = new LLKSTT_60_S_node<T>(value);
                AddFirst(temp);
                return temp;
            }
            public LLKSTT_60_S_node<T> AddLast(T value)
            {
                LLKSTT_60_S_node<T> temp = new LLKSTT_60_S_node<T>(value);
                AddLast(temp);
                return temp;
            }
            public void AddBefore(LLKSTT_60_S_node<T> node, LLKSTT_60_S_node<T> newNode)
            {
                if(First!=null)
                {
                    LLKSTT_60_S_node<T> temp = First;
                    if (First.Value.Equals(node.Value)) AddFirst(newNode);
                    else
                    {
                        while (temp != null)
                        {
                            if (temp.Next.Value.Equals(node.Value))
                            {
                                newNode.Next = temp.Next;
                                temp.Next = newNode;
                                break;
                            }
                            temp = temp.Next;
                        }
                    }
                }
            }
            public void AddAfter(LLKSTT_60_S_node<T> node, LLKSTT_60_S_node<T> newNode)
            {
                if (First != null)
                {
                    LLKSTT_60_S_node<T> temp = First;
                    while (temp != null)
                    {
                        if (temp.Value.Equals(node.Value))
                        {
                            newNode.Next = temp.Next;
                            temp.Next = newNode;
                            break;
                        }
                        temp = temp.Next;
                    }
                }                
            }
            public void AddBefore(LLKSTT_60_S_node<T> node, T value)
            {
                LLKSTT_60_S_node<T> temp = new LLKSTT_60_S_node<T>(value);
                AddBefore(node,temp);
            }
            public void AddAfter(LLKSTT_60_S_node<T> node, T value)
            {
                LLKSTT_60_S_node<T> temp = new LLKSTT_60_S_node<T>(value);
                AddAfter(node,temp);
            }
            public void Show()
            {
                for (LLKSTT_60_S_node<T> i = First; i != null; i = i.Next)
                {
                    Console.WriteLine(i.Value.ToString());
                }
            }
            int dodai()
            {
                int dodai = 0;
                for (LLKSTT_60_S_node<T> i = First; i != null; i = i.Next) dodai++;
                return dodai;
            }
            public LLKSTT_60_S_node<T> Find(T value)
            {
                LLKSTT_60_S_node<T> i = First;
                while (i != null)
                {
                    if (i.Value.Equals(value)) break;
                    i = i.Next;
                }
                if (i != null) return i;
                return new LLKSTT_60_S_node<T>(value);
            }
            #endregion
        }
        /*
        /// <summary>
        /// singly linked list node is int
        /// </summary>
        class LLKSTT_60_S
        {
            #region Khởi tạo
            public LLKSTT_60_S()
            {
                next = null;
            }
            public LLKSTT_60_S(int p)
            {
                this.info = p;
                this.next = null;
            }
            #endregion
            #region Thuộc tính
            public LLKSTT_60_S next;
            public int info;
            /// <summary>
            /// Trả số lượng node được gắn đằng sau
            /// </summary>
            public int Count
            {
                get
                {
                    return dodai();
                }
            }
            #endregion
            #region Phương thức
            /// <summary>
            /// Gắn node mới vào cuối danh sách
            /// </summary>
            /// <param name="node"> là node mới cần gắn</param>
            public void AddLast(LLKSTT_60_S node)
            {
                if (this == null)
                {
                    this.info = node.info;
                    this.next = node.next;
                }
                else
                {
                    LLKSTT_60_S i;
                    for (i = this; i.next != null; i = i.next) ;
                    i.next = node;
                }
            }
            /// <summary>
            /// Gắn value mới vào cuối danh sách
            /// </summary>
            /// <param name="value"> là gia tri mới cần gắn</param> 
            /// <returns>trả về node chứa giá trị value</returns>
            public LLKSTT_60_S AddLast(int value)
            {

                LLKSTT_60_S temp = new LLKSTT_60_S();
                temp.info = value;
                if (this == null)
                {
                    this.info = temp.info;
                    this.next = null;
                }
                else
                {
                    LLKSTT_60_S i;
                    for (i = this; i.next != null; i = i.next) ;
                    i.next = temp;
                }
                return temp;
            }
            /// <summary>
            /// Gắn node mới vào đầu danh sách
            /// </summary>
            /// <param name="node"> là node mới cần gắn</param>
            public void AddFist(LLKSTT_60_S node)
            {
                if (this == null)
                {
                    this.info = node.info;
                    this.next = node.next;
                }
                else
                {
                    LLKSTT_60_S q = new LLKSTT_60_S();
                    q.info = this.info;
                    q.next = this.next;
                    node.next = q;
                    this.info = node.info;
                    this.next = node.next;
                }
            }
            /// <summary>
            /// Gắn value mới vào đầu danh sách
            /// </summary>
            /// <param name="value"> là gia tri mới cần gắn</param> 
            /// <returns>trả về node chứa giá trị value</returns>
            public LLKSTT_60_S AddFist(int value)
            {
                LLKSTT_60_S temp = new LLKSTT_60_S();
                temp.info = value;
                if (this == null)
                {
                    this.info = temp.info;
                    this.next = temp.next;
                }
                else
                {
                    LLKSTT_60_S q = new LLKSTT_60_S();
                    q.info = this.info;
                    q.next = this.next;
                    temp.next = q;
                    this.info = temp.info;
                    this.next = temp.next;
                }
                return temp;
            }
            private int dodai()
            {
                int dodai = 0;
                for (LLKSTT_60_S i = this; i != null; i = i.next) dodai++;
                return dodai;
            }
            /// <summary>
            /// gắn value vào trước node
            /// </summary>
            /// <param name="node">node xác định</param>
            /// <param name="value">node cần gắn</param>
            public void AddBefore(LLKSTT_60_S node, LLKSTT_60_S value)
            {
                LLKSTT_60_S i;
                LLKSTT_60_S temp = new LLKSTT_60_S();
                temp = value;
                for (i = this; i.next.info != node.info && i != null; i = i.next) ;
                if (i != null)
                {
                    temp.next = i.next;
                    i.next = temp;
                }
            }
            /// <summary>
            /// gắn value vào sau node
            /// </summary>
            /// <param name="node">node xác định</param>
            /// <param name="value">node cần gắn</param>
            public void AddAfter(LLKSTT_60_S node, LLKSTT_60_S value)
            {
                LLKSTT_60_S i;
                LLKSTT_60_S temp = new LLKSTT_60_S();
                temp = value;
                for (i = this; i.info != node.info && i != null; i = i.next) ;
                if (i != null)
                {
                    temp.next = i.next;
                    i.next = temp;
                }
            }
            /// <summary>
            /// gắn value vào trước node
            /// </summary>
            /// <param name="node">node xác định</param>
            /// <param name="value">node cần gắn</param>
            /// <returns>trả về node chứa giá trị value</returns>
            public LLKSTT_60_S AddBefore(LLKSTT_60_S node, int value)
            {
                LLKSTT_60_S i;
                LLKSTT_60_S temp = new LLKSTT_60_S();
                temp.info = value;
                for (i = this; i.next.info != node.info && i != null; i = i.next) ;
                if (i != null)
                {
                    temp.next = i.next;
                    i.next = temp;
                }
                return temp;
            }
            /// <summary>
            /// gắn value vào trước node
            /// </summary>
            /// <param name="node">node xác định</param>
            /// <param name="value">node cần gắn</param>
            /// <returns>trả về node chứa giá trị value</returns>
            public LLKSTT_60_S AddAfter(LLKSTT_60_S node, int value)
            {
                LLKSTT_60_S i;
                LLKSTT_60_S temp = new LLKSTT_60_S();
                temp.info = value;
                for (i = this; i.info != node.info && i != null; i = i.next) ;
                if (i != null)
                {
                    temp.next = i.next;
                    i.next = temp;
                }
                return temp;
            }
            public void Clear()
            {
                this.next = null; ;
                this.info = default(int);
            }
            #endregion
        }*/
        public static void tuan09_main()
        {
            LLKSTT_60_S<int> list = new LLKSTT_60_S<int>();
            LLKSTT_60_S_node<int> p, q;
            p = new LLKSTT_60_S_node<int>(4);
            list.AddLast(p);
            p = new LLKSTT_60_S_node<int>(5);
            list.AddLast(p);
            p = new LLKSTT_60_S_node<int>(3);
            list.AddFirst(p);
            list.AddLast(6);
            list.AddFirst(1);
            q = new LLKSTT_60_S_node<int>(2);
            list.AddBefore(p, q);
            q = new LLKSTT_60_S_node<int>(7);
            list.AddAfter(p, q);
            list.AddAfter(p, 3);
            list.Show();
            Console.ReadKey();
        }
    }
}
