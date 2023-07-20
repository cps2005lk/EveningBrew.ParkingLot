#nullable disable
using EveningBrew.ParkingLot.Parking;

namespace EveningBrew.ParkingLot
{
    internal class ParkingLot
    {
        private int id;
        private string name;
        private string address;
        private ParkingRate parkingRate;

        private Dictionary<string, Entrance> entrance;
        private Dictionary<string, Exit> exit;

        // Create a hashmap that identifies all currently generated tickets using their ticket number
        private Dictionary<string, ParkingTicket> tickets;

        // The ParkingLot is a singleton class that ensures it will have only one active instance at a time
        // Both the Entrance and Exit classes use this class to create and close parking tickets
        private static ParkingLot parkingLot = null;

        // Created a private constructor to add a restriction (due to Singleton)
        ParkingLot() {
            // Call the name, address, parking_rate elements of the customer in the parking lot from the database
            // Create initial entrance and exit hashmaps respectively
        }

        // Created a static method to access the singleton instance of ParkingLot
        public static ParkingLot GetInstance() 
        {

            if (parkingLot == null)
            {
                parkingLot = new ParkingLot();
            }
            return parkingLot;

        }

        public bool AddEntrance(Entrance entrance)
        {
            throw new NotImplementedException();
        }

        public bool AddExit(Exit exit)
        {
            throw new NotImplementedException();
        }

        // This function allows parking tickets to be available at multiple entrances
        public ParkingTicket GetParkingTicket(Vehicle.Vehicle vehicle)
        {
            throw new NotImplementedException();
        }

        public bool IsFull(ParkingSpot.ParkingSpot type)
        {
            throw new NotImplementedException();
        }
    }
}
