using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JsonApiSerializer.JsonApi
{
    /// <summary>
    /// Represents the JsonApi version information.
    /// </summary>
    public class VersionInfo
    {
        public string Version { get; set; }

        public Meta Meta { get; set; }
    }
}
