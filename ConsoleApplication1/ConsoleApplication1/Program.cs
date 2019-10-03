using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            InPutValues(arr);
        }

        public static void InPutValues(int[] Arr)
        {
            for(int i = 0; i < Arr.Length; i++)
            {
                Console.Write("A[{" + i + "}] = ");
                string str = Console.ReadLine();
                Arr[i] = int.Parse(str);
            }
        }

        public static bool IsContain5(int[] Arr)
        {
            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5)
                    return true;
            }
            return false;
        }

        public static bool IsContain5Or6(int[] Arr)
        {
            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5 || Arr[i] == 6)
                    return true;
            }
            return false;
        }

        public static bool IsContain5And6(int[] Arr)
        {
            for (int i = 0; i < Arr.Length; i++)
            {
                for (int j = 0; j < Arr.Length; j++)
                {
                    if (Arr[i] == 5 && Arr[j] == 6)
                        return true;
                }
            }
            return false;
        }

        public static int Cout5(int[] Arr)
        {
            int cout = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5)
                    cout++;
            }
            return cout;
        }

        public static int Cout5Or6(int[] Arr)
        {
            int cout = 0;
            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] == 5 || Arr[i] == 6)
                    cout++;
            }
            return cout;
        }

        public static int SumArr(int[] Arr)
        {
            int sum = 0;
            for(int i = 0; i < Arr.Length; i++)
            {
                sum = sum + Arr[i];
            }
            return sum;
        }

        public static int Cout5And6(int[] Arr)
        {
            int cout = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                for(int j = 0; j < Arr.Length; j++)
                {
                    if (Arr[i] == 5 && Arr[j] == 6)
                        cout++;
                }
            }
            return cout;
        }
    }
}
