using PokeDex.Classes.GenerationAndVersion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokeDex.Classes
{
    public class MachineVersionDetail
    {
        [JsonPropertyName("machine")]
        public Machine Machine { get; set; }
        [JsonPropertyName("version_group")]
        public VersionGroup VersionGroup { get; set; }
    }
}
