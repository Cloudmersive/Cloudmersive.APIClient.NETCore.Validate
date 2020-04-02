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
    /// Request to validate a phone number
    /// </summary>
    [DataContract]
    public partial class PhoneNumberValidateRequest :  IEquatable<PhoneNumberValidateRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberValidateRequest" /> class.
        /// </summary>
        /// <param name="phoneNumber">Raw phone number string to parse as input for validation.</param>
        /// <param name="defaultCountryCode">Optional, default country code.  If left blank, will default to \&quot;US\&quot;..</param>
        public PhoneNumberValidateRequest(string phoneNumber = default(string), string defaultCountryCode = default(string))
        {
            this.PhoneNumber = phoneNumber;
            this.DefaultCountryCode = defaultCountryCode;
        }
        
        /// <summary>
        /// Raw phone number string to parse as input for validation
        /// </summary>
        /// <value>Raw phone number string to parse as input for validation</value>
        [DataMember(Name="PhoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Optional, default country code.  If left blank, will default to \&quot;US\&quot;.
        /// </summary>
        /// <value>Optional, default country code.  If left blank, will default to \&quot;US\&quot;.</value>
        [DataMember(Name="DefaultCountryCode", EmitDefaultValue=false)]
        public string DefaultCountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PhoneNumberValidateRequest {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  DefaultCountryCode: ").Append(DefaultCountryCode).Append("\n");
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
            return this.Equals(input as PhoneNumberValidateRequest);
        }

        /// <summary>
        /// Returns true if PhoneNumberValidateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumberValidateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumberValidateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.DefaultCountryCode == input.DefaultCountryCode ||
                    (this.DefaultCountryCode != null &&
                    this.DefaultCountryCode.Equals(input.DefaultCountryCode))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.DefaultCountryCode != null)
                    hashCode = hashCode * 59 + this.DefaultCountryCode.GetHashCode();
                return hashCode;
            }
        }
    }

}
