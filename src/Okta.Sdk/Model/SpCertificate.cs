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
    /// SpCertificate
    /// </summary>
    [DataContract(Name = "SpCertificate")]
    
    public partial class SpCertificate : IEquatable<SpCertificate>
    {
        
        /// <summary>
        /// Gets or Sets X5c
        /// </summary>
        [DataMember(Name = "x5c", EmitDefaultValue = true)]
        public List<string> X5c { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpCertificate {\n");
            sb.Append("  X5c: ").Append(X5c).Append("\n");
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
            return this.Equals(input as SpCertificate);
        }

        /// <summary>
        /// Returns true if SpCertificate instances are equal
        /// </summary>
        /// <param name="input">Instance of SpCertificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpCertificate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.X5c == input.X5c ||
                    this.X5c != null &&
                    input.X5c != null &&
                    this.X5c.SequenceEqual(input.X5c)
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
                
                if (this.X5c != null)
                {
                    hashCode = (hashCode * 59) + this.X5c.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
