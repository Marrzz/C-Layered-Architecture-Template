using Base.Contracts.Domain;

namespace Base.Domain;

public abstract class DomainEntityMetaId<T> :IDomainEntityMetaId<T> where T: IEquatable<T>
{
    public T UpdatedBy { get; set; } = default!;
    public DateTime UpdatedAt { get; set; }
    public T CreatedBy { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
}

public abstract class DomainEntityMetaId : DomainEntityId<Guid>
{
    
}