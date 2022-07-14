using System;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using Application.Queries;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entites;

namespace Application.Commands
{
    public class InsertTestRecordCommand : IRequest<Unit>
    {
        public TestDto TestDto { get; set; }

        public class InsertTestRecordCommandHandler : IRequestHandler<InsertTestRecordCommand,Unit>
        {
            private readonly IAcademyDbContext _context;
            private readonly ILogger<GetTestRecordsQuery> _logger;
            private readonly IMapper _mapper;

            public InsertTestRecordCommandHandler(IAcademyDbContext context, ILogger<GetTestRecordsQuery> logger, IMapper mapper)
            {
                _context = context;
                _logger = logger;
                _mapper = mapper;
            }

            
            public async Task<Unit> Handle(InsertTestRecordCommand request, CancellationToken cancellationToken)
            {
                _logger.LogInformation("Inserting test record!");

                try
                {
                    var test = _mapper.Map<Test>(request.TestDto);

                    await _context.Tests.AddAsync(test, cancellationToken);

                    await _context.SaveChangesAsync(cancellationToken);
                }
                catch (Exception e)
                {
                    _logger.LogError($"Error inserting test record: {e}");
                    throw;
                }
                
                return Unit.Value;
            }
        }
    }
}
