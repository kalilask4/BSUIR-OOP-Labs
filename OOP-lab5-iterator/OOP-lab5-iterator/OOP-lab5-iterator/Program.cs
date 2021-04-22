using System;

namespace OOP_lab5_iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            MemberName memberNames = new MemberName();

            foreach (string s in memberNames.MyMemberName(1,5))
            {
                Console.WriteLine(s + " ");
            }

            Console.ReadKey();
        }
    }
}
