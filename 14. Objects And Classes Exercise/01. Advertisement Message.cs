using System;

namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int messagesCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesCount; i++)
            {
                Message message = new Message();                
                                           
                Console.WriteLine(message.GetRandomMessage());
            }
        }
    }

    class Message
    {

        List<string> Phrase = new List<string>() {"Excellent product.", "Such a great product.", 
            "I always use that product.", "Best product of its category.", 
            "Exceptional product.", "I can't live without this product."};

        List <string> Event = new List<string>() {"Now I feel good.", "I have succeeded with this product.", 
            "Makes miracles. I am happy of the results!", "I cannot believe but now I feelawesome.", 
            "Try it yourself, I am very satisfied.", "I feel great!"};

        List<string> Author = new List<string>() { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

        List <string> City = new List<string>() { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


        public string GetRandomMessage()
        {
            Random rnd = new Random();

            int index = rnd.Next(Phrase.Count);
            string phrase = Phrase[index];

            index = rnd.Next(Event.Count);
            string @event = Event[index];

            index = rnd.Next(Author.Count);
            string author = Author[index];

            index = rnd.Next(City.Count);
            string city = City[index];

            return $"{phrase} {@event} {author} - {city}";
        }
        
    }

 }


