﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume_application.Models
{
    public class DndAbilityScoreSkillsModel
    {
        [JsonProperty("index")]
        public string Index { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } 

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
