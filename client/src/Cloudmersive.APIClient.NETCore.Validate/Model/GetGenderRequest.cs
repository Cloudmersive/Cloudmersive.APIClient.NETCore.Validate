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
    /// Request to get the gender from a first name
    /// </summary>
    [DataContract]
    public partial class GetGenderRequest :  IEquatable<GetGenderRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetGenderRequest" /> class.
        /// </summary>
        /// <param name="firstName">Input first name (given name) to get the gender of.</param>
        /// <param name="countryCode">Optional; the country for this name, possible values are \&quot;US\&quot;, \&quot;LY\&quot;, \&quot;NI\&quot;, \&quot;TT\&quot;, \&quot;MK\&quot;, \&quot;KZ\&quot;, \&quot;BO\&quot;, \&quot;UG\&quot;, \&quot;TZ\&quot;, \&quot;CL\&quot;, \&quot;SI\&quot;, \&quot;MA\&quot;, \&quot;RW\&quot;, \&quot;VN\&quot;, \&quot;AW\&quot;, \&quot;CY\&quot;, \&quot;BH\&quot;, \&quot;SG\&quot;, \&quot;ZA\&quot;, \&quot;MU\&quot;, \&quot;BR\&quot;, \&quot;TN\&quot;, \&quot;KH\&quot;, \&quot;US\&quot;, \&quot;TH\&quot;, \&quot;TW\&quot;, \&quot;UY\&quot;, \&quot;DO\&quot;, \&quot;CO\&quot;, \&quot;UA\&quot;, \&quot;QA\&quot;, \&quot;BY\&quot;, \&quot;SN\&quot;, \&quot;SD\&quot;, \&quot;FJ\&quot;, \&quot;LB\&quot;, \&quot;BE\&quot;, \&quot;ML\&quot;, \&quot;LV\&quot;, \&quot;FR\&quot;, \&quot;TM\&quot;, \&quot;NG\&quot;, \&quot;EC\&quot;, \&quot;NO\&quot;, \&quot;SL\&quot;, \&quot;CR\&quot;, \&quot;PA\&quot;, \&quot;GE\&quot;, \&quot;CH\&quot;, \&quot;KR\&quot;, \&quot;RS\&quot;, \&quot;ZM\&quot;, \&quot;FI\&quot;, \&quot;BF\&quot;, \&quot;MC\&quot;, \&quot;AU\&quot;, \&quot;GA\&quot;, \&quot;LS\&quot;, \&quot;RU\&quot;, \&quot;IN\&quot;, \&quot;SE\&quot;, \&quot;LK\&quot;, \&quot;BZ\&quot;, \&quot;MX\&quot;, \&quot;GH\&quot;, \&quot;AF\&quot;, \&quot;TJ\&quot;, \&quot;BN\&quot;, \&quot;DZ\&quot;, \&quot;CM\&quot;, \&quot;GR\&quot;, \&quot;MD\&quot;, \&quot;HN\&quot;, \&quot;AT\&quot;, \&quot;NZ\&quot;, \&quot;SV\&quot;, \&quot;GW\&quot;, \&quot;NA\&quot;, \&quot;AR\&quot;, \&quot;MZ\&quot;, \&quot;PK\&quot;, \&quot;MN\&quot;, \&quot;IQ\&quot;, \&quot;BW\&quot;, \&quot;VE\&quot;, \&quot;PT\&quot;, \&quot;BS\&quot;, \&quot;AL\&quot;, \&quot;TG\&quot;, \&quot;ID\&quot;, \&quot;ET\&quot;, \&quot;CF\&quot;, \&quot;JP\&quot;, \&quot;BB\&quot;, \&quot;PH\&quot;, \&quot;CU\&quot;, \&quot;BD\&quot;, \&quot;AO\&quot;, \&quot;SM\&quot;, \&quot;LC\&quot;, \&quot;ME\&quot;, \&quot;RO\&quot;,  DANIL\&quot;O\&quot;\&quot;, \&quot;ES\&quot;, \&quot;EE\&quot;, \&quot;IL\&quot;, \&quot;ZW\&quot;, \&quot;SY\&quot;, \&quot;MW\&quot;, \&quot;LU\&quot;, \&quot;IR\&quot;, \&quot;SC\&quot;, \&quot;NL\&quot;, \&quot;JO\&quot;, \&quot;AM\&quot;, \&quot;DE\&quot;, \&quot;GL\&quot;, \&quot;OM\&quot;, \&quot;DK\&quot;, \&quot;HR\&quot;, \&quot;LI\&quot;, \&quot;TD\&quot;, \&quot;KM\&quot;, \&quot;BA\&quot;, \&quot;GM\&quot;, \&quot;GD\&quot;, \&quot;CA\&quot;, \&quot;CZ\&quot;, \&quot;MR\&quot;, \&quot;ST\&quot;, \&quot;IS\&quot;, \&quot;LR\&quot;, \&quot;IE\&quot;, \&quot;VC\&quot;, \&quot;AE\&quot;, \&quot;KG\&quot;, \&quot;DJ\&quot;, \&quot;TR\&quot;, \&quot;KE\&quot;, \&quot;NE\&quot;, \&quot;UZ\&quot;, \&quot;CN\&quot;, \&quot;GQ\&quot;, \&quot;SK\&quot;, \&quot;BJ\&quot;, \&quot;MG\&quot;, \&quot;BT\&quot;, \&quot;EG\&quot;, \&quot;PL\&quot;, \&quot;IT\&quot;, \&quot;SA\&quot;, \&quot;MY\&quot;, \&quot;CI\&quot;, \&quot;AG\&quot;, \&quot;AD\&quot;, \&quot;KS\&quot;, \&quot;HU\&quot;, \&quot;CG\&quot;, \&quot;KP\&quot;, \&quot;DM\&quot;, \&quot;GN\&quot;, \&quot;GT\&quot;, \&quot;NP\&quot;, \&quot;JM\&quot;, \&quot;LA\&quot;, \&quot;GB\&quot;, \&quot;BG\&quot;, \&quot;HT\&quot;, \&quot;PE\&quot;, \&quot;AZ\&quot;, \&quot;LT\&quot;, \&quot;SZ\&quot;, \&quot;PY\&quot;, \&quot;MT\&quot;, \&quot;VA\&quot;.</param>
        public GetGenderRequest(string firstName = default(string), string countryCode = default(string))
        {
            this.FirstName = firstName;
            this.CountryCode = countryCode;
        }
        
        /// <summary>
        /// Input first name (given name) to get the gender of
        /// </summary>
        /// <value>Input first name (given name) to get the gender of</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Optional; the country for this name, possible values are \&quot;US\&quot;, \&quot;LY\&quot;, \&quot;NI\&quot;, \&quot;TT\&quot;, \&quot;MK\&quot;, \&quot;KZ\&quot;, \&quot;BO\&quot;, \&quot;UG\&quot;, \&quot;TZ\&quot;, \&quot;CL\&quot;, \&quot;SI\&quot;, \&quot;MA\&quot;, \&quot;RW\&quot;, \&quot;VN\&quot;, \&quot;AW\&quot;, \&quot;CY\&quot;, \&quot;BH\&quot;, \&quot;SG\&quot;, \&quot;ZA\&quot;, \&quot;MU\&quot;, \&quot;BR\&quot;, \&quot;TN\&quot;, \&quot;KH\&quot;, \&quot;US\&quot;, \&quot;TH\&quot;, \&quot;TW\&quot;, \&quot;UY\&quot;, \&quot;DO\&quot;, \&quot;CO\&quot;, \&quot;UA\&quot;, \&quot;QA\&quot;, \&quot;BY\&quot;, \&quot;SN\&quot;, \&quot;SD\&quot;, \&quot;FJ\&quot;, \&quot;LB\&quot;, \&quot;BE\&quot;, \&quot;ML\&quot;, \&quot;LV\&quot;, \&quot;FR\&quot;, \&quot;TM\&quot;, \&quot;NG\&quot;, \&quot;EC\&quot;, \&quot;NO\&quot;, \&quot;SL\&quot;, \&quot;CR\&quot;, \&quot;PA\&quot;, \&quot;GE\&quot;, \&quot;CH\&quot;, \&quot;KR\&quot;, \&quot;RS\&quot;, \&quot;ZM\&quot;, \&quot;FI\&quot;, \&quot;BF\&quot;, \&quot;MC\&quot;, \&quot;AU\&quot;, \&quot;GA\&quot;, \&quot;LS\&quot;, \&quot;RU\&quot;, \&quot;IN\&quot;, \&quot;SE\&quot;, \&quot;LK\&quot;, \&quot;BZ\&quot;, \&quot;MX\&quot;, \&quot;GH\&quot;, \&quot;AF\&quot;, \&quot;TJ\&quot;, \&quot;BN\&quot;, \&quot;DZ\&quot;, \&quot;CM\&quot;, \&quot;GR\&quot;, \&quot;MD\&quot;, \&quot;HN\&quot;, \&quot;AT\&quot;, \&quot;NZ\&quot;, \&quot;SV\&quot;, \&quot;GW\&quot;, \&quot;NA\&quot;, \&quot;AR\&quot;, \&quot;MZ\&quot;, \&quot;PK\&quot;, \&quot;MN\&quot;, \&quot;IQ\&quot;, \&quot;BW\&quot;, \&quot;VE\&quot;, \&quot;PT\&quot;, \&quot;BS\&quot;, \&quot;AL\&quot;, \&quot;TG\&quot;, \&quot;ID\&quot;, \&quot;ET\&quot;, \&quot;CF\&quot;, \&quot;JP\&quot;, \&quot;BB\&quot;, \&quot;PH\&quot;, \&quot;CU\&quot;, \&quot;BD\&quot;, \&quot;AO\&quot;, \&quot;SM\&quot;, \&quot;LC\&quot;, \&quot;ME\&quot;, \&quot;RO\&quot;,  DANIL\&quot;O\&quot;\&quot;, \&quot;ES\&quot;, \&quot;EE\&quot;, \&quot;IL\&quot;, \&quot;ZW\&quot;, \&quot;SY\&quot;, \&quot;MW\&quot;, \&quot;LU\&quot;, \&quot;IR\&quot;, \&quot;SC\&quot;, \&quot;NL\&quot;, \&quot;JO\&quot;, \&quot;AM\&quot;, \&quot;DE\&quot;, \&quot;GL\&quot;, \&quot;OM\&quot;, \&quot;DK\&quot;, \&quot;HR\&quot;, \&quot;LI\&quot;, \&quot;TD\&quot;, \&quot;KM\&quot;, \&quot;BA\&quot;, \&quot;GM\&quot;, \&quot;GD\&quot;, \&quot;CA\&quot;, \&quot;CZ\&quot;, \&quot;MR\&quot;, \&quot;ST\&quot;, \&quot;IS\&quot;, \&quot;LR\&quot;, \&quot;IE\&quot;, \&quot;VC\&quot;, \&quot;AE\&quot;, \&quot;KG\&quot;, \&quot;DJ\&quot;, \&quot;TR\&quot;, \&quot;KE\&quot;, \&quot;NE\&quot;, \&quot;UZ\&quot;, \&quot;CN\&quot;, \&quot;GQ\&quot;, \&quot;SK\&quot;, \&quot;BJ\&quot;, \&quot;MG\&quot;, \&quot;BT\&quot;, \&quot;EG\&quot;, \&quot;PL\&quot;, \&quot;IT\&quot;, \&quot;SA\&quot;, \&quot;MY\&quot;, \&quot;CI\&quot;, \&quot;AG\&quot;, \&quot;AD\&quot;, \&quot;KS\&quot;, \&quot;HU\&quot;, \&quot;CG\&quot;, \&quot;KP\&quot;, \&quot;DM\&quot;, \&quot;GN\&quot;, \&quot;GT\&quot;, \&quot;NP\&quot;, \&quot;JM\&quot;, \&quot;LA\&quot;, \&quot;GB\&quot;, \&quot;BG\&quot;, \&quot;HT\&quot;, \&quot;PE\&quot;, \&quot;AZ\&quot;, \&quot;LT\&quot;, \&quot;SZ\&quot;, \&quot;PY\&quot;, \&quot;MT\&quot;, \&quot;VA\&quot;
        /// </summary>
        /// <value>Optional; the country for this name, possible values are \&quot;US\&quot;, \&quot;LY\&quot;, \&quot;NI\&quot;, \&quot;TT\&quot;, \&quot;MK\&quot;, \&quot;KZ\&quot;, \&quot;BO\&quot;, \&quot;UG\&quot;, \&quot;TZ\&quot;, \&quot;CL\&quot;, \&quot;SI\&quot;, \&quot;MA\&quot;, \&quot;RW\&quot;, \&quot;VN\&quot;, \&quot;AW\&quot;, \&quot;CY\&quot;, \&quot;BH\&quot;, \&quot;SG\&quot;, \&quot;ZA\&quot;, \&quot;MU\&quot;, \&quot;BR\&quot;, \&quot;TN\&quot;, \&quot;KH\&quot;, \&quot;US\&quot;, \&quot;TH\&quot;, \&quot;TW\&quot;, \&quot;UY\&quot;, \&quot;DO\&quot;, \&quot;CO\&quot;, \&quot;UA\&quot;, \&quot;QA\&quot;, \&quot;BY\&quot;, \&quot;SN\&quot;, \&quot;SD\&quot;, \&quot;FJ\&quot;, \&quot;LB\&quot;, \&quot;BE\&quot;, \&quot;ML\&quot;, \&quot;LV\&quot;, \&quot;FR\&quot;, \&quot;TM\&quot;, \&quot;NG\&quot;, \&quot;EC\&quot;, \&quot;NO\&quot;, \&quot;SL\&quot;, \&quot;CR\&quot;, \&quot;PA\&quot;, \&quot;GE\&quot;, \&quot;CH\&quot;, \&quot;KR\&quot;, \&quot;RS\&quot;, \&quot;ZM\&quot;, \&quot;FI\&quot;, \&quot;BF\&quot;, \&quot;MC\&quot;, \&quot;AU\&quot;, \&quot;GA\&quot;, \&quot;LS\&quot;, \&quot;RU\&quot;, \&quot;IN\&quot;, \&quot;SE\&quot;, \&quot;LK\&quot;, \&quot;BZ\&quot;, \&quot;MX\&quot;, \&quot;GH\&quot;, \&quot;AF\&quot;, \&quot;TJ\&quot;, \&quot;BN\&quot;, \&quot;DZ\&quot;, \&quot;CM\&quot;, \&quot;GR\&quot;, \&quot;MD\&quot;, \&quot;HN\&quot;, \&quot;AT\&quot;, \&quot;NZ\&quot;, \&quot;SV\&quot;, \&quot;GW\&quot;, \&quot;NA\&quot;, \&quot;AR\&quot;, \&quot;MZ\&quot;, \&quot;PK\&quot;, \&quot;MN\&quot;, \&quot;IQ\&quot;, \&quot;BW\&quot;, \&quot;VE\&quot;, \&quot;PT\&quot;, \&quot;BS\&quot;, \&quot;AL\&quot;, \&quot;TG\&quot;, \&quot;ID\&quot;, \&quot;ET\&quot;, \&quot;CF\&quot;, \&quot;JP\&quot;, \&quot;BB\&quot;, \&quot;PH\&quot;, \&quot;CU\&quot;, \&quot;BD\&quot;, \&quot;AO\&quot;, \&quot;SM\&quot;, \&quot;LC\&quot;, \&quot;ME\&quot;, \&quot;RO\&quot;,  DANIL\&quot;O\&quot;\&quot;, \&quot;ES\&quot;, \&quot;EE\&quot;, \&quot;IL\&quot;, \&quot;ZW\&quot;, \&quot;SY\&quot;, \&quot;MW\&quot;, \&quot;LU\&quot;, \&quot;IR\&quot;, \&quot;SC\&quot;, \&quot;NL\&quot;, \&quot;JO\&quot;, \&quot;AM\&quot;, \&quot;DE\&quot;, \&quot;GL\&quot;, \&quot;OM\&quot;, \&quot;DK\&quot;, \&quot;HR\&quot;, \&quot;LI\&quot;, \&quot;TD\&quot;, \&quot;KM\&quot;, \&quot;BA\&quot;, \&quot;GM\&quot;, \&quot;GD\&quot;, \&quot;CA\&quot;, \&quot;CZ\&quot;, \&quot;MR\&quot;, \&quot;ST\&quot;, \&quot;IS\&quot;, \&quot;LR\&quot;, \&quot;IE\&quot;, \&quot;VC\&quot;, \&quot;AE\&quot;, \&quot;KG\&quot;, \&quot;DJ\&quot;, \&quot;TR\&quot;, \&quot;KE\&quot;, \&quot;NE\&quot;, \&quot;UZ\&quot;, \&quot;CN\&quot;, \&quot;GQ\&quot;, \&quot;SK\&quot;, \&quot;BJ\&quot;, \&quot;MG\&quot;, \&quot;BT\&quot;, \&quot;EG\&quot;, \&quot;PL\&quot;, \&quot;IT\&quot;, \&quot;SA\&quot;, \&quot;MY\&quot;, \&quot;CI\&quot;, \&quot;AG\&quot;, \&quot;AD\&quot;, \&quot;KS\&quot;, \&quot;HU\&quot;, \&quot;CG\&quot;, \&quot;KP\&quot;, \&quot;DM\&quot;, \&quot;GN\&quot;, \&quot;GT\&quot;, \&quot;NP\&quot;, \&quot;JM\&quot;, \&quot;LA\&quot;, \&quot;GB\&quot;, \&quot;BG\&quot;, \&quot;HT\&quot;, \&quot;PE\&quot;, \&quot;AZ\&quot;, \&quot;LT\&quot;, \&quot;SZ\&quot;, \&quot;PY\&quot;, \&quot;MT\&quot;, \&quot;VA\&quot;</value>
        [DataMember(Name="CountryCode", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetGenderRequest {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
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
            return this.Equals(input as GetGenderRequest);
        }

        /// <summary>
        /// Returns true if GetGenderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GetGenderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetGenderRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                return hashCode;
            }
        }
    }

}
