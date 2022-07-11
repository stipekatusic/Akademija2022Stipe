using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using Domain.Entites;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace Application.Queries
{
    public class GetTestRecordsQuery : IRequest<List<Test>>
    {
        public class GetTestRecordsQueryHandler : IRequestHandler<GetTestRecordsQuery, List<Test>>
        {
            private readonly IAcademyDbContext _context;
            public GetTestRecordsQueryHandler(IAcademyDbContext context)
            {
                _context = context;
            }
            public async Task<List<Test>> Handle(GetTestRecordsQuery request, CancellationToken cancellationToken)
            {
                return await _context.Tests.ToListAsync(cancellationToken: cancellationToken);
            }
        }
    }
}
