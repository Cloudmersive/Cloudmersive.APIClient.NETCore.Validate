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
    /// Result of performing a Bot check on an IP address
    /// </summary>
    [DataContract]
    public partial class BotCheckResponse :  IEquatable<BotCheckResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BotCheckResponse" /> class.
        /// </summary>
        /// <param name="isBot">True if the input IP address is a Bot or Robot, false otherwise.</param>
        public BotCheckResponse(bool? isBot = default(bool?))
        {
            this.IsBot = isBot;
        }
        
        /// <summary>
        /// True if the input IP address is a Bot or Robot, false otherwise
        /// </summary>
        /// <value>True if the input IP address is a Bot or Robot, false otherwise</value>
        [DataMember(Name="IsBot", EmitDefaultValue=false)]
        public bool? IsBot { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotCheckResponse {\n");
            sb.Append("  IsBot: ").Append(IsBot).Append("\n");
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
            return this.Equals(input as BotCheckResponse);
        }

        /// <summary>
        /// Returns true if BotCheckResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BotCheckResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotCheckResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsBot == input.IsBot ||
                    (this.IsBot != null &&
                    this.IsBot.Equals(input.IsBot))
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
                if (this.IsBot != null)
                    hashCode = hashCode * 59 + this.IsBot.GetHashCode();
                return hashCode;
            }
        }
    }

}
