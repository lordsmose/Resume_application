using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Resume_application.Models
{

    /// <summary>
    /// This is the model pull the Spells query into. Not all of these field need to be filled, but will
    /// allow for deserialization of the json object. Note that every field in this model is made to be
    /// nullable to be easy set to be skipped during serialization to json.
    /// </summary>
    public class DndSpellModel
    {
        /// <summary>
        /// This is the Id for the database, not to be every really seen by the end user but could have
        /// some use.
        /// </summary>
        [JsonProperty("_id")]
        public string Id { get; set; }

        /// <summary>
        /// This is the area of effect of the spell, it is stored in a special object of which the class is
        /// in this cs file. The reason for the class being in this cs file being this is the only place that
        /// this "type" (the graphql name for the json) is only found in this one query. Might consider moving
        /// this out into a sperate file later.
        /// </summary>
        [JsonProperty("area_of_effect")]
        public SpellAreaOfEffect AreaOfEffect { get; set; }

        /// <summary>
        /// This is the type of attack, can be ranged, melee, or null.
        /// </summary>
        [JsonProperty("attack_type")]
        public string AttackType { get; set; }

        /// <summary>
        /// The time it takes to caste, can be any any span of time, an action, or a bonus action amount.
        /// </summary>
        [JsonProperty("casting_time")]
        public string CastingTime { get; set; }

        /// <summary>
        /// This contants a list of all the classes that can use this spell. This object in this list contain
        /// the name, the Id of the class in the database, and the url for the full information about it in the
        /// database.
        /// </summary>
        [JsonProperty("classes")]
        public List<DndDatabaseLinkModel> Classes { get; set; }

        /// <summary>
        /// This is a list of all the componets to cast the spell. They are repersented by three letter: "V", 
        /// "S", "M". "V" meaning Verbal i.e. The caster must say something to cast the spell. "S" being Somatic 
        /// i.e. the caster must make some gesture to cast the spell. "M" being Material i.e. the caster most have
        /// some particular item or materials to cast the spell.
        /// </summary>
        [JsonProperty("componets")]
        public List<string> Componets { get; set; }

        /// <summary>
        /// This states if the spell requires concentration to keep up i.e. You can only have one spell that requires
        /// concentration at a time, if you hit while the spell is still active you have to make a saving thorw to
        /// see if the spell is active, and being incapacitatd or killed makes the spell go away. 
        /// </summary>
        [JsonProperty("concentration")]
        public bool? Concentration { get; set; }

        /// <summary>
        /// This states the Damage the spell does, null if the spell does not do damage. If the spell the does do 
        /// damage it contains the damage type done, the damage done at each spell slot level used, and the damage
        /// done at each level of the character. desciptions of each and be found in the classes repective
        /// documentation.
        /// </summary>
        [JsonProperty("damage")]
        public SpellDamageModel Damage { get; set; }

        /// <summary>
        /// A discription of what the spell does. 
        /// </summary>
        [JsonProperty("desc")]
        public List<string> Description { get; set; }

        /// <summary>
        /// The max amount of time a spell can last. Can be a Instantaneous or continue until dispelled.
        /// </summary>
        [JsonProperty("duration")]
        public string Duration { get; set; }

        /// <summary>
        /// The amount of healing per spell slot expended to us cast said spell.
        /// </summary>
        [JsonProperty("heal_at_slot_level")]
        public DiceDoneAtSpellLevel HealAtSlotLevel { get; set; }

        /// <summary>
        /// A brief discription of what happens if you cast this spell by expected a higher lever spell slot
        /// </summary>
        [JsonProperty("higher_level")]
        public string HigherLevel { get; set; }

        /// <summary>
        /// short hand name for the spell for searching, again not really needed to show the user but might
        /// have some uses down the line.
        /// </summary>
        [JsonProperty("index")]
        public string Index { get; set; }

        /// <summary>
        /// The lowest level spell slot that must be expended to cast the spell.
        /// </summary>
        [JsonProperty("level")]
        public float? Level { get; set; }

        /// <summary>
        /// The specific material needed to cast the spell. If this is null there are no material needed to 
        /// cast the spell.
        /// </summary>
        [JsonProperty("material")]
        public string Material { get; set; }

        /// <summary>
        /// The name of the spell
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The range that the spell. If it is a ranged spell the distanct is normal given in imperail units.
        /// </summary>
        [JsonProperty("range")]
        public string Range { get; set; }

        /// <summary>
        /// States whether or not the spell can be ritualily cast.
        /// </summary>
        [JsonProperty("ritual")]
        public bool? Ritual { get; set; }

        /// <summary>
        /// A link to the database of each type of school the spell is from. These types are: Abjuration, 
        /// Conjuration, Divination, Enchantment, Evocation, Illusion, Necromancy, and Transmutation.
        /// Look at the databased discrption of each school to learn more about them.
        /// </summary>
        [JsonProperty("school")]
        public DndDatabaseLinkModel School { get; set; }

        /// <summary>
        /// List of all the spell classes that can have access to this spell, mostly there if there is
        /// only a few specific subclasses that have access to the spell in a given class.
        /// </summary>
        [JsonProperty("subclasses")]
        public List<DndDatabaseLinkModel> Subclasses { get; set; }

        /// <summary>
        /// The URL to send the get request to to the main database to get this specific spell. The main
        /// domain name is left out.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

    }
    
    public class SpellAreaOfEffect
    {
        [JsonProperty("size")]
        public float Size { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
