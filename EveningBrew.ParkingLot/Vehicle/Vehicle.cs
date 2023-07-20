#nullable disable

using EveningBrew.ParkingLot.Parking;

namespace EveningBrew.ParkingLot.Vehicle
{
    internal abstract class Vehicle
    {
        public string LicenseNo { get; set; }

        public abstract void AssignTicket(ParkingTicket ticket);

    }
}
