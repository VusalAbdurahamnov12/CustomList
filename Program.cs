using C_Generic_types_Collections.Models;
using System;
using System.Collections.Generic;

namespace C_Generic_types_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> _list = new CustomList<int>();
            _list.Add(1);
            _list.Add(2);
            _list.Add(3);
            _list.Add(4);
            _list.Add(5);
            _list.Add(6);
            _list.Add(7);
            _list.Add(8);
            _list.Add(9);
            _list.Add(10);
            _list.Add(11);
            Console.WriteLine(_list.Exist(52));
            Console.WriteLine(_list.Reverse());
            Console.WriteLine(_list.Resize(10));
            Console.WriteLine(_list.Remove());
        }
    }
}
