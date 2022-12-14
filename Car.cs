namespace VehicleAPI
{
    public class Car : Vehicle
    {
        private bool headlightState;
        public Car(int vehicleId, string vehicleColor) : base(vehicleId, vehicleColor)
        {
            HeadlightState = false;
        }

        public bool HeadlightState
        {
            get { return headlightState; }
            set { headlightState = value; }
        }
        

    }
}
