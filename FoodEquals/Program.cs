using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            Food banana = new Food("banana");
            Food banana2 = new Food("banana");
            Food chcolate = new Food("chocolate");

            //svar array = Rotate();
            //Console.WriteLine(banana);
            //Console.WriteLine(banana2);
            //Console.WriteLine(string.Join(",", array));
            Console.WriteLine(banana.Equals(chcolate));
            Console.WriteLine(banana.Equals(banana2));

            //string a = Console.ReadLine();

            //var d = a.ToLower().Substring(0, 1).Equals("c") ? "4" : a; //cde

            //string b = Console.ReadLine();

            //var result = 0;

            //int[] letterCounts = new int[26];

            //foreach (char c in a)
            //{
            //    letterCounts[c - 'a']++;
            //}

            //foreach (char c in b)
            //{
            //    letterCounts[c - 'a']--;
            //}

            //Console.WriteLine(letterCounts.Sum(x => Math.Abs(x)));

            //Console.WriteLine(result);
            //string[] magazine = {"give", "me", "one", "grand", "today", "night"};
            //string[] note = {"give", "one", "grand", "today"};

            //string[] magazine = { "two", "times", "three", "is", "not", "four" };
            //string[] note = { "two", "times", "two", "is", "four" };

            //Array.Sort(magazine);
            //Array.Sort(note);
            //var fred = Rotate();
            //var magazineList = new ArrayList(magazine);
            //List<string> magazineList = magazine.ToList();
            //foreach (string word in note)
            //{
            //    if (magazine.Contains(word))
            //    {
            //        magazineList.Add(word);
            //    }

            //    //break;
            //    //Console.WriteLine("No");
            //}
            //var items = magazine.Except(note);

            //foreach (var item in items)
            //{
            //magazineList.Remove(item);
            //}

            //var length = magazineList;
            //(!note.Intersect(array).Any()
            //Console.WriteLine(note.ToArray().SequenceEqual(magazineList.ToArray()) ? "Yes" : "No");


            //int n = Convert.ToInt32(Console.ReadLine());

            //for (int nItr = 0; nItr < n; nItr++)
            //{
            //    string[] ab = Console.ReadLine().Split(' ');

            //    long a = Convert.ToInt64(ab[0]);

            //    long b = Convert.ToInt64(ab[1]);

            //    long result = andProduct(a, b);

            //    Console.WriteLine(result);
            //}
            int[] arr = { 256741038, 623958417, 467905213, 714532089, 938071625 };
            //plusMinus(arr);
            miniMaxSum(arr);
            Console.ReadLine();
            
        }

        public static int[] andProduct()
        {
            //long a1 = 12;
            //long b1 = 15;

            //List<Range> array = Enumerable.Range(Convert.ToInt32(a), Convert.ToInt32(b)).ToList();
            //var longs = new ArrayList
            //{
            //    Capacity = array.Length
            //};
            // This will track the lowest number found
            //int lowestFound = int.MaxValue;
            //foreach (var num in array)
            //{
            //    //longs.Add(long.Parse(num.ToString()));
            //}
            string[] tickets = { "243578466820230452", "9095676626", "86264", "1179802626578214208812327065", "50128226777149382410171", "345116" };//, "129300455", "123456879"};
            int[] A = {5,6,7};
            int[] B = {3,6,10};
            var score = new int[2];
            for (int index = 0; index < A.Length; index++)
            {
                if (A[index] > B[index])
                {
                   score[1] += 1;
                }
                else if(B[index] > A[index])
                {
                    score[2] += 1;
                }

            }
            //char[] array = new char[tickets.Length];
            //var matches = new List<int>();
            //var matchCount = 0;
            //var i = 0;
            //foreach (var c in tickets)
            //{
            //    var bob = c.ToCharArray();
            //    foreach (var item in bob)
            //    {
            //        i++;
            //        var matchCount = numbers.Contains(int.Parse(item.ToString()));
            //    }
            //}
           

    
            //var array = tickets[0].Intersect(tickets[1]);
            
                //foreach (var c in item.ToCharArray())
                //{
                //    if(numbers.Contains(int.Parse(c.ToString())))
                //        matches.Add(long.Parse(item));
                //}

                //foreach (var match in array)
                //{
                    //matches.Add(long.Parse(item));
                //}

            //}
            return score;
            
            //for (int i = 0; i < 32; i++)
            //{
            //    long count = i;
            //    for (long j = a; j <= b; j++)
            //    {
            //        if ((j & (1 << i)) == 0)
            //        {
            //            count = 0;
            //            break;
            //        }


            //    }
            //    if (count != 0)
            //        ans = ans + (long)Math.Pow(2, count);
            //}
            //return ans;

            //Console.WriteLine(array.Min());
            //array.Sort();

            //return l;
        }

        public static int Rotate()
        {

            //int[] a = {1, 2, 4, 3};
            int[] rotate = {0, 2};
            //int[] a = Enumerable.Range(1, 5 -1).Where( r => r % 2 != 0).ToArray(); //1, 2, 3, 4, 5 };
            string s = "acapmmmmp";
            //var oddNumbers = a.Where(num => num % 2 == 0).ToArray();

           
            //return a;
            //var d = rotate.Length;

            //d %= a.Length;
            //int left = d < 0 ? -d : a.Length -1 + d;
            //for (int i = 0; i < rotate.Length; i++)
            //{
            //    var temp = a[0];
            //    Array.Copy(a, 1, a, 0, a.Length - 1);
            //    a[a.Length - 1] = temp;
            //}
            //return a;

            string reversedString = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reversedString += s[i];
            }

            if (s == reversedString)
            {

            }

            return reversedString.Length;
            //int maxValue = a.Max();
            //int maxIndex = rotate.ToList().IndexOf(maxValue);

            //return maxindex
        }

        static string matchBrackets(char[] chars)
        {
            Stack s = new Stack();
            foreach (char c in chars)
            {
                if (c == '{') s.Push('}');
                else if (c == '(') s.Push(')');
                else if (c == '[') s.Push(']');
                else
                {
                    if (s.Count == 0 || c != (char) s.Peek())
                        return "NO";
                    s.Pop();
                }
            }

            return s.Count == 0 ? "YES" : "NO";
        }

        static int diagonalDifference(int[][] a)
        {

            int row = 0;
            int column = a[0].Length - 1;
            int solution = 0;
            for (int index = 0; index < a.Length; index++)
            {
                solution -= a[row][row] - a[row++][column--];
            }
            return Math.Abs(solution);
        }

        static void plusMinus(int[] arr)
        {
            //int[] p = new int[arr.Length];
            var p = arr.Count(t => t > 0);
            double result = (double)p / arr.Length;
            Console.Write(result + "\n");

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 0)
                    Console.Write(arr[i] + " ");
            }

            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    Console.Write(arr[i] % arr.Length);
            }

        }

        static void staircase(int n)
        {
            //int N = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
                Console.WriteLine(new string('#', i + 1).PadLeft(n, ' '));
        }

        static void miniMaxSum(int[] arr)
        {
            int[] target = new int[arr.Length];
            Array.Copy(arr, target, arr.Length);

            Array.Resize(ref arr, arr.Length -1);
            target = target.Skip(1).ToArray(); //target.Take(target.Count() - 1).ToArray();
            long n = long.Parse(arr.Sum().ToString());
            long t = target.Sum(r => Convert.ToInt64(r));
            Console.WriteLine(n + " " + t);
        }

        static int birthdayCakeCandles(int[] ar)
        {
            var max = ar.Max();
            return ar.Count(c => c >= max);

        }
    }
}
