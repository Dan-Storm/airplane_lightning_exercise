using System;

namespace airplane_lightning
{
    class Program
    {
        static void Main(string[] args)
        {

            var Boeing = new Plane()
            {
                Model = "737 Max",
                Make = "Boeing",
                Seats = 152,
            };

            Boeing.Fly();
        }
        class Plane
    {
        public string Model { get; set; }
        public string Make { get; set; }
        public int Seats { get; set; }

        public void Fly()
        {
            Console.WriteLine($"{Make}: Pretty fly for a white guy!");
            
        }
    }
    }
}
