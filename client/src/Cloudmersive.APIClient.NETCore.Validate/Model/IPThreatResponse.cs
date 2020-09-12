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
    /// Result of performing a IP threat check on an IP address
    /// </summary>
    [DataContract]
    public partial class IPThreatResponse :  IEquatable<IPThreatResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPThreatResponse" /> class.
        /// </summary>
        /// <param name="isThreat">True if the input IP address is a threat, false otherwise.</param>
        /// <param name="threatType">Specifies the type of IP threat; possible values include Blocklist, Botnet, WebBot.</param>
        public IPThreatResponse(bool? isThreat = default(bool?), string threatType = default(string))
        {
            this.IsThreat = isThreat;
            this.ThreatType = threatType;
        }
        
        /// <summary>
        /// True if the input IP address is a threat, false otherwise
        /// </summary>
        /// <value>True if the input IP address is a threat, false otherwise</value>
        [DataMember(Name="IsThreat", EmitDefaultValue=false)]
        public bool? IsThreat { get; set; }

        /// <summary>
        /// Specifies the type of IP threat; possible values include Blocklist, Botnet, WebBot
        /// </summary>
        /// <value>Specifies the type of IP threat; possible values include Blocklist, Botnet, WebBot</value>
        [DataMember(Name="ThreatType", EmitDefaultValue=false)]
        public string ThreatType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPThreatResponse {\n");
            sb.Append("  IsThreat: ").Append(IsThreat).Append("\n");
            sb.Append("  ThreatType: ").Append(ThreatType).Append("\n");
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
            return this.Equals(input as IPThreatResponse);
        }

        /// <summary>
        /// Returns true if IPThreatResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IPThreatResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPThreatResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsThreat == input.IsThreat ||
                    (this.IsThreat != null &&
                    this.IsThreat.Equals(input.IsThreat))
                ) && 
                (
                    this.ThreatType == input.ThreatType ||
                    (this.ThreatType != null &&
                    this.ThreatType.Equals(input.ThreatType))
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
                if (this.IsThreat != null)
                    hashCode = hashCode * 59 + this.IsThreat.GetHashCode();
                if (this.ThreatType != null)
                    hashCode = hashCode * 59 + this.ThreatType.GetHashCode();
                return hashCode;
            }
        }
    }

}