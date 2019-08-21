using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT
{
    class Tuan11
    {
        /// <summary>
        /// double linked list node
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class LLKSTT_60_D_node<T>
        {
            #region Khởi tạo
            public LLKSTT_60_D_node()
            {
                Next = null;
                Previous = null;
            }
            public LLKSTT_60_D_node(T value)
            {
                this.Value = value;
                this.Next = null;
                this.Previous = null;
            }
            #endregion
            #region Thuộc tính
            public T Value;
            public LLKSTT_60_D_node<T> Next;
            public LLKSTT_60_D_node<T> Previous;
            #endregion
            #region Phương thức
            public void DisplayProperties()
            {
                if (this == null)
                    Console.WriteLine("Node is null");
                else
                {
                    if (Previous == null)
                        Console.WriteLine("   Previous node is null.");
                    else
                        Console.WriteLine("   Value of previous node: {0}", Previous.Value.ToString());
                    Console.WriteLine("   Value of current node:  {0}", Value.ToString());
                    if (Next == null)
                        Console.WriteLine("   Next node is null.");
                    else
                        Console.WriteLine("   Value of next node:     {0}", Next.Value.ToString());
                }
            }
            #endregion
        }
        /// <summary>
        /// double linked list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class LLKSTT_60_D<T>
        {
            #region Khởi tạo
            public LLKSTT_60_D()
            {
                First = null;
                Last = null;
            }
            #endregion
            #region Thuộc tính
            public LLKSTT_60_D_node<T> First;
            public LLKSTT_60_D_node<T> Last;
            public int Count
            {
                get
                {
                    return dodai();
                }
            }
            public bool IsEmpty
            {
                get
                {
                    return First == null;
                }
            }
            #endregion
            #region Phương thức
            int dodai()
            {
                int dodai = 0;
                for (LLKSTT_60_D_node<T> i = First; i != null; i = i.Next) dodai++;
                return dodai;
            }
            public void AddLast(LLKSTT_60_D_node<T> node)
            {
                if (Last == null)
                {
                    First = node;
                    Last = node;
                }
                else
                {
                    Last.Next = node;
                    node.Previous = Last;
                    Last = node;
                }
            }
            public void AddFirst(LLKSTT_60_D_node<T> node)
            {
                if (First == null)
                {
                    First = node;
                    Last = node;
                }
                else
                {
                    First.Previous = node;
                    node.Next = First;
                    First = node;
                }
            }
            public LLKSTT_60_D_node<T> AddLast(T value)
            {
                LLKSTT_60_D_node<T> node = new LLKSTT_60_D_node<T>(value);
                this.AddLast(node);
                return node;
            }
            public LLKSTT_60_D_node<T> AddFirst(T value)
            {
                LLKSTT_60_D_node<T> node = new LLKSTT_60_D_node<T>(value);
                AddFirst(node);
                return node;
            }
            public void AddBefore(LLKSTT_60_D_node<T> node, LLKSTT_60_D_node<T> newNode)
            {
                if(First!=null)
                {
                    LLKSTT_60_D_node<T> temp = First;
                    while (temp != null)
                    {
                        if (temp.Value.Equals(node.Value)) break;
                        temp = temp.Next;
                    }
                    if (temp != null)
                    {
                        if (temp == First)
                        {
                            this.AddFirst(newNode);
                        }
                        else
                        {
                            newNode.Previous = temp.Previous;
                            newNode.Previous.Next = newNode;
                            temp.Previous = newNode;
                            newNode.Next = temp;
                        }
                    }
                }
            }
            public void AddAfter(LLKSTT_60_D_node<T> node, LLKSTT_60_D_node<T> newNode)
            {
                LLKSTT_60_D_node<T> temp = First;
                while (temp != null)
                {
                    if (temp.Value.Equals(node.Value)) break;
                    temp = temp.Next;
                }
                if (temp != null)
                {
                    if (temp == Last)
                    {
                        this.AddLast(newNode);
                    }
                    else
                    {
                        newNode.Next = temp.Next;
                        newNode.Next.Previous = newNode;
                        newNode.Previous = temp;
                        temp.Next = newNode;
                    }
                }
            }
            public void AddBefore(LLKSTT_60_D_node<T> node, T value)
            {
                LLKSTT_60_D_node<T> newNode = new LLKSTT_60_D_node<T>(value);
                AddBefore(node, newNode);
            }
            public void AddAfter(LLKSTT_60_D_node<T> node, T value)
            {
                LLKSTT_60_D_node<T> newNode = new LLKSTT_60_D_node<T>(value);
                AddAfter(node, newNode);
            }
            public void Clear()
            {
                First = null;
                Last = null;
            }
            public void RemoveFirst()
            {
                if (First != null)
                {
                    First = First.Next;
                    First.Previous = null;
                }
            }
            public void RemoveLast()
            {
                if (Last != null)
                {
                    Last = Last.Previous;
                    Last.Next = null;
                }
            }
            public bool Remove(LLKSTT_60_D_node<T> node)
            {
                if(First!=null)
                {
                    if (node.Value.Equals(First.Value))
                    {
                        RemoveFirst();
                        return true;
                    }
                    LLKSTT_60_D_node<T> i = First;

                    while (i != null)
                    {
                        if (i.Value.Equals(node.Value)) break;
                        i = i.Next;
                    }
                    if (i != null)
                    {
                        if (i == Last)
                        {
                            RemoveLast();
                            return true;
                        }
                        i.Previous.Next = i.Next;
                        i.Next.Previous = i.Previous;
                        return true;
                    }
                }                
                return false;
            }
            public void Show()
            {
                if(First==null)
                {
                    Console.WriteLine("Danh sach lien ket doi rong");
                }
                    else
                for (LLKSTT_60_D_node<T> i = First; i != null; i = i.Next)
                {
                    Console.WriteLine(i.Value);
                }
            }
            public LLKSTT_60_D_node<T> Find(T value)
            {
                LLKSTT_60_D_node<T> i = First;
                while (i != null)
                {
                    if (i.Value.Equals(value)) break;
                    i = i.Next;
                }
                if (i != null) return i;
                return new LLKSTT_60_D_node<T>(value);
            }
            public LLKSTT_60_D_node<T> FindLast(T value)
            {
                LLKSTT_60_D_node<T> i = Last;
                while (i != null)
                {
                    if (i.Value.Equals(value)) break;
                    i = i.Previous;
                }
                if (i != null) return i;
                return new LLKSTT_60_D_node<T>(value);
            }
            #endregion
        }
        public static void tuan11_main()
        {
            LLKSTT_60_D<int> list = new LLKSTT_60_D<int>();
            LLKSTT_60_D_node<int> node = new LLKSTT_60_D_node<int>();
            node.Value = 45;
            list.AddLast(node);
            node = new LLKSTT_60_D_node<int>(3);
            list.AddFirst(node);
            node = new LLKSTT_60_D_node<int>(4);
            list.AddLast(node);
            node = new LLKSTT_60_D_node<int>(55);
            list.AddLast(node);
            node = new LLKSTT_60_D_node<int>(45);
            LLKSTT_60_D_node<int> newNode = new LLKSTT_60_D_node<int>(2);
            list.AddBefore(node, newNode);
            newNode = new LLKSTT_60_D_node<int>(1);
            list.AddAfter(node, newNode);
            node = new LLKSTT_60_D_node<int>(5);
            list.Remove(node);
            list.Show();
            Console.ReadKey();
        }
    }
}
