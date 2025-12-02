using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;

namespace Application.CompetenceTypes.Commands
{
    public class CreateCompetenceType
    {
        public class Command : IRequest<string>
        {
            public required CompetenceType CompetenceType { get; set; }
        }
        public class Handler(AppDbContext context): IRequestHandler<Command, string>
        {
            public async Task<string> Handle(Command request, CancellationToken cancellationToken)
            {
                context.CompetenceTypes.Add(request.CompetenceType);
                await context.SaveChangesAsync(cancellationToken);
                return request.CompetenceType.Id;
            }
        }
    }
}