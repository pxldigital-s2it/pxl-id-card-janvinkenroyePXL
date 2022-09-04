using DigitalStudentCard.Core.Constants;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Repositories.Contracts;
using DigitalStudentCard.Core.Services.Contracts.Data;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace DigitalStudentCard.Core.Services.Data
{
    internal class AuthenticationService : IAuthenticationService
    {
        private readonly IGenericRepository _genericRepository;
        public AuthenticationService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;

        }
        public async Task<AuthenticationResponse> Authenticate(string userName, string password)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.ApiUrl)
            {
                Path = ApiConstants.AuthenticateEndpointPath
            };

            AuthenticationRequest authenticationRequest = new AuthenticationRequest()
            {
                UserName = userName,
                Password = password
            };

            return await _genericRepository.PostAsync<AuthenticationRequest, AuthenticationResponse>(builder.ToString(), authenticationRequest);
        }
        public bool IsUserAuthenticated()
        {
            return Preferences.ContainsKey("UserId");
        }

        /*
        public async Task<AuthenticationResponse> Register(string firstName, string lastName, string email, string userName, string password)
        {
        UriBuilder builder = new UriBuilder(ApiConstants.BaseUrl)
        {
            Path = ApiConstants.RegisterEndpointPath
            }

            AuthenticationRequest authenticationRequest = new AuthenticationRequest()
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                UserName = userName,
                Password = password
            };

            return await _genericRepository.PostAsync<AuthenticationRequest, AuthenticationResponse>(builder.ToString(), authenticationRequest);
        }
        */
    }
}
