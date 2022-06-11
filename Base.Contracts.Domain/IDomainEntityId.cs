namespace Base.Contracts.Domain;

public interface IDomainEntityId : IDomainEntityId<Guid>
{
    
}

public interface IDomainEntityId<T> where T: IEquatable<T>
{
    public T Id { get; set; }    
}