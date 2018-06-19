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
    /// MilestoneContract
    /// </summary>
    [DataContract]
    public partial class MilestoneContract :  IEquatable<MilestoneContract>, IValidatableObject
    {
    
        
        /// <summary>
        /// Milestone Guid,Unique indentifier for milestone.
        /// </summary>
        /// <value>Milestone Guid,Unique indentifier for milestone.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Milestone start date.
        /// </summary>
        /// <value>Milestone start date.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Gets or Sets LoanAssociate
        /// </summary>
        [DataMember(Name="loanAssociate", EmitDefaultValue=false)]
        public MilestoneContractLoanAssociate LoanAssociate { get; set; }

        /// <summary>
        /// Days under which milestone need to be completed
        /// </summary>
        /// <value>Days under which milestone need to be completed</value>
        [DataMember(Name="expectedDays", EmitDefaultValue=false)]
        public int? ExpectedDays { get; set; }

        /// <summary>
        /// Indicates if milestone is completed.
        /// </summary>
        /// <value>Indicates if milestone is completed.</value>
        [DataMember(Name="doneIndicator", EmitDefaultValue=false)]
        public bool? DoneIndicator { get; set; }

        /// <summary>
        /// Duration in which milestone is completed.
        /// </summary>
        /// <value>Duration in which milestone is completed.</value>
        [DataMember(Name="actualDays ", EmitDefaultValue=false)]
        public int? ActualDays_ { get; set; }

        /// <summary>
        /// Milestone id.
        /// </summary>
        /// <value>Milestone id.</value>
        [DataMember(Name="milestoneIdString", EmitDefaultValue=false)]
        public string MilestoneIdString { get; set; }

        /// <summary>
        /// Indicates if milestone reviewed.
        /// </summary>
        /// <value>Indicates if milestone reviewed.</value>
        [DataMember(Name="reviewedIndicator", EmitDefaultValue=false)]
        public bool? ReviewedIndicator { get; set; }

        /// <summary>
        /// Indicates if role is required for the milestone.
        /// </summary>
        /// <value>Indicates if role is required for the milestone.</value>
        [DataMember(Name="roleRequired", EmitDefaultValue=false)]
        public bool? RoleRequired { get; set; }

        /// <summary>
        /// Milestone Name indicates milestone stage.
        /// </summary>
        /// <value>Milestone Name indicates milestone stage.</value>
        [DataMember(Name="milestoneName", EmitDefaultValue=false)]
        public string MilestoneName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MilestoneContract {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  LoanAssociate: ").Append(LoanAssociate).Append("\n");
            sb.Append("  ExpectedDays: ").Append(ExpectedDays).Append("\n");
            sb.Append("  DoneIndicator: ").Append(DoneIndicator).Append("\n");
            sb.Append("  ActualDays_: ").Append(ActualDays_).Append("\n");
            sb.Append("  MilestoneIdString: ").Append(MilestoneIdString).Append("\n");
            sb.Append("  ReviewedIndicator: ").Append(ReviewedIndicator).Append("\n");
            sb.Append("  RoleRequired: ").Append(RoleRequired).Append("\n");
            sb.Append("  MilestoneName: ").Append(MilestoneName).Append("\n");
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
            return this.Equals(input as MilestoneContract);
        }

        /// <summary>
        /// Returns true if MilestoneContract instances are equal
        /// </summary>
        /// <param name="input">Instance of MilestoneContract to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MilestoneContract input)
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
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.LoanAssociate == input.LoanAssociate ||
                    (this.LoanAssociate != null &&
                    this.LoanAssociate.Equals(input.LoanAssociate))
                ) && 
                (
                    this.ExpectedDays == input.ExpectedDays ||
                    (this.ExpectedDays != null &&
                    this.ExpectedDays.Equals(input.ExpectedDays))
                ) && 
                (
                    this.DoneIndicator == input.DoneIndicator ||
                    (this.DoneIndicator != null &&
                    this.DoneIndicator.Equals(input.DoneIndicator))
                ) && 
                (
                    this.ActualDays_ == input.ActualDays_ ||
                    (this.ActualDays_ != null &&
                    this.ActualDays_.Equals(input.ActualDays_))
                ) && 
                (
                    this.MilestoneIdString == input.MilestoneIdString ||
                    (this.MilestoneIdString != null &&
                    this.MilestoneIdString.Equals(input.MilestoneIdString))
                ) && 
                (
                    this.ReviewedIndicator == input.ReviewedIndicator ||
                    (this.ReviewedIndicator != null &&
                    this.ReviewedIndicator.Equals(input.ReviewedIndicator))
                ) && 
                (
                    this.RoleRequired == input.RoleRequired ||
                    (this.RoleRequired != null &&
                    this.RoleRequired.Equals(input.RoleRequired))
                ) && 
                (
                    this.MilestoneName == input.MilestoneName ||
                    (this.MilestoneName != null &&
                    this.MilestoneName.Equals(input.MilestoneName))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.LoanAssociate != null)
                    hashCode = hashCode * 59 + this.LoanAssociate.GetHashCode();
                if (this.ExpectedDays != null)
                    hashCode = hashCode * 59 + this.ExpectedDays.GetHashCode();
                if (this.DoneIndicator != null)
                    hashCode = hashCode * 59 + this.DoneIndicator.GetHashCode();
                if (this.ActualDays_ != null)
                    hashCode = hashCode * 59 + this.ActualDays_.GetHashCode();
                if (this.MilestoneIdString != null)
                    hashCode = hashCode * 59 + this.MilestoneIdString.GetHashCode();
                if (this.ReviewedIndicator != null)
                    hashCode = hashCode * 59 + this.ReviewedIndicator.GetHashCode();
                if (this.RoleRequired != null)
                    hashCode = hashCode * 59 + this.RoleRequired.GetHashCode();
                if (this.MilestoneName != null)
                    hashCode = hashCode * 59 + this.MilestoneName.GetHashCode();
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
