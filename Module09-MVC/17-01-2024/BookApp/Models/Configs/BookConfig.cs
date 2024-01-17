using BookApp.Models.Entitys.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.Models.Configs
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.ID);
            builder.Property(b => b.ID).ValueGeneratedOnAdd();
            builder.Property(b => b.Name).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Abstract).IsRequired().HasMaxLength(100);
            builder.Property(b => b.ImageURL).IsRequired();
            builder.Property(b => b.URL).IsRequired().HasMaxLength(100);
            builder.Property(b => b.CreatedDate).HasDefaultValueSql("getdate()");
            builder.Property(b => b.ModifiedDate).HasDefaultValueSql("getdate()");
            builder.ToTable("Books");
            builder.HasData(
                new Book
                {
                    ID = 1,
                    Name="Öğrenci Kız",
                    Abstract="",
                    URL="ogrenci-kiz-1",
                    ImageURL="ogrenci-kiz-1.png",
                    Price=145,
                    PageCount=99,
                    Stock=120,
                    IsHome=true
                },
                new Book
                {
                    ID = 2,
                    Name = "Homo Deus",
                    Abstract = "",
                    URL = "homo-deus-2",
                    ImageURL = "homo-deus-2.png",
                    Price = 215,
                    PageCount = 299,
                    Stock = 20,
                    IsHome = true
                },
                new Book
                {
                    ID = 3,
                    Name = "Efendi Uyanıyor",
                    Abstract = "",
                    URL = "efendi-uyaniyor-3",
                    ImageURL = "efendi-uyaniyor-3.png",
                    Price = 185,
                    PageCount = 316,
                    Stock = 78,
                    IsHome = false
                },
                new Book
                {
                    ID = 4,
                    Name = "Evrenin Sonundaki Restoran",
                    Abstract = "",
                    URL = "evrenin-sonundaki-restoran",
                    ImageURL = "evrenin-sonundaki-restoran-3.png",
                    Price = 153,
                    PageCount = 149,
                    Stock = 76,
                    IsHome = true
                },
                new Book
                {
                    ID = 5,
                    Name = "Beyaz Kurt",
                    Abstract = "",
                    URL = "beyaz-kurt",
                    ImageURL = "beyaz-kurt-5.png",
                    Price = 223,
                    PageCount = 123,
                    Stock = 156,
                    IsHome = true
                }
                );

        }
    }
}
