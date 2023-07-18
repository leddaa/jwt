using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

public static class TokenUtil
{
    public static string GenerateToken()
    {
        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes("B4kc&kP4YPme@WK@DzKFoy%^qX4IvjcC");

        var claims = new Dictionary<string, object>
        {
            {"aud", "sdgf"},
            {"iss", ""},
            {"iat", string.Empty},
            {"nbf", string.Empty},
            {"exp", string.Empty},
            {"acr", ""},
            {"aio", ""},
            {"amr", ""},
            {"appid", ""},
            {"appidacr", ""},
            {"deviceid", ""},
            {"family_name", ""},
            {"given_name", ""},
            {"ipaddr", ""},
            {"name", ""},
            {"oid", ""},
            {"onprem_sid", ""},
            {"rh", ""},
            {"roles", new [] { "", "", "",}},
            {"scp", "User.Read"},
            {"sub", ""},
            {"tid", ""},
            {"unique_name", ""},
            {"upn", ""},
            {"uti", ""},
            {"ver", "1.0"},
        };

        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Claims = claims,
            SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDescriptor);
        return tokenHandler.WriteToken(token);
    }
}