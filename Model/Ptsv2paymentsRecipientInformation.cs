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
    /// Ptsv2paymentsRecipientInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsRecipientInformation :  IEquatable<Ptsv2paymentsRecipientInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsRecipientInformation" /> class.
        /// </summary>
        /// <param name="AccountId">Identifier for the recipient’s account. Use the first six digits and last four digits of the recipient’s account number. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. .</param>
        /// <param name="LastName">Recipient’s last name. This field is a passthrough, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. .</param>
        /// <param name="PostalCode">Partial postal code for the recipient’s address. For example, if the postal code is **NN5 7SG**, the value for this  field should be the first part of the postal code: **NN5**. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. .</param>
        public Ptsv2paymentsRecipientInformation(string AccountId = default(string), string LastName = default(string), string PostalCode = default(string))
        {
            this.AccountId = AccountId;
            this.LastName = LastName;
            this.PostalCode = PostalCode;
        }
        
        /// <summary>
        /// Identifier for the recipient’s account. Use the first six digits and last four digits of the recipient’s account number. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. 
        /// </summary>
        /// <value>Identifier for the recipient’s account. Use the first six digits and last four digits of the recipient’s account number. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. </value>
        [DataMember(Name="accountId", EmitDefaultValue=false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Recipient’s last name. This field is a passthrough, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. 
        /// </summary>
        /// <value>Recipient’s last name. This field is a passthrough, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. </value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Partial postal code for the recipient’s address. For example, if the postal code is **NN5 7SG**, the value for this  field should be the first part of the postal code: **NN5**. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. 
        /// </summary>
        /// <value>Partial postal code for the recipient’s address. For example, if the postal code is **NN5 7SG**, the value for this  field should be the first part of the postal code: **NN5**. This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. If the field is not required for the transaction, CyberSource does not forward it to the processor.  For more details, see \&quot;Recipients,\&quot; page 224. </value>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsRecipientInformation {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsRecipientInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsRecipientInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsRecipientInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsRecipientInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AccountId == other.AccountId ||
                    this.AccountId != null &&
                    this.AccountId.Equals(other.AccountId)
                ) && 
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
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
                if (this.AccountId != null)
                    hash = hash * 59 + this.AccountId.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
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
            // AccountId (string) maxLength
            if(this.AccountId != null && this.AccountId.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountId, length must be less than 10.", new [] { "AccountId" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 6.", new [] { "LastName" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 6.", new [] { "PostalCode" });
            }

            yield break;
        }
    }

}
