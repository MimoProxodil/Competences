using System;
using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.GetCompetenceTypes.Queries;

public class GetCompetenceTypeList
{
    public class Query : IRequest<List<CompetenceType>> { }

    public class Hadler(AppDbContext context) : IRequestHandler<Query, List<CompetenceType>>
    {
        public async Task<List<CompetenceType>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await context.CompetenceTypes.ToListAsync(cancellationToken);
        }
    }
}
