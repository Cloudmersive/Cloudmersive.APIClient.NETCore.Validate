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
    /// IP address intelligence result
    /// </summary>
    [DataContract]
    public partial class IPIntelligenceResponse :  IEquatable<IPIntelligenceResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IPIntelligenceResponse" /> class.
        /// </summary>
        /// <param name="isBot">True if the IP address is a known bot, otherwise false.</param>
        /// <param name="isTorNode">True if the IP address is a known Tor exit node, otherwise false.</param>
        /// <param name="isThreat">True if the IP address is a known threat IP, otherwise false.</param>
        /// <param name="isEU">True if the IP address is in the European Union, otherwise false.</param>
        /// <param name="location">Returns the location of the IP address.</param>
        /// <param name="currencyCode">ISO 4217 currency code for the IP address location.</param>
        /// <param name="currencyName">Name of the currency in English.</param>
        /// <param name="regionArea">Region (continent) in which the country is located; possible values are None, Europe, Americas, Asia, Africa, Oceania.</param>
        /// <param name="subregionArea">Subregion in which the country is located; possible values are None, NorthernEurope, WesternEurope, SouthernEurope, EasternEurope, CentralAmerica, NorthernAmerica, SouthAmerica, EasternAfrica, MiddleAfrica, NorthernAfrica , SouthernAfrica , WesternAfrica , CentralAsia , EasternAsia , SouthernAsia , SouthEasternAsia , WesternAsia , Southern , Middle , AustraliaandNewZealand , Melanesia , Polynesia , Micronesia , Caribbean,.</param>
        public IPIntelligenceResponse(bool? isBot = default(bool?), bool? isTorNode = default(bool?), bool? isThreat = default(bool?), bool? isEU = default(bool?), GeolocateResponse location = default(GeolocateResponse), string currencyCode = default(string), string currencyName = default(string), string regionArea = default(string), string subregionArea = default(string))
        {
            this.IsBot = isBot;
            this.IsTorNode = isTorNode;
            this.IsThreat = isThreat;
            this.IsEU = isEU;
            this.Location = location;
            this.CurrencyCode = currencyCode;
            this.CurrencyName = currencyName;
            this.RegionArea = regionArea;
            this.SubregionArea = subregionArea;
        }
        
        /// <summary>
        /// True if the IP address is a known bot, otherwise false
        /// </summary>
        /// <value>True if the IP address is a known bot, otherwise false</value>
        [DataMember(Name="IsBot", EmitDefaultValue=false)]
        public bool? IsBot { get; set; }

        /// <summary>
        /// True if the IP address is a known Tor exit node, otherwise false
        /// </summary>
        /// <value>True if the IP address is a known Tor exit node, otherwise false</value>
        [DataMember(Name="IsTorNode", EmitDefaultValue=false)]
        public bool? IsTorNode { get; set; }

        /// <summary>
        /// True if the IP address is a known threat IP, otherwise false
        /// </summary>
        /// <value>True if the IP address is a known threat IP, otherwise false</value>
        [DataMember(Name="IsThreat", EmitDefaultValue=false)]
        public bool? IsThreat { get; set; }

        /// <summary>
        /// True if the IP address is in the European Union, otherwise false
        /// </summary>
        /// <value>True if the IP address is in the European Union, otherwise false</value>
        [DataMember(Name="IsEU", EmitDefaultValue=false)]
        public bool? IsEU { get; set; }

        /// <summary>
        /// Returns the location of the IP address
        /// </summary>
        /// <value>Returns the location of the IP address</value>
        [DataMember(Name="Location", EmitDefaultValue=false)]
        public GeolocateResponse Location { get; set; }

        /// <summary>
        /// ISO 4217 currency code for the IP address location
        /// </summary>
        /// <value>ISO 4217 currency code for the IP address location</value>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Name of the currency in English
        /// </summary>
        /// <value>Name of the currency in English</value>
        [DataMember(Name="CurrencyName", EmitDefaultValue=false)]
        public string CurrencyName { get; set; }

        /// <summary>
        /// Region (continent) in which the country is located; possible values are None, Europe, Americas, Asia, Africa, Oceania
        /// </summary>
        /// <value>Region (continent) in which the country is located; possible values are None, Europe, Americas, Asia, Africa, Oceania</value>
        [DataMember(Name="RegionArea", EmitDefaultValue=false)]
        public string RegionArea { get; set; }

        /// <summary>
        /// Subregion in which the country is located; possible values are None, NorthernEurope, WesternEurope, SouthernEurope, EasternEurope, CentralAmerica, NorthernAmerica, SouthAmerica, EasternAfrica, MiddleAfrica, NorthernAfrica , SouthernAfrica , WesternAfrica , CentralAsia , EasternAsia , SouthernAsia , SouthEasternAsia , WesternAsia , Southern , Middle , AustraliaandNewZealand , Melanesia , Polynesia , Micronesia , Caribbean,
        /// </summary>
        /// <value>Subregion in which the country is located; possible values are None, NorthernEurope, WesternEurope, SouthernEurope, EasternEurope, CentralAmerica, NorthernAmerica, SouthAmerica, EasternAfrica, MiddleAfrica, NorthernAfrica , SouthernAfrica , WesternAfrica , CentralAsia , EasternAsia , SouthernAsia , SouthEasternAsia , WesternAsia , Southern , Middle , AustraliaandNewZealand , Melanesia , Polynesia , Micronesia , Caribbean,</value>
        [DataMember(Name="SubregionArea", EmitDefaultValue=false)]
        public string SubregionArea { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPIntelligenceResponse {\n");
            sb.Append("  IsBot: ").Append(IsBot).Append("\n");
            sb.Append("  IsTorNode: ").Append(IsTorNode).Append("\n");
            sb.Append("  IsThreat: ").Append(IsThreat).Append("\n");
            sb.Append("  IsEU: ").Append(IsEU).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencyName: ").Append(CurrencyName).Append("\n");
            sb.Append("  RegionArea: ").Append(RegionArea).Append("\n");
            sb.Append("  SubregionArea: ").Append(SubregionArea).Append("\n");
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
            return this.Equals(input as IPIntelligenceResponse);
        }

        /// <summary>
        /// Returns true if IPIntelligenceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of IPIntelligenceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPIntelligenceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsBot == input.IsBot ||
                    (this.IsBot != null &&
                    this.IsBot.Equals(input.IsBot))
                ) && 
                (
                    this.IsTorNode == input.IsTorNode ||
                    (this.IsTorNode != null &&
                    this.IsTorNode.Equals(input.IsTorNode))
                ) && 
                (
                    this.IsThreat == input.IsThreat ||
                    (this.IsThreat != null &&
                    this.IsThreat.Equals(input.IsThreat))
                ) && 
                (
                    this.IsEU == input.IsEU ||
                    (this.IsEU != null &&
                    this.IsEU.Equals(input.IsEU))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.CurrencyName == input.CurrencyName ||
                    (this.CurrencyName != null &&
                    this.CurrencyName.Equals(input.CurrencyName))
                ) && 
                (
                    this.RegionArea == input.RegionArea ||
                    (this.RegionArea != null &&
                    this.RegionArea.Equals(input.RegionArea))
                ) && 
                (
                    this.SubregionArea == input.SubregionArea ||
                    (this.SubregionArea != null &&
                    this.SubregionArea.Equals(input.SubregionArea))
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
                if (this.IsTorNode != null)
                    hashCode = hashCode * 59 + this.IsTorNode.GetHashCode();
                if (this.IsThreat != null)
                    hashCode = hashCode * 59 + this.IsThreat.GetHashCode();
                if (this.IsEU != null)
                    hashCode = hashCode * 59 + this.IsEU.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.CurrencyCode != null)
                    hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencyName != null)
                    hashCode = hashCode * 59 + this.CurrencyName.GetHashCode();
                if (this.RegionArea != null)
                    hashCode = hashCode * 59 + this.RegionArea.GetHashCode();
                if (this.SubregionArea != null)
                    hashCode = hashCode * 59 + this.SubregionArea.GetHashCode();
                return hashCode;
            }
        }
    }

}
