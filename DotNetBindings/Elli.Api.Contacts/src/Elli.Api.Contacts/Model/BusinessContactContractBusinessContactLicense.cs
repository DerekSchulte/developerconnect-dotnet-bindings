/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Contacts
 *
 * Represents borrower and business contacts
 *
 * OpenAPI spec version: 1.2.1
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
using SwaggerDateConverter = Elli.Api.Contacts.Client.SwaggerDateConverter;

namespace Elli.Api.Contacts.Model
{
    /// <summary>
    /// Business licensing information.
    /// </summary>
    [DataContract]
    public partial class BusinessContactContractBusinessContactLicense :  IEquatable<BusinessContactContractBusinessContactLicense>, IValidatableObject
    {
    
        
        /// <summary>
        /// Name of the licensing authority.
        /// </summary>
        /// <value>Name of the licensing authority.</value>
        [DataMember(Name="licenseAuthName", EmitDefaultValue=false)]
        public string LicenseAuthName { get; set; }

        /// <summary>
        /// Type of license.
        /// </summary>
        /// <value>Type of license.</value>
        [DataMember(Name="licenseAuthType", EmitDefaultValue=false)]
        public string LicenseAuthType { get; set; }

        /// <summary>
        /// Date the license was issued.
        /// </summary>
        /// <value>Date the license was issued.</value>
        [DataMember(Name="licenseIssueDate", EmitDefaultValue=false)]
        public DateTime? LicenseIssueDate { get; set; }

        /// <summary>
        /// License number.
        /// </summary>
        /// <value>License number.</value>
        [DataMember(Name="licenseNumber", EmitDefaultValue=false)]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// State the license was issued.
        /// </summary>
        /// <value>State the license was issued.</value>
        [DataMember(Name="licenseStateCode", EmitDefaultValue=false)]
        public string LicenseStateCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BusinessContactContractBusinessContactLicense {\n");
            sb.Append("  LicenseAuthName: ").Append(LicenseAuthName).Append("\n");
            sb.Append("  LicenseAuthType: ").Append(LicenseAuthType).Append("\n");
            sb.Append("  LicenseIssueDate: ").Append(LicenseIssueDate).Append("\n");
            sb.Append("  LicenseNumber: ").Append(LicenseNumber).Append("\n");
            sb.Append("  LicenseStateCode: ").Append(LicenseStateCode).Append("\n");
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
            return this.Equals(input as BusinessContactContractBusinessContactLicense);
        }

        /// <summary>
        /// Returns true if BusinessContactContractBusinessContactLicense instances are equal
        /// </summary>
        /// <param name="input">Instance of BusinessContactContractBusinessContactLicense to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BusinessContactContractBusinessContactLicense input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LicenseAuthName == input.LicenseAuthName ||
                    (this.LicenseAuthName != null &&
                    this.LicenseAuthName.Equals(input.LicenseAuthName))
                ) && 
                (
                    this.LicenseAuthType == input.LicenseAuthType ||
                    (this.LicenseAuthType != null &&
                    this.LicenseAuthType.Equals(input.LicenseAuthType))
                ) && 
                (
                    this.LicenseIssueDate == input.LicenseIssueDate ||
                    (this.LicenseIssueDate != null &&
                    this.LicenseIssueDate.Equals(input.LicenseIssueDate))
                ) && 
                (
                    this.LicenseNumber == input.LicenseNumber ||
                    (this.LicenseNumber != null &&
                    this.LicenseNumber.Equals(input.LicenseNumber))
                ) && 
                (
                    this.LicenseStateCode == input.LicenseStateCode ||
                    (this.LicenseStateCode != null &&
                    this.LicenseStateCode.Equals(input.LicenseStateCode))
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
                if (this.LicenseAuthName != null)
                    hashCode = hashCode * 59 + this.LicenseAuthName.GetHashCode();
                if (this.LicenseAuthType != null)
                    hashCode = hashCode * 59 + this.LicenseAuthType.GetHashCode();
                if (this.LicenseIssueDate != null)
                    hashCode = hashCode * 59 + this.LicenseIssueDate.GetHashCode();
                if (this.LicenseNumber != null)
                    hashCode = hashCode * 59 + this.LicenseNumber.GetHashCode();
                if (this.LicenseStateCode != null)
                    hashCode = hashCode * 59 + this.LicenseStateCode.GetHashCode();
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
