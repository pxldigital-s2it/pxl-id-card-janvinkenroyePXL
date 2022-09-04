using DigitalStudentCard.Core.Constants;
using DigitalStudentCard.Core.Models;
using DigitalStudentCard.Core.Repositories.Contracts;
using DigitalStudentCard.Core.Services.Contracts.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public async Task<ObservableCollection<Moment>> GetLectorMomentsAsync(int userNumber)
        {
     
            UriBuilder builder = new UriBuilder(ApiConstants.ApiUrl)
            {
                Path = $"{ApiConstants.LectorsEndpointPath}/{userNumber}/moments"
            };

            var moments = await _genericRepository.GetAsync<List<Moment>>(builder.ToString());

            return new ObservableCollection<Moment>(moments);
        }

        public async Task<ObservableCollection<Moment>> GetStudentMomentsAsync(int userNumber)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.ApiUrl)
            {
                Path = $"{ApiConstants.StudentsEndpointPath}/{userNumber}/moments"
            };

            var moments = await _genericRepository.GetAsync<List<Moment>>(builder.ToString());
            
            return new ObservableCollection<Moment>(moments);
        }

        public async Task<Moment> GetMomentAsync(int momentId)
        {
            UriBuilder builder = new UriBuilder(ApiConstants.ApiUrl)
            {
                Path = $"{ApiConstants.MomentsEndpointPath}/{momentId}"
            };

            var moment = await _genericRepository.GetAsync<Moment>(builder.ToString());

            return moment;
        }
    }
}
