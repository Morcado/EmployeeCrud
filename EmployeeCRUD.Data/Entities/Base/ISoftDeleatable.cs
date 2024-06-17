namespace EmployeeCRUD.Data.Entities.Base
{
    public interface ISoftDeleatable
    {
        bool IsDeleted { get; set; }
        DateTime? DeletedOnUtc { get; set; }
    }
}
