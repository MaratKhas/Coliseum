using Coliseum.BuildingBlocks.Domain;

namespace Coliseum.Domain.Bases
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }

        /// <summary>
        /// События домена.
        /// </summary>
        private readonly List<IDomainEvent> _domainEvents = new();

        /// <summary>
        /// События домена.
        /// </summary>
        /// <value>The domain events.</value>
        public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents;

        protected void AddDomainEvent(IDomainEvent eventItem)
        {
            _domainEvents.Add(eventItem);
        }

        // Метод для удаления доменного события
        protected void RemoveDomainEvent(IDomainEvent eventItem)
        {
            _domainEvents.Remove(eventItem);
        }

        // Метод для очистки всех доменных событий
        protected void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(obj == this)
                return true;

            return base.Equals(obj);
        }
    }
}
