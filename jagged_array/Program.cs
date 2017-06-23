using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] =new int[]{0,1,2,3,4 };
            arr[1] = new int[] { 5,6,7,8 };
            arr[2] = new int[] { 9,5,1};
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write("my array index ({0})",i);
                for(int j =0;j<arr[i].Length;j++)
                {
                    Console.Write("{0}", arr[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
