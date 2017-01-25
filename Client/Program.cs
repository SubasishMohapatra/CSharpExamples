using LinqQExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleClass sampleClass = new SampleClass();
            sampleClass.Initialize();
            var result = sampleClass.GetPeopleByJoiningDate(2016);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.GetType().GetProperty("JoiningDate").GetValue(item, null)}:");
                foreach (dynamic name in item.GetType().GetProperty("Names").GetValue(item, null))
                {
                    Console.WriteLine($"\t{name}");
                }              
            }
            Console.ReadLine();
        }


    }
}