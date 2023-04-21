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
    /// Defines ApplicationSignOnMode
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class ApplicationSignOnMode : StringEnum
    {
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: AUTO_LOGIN
        /// </summary>
        public static ApplicationSignOnMode AUTOLOGIN = new ApplicationSignOnMode("AUTO_LOGIN");
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: BASIC_AUTH
        /// </summary>
        public static ApplicationSignOnMode BASICAUTH = new ApplicationSignOnMode("BASIC_AUTH");
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: BOOKMARK
        /// </summary>
        public static ApplicationSignOnMode BOOKMARK = new ApplicationSignOnMode("BOOKMARK");
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: BROWSER_PLUGIN
        /// </summary>
        public static ApplicationSignOnMode BROWSERPLUGIN = new ApplicationSignOnMode("BROWSER_PLUGIN");
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: OPENID_CONNECT
        /// </summary>
        public static ApplicationSignOnMode OPENIDCONNECT = new ApplicationSignOnMode("OPENID_CONNECT");
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: SAML_1_1
        /// </summary>
        public static ApplicationSignOnMode SAML11 = new ApplicationSignOnMode("SAML_1_1");
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: SAML_2_0
        /// </summary>
        public static ApplicationSignOnMode SAML20 = new ApplicationSignOnMode("SAML_2_0");
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: SECURE_PASSWORD_STORE
        /// </summary>
        public static ApplicationSignOnMode SECUREPASSWORDSTORE = new ApplicationSignOnMode("SECURE_PASSWORD_STORE");
        /// <summary>
        /// StringEnum ApplicationSignOnMode for value: WS_FEDERATION
        /// </summary>
        public static ApplicationSignOnMode WSFEDERATION = new ApplicationSignOnMode("WS_FEDERATION");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="ApplicationSignOnMode"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator ApplicationSignOnMode(string value) => new ApplicationSignOnMode(value);

        /// <summary>
        /// Creates a new <see cref="ApplicationSignOnMode"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public ApplicationSignOnMode(string value)
            : base(value)
        {
        }
    }


}