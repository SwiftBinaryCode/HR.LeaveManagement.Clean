namespace HR.LeaveManagement.Domain.Common
{
    //class is abstract because I dont want it to stand on its own
    //Was created because we have certian fields that are repeated throught the board.
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string? ModifiedBy { get; set; }

    }
}
