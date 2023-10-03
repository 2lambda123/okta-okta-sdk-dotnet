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
    /// Indicates whether the Password Protection Warning feature is enabled
    /// </summary>
    /// <value>Indicates whether the Password Protection Warning feature is enabled</value>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class PasswordProtectionWarningTrigger : StringEnum
    {
        /// <summary>
        /// StringEnum PasswordProtectionWarningTrigger for value: PASSWORD_PROTECTION_OFF
        /// </summary>
        public static PasswordProtectionWarningTrigger PASSWORDPROTECTIONOFF = new PasswordProtectionWarningTrigger("PASSWORD_PROTECTION_OFF");
        /// <summary>
        /// StringEnum PasswordProtectionWarningTrigger for value: PASSWORD_REUSE
        /// </summary>
        public static PasswordProtectionWarningTrigger PASSWORDREUSE = new PasswordProtectionWarningTrigger("PASSWORD_REUSE");
        /// <summary>
        /// StringEnum PasswordProtectionWarningTrigger for value: PHISHING_REUSE
        /// </summary>
        public static PasswordProtectionWarningTrigger PHISHINGREUSE = new PasswordProtectionWarningTrigger("PHISHING_REUSE");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="PasswordProtectionWarningTrigger"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator PasswordProtectionWarningTrigger(string value) => new PasswordProtectionWarningTrigger(value);

        /// <summary>
        /// Creates a new <see cref="PasswordProtectionWarningTrigger"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public PasswordProtectionWarningTrigger(string value)
            : base(value)
        {
        }
    }


}