using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main()
        {
            WriteFriendsToFile();
        }

        static void WriteFriendsToFile()
        {
            string[] friends = { "\n Alice", "\n Bob", "\n Charlie", "\n David", "\n Eve" };
            File.WriteAllLines("friends.txt", friends);
            Console.WriteLine("Friends' names written to file.");
        }
    }
}
