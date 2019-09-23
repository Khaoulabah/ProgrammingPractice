﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Practice1
{
   public class TwoSumSolution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] solution = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        solution[0] = i;
                        solution[1] = j;
                        return solution;
                    }
                }
            }
            return solution;
        }
    }
}
