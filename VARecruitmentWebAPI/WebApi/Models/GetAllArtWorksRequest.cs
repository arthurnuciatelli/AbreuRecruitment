using System;

namespace VARecruitmentWebAPI.WebApi.Models
{
    public class GetAllArtWorksRequest(Guid id)
    {
        public Guid Id { get; set; } = id;
    }
}
