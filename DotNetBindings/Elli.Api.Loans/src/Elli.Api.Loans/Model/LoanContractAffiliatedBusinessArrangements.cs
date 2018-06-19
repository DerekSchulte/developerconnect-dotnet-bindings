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
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
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
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractAffiliatedBusinessArrangements
    /// </summary>
    [DataContract]
    public partial class LoanContractAffiliatedBusinessArrangements :  IEquatable<LoanContractAffiliatedBusinessArrangements>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets LenderName
        /// </summary>
        [DataMember(Name="lenderName", EmitDefaultValue=false)]
        public string LenderName { get; set; }

        /// <summary>
        /// Gets or Sets LenderAddress
        /// </summary>
        [DataMember(Name="lenderAddress", EmitDefaultValue=false)]
        public string LenderAddress { get; set; }

        /// <summary>
        /// Gets or Sets LenderAddressCity
        /// </summary>
        [DataMember(Name="lenderAddressCity", EmitDefaultValue=false)]
        public string LenderAddressCity { get; set; }

        /// <summary>
        /// Gets or Sets LenderAddressState
        /// </summary>
        [DataMember(Name="lenderAddressState", EmitDefaultValue=false)]
        public string LenderAddressState { get; set; }

        /// <summary>
        /// Gets or Sets LenderAddressZipcode
        /// </summary>
        [DataMember(Name="lenderAddressZipcode", EmitDefaultValue=false)]
        public string LenderAddressZipcode { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateName
        /// </summary>
        [DataMember(Name="affiliateName", EmitDefaultValue=false)]
        public string AffiliateName { get; set; }

        /// <summary>
        /// Gets or Sets NatureOfRelationship
        /// </summary>
        [DataMember(Name="natureOfRelationship", EmitDefaultValue=false)]
        public string NatureOfRelationship { get; set; }

        /// <summary>
        /// Gets or Sets SettlementIndicator
        /// </summary>
        [DataMember(Name="settlementIndicator", EmitDefaultValue=false)]
        public bool? SettlementIndicator { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseSaleRefinanceIndicator
        /// </summary>
        [DataMember(Name="purchaseSaleRefinanceIndicator", EmitDefaultValue=false)]
        public bool? PurchaseSaleRefinanceIndicator { get; set; }

        /// <summary>
        /// Gets or Sets ServiceDescription1
        /// </summary>
        [DataMember(Name="serviceDescription1", EmitDefaultValue=false)]
        public string ServiceDescription1 { get; set; }

        /// <summary>
        /// Gets or Sets ServiceDescription2
        /// </summary>
        [DataMember(Name="serviceDescription2", EmitDefaultValue=false)]
        public string ServiceDescription2 { get; set; }

        /// <summary>
        /// Gets or Sets ServiceDescription3
        /// </summary>
        [DataMember(Name="serviceDescription3", EmitDefaultValue=false)]
        public string ServiceDescription3 { get; set; }

        /// <summary>
        /// Gets or Sets ServiceDescription4
        /// </summary>
        [DataMember(Name="serviceDescription4", EmitDefaultValue=false)]
        public string ServiceDescription4 { get; set; }

        /// <summary>
        /// Gets or Sets ServiceDescription5
        /// </summary>
        [DataMember(Name="serviceDescription5", EmitDefaultValue=false)]
        public string ServiceDescription5 { get; set; }

        /// <summary>
        /// Gets or Sets ServiceDescription6
        /// </summary>
        [DataMember(Name="serviceDescription6", EmitDefaultValue=false)]
        public string ServiceDescription6 { get; set; }

        /// <summary>
        /// Gets or Sets ChargeRangeChargesDescription1
        /// </summary>
        [DataMember(Name="chargeRangeChargesDescription1", EmitDefaultValue=false)]
        public string ChargeRangeChargesDescription1 { get; set; }

        /// <summary>
        /// Gets or Sets ChargeRangeChargesDescription2
        /// </summary>
        [DataMember(Name="chargeRangeChargesDescription2", EmitDefaultValue=false)]
        public string ChargeRangeChargesDescription2 { get; set; }

        /// <summary>
        /// Gets or Sets ChargeRangeChargesDescription3
        /// </summary>
        [DataMember(Name="chargeRangeChargesDescription3", EmitDefaultValue=false)]
        public string ChargeRangeChargesDescription3 { get; set; }

        /// <summary>
        /// Gets or Sets ChargeRangeChargesDescription4
        /// </summary>
        [DataMember(Name="chargeRangeChargesDescription4", EmitDefaultValue=false)]
        public string ChargeRangeChargesDescription4 { get; set; }

        /// <summary>
        /// Gets or Sets ChargeRangeChargesDescription5
        /// </summary>
        [DataMember(Name="chargeRangeChargesDescription5", EmitDefaultValue=false)]
        public string ChargeRangeChargesDescription5 { get; set; }

        /// <summary>
        /// Gets or Sets ChargeRangeChargesDescription6
        /// </summary>
        [DataMember(Name="chargeRangeChargesDescription6", EmitDefaultValue=false)]
        public string ChargeRangeChargesDescription6 { get; set; }

        /// <summary>
        /// Gets or Sets RequiredUseIndicator1
        /// </summary>
        [DataMember(Name="requiredUseIndicator1", EmitDefaultValue=false)]
        public bool? RequiredUseIndicator1 { get; set; }

        /// <summary>
        /// Gets or Sets RequiredUseIndicator2
        /// </summary>
        [DataMember(Name="requiredUseIndicator2", EmitDefaultValue=false)]
        public bool? RequiredUseIndicator2 { get; set; }

        /// <summary>
        /// Gets or Sets RequiredUseIndicator3
        /// </summary>
        [DataMember(Name="requiredUseIndicator3", EmitDefaultValue=false)]
        public bool? RequiredUseIndicator3 { get; set; }

        /// <summary>
        /// Gets or Sets RequiredUseIndicator4
        /// </summary>
        [DataMember(Name="requiredUseIndicator4", EmitDefaultValue=false)]
        public bool? RequiredUseIndicator4 { get; set; }

        /// <summary>
        /// Gets or Sets RequiredUseIndicator5
        /// </summary>
        [DataMember(Name="requiredUseIndicator5", EmitDefaultValue=false)]
        public bool? RequiredUseIndicator5 { get; set; }

        /// <summary>
        /// Gets or Sets RequiredUseIndicator6
        /// </summary>
        [DataMember(Name="requiredUseIndicator6", EmitDefaultValue=false)]
        public bool? RequiredUseIndicator6 { get; set; }

        /// <summary>
        /// Gets or Sets PercentOwnershipInterest
        /// </summary>
        [DataMember(Name="percentOwnershipInterest", EmitDefaultValue=false)]
        public double? PercentOwnershipInterest { get; set; }

        /// <summary>
        /// Gets or Sets AffiliatedBusinessArrangementIndex
        /// </summary>
        [DataMember(Name="affiliatedBusinessArrangementIndex", EmitDefaultValue=false)]
        public int? AffiliatedBusinessArrangementIndex { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractAffiliatedBusinessArrangements {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LenderName: ").Append(LenderName).Append("\n");
            sb.Append("  LenderAddress: ").Append(LenderAddress).Append("\n");
            sb.Append("  LenderAddressCity: ").Append(LenderAddressCity).Append("\n");
            sb.Append("  LenderAddressState: ").Append(LenderAddressState).Append("\n");
            sb.Append("  LenderAddressZipcode: ").Append(LenderAddressZipcode).Append("\n");
            sb.Append("  AffiliateName: ").Append(AffiliateName).Append("\n");
            sb.Append("  NatureOfRelationship: ").Append(NatureOfRelationship).Append("\n");
            sb.Append("  SettlementIndicator: ").Append(SettlementIndicator).Append("\n");
            sb.Append("  PurchaseSaleRefinanceIndicator: ").Append(PurchaseSaleRefinanceIndicator).Append("\n");
            sb.Append("  ServiceDescription1: ").Append(ServiceDescription1).Append("\n");
            sb.Append("  ServiceDescription2: ").Append(ServiceDescription2).Append("\n");
            sb.Append("  ServiceDescription3: ").Append(ServiceDescription3).Append("\n");
            sb.Append("  ServiceDescription4: ").Append(ServiceDescription4).Append("\n");
            sb.Append("  ServiceDescription5: ").Append(ServiceDescription5).Append("\n");
            sb.Append("  ServiceDescription6: ").Append(ServiceDescription6).Append("\n");
            sb.Append("  ChargeRangeChargesDescription1: ").Append(ChargeRangeChargesDescription1).Append("\n");
            sb.Append("  ChargeRangeChargesDescription2: ").Append(ChargeRangeChargesDescription2).Append("\n");
            sb.Append("  ChargeRangeChargesDescription3: ").Append(ChargeRangeChargesDescription3).Append("\n");
            sb.Append("  ChargeRangeChargesDescription4: ").Append(ChargeRangeChargesDescription4).Append("\n");
            sb.Append("  ChargeRangeChargesDescription5: ").Append(ChargeRangeChargesDescription5).Append("\n");
            sb.Append("  ChargeRangeChargesDescription6: ").Append(ChargeRangeChargesDescription6).Append("\n");
            sb.Append("  RequiredUseIndicator1: ").Append(RequiredUseIndicator1).Append("\n");
            sb.Append("  RequiredUseIndicator2: ").Append(RequiredUseIndicator2).Append("\n");
            sb.Append("  RequiredUseIndicator3: ").Append(RequiredUseIndicator3).Append("\n");
            sb.Append("  RequiredUseIndicator4: ").Append(RequiredUseIndicator4).Append("\n");
            sb.Append("  RequiredUseIndicator5: ").Append(RequiredUseIndicator5).Append("\n");
            sb.Append("  RequiredUseIndicator6: ").Append(RequiredUseIndicator6).Append("\n");
            sb.Append("  PercentOwnershipInterest: ").Append(PercentOwnershipInterest).Append("\n");
            sb.Append("  AffiliatedBusinessArrangementIndex: ").Append(AffiliatedBusinessArrangementIndex).Append("\n");
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
            return this.Equals(input as LoanContractAffiliatedBusinessArrangements);
        }

        /// <summary>
        /// Returns true if LoanContractAffiliatedBusinessArrangements instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractAffiliatedBusinessArrangements to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractAffiliatedBusinessArrangements input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LenderName == input.LenderName ||
                    (this.LenderName != null &&
                    this.LenderName.Equals(input.LenderName))
                ) && 
                (
                    this.LenderAddress == input.LenderAddress ||
                    (this.LenderAddress != null &&
                    this.LenderAddress.Equals(input.LenderAddress))
                ) && 
                (
                    this.LenderAddressCity == input.LenderAddressCity ||
                    (this.LenderAddressCity != null &&
                    this.LenderAddressCity.Equals(input.LenderAddressCity))
                ) && 
                (
                    this.LenderAddressState == input.LenderAddressState ||
                    (this.LenderAddressState != null &&
                    this.LenderAddressState.Equals(input.LenderAddressState))
                ) && 
                (
                    this.LenderAddressZipcode == input.LenderAddressZipcode ||
                    (this.LenderAddressZipcode != null &&
                    this.LenderAddressZipcode.Equals(input.LenderAddressZipcode))
                ) && 
                (
                    this.AffiliateName == input.AffiliateName ||
                    (this.AffiliateName != null &&
                    this.AffiliateName.Equals(input.AffiliateName))
                ) && 
                (
                    this.NatureOfRelationship == input.NatureOfRelationship ||
                    (this.NatureOfRelationship != null &&
                    this.NatureOfRelationship.Equals(input.NatureOfRelationship))
                ) && 
                (
                    this.SettlementIndicator == input.SettlementIndicator ||
                    (this.SettlementIndicator != null &&
                    this.SettlementIndicator.Equals(input.SettlementIndicator))
                ) && 
                (
                    this.PurchaseSaleRefinanceIndicator == input.PurchaseSaleRefinanceIndicator ||
                    (this.PurchaseSaleRefinanceIndicator != null &&
                    this.PurchaseSaleRefinanceIndicator.Equals(input.PurchaseSaleRefinanceIndicator))
                ) && 
                (
                    this.ServiceDescription1 == input.ServiceDescription1 ||
                    (this.ServiceDescription1 != null &&
                    this.ServiceDescription1.Equals(input.ServiceDescription1))
                ) && 
                (
                    this.ServiceDescription2 == input.ServiceDescription2 ||
                    (this.ServiceDescription2 != null &&
                    this.ServiceDescription2.Equals(input.ServiceDescription2))
                ) && 
                (
                    this.ServiceDescription3 == input.ServiceDescription3 ||
                    (this.ServiceDescription3 != null &&
                    this.ServiceDescription3.Equals(input.ServiceDescription3))
                ) && 
                (
                    this.ServiceDescription4 == input.ServiceDescription4 ||
                    (this.ServiceDescription4 != null &&
                    this.ServiceDescription4.Equals(input.ServiceDescription4))
                ) && 
                (
                    this.ServiceDescription5 == input.ServiceDescription5 ||
                    (this.ServiceDescription5 != null &&
                    this.ServiceDescription5.Equals(input.ServiceDescription5))
                ) && 
                (
                    this.ServiceDescription6 == input.ServiceDescription6 ||
                    (this.ServiceDescription6 != null &&
                    this.ServiceDescription6.Equals(input.ServiceDescription6))
                ) && 
                (
                    this.ChargeRangeChargesDescription1 == input.ChargeRangeChargesDescription1 ||
                    (this.ChargeRangeChargesDescription1 != null &&
                    this.ChargeRangeChargesDescription1.Equals(input.ChargeRangeChargesDescription1))
                ) && 
                (
                    this.ChargeRangeChargesDescription2 == input.ChargeRangeChargesDescription2 ||
                    (this.ChargeRangeChargesDescription2 != null &&
                    this.ChargeRangeChargesDescription2.Equals(input.ChargeRangeChargesDescription2))
                ) && 
                (
                    this.ChargeRangeChargesDescription3 == input.ChargeRangeChargesDescription3 ||
                    (this.ChargeRangeChargesDescription3 != null &&
                    this.ChargeRangeChargesDescription3.Equals(input.ChargeRangeChargesDescription3))
                ) && 
                (
                    this.ChargeRangeChargesDescription4 == input.ChargeRangeChargesDescription4 ||
                    (this.ChargeRangeChargesDescription4 != null &&
                    this.ChargeRangeChargesDescription4.Equals(input.ChargeRangeChargesDescription4))
                ) && 
                (
                    this.ChargeRangeChargesDescription5 == input.ChargeRangeChargesDescription5 ||
                    (this.ChargeRangeChargesDescription5 != null &&
                    this.ChargeRangeChargesDescription5.Equals(input.ChargeRangeChargesDescription5))
                ) && 
                (
                    this.ChargeRangeChargesDescription6 == input.ChargeRangeChargesDescription6 ||
                    (this.ChargeRangeChargesDescription6 != null &&
                    this.ChargeRangeChargesDescription6.Equals(input.ChargeRangeChargesDescription6))
                ) && 
                (
                    this.RequiredUseIndicator1 == input.RequiredUseIndicator1 ||
                    (this.RequiredUseIndicator1 != null &&
                    this.RequiredUseIndicator1.Equals(input.RequiredUseIndicator1))
                ) && 
                (
                    this.RequiredUseIndicator2 == input.RequiredUseIndicator2 ||
                    (this.RequiredUseIndicator2 != null &&
                    this.RequiredUseIndicator2.Equals(input.RequiredUseIndicator2))
                ) && 
                (
                    this.RequiredUseIndicator3 == input.RequiredUseIndicator3 ||
                    (this.RequiredUseIndicator3 != null &&
                    this.RequiredUseIndicator3.Equals(input.RequiredUseIndicator3))
                ) && 
                (
                    this.RequiredUseIndicator4 == input.RequiredUseIndicator4 ||
                    (this.RequiredUseIndicator4 != null &&
                    this.RequiredUseIndicator4.Equals(input.RequiredUseIndicator4))
                ) && 
                (
                    this.RequiredUseIndicator5 == input.RequiredUseIndicator5 ||
                    (this.RequiredUseIndicator5 != null &&
                    this.RequiredUseIndicator5.Equals(input.RequiredUseIndicator5))
                ) && 
                (
                    this.RequiredUseIndicator6 == input.RequiredUseIndicator6 ||
                    (this.RequiredUseIndicator6 != null &&
                    this.RequiredUseIndicator6.Equals(input.RequiredUseIndicator6))
                ) && 
                (
                    this.PercentOwnershipInterest == input.PercentOwnershipInterest ||
                    (this.PercentOwnershipInterest != null &&
                    this.PercentOwnershipInterest.Equals(input.PercentOwnershipInterest))
                ) && 
                (
                    this.AffiliatedBusinessArrangementIndex == input.AffiliatedBusinessArrangementIndex ||
                    (this.AffiliatedBusinessArrangementIndex != null &&
                    this.AffiliatedBusinessArrangementIndex.Equals(input.AffiliatedBusinessArrangementIndex))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LenderName != null)
                    hashCode = hashCode * 59 + this.LenderName.GetHashCode();
                if (this.LenderAddress != null)
                    hashCode = hashCode * 59 + this.LenderAddress.GetHashCode();
                if (this.LenderAddressCity != null)
                    hashCode = hashCode * 59 + this.LenderAddressCity.GetHashCode();
                if (this.LenderAddressState != null)
                    hashCode = hashCode * 59 + this.LenderAddressState.GetHashCode();
                if (this.LenderAddressZipcode != null)
                    hashCode = hashCode * 59 + this.LenderAddressZipcode.GetHashCode();
                if (this.AffiliateName != null)
                    hashCode = hashCode * 59 + this.AffiliateName.GetHashCode();
                if (this.NatureOfRelationship != null)
                    hashCode = hashCode * 59 + this.NatureOfRelationship.GetHashCode();
                if (this.SettlementIndicator != null)
                    hashCode = hashCode * 59 + this.SettlementIndicator.GetHashCode();
                if (this.PurchaseSaleRefinanceIndicator != null)
                    hashCode = hashCode * 59 + this.PurchaseSaleRefinanceIndicator.GetHashCode();
                if (this.ServiceDescription1 != null)
                    hashCode = hashCode * 59 + this.ServiceDescription1.GetHashCode();
                if (this.ServiceDescription2 != null)
                    hashCode = hashCode * 59 + this.ServiceDescription2.GetHashCode();
                if (this.ServiceDescription3 != null)
                    hashCode = hashCode * 59 + this.ServiceDescription3.GetHashCode();
                if (this.ServiceDescription4 != null)
                    hashCode = hashCode * 59 + this.ServiceDescription4.GetHashCode();
                if (this.ServiceDescription5 != null)
                    hashCode = hashCode * 59 + this.ServiceDescription5.GetHashCode();
                if (this.ServiceDescription6 != null)
                    hashCode = hashCode * 59 + this.ServiceDescription6.GetHashCode();
                if (this.ChargeRangeChargesDescription1 != null)
                    hashCode = hashCode * 59 + this.ChargeRangeChargesDescription1.GetHashCode();
                if (this.ChargeRangeChargesDescription2 != null)
                    hashCode = hashCode * 59 + this.ChargeRangeChargesDescription2.GetHashCode();
                if (this.ChargeRangeChargesDescription3 != null)
                    hashCode = hashCode * 59 + this.ChargeRangeChargesDescription3.GetHashCode();
                if (this.ChargeRangeChargesDescription4 != null)
                    hashCode = hashCode * 59 + this.ChargeRangeChargesDescription4.GetHashCode();
                if (this.ChargeRangeChargesDescription5 != null)
                    hashCode = hashCode * 59 + this.ChargeRangeChargesDescription5.GetHashCode();
                if (this.ChargeRangeChargesDescription6 != null)
                    hashCode = hashCode * 59 + this.ChargeRangeChargesDescription6.GetHashCode();
                if (this.RequiredUseIndicator1 != null)
                    hashCode = hashCode * 59 + this.RequiredUseIndicator1.GetHashCode();
                if (this.RequiredUseIndicator2 != null)
                    hashCode = hashCode * 59 + this.RequiredUseIndicator2.GetHashCode();
                if (this.RequiredUseIndicator3 != null)
                    hashCode = hashCode * 59 + this.RequiredUseIndicator3.GetHashCode();
                if (this.RequiredUseIndicator4 != null)
                    hashCode = hashCode * 59 + this.RequiredUseIndicator4.GetHashCode();
                if (this.RequiredUseIndicator5 != null)
                    hashCode = hashCode * 59 + this.RequiredUseIndicator5.GetHashCode();
                if (this.RequiredUseIndicator6 != null)
                    hashCode = hashCode * 59 + this.RequiredUseIndicator6.GetHashCode();
                if (this.PercentOwnershipInterest != null)
                    hashCode = hashCode * 59 + this.PercentOwnershipInterest.GetHashCode();
                if (this.AffiliatedBusinessArrangementIndex != null)
                    hashCode = hashCode * 59 + this.AffiliatedBusinessArrangementIndex.GetHashCode();
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
