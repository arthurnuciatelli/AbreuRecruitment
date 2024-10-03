using System;
using MediatR;
using VAArtGalleryWebAPI.Domain.Entities;
using VAArtGalleryWebAPI.Domain.Interfaces;
using VAArtGalleryWebAPI.WebApi.Models;

namespace VARecruitmentWebAPI.Application.Command
{
    public class CreateGalleryCommandHandler(IArtGalleryRepository artGalleryRepository) : IRequestHandler<CreateGalleryCommand, ArtGallery>
    {
        public async Task<ArtGallery> Handle(CreateGalleryCommand request, CancellationToken cancellationToken)
        {
            return await artGalleryRepository.CreateAsync(new ArtGallery(request.Name, request.City, request.Manager), cancellationToken);
        }
    }
}
