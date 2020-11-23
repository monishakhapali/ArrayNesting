using System;
using System.Collections.Generic;

namespace NestingofArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nums = { 5, 4, 0, 3, 1, 6, 2 };
            ArrayNesting(nums);

        }
        public static int ArrayNesting(int[] nums)
        {
            HashSet<int> hset = new HashSet<int>();
            int maxcount = 0;
            for(int i=0;i<nums.Length;i++)
            {
                if(!hset.Contains(i))
                {
                    int count = 0;
                    while(!hset.Contains(i))
                    {
                        hset.Add(i);
                        i = nums[i];
                        count++;
                    }
                    if(count> maxcount)
                    {
                        maxcount = count;
                    }
                }
            }
            return maxcount;
        }
    }
}
