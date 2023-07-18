using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

var token = TokenUtil.GenerateToken();

Console.WriteLine(token);