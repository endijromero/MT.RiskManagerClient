// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MarginTrading.RiskManagerClient.Models
{
    using MarginTrading.RiskManagerClient;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// API DTO for setting overriding mean coefficient value
    /// </summary>
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
        /// <param name="value">Coefficient value</param>
        /// <param name="asset">Instrument identifier</param>
        public MeanCoeffOverrideModel(double value, string asset = default(string))
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
        /// Gets or sets instrument identifier
        /// </summary>
        [JsonProperty(PropertyName = "asset")]
        public string Asset { get; set; }

        /// <summary>
        /// Gets or sets coefficient value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
