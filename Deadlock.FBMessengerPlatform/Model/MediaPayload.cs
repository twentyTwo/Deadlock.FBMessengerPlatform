﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deadlock.FBMessengerPlatform.Model
{
    public class MediaPayload : IPayload
    {
        /// <summary>
        /// URL of media
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
