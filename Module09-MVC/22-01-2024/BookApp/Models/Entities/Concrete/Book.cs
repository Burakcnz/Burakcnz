using BookApp.Models.Entities.Abstract;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Models.Entities.Concrete
{
    public class Book : BaseEntity
    {
        [DisplayName("Kitabın Adı")]
        [Required(ErrorMessage ="Lütfen {0} alanını boş bırakmayınız.")]
        [MinLength(5,ErrorMessage ="Lütfen {0} alanına {1} karakterden uzun bir bilgi giriniz.")]
        [MaxLength(100, ErrorMessage = "Lütfen {0} alanına {1} karakterden kısa bir bilgi giriniz.\"")]
        public string Name { get; set; }

        [DisplayName("Kitabın Özeti")]
        [Required(ErrorMessage = "Lütfen {0} alanını boş bırakmayınız.")]
        [MinLength(5, ErrorMessage = "Lütfen {0} alanına {1} karakterden uzun bir bilgi giriniz.")]
        [MaxLength(1000, ErrorMessage = "Lütfen {0} alanına {1} karakterden kısa bir bilgi giriniz.\"")]

        public string Abstract { get; set; }
        public string Url { get; set; }

        [DisplayName("Kitabın Resmi")]
        [Required(ErrorMessage = "Lütfen {0} alanını boş bırakmayınız.")]
        public string ImageUrl { get; set; }

        [DisplayName("Stok Miktarı")]
        [Required(ErrorMessage = "Lütfen {0} alanını boş bırakmayınız.")]
        public int Stock { get; set; }

        [DisplayName("Fiyat")]
        [Required(ErrorMessage = "Lütfen {0} alanını boş bırakmayınız.")]
        public decimal Price { get; set; }

        [DisplayName("Sayfa Sayısı")]
        [Required(ErrorMessage = "Lütfen {0} alanını boş bırakmayınız.")]
        public int PageCount { get; set; }

        [DisplayName("Ana Sayfada Göster")]
        public bool IsHome { get; set; }
    }
}
