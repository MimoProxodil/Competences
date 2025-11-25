using System;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers;

public class CompetenceTypesController(AppDbContext context) : BaseApiController
{
    [HttpGet]
    public async Task<ActionResult<List<CompetenceType>>> GetCompetenceTypes()
    {
        return await context.CompetenceTypes.ToListAsync(); 
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<CompetenceType>> GetCompetenceTypeDetail(string id)
    {
        var type = await context.CompetenceTypes.FindAsync(id);
        if(type == null) return NotFound();
        return Ok(type);
    }
}
