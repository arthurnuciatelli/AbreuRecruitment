using System;

namespace VARecruitmentWebAPI.WebApi.Models
{
    public class GetAllArtWorksResult(Guid id, string name)
    {
        public Guid Id { get; set; } = id;
        public string Name { get; set; } = name;
    }
}
