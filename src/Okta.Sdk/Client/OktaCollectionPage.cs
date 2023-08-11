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
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Okta.Sdk.Client
{
    /// <summary>
    /// Represents a page of resources in an Okta API collection.
    /// </summary>
    /// <remarks>See <a href="https://developer.okta.com/docs/api/getting_started/design_principles.html#pagination">the API documentation on pagination</a>.</remarks>
    /// <typeparam name="T">The resource type of this collection.</typeparam>
    public class OktaCollectionPage<T>
    {
        /// <summary>
        /// Gets or sets the items in this page.
        /// </summary>
        /// <value>
        /// The items in this page.
        /// </value>
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        /// Gets or sets the HTTP response returned from the Okta API when fetching this page.
        /// </summary>
        /// <value>
        /// The HTTP response returned from the Okta API when fetching this page.
        /// </value>
        public ApiResponse<IEnumerable<T>> Response { get; set; }

        /// <summary>
        /// Gets or sets the link to get the next page of results, if any.
        /// </summary>
        /// <value>
        /// The link to get the next page of results. If there is no next page, this will be <c>null</c>.
        /// </value>
        public WebLink NextLink { get; set; }
    }
}
