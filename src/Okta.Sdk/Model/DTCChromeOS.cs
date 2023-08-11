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
    /// Google Chrome Device Trust Connector provider
    /// </summary>
    [DataContract(Name = "DTCChromeOS")]
    
    public partial class DTCChromeOS : IEquatable<DTCChromeOS>
    {

        /// <summary>
        /// Gets or Sets KeyTrustLevel
        /// </summary>
        [DataMember(Name = "keyTrustLevel", EmitDefaultValue = true)]
        
        public KeyTrustLevelOSMode KeyTrustLevel { get; set; }

        /// <summary>
        /// Gets or Sets PasswordProtectionWarningTrigger
        /// </summary>
        [DataMember(Name = "passwordProtectionWarningTrigger", EmitDefaultValue = true)]
        
        public PasswordProtectionWarningTrigger PasswordProtectionWarningTrigger { get; set; }

        /// <summary>
        /// Gets or Sets SafeBrowsingProtectionLevel
        /// </summary>
        [DataMember(Name = "safeBrowsingProtectionLevel", EmitDefaultValue = true)]
        
        public SafeBrowsingProtectionLevel SafeBrowsingProtectionLevel { get; set; }
        
        /// <summary>
        /// Indicates whether the AllowScreenLock enterprise policy is enabled
        /// </summary>
        /// <value>Indicates whether the AllowScreenLock enterprise policy is enabled</value>
        [DataMember(Name = "allowScreenLock", EmitDefaultValue = true)]
        public bool AllowScreenLock { get; set; }

        /// <summary>
        /// Gets or Sets BrowserVersion
        /// </summary>
        [DataMember(Name = "browserVersion", EmitDefaultValue = true)]
        public ChromeBrowserVersion BrowserVersion { get; set; }

        /// <summary>
        /// Indicates if a software stack is used to communicate with the DNS server
        /// </summary>
        /// <value>Indicates if a software stack is used to communicate with the DNS server</value>
        [DataMember(Name = "builtInDnsClientEnabled", EmitDefaultValue = true)]
        public bool BuiltInDnsClientEnabled { get; set; }

        /// <summary>
        /// Indicates whether access to the Chrome Remote Desktop application is blocked through a policy
        /// </summary>
        /// <value>Indicates whether access to the Chrome Remote Desktop application is blocked through a policy</value>
        [DataMember(Name = "chromeRemoteDesktopAppBlocked", EmitDefaultValue = true)]
        public bool ChromeRemoteDesktopAppBlocked { get; set; }

        /// <summary>
        /// Enrollment domain of the customer that is currently managing the device
        /// </summary>
        /// <value>Enrollment domain of the customer that is currently managing the device</value>
        [DataMember(Name = "deviceEnrollmentDomain", EmitDefaultValue = true)]
        public string DeviceEnrollmentDomain { get; set; }

        /// <summary>
        /// Indicates whether the main disk is encrypted
        /// </summary>
        /// <value>Indicates whether the main disk is encrypted</value>
        [DataMember(Name = "diskEnrypted", EmitDefaultValue = true)]
        public bool DiskEnrypted { get; set; }

        /// <summary>
        /// Indicates whether a firewall is enabled at the OS-level on the device
        /// </summary>
        /// <value>Indicates whether a firewall is enabled at the OS-level on the device</value>
        [DataMember(Name = "osFirewall", EmitDefaultValue = true)]
        public bool OsFirewall { get; set; }

        /// <summary>
        /// Gets or Sets OsVersion
        /// </summary>
        [DataMember(Name = "osVersion", EmitDefaultValue = true)]
        public OSVersion OsVersion { get; set; }

        /// <summary>
        /// Indicates whether enterprise-grade (custom) unsafe URL scanning is enabled
        /// </summary>
        /// <value>Indicates whether enterprise-grade (custom) unsafe URL scanning is enabled</value>
        [DataMember(Name = "realtimeUrlCheckMode", EmitDefaultValue = true)]
        public bool RealtimeUrlCheckMode { get; set; }

        /// <summary>
        /// Indicates whether the device is password-protected
        /// </summary>
        /// <value>Indicates whether the device is password-protected</value>
        [DataMember(Name = "screenLockSecured", EmitDefaultValue = true)]
        public bool ScreenLockSecured { get; set; }

        /// <summary>
        /// Indicates whether the Site Isolation (also known as **Site Per Process**) setting is enabled
        /// </summary>
        /// <value>Indicates whether the Site Isolation (also known as **Site Per Process**) setting is enabled</value>
        [DataMember(Name = "siteIsolationEnabled", EmitDefaultValue = true)]
        public bool SiteIsolationEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DTCChromeOS {\n");
            sb.Append("  AllowScreenLock: ").Append(AllowScreenLock).Append("\n");
            sb.Append("  BrowserVersion: ").Append(BrowserVersion).Append("\n");
            sb.Append("  BuiltInDnsClientEnabled: ").Append(BuiltInDnsClientEnabled).Append("\n");
            sb.Append("  ChromeRemoteDesktopAppBlocked: ").Append(ChromeRemoteDesktopAppBlocked).Append("\n");
            sb.Append("  DeviceEnrollmentDomain: ").Append(DeviceEnrollmentDomain).Append("\n");
            sb.Append("  DiskEnrypted: ").Append(DiskEnrypted).Append("\n");
            sb.Append("  KeyTrustLevel: ").Append(KeyTrustLevel).Append("\n");
            sb.Append("  OsFirewall: ").Append(OsFirewall).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  PasswordProtectionWarningTrigger: ").Append(PasswordProtectionWarningTrigger).Append("\n");
            sb.Append("  RealtimeUrlCheckMode: ").Append(RealtimeUrlCheckMode).Append("\n");
            sb.Append("  SafeBrowsingProtectionLevel: ").Append(SafeBrowsingProtectionLevel).Append("\n");
            sb.Append("  ScreenLockSecured: ").Append(ScreenLockSecured).Append("\n");
            sb.Append("  SiteIsolationEnabled: ").Append(SiteIsolationEnabled).Append("\n");
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
            return this.Equals(input as DTCChromeOS);
        }

        /// <summary>
        /// Returns true if DTCChromeOS instances are equal
        /// </summary>
        /// <param name="input">Instance of DTCChromeOS to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DTCChromeOS input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowScreenLock == input.AllowScreenLock ||
                    this.AllowScreenLock.Equals(input.AllowScreenLock)
                ) && 
                (
                    this.BrowserVersion == input.BrowserVersion ||
                    (this.BrowserVersion != null &&
                    this.BrowserVersion.Equals(input.BrowserVersion))
                ) && 
                (
                    this.BuiltInDnsClientEnabled == input.BuiltInDnsClientEnabled ||
                    this.BuiltInDnsClientEnabled.Equals(input.BuiltInDnsClientEnabled)
                ) && 
                (
                    this.ChromeRemoteDesktopAppBlocked == input.ChromeRemoteDesktopAppBlocked ||
                    this.ChromeRemoteDesktopAppBlocked.Equals(input.ChromeRemoteDesktopAppBlocked)
                ) && 
                (
                    this.DeviceEnrollmentDomain == input.DeviceEnrollmentDomain ||
                    (this.DeviceEnrollmentDomain != null &&
                    this.DeviceEnrollmentDomain.Equals(input.DeviceEnrollmentDomain))
                ) && 
                (
                    this.DiskEnrypted == input.DiskEnrypted ||
                    this.DiskEnrypted.Equals(input.DiskEnrypted)
                ) && 
                (
                    this.KeyTrustLevel == input.KeyTrustLevel ||
                    this.KeyTrustLevel.Equals(input.KeyTrustLevel)
                ) && 
                (
                    this.OsFirewall == input.OsFirewall ||
                    this.OsFirewall.Equals(input.OsFirewall)
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.PasswordProtectionWarningTrigger == input.PasswordProtectionWarningTrigger ||
                    this.PasswordProtectionWarningTrigger.Equals(input.PasswordProtectionWarningTrigger)
                ) && 
                (
                    this.RealtimeUrlCheckMode == input.RealtimeUrlCheckMode ||
                    this.RealtimeUrlCheckMode.Equals(input.RealtimeUrlCheckMode)
                ) && 
                (
                    this.SafeBrowsingProtectionLevel == input.SafeBrowsingProtectionLevel ||
                    this.SafeBrowsingProtectionLevel.Equals(input.SafeBrowsingProtectionLevel)
                ) && 
                (
                    this.ScreenLockSecured == input.ScreenLockSecured ||
                    this.ScreenLockSecured.Equals(input.ScreenLockSecured)
                ) && 
                (
                    this.SiteIsolationEnabled == input.SiteIsolationEnabled ||
                    this.SiteIsolationEnabled.Equals(input.SiteIsolationEnabled)
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
                
                hashCode = (hashCode * 59) + this.AllowScreenLock.GetHashCode();
                if (this.BrowserVersion != null)
                {
                    hashCode = (hashCode * 59) + this.BrowserVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BuiltInDnsClientEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ChromeRemoteDesktopAppBlocked.GetHashCode();
                if (this.DeviceEnrollmentDomain != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceEnrollmentDomain.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DiskEnrypted.GetHashCode();
                if (this.KeyTrustLevel != null)
                {
                    hashCode = (hashCode * 59) + this.KeyTrustLevel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OsFirewall.GetHashCode();
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
                }
                if (this.PasswordProtectionWarningTrigger != null)
                {
                    hashCode = (hashCode * 59) + this.PasswordProtectionWarningTrigger.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RealtimeUrlCheckMode.GetHashCode();
                if (this.SafeBrowsingProtectionLevel != null)
                {
                    hashCode = (hashCode * 59) + this.SafeBrowsingProtectionLevel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ScreenLockSecured.GetHashCode();
                hashCode = (hashCode * 59) + this.SiteIsolationEnabled.GetHashCode();
                return hashCode;
            }
        }

    }

}
