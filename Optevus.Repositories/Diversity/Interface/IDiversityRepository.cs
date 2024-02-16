using Optevus.Model.POCO;

namespace Optevus.Repositories.Diversity.Interface
{
    public interface IDiversityRepository
    {
        Task<CandidateGender?> GetApplicantGenderAsync(int jobId);
        Task<DiversitySchoolAggregate?> GetDiversitySchool(int jobId);
        Task<JobDiversityStatistics?> GetJobApplicantAsync(int jobId);
        Task<List<CandidateAge?>> GetJobApplicantAgeAsync(int jobId);
        Task<EthnicityModel?> GetApplicantEthnicityAsync(int jobId);
    }
}
