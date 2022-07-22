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
    /// SamlApplicationSettingsSignOn
    /// </summary>
    [DataContract(Name = "SamlApplicationSettingsSignOn")]
    public partial class SamlApplicationSettingsSignOn : IEquatable<SamlApplicationSettingsSignOn>
    {
        
        /// <summary>
        /// Gets or Sets AcsEndpoints
        /// </summary>
        [DataMember(Name = "acsEndpoints", EmitDefaultValue = false)]
        public List<AcsEndpoint> AcsEndpoints { get; set; }

        /// <summary>
        /// Gets or Sets AllowMultipleAcsEndpoints
        /// </summary>
        [DataMember(Name = "allowMultipleAcsEndpoints", EmitDefaultValue = true)]
        public bool AllowMultipleAcsEndpoints { get; set; }

        /// <summary>
        /// Gets or Sets AssertionSigned
        /// </summary>
        [DataMember(Name = "assertionSigned", EmitDefaultValue = true)]
        public bool AssertionSigned { get; set; }

        /// <summary>
        /// Gets or Sets AttributeStatements
        /// </summary>
        [DataMember(Name = "attributeStatements", EmitDefaultValue = false)]
        public List<SamlAttributeStatement> AttributeStatements { get; set; }

        /// <summary>
        /// Gets or Sets Audience
        /// </summary>
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public string Audience { get; set; }

        /// <summary>
        /// Gets or Sets AudienceOverride
        /// </summary>
        [DataMember(Name = "audienceOverride", EmitDefaultValue = false)]
        public string AudienceOverride { get; set; }

        /// <summary>
        /// Gets or Sets AuthnContextClassRef
        /// </summary>
        [DataMember(Name = "authnContextClassRef", EmitDefaultValue = false)]
        public string AuthnContextClassRef { get; set; }

        /// <summary>
        /// Gets or Sets DefaultRelayState
        /// </summary>
        [DataMember(Name = "defaultRelayState", EmitDefaultValue = false)]
        public string DefaultRelayState { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets DestinationOverride
        /// </summary>
        [DataMember(Name = "destinationOverride", EmitDefaultValue = false)]
        public string DestinationOverride { get; set; }

        /// <summary>
        /// Gets or Sets DigestAlgorithm
        /// </summary>
        [DataMember(Name = "digestAlgorithm", EmitDefaultValue = false)]
        public string DigestAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets HonorForceAuthn
        /// </summary>
        [DataMember(Name = "honorForceAuthn", EmitDefaultValue = true)]
        public bool HonorForceAuthn { get; set; }

        /// <summary>
        /// Gets or Sets IdpIssuer
        /// </summary>
        [DataMember(Name = "idpIssuer", EmitDefaultValue = false)]
        public string IdpIssuer { get; set; }

        /// <summary>
        /// Gets or Sets InlineHooks
        /// </summary>
        [DataMember(Name = "inlineHooks", EmitDefaultValue = false)]
        public List<SignOnInlineHook> InlineHooks { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Gets or Sets RecipientOverride
        /// </summary>
        [DataMember(Name = "recipientOverride", EmitDefaultValue = false)]
        public string RecipientOverride { get; set; }

        /// <summary>
        /// Gets or Sets RequestCompressed
        /// </summary>
        [DataMember(Name = "requestCompressed", EmitDefaultValue = true)]
        public bool RequestCompressed { get; set; }

        /// <summary>
        /// Gets or Sets ResponseSigned
        /// </summary>
        [DataMember(Name = "responseSigned", EmitDefaultValue = true)]
        public bool ResponseSigned { get; set; }

        /// <summary>
        /// Gets or Sets SignatureAlgorithm
        /// </summary>
        [DataMember(Name = "signatureAlgorithm", EmitDefaultValue = false)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// Gets or Sets Slo
        /// </summary>
        [DataMember(Name = "slo", EmitDefaultValue = false)]
        public SingleLogout Slo { get; set; }

        /// <summary>
        /// Gets or Sets SpCertificate
        /// </summary>
        [DataMember(Name = "spCertificate", EmitDefaultValue = false)]
        public SpCertificate SpCertificate { get; set; }

        /// <summary>
        /// Gets or Sets SpIssuer
        /// </summary>
        [DataMember(Name = "spIssuer", EmitDefaultValue = false)]
        public string SpIssuer { get; set; }

        /// <summary>
        /// Gets or Sets SsoAcsUrl
        /// </summary>
        [DataMember(Name = "ssoAcsUrl", EmitDefaultValue = false)]
        public string SsoAcsUrl { get; set; }

        /// <summary>
        /// Gets or Sets SsoAcsUrlOverride
        /// </summary>
        [DataMember(Name = "ssoAcsUrlOverride", EmitDefaultValue = false)]
        public string SsoAcsUrlOverride { get; set; }

        /// <summary>
        /// Gets or Sets SubjectNameIdFormat
        /// </summary>
        [DataMember(Name = "subjectNameIdFormat", EmitDefaultValue = false)]
        public string SubjectNameIdFormat { get; set; }

        /// <summary>
        /// Gets or Sets SubjectNameIdTemplate
        /// </summary>
        [DataMember(Name = "subjectNameIdTemplate", EmitDefaultValue = false)]
        public string SubjectNameIdTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SamlApplicationSettingsSignOn {\n");
            sb.Append("  AcsEndpoints: ").Append(AcsEndpoints).Append("\n");
            sb.Append("  AllowMultipleAcsEndpoints: ").Append(AllowMultipleAcsEndpoints).Append("\n");
            sb.Append("  AssertionSigned: ").Append(AssertionSigned).Append("\n");
            sb.Append("  AttributeStatements: ").Append(AttributeStatements).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
            sb.Append("  AudienceOverride: ").Append(AudienceOverride).Append("\n");
            sb.Append("  AuthnContextClassRef: ").Append(AuthnContextClassRef).Append("\n");
            sb.Append("  DefaultRelayState: ").Append(DefaultRelayState).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  DestinationOverride: ").Append(DestinationOverride).Append("\n");
            sb.Append("  DigestAlgorithm: ").Append(DigestAlgorithm).Append("\n");
            sb.Append("  HonorForceAuthn: ").Append(HonorForceAuthn).Append("\n");
            sb.Append("  IdpIssuer: ").Append(IdpIssuer).Append("\n");
            sb.Append("  InlineHooks: ").Append(InlineHooks).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  RecipientOverride: ").Append(RecipientOverride).Append("\n");
            sb.Append("  RequestCompressed: ").Append(RequestCompressed).Append("\n");
            sb.Append("  ResponseSigned: ").Append(ResponseSigned).Append("\n");
            sb.Append("  SignatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  Slo: ").Append(Slo).Append("\n");
            sb.Append("  SpCertificate: ").Append(SpCertificate).Append("\n");
            sb.Append("  SpIssuer: ").Append(SpIssuer).Append("\n");
            sb.Append("  SsoAcsUrl: ").Append(SsoAcsUrl).Append("\n");
            sb.Append("  SsoAcsUrlOverride: ").Append(SsoAcsUrlOverride).Append("\n");
            sb.Append("  SubjectNameIdFormat: ").Append(SubjectNameIdFormat).Append("\n");
            sb.Append("  SubjectNameIdTemplate: ").Append(SubjectNameIdTemplate).Append("\n");
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
            return this.Equals(input as SamlApplicationSettingsSignOn);
        }

        /// <summary>
        /// Returns true if SamlApplicationSettingsSignOn instances are equal
        /// </summary>
        /// <param name="input">Instance of SamlApplicationSettingsSignOn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SamlApplicationSettingsSignOn input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcsEndpoints == input.AcsEndpoints ||
                    this.AcsEndpoints != null &&
                    input.AcsEndpoints != null &&
                    this.AcsEndpoints.SequenceEqual(input.AcsEndpoints)
                ) && 
                (
                    this.AllowMultipleAcsEndpoints == input.AllowMultipleAcsEndpoints ||
                    this.AllowMultipleAcsEndpoints.Equals(input.AllowMultipleAcsEndpoints)
                ) && 
                (
                    this.AssertionSigned == input.AssertionSigned ||
                    this.AssertionSigned.Equals(input.AssertionSigned)
                ) && 
                (
                    this.AttributeStatements == input.AttributeStatements ||
                    this.AttributeStatements != null &&
                    input.AttributeStatements != null &&
                    this.AttributeStatements.SequenceEqual(input.AttributeStatements)
                ) && 
                (
                    this.Audience == input.Audience ||
                    (this.Audience != null &&
                    this.Audience.Equals(input.Audience))
                ) && 
                (
                    this.AudienceOverride == input.AudienceOverride ||
                    (this.AudienceOverride != null &&
                    this.AudienceOverride.Equals(input.AudienceOverride))
                ) && 
                (
                    this.AuthnContextClassRef == input.AuthnContextClassRef ||
                    (this.AuthnContextClassRef != null &&
                    this.AuthnContextClassRef.Equals(input.AuthnContextClassRef))
                ) && 
                (
                    this.DefaultRelayState == input.DefaultRelayState ||
                    (this.DefaultRelayState != null &&
                    this.DefaultRelayState.Equals(input.DefaultRelayState))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.DestinationOverride == input.DestinationOverride ||
                    (this.DestinationOverride != null &&
                    this.DestinationOverride.Equals(input.DestinationOverride))
                ) && 
                (
                    this.DigestAlgorithm == input.DigestAlgorithm ||
                    (this.DigestAlgorithm != null &&
                    this.DigestAlgorithm.Equals(input.DigestAlgorithm))
                ) && 
                (
                    this.HonorForceAuthn == input.HonorForceAuthn ||
                    this.HonorForceAuthn.Equals(input.HonorForceAuthn)
                ) && 
                (
                    this.IdpIssuer == input.IdpIssuer ||
                    (this.IdpIssuer != null &&
                    this.IdpIssuer.Equals(input.IdpIssuer))
                ) && 
                (
                    this.InlineHooks == input.InlineHooks ||
                    this.InlineHooks != null &&
                    input.InlineHooks != null &&
                    this.InlineHooks.SequenceEqual(input.InlineHooks)
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.RecipientOverride == input.RecipientOverride ||
                    (this.RecipientOverride != null &&
                    this.RecipientOverride.Equals(input.RecipientOverride))
                ) && 
                (
                    this.RequestCompressed == input.RequestCompressed ||
                    this.RequestCompressed.Equals(input.RequestCompressed)
                ) && 
                (
                    this.ResponseSigned == input.ResponseSigned ||
                    this.ResponseSigned.Equals(input.ResponseSigned)
                ) && 
                (
                    this.SignatureAlgorithm == input.SignatureAlgorithm ||
                    (this.SignatureAlgorithm != null &&
                    this.SignatureAlgorithm.Equals(input.SignatureAlgorithm))
                ) && 
                (
                    this.Slo == input.Slo ||
                    (this.Slo != null &&
                    this.Slo.Equals(input.Slo))
                ) && 
                (
                    this.SpCertificate == input.SpCertificate ||
                    (this.SpCertificate != null &&
                    this.SpCertificate.Equals(input.SpCertificate))
                ) && 
                (
                    this.SpIssuer == input.SpIssuer ||
                    (this.SpIssuer != null &&
                    this.SpIssuer.Equals(input.SpIssuer))
                ) && 
                (
                    this.SsoAcsUrl == input.SsoAcsUrl ||
                    (this.SsoAcsUrl != null &&
                    this.SsoAcsUrl.Equals(input.SsoAcsUrl))
                ) && 
                (
                    this.SsoAcsUrlOverride == input.SsoAcsUrlOverride ||
                    (this.SsoAcsUrlOverride != null &&
                    this.SsoAcsUrlOverride.Equals(input.SsoAcsUrlOverride))
                ) && 
                (
                    this.SubjectNameIdFormat == input.SubjectNameIdFormat ||
                    (this.SubjectNameIdFormat != null &&
                    this.SubjectNameIdFormat.Equals(input.SubjectNameIdFormat))
                ) && 
                (
                    this.SubjectNameIdTemplate == input.SubjectNameIdTemplate ||
                    (this.SubjectNameIdTemplate != null &&
                    this.SubjectNameIdTemplate.Equals(input.SubjectNameIdTemplate))
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
                if (this.AcsEndpoints != null)
                {
                    hashCode = (hashCode * 59) + this.AcsEndpoints.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AllowMultipleAcsEndpoints.GetHashCode();
                hashCode = (hashCode * 59) + this.AssertionSigned.GetHashCode();
                if (this.AttributeStatements != null)
                {
                    hashCode = (hashCode * 59) + this.AttributeStatements.GetHashCode();
                }
                if (this.Audience != null)
                {
                    hashCode = (hashCode * 59) + this.Audience.GetHashCode();
                }
                if (this.AudienceOverride != null)
                {
                    hashCode = (hashCode * 59) + this.AudienceOverride.GetHashCode();
                }
                if (this.AuthnContextClassRef != null)
                {
                    hashCode = (hashCode * 59) + this.AuthnContextClassRef.GetHashCode();
                }
                if (this.DefaultRelayState != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultRelayState.GetHashCode();
                }
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.DestinationOverride != null)
                {
                    hashCode = (hashCode * 59) + this.DestinationOverride.GetHashCode();
                }
                if (this.DigestAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.DigestAlgorithm.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HonorForceAuthn.GetHashCode();
                if (this.IdpIssuer != null)
                {
                    hashCode = (hashCode * 59) + this.IdpIssuer.GetHashCode();
                }
                if (this.InlineHooks != null)
                {
                    hashCode = (hashCode * 59) + this.InlineHooks.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.RecipientOverride != null)
                {
                    hashCode = (hashCode * 59) + this.RecipientOverride.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestCompressed.GetHashCode();
                hashCode = (hashCode * 59) + this.ResponseSigned.GetHashCode();
                if (this.SignatureAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureAlgorithm.GetHashCode();
                }
                if (this.Slo != null)
                {
                    hashCode = (hashCode * 59) + this.Slo.GetHashCode();
                }
                if (this.SpCertificate != null)
                {
                    hashCode = (hashCode * 59) + this.SpCertificate.GetHashCode();
                }
                if (this.SpIssuer != null)
                {
                    hashCode = (hashCode * 59) + this.SpIssuer.GetHashCode();
                }
                if (this.SsoAcsUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SsoAcsUrl.GetHashCode();
                }
                if (this.SsoAcsUrlOverride != null)
                {
                    hashCode = (hashCode * 59) + this.SsoAcsUrlOverride.GetHashCode();
                }
                if (this.SubjectNameIdFormat != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectNameIdFormat.GetHashCode();
                }
                if (this.SubjectNameIdTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.SubjectNameIdTemplate.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
