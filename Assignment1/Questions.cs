using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class Questions
    {
        //Question 1
        public static List<int> TargetRange(int[] marks, int target)
        {
            List<int> result = new List<int>();
            int j = 0;
            bool found = false;
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] == target)
                {
                    result.Add(i);
                    found = true;
                }
            }
            if (!found)
            {
                result.Add(-1);
            }
            return result;
        }

        //Question 2
        public static string StringReverse(string s)
        {
            StringBuilder sb = new StringBuilder();
            if (s.Length == 1)
            {
                return s;
            }
            var c = s.ToCharArray();
            for (int i = c.Length-1; i >= 0; i--)
            {
                sb.Append(c[i]);
            }

            return sb.ToString();
        }

        //Question 3
        public static int MinSum(int[] arr)
        {
            int sum = arr[0];
            if (arr.Length == 1)
            {
                return sum;
            }
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i - 1])
                {
                    arr[i]++;
                }
                sum = sum + arr[i];
            }
            
            return sum;

        }

        //Question 4
        public static string FreqSort(string s)
        {
            StringBuilder sb = new StringBuilder();
            if (s.Length == 1)
            {
                return s;
            }
            var ch = s.ToCharArray();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in ch)
            {
                if (!dict.ContainsKey(c))
                {
                    dict[c] = 1;
                }
                else
                {
                    dict[c]++;
                }
            }
            
            var sortedDict = dict.OrderByDescending(val => val.Value).ToDictionary(x => x.Key, x => x.Value); 
            foreach (var val in sortedDict)
            {
                for(int i =0; i< val.Value; i++)
                {
                    sb.Append(val.Key);
                }
            }
            return sb.ToString();
        }

        //Question 5
        public static List<int> Intersect1(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            
            for (int i = 0; i < nums1.Length; i++)
            {
                if (nums2.Contains(nums1[i]))
                {
                    result.Add(nums1[i]);
                }
            }
            return result;
        }


        //Question 6
        public static bool ContainsDuplicate(char[] arr, int k)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            int distance = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                {
                    dict.Add(arr[i], distance);
                }
                else
                {
                    dict[arr[i]] = Math.Abs(distance-i);
                }
            }
            foreach(var dist in dict.Values)
            {
                if (dist < k)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
