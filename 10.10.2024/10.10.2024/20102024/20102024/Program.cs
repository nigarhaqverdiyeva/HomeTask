namespace _20102024
{
    public class Program
    {
        public static void Main()
        {
            Singer singer1 = new Singer("Aygün", "Kazimova", 50);
            Singer singer2 = new Singer("Murat", "Boz", 40);
            Singer singer3 = new Singer("Mustafa", "Ceceli", 35);
            Song song1 = new Song("SOS", "Pop", singer1);
            Song song2 = new Song("Dogum gunu", "Pop", singer2);
            Song song3= new Song("Fzsexr","Jazz",singer3);
            song1.AddRating(4);
            song1.AddRating(6);
            song1.AddRating(8);
            song2.AddRating(9);
            song2.AddRating(10);
            double averageRating = song1.GetAverageRating();
            double averageRating2 = song2.GetAverageRating();
            Console.WriteLine(song1);
    
        }
    }
}
