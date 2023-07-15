namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            string fileName = string.Empty;
            string extension = string.Empty;

            int indexOfName = filePath.LastIndexOf('\\');
            int indexOfExtension = filePath.LastIndexOf('.');

            if (indexOfName != -1 && indexOfExtension != -1 && indexOfExtension > indexOfName)
            {
                fileName = filePath.Substring(indexOfName + 1, indexOfExtension - indexOfName - 1);
                extension = filePath.Substring(indexOfExtension + 1, filePath.Length - indexOfExtension - 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
            
        }
    }
}