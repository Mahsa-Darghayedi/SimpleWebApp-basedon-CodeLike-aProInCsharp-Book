using FlyingDutchmanAirlinesRefactoring.Domain.Models.BaseEntities;

namespace FlyingDutchmanAirlinesRefactoring.Domain.Models
{
    public class Airport : BaseEntity<int>
    {
        private readonly HashSet<Flight> _flightsOrigin;
        private readonly HashSet<Flight> _flightsDestination;

        public Airport()
        {
            _flightsOrigin = new HashSet<Flight>(); 
            _flightsDestination = new HashSet<Flight>();
        }

        public string City { get; set; }
        public string IATA { get; set; }

        public IReadOnlyCollection<Flight> FlightsOrigin => _flightsOrigin;
        public IReadOnlyCollection<Flight> FlightsDestination => _flightsDestination;
    }
}
