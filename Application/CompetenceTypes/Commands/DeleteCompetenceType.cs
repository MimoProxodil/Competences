using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Persistence;

namespace Application.CompetenceTypes.Commands
{
    public class DeleteCompetenceType
    {
        public class Command : IRequest
        {
            public required string Id { get; set; }
        }
        public class Handler(AppDbContext context) : IRequestHandler<Command>
        {
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var competenceType = await context.CompetenceTypes
                    .FindAsync([request.Id], cancellationToken)
                        ?? throw new Exception("Competence Type not found");

                context.CompetenceTypes.Remove(competenceType);
                await context.SaveChangesAsync(cancellationToken);
            }
        }

    }
}