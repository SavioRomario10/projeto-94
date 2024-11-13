using System;
using Projeto.Entities;

namespace Projeto{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice strip");
            Comment c2 = new Comment("wow that's awesome");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit",
                12
            );
            
            p1.AddComent(c1, c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                12
            );
            
            p2.AddComent(c3, c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadKey();
        }
    }
}