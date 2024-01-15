using BookApp.Models.Entitys.Abstract;

namespace BookApp.Models.Entitys.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
    }
}
