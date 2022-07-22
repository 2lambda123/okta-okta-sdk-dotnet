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
    /// PolicySubject
    /// </summary>
    [DataContract(Name = "PolicySubject")]
    public partial class PolicySubject : IEquatable<PolicySubject>
    {
        
        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public string Filter { get; set; }

        /// <summary>
        /// Gets or Sets Format
        /// </summary>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public List<string> Format { get; set; }

        /// <summary>
        /// Gets or Sets MatchAttribute
        /// </summary>
        [DataMember(Name = "matchAttribute", EmitDefaultValue = false)]
        public string MatchAttribute { get; set; }

        /// <summary>
        /// Gets or Sets MatchType
        /// </summary>
        [DataMember(Name = "matchType", EmitDefaultValue = false)]
        public string MatchType { get; set; }

        /// <summary>
        /// Gets or Sets UserNameTemplate
        /// </summary>
        [DataMember(Name = "userNameTemplate", EmitDefaultValue = false)]
        public PolicyUserNameTemplate UserNameTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PolicySubject {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  MatchAttribute: ").Append(MatchAttribute).Append("\n");
            sb.Append("  MatchType: ").Append(MatchType).Append("\n");
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
            return this.Equals(input as PolicySubject);
        }

        /// <summary>
        /// Returns true if PolicySubject instances are equal
        /// </summary>
        /// <param name="input">Instance of PolicySubject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicySubject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
                ) && 
                (
                    this.Format == input.Format ||
                    this.Format != null &&
                    input.Format != null &&
                    this.Format.SequenceEqual(input.Format)
                ) && 
                (
                    this.MatchAttribute == input.MatchAttribute ||
                    (this.MatchAttribute != null &&
                    this.MatchAttribute.Equals(input.MatchAttribute))
                ) && 
                (
                    this.MatchType == input.MatchType ||
                    (this.MatchType != null &&
                    this.MatchType.Equals(input.MatchType))
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
                }
                if (this.Format != null)
                {
                    hashCode = (hashCode * 59) + this.Format.GetHashCode();
                }
                if (this.MatchAttribute != null)
                {
                    hashCode = (hashCode * 59) + this.MatchAttribute.GetHashCode();
                }
                if (this.MatchType != null)
                {
                    hashCode = (hashCode * 59) + this.MatchType.GetHashCode();
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