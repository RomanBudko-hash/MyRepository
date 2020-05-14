using System;


namespace SomethingProject
{
    internal class NewAndLastClass : MostLastClassOnThisProject
    {
        public int [] Random ( ref int []array )
        {
            var rand = new Random();
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(55);
            }
            return array;
        }
    }
}
