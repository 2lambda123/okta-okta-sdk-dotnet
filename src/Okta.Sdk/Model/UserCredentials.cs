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
    /// UserCredentials
    /// </summary>
    [DataContract(Name = "UserCredentials")]
    
    public partial class UserCredentials : IEquatable<UserCredentials>
    {
        
        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public PasswordCredential Password { get; set; }

        /// <summary>
        /// Gets or Sets Provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = true)]
        public AuthenticationProvider Provider { get; set; }

        /// <summary>
        /// Gets or Sets RecoveryQuestion
        /// </summary>
        [DataMember(Name = "recovery_question", EmitDefaultValue = true)]
        public RecoveryQuestionCredential RecoveryQuestion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserCredentials {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  RecoveryQuestion: ").Append(RecoveryQuestion).Append("\n");
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
            return this.Equals(input as UserCredentials);
        }

        /// <summary>
        /// Returns true if UserCredentials instances are equal
        /// </summary>
        /// <param name="input">Instance of UserCredentials to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserCredentials input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.RecoveryQuestion == input.RecoveryQuestion ||
                    (this.RecoveryQuestion != null &&
                    this.RecoveryQuestion.Equals(input.RecoveryQuestion))
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
                
                if (this.Password != null)
                {
                    hashCode = (hashCode * 59) + this.Password.GetHashCode();
                }
                if (this.Provider != null)
                {
                    hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                }
                if (this.RecoveryQuestion != null)
                {
                    hashCode = (hashCode * 59) + this.RecoveryQuestion.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
