#nullable disable
using EveningBrew.ParkingLot.Types;

namespace EveningBrew.ParkingLot.User
{
    internal abstract class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Person Person { get; set; }
        public AccountStatus AccountStatus { get; set; }


        public abstract bool ResetPassword();
    }
}
