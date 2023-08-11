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
    /// Defines PolicyPlatformOperatingSystemType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class PolicyPlatformOperatingSystemType : StringEnum
    {
        /// <summary>
        /// StringEnum PolicyPlatformOperatingSystemType for value: ANDROID
        /// </summary>
        public static PolicyPlatformOperatingSystemType ANDROID = new PolicyPlatformOperatingSystemType("ANDROID");
        /// <summary>
        /// StringEnum PolicyPlatformOperatingSystemType for value: ANY
        /// </summary>
        public static PolicyPlatformOperatingSystemType ANY = new PolicyPlatformOperatingSystemType("ANY");
        /// <summary>
        /// StringEnum PolicyPlatformOperatingSystemType for value: IOS
        /// </summary>
        public static PolicyPlatformOperatingSystemType IOS = new PolicyPlatformOperatingSystemType("IOS");
        /// <summary>
        /// StringEnum PolicyPlatformOperatingSystemType for value: OSX
        /// </summary>
        public static PolicyPlatformOperatingSystemType OSX = new PolicyPlatformOperatingSystemType("OSX");
        /// <summary>
        /// StringEnum PolicyPlatformOperatingSystemType for value: OTHER
        /// </summary>
        public static PolicyPlatformOperatingSystemType OTHER = new PolicyPlatformOperatingSystemType("OTHER");
        /// <summary>
        /// StringEnum PolicyPlatformOperatingSystemType for value: WINDOWS
        /// </summary>
        public static PolicyPlatformOperatingSystemType WINDOWS = new PolicyPlatformOperatingSystemType("WINDOWS");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="PolicyPlatformOperatingSystemType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator PolicyPlatformOperatingSystemType(string value) => new PolicyPlatformOperatingSystemType(value);

        /// <summary>
        /// Creates a new <see cref="PolicyPlatformOperatingSystemType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public PolicyPlatformOperatingSystemType(string value)
            : base(value)
        {
        }
    }


}
