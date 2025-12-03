using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.CompetenceTypes.Commands
{
    public class EditCompetenceType
    {
        public class Command : IRequest
        {
            public required CompetenceType CompetenceType{ get; set; }
        }

        public class Handler(AppDbContext context, IMapper mapper) : IRequestHandler<Command>
        {
            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var competenceType = await context.CompetenceTypes
                    .FindAsync([request.CompetenceType.Id], cancellationToken) 
                        ?? throw new Exception("Competence Type not found");

                mapper.Map(request.CompetenceType, competenceType);
                await context.SaveChangesAsync(cancellationToken);
            }
        }
    }
}