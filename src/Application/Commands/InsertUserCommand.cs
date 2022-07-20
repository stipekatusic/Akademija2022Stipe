using System;
using Application.Common.Dtos;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Application.Common.Interfaces;
using AutoMapper;
using Domain.Entites;
using Microsoft.Extensions.Logging;

namespace Application.Commands
{
    public class InsertUserCommand : IRequest<Unit>
    {
        public UserDto UserDto { get; set; }
        public class InsertUserCommandHandler : IRequestHandler<InsertUserCommand, Unit>
        {
            private readonly IAcademyDbContext _context;
            private readonly IMapper _mapper;
            private readonly ILogger<InsertUserCommand> _logger;
            public InsertUserCommandHandler(IAcademyDbContext context, IMapper mapper, ILogger<InsertUserCommand> logger)
            {
                _context = context;
                _mapper = mapper;
                _logger = logger;
            }
            public async Task<Unit> Handle(InsertUserCommand request, CancellationToken cancellationToken)
            {
                _logger.LogInformation("Inserting user");

                try
                {
                    var user = _mapper.Map<User>(request.UserDto);

                    await _context.Users.AddAsync(user, cancellationToken);

                    await _context.SaveChangesAsync(cancellationToken);

                    return Unit.Value;
                }
                catch (Exception e)
                {
                    _logger.LogError($"Error inserting user: {e}");
                    throw;
                }
            }
        }
    }
}
