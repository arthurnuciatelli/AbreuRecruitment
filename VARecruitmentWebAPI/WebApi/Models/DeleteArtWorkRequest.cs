using System;

namespace VARecruitmentWebAPI.WebApi.Models
{
    public class DeleteArtWorkRequest(Guid id)
    {
        public Guid Id { get; set; } = id;
    }
}
