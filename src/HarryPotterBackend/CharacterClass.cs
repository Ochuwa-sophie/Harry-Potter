using System.Text.Json;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace HarryPotter
    {
        public class CharacterClass
        {
            [Required]
            public CharacterList Character { get; set; }

        }
        // public class jsonresponse
        // {
        //     CharacterClass = JsonSerializer.Deserialize<CharacterListWithPOCOs>(jsonString);

        // }
    }
