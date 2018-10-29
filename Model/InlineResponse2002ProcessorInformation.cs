/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
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
    /// InlineResponse2002ProcessorInformation
    /// </summary>
    [DataContract]
    public partial class InlineResponse2002ProcessorInformation :  IEquatable<InlineResponse2002ProcessorInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse2002ProcessorInformation" /> class.
        /// </summary>
        /// <param name="ApprovalCode">Authorization code. Returned only when the processor returns this value. .</param>
        /// <param name="CardVerification">CardVerification.</param>
        /// <param name="Avs">Avs.</param>
        /// <param name="TransactionId">Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this  value. .</param>
        public InlineResponse2002ProcessorInformation(string ApprovalCode = default(string), InlineResponse2002ProcessorInformationCardVerification CardVerification = default(InlineResponse2002ProcessorInformationCardVerification), InlineResponse2002ProcessorInformationAvs Avs = default(InlineResponse2002ProcessorInformationAvs), string TransactionId = default(string))
        {
            this.ApprovalCode = ApprovalCode;
            this.CardVerification = CardVerification;
            this.Avs = Avs;
            this.TransactionId = TransactionId;
        }
        
        /// <summary>
        /// Authorization code. Returned only when the processor returns this value. 
        /// </summary>
        /// <value>Authorization code. Returned only when the processor returns this value. </value>
        [DataMember(Name="approvalCode", EmitDefaultValue=false)]
        public string ApprovalCode { get; set; }

        /// <summary>
        /// Gets or Sets CardVerification
        /// </summary>
        [DataMember(Name="cardVerification", EmitDefaultValue=false)]
        public InlineResponse2002ProcessorInformationCardVerification CardVerification { get; set; }

        /// <summary>
        /// Gets or Sets Avs
        /// </summary>
        [DataMember(Name="avs", EmitDefaultValue=false)]
        public InlineResponse2002ProcessorInformationAvs Avs { get; set; }

        /// <summary>
        /// Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this  value. 
        /// </summary>
        /// <value>Network transaction identifier (TID). You can use this value to identify a specific transaction when you are discussing the transaction with your processor. Not all processors provide this  value. </value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse2002ProcessorInformation {\n");
            sb.Append("  ApprovalCode: ").Append(ApprovalCode).Append("\n");
            sb.Append("  CardVerification: ").Append(CardVerification).Append("\n");
            sb.Append("  Avs: ").Append(Avs).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
            return this.Equals(obj as InlineResponse2002ProcessorInformation);
        }

        /// <summary>
        /// Returns true if InlineResponse2002ProcessorInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse2002ProcessorInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse2002ProcessorInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ApprovalCode == other.ApprovalCode ||
                    this.ApprovalCode != null &&
                    this.ApprovalCode.Equals(other.ApprovalCode)
                ) && 
                (
                    this.CardVerification == other.CardVerification ||
                    this.CardVerification != null &&
                    this.CardVerification.Equals(other.CardVerification)
                ) && 
                (
                    this.Avs == other.Avs ||
                    this.Avs != null &&
                    this.Avs.Equals(other.Avs)
                ) && 
                (
                    this.TransactionId == other.TransactionId ||
                    this.TransactionId != null &&
                    this.TransactionId.Equals(other.TransactionId)
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
                if (this.ApprovalCode != null)
                    hash = hash * 59 + this.ApprovalCode.GetHashCode();
                if (this.CardVerification != null)
                    hash = hash * 59 + this.CardVerification.GetHashCode();
                if (this.Avs != null)
                    hash = hash * 59 + this.Avs.GetHashCode();
                if (this.TransactionId != null)
                    hash = hash * 59 + this.TransactionId.GetHashCode();
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
            // TransactionId (string) maxLength
            if(this.TransactionId != null && this.TransactionId.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TransactionId, length must be less than 50.", new [] { "TransactionId" });
            }

            yield break;
        }
    }

}