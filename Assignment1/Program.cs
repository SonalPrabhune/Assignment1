// See https://aka.ms/new-console-template for more information
int question = 0;
Console.WriteLine("Select a number from 1 to 6 to run the questions");
int.TryParse(Console.ReadLine(), out question);
if (question > 0 && question <= 6)
{
    switch (question) {
        //Question 1:
        //Professor Agrawal receives an array of integer points sorted in ascending order, 
        //the task is to find the initial and final index of a given target point’s value.
        //If the target point value is not found in the array of integers, return [-1, -1]
        //The professor had to leave for a conference at short notice and asked you to 
        //complete the task for him.He instructed you to limit the time complexity to O(n).
        case 1:
            Console.WriteLine("Running Question 1");
            int n = 0;            
            int target, temp;

            Console.WriteLine("Enter a size of array");
            int.TryParse(Console.ReadLine(), out n);
            if (n == 0)
            {
                throw new Exception("Invalid size of Array");
            }
            int[] marks = new int[n];
            Console.WriteLine("Enter " + n + " elements");            
            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out temp);
                marks[i] = temp;
            }
            if (marks.Length == 0)
            {
                throw new Exception("Invalid Array");
            }
            Array.Sort(marks);
            Console.WriteLine("Sorted array of marks is...");
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
            Console.WriteLine("Enter a target value to search");
            int.TryParse(Console.ReadLine(), out target);

            Console.WriteLine("Target found at location...");
            var result = Assignment1.Questions.TargetRange(marks, target);
            foreach (var value in result)
            {
                Console.WriteLine(value);
            }
            break;
            //The "FOR" statement has three parts that control how the statement works. 
            //The first part is the initializer (int i=0), 
            //The second part is the condition (i<n),
            //The third part is the iterator (i++).

        //Question 2:
        //Rocky is not aware of the inbuilt functions to split and reverse a string.
        //He is given a string and he needs to reverse the order of characters in each word 
        //within a sentence while still preserving whitespace and initial word order. 
        //He is not allowed to use any predefined split and reverse function.He is requesting 
        //you to complete the method for him.
        case 2:
            Console.WriteLine("Running Question 2");
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            if (s?.Length == 0)
            {
                Console.WriteLine("Invalid String");
                return;
            }
            else
            {
                Console.WriteLine("Reversed string is ...");
                Console.WriteLine(Assignment1.Questions.StringReverse(s));
            }
            break;

        //Question 3:
        //Professor Stablein is given a sorted integer array. He needs to make the array elements
        //distinct by increasing each value as needed, while minimizing the array sum.
        //Professor Stablein thought this was an interesting exercise that the students might
        //enjoy completing. Your job is to complete the method to print the minimum possible sum as output.
        case 3:
            Console.WriteLine("Running Question 3");
            int arrSize = 0, tempVal, output;

            Console.WriteLine("Enter a size of array");
            int.TryParse(Console.ReadLine(), out arrSize);
            if (arrSize == 0)
            {
                throw new Exception("Invalid size of Array");
            }
            int[] arr = new int[arrSize];
            Console.WriteLine("Enter " + arrSize + " elements");
            for (int i = 0; i < arrSize; i++)
            {
                int.TryParse(Console.ReadLine(), out tempVal);
                arr[i] = tempVal;
            }
            if (arr.Length == 0)
            {
                throw new Exception("Invalid Array");
            }
            Array.Sort(arr);
            Console.WriteLine("Sorted array of marks is...");
            foreach (int el in arr)
            {
                Console.WriteLine(el);
            }

            Console.WriteLine("Min Sum of array elements is ...");
            output = Assignment1.Questions.MinSum(arr);
            Console.WriteLine(output);
            break;

        //Question 4:
        //You are given a string and your task is to sort the given string
        //in decreasing order of frequency of occurrence of each character.
        case 4:
            Console.WriteLine("Running Question 4");
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            if (str?.Length == 0)
            {
                Console.WriteLine("Invalid String");
                return;
            }
            else
            {
                Console.WriteLine("Sorted string by decreasing order of frequency of each character is ...");
                Console.WriteLine(Assignment1.Questions.FreqSort(str));
            }
            break;

        //Question 5:
        //Rocky the Bull is new to programming and is having trouble understanding the importance of time complexity.
        //Professor Agrawal assigned you the job of explaining time complexity to Rocky with the example below.
        //Given two arrays, write a function to compute their intersection.
        case 5:
            Console.WriteLine("Running Question 5");
            int[] nums1;
            int[] nums2;
            int num1Size, num2Size, tempNum;

            Console.WriteLine("Enter a size of first array");
            int.TryParse(Console.ReadLine(), out num1Size);
            if (num1Size == 0)
            {
                throw new Exception("Invalid size of first array");
            }
            nums1 = new int[num1Size];
            Console.WriteLine("Enter " + num1Size + " elements for first array");
            for (int i = 0; i < num1Size; i++)
            {
                int.TryParse(Console.ReadLine(), out tempNum);
                nums1[i] = tempNum;
            }
            if (nums1.Length == 0)
            {
                throw new Exception("Invalid first array");
            }

            Console.WriteLine("Enter a size of second array");
            int.TryParse(Console.ReadLine(), out num2Size);
            if (num2Size == 0)
            {
                throw new Exception("Invalid size of second array");
            }
            nums2 = new int[num2Size];
            Console.WriteLine("Enter " + num2Size + " elements for second array");
            for (int i = 0; i < num2Size; i++)
            {
                int.TryParse(Console.ReadLine(), out tempNum);
                nums2[i] = tempNum;
            }
            if (nums2.Length == 0)
            {
                throw new Exception("Invalid second array");
            }
            
            var intersect1Result = Assignment1.Questions.Intersect1(nums1, nums2);
            Console.WriteLine("Solution is:");
            foreach (var res in intersect1Result)
            {
                Console.WriteLine(res);
            }

            break;

        //Question 6:
        //You are given an array of characters and an integer k, and are required to find out whether
        //there are two distinct indices i and j in the array such that arr[i] = arr[j] and the
        //absolute difference between i and j is at most k.
        case 6:
            Console.WriteLine("Running Question 6");
            int inputSize;
            char val;
            int k;

            Console.WriteLine("Enter a size of char array");
            int.TryParse(Console.ReadLine(), out inputSize);
            if (inputSize == 0)
            {
                throw new Exception("Invalid size of Array");
            }
            char[] input = new char[inputSize];
            Console.WriteLine("Enter " + inputSize + " characters");
            for (int i = 0; i < inputSize; i++)
            {
                char.TryParse(Console.ReadLine(), out val);
                input[i] = val;
            }
            if (input.Length == 0)
            {
                throw new Exception("Invalid Array");
            }

            Console.WriteLine("Enter the absolute distance between duplicate elements");
            int.TryParse(Console.ReadLine(), out k);
            if (k == 0)
            {
                throw new Exception("Invalid distance of 0");
            }
            else if (k >= input.Length)
            {
                throw new Exception("Invalid distance of spanning more than the array length");
            }

            Console.WriteLine("Output:");    
            Console.WriteLine(Assignment1.Questions.ContainsDuplicate(input, k));
            break;
    }
}
