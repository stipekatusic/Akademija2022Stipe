using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entites;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Application.Queries
{
    public class GetTestRecordsQuery : IRequest<List<Test>>
    {
        public class GetTestRecordsQueryHandler : IRequestHandler<GetTestRecordsQuery, List<Test>>
        {
            private readonly IAcademyDbContext _context;
            private readonly ILogger<GetTestRecordsQuery> _logger;
            public GetTestRecordsQueryHandler(IAcademyDbContext context, ILogger<GetTestRecordsQuery> logger)
            {
                _context = context;
                _logger = logger;
            }
            public async Task<List<Test>> Handle(GetTestRecordsQuery request, CancellationToken cancellationToken)
            {
                _logger.LogInformation("Getting test query.");

                return await _context.Tests.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}
