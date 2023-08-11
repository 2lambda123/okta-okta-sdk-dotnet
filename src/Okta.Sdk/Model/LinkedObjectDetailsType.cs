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
    /// Defines LinkedObjectDetailsType
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class LinkedObjectDetailsType : StringEnum
    {
        /// <summary>
        /// StringEnum LinkedObjectDetailsType for value: USER
        /// </summary>
        public static LinkedObjectDetailsType USER = new LinkedObjectDetailsType("USER");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="LinkedObjectDetailsType"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator LinkedObjectDetailsType(string value) => new LinkedObjectDetailsType(value);

        /// <summary>
        /// Creates a new <see cref="LinkedObjectDetailsType"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public LinkedObjectDetailsType(string value)
            : base(value)
        {
        }
    }


}
