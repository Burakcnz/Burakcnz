using BookApp.Models.Entitys.Abstract;

namespace BookApp.Models.Entitys.Concrete
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Abstract { get; set; }
        public string URL { get; set; }
        public string ImageURL { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public bool IsHome { get; set; }
    }
}
