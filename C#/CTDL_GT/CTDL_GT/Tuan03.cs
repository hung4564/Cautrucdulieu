using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTDL_GT
{
    class Tuan03
    {
        public static void dem_tu()
        {
            Console.Write("Nhap cau:");
            int dem = 0;
            string s = Console.ReadLine();

            while (s.IndexOf("  ") >= 0)
            {
                s = s.Replace("  ", " ");
            }
            if (s[0] == ' ')
            {
                s = s.Remove(0, 1);
            }
            if (s[s.Length - 1] == ' ')
            {
                s = s.Remove(s.Length - 1, 1);
            }
            if (s.IndexOf(" ") < 1) dem = 0;
            else
            {
                for (int i = s.IndexOf(" "); i < s.Length; i++)
                {
                    if (s[i] == ' ') dem++;
                }
            }
            Console.WriteLine(s);
            Console.WriteLine(dem + 1 + " tu");
        }
        public static void tinh_pi(double epslion = 0.0001)
        {
            double giaithua = 1;
            double sum = 0;
            int i = 0;
            while (Math.Abs(giaithua) > epslion)
            {

                giaithua = giaithua * (-1) * (2 * i - 1) / (2 * i + 1);
                sum = sum + giaithua;
                i++;
            }
            Console.WriteLine(4 * sum);
        }
        public static void tinhtbc()
        {
            /*tinh trung binh cong cua so chan cua day cac so nguyen duong*/
            int[] so = new int[100];
            int n;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());
            int i = 0, dem = 0;
            int sum = 0;
            do
            {
                Console.Write("so[{0}] = ", i);
                so[i] = Convert.ToInt32(Console.ReadLine());
                if (so[i] < 0) Console.WriteLine("Nhap so duong, nhap lai"); else i++;
                if (so[i - 1] % 2 == 0)
                {
                    sum = sum + so[i - 1];
                    dem++;
                }
            }
            while (i < n || so[i] < 0);
            if (dem == 0) dem = 1;
            Console.WriteLine("trung binh cong cua cac so chan la {0:F3}", (double)sum / dem);
        }
    }
}
