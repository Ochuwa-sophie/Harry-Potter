using System.Text.Json;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

namespace HarryPotter
    {
        public class CharacterList
        {
            [Required]
            public string key { get; set; }
            public string name { get; set; }
            public string house { get; set;}
            public string patronus { get; set; }
            public string species { get; set; }
            public string bloodstatus { get; set; }
            public string role { get; set; }
            public string school { get; set; }
            public bool deathEater { get; set; }
            public bool dumbledoresArmy { get; set; }
            public bool orderOfThePhoenix { get; set; }
            public bool ministryOfMagic { get; set; }
            public string alias { get; set; }
            public string wand { get; set; }
            public string boggart { get; set; }
            public string animagus { get; set; }
        }
    }
