using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Application.Queries;
using Domain.Entites;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands
{
    public class InsertTestRecordCommand : IRequest<Unit>
    {
        public Test Test { get; set; }

        public class InsertTestRecordCommandHandler : IRequestHandler<InsertTestRecordCommand,Unit>
        {
            private readonly IAcademyDbContext _context;
            private readonly ILogger<GetTestRecordsQuery> _logger;

            public InsertTestRecordCommandHandler(IAcademyDbContext context, ILogger<GetTestRecordsQuery> logger)
            {
                _context = context;
                _logger = logger;
            }

            
            public async Task<Unit> Handle(InsertTestRecordCommand request, CancellationToken cancellationToken)
            {
                _logger.LogInformation("Inserting test record!");

                await _context.Tests.AddAsync(request.Test, cancellationToken);

                await _context.SaveChangesAsync(cancellationToken);

                return Unit.Value;
            }
        }
    }
}
