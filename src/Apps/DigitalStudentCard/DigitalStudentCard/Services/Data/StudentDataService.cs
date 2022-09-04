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
    public class StudentDataService : IStudentDataService
    {
        private readonly IGenericRepository _genericRepository;

        public StudentDataService(IGenericRepository genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public async Task<ObservableCollection<Student>> GetAbsentStudentsForMomentsAsync(int momentId)
        {
     
            UriBuilder builder = new UriBuilder(ApiConstants.ApiUrl)
            {
                Path = $"{ApiConstants.MomentsEndpointPath}/{momentId}/absent-students"
            };

            var students = await _genericRepository.GetAsync<List<Student>>(builder.ToString());

            return new ObservableCollection<Student>(students);
        }
    }
}
