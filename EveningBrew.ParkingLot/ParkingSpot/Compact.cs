namespace EveningBrew.ParkingLot.ParkingSpot
{
    internal class Compact : ParkingSpot
    {
       internal override bool AssignVehicle(Vehicle.Vehicle vehicle)
        {
            // place holder for compact parking lot specific logic 

           Vehicle = vehicle;
           return true;
        }
    }
}
