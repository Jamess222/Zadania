using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            TallGuy guy = new TallGuy()
            {
                height = 175,
                name = "James"
            };
            guy.Talk();
            guy.Honk();
        }
    }
}
