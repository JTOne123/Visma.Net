﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ONIT.VismaNetApi.Lib;

namespace ONIT.VismaNetApi.Models
{
    public class CustomerVatZone : DescriptiveDto
    {
        public string defaultVatCategory { get; set; }

        public NumberDescription defaultTaxCategory { get; set; }

        [JsonProperty]
        public JObject extras { get; private set; }

        [JsonProperty]
        public string errorInfo { get; private set; }

        [JsonProperty]
        public MetaData metadata { get; private set; }
    }
}