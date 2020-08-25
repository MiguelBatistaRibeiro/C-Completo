using String_Builder.Entities;
using System;

namespace String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice dream");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(DateTime.Parse("21/05/2018 13:05:44"), "Finaly", "Good night for all of you", 9);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Have a nice weekend");
            Comment c4 = new Comment("Wow that's wonderful!");

            Post p2 = new Post(DateTime.Parse("22/05/2018 15:30:24"), "Bye Bye", "I'm goig to the house", 9);
            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);

            Console.ReadKey();
        }
    }
}
