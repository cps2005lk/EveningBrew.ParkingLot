using EveningBrew.ParkingLot.Types;

namespace EveningBrew.ParkingLot.Payment
{
    internal abstract class Payment
    {
        private double amount;
        private PaymentStatus status;
        private DateTime timestamp;

        public abstract bool InitiateTransaction();
    }
}
