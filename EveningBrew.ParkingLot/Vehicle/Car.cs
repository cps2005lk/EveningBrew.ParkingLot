using EveningBrew.ParkingLot.Parking;

namespace EveningBrew.ParkingLot.Vehicle
{
    internal class Car : Vehicle
    {
        public override void AssignTicket(ParkingTicket ticket)
        { 
            ticket.Vehicle = this;
        }
    }
}
