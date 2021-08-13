using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TierThree.Model
{
    public class AdministratorModel
    {
        [Key]
        [JsonPropertyName("adminId")]
        public int adminId { get; set; }

        [Required]
        [JsonPropertyName("name")]
        public string Name;

        [Required] [JsonPropertyName("password")]
        public string Password;

        [JsonPropertyName("address")] public string Address;

        [Required] [JsonPropertyName("adminUsername")] public string adminUsername;

        [JsonPropertyName("dob")] public string Dob;

        [Required] [JsonPropertyName("email")] public string Email;

        public override string ToString()
        {
            return adminId + ", " + adminUsername;
        }
    }
}