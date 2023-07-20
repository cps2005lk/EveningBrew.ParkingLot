#nullable disable
namespace EveningBrew.ParkingLot.Parking
{
    internal class ParkingTicket
    {
        private int ticketNo;
        private DateTime timestamp;
        private DateTime exit;
        private double amount;
        private bool status;

        // Following are the instances of their respective classes
        public Vehicle.Vehicle Vehicle { get; set; }

        private Payment.Payment payment;
        private Entrance entrance;
        private Exit exitIns;
    }
}
