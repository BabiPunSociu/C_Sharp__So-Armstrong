using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Armstrong
{
    internal class inDayArmstrongTrongDoanAB
    {
        
        public static void timKiem(int a, int b)
        {
            Console.Write("Các số Armstrong từ " + a +" đến " + b +" là: ");

            bool check_empty = true;
            for(int i = a; i<=b; i++)
            {
                if (KiemTra.check_Armstrong(i) == true)
                {
                    Console.Write(i + " ");
                    check_empty = false;
                }
            }
            if (check_empty == true) Console.WriteLine("Không có số Armstrong nào ...");
        }
    }
}
