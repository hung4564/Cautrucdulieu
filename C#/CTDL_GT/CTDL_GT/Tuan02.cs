using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace CTDL_GT
{
    class Tuan02
    {
        class So_phuc
        {
            double thuc, ao;
            double eplsion = 0.00000001;
            public void in_giatri()
            {
                if (this.thuc > eplsion || this.thuc < -eplsion) Console.Write("{0}", this.thuc);
                if (this.ao > eplsion) Console.Write("+");
                else if (this.ao < -eplsion) Console.Write("-");
                if (this.ao > eplsion || this.ao < -eplsion) Console.Write("{0}i", Math.Abs(this.ao));
            }
            public override string ToString()
            {
                string s = "";
                if (this.thuc > eplsion || this.thuc < -eplsion) s = this.thuc.ToString();
                if (this.ao > eplsion) s = s + "+";
                else if (this.ao < -eplsion) s = s + "-";
                if (this.ao > eplsion || this.ao < -eplsion) s = s + Math.Abs(this.ao).ToString();
                return s;
            }
            public So_phuc()
            {

            }
            public So_phuc(double t, double o)
            {
                this.thuc = t;
                this.ao = o;
            }
            public So_phuc lien_hop()
            {
                So_phuc c = new So_phuc();
                c.thuc = this.thuc;
                c.ao = -this.ao;
                return c;
            }
            public static So_phuc operator +(So_phuc a, So_phuc b)
            {
                return new So_phuc(a.thuc + b.thuc, a.ao + b.ao);
            }
            public static So_phuc operator -(So_phuc a, So_phuc b)
            {
                return new So_phuc(a.thuc - b.thuc, a.ao - b.ao);
            }
            public static So_phuc operator -(So_phuc a)
            {
                return new So_phuc(-a.thuc, -a.ao);
            }
            public static So_phuc operator *(So_phuc a, So_phuc b)
            {
                return new So_phuc(a.thuc * b.thuc - a.ao * b.ao, a.thuc * b.ao + a.ao * b.thuc);
            }
            public static So_phuc operator *(int b, So_phuc a)
            {
                return new So_phuc(a.thuc * b, a.ao * b);
            }
            public double modun()
            {
                return Math.Sqrt(this.thuc * this.thuc + this.ao * this.ao);
            }
            public So_phuc Sqrl()
            {
                So_phuc c = new So_phuc();
                double delta = this.modun();
                c.thuc = Math.Sqrt((this.thuc + delta) / 2);
                c.ao = this.ao / c.thuc / 2;
                return c;
            }
            public So_phuc nghichdao()
            {
                So_phuc a = new So_phuc();
                a.thuc = this.thuc / (this.modun());
                a.ao = -this.ao / this.modun();
                return a;
            }
            public static So_phuc operator /(So_phuc so_bi_chia, int so_chia)
            {
                return new So_phuc(so_bi_chia.thuc / so_chia, so_bi_chia.ao / so_chia);
            }
            public static So_phuc operator /(So_phuc so_bi_chia, So_phuc so_chia)
            {
                So_phuc thuong = new So_phuc();
                thuong = so_chia.lien_hop();
                thuong = thuong * so_bi_chia;
                thuong.thuc = thuong.thuc / (so_chia.thuc * so_chia.thuc + so_chia.ao * so_chia.ao);
                thuong.ao = thuong.ao / (so_chia.thuc * so_chia.thuc + so_chia.ao * so_chia.ao);
                return thuong;
            }
            public void chuyendoi(string s)
            {
                string thuc = "", ao = "";
                double heso_thuc = 0, heso_ao = 0;
                int diachi = 0;
                if (s.Length < 1) Console.WriteLine("Nhap sai");
                else
                {
                    while (s.IndexOf(" ") > 0)
                    {
                        s = s.Remove(s.IndexOf(" "), 1);
                    }
                    if (s.IndexOf("+", 1) > 0) diachi = s.IndexOf("+", 1);
                    if (s.IndexOf("-", 1) > 0) diachi = s.IndexOf("-", 1);
                    if (diachi == 0)
                    {
                        if (s.IndexOf("i") >= 0)
                        {
                            ao = s.Substring(0);
                            ao = ao.Remove(ao.IndexOf("i"));
                            thuc = "0";
                        }
                        else
                        {
                            thuc = s.Substring(0);
                            ao = "0";
                        }
                    }
                    else
                    {
                        thuc = s.Substring(0, diachi);
                        ao = s.Substring(diachi);
                        ao = ao.Remove(ao.IndexOf("i"));
                    }
                    if (ao.Length == 1)
                    {
                        if (ao[0] == '+') ao = "1";
                        if (ao[0] == '-') ao = "-1";
                    }
                    if (ao.Length == 0)
                    {
                        ao = "1";
                    }
                    try
                    {
                        heso_thuc = Convert.ToDouble(thuc);
                        heso_ao = Convert.ToDouble(ao);
                        this.thuc = heso_thuc;
                        this.ao = heso_ao;
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error);
                    }
                }
            }
        }
        public static void giaiptbac_sophuc()
        {
            string nhap;
            var a = new So_phuc();
            var b = new So_phuc();
            var c = new So_phuc();
            Console.Write("nhap he so a:");
            nhap = Console.ReadLine();
            a.chuyendoi(nhap);
            Console.Write("nhap he so b:");
            nhap = Console.ReadLine();
            b.chuyendoi(nhap);
            Console.Write("nhap he so c:");
            nhap = Console.ReadLine();
            c.chuyendoi(nhap);
            So_phuc delta = b * b + (-4) * a * c;
            delta.in_giatri();
            Console.Write("\n");
            delta = delta.Sqrl();
            delta.in_giatri();
            So_phuc x1, x2, d;
            d = -b + delta;
            x1 = (-b + delta) / (2 * a);
            x2 = (-b - delta) / (2 * a);
            Console.Write("\nx1=");
            x1.in_giatri();
            Console.Write("\nx2=");
            x2.in_giatri();
        }
        public static void ptbacn()
        {
            int n;
            Console.Write("Nhap n:");
            n = Convert.ToInt32(Console.ReadLine());
            int x;
            Console.Write("Nhap x:");
            x = Convert.ToInt32(Console.ReadLine());
            List<int> list_heso = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap he so thu {0}", i);
                int a = Convert.ToInt32(Console.ReadLine());
                list_heso.Add(a);
            }
            long sum = 0, giaithua = 1;
            foreach (var heso in list_heso)
            {
                giaithua = giaithua * x;
                sum = sum + heso * giaithua;
            }
            Console.WriteLine("F({0},{1})={2}", x, n, sum);
        }
        public static void tinh_e()
        {
            double x, epslion = 0.000001;
            double giaithua = 1, sum = 1;
            Console.Write("Nhap x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap epslion:");
            epslion = Convert.ToDouble(Console.ReadLine());
            int i = 1;
            while (giaithua > epslion)
            {
                giaithua = giaithua * 1 / i * x;
                sum = sum + giaithua;
                i++;
            }
            Console.Write("e^({0})={1}", x, sum);
        }
        public static void giaiptbac2_complex()
        {
            Complex a = new Complex(1, 0);
            Complex b = new Complex(-3, 2);
            Complex c = new Complex(-7, 4);
            Complex delta = new Complex();
            delta = b * b - 4 * a * c;
            Complex x1 = new Complex();
            Complex x2 = new Complex();
            x1 = (-b + Complex.Sqrt(delta)) / (2 * a);
            x2 = (-b - Complex.Sqrt(delta)) / (2 * a);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}
