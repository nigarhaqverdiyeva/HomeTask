using System.Text.Json;

namespace Library_micro_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string directoryPath = "Files";
            string filePath = Path.Combine(directoryPath, "Database.json");
            if (!Directory.Exists(directoryPath))
            {
                Console.WriteLine("Files qovluğu mövcud deyil.");
                Directory.CreateDirectory(directoryPath);
            }
            else
            {
                Console.WriteLine("Files qovluğu mövcuddur.");
            }
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Database.json faylı mövcud deyil.");
                File.Create(filePath);
            }
            else
            {
                Console.WriteLine("Database.json faylı mövcuddur.");
            }

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Get book by id");
                Console.WriteLine("3. Remove book");
                Console.WriteLine("0. Quit");
                Console.Write("Choose an option: ");
                var option = Console.ReadLine();
            }
        }
    }