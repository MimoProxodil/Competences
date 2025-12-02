using System;
using Application.CompetenceTypes.Commands;
using Application.CompetenceTypes.Queries;
using Application.GetCompetenceTypes.Queries;
using Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CompetenceTypesController : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<CompetenceType>>> GetCompetenceTypes()
    {
        return await Mediator.Send(new GetCompetenceTypeList.Query());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CompetenceType>> GetCompetenceTypeDetail(string id)
    {
        // var type = await context.CompetenceTypes.FindAsync(id);
        // if(type == null) return NotFound();
        // return Ok(type);
        return await Mediator.Send(new GetCompetenceTypeDetails.Query{Id = id});
    }

    [HttpPost]
    public async Task<ActionResult<string>> CreateCompetenceType(CompetenceType competenceType)
    {
        return await Mediator.Send(new CreateCompetenceType.Command{CompetenceType = competenceType});
    }

    [HttpPut]
    public async Task<ActionResult> EditCompetenceType(CompetenceType competenceType)
    {
        await Mediator.Send(new EditCompetenceType.Command{CompetenceType = competenceType});
        return NoContent();
    }

}
