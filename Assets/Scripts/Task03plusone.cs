using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task03plusone : MonoBehaviour
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            int count = 0;
            int major = 0;

            foreach (int num in nums)
            {
                if (count == 0)
                {
                    major = num;
                }
                count += (num == major) ? 1 : -1;
            }

            return major;
        }
    }
}
