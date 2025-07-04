using System;
using System.Linq;


namespace SoftUniCSharpObjectsAndClasses
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
        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newTitle)
        {
            Title = newTitle;
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
            string input = Console.ReadLine();
            string[] article = input.Split(", ");
            string title = article[0];
            string content = article[1];
            string author = article[2];
            Articles newArticle = new Articles(title, content, author);
            int numberOfCommands = int.Parse(Console.ReadLine());
            string [] command;
            for (int i = 0; i < numberOfCommands; i++)
            {
                command = Console.ReadLine().Split(": ").ToArray();
                if (command[0] == "Edit")
                {
                    string newContent = command[1];
                    newArticle.Edit(newContent);
                }
                else if (command[0] == "ChangeAuthor")
                {
                    string newAuthor = command[1];
                    newArticle.ChangeAuthor(newAuthor);
                }
                else if(command[0] == "Rename")
                {
                    string newTitle = command[1];
                    newArticle.Rename(newTitle);
                }
            }
            Console.WriteLine(newArticle);
        }
    }
}

