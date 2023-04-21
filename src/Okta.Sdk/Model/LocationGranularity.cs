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
    /// Defines LocationGranularity
    /// </summary>
    [JsonConverter(typeof(StringEnumSerializingConverter))]
    public sealed class LocationGranularity : StringEnum
    {
        /// <summary>
        /// StringEnum LocationGranularity for value: CITY
        /// </summary>
        public static LocationGranularity CITY = new LocationGranularity("CITY");
        /// <summary>
        /// StringEnum LocationGranularity for value: COUNTRY
        /// </summary>
        public static LocationGranularity COUNTRY = new LocationGranularity("COUNTRY");
        /// <summary>
        /// StringEnum LocationGranularity for value: LAT_LONG
        /// </summary>
        public static LocationGranularity LATLONG = new LocationGranularity("LAT_LONG");
        /// <summary>
        /// StringEnum LocationGranularity for value: SUBDIVISION
        /// </summary>
        public static LocationGranularity SUBDIVISION = new LocationGranularity("SUBDIVISION");

        /// <summary>
        /// Implicit operator declaration to accept and convert a string value as a <see cref="LocationGranularity"/>
        /// </summary>
        /// <param name="value">The value to use</param>
        public static implicit operator LocationGranularity(string value) => new LocationGranularity(value);

        /// <summary>
        /// Creates a new <see cref="LocationGranularity"/> instance.
        /// </summary>
        /// <param name="value">The value to use.</param>
        public LocationGranularity(string value)
            : base(value)
        {
        }
    }


}