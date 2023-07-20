using EveningBrew.ParkingLot.Parking;

namespace EveningBrew.ParkingLot.User
{
    internal class Admin : Account
    {
        public bool AddParkingSpot(ParkingSpot.ParkingSpot spot)
        {
            
            throw new NotSupportedException();
        }

        public bool AddDisplayBoard(DisplayBoard displayBoard)
        {
            // displayBoard here refers to an instance of the DisplayBoard class
          
            throw new NotSupportedException();
        }

        public bool AddEntrance(Entrance entrance)
        {
            // entrance here refers to an instance of the Entrance class
            
            throw new NotSupportedException();
        }

        public bool AddExit(Exit exit)
        {
            // exit here refers to an instance of the Exit class
            throw new NotImplementedException();
        }

        // Will implement the functionality in this class
        public override bool ResetPassword()
        {
            // definition
            throw new NotSupportedException();
        }
    }
}
