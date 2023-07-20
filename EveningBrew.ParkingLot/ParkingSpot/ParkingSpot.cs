#nullable disable
namespace EveningBrew.ParkingLot.ParkingSpot
{
    internal abstract class ParkingSpot
    {
        public int Id { get; set; }
        public Vehicle.Vehicle Vehicle { get; set; }


        internal bool IsFree()
        {
           return Vehicle == null;
        }

        internal abstract bool AssignVehicle(Vehicle.Vehicle vehicle);

        internal bool RemoveVehicle()
        {
            this.Vehicle = null;
            return true;
        }
    }
}