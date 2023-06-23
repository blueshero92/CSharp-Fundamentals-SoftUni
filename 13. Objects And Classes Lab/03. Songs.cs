namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("_");               

                Song song = new Song();

                song.TypeList = data[0];
                song.Name = data[1];
                song.Time = data[2];

                songs.Add(song);
            }

            string typeToPrint = Console.ReadLine();

            if(typeToPrint == "all")
            {
                for (int j = 0; j < songs.Count; j++)
                {
                    Console.WriteLine(songs[j].Name);
                }
            }
            else
            {
                for (int k = 0; k < songs.Count; k++)
                {
                    if (songs[k].TypeList == typeToPrint)
                    {
                        Console.WriteLine(songs[k].Name);
                    }
                }
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }
}