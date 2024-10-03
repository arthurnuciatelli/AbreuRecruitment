using System;
using MediatR;
using VAArtGalleryWebAPI.Domain.Interfaces;

namespace VARecruitmentWebAPI.Application.Command
{
    public class DeleteCommandHandler(IArtWorkRepository artWorkRepository) : IRequestHandler<DeleteCommand, bool>
    {
        public async Task<bool> Handle(DeleteCommand request, CancellationToken cancellationToken)
        {
            return await artWorkRepository.DeleteAsync(request.ArtWorkId, cancellationToken);
        }
    }
}
