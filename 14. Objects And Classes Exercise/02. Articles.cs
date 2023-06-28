namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split(", ");
            string title = command[0];
            string content = command[1];
            string author = command[2];

            Article article = new Article(title, content, author);

            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {
                string[] command2 = Console.ReadLine().Split(": ");

                switch (command2[0])
                {
                    case "Edit": string newContent = command2[1];
                        article.Edit(newContent);
                        break;
                    case "ChangeAuthor": string newAuthor = command2[1];
                        article.ChangeAuthor(newAuthor);
                        break;
                    case "Rename": string newTitle = command2[1];
                        article.Rename(newTitle);
                        break;
                }
            }

            Console.WriteLine(article.ToString());

        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

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
}