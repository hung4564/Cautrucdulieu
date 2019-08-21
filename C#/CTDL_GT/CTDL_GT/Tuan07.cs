using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT
{
    class Tuan07
    {
        public static void tuan07_main()
        {
            LinkedList<string> danhSach = new LinkedList<string>();
            themphantu(danhSach);
        }
        enum menu1
        {
            themdau = 1,
            themcuoi,
            themsau_node,
            themtruoc_node,
            xem,
            xoa,
            themnhieu,
            thoat
        }
        public static void themphantu(LinkedList<string> danhSach)
        {
            int select;
            List<int> menu = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Phan tu dang string");
                    Console.WriteLine("1.Them phan tu vao dau");
                    Console.WriteLine("2.Them phan tu vao cuoi");
                    Console.WriteLine("3.Them phan tu vao sau mot node");
                    Console.WriteLine("4.Them phan tu vao dau mot node");
                    Console.WriteLine("5.xem danh sach");
                    Console.WriteLine("6.Xoa phan tu");
                    Console.WriteLine("7.Them nhieu phan tu");
                    Console.WriteLine("8.Thoat");
                    if (!Int32.TryParse(Console.ReadLine(), out select)) select = 0;

                    LinkedListNode<string> temp;
                    switch (select)
                    {
                        case (int)menu1.themdau:
                            Console.Write("\nNhap phan tu vao dau danh sach lien ket: ");
                            danhSach.AddFirst(Console.ReadLine());
                            break;
                        case (int)menu1.themcuoi:
                            Console.Write("\nNhap phan tu vao cuoi danh sach lien ket: ");
                            danhSach.AddLast(Console.ReadLine());
                            break;
                        case (int)menu1.themsau_node:
                            Console.Write("\nNhap phan tu can them: ");
                            temp = timptu(danhSach);
                            if (temp == null) Console.WriteLine("Khong tim thay phan tu chon");
                            else
                            {
                                Console.WriteLine("Them phan tu moi vao sau \"{0}\"", temp.Value);
                                danhSach.AddAfter(temp, Console.ReadLine());
                            }
                            break;
                        case (int)menu1.themtruoc_node:
                            temp = timptu(danhSach);
                            if (temp == null) Console.WriteLine("Khong tim thay phan tu chon");
                            else
                            {
                                Console.WriteLine("Them phan tu moi vao truoc \"{0}\"", temp.Value);
                                danhSach.AddBefore(temp, Console.ReadLine());
                            }
                            break;
                        case (int)menu1.xem:
                            break;
                        case (int)menu1.xoa:
                            Console.WriteLine("Nhap phat tu xoa");
                            if (danhSach.Remove(Console.ReadLine())) Console.WriteLine("Xoa thanh cong"); else Console.WriteLine("Khong ton tai phan tu ban chon");
                            break;
                        case (int)menu1.themnhieu:
                            bool check;
                            int n;
                            do
                            {

                                Console.Write("nhap so luong phan tu muon them:");
                                check = Int32.TryParse(Console.ReadLine(), out n);
                                if (!check) Console.WriteLine("Nhap so");
                            } while (!check);
                            for (int i = n - 1; i >= 0; i--)
                            {
                                Console.Write("\nNhap phan tu: ");
                                danhSach.AddLast(Console.ReadLine());
                            }
                            break;
                        case (int)menu1.thoat:
                            break;
                        default:
                            Console.WriteLine("Chi chon so trong menu");
                            break;
                    }
                } while (!menu.Contains(select));
                if (select > 0 && select < 8)
                {
                    if (danhSach.Count == 0) Console.WriteLine("danh sach rong");
                    else
                    {
                        Console.WriteLine("danh sach phan tu");
                        foreach (var item in danhSach)
                        {
                            Console.Write(item + " ");
                        }
                    }
                }
                string s;
                do
                {
                    Console.WriteLine("\nBan muon tiep tuc(Y,N)");
                    s = Console.ReadLine();
                    if (s.ToUpper() == "N" || s.ToUpper() == "Y") break; else Console.WriteLine("chi nhap y hoac n");
                } while (true);
                if (s.ToUpper() == "N") break;
            } while (true);
        }
        public static LinkedListNode<string> timptu(LinkedList<String> danhSach)
        {
            Console.Write("\nPhan tu chon: ");
            string temp = Console.ReadLine();
            LinkedListNode<string> temp_node = danhSach.Find(temp);
            return temp_node;
        }
        public static void DisplayProperties(LinkedListNode<String> lln)
        {
            if (lln.List == null)
                Console.WriteLine("   Node is not linked.");
            else
                Console.WriteLine("   Node belongs to a linked list with {0} elements.", lln.List.Count);

            if (lln.Previous == null)
                Console.WriteLine("   Previous node is null.");
            else
                Console.WriteLine("   Value of previous node: {0}", lln.Previous.Value);

            Console.WriteLine("   Value of current node:  {0}", lln.Value);

            if (lln.Next == null)
                Console.WriteLine("   Next node is null.");
            else
                Console.WriteLine("   Value of next node:     {0}", lln.Next.Value);

            Console.WriteLine();
        }
    }
}
