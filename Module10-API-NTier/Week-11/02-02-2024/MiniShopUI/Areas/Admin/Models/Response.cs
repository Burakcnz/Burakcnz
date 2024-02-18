using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.Json.Serialization;

namespace MiniShopUI.Areas.Admin.Models
{
    public class Response<T>
    {
        [JsonPropertyName("Data")]
        public T Data { get; set; }

        [JsonPropertyName("Error")]
        public string Error { get; set; }

        [JsonPropertyName("ItemCount")]
        public int ItemCount { get; set; }
    }
}
