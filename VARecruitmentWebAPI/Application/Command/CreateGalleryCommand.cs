
using MediatR;
using VAArtGalleryWebAPI.Domain.Entities;

namespace VARecruitmentWebAPI.Application.Command
{
    public class CreateGalleryCommand(string name, string city, string manager) : IRequest<ArtGallery>
    {
        public string Name { get; set; } = name;

        public string City { get; set; } = city;

        public string Manager { get; set; } = manager;
    }
}
