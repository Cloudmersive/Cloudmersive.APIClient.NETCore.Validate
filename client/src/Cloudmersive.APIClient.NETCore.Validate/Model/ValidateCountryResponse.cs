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
    /// Result of performing a country validation operation
    /// </summary>
    [DataContract]
    public partial class ValidateCountryResponse :  IEquatable<ValidateCountryResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateCountryResponse" /> class.
        /// </summary>
        /// <param name="successful">True if successful, false otherwise.</param>
        /// <param name="countryFullName">Full name of the country.</param>
        /// <param name="iSOTwoLetterCode">Two-letter ISO 3166-1 country code.</param>
        /// <param name="fIPSTwoLetterCode">Two-letter FIPS 10-4 country code.</param>
        /// <param name="threeLetterCode">Three-letter ISO 3166-1 country code.</param>
        /// <param name="isEuropeanUnionMember">True if this country is currently a member of the European Union (EU), false otherwise.</param>
        /// <param name="timezones">Time zones (IANA/Olsen) in the country.</param>
        /// <param name="iSOCurrencyCode">ISO 4217 currency three-letter code associated with the country.</param>
        /// <param name="currencySymbol">Symbol associated with the currency.</param>
        /// <param name="currencyEnglishName">Full name of the currency.</param>
        /// <param name="region">Region (continent) in which the country is located; possible values are None, Europe, Americas, Asia, Africa, Oceania.</param>
        /// <param name="subregion">Subregion in which the country is located; possible values are None, NorthernEurope, WesternEurope, SouthernEurope, EasternEurope, CentralAmerica, NorthernAmerica, SouthAmerica, EasternAfrica, MiddleAfrica, NorthernAfrica , SouthernAfrica , WesternAfrica , CentralAsia , EasternAsia , SouthernAsia , SouthEasternAsia , WesternAsia , Southern , Middle , AustraliaandNewZealand , Melanesia , Polynesia , Micronesia , Caribbean,.</param>
        public ValidateCountryResponse(bool? successful = default(bool?), string countryFullName = default(string), string iSOTwoLetterCode = default(string), string fIPSTwoLetterCode = default(string), string threeLetterCode = default(string), bool? isEuropeanUnionMember = default(bool?), List<Timezone> timezones = default(List<Timezone>), string iSOCurrencyCode = default(string), string currencySymbol = default(string), string currencyEnglishName = default(string), string region = default(string), string subregion = default(string))
        {
            this.Successful = successful;
            this.CountryFullName = countryFullName;
            this.ISOTwoLetterCode = iSOTwoLetterCode;
            this.FIPSTwoLetterCode = fIPSTwoLetterCode;
            this.ThreeLetterCode = threeLetterCode;
            this.IsEuropeanUnionMember = isEuropeanUnionMember;
            this.Timezones = timezones;
            this.ISOCurrencyCode = iSOCurrencyCode;
            this.CurrencySymbol = currencySymbol;
            this.CurrencyEnglishName = currencyEnglishName;
            this.Region = region;
            this.Subregion = subregion;
        }
        
        /// <summary>
        /// True if successful, false otherwise
        /// </summary>
        /// <value>True if successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Full name of the country
        /// </summary>
        /// <value>Full name of the country</value>
        [DataMember(Name="CountryFullName", EmitDefaultValue=false)]
        public string CountryFullName { get; set; }

        /// <summary>
        /// Two-letter ISO 3166-1 country code
        /// </summary>
        /// <value>Two-letter ISO 3166-1 country code</value>
        [DataMember(Name="ISOTwoLetterCode", EmitDefaultValue=false)]
        public string ISOTwoLetterCode { get; set; }

        /// <summary>
        /// Two-letter FIPS 10-4 country code
        /// </summary>
        /// <value>Two-letter FIPS 10-4 country code</value>
        [DataMember(Name="FIPSTwoLetterCode", EmitDefaultValue=false)]
        public string FIPSTwoLetterCode { get; set; }

        /// <summary>
        /// Three-letter ISO 3166-1 country code
        /// </summary>
        /// <value>Three-letter ISO 3166-1 country code</value>
        [DataMember(Name="ThreeLetterCode", EmitDefaultValue=false)]
        public string ThreeLetterCode { get; set; }

        /// <summary>
        /// True if this country is currently a member of the European Union (EU), false otherwise
        /// </summary>
        /// <value>True if this country is currently a member of the European Union (EU), false otherwise</value>
        [DataMember(Name="IsEuropeanUnionMember", EmitDefaultValue=false)]
        public bool? IsEuropeanUnionMember { get; set; }

        /// <summary>
        /// Time zones (IANA/Olsen) in the country
        /// </summary>
        /// <value>Time zones (IANA/Olsen) in the country</value>
        [DataMember(Name="Timezones", EmitDefaultValue=false)]
        public List<Timezone> Timezones { get; set; }

        /// <summary>
        /// ISO 4217 currency three-letter code associated with the country
        /// </summary>
        /// <value>ISO 4217 currency three-letter code associated with the country</value>
        [DataMember(Name="ISOCurrencyCode", EmitDefaultValue=false)]
        public string ISOCurrencyCode { get; set; }

        /// <summary>
        /// Symbol associated with the currency
        /// </summary>
        /// <value>Symbol associated with the currency</value>
        [DataMember(Name="CurrencySymbol", EmitDefaultValue=false)]
        public string CurrencySymbol { get; set; }

        /// <summary>
        /// Full name of the currency
        /// </summary>
        /// <value>Full name of the currency</value>
        [DataMember(Name="CurrencyEnglishName", EmitDefaultValue=false)]
        public string CurrencyEnglishName { get; set; }

        /// <summary>
        /// Region (continent) in which the country is located; possible values are None, Europe, Americas, Asia, Africa, Oceania
        /// </summary>
        /// <value>Region (continent) in which the country is located; possible values are None, Europe, Americas, Asia, Africa, Oceania</value>
        [DataMember(Name="Region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// Subregion in which the country is located; possible values are None, NorthernEurope, WesternEurope, SouthernEurope, EasternEurope, CentralAmerica, NorthernAmerica, SouthAmerica, EasternAfrica, MiddleAfrica, NorthernAfrica , SouthernAfrica , WesternAfrica , CentralAsia , EasternAsia , SouthernAsia , SouthEasternAsia , WesternAsia , Southern , Middle , AustraliaandNewZealand , Melanesia , Polynesia , Micronesia , Caribbean,
        /// </summary>
        /// <value>Subregion in which the country is located; possible values are None, NorthernEurope, WesternEurope, SouthernEurope, EasternEurope, CentralAmerica, NorthernAmerica, SouthAmerica, EasternAfrica, MiddleAfrica, NorthernAfrica , SouthernAfrica , WesternAfrica , CentralAsia , EasternAsia , SouthernAsia , SouthEasternAsia , WesternAsia , Southern , Middle , AustraliaandNewZealand , Melanesia , Polynesia , Micronesia , Caribbean,</value>
        [DataMember(Name="Subregion", EmitDefaultValue=false)]
        public string Subregion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateCountryResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  CountryFullName: ").Append(CountryFullName).Append("\n");
            sb.Append("  ISOTwoLetterCode: ").Append(ISOTwoLetterCode).Append("\n");
            sb.Append("  FIPSTwoLetterCode: ").Append(FIPSTwoLetterCode).Append("\n");
            sb.Append("  ThreeLetterCode: ").Append(ThreeLetterCode).Append("\n");
            sb.Append("  IsEuropeanUnionMember: ").Append(IsEuropeanUnionMember).Append("\n");
            sb.Append("  Timezones: ").Append(Timezones).Append("\n");
            sb.Append("  ISOCurrencyCode: ").Append(ISOCurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  CurrencyEnglishName: ").Append(CurrencyEnglishName).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  Subregion: ").Append(Subregion).Append("\n");
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
            return this.Equals(input as ValidateCountryResponse);
        }

        /// <summary>
        /// Returns true if ValidateCountryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateCountryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateCountryResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Successful == input.Successful ||
                    (this.Successful != null &&
                    this.Successful.Equals(input.Successful))
                ) && 
                (
                    this.CountryFullName == input.CountryFullName ||
                    (this.CountryFullName != null &&
                    this.CountryFullName.Equals(input.CountryFullName))
                ) && 
                (
                    this.ISOTwoLetterCode == input.ISOTwoLetterCode ||
                    (this.ISOTwoLetterCode != null &&
                    this.ISOTwoLetterCode.Equals(input.ISOTwoLetterCode))
                ) && 
                (
                    this.FIPSTwoLetterCode == input.FIPSTwoLetterCode ||
                    (this.FIPSTwoLetterCode != null &&
                    this.FIPSTwoLetterCode.Equals(input.FIPSTwoLetterCode))
                ) && 
                (
                    this.ThreeLetterCode == input.ThreeLetterCode ||
                    (this.ThreeLetterCode != null &&
                    this.ThreeLetterCode.Equals(input.ThreeLetterCode))
                ) && 
                (
                    this.IsEuropeanUnionMember == input.IsEuropeanUnionMember ||
                    (this.IsEuropeanUnionMember != null &&
                    this.IsEuropeanUnionMember.Equals(input.IsEuropeanUnionMember))
                ) && 
                (
                    this.Timezones == input.Timezones ||
                    this.Timezones != null &&
                    this.Timezones.SequenceEqual(input.Timezones)
                ) && 
                (
                    this.ISOCurrencyCode == input.ISOCurrencyCode ||
                    (this.ISOCurrencyCode != null &&
                    this.ISOCurrencyCode.Equals(input.ISOCurrencyCode))
                ) && 
                (
                    this.CurrencySymbol == input.CurrencySymbol ||
                    (this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(input.CurrencySymbol))
                ) && 
                (
                    this.CurrencyEnglishName == input.CurrencyEnglishName ||
                    (this.CurrencyEnglishName != null &&
                    this.CurrencyEnglishName.Equals(input.CurrencyEnglishName))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.Subregion == input.Subregion ||
                    (this.Subregion != null &&
                    this.Subregion.Equals(input.Subregion))
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
                if (this.Successful != null)
                    hashCode = hashCode * 59 + this.Successful.GetHashCode();
                if (this.CountryFullName != null)
                    hashCode = hashCode * 59 + this.CountryFullName.GetHashCode();
                if (this.ISOTwoLetterCode != null)
                    hashCode = hashCode * 59 + this.ISOTwoLetterCode.GetHashCode();
                if (this.FIPSTwoLetterCode != null)
                    hashCode = hashCode * 59 + this.FIPSTwoLetterCode.GetHashCode();
                if (this.ThreeLetterCode != null)
                    hashCode = hashCode * 59 + this.ThreeLetterCode.GetHashCode();
                if (this.IsEuropeanUnionMember != null)
                    hashCode = hashCode * 59 + this.IsEuropeanUnionMember.GetHashCode();
                if (this.Timezones != null)
                    hashCode = hashCode * 59 + this.Timezones.GetHashCode();
                if (this.ISOCurrencyCode != null)
                    hashCode = hashCode * 59 + this.ISOCurrencyCode.GetHashCode();
                if (this.CurrencySymbol != null)
                    hashCode = hashCode * 59 + this.CurrencySymbol.GetHashCode();
                if (this.CurrencyEnglishName != null)
                    hashCode = hashCode * 59 + this.CurrencyEnglishName.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Subregion != null)
                    hashCode = hashCode * 59 + this.Subregion.GetHashCode();
                return hashCode;
            }
        }
    }

}
