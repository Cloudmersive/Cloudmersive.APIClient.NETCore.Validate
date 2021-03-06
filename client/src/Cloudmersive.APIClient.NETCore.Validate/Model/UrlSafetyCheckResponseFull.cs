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
    /// Result of checking a URL for safety threats
    /// </summary>
    [DataContract]
    public partial class UrlSafetyCheckResponseFull :  IEquatable<UrlSafetyCheckResponseFull>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UrlSafetyCheckResponseFull" /> class.
        /// </summary>
        /// <param name="cleanURL">True if the URL is clean, false if it is at risk of containing a safety threat or attack.</param>
        /// <param name="threatType">Threat type identified, if any; possible values are \&quot;ForcedDownload\&quot;, \&quot;VirusesAndMalware\&quot;, \&quot;Phishing\&quot;.</param>
        public UrlSafetyCheckResponseFull(bool? cleanURL = default(bool?), string threatType = default(string))
        {
            this.CleanURL = cleanURL;
            this.ThreatType = threatType;
        }
        
        /// <summary>
        /// True if the URL is clean, false if it is at risk of containing a safety threat or attack
        /// </summary>
        /// <value>True if the URL is clean, false if it is at risk of containing a safety threat or attack</value>
        [DataMember(Name="CleanURL", EmitDefaultValue=false)]
        public bool? CleanURL { get; set; }

        /// <summary>
        /// Threat type identified, if any; possible values are \&quot;ForcedDownload\&quot;, \&quot;VirusesAndMalware\&quot;, \&quot;Phishing\&quot;
        /// </summary>
        /// <value>Threat type identified, if any; possible values are \&quot;ForcedDownload\&quot;, \&quot;VirusesAndMalware\&quot;, \&quot;Phishing\&quot;</value>
        [DataMember(Name="ThreatType", EmitDefaultValue=false)]
        public string ThreatType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UrlSafetyCheckResponseFull {\n");
            sb.Append("  CleanURL: ").Append(CleanURL).Append("\n");
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
            return this.Equals(input as UrlSafetyCheckResponseFull);
        }

        /// <summary>
        /// Returns true if UrlSafetyCheckResponseFull instances are equal
        /// </summary>
        /// <param name="input">Instance of UrlSafetyCheckResponseFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UrlSafetyCheckResponseFull input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CleanURL == input.CleanURL ||
                    (this.CleanURL != null &&
                    this.CleanURL.Equals(input.CleanURL))
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
                if (this.CleanURL != null)
                    hashCode = hashCode * 59 + this.CleanURL.GetHashCode();
                if (this.ThreatType != null)
                    hashCode = hashCode * 59 + this.ThreatType.GetHashCode();
                return hashCode;
            }
        }
    }

}
