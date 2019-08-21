using System;
using System.Collections;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT
{
    class Tuan01
    {
        public class bai_1
        {
            public static void hello()
            {
                Console.WriteLine("Hello CSharp");
            }
        }
        public class bai_2
        {
            public static void nhapxuat()
            {
                Console.WriteLine("\nNhap xuat co ban");
                Console.WriteLine("-------------------------------------------------");
                #region khaibaobien
                byte BienByte = 10;
                short BienShort = 10;
                int BienInt = 10;
                long BienLong = 10;
                long? BienLong_2 = null;            // Biến long không thể đặt là Null nhưng có thể thêm dấu ? vào sau kiểu dữ liệu. Lúc này kiểu dữ liệu của f là long?
                                                    // Kiểu số thực
                float BienFloat = 10.934f;            // Giá trị của biến kiểu float phải có hậu tố f hoặc F. 
                double BienDouble = 10.934;           // Giá trị của biến kiểu double không cần hậu tố.
                decimal BienDecimal = 10.943m;        // Giá trị của biến kiểu decimal phải có hậu tố m.

                // Kiểu ký tự và kiểu chuỗi
                char BienChar = 'H';                // Giá trị của biến kiểu ký tự nằm trong cặp dấu '' (nháy đơn).
                string BienString = "hello CSharp"; // Giá trị của biến kiểu chuỗi nằm trong cặp dấu "" (nháy kép).
                BienString = BienChar + BienString; // Nối biến char vào biến string sẽ thành biến string
                                                    //Khai báo biến mà không cần kiểu dữ liệu, kiểu dữ liệu sẽ được xác định khi gán giá trị cho biến
                var VarString_2 = BienString + " and the World.";          //VarString sẽ mang kiểu dữ liệu của biến BienString.
                var VarInt = BienInt;
                object ObjByte = BienByte;
                #endregion
                #region Xuat
                Console.WriteLine("{0}", VarString_2);
                BienLong_2 = BienShort;
                Console.Write(" {0,20}  = {1} \n", "BienLong", BienLong);        //mặc định căn lề phải
                Console.Write(" {0,-20}  = {1} \n", "BienFloat", BienFloat);     //thêm dấu âm sẽ chuyển sang căn lề trái
                Console.WriteLine(" BienDouble  = {0:F2}", BienDouble);         //làm tròn đến 2 chữ số sau thập phân
                Console.WriteLine(" BienDecimal = {0,4:F1}", BienDecimal);      //để 4 ô viết và làm tròn đến 1 chữ số sau thập phân
                Console.WriteLine(@"D:\Miccrosoft Vissual Studio");             //Cho phép một chuỗi  thô không có xử lý cho các ký tự phía sau dấu \ bên trong 
                Console.WriteLine($"{BienChar}.{BienChar}.{BienChar}");
                #endregion
                #region Nhap
                Console.Write("nhap ki tu:");

                BienChar = Convert.ToChar(Console.ReadLine());       //Đọc 1 ký tự từ bàn phím và trả về kiểu số nguyên
                Console.WriteLine("\n" + BienInt);

                #endregion
            }
        }
        public class bai_3
        {
            public static void y_1_int_giaithua()
            {
                Console.WriteLine("Int_tinh giai thua");
                Console.WriteLine("-------------------------------------------------");
                int a = 0;
                Console.WriteLine(a.GetType());
                Console.WriteLine(typeof(int));
                Console.WriteLine(int.MinValue);
                Console.WriteLine(int.MaxValue);
                int i;
                var sum = new BigInteger(1);
                Console.Write("Nhap du lieu:");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Du lieu vua nhap: {0}", a);
                for (i = 1; i <= a; i++)
                {
                    sum = sum * i;
                }
                Console.WriteLine("Giai thua cua {0} la {1}", a, sum);
            }
            public static void y_2_double_ptbac2()
            {
                Console.WriteLine("Double_giai phuong trinh bac 2");
                Console.WriteLine("-------------------------------------------------");
                double a = 0, b, c;
                Console.WriteLine(a.GetType());
                Console.WriteLine(typeof(double));
                Console.WriteLine(double.MinValue);
                Console.WriteLine(double.MaxValue);
                Console.Write("a = ");
                a = double.Parse(Console.ReadLine());
                Console.Write("b = ");
                b = double.Parse(Console.ReadLine());
                Console.Write("c = ");
                c = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    if (b == 0)
                    {
                        if (c == 0) Console.WriteLine("Phuong trinh co vo so nghiem");
                        else Console.WriteLine("Phuong trinh vo nghiem");
                    }
                    else Console.WriteLine("Phuong trinh bac 1 co nghiem la {0}", -c / b);
                }
                else
                {
                    double esplsi = 0.00000000000001;
                    double delta = b * b - 4 * a * c;
                    if (delta > 0) Console.WriteLine("Phuong trinh co 2 nghiem la {0} va {1}", (-b + Math.Sqrt(delta) / (2 * a)), (-b - Math.Sqrt(delta) / (2 * a)));
                    if (0 < delta && delta < esplsi) Console.WriteLine("Phuong trinh co nghiem kep la {0}", -b / (2 * a));
                    if (delta < 0) Console.WriteLine("Phuong trinh co 2 nghiem ao la {0} + i({1} và {0} - i({1}", -b / (2 * a), Math.Sqrt(Math.Abs(delta)));

                }
            }
            public static void y_3_char_ktkitu()
            {
                Console.WriteLine("Char_kiem tra ki tu");
                Console.WriteLine("-------------------------------------------------");
                char a = 'A';
                Console.Write("nhap ki tu can kiem tra:");
                a = Convert.ToChar(Console.Read());
                Console.Write("Ki tu \"{0}\" ", a);
                if (char.IsLetter(a))
                {
                    if (char.IsUpper(a)) Console.Write("la chu cai in hoa ");
                    if (char.IsLower(a)) Console.Write("la chu cai in thuong");
                }
                else if (char.IsNumber(a)) Console.Write("la chu so ");
                else if (char.IsPunctuation(a)) Console.Write("la dau cau ");
                else if (char.IsWhiteSpace(a)) Console.Write("la dau cach ");
                else Console.Write("khong xac dinh");
            }
            public static void y_4_array_chensovaomang()
            {
                Console.WriteLine("array_chen so vao mang");
                Console.WriteLine("-------------------------------------------------");
                int[] arr1 = new int[10];
                int i, n, p, x;
                do
                {
                    Console.Write("Nhap kich co mang(<10): ");
                    n = Convert.ToInt32(Console.ReadLine());
                    if (n > 10) Console.WriteLine("n>10, nhap lai");
                } while (n > 10);
                /* nhap cac phan tu vao trong mang*/
                Console.Write("Nhap {0} phan tu vao trong mang:\n", n);
                for (i = 0; i < n; i++)
                {
                    Console.Write("Phan tu - {0}: ", i);
                    arr1[i] = Convert.ToInt32(Console.ReadLine());
                }


                Console.Write("Nhap gia tri phan tu moi can chen: ");
                x = Convert.ToInt32(Console.ReadLine());
            nhaplai: Console.Write("Nhap vi tri can chen phan tu moi nay: ");
                p = Convert.ToInt32(Console.ReadLine());
                if (p > n) { Console.WriteLine("vi tri can cho vuot qua so phan tu la {0}", n); goto nhaplai; }
                Console.Write("In mang ban dau:\n");
                for (i = 0; i < n; i++)
                    Console.Write("{0} ", arr1[i]);
                /* di chuyen vi tri cac phan tu ben phai cua mang */
                for (i = n; i >= p; i--)
                    arr1[i] = arr1[i - 1];
                /* chen gia tri vao vi tri da cho */
                arr1[p - 1] = x;


                Console.Write("\n\nSau khi chen phan tu, mang co dang:\n");
                for (i = 0; i <= n; i++)
                    Console.Write("{0} ", arr1[i]);
                Console.Write("\n\n");

                Console.ReadKey();
            }
            /*       public static void y_5_list_dongian()
                      {
                          int[] b = new int[3];
                          b[0] = 1;
                          b[1] = 2;
                          b[2] = 3;

                      List<int> a = new List<int>(b);
                          a.Add(4);
                          a.Add(5);
                          a.AddRange(b);
                          foreach( int i in a)
                          {
                              Console.WriteLine(i);
                          }
                      }

           public void y_3_char_dongian()
           {
               char value = "abcdef"[0];
               Console.WriteLine(value);
               Console.WriteLine((int)value);
               Console.WriteLine(value == 'y');
               Console.WriteLine(value.GetType());
               Console.WriteLine(typeof(char));
               Console.WriteLine((int)char.MinValue);
               Console.WriteLine((int)char.MaxValue);
               if (char.IsLower(value)) Console.WriteLine(char.ToUpper(value));
               else Console.WriteLine(char.ToLower(value));
               value = Convert.ToChar(Console.Read());
               Console.WriteLine("ki tu {0} co ma ASCII la {1}", value, Convert.ToInt32(value));
           }

           public void y_4_array_dongian()
           {
               string[] array = { "red", "blue", "green" };
               // Loop with for each and write colors with string interpolation.
               foreach (string mau in array)
               {
                   System.Console.WriteLine($"Color = {mau}");
               }
           }
           public void y_6_string_dongian()
           {
               string c = "hello";
               string a = "\u0068ello ";
               string b = "h";
               // Append to contents of 'b'  
               b += "ello";
               Console.WriteLine(c == b);

               Console.WriteLine(a + b);
               Console.WriteLine(a + b == "Hello hello");
           }
                */
            public static void y_5_list_ghira()
            {
                Console.WriteLine("list _ghi ra)");
                Console.WriteLine("-------------------------------------------------");
                ArrayList c = new ArrayList() { "Toi la sinh vien", false };
                ArrayList arrayList = new ArrayList() { "Toi la Hung", 20 };
                arrayList.Add("Toi la nam");
                arrayList.AddRange(c);
                foreach (var thanhphan in arrayList)
                {
                    Console.WriteLine(thanhphan);
                }
                Console.Write(arrayList.Contains(20));
            }
            public static void y_6_string_kttk()
            {
                Console.WriteLine("string _ kiem tra tai khoan");
                Console.WriteLine("-------------------------------------------------");
                string user_0 = "hung", pass_0 = "1234";
                string username, password; //khai bao hai chuoi
                int ctr = 0;
                Console.Write("Mac dinh username va password la: {0} va {1}\n", user_0, pass_0);
                Console.Write("------------------------------------------------------\n");

                do
                {
                    Console.Write("Nhap username: ");
                    username = Console.ReadLine();

                    Console.Write("Nhap password: ");
                    password = Console.ReadLine();

                    if (username != user_0 || password != pass_0)
                    {
                        ctr++;
                        Console.WriteLine("Ban da nhap sai, moi nhap lai, ban con {0} lan nhap nua ", 3 - ctr);
                    }
                    else
                        ctr = 1;

                }
                while ((username != user_0 || password != pass_0) && (ctr != 3));

                if (ctr == 3)
                    Console.Write("\nBan da nhap sai username va password qua 3 lan. Xin hay thu lai sau!\n\n");
                else
                    Console.Write("\nBan da nhap mat khau dung!\n\n");
            }
        }
        public class bai_4
        {
            public static void y1_swich()
            {
                Console.WriteLine("switch_goto kiem tra thang nhap vao co bao ngay");
                Console.WriteLine("-------------------------------------------------");
                int thang;
                Console.Write("Nhap thang can xet: ");
                int.TryParse(Console.ReadLine(), out thang);
                Console.Write("Thang {0} ", thang);
                switch (thang)
                {
                    case 1:
                        Console.WriteLine("co 31 ngay");
                        break;
                    case 2:
                        Console.WriteLine("co 28 ngay hoac 29 ngay ");
                        break;
                    case 3:
                        goto case 1;
                    case 4:
                        Console.WriteLine("co 30 ngay");
                        break;
                    case 5:
                        goto case 1;
                    case 6:
                        goto case 4;
                    case 7:
                        goto case 1;
                    case 8:
                        goto case 1;
                    case 9:
                        goto case 4;
                    case 10:
                        goto case 1;
                    case 11:
                        goto case 4;
                    case 12:
                        goto case 1;
                    default:
                        Console.WriteLine("khong ton tai");
                        break;
                }
            }
            public static void y2_dowhile()
            {
                Console.WriteLine("do while_kiem tra so nguyen to");
                Console.WriteLine("-------------------------------------------------");
                int number;
                int bien_dem = 0;
                int i = 1;
                Console.Write("Nhap mot so bat ky: ");
                number = Convert.ToInt32(Console.ReadLine());
                if (number == 2 || number == 3) Console.WriteLine("So da cho la so nguyen to.");
                else
                {
                    do
                    {
                        i++;
                        if (number % i == 0) { bien_dem++; break; }
                    }
                    while (bien_dem > 0 || i == number - 1);
                    if (bien_dem == 0)
                        Console.WriteLine("So da cho la so nguyen to.");
                    else
                        Console.WriteLine("So da cho khong phai la so nguyen to.");
                }
            }
        }
    }
}
