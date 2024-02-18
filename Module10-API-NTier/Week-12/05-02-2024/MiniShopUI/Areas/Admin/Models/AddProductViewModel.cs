using System.ComponentModel;
using System.Text.Json.Serialization;

namespace MiniShopUI.Areas.Admin.Models
{
    public class AddProductViewModel
    {
        [JsonPropertyName("Name")]
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }


        [JsonPropertyName("Properties")]
        [DisplayName("Özellikler")]
        public string Properties { get; set; }


        [JsonPropertyName("Price")]
        [DisplayName("Fiyat")]
        public int Price { get; set; }

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
        public List<int> CategoryIds { get; set; }

        [JsonIgnore]
        [DisplayName("Kategori Seç")]
        public List<CategoryViewModel> CategoryList { get; set; }
    }
}
