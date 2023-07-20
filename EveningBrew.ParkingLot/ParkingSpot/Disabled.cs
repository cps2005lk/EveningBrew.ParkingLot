namespace EveningBrew.ParkingLot.ParkingSpot
{
    internal class Disabled : ParkingSpot
    {
        internal override bool AssignVehicle(Vehicle.Vehicle vehicle)
        {
            // place holder for Disabled parking lot specific logic 

            Vehicle = vehicle;
            return true;
        }
    }
}
