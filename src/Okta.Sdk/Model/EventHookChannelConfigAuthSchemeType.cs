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
    /// Defines EventHookChannelConfigAuthSchemeType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class EventHookChannelConfigAuthSchemeType : StringEnum
    {
        /// <summary>
        /// StringEnum EventHookChannelConfigAuthSchemeType for value: HEADER
        /// </summary>
        public static EventHookChannelConfigAuthSchemeType HEADER = new EventHookChannelConfigAuthSchemeType("HEADER");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="EventHookChannelConfigAuthSchemeType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator EventHookChannelConfigAuthSchemeType(string value) => new EventHookChannelConfigAuthSchemeType(value);

        /// <summary>
        /// Creates a new <see cref="EventHookChannelConfigAuthSchemeType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public EventHookChannelConfigAuthSchemeType(string value)
            : base(value)
        {
        }
    }


}
