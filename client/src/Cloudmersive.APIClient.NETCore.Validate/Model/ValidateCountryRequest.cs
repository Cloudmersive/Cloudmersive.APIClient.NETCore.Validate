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
    /// Input parameter to a country validation request
    /// </summary>
    [DataContract]
    public partial class ValidateCountryRequest :  IEquatable<ValidateCountryRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateCountryRequest" /> class.
        /// </summary>
        /// <param name="rawCountryInput">Raw country input - can be a two-letter code (FIPS 10-4 or ISO 3166-1), three-letter code (ISO 3166-1) or country name.</param>
        public ValidateCountryRequest(string rawCountryInput = default(string))
        {
            this.RawCountryInput = rawCountryInput;
        }
        
        /// <summary>
        /// Raw country input - can be a two-letter code (FIPS 10-4 or ISO 3166-1), three-letter code (ISO 3166-1) or country name
        /// </summary>
        /// <value>Raw country input - can be a two-letter code (FIPS 10-4 or ISO 3166-1), three-letter code (ISO 3166-1) or country name</value>
        [DataMember(Name="RawCountryInput", EmitDefaultValue=false)]
        public string RawCountryInput { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateCountryRequest {\n");
            sb.Append("  RawCountryInput: ").Append(RawCountryInput).Append("\n");
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
            return this.Equals(input as ValidateCountryRequest);
        }

        /// <summary>
        /// Returns true if ValidateCountryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateCountryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateCountryRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RawCountryInput == input.RawCountryInput ||
                    (this.RawCountryInput != null &&
                    this.RawCountryInput.Equals(input.RawCountryInput))
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
                if (this.RawCountryInput != null)
                    hashCode = hashCode * 59 + this.RawCountryInput.GetHashCode();
                return hashCode;
            }
        }
    }

}