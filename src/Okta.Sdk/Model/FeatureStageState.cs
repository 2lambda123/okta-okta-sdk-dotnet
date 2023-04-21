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
    /// Defines FeatureStageState
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class FeatureStageState : StringEnum
    {
        /// <summary>
        /// StringEnum FeatureStageState for value: CLOSED
        /// </summary>
        public static FeatureStageState CLOSED = new FeatureStageState("CLOSED");
        /// <summary>
        /// StringEnum FeatureStageState for value: OPEN
        /// </summary>
        public static FeatureStageState OPEN = new FeatureStageState("OPEN");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="FeatureStageState"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator FeatureStageState(string value) => new FeatureStageState(value);

        /// <summary>
        /// Creates a new <see cref="FeatureStageState"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public FeatureStageState(string value)
            : base(value)
        {
        }
    }


}