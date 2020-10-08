using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ComponentModel.DataAnnotations;

namespace HarryPotter {
            public class Program {
            public static void Main (string[] args) {
            
                                                    }
                                }
                                 }
    // public class Character_List
    //     {
    //         [Required]
    //         public string key { get; set; }
    //         public string name { get; set; }
    //         public string house { get; set;}
    //         public string patronus { get; set; }
    //         public string species { get; set; }
    //         public string bloodstatus { get; set; }
    //         public string role { get; set; }
    //         public string school { get; set; }
    //         public bool deathEater { get; set; }
    //         public bool dumbledoresArmy { get; set; }
    //         public bool orderOfThePhoenix { get; set; }
    //         public bool ministryOfMagic { get; set; }
    //         public string alias { get; set; }
    //         public string wand { get; set; }
    //         public string boggart { get; set; }
    //         public string animagus { get; set; }

    //     public override string ToString()
    //     {
    //         return $"{animagus}: {boggart}:{wand}:{alias}:{ministryOfMagic}:{orderOfThePhoenix}:{dumbledoresArmy}:{ key }:{name} : {house} : {patronus}:{species}: {bloodstatus} :{role}: {school}: {deathEater}:{animagus} ";
    //     }
    // }

    // class Program
    // {
    //     private static async Task Main()
    //     {
    //         using var client = new HttpClient();

    //         client.BaseAddress = new Uri("$2a$10$6LAQX.6eCDcvcBh3dEXu.eo99sB1Sr7MqgkBp9/W4jhFXvhugOKDG");
    //         client.DefaultRequestHeaders.Add("Harry Potter App", "C# console program");
    //         client.DefaultRequestHeaders.Accept.Add(
    //                 new MediaTypeWithQualityHeaderValue("application/json"));

    //         var url = "https://www.potterapi.com/v1/";
    //         HttpResponseMessage response = await client.GetAsync(url);
    //         response.EnsureSuccessStatusCode();
    //         var resp = await response.Content.ReadAsStringAsync();

    //         List<CharacterList> characterList =  JsonConvert.DeserializeObject<List<CharacterList>>(resp);
    //         characterList.ForEach(Console.WriteLine);
    //     }
    // }
