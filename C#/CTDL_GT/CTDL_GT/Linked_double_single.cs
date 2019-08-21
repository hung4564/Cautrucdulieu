using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT
{
    class Linked_double_single
    {
        class Node_S
        {
            public Node_S()
            {
                Next = null;
            }
            public Node_S Next;
            public int Info;
        }
        class Node_D
        {
            public Node_D()
            {
                Lptr = null;
                Rptr = null;
            }
            public Node_D Lptr;
            public Node_D Rptr;
            public int Info;
            public void show()
            {
                if (Lptr != null)
                    Console.WriteLine("nut truoc cua {0} la {1}", Info, Lptr.Info);
                if (Rptr != null)
                    Console.WriteLine("nut sau cua {0} la {1}", Info, Rptr.Info);
            }
        }
        static Node_S SL = null; // Initial, SL quản lý danh sách liên kết đơn
        static Node_D LL = null; // Initial, LL quản lý danh sách liên kết kép ở phía trái
        static Node_D RL = null; // Initial, RL quản lý danh sách liên kết kép ở phía phải
        #region Danh sách liên kết đơn SL
        //Bổ xung một phần tử vào đầu danh sách đơn SL
        static void AddFirst_S(int x)
        {
            Node_S Sp = new Node_S();
            /*
            Tạo một nút có cấu trúc Node_s được trỏ bởi Sp(nghĩa là đỉa chỉ của node nằm trong con trỏ Sp)
            Địa chỉ của node là một số nguyên
            Sp là con trỏ, là một biến đặc biệt chứa địa chỉ của biến
            Một biến bất kì phải có địa chỉ
            Máy tính truy cập theo địa chỉ
            để truy cập một biến cần dùng tên biến hoặc địa chỉ của biến
            Địa chỉ của biến có thể nằm ở trong con trỏ
            */
            Sp.Info = x;//truy cập(gắn =x) vào trường info của node vừa tạo bằng con trỏ sp
            Sp.Next = SL;
            SL = Sp;
        }
        //Bổ xung một phần tử vào cuối danh sách đơn SL
        static void AddLast_S(int x)
        {
            Node_S Sp = new Node_S();
            Sp.Info = x;
            Sp.Next = null;
            if (SL == null)
            {
                SL = Sp;
            }
            else
            {
                Node_S Sq = SL;//tạo 1 con trỏ trung gian duyện danh sách SL
                while (Sq.Next != null)
                {
                    Sq = Sq.Next;
                }
                //Sq trỏ vào phần tử cuối danh sách
                Sq.Next = Sp;
            }
        }
        //Xóa một phần tử ở đầu danh sách đơn SL
        static void DeleteFirst_S()
        {
            if (SL != null)
            {
                SL = SL.Next;
            }
        }
        //Xóa một phần từ ở cuối danh sách đơn SL
        static void DeleteLast_S()
        {
            if (SL != null)
            {
                if (SL.Next == null)
                {
                    SL = null;
                }
                else
                {
                    Node_S Sq = SL;//tạo 1 con trỏ trung gian duyện danh sách SL
                    while (Sq.Next.Next != null)
                    {
                        Sq = Sq.Next;
                    }
                    Sq.Next = null;
                }
            }
        }
        //Duyệt in ra toàn bộ danh sách đơn SL
        static void Traver_S()
        {
            if (SL == null)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            Node_S Sq = SL;//tạo 1 con trỏ trung gian duyện danh sách SL
            while (Sq != null)
            {
                Console.WriteLine("Info : {0}", Sq.Info);
                Sq = Sq.Next;
            }
        }
        //Tìm phần từ chứa giá trị x trong danh sách đơn SL không thì trả về null
        static Node_S Find_S(int x)
        {
            Node_S Sq = SL;
            while (Sq != null)
            {
                if (Sq.Info == x) return Sq;
                Sq = Sq.Next;
            }
            return null;
        }
        //Xóa phần tử chứa giá trí x trong danh sách đơn trả về giá trị true nếu xóa được không thì trả về false
        static bool Remove_S(int x)
        {
            if (SL != null)
            {
                if (SL.Info == x)//nếu giá trị đầu tiên chứa giá trị x thì thoát
                {
                    SL = SL.Next;
                    return true;
                }
                else
                {
                    Node_S Sq = SL;
                    while (Sq.Next != null)
                    {
                        if (Sq.Next.Info == x) break;
                        Sq = Sq.Next;
                    }//Sq trỏ phần tử trước phần tử cần xóa
                    if (Sq.Next != null)//Sq trở tới phần tử trước phần tử cần xóa
                    {
                        Sq.Next = Sq.Next.Next;
                        return true;
                    }
                }
            }
            return false;
        }
        //Xóa toàn bộ phần tử chứa giá trí x trong danh sách đơn trả về giá trị true nếu xóa hết được không thì trả về false
        static bool RemoveAll_S(int x)
        {
            if (SL != null)
            {
                Node_S Sq;
                while (SL.Info == x)//nếu phần tử đầu tiên chứa x, xóa phần tử đầu tiên
                {
                    DeleteFirst_S();
                }
                Sq = SL;
                while (Sq.Next != null)
                {
                    if (Sq.Next.Info == x)//Sq trỏ phần tử trước phần tử cần xóa nếu ko tm chuyển sang phần tử tiếp theo
                    {
                        Sq.Next = Sq.Next.Next;
                    }
                    else
                    {
                        Sq = Sq.Next;
                    }
                }
            }
            return Find_S(x) != null; ;
        }
        //Xóa toàn bộ danh sách đơn
        static void Clear_S()
        {
            SL = null;
        }
        #endregion
        #region Danh sách liên kết đôi LL,RL
        //Bổ xung một phần tử vào đầu danh sách đôi LL,RL
        static void AddFirst_D(int x)
        {
            Node_D Sq = new Node_D();
            Sq.Info = x;
            if (LL == null)        //danh sách rỗng thì gán RL,LL trỏ tới Sq
            {
                LL = Sq;
                RL = Sq;
            }
            else
            {
                Sq.Rptr = LL;       //Sq nối với LL cũ
                LL.Lptr = Sq;
                LL = Sq;            //Thay đổi LL
            }
        }
        //Bổ xung một phần tử vào cuối danh sách đôi LL,RL
        static void AddLast_D(int x)
        {
            Node_D Sq = new Node_D();
            Sq.Info = x;
            if (RL == null)        //danh sách rỗng thì gán RL,LL trỏ tới Sq
            {
                LL = Sq;
                RL = Sq;
            }
            else
            {
                Sq.Lptr = RL;       //Sq nối với RL
                RL.Rptr = Sq;
                RL = Sq;            //Thay đổi RL
            }
        }
        //Xóa một phần tử ở đầu danh sách đôi LL,RL
        static void DeleteFirst_D()
        {
            if (LL != null)
            {
                LL = LL.Rptr;
                LL.Lptr = null;
            }
        }
        //Xóa một phần từ ở cuối danh sách đôi LL,RL
        static void DeleteLast_D()
        {
            if (RL != null)
            {
                RL = RL.Lptr;
                RL.Rptr = null;
            }
        }
        //Duyệt in ra toàn bộ danh sách đôi LL,RL
        static void Traver_D()
        {
            if(LL==null)
            {
                Console.WriteLine("Danh sach rong");
                return;
            }
            Node_D Sq = LL;//tạo 1 con trỏ trung gian duyện danh sách SL
            while (Sq != null)
            {
                Console.WriteLine("Info : {0}", Sq.Info);
                Sq = Sq.Rptr;
            }
        }
        //Tìm phần từ chứa giá trị x trong danh sách đôi SL không thì trả về null
        static Node_D Find_D(int x)
        {
            if (LL != null)
            {
                Node_D Sq = LL, Sp = RL;
                while (Sq != null)
                {
                    if (Sq.Info == x)
                    {
                        break;
                    }
                    Sq = Sq.Rptr;
                }
                return Sq;
            }
            return null;
        }
        //Xóa phần từ chứa giá trị x trong danh sách đôi
        static void Remove_D(int x)
        {
            Node_D temp = Find_D(x);
            if (temp != null)
            {
                if (temp == LL) DeleteFirst_D();
                else
                if (temp == RL) DeleteLast_D();
                else
                {
                    temp.Lptr.Rptr = temp.Rptr;
                    temp.Rptr.Lptr = temp.Lptr;
                }
            }
        }
        //Xóa toàn bộ phẩn tự chứa giá trị x trong danh sách đôi
        static void RemoveAll_D(int x)
        {
            if(LL!=null)
            {
                while (LL.Info==x) DeleteFirst_D();
                while (RL.Info== x) DeleteLast_D();
                Node_D temp = LL;
                while(temp!=null)
                {
                    if(temp.Info==x)
                    {
                        temp.Lptr.Rptr = temp.Rptr;
                        temp.Rptr.Lptr = temp.Lptr;
                    }
                    temp = temp.Rptr;
                }
            }
        }
        //Xóa toàn bộ danh sách đơn
        static void Clear_D()
        {
            LL = null;
            RL = null;
        }
        #endregion
        public static void main_Linked_S()
        {
            for (int i = 0; i < 4; i++)
            {
                AddLast_S(i);
            }
            for (int i = 0; i < 4; i++)
            {
                AddLast_S(i);
            }
            for (int i = 0; i < 3; i++)
            {
                AddLast_S(4);
            }
            Traver_S();
            Console.WriteLine("Xoa phan tu dau");
            DeleteFirst_S();
            Traver_S();
            Console.WriteLine("Xoa phan tu cuoi");
            DeleteLast_S();
            Traver_S();
            int x = 3;
            Console.WriteLine("Xoa phan tu chua gia tri x ={0}", x);
            Remove_S(x);
            Traver_S();
            x = 4;
            Console.WriteLine("Xoa toan bo phan tu chua gia tri x ={0}", x);
            RemoveAll_S(x);
            Traver_S();
            Console.ReadKey();
        }
        public static void main_Linked_D()
        {
            for (int i = 0; i < 4; i++)
            {
                AddLast_D(i * 10);
            }
            for (int i = 0; i < 4; i++)
            {
                AddFirst_D(i*10);
            }
            Traver_D();
            int x = 0;
            Node_D q = Find_D(0);
            q.show();
            x = 30;
            Remove_D(x);
            Console.WriteLine("Day sau khi xoa phan tu {0}", x);
            Traver_D();
            x = 20;
            RemoveAll_D(x);
            Console.WriteLine("Day sau khi xoa toan bo phan tu {0}", x);
            Traver_D();
            Clear_D();
            Traver_D();
            Console.ReadKey();
        }
    }
}
