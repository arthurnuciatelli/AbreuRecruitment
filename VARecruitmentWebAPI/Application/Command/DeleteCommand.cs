using System;
using MediatR;

namespace VARecruitmentWebAPI.Application.Command
{
    public class DeleteCommand(Guid artWorkId) : IRequest<bool>
    {
        public Guid ArtWorkId { get; set; } = artWorkId;
    }
}
