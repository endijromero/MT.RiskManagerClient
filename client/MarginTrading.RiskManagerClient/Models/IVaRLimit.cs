// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MarginTrading.RiskManagerClient.Models
{
    using MarginTrading.RiskManagerClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IVaRLimit
    {
        /// <summary>
        /// Initializes a new instance of the IVaRLimit class.
        /// </summary>
        public IVaRLimit()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IVaRLimit class.
        /// </summary>
        public IVaRLimit(string assetId = default(string), string counterPartyId = default(string), double? softLimit = default(double?), double? hardLimit = default(double?))
        {
            AssetId = assetId;
            CounterPartyId = counterPartyId;
            SoftLimit = softLimit;
            HardLimit = hardLimit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assetId")]
        public string AssetId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "counterPartyId")]
        public string CounterPartyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "softLimit")]
        public double? SoftLimit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardLimit")]
        public double? HardLimit { get; set; }

    }
}
