using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Armstrong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arm;
            do
            {
                Console.Write("Nhap so nguyen a (a>=0): a = ");
                arm = Convert.ToInt32(Console.ReadLine());
            } while (arm < 0);
            Console.WriteLine("\na = " + arm + " có phải số Armstrong không?\t" + KiemTra.check_Armstrong(arm));

            // in n số Armstrong đầu tiên
            nSoArmstrongDauTien.inDaySo();

            // in các số Armstrong từ a đến b
            int a, b;
            do
            {
                Console.Write("Nhập số bắt đầu (a>=0) : a = ");
                a = Convert.ToInt32(Console.ReadLine());
            }while (a < 0);


            do
            {
                Console.Write("Nhập số bắt đầu (b>=a) : b = ");
                b = Convert.ToInt32(Console.ReadLine());
            } while (b < a);

            inDayArmstrongTrongDoanAB.timKiem(a, b);
        }
    }
}
