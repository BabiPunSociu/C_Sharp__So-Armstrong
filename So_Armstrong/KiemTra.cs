using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace So_Armstrong
{
    internal class KiemTra
    {
        public static int soChuSo(int a)
        {
            int result = 0;
            while(a > 0)
            {
                a /= 10;
                result++;
            };
            return result;
        }
        public static bool check_Armstrong(int a)
        {
            int a_copy = a;
            int n = soChuSo(a); // số chữ số của a
            double sum = 0;
            
            while (a > 0)
            {
                sum += Math.Pow(a % 10, n);
                a /= 10;
            };
            return (sum == a_copy)? true:false;
        }
    }
}
