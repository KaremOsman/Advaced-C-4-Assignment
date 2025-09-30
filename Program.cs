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
            //You have a hashtable where its values are integers, find the key associated with the highest value.

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
            //You have a hashtable , the  user will enter targetValue find all keys that associated with a specific targetValue
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
            // Given an array of strings, group anagrams together.


            //solution

            //string[] anagrams = { "listen", "silent", "enlist", "inlets", "google", "gogole", "evil", "vile", "live" };

            //var Result = anagrams.GroupBy(word => String.Concat(word.OrderBy(c => c)))
            //                     .Select(G => G);

            //foreach (var group in Result)
            //         Console.WriteLine("Anagram Group: " + string.Join(", ", group));


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

            #region Q_8
            //‎Given an array of integers from 1 to N with some numbers missing, find the missing numbers.

            //solution

            //int[] arr = { 1, 2, 4, 5, 7, 8, 9, 12, 15 };

            //List<int> list = arr.ToList();
            //List<int> Missed = new List<int>();
            //int N = 15;
            //for (int i = 1; i < N ; i++)
            //{
            //    if (!(list.Contains(i))) Missed.Add(i);

            //}
            //Console.Write($"Missed =");
            //foreach (var i in Missed)
            //    Console.Write(" "+i);

            #endregion

            #region Q_9
            //‎You  have a list of integers with possible duplicates, create a HashSet that contains only unique values.

            //solution

            //List<int> list = new List<int>() { 1, 2, 3, 3, 4, 6, 5, 4, 5, 7, 3 };

            //HashSet<int> set = new HashSet<int>(list);

            //foreach (int i in set) Console.WriteLine(i);

            #endregion

            #region Q_10
            //You have a hashtable with unique values, create a new hashtable where the keys and values are swapped.


            //solution

            // Hashtable table = new Hashtable()
            // {
            //     { 1, "karem"},
            //     {2, "Osman" },
            //     {3, "kamon" }
            // };
            // Hashtable table2 = new Hashtable();
            //foreach (DictionaryEntry i in table) 
            // { 
            //     if (i.Value != null)
            //     table2.Add(i.Value , i.Key);
            // };
            // foreach (DictionaryEntry item in table2)
            //         Console.WriteLine(item);              

            #endregion

            #region Q_11
            //‎Find the union of two sets, returning the unique elements from both sets.


            // solution

            //HashSet<int> set01 = [1, 4, 6, 2, 3, 6];
            //HashSet<int> set02 = [5, 6, 7, 3, 2, 1];
            //Console.Write("\n The Union Of Set01 and Set02 is :");
            //set01.IntersectWith(set02);
            //foreach (var item in set01)
            //    Console.Write(" " + item);// 1 6 2 3
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.Write("unique elements from both sets :");
            //set01.UnionWith(set02);
            //foreach (var item in set01)
            //    Console.Write(" " + item); //1 4 6 2 3 5 7
            //Console.WriteLine();
            //Console.WriteLine();
            //set02.SymmetricExceptWith(set01);
            //foreach (var item in set02)
            //    Console.Write(" " + item); // 5 7 4 
            //Console.WriteLine();


            #endregion

            #region Q_12
            //‎You have a dictionary with string keys, the user will enter targetChar , count how many keys start with this targetChar.

            //solution

            //Dictionary<string, int> Fruites = new Dictionary<string, int>()
            //{
            //    {"apple", 1 },
            //    {"animal", 2 },
            //    {"airport", 3}
            //};
            //string? targetChar;
            //int count = 0;
            //do
            //{
            //    Console.WriteLine("Enter char for search");
            //    targetChar = Console.ReadLine();
            //} while (targetChar == string.Empty);


            //string? LowerCh = targetChar?.ToLower() ?? "";

            //foreach (var value in Fruites.Keys)
            //    if (targetChar != null && value.StartsWith(LowerCh))
            //        count++;
            //if (count == 0)
            //    Console.WriteLine($"There is No keys started with targetChar : \" {targetChar} \" ");
            //else
            //    Console.WriteLine($"Total Keys That Start With targetChar :\" {targetChar} \"  are  = {count}");




            #endregion

            #region Q_13
            //‎You have a sorted set , user will enter an integer target, find all elements that is greater than target and add them in list.


            //solution

            //SortedSet<int> Nums = new SortedSet<int>()
            //{
            //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15
            //};
            //List<int> Values = new List<int>();
            //int TargetNumber;

            //do Console.WriteLine("Enter TatgetNumber");
            //while (!(int.TryParse(Console.ReadLine(), out TargetNumber)));

            //foreach (var N in  Nums) 
            //    if (N > TargetNumber)
            //        Values.Add(N);

            //Console.Write($"\n Elements That Grater Than \" {TargetNumber} \" : ");
            //foreach (var item in Values)
            //    Console.Write(" " + item);
            //Console.WriteLine();


            #endregion

            #region Q_14
            //You have a sorted list with integer values, find all the keys associated with even values.


            //solution

            //SortedList sortedList = new SortedList()
            //{
            //    {1,"karem" },
            //    {2, "Osman" },
            //    {3, "Kareman" },
            //    {4,"Nour" },
            //    {5,"john" },
            //    {6,"Rose" }
            //};
            //foreach (int key in sortedList.Keys)
            //{
            //    if(key % 2 == 0)
            //        Console.WriteLine($"{sortedList[key]}");
            //}

            #endregion
        }
    }
}
