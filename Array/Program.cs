using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shoppinglist = { "monster", "pop corn", "chips", "cookies", "chicken nuggets" };


            int arrayLenght = shoppinglist.Length;
            Console.WriteLine($"You have {arrayLenght} items on your list.");

            for (int i = 0; i < shoppinglist.Length; i++)
            {
                Console.WriteLine($"{i+1}. {shoppinglist[i]}");
            }
            Console.WriteLine($"The first item on your list is {shoppinglist[0]}");
            Console.WriteLine($"The last item on your list is {shoppinglist[shoppinglist.Length-1]}");

        }
    }
}
