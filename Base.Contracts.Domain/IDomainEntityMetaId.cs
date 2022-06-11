namespace Base.Contracts.Domain;

public interface IDomainEntityMetaId : IDomainEntityId<Guid>
{
    
}


public interface IDomainEntityMetaId<T> where T : IEquatable<T>
{
    public T UpdatedBy { get; set; }
    
    public DateTime UpdatedAt { get; set; }
    
    public T CreatedBy { get; set; }
    
    public DateTime CreatedAt { get; set; }
    
}