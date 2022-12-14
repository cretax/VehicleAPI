namespace VehicleAPI
{
    public abstract class Vehicle
    {

        public int VehicleId { get; set; }
        public string VehicleColor { get; set; }

        public Vehicle(int vehicleId, string vehicleColor)
        {
            VehicleId = vehicleId;
            VehicleColor = vehicleColor;
        }

    }
}
