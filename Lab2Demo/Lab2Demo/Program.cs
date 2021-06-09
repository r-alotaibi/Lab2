using System;

namespace Lab2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            movies();
        }


        public static void movies()
        {
            string[] movies = { "1- The last summer", "2- The party", "3- The room", "4- level 16", "5- Baby drive" };


            Console.WriteLine("The list of avaiable movies:");
            //show all movies
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(movies[i]);
            }
            Console.WriteLine();

            Console.WriteLine("The list of movies on reverse order:");
            //display all movies in the reverse order
            for (int j = 4; j > -1; j--)
            {
                Console.WriteLine(movies[j]);
            }
            Console.WriteLine();

            Console.WriteLine("The 4th movie in the list:");
            //retrieve the 4th element
            Console.WriteLine(movies[3]);
            Console.WriteLine();

            Console.WriteLine("After delete the 3rd movie in the list:");
            //delete the 3rd element
            string t4 = movies[3];
            string t5 = movies[4];
            movies[2] = t4;
            movies[3] = t5;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(movies[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Using 'foreach' to access:");
            //access to movies name using foreach
            foreach (string i in movies)
            {
                Console.WriteLine(i);
            }
        }

    }
 }