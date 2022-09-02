using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Presences.Domain;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Presences.Api.Controllers;

[Route("api/authentication")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IConfiguration _configuration;

    public AuthenticationController(IConfiguration configuration)
    {
        _configuration = configuration ??
            throw new ArgumentNullException(nameof(configuration));
    }

    [HttpPost("authenticate")]
    public ActionResult<string> Authenticate(
        AuthenticationRequestBody authenticationRequestBody)
    {
        // Step 1: validate the username/password
        var user = ValidateUserCredentials(
            authenticationRequestBody.UserName,
            authenticationRequestBody.Password);

        if (user == null)
        {
            return Unauthorized();
        }

        // Step 2: create a token
        var securityKey = new SymmetricSecurityKey(
            Encoding.ASCII.GetBytes(_configuration["Authentication:SecretForKey"]));
        var signingCredentials = new SigningCredentials(
            securityKey, SecurityAlgorithms.HmacSha256);

        var claimsForToken = new List<Claim>();
        claimsForToken.Add(new Claim("sub", user.UserNumber.ToString()));
        claimsForToken.Add(new Claim("role", user.Role.ToString()));

        var jwtSecurityToken = new JwtSecurityToken(
            _configuration["Authentication:Issuer"],
            _configuration["Authentication:Audience"],
            claimsForToken,
            DateTime.UtcNow,
            DateTime.UtcNow.AddHours(1),
            signingCredentials);

        var tokenToReturn = new JwtSecurityTokenHandler()
           .WriteToken(jwtSecurityToken);

        return Ok(tokenToReturn);
    }

    private User ValidateUserCredentials(string? userName, string? password)
    {
        // we don't have a user DB or table.  If you have, check the passed-through
        // username/password against what's stored in the database.
        //
        // For demo purposes, we assume the credentials are valid

        // return a new CityInfoUser (values would normally come from your user DB/table)
        return new User()
        {
            UserNumber = 1,
            UserName = userName ?? "",
            FirstName = "Kevin",
            LastName = "Dockx",
        };
    }

    public class AuthenticationRequestBody
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
