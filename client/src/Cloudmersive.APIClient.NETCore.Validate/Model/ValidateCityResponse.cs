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
    /// Result of validating a city
    /// </summary>
    [DataContract]
    public partial class ValidateCityResponse :  IEquatable<ValidateCityResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateCityResponse" /> class.
        /// </summary>
        /// <param name="validCity">True if the city is valid, false otherwise.</param>
        /// <param name="city">If valid, City corresponding to the input postal code, such as &#39;Walnut Creek&#39;.</param>
        /// <param name="stateOrProvince">If valid; State or province corresponding to the input state name, such as &#39;CA&#39; or &#39;California&#39;.</param>
        /// <param name="latitude">If the postal code is valid, the degrees latitude of the centroid of the state, null otherwise.</param>
        /// <param name="longitude">If the postal code is valid, the degrees longitude of the centroid of the state, null otherwise.</param>
        public ValidateCityResponse(bool? validCity = default(bool?), string city = default(string), string stateOrProvince = default(string), double? latitude = default(double?), double? longitude = default(double?))
        {
            this.ValidCity = validCity;
            this.City = city;
            this.StateOrProvince = stateOrProvince;
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        
        /// <summary>
        /// True if the city is valid, false otherwise
        /// </summary>
        /// <value>True if the city is valid, false otherwise</value>
        [DataMember(Name="ValidCity", EmitDefaultValue=false)]
        public bool? ValidCity { get; set; }

        /// <summary>
        /// If valid, City corresponding to the input postal code, such as &#39;Walnut Creek&#39;
        /// </summary>
        /// <value>If valid, City corresponding to the input postal code, such as &#39;Walnut Creek&#39;</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// If valid; State or province corresponding to the input state name, such as &#39;CA&#39; or &#39;California&#39;
        /// </summary>
        /// <value>If valid; State or province corresponding to the input state name, such as &#39;CA&#39; or &#39;California&#39;</value>
        [DataMember(Name="StateOrProvince", EmitDefaultValue=false)]
        public string StateOrProvince { get; set; }

        /// <summary>
        /// If the postal code is valid, the degrees latitude of the centroid of the state, null otherwise
        /// </summary>
        /// <value>If the postal code is valid, the degrees latitude of the centroid of the state, null otherwise</value>
        [DataMember(Name="Latitude", EmitDefaultValue=false)]
        public double? Latitude { get; set; }

        /// <summary>
        /// If the postal code is valid, the degrees longitude of the centroid of the state, null otherwise
        /// </summary>
        /// <value>If the postal code is valid, the degrees longitude of the centroid of the state, null otherwise</value>
        [DataMember(Name="Longitude", EmitDefaultValue=false)]
        public double? Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateCityResponse {\n");
            sb.Append("  ValidCity: ").Append(ValidCity).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  StateOrProvince: ").Append(StateOrProvince).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as ValidateCityResponse);
        }

        /// <summary>
        /// Returns true if ValidateCityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateCityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateCityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidCity == input.ValidCity ||
                    (this.ValidCity != null &&
                    this.ValidCity.Equals(input.ValidCity))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.StateOrProvince == input.StateOrProvince ||
                    (this.StateOrProvince != null &&
                    this.StateOrProvince.Equals(input.StateOrProvince))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
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
                if (this.ValidCity != null)
                    hashCode = hashCode * 59 + this.ValidCity.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.StateOrProvince != null)
                    hashCode = hashCode * 59 + this.StateOrProvince.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                return hashCode;
            }
        }
    }

}
