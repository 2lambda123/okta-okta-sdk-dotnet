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
    /// RecoveryQuestionCredential
    /// </summary>
    [DataContract(Name = "RecoveryQuestionCredential")]
    
    public partial class RecoveryQuestionCredential : IEquatable<RecoveryQuestionCredential>
    {
        
        /// <summary>
        /// Gets or Sets Answer
        /// </summary>
        [DataMember(Name = "answer", EmitDefaultValue = true)]
        public string Answer { get; set; }

        /// <summary>
        /// Gets or Sets Question
        /// </summary>
        [DataMember(Name = "question", EmitDefaultValue = true)]
        public string Question { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecoveryQuestionCredential {\n");
            sb.Append("  Answer: ").Append(Answer).Append("\n");
            sb.Append("  Question: ").Append(Question).Append("\n");
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
            return this.Equals(input as RecoveryQuestionCredential);
        }

        /// <summary>
        /// Returns true if RecoveryQuestionCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of RecoveryQuestionCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecoveryQuestionCredential input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Answer == input.Answer ||
                    (this.Answer != null &&
                    this.Answer.Equals(input.Answer))
                ) && 
                (
                    this.Question == input.Question ||
                    (this.Question != null &&
                    this.Question.Equals(input.Question))
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
                
                if (this.Answer != null)
                {
                    hashCode = (hashCode * 59) + this.Answer.GetHashCode();
                }
                if (this.Question != null)
                {
                    hashCode = (hashCode * 59) + this.Question.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
