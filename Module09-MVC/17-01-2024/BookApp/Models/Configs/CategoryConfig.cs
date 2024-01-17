using BookApp.Models.Entitys.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookApp.Models.Configs
{
    //bu class category entitisinin özelliklerini ayarlamak amacıyla yaratılmıştır.
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(c => c.Name).IsRequired().HasMaxLength(100);
            builder.HasKey(c => c.ID);//primary key
            builder.Property(c => c.ID).ValueGeneratedOnAdd();//Indentity Specification
            builder.Property(c => c.CreatedDate).HasDefaultValueSql("getdate()");
            builder.Property(c => c.ModifiedDate).HasDefaultValueSql("getdate()");
            builder.Property(c => c.Description).IsRequired().HasMaxLength(100);
            builder.Property(c => c.URL).IsRequired().HasMaxLength(100);
            builder.ToTable("Categories");

            builder.HasData(
                new Category
                {
                    ID = 1,
                    Name = "Genel",
                    Description = "Genel kategorisine sahip ve kategorisiz kitaplar burada olacak",
                    URL = "genel"
                },
                new Category
                {
                    ID = 2,
                    Name = "Bilim Kurgu",
                    Description = "Bilim kurgu kitapları",
                    URL = "bilim-kurgu"
                }, new Category
                {
                    ID = 3,
                    Name = "Distopya",
                    Description = "Distopik kitaplar",
                    URL = "distopya"
                }, new Category
                {
                    ID = 4,
                    Name = "Bilim Ve Mühendislik",
                    Description = "Bilim ve Mühendislik Kitapları",
                    URL = "bilim-ve-muhendislik"
                }, new Category
                {
                    ID = 5,
                    Name = "Dünya Tarihi",
                    Description = "Dünya tarihi ile ilgili kitaplar",
                    URL = "dunya-tarihi"
                }
                );

        }
    }
}
