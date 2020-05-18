using System;

namespace SomethingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dateBaseOfClient = new int[50];

            NewAndLastClass nalc = new NewAndLastClass();

            nalc.Random (ref dateBaseOfClient);
            
            Console.WriteLine("До сортировки");

            Console.WriteLine(string.Join(" ", dateBaseOfClient));

            Console.WriteLine("После сортировки");

            nalc.MergeSort(ref dateBaseOfClient);

            Console.WriteLine(string.Join(" ", dateBaseOfClient));
        }       
    }
}
