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
    /// The Feature object is used to configure application feature settings.  The only feature currently supported is &#x60;USER_PROVISIONING&#x60; for the Org2Org application type. 
    /// </summary>
    [DataContract(Name = "ApplicationFeature")]
    
    public partial class ApplicationFeature : IEquatable<ApplicationFeature>
    {
        /// <summary>
        /// Identifying name of the feature
        /// </summary>
        /// <value>Identifying name of the feature</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class NameEnum : StringEnum
        {
            /// <summary>
            /// StringEnum USERPROVISIONING for value: USER_PROVISIONING
            /// </summary>
            
            public static NameEnum USERPROVISIONING = new NameEnum("USER_PROVISIONING");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="NameEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator NameEnum(string value) => new NameEnum(value);

            /// <summary>
            /// Creates a new <see cref="Name"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public NameEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// Identifying name of the feature
        /// </summary>
        /// <value>Identifying name of the feature</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        
        public NameEnum Name { get; set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        
        public EnabledStatus Status { get; set; }
        
        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = true)]
        public ApplicationFeatureCapabilities Capabilities { get; set; }

        /// <summary>
        /// Description of the feature
        /// </summary>
        /// <value>Description of the feature</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns false as Description should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDescription()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = true)]
        public ApplicationFeatureLinks Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ApplicationFeature {\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as ApplicationFeature);
        }

        /// <summary>
        /// Returns true if ApplicationFeature instances are equal
        /// </summary>
        /// <param name="input">Instance of ApplicationFeature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApplicationFeature input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Capabilities == input.Capabilities ||
                    (this.Capabilities != null &&
                    this.Capabilities.Equals(input.Capabilities))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    this.Name.Equals(input.Name)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                
                if (this.Capabilities != null)
                {
                    hashCode = (hashCode * 59) + this.Capabilities.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
