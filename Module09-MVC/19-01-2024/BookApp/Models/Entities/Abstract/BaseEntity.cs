namespace BookApp.Models.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; }
    }
}
