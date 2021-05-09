using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume_application.Models
{
    /// <summary>
    /// This is a small model that is used to link back to the database when applicable.
    /// In the graphql database, this is know as the AbilityScoreSkills class but I think
    /// my naming makes more sense.
    /// </summary>
    public class DndDatabaseLinkModel
    {
        /// <summary>
        /// The short name used for searching purposes
        /// </summary>
        [JsonProperty("index")]
        public string Index { get; set; }

        /// <summary>
        /// The name of the object int the database
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } 

        /// <summary>
        /// The URL to search for a person in a database. does not include the base url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
