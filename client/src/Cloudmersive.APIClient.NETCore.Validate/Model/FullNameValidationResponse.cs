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
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Cloudmersive.APIClient.NETCore.Validate.Client.SwaggerDateConverter;

namespace Cloudmersive.APIClient.NETCore.Validate.Model
{
    /// <summary>
    /// Result of a full name validation operation
    /// </summary>
    [DataContract]
    public partial class FullNameValidationResponse :  IEquatable<FullNameValidationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FullNameValidationResponse" /> class.
        /// </summary>
        /// <param name="Successful">True if the validation operation was successful, false otherwise.</param>
        /// <param name="ValidationResultFirstName">Possible values are: ValidFirstName, ValidUnknownFirstName, InvalidSpamInput, InvalidCharacters, InvalidEmpty.</param>
        /// <param name="ValidationResultLastName">Possible values are: ValidLastName, ValidUnknownLastName, InvalidSpamInput, InvalidCharacters, InvalidEmpty.</param>
        /// <param name="Title">The person&#39;s title (if supplied), e.g. \&quot;Mr.\&quot; or \&quot;Ms.\&quot;.</param>
        /// <param name="FirstName">The first name (given name).</param>
        /// <param name="MiddleName">The middle name(s); if there are multiple names they will be separated by spaces.</param>
        /// <param name="LastName">The last name (surname).</param>
        /// <param name="NickName">Nickname (if supplied).</param>
        /// <param name="Suffix">Suffix to the name, e.g. \&quot;Jr.\&quot; or \&quot;Sr.\&quot;.</param>
        /// <param name="DisplayName">The full display name of the name.</param>
        public FullNameValidationResponse(bool? Successful = default(bool?), string ValidationResultFirstName = default(string), string ValidationResultLastName = default(string), string Title = default(string), string FirstName = default(string), string MiddleName = default(string), string LastName = default(string), string NickName = default(string), string Suffix = default(string), string DisplayName = default(string))
        {
            this.Successful = Successful;
            this.ValidationResultFirstName = ValidationResultFirstName;
            this.ValidationResultLastName = ValidationResultLastName;
            this.Title = Title;
            this.FirstName = FirstName;
            this.MiddleName = MiddleName;
            this.LastName = LastName;
            this.NickName = NickName;
            this.Suffix = Suffix;
            this.DisplayName = DisplayName;
        }
        
        /// <summary>
        /// True if the validation operation was successful, false otherwise
        /// </summary>
        /// <value>True if the validation operation was successful, false otherwise</value>
        [DataMember(Name="Successful", EmitDefaultValue=false)]
        public bool? Successful { get; set; }

        /// <summary>
        /// Possible values are: ValidFirstName, ValidUnknownFirstName, InvalidSpamInput, InvalidCharacters, InvalidEmpty
        /// </summary>
        /// <value>Possible values are: ValidFirstName, ValidUnknownFirstName, InvalidSpamInput, InvalidCharacters, InvalidEmpty</value>
        [DataMember(Name="ValidationResult_FirstName", EmitDefaultValue=false)]
        public string ValidationResultFirstName { get; set; }

        /// <summary>
        /// Possible values are: ValidLastName, ValidUnknownLastName, InvalidSpamInput, InvalidCharacters, InvalidEmpty
        /// </summary>
        /// <value>Possible values are: ValidLastName, ValidUnknownLastName, InvalidSpamInput, InvalidCharacters, InvalidEmpty</value>
        [DataMember(Name="ValidationResult_LastName", EmitDefaultValue=false)]
        public string ValidationResultLastName { get; set; }

        /// <summary>
        /// The person&#39;s title (if supplied), e.g. \&quot;Mr.\&quot; or \&quot;Ms.\&quot;
        /// </summary>
        /// <value>The person&#39;s title (if supplied), e.g. \&quot;Mr.\&quot; or \&quot;Ms.\&quot;</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// The first name (given name)
        /// </summary>
        /// <value>The first name (given name)</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name(s); if there are multiple names they will be separated by spaces
        /// </summary>
        /// <value>The middle name(s); if there are multiple names they will be separated by spaces</value>
        [DataMember(Name="MiddleName", EmitDefaultValue=false)]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name (surname)
        /// </summary>
        /// <value>The last name (surname)</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Nickname (if supplied)
        /// </summary>
        /// <value>Nickname (if supplied)</value>
        [DataMember(Name="NickName", EmitDefaultValue=false)]
        public string NickName { get; set; }

        /// <summary>
        /// Suffix to the name, e.g. \&quot;Jr.\&quot; or \&quot;Sr.\&quot;
        /// </summary>
        /// <value>Suffix to the name, e.g. \&quot;Jr.\&quot; or \&quot;Sr.\&quot;</value>
        [DataMember(Name="Suffix", EmitDefaultValue=false)]
        public string Suffix { get; set; }

        /// <summary>
        /// The full display name of the name
        /// </summary>
        /// <value>The full display name of the name</value>
        [DataMember(Name="DisplayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FullNameValidationResponse {\n");
            sb.Append("  Successful: ").Append(Successful).Append("\n");
            sb.Append("  ValidationResultFirstName: ").Append(ValidationResultFirstName).Append("\n");
            sb.Append("  ValidationResultLastName: ").Append(ValidationResultLastName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  MiddleName: ").Append(MiddleName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  NickName: ").Append(NickName).Append("\n");
            sb.Append("  Suffix: ").Append(Suffix).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(input as FullNameValidationResponse);
        }

        /// <summary>
        /// Returns true if FullNameValidationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of FullNameValidationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FullNameValidationResponse input)
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
                    this.ValidationResultFirstName == input.ValidationResultFirstName ||
                    (this.ValidationResultFirstName != null &&
                    this.ValidationResultFirstName.Equals(input.ValidationResultFirstName))
                ) && 
                (
                    this.ValidationResultLastName == input.ValidationResultLastName ||
                    (this.ValidationResultLastName != null &&
                    this.ValidationResultLastName.Equals(input.ValidationResultLastName))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.MiddleName == input.MiddleName ||
                    (this.MiddleName != null &&
                    this.MiddleName.Equals(input.MiddleName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.NickName == input.NickName ||
                    (this.NickName != null &&
                    this.NickName.Equals(input.NickName))
                ) && 
                (
                    this.Suffix == input.Suffix ||
                    (this.Suffix != null &&
                    this.Suffix.Equals(input.Suffix))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
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
                if (this.ValidationResultFirstName != null)
                    hashCode = hashCode * 59 + this.ValidationResultFirstName.GetHashCode();
                if (this.ValidationResultLastName != null)
                    hashCode = hashCode * 59 + this.ValidationResultLastName.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.MiddleName != null)
                    hashCode = hashCode * 59 + this.MiddleName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.NickName != null)
                    hashCode = hashCode * 59 + this.NickName.GetHashCode();
                if (this.Suffix != null)
                    hashCode = hashCode * 59 + this.Suffix.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
