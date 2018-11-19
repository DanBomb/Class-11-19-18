namespace ThatOneThing {


    public class Missile : ITrackable {


        private float rate;
        private float missileDistance;

        public Missile (float rate) {
            this.rate = rate;
        }
        public float MathCalculator (int time, float rate) {
            return time * rate;
        }

        public float DistanceTravelledInMeters (float rate, int time) {
            missileDistance = MathCalculator (time, rate);
            return missileDistance;

    
        }
        
    }

    public class RaceCar : ITrackable
    {

        public float rate;
        public float raceCarDistance;

        public RaceCar(float rate) {

            this.rate = rate;
        }
        public float MathCalculator (int time, float rate) {

            return time * rate;
        }

        public float DistanceTravelledInMeters(float rate, int time)
        {
            raceCarDistance = MathCalculator (time, rate);
            return raceCarDistance;
        }
    }
}      

