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
    public class InsertTestRecordCommand : IRequest<Test>
    {
        public TestDto TestDto { get; set; }

        public class InsertTestRecordCommandHandler : IRequestHandler<InsertTestRecordCommand,Test>
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

            
            public async Task<Test> Handle(InsertTestRecordCommand request, CancellationToken cancellationToken)
            {
                _logger.LogInformation("Inserting test record!");

                try
                {
                    var test = _mapper.Map<Test>(request.TestDto);

                    await _context.Tests.AddAsync(test, cancellationToken);

                    await _context.SaveChangesAsync(cancellationToken);

                    //test for reservations

                    var user = new User();
                    user.FirstName = "Stipe";
                    user.LastName = "Katusic";

                    await _context.Users.AddAsync(user, cancellationToken);

                    var room = new Room();
                    room.Name = "Galactica";

                    await _context.Rooms.AddAsync(room, cancellationToken);

                    var reservation = new Reservation();
                    reservation.User = user;
                    reservation.Room = room;

                    await _context.Reservations.AddAsync(reservation, cancellationToken);

                    await _context.SaveChangesAsync(cancellationToken);

                    return test;
                }
                catch (Exception e)
                {
                    _logger.LogError($"Error inserting test record: {e}");
                    throw;
                }
                
            }
        }
    }
}
