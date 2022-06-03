using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public static class Questions
    {
        //Question 1 - find the initial and final index of a given target point’s value.
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

        //Question 2 - Create your own split and reverse function.
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

        //Question 3 - make the array elements distinct by increasing each value as needed, while minimizing the array sum. 
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
        
        
        //Question 3: Rohit solution//
                  /*   public static int minSum (int[] arr)
                        {
                        int sum = arr[0], prev = arr[0], n = arr.length;

                for (int i = 1; i < n; i++)
                {
                    if (arr[i] <= prev)
                    {
                        prev = prev + 1;
                        sum = sum + prev;
                    }
                    else
                    {
                        sum = sum + arr[i];
                        prev = arr[i];
                    }
                }

                return sum;
            } */

        //Question 4 - sort the given string in decreasing order of frequency of occurrence of each character.
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

        //Question 5 - Given two arrays, write a function to compute their intersection.
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
// Question 5  Rohit Solution //
        /*       Console.WriteLine("Running Question 5");
            {
                int[] array1 = new int[] { 2, 5, 5, 2 }; //array1 and array2 is the input,we are declaring
                int[] array2 = new int[] { 5, 5 };
            int[] result = Commonelements(array1, array);//method declaration and passing the inputs
            Console.WriteLine(result);
                    Console.WriteLine("Running Question 5");

                int[] result = array1.Where(x => array2.Contains(x)).ToArray();

                Console.Write(string.Join(',', result));

            }*/
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

//Question 6: Rohit Solution //
// public bool ContainsDuplicate(char[] arr, int k) //
/*{
      Dictionary<char,char> memo = new Dictionary<char, char>();
      for (int i = 0; i < arr.length; i++)
      {
        if (memo.ContainsKey(nums[i]))
        {
          if (i - memo[nums[i]] <= k)
          {
            return true;
          }
          else
          { 
            memo[nums[i]] = i;
          }
        }
        else
        {
          memo.Add(nums[i], i);
        }
      }
      return false;
    }
}*/
