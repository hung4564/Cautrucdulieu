using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT
{
    class Tuan05
    {
        public static void chuyen10_2(int heso10)
        {
            Stack<int> stack = new Stack<int>();
            while (heso10 > 0)
            {
                stack.Push(heso10 % 2);
                heso10 = heso10 / 2;
            }
            Console.WriteLine("he so 2 cua {0}",heso10);
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
            }

        }
        public static void trycatch()
        {
            byte[] a = new byte[5];
            //nhap mang
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("a[{0}]=", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong duoc nhap ki tu cho mang so");
            }
            catch (OverflowException)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Khong duoc nhap gia tri nam ngoai mien 0-255");
            }
            catch (IndexOutOfRangeException)
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Loi vuot qua pham vi cua mang");
            }
            //in mang
            for (int i = 0; i < 5; i++)
                Console.Write(" {0}", a[i]);
        }
        class Trycatch_test
        {
            public static void test1()
            {
                try
                {
                    Console.WriteLine("Vao phuong thuc 1");
                    test2();
                    Console.WriteLine("Thoat phuong thuc 1");
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Thoat phuong thuc 1 voi loi");
                }
            }
            public static void test2()
            {
                Console.WriteLine("Vao phuong thuc 2");
                throw new Exception("error tai day");
            }
        }
        public static void trycatch_test()
        {
            try
            {
                Console.WriteLine("Vao phuong thuc");
                Trycatch_test.test1();
                Console.WriteLine("Thoat phuong thuc");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Thoat phuong thuc voi loi");
            }
        }
        public static void xoaptlist()
        {
            int[] b = {1,2,3,4,5,6,7,8,9,10};
            List<int> list = new List<int>();
            int index=-1;
            list.AddRange(b);
            foreach (var e in list)
            {
                Console.Write(e+" ");
            }
            Console.WriteLine("");
            Console.WriteLine("1. chon vi tri can xoa");
            Console.WriteLine("2. chon phan tu can xoa");
            Console.Write("Ban chon: ");
            char nut = Convert.ToChar(Console.ReadLine());
            switch (nut)
            {
                case '1':
                    Console.Write("Nhap vi tri phan tu can xoa:");
                    index = Int32.Parse(Console.ReadLine());
                    index = index - 1;
                    break;
                case '2':
                    Console.Write("Nhap gia tri phan tu can xoa:");
                    int a=Int32.Parse(Console.ReadLine());
                    index = index = list.FindIndex(x => x == a);
                    break;
                default:
                    Console.WriteLine("chi chon 1 hoac 2");
                    break;
            }
            if (index >= 0 && index < list.Count) list.RemoveAt(index); else Console.WriteLine("Cap nhap khong thanh cong");
            foreach(var e in list)
            {
                Console.Write(e + " ");
            }
        }
    }
}