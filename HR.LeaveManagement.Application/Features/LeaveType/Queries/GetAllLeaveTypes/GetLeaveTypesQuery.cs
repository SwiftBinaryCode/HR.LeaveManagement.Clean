using MediatR;

namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    //IRequest needs us to specify what we I want it to return, and in this case its a list of leavetypedto
    //This query is what is going to return to the api
    //Dto is being sent back because it is optimized for the read operation
    
    public record GetLeaveTypesQuery : IRequest<List<LeaveTypeDto>>;
    
}
