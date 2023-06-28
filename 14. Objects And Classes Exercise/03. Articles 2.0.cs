namespace _03._Articles_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int articlesCount = int.Parse(Console.ReadLine());

            List<Article> articleList = new List<Article>();

            for (int i = 0; i < articlesCount; i++)
            {
                string[] command = Console.ReadLine().Split(", ");

                string title = command[0];
                string content = command[1];
                string author = command[2];

                Article article = new Article(title, content, author);

                articleList.Add(article);
            }

            Console.WriteLine(string.Join(Environment.NewLine, articleList));

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
        
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

    }
}