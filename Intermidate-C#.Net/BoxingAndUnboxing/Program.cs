using System;
using System.Collections;
using System.Collections.Generic;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            // This would lead to boxing: int -> object
            // And will get performance penalty when boxing/unboxing
            list.Add(1);
            list.Add("Mosh");
            list.Add(DateTime.Today);

            // This is unboxing
            var num = (int) list[0];

            // Refer to use Generic which specify type
            // Will not lead to Boxing/Unboxing (prevent Performance Penalty)
            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("Thinh");
        }
    }
}
