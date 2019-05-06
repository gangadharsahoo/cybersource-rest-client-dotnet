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
    /// TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation
    /// </summary>
    [DataContract]
    public partial class TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation :  IEquatable<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation" /> class.
        /// </summary>
        /// <param name="CompanyTaxID">Tax identifier for the customer’s company.  **Important**: Contact your TeleCheck representative to find out whether this field is required or optional. .</param>
        /// <param name="Currency">Currency used by the customer. Accepts input in the ISO 4217 standard, stores as ISO 4217 Alpha..</param>
        /// <param name="DateOBirth">Date of birth of the customer.  Format: &#x60;YYYY-MM-DD&#x60; or &#x60;YYYYMMDD&#x60; .</param>
        /// <param name="PersonalIdentification">PersonalIdentification.</param>
        public TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation(string CompanyTaxID = default(string), string Currency = default(string), string DateOBirth = default(string), List<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationPersonalIdentification> PersonalIdentification = default(List<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationPersonalIdentification>))
        {
            this.CompanyTaxID = CompanyTaxID;
            this.Currency = Currency;
            this.DateOBirth = DateOBirth;
            this.PersonalIdentification = PersonalIdentification;
        }
        
        /// <summary>
        /// Tax identifier for the customer’s company.  **Important**: Contact your TeleCheck representative to find out whether this field is required or optional. 
        /// </summary>
        /// <value>Tax identifier for the customer’s company.  **Important**: Contact your TeleCheck representative to find out whether this field is required or optional. </value>
        [DataMember(Name="companyTaxID", EmitDefaultValue=false)]
        public string CompanyTaxID { get; set; }

        /// <summary>
        /// Currency used by the customer. Accepts input in the ISO 4217 standard, stores as ISO 4217 Alpha.
        /// </summary>
        /// <value>Currency used by the customer. Accepts input in the ISO 4217 standard, stores as ISO 4217 Alpha.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }

        /// <summary>
        /// Date of birth of the customer.  Format: &#x60;YYYY-MM-DD&#x60; or &#x60;YYYYMMDD&#x60; 
        /// </summary>
        /// <value>Date of birth of the customer.  Format: &#x60;YYYY-MM-DD&#x60; or &#x60;YYYYMMDD&#x60; </value>
        [DataMember(Name="dateOBirth", EmitDefaultValue=false)]
        public string DateOBirth { get; set; }

        /// <summary>
        /// Gets or Sets PersonalIdentification
        /// </summary>
        [DataMember(Name="personalIdentification", EmitDefaultValue=false)]
        public List<TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformationPersonalIdentification> PersonalIdentification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation {\n");
            sb.Append("  CompanyTaxID: ").Append(CompanyTaxID).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  DateOBirth: ").Append(DateOBirth).Append("\n");
            sb.Append("  PersonalIdentification: ").Append(PersonalIdentification).Append("\n");
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
            return this.Equals(obj as TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation);
        }

        /// <summary>
        /// Returns true if TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsV1InstrumentIdentifiersPaymentInstrumentsGet200ResponseBuyerInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompanyTaxID == other.CompanyTaxID ||
                    this.CompanyTaxID != null &&
                    this.CompanyTaxID.Equals(other.CompanyTaxID)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.DateOBirth == other.DateOBirth ||
                    this.DateOBirth != null &&
                    this.DateOBirth.Equals(other.DateOBirth)
                ) && 
                (
                    this.PersonalIdentification == other.PersonalIdentification ||
                    this.PersonalIdentification != null &&
                    this.PersonalIdentification.SequenceEqual(other.PersonalIdentification)
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
                if (this.CompanyTaxID != null)
                    hash = hash * 59 + this.CompanyTaxID.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.DateOBirth != null)
                    hash = hash * 59 + this.DateOBirth.GetHashCode();
                if (this.PersonalIdentification != null)
                    hash = hash * 59 + this.PersonalIdentification.GetHashCode();
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
            // CompanyTaxID (string) maxLength
            if(this.CompanyTaxID != null && this.CompanyTaxID.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyTaxID, length must be less than 9.", new [] { "CompanyTaxID" });
            }

            // Currency (string) maxLength
            if(this.Currency != null && this.Currency.Length > 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be less than 3.", new [] { "Currency" });
            }

            // Currency (string) minLength
            if(this.Currency != null && this.Currency.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be greater than 3.", new [] { "Currency" });
            }

            // DateOBirth (string) maxLength
            if(this.DateOBirth != null && this.DateOBirth.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DateOBirth, length must be less than 10.", new [] { "DateOBirth" });
            }

            // DateOBirth (string) minLength
            if(this.DateOBirth != null && this.DateOBirth.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DateOBirth, length must be greater than 8.", new [] { "DateOBirth" });
            }

            yield break;
        }
    }

}