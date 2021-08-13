using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace TierThree.Model
{
    public class UserModel
    {
        [Key]
        [JsonPropertyName("id")]
        public int userId { get; set; }

        [Required]
        [JsonPropertyName("username")]
        public string userName;

        [Required] [JsonPropertyName("Password")]
        public string password;

        [JsonPropertyName("Address")] public string address;

        [Required] [JsonPropertyName("Email")] public string email;

        [JsonPropertyName("Dob")] public string dob;

        public override string ToString()
        {
            return userId + ", " + userName;
        }
    }
}