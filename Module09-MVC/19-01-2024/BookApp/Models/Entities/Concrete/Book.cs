using BookApp.Models.Entities.Abstract;

namespace BookApp.Models.Entities.Concrete
{
    public class Book : BaseEntity
    {
        public string Name { get; set; }
        public string Abstract { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int PageCount { get; set; }
        public bool IsHome { get; set; }
    }
}
