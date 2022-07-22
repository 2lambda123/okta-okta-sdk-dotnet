/*
 * Okta API
 *
 * Allows customers to easily access the Okta API
 *
 * The version of the OpenAPI document: 3.0.0
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
    /// ApplicationCredentials
    /// </summary>
    [DataContract(Name = "ApplicationCredentials")]
    public partial class ApplicationCredentials : IEquatable<ApplicationCredentials>
    {
        
        /// <summary>
        /// Gets or Sets Signing
        /// </summary>
        [DataMember(Name = "signing", EmitDefaultValue = false)]
        public ApplicationCredentialsSigning Signing { get; set; }

        /// <summary>
        /// Gets or Sets UserNameTemplate
        /// </summary>
        [DataMember(Name = "userNameTemplate", EmitDefaultValue = false)]
        public ApplicationCredentialsUsernameTemplate UserNameTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationCredentials {\n");
            sb.Append("  Signing: ").Append(Signing).Append("\n");
            sb.Append("  UserNameTemplate: ").Append(UserNameTemplate).Append("\n");
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
            return this.Equals(input as ApplicationCredentials);
        }

        /// <summary>
        /// Returns true if ApplicationCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationCredentials input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Signing == input.Signing ||
                    (this.Signing != null &&
                    this.Signing.Equals(input.Signing))
                ) && 
                (
                    this.UserNameTemplate == input.UserNameTemplate ||
                    (this.UserNameTemplate != null &&
                    this.UserNameTemplate.Equals(input.UserNameTemplate))
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
                if (this.Signing != null)
                {
                    hashCode = (hashCode * 59) + this.Signing.GetHashCode();
                }
                if (this.UserNameTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.UserNameTemplate.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
