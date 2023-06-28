namespace _03._Word_Synonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary <string, string> words = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (!words.ContainsKey(word))
                {
                    words.Add(word, synonim);
                   
                }
                else
                {
                    string currentKeyValue = words[word];
                    words[word] = currentKeyValue + ", " + synonim;
                }
                
            }
            
            foreach (var kvp in words)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
           
        }
    }
}