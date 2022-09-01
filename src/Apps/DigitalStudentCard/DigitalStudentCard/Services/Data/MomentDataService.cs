using DigitalStudentCard.Core.Constants;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Repositories.Contracts;
using DigitalStudentCard.Core.Services.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalStudentCard.Core.Services.Data
{
    public class MomentDataService : IMomentDataService
    {
        private readonly IGenericRepository _genericRepository;

        public MomentDataService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<IEnumerable<Moment>> GetLectorMomentsAsync(int lectorId)
        {
     
            UriBuilder builder = new UriBuilder(ApiConstants.BaseUrl)
            {
                Path = $"{ApiConstants.LectorsEndpointPath}/{lectorId}/moments"
            };

            var moments = await _genericRepository.GetAsync<List<Moment>>(builder.ToString());

            return moments;
        }

        public async Task<IEnumerable<Moment>> GetStudentMomentsAsync(int studentId)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.BaseUrl)
            {
                Path = $"{ApiConstants.LectorsEndpointPath}/{studentId}/moments"
            };

            var moments = await _genericRepository.GetAsync<List<Moment>>(builder.ToString());

            return moments;
        }
    }
}
