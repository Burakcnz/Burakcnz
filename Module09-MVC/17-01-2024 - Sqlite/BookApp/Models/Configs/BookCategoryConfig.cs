using BookApp.Models.Entitys.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.Models.Configs
{
    public class BookCategoryConfig : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasKey(bc => new { bc.BookID, bc.CategoryID });

            builder.ToTable("BookCategories");
            builder.HasData(
                new BookCategory { BookID = 1, CategoryID = 1 },
                new BookCategory { BookID = 1, CategoryID = 2 },
                new BookCategory { BookID = 1, CategoryID = 3 },

                new BookCategory { BookID = 2, CategoryID = 3 },
                new BookCategory { BookID = 2, CategoryID = 5 },


                new BookCategory { BookID = 3, CategoryID = 2 },
                new BookCategory { BookID = 3, CategoryID = 4 },
                new BookCategory { BookID = 3, CategoryID = 5 },

                new BookCategory { BookID = 4, CategoryID = 3 },

                new BookCategory { BookID = 5, CategoryID = 1 },
                new BookCategory { BookID = 5, CategoryID = 2 },
                new BookCategory { BookID = 5, CategoryID = 4 },
                new BookCategory { BookID = 5, CategoryID = 5 }

                );
        }
    }
}
