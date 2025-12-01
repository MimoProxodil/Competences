using System;
using Application.CompetenceTypes.Queries;
using Application.GetCompetenceTypes.Queries;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CompetenceTypesController(IMediator mediator) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<CompetenceType>>> GetCompetenceTypes()
    {
        return await mediator.Send(new GetCompetenceTypeList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CompetenceType>> GetCompetenceTypeDetail(string id)
    {
        // var type = await context.CompetenceTypes.FindAsync(id);
        // if(type == null) return NotFound();
        // return Ok(type);
        return await mediator.Send(new GetCompetenceTypeDetails.Query{Id = id});
    }
}
