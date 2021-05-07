using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Resume_application.Models
{
    [JsonObject("filter")]
    public class DndSpellModel
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("area_of_effect")]
        public SpellAreaOfEffect AreaOfEffect { get; set; }

        [JsonProperty("attack_type")]
        public string AttackType { get; set; }

        [JsonProperty("casting_time")]
        public string CastingTime { get; set; }

        [JsonProperty("classes")]
        public List<DndAbilityScoreSkillsModel> Classes { get; set; }

        [JsonProperty("componets")]
        public List<string> Componets { get; set; }

        [JsonProperty("concentration")]
        public List<string> Concentration { get; set; }

        [JsonProperty("desc")]
        public List<string> Description { get; set; }

        [JsonProperty("duration")]
        public string Duration { get; set; }

        [JsonProperty("higher_level")]
        public string HigherLevel { get; set; }

        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("level")]
        public float Level { get; set; }

        [JsonProperty("material")]
        public string Material { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }

        [JsonProperty("ritual")]
        public bool Ritual { get; set; }

        [JsonProperty("school")]
        public DndAbilityScoreSkillsModel School { get; set; }

        [JsonProperty("subclasses")]
        public List<DndAbilityScoreSkillsModel> Subclasses { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonConstructor]
        public DndSpellModel() { }

    }
    
    public class SpellAreaOfEffect
    {
        [JsonProperty("size")]
        public float Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
