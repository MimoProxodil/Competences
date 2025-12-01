using System;
using System.Security.Cryptography.X509Certificates;
using Domain;
using MediatR;
using Persistence;

namespace Application.CompetenceTypes.Queries;

public class GetCompetenceTypeDetails
{
    public class Query : IRequest<CompetenceType>
    {
        public required string Id { get; set; }
    }

    public class Handler(AppDbContext context) : IRequestHandler<Query, CompetenceType>
    {
        public async Task<CompetenceType> Handle(Query request, CancellationToken cancellationToken)
        {
            var type = await context.CompetenceTypes.FindAsync([request.Id], cancellationToken);
            if (type == null) throw new Exception("Competence Type not found");
            return type;
        }
    }
}
