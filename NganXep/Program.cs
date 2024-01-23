using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NganXep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int socoso; // số của cơ số
            int coso;
            int cosodoi; // cơ số muốn đổi

            Console.Write("Nhap so truoc khi doi: ");
            socoso = int.Parse(Console.ReadLine());
            Console.Write("Nhap co so truoc khi doi: ");
            coso = int.Parse(Console.ReadLine());
            Console.Write("Nhap co so muon doi: ");
            cosodoi = int.Parse(Console.ReadLine());

            Stack s = new Stack();
            while (socoso > 0)
            {
                s.Them(socoso % cosodoi);
                socoso = socoso / cosodoi;
            }

            Console.Write($"Bieu dien co so he {cosodoi}: ");
            while (!s.KiemTraRong())
            {
                int n = s.LayPhanTu();

                if (n > 9)
                {
                    Console.Write(DoiCoSoLonHon10(n));
                }
                else
                {
                    Console.Write(n);
                }
            }

            Console.ReadLine();
        }

        static char DoiCoSoLonHon10(int n)
        {
            switch (n)
            {
                case 10:
                    return 'A';
                case 11:
                    return 'B';
                case 12:
                    return 'C';
                case 13:
                    return 'D';
                case 14:
                    return 'E';
                case 15:
                    return 'F';
                default:
                    return (char)('0' + n);
            }
        }
    }
}
