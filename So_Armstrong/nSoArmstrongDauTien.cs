using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Armstrong
{
    internal class nSoArmstrongDauTien
    {
        public static void inDaySo()
        {
            int n;
            do
            {
                Console.Write("Nhap so nguyen n (n>0): a = ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n <= 0);
            int dem = 0;
            int Arm = 0;
            while (dem < n)
            {
                if (KiemTra.check_Armstrong(Arm) == true)
                {
                    Console.Write(Arm + " ");
                    dem++;
                }
                Arm++;
            }
        }
    }
}
