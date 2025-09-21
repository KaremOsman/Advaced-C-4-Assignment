using System.Collections;

namespace Advaced_C__4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q_1
            //Given an array of integers, count the frequency of each element using a hash table.


            //solution 

            //int count = 0;
            //int[] nums = { 1, 2, 3, 9, 5, 2, 4, 4, 5, 5, 6, 7, 4, 2, 9, 8 };
            //Hashtable hashtable = new Hashtable();
            //foreach (int i in nums)
            //{ 
            //    if (hashtable.ContainsKey(i))
            //    {
            //        hashtable[i] = (int)hashtable[i] + 1 ;
            //        count++;// count of duplicate elements
            //    }
            //    else
            //    {

            //        hashtable.Add(i, 1);
            //    }
            //}
            //foreach (DictionaryEntry entry in hashtable)
            //{
            //   Console.WriteLine("Element " + entry.Key + " is duplicated " + entry.Value + " times");
            //}
            //Console.WriteLine("=======================================");
            //Console.WriteLine("Number of duplicate elements: " + count); 
            #endregion

            #region Q_2
            //‎You have a hashtable where its values are integers, find the key associated with the highest value.

            //solution

            //Hashtable Table = new Hashtable()
            //{
            //    ["Math"] = 90,
            //    ["Science"] = 85,
            //    ["English"] = 88,
            //    ["History"] = 92
            //};
            //int MaxValue = 0;
            //foreach (DictionaryEntry item in Table)
            //{
            //    if(item.Value is not null && (int)item.Value > MaxValue) MaxValue = (int)item.Value;
            //};
            //Console.WriteLine($"highest Degree = { MaxValue}");
            //foreach (DictionaryEntry item in Table)
            //{
            //    if (item.Value is not null && (int)item.Value == MaxValue)
            //        Console.WriteLine($"Subject with highest Degree: {item.Key}");
            //}
            ;

            #endregion

            #region Q_3
            //‎You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue
            //Note: if the targetValue not found print(“Key not found”)


            // solution

            //Hashtable Frutes = new Hashtable()
            //{
            //    ["key1"] = "apple",
            //    ["key2"] = "banana",
            //    ["key3"] = "orange",
            //    ["key4"] = "banana",
            //    ["key5"] = "apple",
            //};
            // string TargetValue;
            // string key = string.Empty ;
            //do
            //{
            //    Console.WriteLine("Enter Targer Value");
            //    TargetValue  = Console.ReadLine();

            //}while (string.IsNullOrEmpty(TargetValue));
            //TargetValue = TargetValue.ToLower();
            //foreach (DictionaryEntry frout in Frutes)
            //{
            //    if (TargetValue != null && TargetValue == frout.Value as string)
            //    {
            //        key = frout.Key as string ?? "";
            //        Console.WriteLine($"TargetValue Key is " + frout.Key);
            //    }
            //}
            //if (string.IsNullOrEmpty(key))
            //    Console.WriteLine("Key Not Found");

            #endregion

            #region Q_4
            //


            //solution


            #endregion

            #region Q_5
            //Given an array of integers, check if the array contains any duplicates.


            //solutions

            //int[] nums = {1, 3, 5, 1, 7, 9, 3, 5, 1, 3, 5, 7, 9 };

            #region solution 1
            //for (int i = 0; i < nums.Length; i++) 
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (nums[i] == nums[j])
            //        {
            //            Console.WriteLine("Array Has Duplicated Numbers"); ;
            //            return;
            //        }
            //    }
            //} 
            #endregion

            #region solution 2
            //Hashtable numbers = new Hashtable();

            //foreach (int i in nums) 
            //{
            //    if (numbers.ContainsKey(i))
            //    { Console.WriteLine("Array Has Duplicated numbers");
            //        return;
            //    }
            //    else
            //    {
            //        numbers.Add(i, 1);
            //    };
            //};

            #endregion

            #endregion

            #region Q_6
            //Implement a SortedDictionary that stores student IDs (int) and their names (string).
            //Perform operations like adding, removing, and retrieving student names.


            // solution

            //SortedDictionary<int, string> students = new SortedDictionary<int, string>()
            //{
            //    [1001] = "Alice",
            //    [1003] = "Bob",
            //    [1002] = "Charlie",
            //    [1005] = "David",
            //    [1004] = "Eve"
            //};
            //// 1. Add a new student with ID 1006 and name "Frank".
            //students.Add(1006, "Frank");
            //// 2. Update the name of the student with ID 1004 to "Eve".
            //students.Remove(1004);
            //// 3. retrieve and print the student Names
            //foreach (var student in students)
            //{
            //    Console.WriteLine($"Name: {student.Value}");
            //};

            #endregion

            #region Q_7
            //7.Create an employee directory where employee IDs (int) are keys and employee names (string) are values.
            //Use a SortedList to manage and retrieve employees in order of their IDs.

            //solution

            //Dictionary<int, string> employees = new Dictionary<int, string>()
            //{
            //    [102] = "Jane",
            //    [101] = "John",
            //    [105] = "Bob",
            //    [104] = "Alice",
            //    [103] = "Doe"
            //};
            //SortedList<int, string> sortedEmployees = new SortedList<int, string>(employees);
            //foreach (var item in sortedEmployees)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



        }
    }
}
