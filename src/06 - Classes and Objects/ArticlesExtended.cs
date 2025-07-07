using System;
using System.Collections.Generic;


namespace SoftUniCSharpClassesAndObjects
{
    class Articles
    {
        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }

        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main()
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<string> articles = new List<string>();
            for (int i = 0; i < numberOfArticles; i++)
            {
                string input = Console.ReadLine();
                string[]article = input.Split(", ").ToArray();
                string title = article[0];
                string content = article[1];
                string author = article[2];
                Articles newArticle = new Articles(title,content,author);
                articles.Add(newArticle.ToString());
            }
            for (int i = 0; i < articles.Count(); i++)
            {
                Console.WriteLine(articles[i]);
            }
        }
    }
}


