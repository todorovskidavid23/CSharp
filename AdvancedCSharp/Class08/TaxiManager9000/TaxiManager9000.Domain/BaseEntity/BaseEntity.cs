namespace TaxiManager9000.Domain.BaseEntity;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public DateTime CreatedData { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;



}
