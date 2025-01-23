using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AIEVO.Utils
{
    [JsonSourceGenerationOptions(WriteIndented = true, AllowTrailingCommas = true)]
    [JsonSerializable(typeof(List<GitHubModelFileDetails>))]
    [JsonSerializable(typeof(List<HuggingFaceModelFileDetails>))]
    internal partial class SourceGenerationContext : JsonSerializerContext
    {
    }
}
