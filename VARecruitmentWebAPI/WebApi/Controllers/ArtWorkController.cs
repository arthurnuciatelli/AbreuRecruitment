using MediatR;
using System;
using Microsoft.AspNetCore.Mvc;
using VARecruitmentWebAPI.WebApi.Models;
using VARecruitmentWebAPI.Application.Command;
using System.Runtime.CompilerServices;
using VAArtGalleryWebAPI.Application.Queries;
using VAArtGalleryWebAPI.WebApi.Models;

namespace VARecruitmentWebAPI.WebApi.Controllers
{

    [Route("api/art-works")]
    [ApiController]
    public class ArtWorkController(IMediator mediator) : ControllerBase
    {
        [HttpGet]
        [Route("{galleryId}")]
        public async Task<ActionResult<List<GetArtGalleryArtWorksResult>>> GetAll(Guid galleryId)    
        {
            var artworks = await mediator.Send(new GetArtGalleryArtWorksQuery(galleryId));
            var result = artworks.Select(g => new GetArtGalleryArtWorksResult(g.Id, g.Name, g.Author, g.CreationYear, g.AskPrice)).ToList();
            return Ok(result);
        }

        [HttpDelete]
        public async Task<ActionResult> Remove([FromBody] DeleteArtWorkRequest request)
        {            
            var removed = await mediator.Send(new DeleteCommand(request.Id));
            return removed ? StatusCode(StatusCodes.Status204NoContent) : StatusCode(StatusCodes.Status404NotFound);                                                            
        }
    }
}
