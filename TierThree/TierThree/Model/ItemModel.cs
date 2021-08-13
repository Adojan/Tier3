using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TierThree.Model
{
    public class ItemModel
    {
        [Key]
        [JsonPropertyName("id")]
        public int itemId { get; set; }

        [Required]
        [JsonPropertyName("itemname")]
        public string itemName;

        [Required] [JsonPropertyName("seller")]
        public string Seller;

        [JsonPropertyName("description")] public string Description;

        [Required] [JsonPropertyName("price")] public string Price;

        [JsonPropertyName("dob")] public string Dob;

        public override string ToString()
        {
            return itemId + ", " + itemName;
        }
    }
}