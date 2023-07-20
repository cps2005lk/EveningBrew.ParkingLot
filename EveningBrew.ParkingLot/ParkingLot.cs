#nullable disable
using System.Runtime.CompilerServices;
using EveningBrew.ParkingLot.Parking;
using EveningBrew.ParkingLot.ParkingSpot;

namespace EveningBrew.ParkingLot
{
    internal class ParkingLot
    {
        private int id;
        private string _name;
        private string _address;
        private ParkingRate _parkingRate;

        List<Disabled> _disabledSpots = new List<Disabled>();
        List<Large> _largeSpots = new List<Large>();
        List<Compact> _compactSpots = new List<Compact>();
        List<Motorcycle> _motorcycleSpots = new List<Motorcycle>();



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

        public bool Add(ParkingSpot.ParkingSpot parkingSpot)
        {
            switch (parkingSpot)
            {
                case Disabled spot:
                    _disabledSpots.Add(spot);
                    break;

                case  Large spot:
                    _largeSpots.Add(spot);
                    break;

                case  Compact spot:
                    _compactSpots.Add(spot);
                    break;
                case  Motorcycle spot:
                    _motorcycleSpots.Add(spot);
                    break;
            }
            return true;
        }
    }
}
