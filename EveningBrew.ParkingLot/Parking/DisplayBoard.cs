#nullable disable

using EveningBrew.ParkingLot.ParkingSpot;
using EveningBrew.ParkingLot.Vehicle;

namespace EveningBrew.ParkingLot.Parking
{
    internal class DisplayBoard
    {
        private List<Disabled> DisabledSpot;
        private List<Compact> compactSpot;
        private List<Large> largeSpot;
        private List<MotorCycle> motorCycleSpot;

        public int Id { get; set; }


        // Member functions
        public void ShowFreeSlot()
        {
            throw new NotImplementedException();
        }
    }
}
