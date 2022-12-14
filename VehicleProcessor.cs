namespace VehicleAPI
{

    public class VehicleProcessor : IVehicleProcessor
    {


        public List<Vehicle> ListOfVehicles = new List<Vehicle> {
            new Car(1, "black"),
            new Bus(2, "blue"),
            new Boat(3 ,"white"),
            new Car(4, "red"),
            new Boat(5, "blue"),
            new Car(6, "white"),
            new Bus(7, "red"),
            new Car(8, "black"),
            new Car(9, "white"),
            new Boat(10, "blue")
        };


        public List<Car> GetCars(string color)
        {
            var cars = new List<Car>();
            foreach (var vehicle in ListOfVehicles)
            {
                if (vehicle is Car && vehicle.VehicleColor == color)
                {
                    cars.Add((Car)vehicle);
                }
            }

            return cars;
        }

        public List<Bus> GetBuses(string color)
        {
            var buses = new List<Bus>();
            foreach (var vehicle in ListOfVehicles)
            {
                if (vehicle is Bus && vehicle.VehicleColor == color)
                {
                    buses.Add((Bus)vehicle);
                }
            }

            return buses;
        }

        public List<Boat> GetBoats(string color)
        {
            var boats = new List<Boat>();
            foreach (var vehicle in ListOfVehicles)
            {
                if (vehicle is Boat && vehicle.VehicleColor == color)
                {
                    boats.Add((Boat)vehicle);
                }
            }

            return boats;
        }

        public void SetHeadligtState(int id)
        {
            foreach (var vehicle in ListOfVehicles)
            {
                if (vehicle is Car && vehicle.VehicleId == id)
                {
                    var car = (Car)vehicle;
                    var currentHeadLightState = car.HeadlightState;
                    car.HeadlightState = !currentHeadLightState;
                    break;
                }
            }            
        }

        public void DeleteCar(int id)
        {
            foreach (var vehicle in ListOfVehicles)
            {
                if (vehicle is Car && vehicle.VehicleId == id)
                {
                    ListOfVehicles.Remove(vehicle);
                    break;
                }
            }
        }
    }

    public interface IVehicleProcessor
    {
        public List<Car> GetCars(string color);
        public List<Bus> GetBuses(string color);
        public List<Boat> GetBoats(string color);
        public void SetHeadligtState(int id);
        public void DeleteCar(int id);

    }
}
