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
    /// Input to a VAT lookup request
    /// </summary>
    [DataContract]
    public partial class VatLookupRequest :  IEquatable<VatLookupRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VatLookupRequest" /> class.
        /// </summary>
        /// <param name="vatCode">VAT code to lookup; example \&quot;CZ25123891\&quot;.</param>
        public VatLookupRequest(string vatCode = default(string))
        {
            this.VatCode = vatCode;
        }
        
        /// <summary>
        /// VAT code to lookup; example \&quot;CZ25123891\&quot;
        /// </summary>
        /// <value>VAT code to lookup; example \&quot;CZ25123891\&quot;</value>
        [DataMember(Name="VatCode", EmitDefaultValue=false)]
        public string VatCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VatLookupRequest {\n");
            sb.Append("  VatCode: ").Append(VatCode).Append("\n");
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
            return this.Equals(input as VatLookupRequest);
        }

        /// <summary>
        /// Returns true if VatLookupRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of VatLookupRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VatLookupRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VatCode == input.VatCode ||
                    (this.VatCode != null &&
                    this.VatCode.Equals(input.VatCode))
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
                if (this.VatCode != null)
                    hashCode = hashCode * 59 + this.VatCode.GetHashCode();
                return hashCode;
            }
        }
    }

}
