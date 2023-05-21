namespace HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes
{
    //only contains fields that are absolutley necesarry to carry out the get leave types.
    //only defines the exact fields that are needed to be able to map to and from for this particular behvior,
    //which is getting all leave types.
    public class LeaveTypeDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public int DefaultDays { get; set; }
    }
}
