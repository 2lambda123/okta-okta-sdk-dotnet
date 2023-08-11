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
    /// Defines AuthenticatorMethodType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class AuthenticatorMethodType : StringEnum
    {
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: cert
        /// </summary>
        public static AuthenticatorMethodType Cert = new AuthenticatorMethodType("cert");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: duo
        /// </summary>
        public static AuthenticatorMethodType Duo = new AuthenticatorMethodType("duo");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: email
        /// </summary>
        public static AuthenticatorMethodType Email = new AuthenticatorMethodType("email");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: idp
        /// </summary>
        public static AuthenticatorMethodType Idp = new AuthenticatorMethodType("idp");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: otp
        /// </summary>
        public static AuthenticatorMethodType Otp = new AuthenticatorMethodType("otp");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: password
        /// </summary>
        public static AuthenticatorMethodType Password = new AuthenticatorMethodType("password");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: push
        /// </summary>
        public static AuthenticatorMethodType Push = new AuthenticatorMethodType("push");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: security_question
        /// </summary>
        public static AuthenticatorMethodType SecurityQuestion = new AuthenticatorMethodType("security_question");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: signed_nonce
        /// </summary>
        public static AuthenticatorMethodType SignedNonce = new AuthenticatorMethodType("signed_nonce");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: sms
        /// </summary>
        public static AuthenticatorMethodType Sms = new AuthenticatorMethodType("sms");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: totp
        /// </summary>
        public static AuthenticatorMethodType Totp = new AuthenticatorMethodType("totp");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: voice
        /// </summary>
        public static AuthenticatorMethodType Voice = new AuthenticatorMethodType("voice");
        /// <summary>
        /// StringEnum AuthenticatorMethodType for value: webauthn
        /// </summary>
        public static AuthenticatorMethodType Webauthn = new AuthenticatorMethodType("webauthn");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="AuthenticatorMethodType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator AuthenticatorMethodType(string value) => new AuthenticatorMethodType(value);

        /// <summary>
        /// Creates a new <see cref="AuthenticatorMethodType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public AuthenticatorMethodType(string value)
            : base(value)
        {
        }
    }


}
