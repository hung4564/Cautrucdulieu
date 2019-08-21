using System;
using System.Text.RegularExpressions;

namespace CTDL_GT
{
    class Tuan04
    {
        public static double tinh_e(double x, double epslion = 0.0001)
        {
            double giaithua = 1, sum = 1;
            int i = 1;
            while (giaithua > epslion)
            {
                giaithua = giaithua * 1 / i * x;
                sum = sum + giaithua;
                i++;
            }
            return sum;
        }
        public static double ln_temp(double x, double epslion = 0.0001)
        {
            double giaithua = -1, ketqua = 0;
            int i = 1;
            x = x - 1;
            while (Math.Abs(giaithua) > epslion)
            {
                if (i > 1) giaithua = giaithua * (-1) * (i - 1) / i * x; else giaithua = x;
                ketqua = ketqua + giaithua;
                i++;
            }
            return ketqua;
        }
        public static double tinh_ln(double x, double epslion = 0.0001)
        {
            if (x <= 2) return ln_temp(x, epslion);
            //ln(1 + x) = ln(1 + 1/x) - ln(1/x).
            else return ln_temp(1 + 1 / (x - 1), epslion) - ln_temp(1 / (x - 1), epslion);
        }
        public static double canbac_ncuam(double so, double mu, double epslion = 1E-5)
        {
            return tinh_e(1 / mu * tinh_ln(so, epslion), epslion);
        }
        public static void demtu()
        {
            Console.Write("Nhap chuoi: ");
            string s = Console.ReadLine();
            char[] mychar = { '\t', ' ' };
            //string[] tu = s.Split(mychar,StringSplitOptions.RemoveEmptyEntries);
            string[] tu = Regex.Split(s, " ", RegexOptions.None);
            Console.WriteLine("Chuoi '{0}' co {1} tu", s, tu.Length);
        }
    }
}
