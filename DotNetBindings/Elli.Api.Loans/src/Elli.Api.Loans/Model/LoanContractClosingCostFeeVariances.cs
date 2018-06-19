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
    /// LoanContractClosingCostFeeVariances
    /// </summary>
    [DataContract]
    public partial class LoanContractClosingCostFeeVariances :  IEquatable<LoanContractClosingCostFeeVariances>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets FeeVarianceFeeType
        /// </summary>
        [DataMember(Name="feeVarianceFeeType", EmitDefaultValue=false)]
        public string FeeVarianceFeeType { get; set; }

        /// <summary>
        /// Gets or Sets FeeVarianceChargeIndex
        /// </summary>
        [DataMember(Name="feeVarianceChargeIndex", EmitDefaultValue=false)]
        public int? FeeVarianceChargeIndex { get; set; }

        /// <summary>
        /// Gets or Sets InitialLE
        /// </summary>
        [DataMember(Name="initialLE", EmitDefaultValue=false)]
        public double? InitialLE { get; set; }

        /// <summary>
        /// Gets or Sets LE
        /// </summary>
        [DataMember(Name="lE", EmitDefaultValue=false)]
        public double? LE { get; set; }

        /// <summary>
        /// Gets or Sets CD
        /// </summary>
        [DataMember(Name="cD", EmitDefaultValue=false)]
        public double? CD { get; set; }

        /// <summary>
        /// Gets or Sets Itemization
        /// </summary>
        [DataMember(Name="itemization", EmitDefaultValue=false)]
        public double? Itemization { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Line
        /// </summary>
        [DataMember(Name="line", EmitDefaultValue=false)]
        public string Line { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractClosingCostFeeVariances {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FeeVarianceFeeType: ").Append(FeeVarianceFeeType).Append("\n");
            sb.Append("  FeeVarianceChargeIndex: ").Append(FeeVarianceChargeIndex).Append("\n");
            sb.Append("  InitialLE: ").Append(InitialLE).Append("\n");
            sb.Append("  LE: ").Append(LE).Append("\n");
            sb.Append("  CD: ").Append(CD).Append("\n");
            sb.Append("  Itemization: ").Append(Itemization).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Line: ").Append(Line).Append("\n");
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
            return this.Equals(input as LoanContractClosingCostFeeVariances);
        }

        /// <summary>
        /// Returns true if LoanContractClosingCostFeeVariances instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractClosingCostFeeVariances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractClosingCostFeeVariances input)
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
                    this.FeeVarianceFeeType == input.FeeVarianceFeeType ||
                    (this.FeeVarianceFeeType != null &&
                    this.FeeVarianceFeeType.Equals(input.FeeVarianceFeeType))
                ) && 
                (
                    this.FeeVarianceChargeIndex == input.FeeVarianceChargeIndex ||
                    (this.FeeVarianceChargeIndex != null &&
                    this.FeeVarianceChargeIndex.Equals(input.FeeVarianceChargeIndex))
                ) && 
                (
                    this.InitialLE == input.InitialLE ||
                    (this.InitialLE != null &&
                    this.InitialLE.Equals(input.InitialLE))
                ) && 
                (
                    this.LE == input.LE ||
                    (this.LE != null &&
                    this.LE.Equals(input.LE))
                ) && 
                (
                    this.CD == input.CD ||
                    (this.CD != null &&
                    this.CD.Equals(input.CD))
                ) && 
                (
                    this.Itemization == input.Itemization ||
                    (this.Itemization != null &&
                    this.Itemization.Equals(input.Itemization))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Line == input.Line ||
                    (this.Line != null &&
                    this.Line.Equals(input.Line))
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
                if (this.FeeVarianceFeeType != null)
                    hashCode = hashCode * 59 + this.FeeVarianceFeeType.GetHashCode();
                if (this.FeeVarianceChargeIndex != null)
                    hashCode = hashCode * 59 + this.FeeVarianceChargeIndex.GetHashCode();
                if (this.InitialLE != null)
                    hashCode = hashCode * 59 + this.InitialLE.GetHashCode();
                if (this.LE != null)
                    hashCode = hashCode * 59 + this.LE.GetHashCode();
                if (this.CD != null)
                    hashCode = hashCode * 59 + this.CD.GetHashCode();
                if (this.Itemization != null)
                    hashCode = hashCode * 59 + this.Itemization.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Line != null)
                    hashCode = hashCode * 59 + this.Line.GetHashCode();
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
