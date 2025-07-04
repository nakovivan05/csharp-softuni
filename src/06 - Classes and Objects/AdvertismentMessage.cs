using System;


namespace SoftUniCSharpClassesAndObjects
{
    class AdvertisementMessage
    {
        private static string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };
        private static string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        private static string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        private static string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        public static string GenerateMessage ()
        {
            Random rnd = new Random();
            string phrase = phrases[rnd.Next(phrases.Length)];
            string anEvent = events[rnd.Next(events.Length)];
            string author = authors[rnd.Next(authors.Length)];
            string city = cities[rnd.Next(cities.Length)];
            return $"{phrase} {anEvent} {author} – {city}.";
        }
        

    }
    class Program
    {
        static void Main()
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfMessages; i++)
            {
                Console.WriteLine(AdvertisementMessage.GenerateMessage());
            }
        }
    }

}