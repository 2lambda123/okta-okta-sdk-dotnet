/*
 * Okta Admin Management
 *
 * Allows customers to easily access the Okta Management APIs
 *
 * The version of the OpenAPI document: 5.1.0
 * Contact: devex-public@okta.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Okta.Sdk.Client.OpenAPIDateConverter;

namespace Okta.Sdk.Model
{
    /// <summary>
    /// Template: ModelGeneric
    /// NetworkZoneLocation
    /// </summary>
    [DataContract(Name = "NetworkZoneLocation")]
    
    public partial class NetworkZoneLocation : IEquatable<NetworkZoneLocation>
    {
        
        /// <summary>
        /// Format of the country value: length 2 [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code. Do not use continent codes as they are treated as generic codes for undesignated countries.
        /// </summary>
        /// <value>Format of the country value: length 2 [ISO-3166-1](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code. Do not use continent codes as they are treated as generic codes for undesignated countries.</value>
        [DataMember(Name = "country", EmitDefaultValue = true)]
        public string Country { get; set; }

        /// <summary>
        /// Format of the region value (optional): region code [ISO-3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) appended to country code (&#x60;countryCode-regionCode&#x60;), or &#x60;null&#x60; if empty. Do not use continent codes as they are treated as generic codes for undesignated regions.
        /// </summary>
        /// <value>Format of the region value (optional): region code [ISO-3166-2](https://en.wikipedia.org/wiki/ISO_3166-2) appended to country code (&#x60;countryCode-regionCode&#x60;), or &#x60;null&#x60; if empty. Do not use continent codes as they are treated as generic codes for undesignated regions.</value>
        [DataMember(Name = "region", EmitDefaultValue = true)]
        public string Region { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetworkZoneLocation {\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NetworkZoneLocation);
        }

        /// <summary>
        /// Returns true if NetworkZoneLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of NetworkZoneLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetworkZoneLocation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
