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
    /// UI Schema element options object
    /// </summary>
    [DataContract(Name = "UIElement_options")]
    
    public partial class UIElementOptions : IEquatable<UIElementOptions>
    {
        /// <summary>
        /// Specifies how the input appears
        /// </summary>
        /// <value>Specifies how the input appears</value>
        [JsonConverter(typeof(StringEnumSerializingConverter))]
        public sealed class FormatEnum : StringEnum
        {
            /// <summary>
            /// StringEnum Text for value: text
            /// </summary>
            
            public static FormatEnum Text = new FormatEnum("text");

            /// <summary>
            /// StringEnum Radio for value: radio
            /// </summary>
            
            public static FormatEnum Radio = new FormatEnum("radio");

            /// <summary>
            /// StringEnum Select for value: select
            /// </summary>
            
            public static FormatEnum Select = new FormatEnum("select");

            /// <summary>
            /// StringEnum Checkbox for value: checkbox
            /// </summary>
            
            public static FormatEnum Checkbox = new FormatEnum("checkbox");

            /// <summary>
            /// StringEnum RadioYesNo for value: radio_yes_no
            /// </summary>
            
            public static FormatEnum RadioYesNo = new FormatEnum("radio_yes_no");

            /// <summary>
            /// StringEnum RadioTrueFalse for value: radio_true_false
            /// </summary>
            
            public static FormatEnum RadioTrueFalse = new FormatEnum("radio_true_false");


            /// <summary>
            /// Implicit operator declaration to accept and convert a string value as a <see cref="FormatEnum"/>
            /// </summary>
            /// <param name="value">The value to use</param>
            public static implicit operator FormatEnum(string value) => new FormatEnum(value);

            /// <summary>
            /// Creates a new <see cref="Format"/> instance.
            /// </summary>
            /// <param name="value">The value to use.</param>
            public FormatEnum(string value)
                : base(value)
            {
            }
        }


        /// <summary>
        /// Specifies how the input appears
        /// </summary>
        /// <value>Specifies how the input appears</value>
        [DataMember(Name = "format", EmitDefaultValue = true)]
        
        public FormatEnum Format { get; set; }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UIElementOptions {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
            return this.Equals(input as UIElementOptions);
        }

        /// <summary>
        /// Returns true if UIElementOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of UIElementOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UIElementOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
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
                
                if (this.Format != null)
                {
                    hashCode = (hashCode * 59) + this.Format.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
