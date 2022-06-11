using Base.Contracts.Domain;
using Microsoft.AspNetCore.Identity;

namespace Base.Domain.Identity;

public class BaseUser : BaseUser<Guid>, IDomainEntityId
{
    public BaseUser() : base()
    {
    }

    public BaseUser(string email) : base(email)
    {
    }
}

public class BaseUser<TKey> : IdentityUser<TKey>, IDomainEntityId<TKey> where TKey: IEquatable<TKey>

{
    public BaseUser() : base()
    {
    }

    public BaseUser(string email) : base(email)
    {
    }
}