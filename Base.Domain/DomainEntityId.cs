using Base.Contracts.Domain;

namespace Base.Domain;

public abstract class DomainEntityId : DomainEntityId<Guid>, IDomainEntityId
{
    
}

public abstract class DomainEntityId<T> : IDomainEntityId<T> where T : IEquatable<T>
{
    public T Id { get; set; } = default!;
}