using System;
using System.Collections.Generic;

namespace Delegate
{
    internal class Program
    {
        //------------------------------------------------------------
        //Task1

        //static void Main(string[] args)
        //{
        //    Action action = PrintSomething;
        //    action();
        //}
        //static void PrintSomething()
        //{
        //    Console.WriteLine("Write");
        //}

        //-------------------------------------------------------------
        //Task2

        //static void Main(string[] args)
        //{
        //    Func<int,int> func = Power;
        //    int.TryParse(Console.ReadLine(), out int number);
        //    Console.WriteLine(func(number));
        //}
        //static int Power(int number)
        //{
        //    return number * number;
        //}

        //-------------------------------------------------------------
        //Task3

        //static void Main(string[] args)
        //{
        //    Predicate<int> pre = new Predicate<int>(Even);
        //    List<int> list = new List<int>() { 1, 2, 3, 4 };
        //    for(int i=0; i<list.Count; i++)
        //    {
        //        if (Even(list[i]))
        //        {
        //            Console.WriteLine(list[i]);
        //        }
        //    }
        //}
        //static bool Even(int number)
        //{
        //    return number % 2 == 0;
        //}

        //-------------------------------------------------------------
        //Task4

        //static void Main(string[] args)
        //{
        //    Action<int> action = new Action<int>(Increment);
        //    List<int> list = new List<int>() { 1, 2, 3, 4 };
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        action(list[i]);
        //    }
        //}
        //static void Increment(int number)
        //{
        //    Console.WriteLine(number+1);
        //}


        //-------------------------------------------------------------
        //Task5

        //static void Main(string[] args)
        //{
        //    Action<int> action1 = new Action<int>(Increment);
        //    Action<int> action2 = new Action<int>(Increment);
        //    Action<int> action3 = new Action<int>(Increment);
        //    List<Action<int>> list = new List<Action<int>>();
        //    list.Add(action1);
        //    list.Add(action2);
        //    list.Add(action3);
        //}
        //static void Increment(int number)
        //{
        //    Console.WriteLine(number + 1);
        //}
        //static void AddMr(string name)
        //{
        //    Console.WriteLine($"Mr {name}");
        //}
        //static void AddSalary(int number)
        //{
        //    Console.WriteLine($"New salary: {number + 2000}");
        //}




        //-------------------------------------------------------------
        //Task6

        //static void Main(string[] args)
        //{
        //    List<string> list = new List<string>() { "sdsff","asifhfsdfsdf", "sad", "asdf","sd", "fsdhfasdhfgahsfadfasgfashdhf"};
        //    Predicate<string> pre = new Predicate<string>(StringLen);
        //    for(int i=0;i<list.Count;i++)
        //    {
        //        if (pre(list[i]))
        //        {
        //            Console.WriteLine(list[i]);
        //        }
        //    }
        //}
        //static bool StringLen(string str)
        //{ 
        //    return str.Length >= 5; 
        //}


        //-------------------------------------------------------------
        //-------------------------------------------------------------
        //-------------------------------------------------------------
    }
}
