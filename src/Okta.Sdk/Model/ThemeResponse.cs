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
    /// ThemeResponse
    /// </summary>
    [DataContract(Name = "ThemeResponse")]
    
    public partial class ThemeResponse : IEquatable<ThemeResponse>
    {

        /// <summary>
        /// Gets or Sets EmailTemplateTouchPointVariant
        /// </summary>
        [DataMember(Name = "emailTemplateTouchPointVariant", EmitDefaultValue = false)]
        
        public EmailTemplateTouchPointVariant EmailTemplateTouchPointVariant { get; set; }

        /// <summary>
        /// Gets or Sets EndUserDashboardTouchPointVariant
        /// </summary>
        [DataMember(Name = "endUserDashboardTouchPointVariant", EmitDefaultValue = false)]
        
        public EndUserDashboardTouchPointVariant EndUserDashboardTouchPointVariant { get; set; }

        /// <summary>
        /// Gets or Sets ErrorPageTouchPointVariant
        /// </summary>
        [DataMember(Name = "errorPageTouchPointVariant", EmitDefaultValue = false)]
        
        public ErrorPageTouchPointVariant ErrorPageTouchPointVariant { get; set; }

        /// <summary>
        /// Gets or Sets LoadingPageTouchPointVariant
        /// </summary>
        [DataMember(Name = "loadingPageTouchPointVariant", EmitDefaultValue = false)]
        
        public LoadingPageTouchPointVariant LoadingPageTouchPointVariant { get; set; }

        /// <summary>
        /// Gets or Sets SignInPageTouchPointVariant
        /// </summary>
        [DataMember(Name = "signInPageTouchPointVariant", EmitDefaultValue = false)]
        
        public SignInPageTouchPointVariant SignInPageTouchPointVariant { get; set; }
        
        /// <summary>
        /// Gets or Sets BackgroundImage
        /// </summary>
        [DataMember(Name = "backgroundImage", EmitDefaultValue = false)]
        public string BackgroundImage { get; private set; }

        /// <summary>
        /// Returns false as BackgroundImage should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeBackgroundImage()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Favicon
        /// </summary>
        [DataMember(Name = "favicon", EmitDefaultValue = false)]
        public string Favicon { get; private set; }

        /// <summary>
        /// Returns false as Favicon should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFavicon()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
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
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; private set; }

        /// <summary>
        /// Returns false as Logo should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLogo()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PrimaryColorContrastHex
        /// </summary>
        [DataMember(Name = "primaryColorContrastHex", EmitDefaultValue = false)]
        public string PrimaryColorContrastHex { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryColorHex
        /// </summary>
        [DataMember(Name = "primaryColorHex", EmitDefaultValue = false)]
        public string PrimaryColorHex { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryColorContrastHex
        /// </summary>
        [DataMember(Name = "secondaryColorContrastHex", EmitDefaultValue = false)]
        public string SecondaryColorContrastHex { get; set; }

        /// <summary>
        /// Gets or Sets SecondaryColorHex
        /// </summary>
        [DataMember(Name = "secondaryColorHex", EmitDefaultValue = false)]
        public string SecondaryColorHex { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public Dictionary<string, Object> Links { get; private set; }

        /// <summary>
        /// Returns false as Links should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLinks()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThemeResponse {\n");
            sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
            sb.Append("  EmailTemplateTouchPointVariant: ").Append(EmailTemplateTouchPointVariant).Append("\n");
            sb.Append("  EndUserDashboardTouchPointVariant: ").Append(EndUserDashboardTouchPointVariant).Append("\n");
            sb.Append("  ErrorPageTouchPointVariant: ").Append(ErrorPageTouchPointVariant).Append("\n");
            sb.Append("  Favicon: ").Append(Favicon).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LoadingPageTouchPointVariant: ").Append(LoadingPageTouchPointVariant).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  PrimaryColorContrastHex: ").Append(PrimaryColorContrastHex).Append("\n");
            sb.Append("  PrimaryColorHex: ").Append(PrimaryColorHex).Append("\n");
            sb.Append("  SecondaryColorContrastHex: ").Append(SecondaryColorContrastHex).Append("\n");
            sb.Append("  SecondaryColorHex: ").Append(SecondaryColorHex).Append("\n");
            sb.Append("  SignInPageTouchPointVariant: ").Append(SignInPageTouchPointVariant).Append("\n");
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
            return this.Equals(input as ThemeResponse);
        }

        /// <summary>
        /// Returns true if ThemeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ThemeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThemeResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BackgroundImage == input.BackgroundImage ||
                    (this.BackgroundImage != null &&
                    this.BackgroundImage.Equals(input.BackgroundImage))
                ) && 
                (
                    this.EmailTemplateTouchPointVariant == input.EmailTemplateTouchPointVariant ||
                    this.EmailTemplateTouchPointVariant.Equals(input.EmailTemplateTouchPointVariant)
                ) && 
                (
                    this.EndUserDashboardTouchPointVariant == input.EndUserDashboardTouchPointVariant ||
                    this.EndUserDashboardTouchPointVariant.Equals(input.EndUserDashboardTouchPointVariant)
                ) && 
                (
                    this.ErrorPageTouchPointVariant == input.ErrorPageTouchPointVariant ||
                    this.ErrorPageTouchPointVariant.Equals(input.ErrorPageTouchPointVariant)
                ) && 
                (
                    this.Favicon == input.Favicon ||
                    (this.Favicon != null &&
                    this.Favicon.Equals(input.Favicon))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LoadingPageTouchPointVariant == input.LoadingPageTouchPointVariant ||
                    this.LoadingPageTouchPointVariant.Equals(input.LoadingPageTouchPointVariant)
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.PrimaryColorContrastHex == input.PrimaryColorContrastHex ||
                    (this.PrimaryColorContrastHex != null &&
                    this.PrimaryColorContrastHex.Equals(input.PrimaryColorContrastHex))
                ) && 
                (
                    this.PrimaryColorHex == input.PrimaryColorHex ||
                    (this.PrimaryColorHex != null &&
                    this.PrimaryColorHex.Equals(input.PrimaryColorHex))
                ) && 
                (
                    this.SecondaryColorContrastHex == input.SecondaryColorContrastHex ||
                    (this.SecondaryColorContrastHex != null &&
                    this.SecondaryColorContrastHex.Equals(input.SecondaryColorContrastHex))
                ) && 
                (
                    this.SecondaryColorHex == input.SecondaryColorHex ||
                    (this.SecondaryColorHex != null &&
                    this.SecondaryColorHex.Equals(input.SecondaryColorHex))
                ) && 
                (
                    this.SignInPageTouchPointVariant == input.SignInPageTouchPointVariant ||
                    this.SignInPageTouchPointVariant.Equals(input.SignInPageTouchPointVariant)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                
                if (this.BackgroundImage != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundImage.GetHashCode();
                }
                if (this.EmailTemplateTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.EmailTemplateTouchPointVariant.GetHashCode();
                }
                if (this.EndUserDashboardTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.EndUserDashboardTouchPointVariant.GetHashCode();
                }
                if (this.ErrorPageTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorPageTouchPointVariant.GetHashCode();
                }
                if (this.Favicon != null)
                {
                    hashCode = (hashCode * 59) + this.Favicon.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LoadingPageTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.LoadingPageTouchPointVariant.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.PrimaryColorContrastHex != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryColorContrastHex.GetHashCode();
                }
                if (this.PrimaryColorHex != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryColorHex.GetHashCode();
                }
                if (this.SecondaryColorContrastHex != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryColorContrastHex.GetHashCode();
                }
                if (this.SecondaryColorHex != null)
                {
                    hashCode = (hashCode * 59) + this.SecondaryColorHex.GetHashCode();
                }
                if (this.SignInPageTouchPointVariant != null)
                {
                    hashCode = (hashCode * 59) + this.SignInPageTouchPointVariant.GetHashCode();
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
