using System;

namespace ThatOnething {

    class Program {

        public static int time = 10;
    
        static void Main(string[] args) 
        {
            Console.WriteLine ("Testing objects:");
            Missile Bill = new Missile (1000.0);
            RaceCar McQueen = new RaceCar (100.0);

            Console.WriteLine ("Missile distance traveled: " + Bill.DistanceTraveledInMeters (Bill.rate, time) + " meters");

            Console.WriteLine ("Racecar distance traveled: " + McQueen.DistanceTraveledInMeters (McQueen.rate, time) + " meters");
        }
    }
}
