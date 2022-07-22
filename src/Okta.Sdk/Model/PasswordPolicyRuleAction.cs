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
    /// PasswordPolicyRuleAction
    /// </summary>
    [DataContract(Name = "PasswordPolicyRuleAction")]
    public partial class PasswordPolicyRuleAction : IEquatable<PasswordPolicyRuleAction>
    {
        
        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public string Access { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PasswordPolicyRuleAction {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
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
            return this.Equals(input as PasswordPolicyRuleAction);
        }

        /// <summary>
        /// Returns true if PasswordPolicyRuleAction instances are equal
        /// </summary>
        /// <param name="input">Instance of PasswordPolicyRuleAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PasswordPolicyRuleAction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Access == input.Access ||
                    (this.Access != null &&
                    this.Access.Equals(input.Access))
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
                if (this.Access != null)
                {
                    hashCode = (hashCode * 59) + this.Access.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
