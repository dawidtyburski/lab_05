using System;
using System.Linq;
using System.Collections.Generic;

namespace lab_05
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableList1<int> ob1 = new ObservableList1<int>();
            ob1.Add(1);
            ob1.Add(3);
            ob1.Add(5);
            ob1.Add(7);
            ob1.Add(9);
            ob1.Add(11);

            if(ob1.Length()>0)
            {
                Console.WriteLine();
                Console.WriteLine($"ob1 Length: {ob1.Length()}");
            }
            while(ob1.Length()>0)
            {
                Console.WriteLine();
                Console.WriteLine("For Get() type get [index]");
                Console.WriteLine("For Set() type set [index] to [new value]");
                Console.WriteLine("For RemoveAt() type remove [index]");

                string rl = Console.ReadLine();
                if(rl != null)
                {
                    string[] rlList = rl.Split(" ");
                    
                    foreach (string s in rlList)
                    {
                        if(s == "get")
                        {
                            Console.WriteLine(ob1.Get(Int32.Parse(rlList.Last())));
                        }
                        else if(s == "set")
                        {
                            ob1.Set(rlList[1], rlList.Last());
                        }
                        else if (s == "remove")
                        {
                            ob1.RemoveAt(Int32.Parse(rlList.Last()));
                        }
                    }
                }
            }
        }
    }
}
