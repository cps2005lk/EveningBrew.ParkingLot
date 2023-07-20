namespace EveningBrew.ParkingLot.ParkingSpot
{
    internal class Large: ParkingSpot
    {
        internal override bool AssignVehicle(Vehicle.Vehicle vehicle)
        {
            // place holder for Large parking lot specific logic 

            Vehicle = vehicle;
            return true;
        }
    }
}
