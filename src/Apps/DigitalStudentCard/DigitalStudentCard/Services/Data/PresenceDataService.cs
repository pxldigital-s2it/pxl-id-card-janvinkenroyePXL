using DigitalStudentCard.Core.Constants;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Repositories.Contracts;
using DigitalStudentCard.Core.Services.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Data
{
    public class PresenceDataService : IPresenceDataService
    {
        private readonly IGenericRepository _genericRepository;

        public PresenceDataService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<Presence> AddPresence(Presence presence)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.ApiUrl)
            {
                Path = ApiConstants.PresencesEndpointPath
            };

            var result = await _genericRepository.PostAsync(builder.ToString(), presence);

            return result;
        }
    }
}
