﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 37, 748, 68, 4 };
            int temp = 0;


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if(arr[i] < arr[j])
                    {
                        temp = arr[i];

                        arr[i] = arr[j];

                        arr[j] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0},", arr[i]);
                Console.ReadKey();
            }

        }
    }
}
