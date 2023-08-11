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
    /// SamlApplicationSettingsApplication
    /// </summary>
    [DataContract(Name = "SamlApplicationSettingsApplication")]
    
    public partial class SamlApplicationSettingsApplication : IEquatable<SamlApplicationSettingsApplication>
    {
        
        /// <summary>
        /// Gets or Sets AcsUrl
        /// </summary>
        [DataMember(Name = "acsUrl", EmitDefaultValue = true)]
        public string AcsUrl { get; set; }

        /// <summary>
        /// Gets or Sets AudRestriction
        /// </summary>
        [DataMember(Name = "audRestriction", EmitDefaultValue = true)]
        public string AudRestriction { get; set; }

        /// <summary>
        /// Gets or Sets BaseUrl
        /// </summary>
        [DataMember(Name = "baseUrl", EmitDefaultValue = true)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SamlApplicationSettingsApplication {\n");
            sb.Append("  AcsUrl: ").Append(AcsUrl).Append("\n");
            sb.Append("  AudRestriction: ").Append(AudRestriction).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
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
            return this.Equals(input as SamlApplicationSettingsApplication);
        }

        /// <summary>
        /// Returns true if SamlApplicationSettingsApplication instances are equal
        /// </summary>
        /// <param name="input">Instance of SamlApplicationSettingsApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SamlApplicationSettingsApplication input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcsUrl == input.AcsUrl ||
                    (this.AcsUrl != null &&
                    this.AcsUrl.Equals(input.AcsUrl))
                ) && 
                (
                    this.AudRestriction == input.AudRestriction ||
                    (this.AudRestriction != null &&
                    this.AudRestriction.Equals(input.AudRestriction))
                ) && 
                (
                    this.BaseUrl == input.BaseUrl ||
                    (this.BaseUrl != null &&
                    this.BaseUrl.Equals(input.BaseUrl))
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
                
                if (this.AcsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.AcsUrl.GetHashCode();
                }
                if (this.AudRestriction != null)
                {
                    hashCode = (hashCode * 59) + this.AudRestriction.GetHashCode();
                }
                if (this.BaseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BaseUrl.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
