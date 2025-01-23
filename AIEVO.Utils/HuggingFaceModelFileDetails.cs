using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AIEVO.Utils
{
    public class HuggingFaceModelFileDetails
    {
        /// <summary>
        /// Gets the Type of the file.
        /// </summary>
        [JsonPropertyName("type")]
        public string? Type { get; init; }

        /// <summary>
        /// Gets the size of the file.
        /// </summary>
        [JsonPropertyName("size")]
        public long Size { get; init; }

        /// <summary>
        /// Gets the path of the file.
        /// </summary>
        [JsonPropertyName("path")]
        public string? Path { get; init; }
    }
}
