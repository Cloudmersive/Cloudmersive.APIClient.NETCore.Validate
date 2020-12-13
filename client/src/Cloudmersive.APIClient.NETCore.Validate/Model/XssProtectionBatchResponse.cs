/* 
 * validateapi
 *
 * The validation APIs help you validate data. Check if an E-mail address is real. Check if a domain is real. Check up on an IP address, and even where it is located. All this and much more is available in the validation API.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.Validate.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.Validate.Model
{
    /// <summary>
    /// Result of performing a batch XSS protection operation
    /// </summary>
    [DataContract]
    public partial class XssProtectionBatchResponse :  IEquatable<XssProtectionBatchResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XssProtectionBatchResponse" /> class.
        /// </summary>
        /// <param name="resultItems">Results from performing a batch XSS protection operation.</param>
        public XssProtectionBatchResponse(List<XssProtectionResult> resultItems = default(List<XssProtectionResult>))
        {
            this.ResultItems = resultItems;
        }
        
        /// <summary>
        /// Results from performing a batch XSS protection operation
        /// </summary>
        /// <value>Results from performing a batch XSS protection operation</value>
        [DataMember(Name="ResultItems", EmitDefaultValue=false)]
        public List<XssProtectionResult> ResultItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XssProtectionBatchResponse {\n");
            sb.Append("  ResultItems: ").Append(ResultItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as XssProtectionBatchResponse);
        }

        /// <summary>
        /// Returns true if XssProtectionBatchResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of XssProtectionBatchResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(XssProtectionBatchResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResultItems == input.ResultItems ||
                    this.ResultItems != null &&
                    this.ResultItems.SequenceEqual(input.ResultItems)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResultItems != null)
                    hashCode = hashCode * 59 + this.ResultItems.GetHashCode();
                return hashCode;
            }
        }
    }

}
