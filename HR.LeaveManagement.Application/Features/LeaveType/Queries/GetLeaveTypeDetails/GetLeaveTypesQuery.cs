using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails
{
    //Leavetypedetails query that expecting an id as a parameter.
    //Its also inheriting from IRequest and it returns a LeaveTypeDetailsDto
    public record GetLeaveTypeDetailsQuery(int Id) : IRequest<LeaveTypeDetailsDto>;
}
