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
    /// GroupSchema
    /// </summary>
    [DataContract(Name = "GroupSchema")]
    
    public partial class GroupSchema : IEquatable<GroupSchema>
    {
        
        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "$schema", EmitDefaultValue = true)]
        public string Schema { get; private set; }

        /// <summary>
        /// Returns false as Schema should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSchema()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = true)]
        public string Created { get; private set; }

        /// <summary>
        /// Returns false as Created should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Definitions
        /// </summary>
        [DataMember(Name = "definitions", EmitDefaultValue = true)]
        public GroupSchemaDefinitions Definitions { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastUpdated
        /// </summary>
        [DataMember(Name = "lastUpdated", EmitDefaultValue = true)]
        public string LastUpdated { get; private set; }

        /// <summary>
        /// Returns false as LastUpdated should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastUpdated()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Properties
        /// </summary>
        [DataMember(Name = "properties", EmitDefaultValue = true)]
        public UserSchemaProperties Properties { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; private set; }

        /// <summary>
        /// Returns false as Type should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeType()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = true)]
        public LinksSelf Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupSchema {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Definitions: ").Append(Definitions).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Properties: ").Append(Properties).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as GroupSchema);
        }

        /// <summary>
        /// Returns true if GroupSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupSchema input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Schema == input.Schema ||
                    (this.Schema != null &&
                    this.Schema.Equals(input.Schema))
                ) && 
                (
                    this.Created == input.Created ||
                    (this.Created != null &&
                    this.Created.Equals(input.Created))
                ) && 
                (
                    this.Definitions == input.Definitions ||
                    (this.Definitions != null &&
                    this.Definitions.Equals(input.Definitions))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Properties == input.Properties ||
                    (this.Properties != null &&
                    this.Properties.Equals(input.Properties))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                
                if (this.Schema != null)
                {
                    hashCode = (hashCode * 59) + this.Schema.GetHashCode();
                }
                if (this.Created != null)
                {
                    hashCode = (hashCode * 59) + this.Created.GetHashCode();
                }
                if (this.Definitions != null)
                {
                    hashCode = (hashCode * 59) + this.Definitions.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LastUpdated != null)
                {
                    hashCode = (hashCode * 59) + this.LastUpdated.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Properties != null)
                {
                    hashCode = (hashCode * 59) + this.Properties.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
