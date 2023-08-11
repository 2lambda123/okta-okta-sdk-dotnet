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
    /// Defines IdentitySourceSessionStatus
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class IdentitySourceSessionStatus : StringEnum
    {
        /// <summary>
        /// StringEnum IdentitySourceSessionStatus for value: CLOSED
        /// </summary>
        public static IdentitySourceSessionStatus CLOSED = new IdentitySourceSessionStatus("CLOSED");
        /// <summary>
        /// StringEnum IdentitySourceSessionStatus for value: COMPLETED
        /// </summary>
        public static IdentitySourceSessionStatus COMPLETED = new IdentitySourceSessionStatus("COMPLETED");
        /// <summary>
        /// StringEnum IdentitySourceSessionStatus for value: CREATED
        /// </summary>
        public static IdentitySourceSessionStatus CREATED = new IdentitySourceSessionStatus("CREATED");
        /// <summary>
        /// StringEnum IdentitySourceSessionStatus for value: ERROR
        /// </summary>
        public static IdentitySourceSessionStatus ERROR = new IdentitySourceSessionStatus("ERROR");
        /// <summary>
        /// StringEnum IdentitySourceSessionStatus for value: EXPIRED
        /// </summary>
        public static IdentitySourceSessionStatus EXPIRED = new IdentitySourceSessionStatus("EXPIRED");
        /// <summary>
        /// StringEnum IdentitySourceSessionStatus for value: IN_PROGRESS
        /// </summary>
        public static IdentitySourceSessionStatus INPROGRESS = new IdentitySourceSessionStatus("IN_PROGRESS");
        /// <summary>
        /// StringEnum IdentitySourceSessionStatus for value: TRIGGERED
        /// </summary>
        public static IdentitySourceSessionStatus TRIGGERED = new IdentitySourceSessionStatus("TRIGGERED");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="IdentitySourceSessionStatus"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator IdentitySourceSessionStatus(string value) => new IdentitySourceSessionStatus(value);

        /// <summary>
        /// Creates a new <see cref="IdentitySourceSessionStatus"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public IdentitySourceSessionStatus(string value)
            : base(value)
        {
        }
    }


}
