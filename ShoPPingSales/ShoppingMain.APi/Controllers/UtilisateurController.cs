using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shopping.Application.DTOs.Utilisateurs;
using Shopping.Application.Features.Utilisateurs.Requests.Commands;
using Shopping.Application.Features.Utilisateurs.Requests.Queries;
using Shopping.Application.Responses;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShoppingMain.APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UtilisateurController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<UtilisateurDto>>> Get()
        {
            var listUtilisateur = await _mediator.Send(new GetUtilisateurListRequest());
            return Ok(listUtilisateur);
        }

        [HttpPost]
        public async Task<ActionResult<BaseCommandReponse>> Post([FromBody] CreateUtilisateurDto utilisateur)
        {
            utilisateur.Id = Guid.NewGuid();
            var response = await _mediator.Send(new CreateUtilisateurCommand { UtilisateurDto = utilisateur });
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UtilisateurDto>> Get(Guid id)
        {
            var utilisateur = await _mediator.Send(new GetUtilisateurDetailRequest { Id = id });
            return Ok(utilisateur);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteUtilisateurCommand { Id = id });
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, [FromBody] UpdateUtilisateurDto utilisateur)
        {
            await _mediator.Send(new UpdateUtilisateurCommand { Id = id, utilisateurDto = utilisateur });
            return NoContent();
        }
    }
}
