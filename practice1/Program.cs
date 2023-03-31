// using System;
// using System.Collections.Generic;
// using System.Linq;

// namespace project
// {
//     class Program
//     {
//         static void Main()
//         {
//             Задание 1
//             String j = "ab";
//             String s = "aabbccd";
//             int count = 0;
//             foreach (char character in s)
//             {
//                 if (j.Contains(character))
//                 {
//                     count++;
//                 }
//             }
//             Console.WriteLine(count);



//             Задание 2
//             int[] candidates = {10, 1, 2, 7, 6, 1, 5};
//             int target = 8;

//             List<List<int>> results = CombinationSum(candidates, target);   

//             foreach (List<int> result in results)  
//             {
//                 Console.WriteLine(string.Join(", ", result));
//             }
//         }

//         static List<List<int>> CombinationSum(int[] candidates, int target)
//         {
//             List<List<int>> results = new List<List<int>>();
//             Array.Sort(candidates);
//             int count = 0;
//             while (count < candidates.Length) 
//             {
//                 int current = candidates[count];
//                 if (current > target) break;
//                 if (current == target) {
//                     results.Add(new List<int> {current});
//                     break;
//                 }
//                 var subResults = CombinationSum(candidates.Skip(count + 1).ToArray(), target - current);
//                 foreach (var subResult in subResults) {
//                     subResult.Insert(0, current);
//                     results.Add(subResult);
//                 }
//                 while (count < candidates.Length && candidates[count] == current)
//                 {
//                     count++;
//                 }
//             }
//             return results;



//Задание 3

//         int[] nums = {1,1,1,3,3,4,3,2,4,2};

//         Console.WriteLine(SameFun(nums));
//         }

//         static bool SameFun(int[] nums)
//         {
//             if (nums.Distinct().Count() != nums.Length)
//             {
//                 return true;
//             }
//             else
//             {
//                 return false;
//             }
//         }
//     }
// }