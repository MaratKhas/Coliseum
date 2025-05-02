using Coliseum.BuildingBlocks.Domain;

namespace Coliseum.Modules.Coliseums.Domain.Bases
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
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

        private List<IDomainEventObserver> _domainEventObserver = new();

        public void RegisterObserver(IDomainEventObserver domainEventObserver)
        {
            _domainEventObserver.Add(domainEventObserver);
        }

        protected void AddDomainEvent(IDomainEvent eventItem)
        {
            _domainEvents.Add(eventItem);
            foreach (var observer in _domainEventObserver)
            {
                observer?.HandleEvent(eventItem);
            };
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
            if (obj == this)
                return true;

            return base.Equals(obj);
        }
    }
}
