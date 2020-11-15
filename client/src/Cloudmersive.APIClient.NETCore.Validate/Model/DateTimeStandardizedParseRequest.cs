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
    /// Input parameter to a date time parsing request
    /// </summary>
    [DataContract]
    public partial class DateTimeStandardizedParseRequest :  IEquatable<DateTimeStandardizedParseRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateTimeStandardizedParseRequest" /> class.
        /// </summary>
        /// <param name="rawDateTimeInput">Raw string input of a standard-formatted date and time for parsing.</param>
        /// <param name="countryCode">Optional: specify the two-letter country code to optimzie date formatting; default is US.</param>
        public DateTimeStandardizedParseRequest(string rawDateTimeInput = default(string), string countryCode = default(string))
        {
            this.RawDateTimeInput = rawDateTimeInput;
            this.CountryCode = countryCode;
        }
        
        /// <summary>
        /// Raw string input of a standard-formatted date and time for parsing
        /// </summary>
        /// <value>Raw string input of a standard-formatted date and time for parsing</value>
        [DataMember(Name="RawDateTimeInput", EmitDefaultValue=false)]
        public string RawDateTimeInput { get; set; }

        /// <summary>
        /// Optional: specify the two-letter country code to optimzie date formatting; default is US
        /// </summary>
        /// <value>Optional: specify the two-letter country code to optimzie date formatting; default is US</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateTimeStandardizedParseRequest {\n");
            sb.Append("  RawDateTimeInput: ").Append(RawDateTimeInput).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as DateTimeStandardizedParseRequest);
        }

        /// <summary>
        /// Returns true if DateTimeStandardizedParseRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DateTimeStandardizedParseRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateTimeStandardizedParseRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RawDateTimeInput == input.RawDateTimeInput ||
                    (this.RawDateTimeInput != null &&
                    this.RawDateTimeInput.Equals(input.RawDateTimeInput))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                if (this.RawDateTimeInput != null)
                    hashCode = hashCode * 59 + this.RawDateTimeInput.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                return hashCode;
            }
        }
    }

}