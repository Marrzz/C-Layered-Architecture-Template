using Base.Contracts.Domain;

namespace Base.Domain;

public abstract class DomainEntityMetaId<T> :IDomainEntityMetaId<T> where T: IEquatable<T>
{
    public T UpdatedBy { get; set; } = default!;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    public T CreatedBy { get; set; } = default!;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}

public abstract class DomainEntityMetaId : DomainEntityId<Guid>
{
    
}