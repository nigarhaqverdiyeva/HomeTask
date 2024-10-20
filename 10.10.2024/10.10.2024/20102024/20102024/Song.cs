using System;

namespace _20102024
{
    public class Song
    {
        public string name { get; set; }
        public string genre { get; set; }
        public Singer singer { get; set; }
        private double[] ratings = new double[10];
        private int ratingCount = 0;

        public Song(string name, string genre, Singer singer)
        {
            if (name.Length > 100)
            {
                Console.WriteLine("Invalid name");
                return;
            }

            if (genre == "Pop" || genre == "Rock" || genre == "Jazz" || genre == "Techno")
            {
                this.genre = genre;
            }
            else
            {
                Console.WriteLine("Düzgün genre daxil edilməyib");
                return;
            }

            this.name = name;
            this.singer = singer;
        }

        public void AddRating(double rating)
        {
            if (rating < 0 || rating > 10)
            {
                Console.WriteLine("Invalid value");
                return;
            }
            if (ratingCount < ratings.Length)
            {
                ratings[ratingCount] = rating;
                ratingCount++;
            }
            else
            {
                Console.WriteLine("Maximum rating reached");
            }
        }

        public double GetAverageRating()
        {
            if (ratingCount == 0)
            {
                return 0;
            }

            double total = 0;
            for (int i = 0; i < ratingCount; i++)
            {
                total += ratings[i];
            }
            return total / ratingCount;
        }
        public override string ToString()
        {
            return $"Song: {name}, Genre: {genre}, Singer: {singer.name} {singer.surname}, Average Rating: {GetAverageRating():F2}";
        }
    }
}
