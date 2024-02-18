using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MiniShopUI.Areas.Admin.Models
{
    public class AddProductViewModel
    {
        [JsonPropertyName("Name")]
        [DisplayName("Ürün Adı")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        [MinLength(5, ErrorMessage ="{0} alanına uzunluğu {1} karakterden daha kısa bir bilgi girilemez.")]
        [MaxLength(100,ErrorMessage ="{0} alanına {1} karakterden daha uzun bir bilgi girilemez.")]
        public string Name { get; set; }


        [JsonPropertyName("Properties")]
        [DisplayName("Özellikler")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        [MinLength(10, ErrorMessage = "{0} alanına uzunluğu {1} karakterden daha kısa bir bilgi girilemez.")]
        [MaxLength(500, ErrorMessage = "{0} alanına {1} karakterden daha uzun bir bilgi girilemez.")]
        public string Properties { get; set; }


        [JsonPropertyName("Price")]
        [DisplayName("Fiyat")]
        [Required(ErrorMessage = "{0} alanı boş bırakılamaz.")]
        public decimal? Price { get; set; }

        [JsonPropertyName("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("Url")]
        public string Url { get; set; }


        [JsonPropertyName("IsActive")]
        [DisplayName("Aktif")]
        public bool IsActive { get; set; }


        [JsonPropertyName("IsHome")]
        [DisplayName("Ana Sayfa")]
        public bool IsHome { get; set; }

        [JsonPropertyName("CategoryIds")]
        public List<int> CategoryIds { get; set; } = new List<int>();

        [JsonIgnore]
        [DisplayName("Kategori Seç")]
        public List<CategoryViewModel> CategoryList { get; set; }
    }
}
