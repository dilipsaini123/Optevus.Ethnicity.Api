using Optevus.Model.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optevus.Services.DiversityServices.Interface
{
    public interface IDiversityService
    {
        Task<ResponseGenderAggregate?> GetApplicantGenderAsync(int jobId);
        Task<ResponseJobDiversityStatistics> GetJobApplicant(int jobId);
        Task<ResponseDiversitySchool?> GetDiversitySchool(int jobId);
        Task<List<ResponseAgeAggregate>?> GetApplicantAgeRanges(int jobId);
        Task<ResponseEthnicityAggregate?> GetApplicantEthnicity(int jobId);
    }
}
