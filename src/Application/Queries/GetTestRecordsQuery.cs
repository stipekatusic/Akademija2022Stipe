using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Dtos;
using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entites;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace Application.Queries
{
    public class GetTestRecordsQuery : IRequest<List<TestDto>>
    {
        public class GetTestRecordsQueryHandler : IRequestHandler<GetTestRecordsQuery, List<TestDto>>
        {
            private readonly IAcademyDbContext _context;
            private readonly ILogger<GetTestRecordsQuery> _logger;
            private readonly IMapper _mapper;
            public GetTestRecordsQueryHandler(IAcademyDbContext context, ILogger<GetTestRecordsQuery> logger, IMapper mapper)
            {
                _context = context;
                _logger = logger;
                _mapper = mapper;
            }
            public async Task<List<TestDto>> Handle(GetTestRecordsQuery request, CancellationToken cancellationToken)
            {
                _logger.LogInformation("Getting test query.");

                var test = await _context.Tests.ToListAsync(cancellationToken: cancellationToken);

                var testDto = _mapper.Map<List<TestDto>>(test);

                return testDto;
            }
        }
    }
}
