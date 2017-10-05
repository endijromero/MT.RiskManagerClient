// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MarginTrading.RiskManagerClient.Models
{
    using MarginTrading.RiskManagerClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class MeanCoeffOverrideModel
    {
        /// <summary>
        /// Initializes a new instance of the MeanCoeffOverrideModel class.
        /// </summary>
        public MeanCoeffOverrideModel()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MeanCoeffOverrideModel class.
        /// </summary>
        public MeanCoeffOverrideModel(string asset = default(string), double? value = default(double?))
        {
            Asset = asset;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "asset")]
        public string Asset { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double? Value { get; set; }

    }
}
