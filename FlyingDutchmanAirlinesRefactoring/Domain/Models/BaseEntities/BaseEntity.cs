namespace FlyingDutchmanAirlinesRefactoring.Domain.Models.BaseEntities
{
    public class BaseEntity<Key> : IBaseEntity<Key>
    {
        public Key Id { get; set; }
    }
}
