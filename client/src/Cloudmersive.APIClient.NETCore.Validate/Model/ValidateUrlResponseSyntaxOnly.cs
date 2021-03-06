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
    /// Result of validating a URL with syntax only
    /// </summary>
    [DataContract]
    public partial class ValidateUrlResponseSyntaxOnly :  IEquatable<ValidateUrlResponseSyntaxOnly>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateUrlResponseSyntaxOnly" /> class.
        /// </summary>
        /// <param name="validURL">True if the URL is valid, false otherwise.</param>
        /// <param name="wellFormedURL">Well-formed version of the URL.</param>
        /// <param name="topLevelDomainName">The top-level domain name of the URL, e.g. mydomain.com.</param>
        public ValidateUrlResponseSyntaxOnly(bool? validURL = default(bool?), string wellFormedURL = default(string), string topLevelDomainName = default(string))
        {
            this.ValidURL = validURL;
            this.WellFormedURL = wellFormedURL;
            this.TopLevelDomainName = topLevelDomainName;
        }
        
        /// <summary>
        /// True if the URL is valid, false otherwise
        /// </summary>
        /// <value>True if the URL is valid, false otherwise</value>
        [DataMember(Name="ValidURL", EmitDefaultValue=false)]
        public bool? ValidURL { get; set; }

        /// <summary>
        /// Well-formed version of the URL
        /// </summary>
        /// <value>Well-formed version of the URL</value>
        [DataMember(Name="WellFormedURL", EmitDefaultValue=false)]
        public string WellFormedURL { get; set; }

        /// <summary>
        /// The top-level domain name of the URL, e.g. mydomain.com
        /// </summary>
        /// <value>The top-level domain name of the URL, e.g. mydomain.com</value>
        [DataMember(Name="TopLevelDomainName", EmitDefaultValue=false)]
        public string TopLevelDomainName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateUrlResponseSyntaxOnly {\n");
            sb.Append("  ValidURL: ").Append(ValidURL).Append("\n");
            sb.Append("  WellFormedURL: ").Append(WellFormedURL).Append("\n");
            sb.Append("  TopLevelDomainName: ").Append(TopLevelDomainName).Append("\n");
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
            return this.Equals(input as ValidateUrlResponseSyntaxOnly);
        }

        /// <summary>
        /// Returns true if ValidateUrlResponseSyntaxOnly instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateUrlResponseSyntaxOnly to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateUrlResponseSyntaxOnly input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidURL == input.ValidURL ||
                    (this.ValidURL != null &&
                    this.ValidURL.Equals(input.ValidURL))
                ) && 
                (
                    this.WellFormedURL == input.WellFormedURL ||
                    (this.WellFormedURL != null &&
                    this.WellFormedURL.Equals(input.WellFormedURL))
                ) && 
                (
                    this.TopLevelDomainName == input.TopLevelDomainName ||
                    (this.TopLevelDomainName != null &&
                    this.TopLevelDomainName.Equals(input.TopLevelDomainName))
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
                if (this.ValidURL != null)
                    hashCode = hashCode * 59 + this.ValidURL.GetHashCode();
                if (this.WellFormedURL != null)
                    hashCode = hashCode * 59 + this.WellFormedURL.GetHashCode();
                if (this.TopLevelDomainName != null)
                    hashCode = hashCode * 59 + this.TopLevelDomainName.GetHashCode();
                return hashCode;
            }
        }
    }

}
