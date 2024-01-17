namespace BookApp.Models.Entitys.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime ModifiedDate { get; set; } = DateTime.Now;
        public virtual bool IsActive { get; set; } = true;
        public virtual bool IsDeleted { get; set; }
    }
}
