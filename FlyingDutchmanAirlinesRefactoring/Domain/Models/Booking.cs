using FlyingDutchmanAirlinesRefactoring.Domain.Models.BaseEntities;

namespace FlyingDutchmanAirlinesRefactoring.Domain.Models
{
    public class Booking : BaseEntity<int>
    {
        public string FlightNumber { get; set; }
        public int CustomerID { get; set; }


        public virtual Customer Customer { get; set; }
        public virtual Flight Flight { get; set; }
    }
}
