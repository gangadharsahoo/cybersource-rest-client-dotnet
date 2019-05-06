/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy
    /// </summary>
    [DataContract]
    public partial class TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy :  IEquatable<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy" /> class.
        /// </summary>
        /// <param name="AdministrativeArea">State or province in which the customer’s driver’s license was issued. Use the State, Province, and Territory Codes for the United States and Canada.  **Important**: Contact your TeleCheck representative to learn whether this field is required or optional. .</param>
        public TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy(string AdministrativeArea = default(string))
        {
            this.AdministrativeArea = AdministrativeArea;
        }
        
        /// <summary>
        /// State or province in which the customer’s driver’s license was issued. Use the State, Province, and Territory Codes for the United States and Canada.  **Important**: Contact your TeleCheck representative to learn whether this field is required or optional. 
        /// </summary>
        /// <value>State or province in which the customer’s driver’s license was issued. Use the State, Province, and Territory Codes for the United States and Canada.  **Important**: Contact your TeleCheck representative to learn whether this field is required or optional. </value>
        [DataMember(Name="administrativeArea", EmitDefaultValue=false)]
        public string AdministrativeArea { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy {\n");
            sb.Append("  AdministrativeArea: ").Append(AdministrativeArea).Append("\n");
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
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy);
        }

        /// <summary>
        /// Returns true if TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationIssuedBy other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AdministrativeArea == other.AdministrativeArea ||
                    this.AdministrativeArea != null &&
                    this.AdministrativeArea.Equals(other.AdministrativeArea)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.AdministrativeArea != null)
                    hash = hash * 59 + this.AdministrativeArea.GetHashCode();
                return hash;
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
