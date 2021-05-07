using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShuftiPro.Services.Base
{
    public class ShuftiProAdditionalDataDocument
    {
        private Dictionary<string, string> _proof;

        [JsonIgnore]
        public ShuftiProAdditionalDataDocumentProof Proof { get; private set; }

        [JsonProperty("proof")]
        public Dictionary<string, string> ProofDict
        {
            get => _proof;
            set
            {
                _proof = value;
                Proof = JsonConvert.DeserializeObject<ShuftiProAdditionalDataDocumentProof>(JsonConvert.SerializeObject(ProofDict));
            }
        }
    }
}
