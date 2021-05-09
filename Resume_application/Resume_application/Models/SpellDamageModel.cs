using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume_application.Models
{
    public class SpellDamageModel
    {
        [JsonProperty("damage_type")]
        public DndDatabaseLinkModel damageType { get; set; }
        [JsonProperty("damage_at_character_level")]
        public DiceDoneAtSpellLevel damagePerCharacterLevel { get; set; }
        [JsonProperty("damage_at_slot_level")]
        public SpellDamagePerSlotLevel damageParSlotLevel { get; set; }
    }
    public class SpellDamagePerSlotLevel
    {
        [JsonProperty("1")]
        public string One { get; set; }
        [JsonProperty("2")]
        public string Two { get; set; }
        [JsonProperty("3")]
        public string Three { get; set; }
        [JsonProperty("4")]
        public string Four { get; set; }
        [JsonProperty("5")]
        public string Five { get; set; }
        [JsonProperty("6")]
        public string Six { get; set; }
        [JsonProperty("7")]
        public string Seven { get; set; }
        [JsonProperty("8")]
        public string Eight { get; set; }
        [JsonProperty("9")]
        public string Nine { get; set; }
        [JsonProperty("10")]
        public string Ten { get; set; }
        [JsonProperty("11")]
        public string Eleven { get; set; }
        [JsonProperty("12")]
        public string Twelve { get; set; }
        [JsonProperty("13")]
        public string Thirteen { get; set; }
        [JsonProperty("14")]
        public string Fourteen { get; set; }
        [JsonProperty("15")]
        public string Fifteen { get; set; }
        [JsonProperty("16")]
        public string Sixteen { get; set; }
        [JsonProperty("17")]
        public string Seventeen { get; set; }
        [JsonProperty("18")]
        public string Eightteen { get; set; }
        [JsonProperty("19")]
        public string Nineteen { get; set; }
        [JsonProperty("20")]
        public string Twenty { get; set; }
    }
}
