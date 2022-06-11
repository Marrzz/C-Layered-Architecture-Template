using System.ComponentModel;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace Base.Extensions;

public static class IdentityExtensions
{

    public static Guid GetUserId(this ClaimsPrincipal user) => GetUserId<Guid>(user);
    
    public static TKeyType GetUserId<TKeyType>(this ClaimsPrincipal user)
    {
        var idClaims = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

        if (idClaims == null)
        {
            throw new NullReferenceException("Name Identifier claim not found!!!");
        }

        var res  = (TKeyType) TypeDescriptor
            .GetConverter(typeof(TKeyType))
            .ConvertFromInvariantString(idClaims.Value)!;
        return res;
        

        
    }

    public static string GenerateJwt(
        IEnumerable<Claim> claims, string key, 
        string issuer, string audience, DateTime expirationDateTime)
    {
        var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var signinCredentials = new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256);
        var token = new JwtSecurityToken(issuer, audience, claims, expires: expirationDateTime, signingCredentials: signinCredentials);
        return new JwtSecurityTokenHandler().WriteToken(token);
    }
}
