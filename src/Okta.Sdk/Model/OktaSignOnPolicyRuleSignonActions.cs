/*
 * Okta Management
 *
 * Allows customers to easily access the Okta Management APIs
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
    /// OktaSignOnPolicyRuleSignonActions
    /// </summary>
    [DataContract(Name = "OktaSignOnPolicyRuleSignonActions")]
    
    public partial class OktaSignOnPolicyRuleSignonActions : IEquatable<OktaSignOnPolicyRuleSignonActions>
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        
        public PolicyAccess Access { get; set; }

        /// <summary>
        /// Gets or Sets FactorPromptMode
        /// </summary>
        [DataMember(Name = "factorPromptMode", EmitDefaultValue = false)]
        
        public OktaSignOnPolicyFactorPromptMode FactorPromptMode { get; set; }
        
        /// <summary>
        /// Gets or Sets FactorLifetime
        /// </summary>
        [DataMember(Name = "factorLifetime", EmitDefaultValue = false)]
        public int FactorLifetime { get; set; }

        /// <summary>
        /// Gets or Sets RememberDeviceByDefault
        /// </summary>
        [DataMember(Name = "rememberDeviceByDefault", EmitDefaultValue = true)]
        public bool RememberDeviceByDefault { get; set; }

        /// <summary>
        /// Gets or Sets RequireFactor
        /// </summary>
        [DataMember(Name = "requireFactor", EmitDefaultValue = true)]
        public bool RequireFactor { get; set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [DataMember(Name = "session", EmitDefaultValue = false)]
        public OktaSignOnPolicyRuleSignonSessionActions Session { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OktaSignOnPolicyRuleSignonActions {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  FactorLifetime: ").Append(FactorLifetime).Append("\n");
            sb.Append("  FactorPromptMode: ").Append(FactorPromptMode).Append("\n");
            sb.Append("  RememberDeviceByDefault: ").Append(RememberDeviceByDefault).Append("\n");
            sb.Append("  RequireFactor: ").Append(RequireFactor).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
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
            return this.Equals(input as OktaSignOnPolicyRuleSignonActions);
        }

        /// <summary>
        /// Returns true if OktaSignOnPolicyRuleSignonActions instances are equal
        /// </summary>
        /// <param name="input">Instance of OktaSignOnPolicyRuleSignonActions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OktaSignOnPolicyRuleSignonActions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Access == input.Access ||
                    this.Access.Equals(input.Access)
                ) && 
                (
                    this.FactorLifetime == input.FactorLifetime ||
                    this.FactorLifetime.Equals(input.FactorLifetime)
                ) && 
                (
                    this.FactorPromptMode == input.FactorPromptMode ||
                    this.FactorPromptMode.Equals(input.FactorPromptMode)
                ) && 
                (
                    this.RememberDeviceByDefault == input.RememberDeviceByDefault ||
                    this.RememberDeviceByDefault.Equals(input.RememberDeviceByDefault)
                ) && 
                (
                    this.RequireFactor == input.RequireFactor ||
                    this.RequireFactor.Equals(input.RequireFactor)
                ) && 
                (
                    this.Session == input.Session ||
                    (this.Session != null &&
                    this.Session.Equals(input.Session))
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
                hashCode = (hashCode * 59) + this.FactorLifetime.GetHashCode();
                if (this.FactorPromptMode != null)
                {
                    hashCode = (hashCode * 59) + this.FactorPromptMode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RememberDeviceByDefault.GetHashCode();
                hashCode = (hashCode * 59) + this.RequireFactor.GetHashCode();
                if (this.Session != null)
                {
                    hashCode = (hashCode * 59) + this.Session.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
