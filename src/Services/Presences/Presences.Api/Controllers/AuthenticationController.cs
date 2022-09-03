using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Presences.DataTransfer;
using Presences.Domain;
using Presences.Logic.IRepositories;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Presences.Api.Controllers;

[Route("api/authentication")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly IConfiguration _configuration;
    private readonly IUserRepository _userRepository;

    public AuthenticationController(IConfiguration configuration, IUserRepository userRepository)
    {
        _configuration = configuration ??
            throw new ArgumentNullException(nameof(configuration));
        _userRepository = userRepository ?? 
            throw new ArgumentNullException(nameof(userRepository));
    }

    [HttpPost("authenticate")]
    public ActionResult<string> Authenticate(
        AuthenticationRequestBody authenticationRequestBody)
    {
        if (authenticationRequestBody.UserName == null || authenticationRequestBody.Password == null)
        {
            return BadRequest();
        }

        // Step 1: validate the username/password
        var user = _userRepository.GetByUserName(authenticationRequestBody.UserName);
        if (user == null || user.Password != authenticationRequestBody.Password)
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

        var response = new AuthenticationResponse()
        {
            Token = tokenToReturn,
            IsAuthenticated = true,
            User = new User
            {
                UserName = user.UserName,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Role = user.Role,
                UserNumber = user.UserNumber
            }
        };

        return Ok(response);
    }

    public class AuthenticationRequestBody
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
