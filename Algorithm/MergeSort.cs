﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class MergeSort
    {
        public void mergesort(int[] Array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;
                mergesort(Array, left, mid);
                mergesort(Array, mid + 1, right);
                merge(Array, left, mid, right);
            }
        }

        // merge function performs sort and merge operations
        // for mergesort function
        static void merge(int[] Array, int left, int mid, int right)
        {
            // Create two temporary array to hold split 
            // elements of main array 
            int n1 = mid - left + 1; //no of elements in LeftArray
            int n2 = right - mid;     //no of elements in RightArray    
            int[] LeftArray = new int[n1];
            int[] RightArray = new int[n2];

            for (int i = 0; i < n1; i++)
            {
                LeftArray[i] = Array[left + i];
            }

            for (int i = 0; i < n2; i++)
            {
                RightArray[i] = Array[mid + i + 1];
            }

            // In below section x, y and z represents index number
            // of LeftArray, RightArray and Array respectively
            int x = 0, y = 0, z = left;
            while (x < n1 && y < n2)
            {
                if (LeftArray[x] < RightArray[y])
                {
                    Array[z] = LeftArray[x];
                    x++;
                }
                else
                {
                    Array[z] = RightArray[y];
                    y++;
                }
                z++;
            }

            // Copying the remaining elements of LeftArray
            while (x < n1)
            {
                Array[z] = LeftArray[x];
                x++;
                z++;
            }

            // Copying the remaining elements of RightArray
            while (y < n2)
            {
                Array[z] = RightArray[y];
                y++;
                z++;
            }
        }

        // function to print array
        public void PrintArray(int[] Array)
        {
            int n = Array.Length;
            for (int i = 0; i < n; i++)
                Console.Write(Array[i] + " ");
            Console.Write("\n");

        }

    }
}