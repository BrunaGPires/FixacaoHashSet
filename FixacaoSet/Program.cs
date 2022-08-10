using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixacaoSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Class A
            HashSet<int> A = new HashSet<int>();
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student number: ");
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                A.Add(student);
            }

            //Class B
            HashSet<int> B = new HashSet<int>();
            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student number: ");
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                B.Add(student);
            }

            //Class C
            HashSet<int> C = new HashSet<int>();
            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student number: ");
            for (int i = 0; i < n; i++)
            {
                int student = int.Parse(Console.ReadLine());
                C.Add(student);
            }

            HashSet<int> all = new HashSet<int>(A);
            all.UnionWith(B);
            all.UnionWith(C);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}
