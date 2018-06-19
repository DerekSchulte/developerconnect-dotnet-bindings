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
    /// LoanContractPrivacyPolicy
    /// </summary>
    [DataContract]
    public partial class LoanContractPrivacyPolicy :  IEquatable<LoanContractPrivacyPolicy>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets AdditionalRightsDescription
        /// </summary>
        [DataMember(Name="additionalRightsDescription", EmitDefaultValue=false)]
        public string AdditionalRightsDescription { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateType
        /// </summary>
        [DataMember(Name="affiliateType", EmitDefaultValue=false)]
        public string AffiliateType { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateTypeExample1
        /// </summary>
        [DataMember(Name="affiliateTypeExample1", EmitDefaultValue=false)]
        public string AffiliateTypeExample1 { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateTypeExample2
        /// </summary>
        [DataMember(Name="affiliateTypeExample2", EmitDefaultValue=false)]
        public string AffiliateTypeExample2 { get; set; }

        /// <summary>
        /// Gets or Sets AffiliateTypeExample3
        /// </summary>
        [DataMember(Name="affiliateTypeExample3", EmitDefaultValue=false)]
        public string AffiliateTypeExample3 { get; set; }

        /// <summary>
        /// Gets or Sets AlsoCollectFrom
        /// </summary>
        [DataMember(Name="alsoCollectFrom", EmitDefaultValue=false)]
        public string AlsoCollectFrom { get; set; }

        /// <summary>
        /// Gets or Sets DaysToUse
        /// </summary>
        [DataMember(Name="daysToUse", EmitDefaultValue=false)]
        public int? DaysToUse { get; set; }

        /// <summary>
        /// Gets or Sets HowToShare
        /// </summary>
        [DataMember(Name="howToShare", EmitDefaultValue=false)]
        public string HowToShare { get; set; }

        /// <summary>
        /// Gets or Sets InformationShare1
        /// </summary>
        [DataMember(Name="informationShare1", EmitDefaultValue=false)]
        public string InformationShare1 { get; set; }

        /// <summary>
        /// Gets or Sets InformationShare2
        /// </summary>
        [DataMember(Name="informationShare2", EmitDefaultValue=false)]
        public string InformationShare2 { get; set; }

        /// <summary>
        /// Gets or Sets InformationShare3
        /// </summary>
        [DataMember(Name="informationShare3", EmitDefaultValue=false)]
        public string InformationShare3 { get; set; }

        /// <summary>
        /// Gets or Sets InformationShare4
        /// </summary>
        [DataMember(Name="informationShare4", EmitDefaultValue=false)]
        public string InformationShare4 { get; set; }

        /// <summary>
        /// Gets or Sets InformationShare5
        /// </summary>
        [DataMember(Name="informationShare5", EmitDefaultValue=false)]
        public string InformationShare5 { get; set; }

        /// <summary>
        /// Gets or Sets InformationShare6
        /// </summary>
        [DataMember(Name="informationShare6", EmitDefaultValue=false)]
        public string InformationShare6 { get; set; }

        /// <summary>
        /// Gets or Sets InformationShare7
        /// </summary>
        [DataMember(Name="informationShare7", EmitDefaultValue=false)]
        public string InformationShare7 { get; set; }

        /// <summary>
        /// Gets or Sets InformationTypesWeCollect1
        /// </summary>
        [DataMember(Name="informationTypesWeCollect1", EmitDefaultValue=false)]
        public string InformationTypesWeCollect1 { get; set; }

        /// <summary>
        /// Gets or Sets InformationTypesWeCollect2
        /// </summary>
        [DataMember(Name="informationTypesWeCollect2", EmitDefaultValue=false)]
        public string InformationTypesWeCollect2 { get; set; }

        /// <summary>
        /// Gets or Sets InformationTypesWeCollect3
        /// </summary>
        [DataMember(Name="informationTypesWeCollect3", EmitDefaultValue=false)]
        public string InformationTypesWeCollect3 { get; set; }

        /// <summary>
        /// Gets or Sets InformationTypesWeCollect4
        /// </summary>
        [DataMember(Name="informationTypesWeCollect4", EmitDefaultValue=false)]
        public string InformationTypesWeCollect4 { get; set; }

        /// <summary>
        /// Gets or Sets InformationTypesWeCollect5
        /// </summary>
        [DataMember(Name="informationTypesWeCollect5", EmitDefaultValue=false)]
        public string InformationTypesWeCollect5 { get; set; }

        /// <summary>
        /// Gets or Sets JointMarketType
        /// </summary>
        [DataMember(Name="jointMarketType", EmitDefaultValue=false)]
        public string JointMarketType { get; set; }

        /// <summary>
        /// Gets or Sets JointMarketTypeExample1
        /// </summary>
        [DataMember(Name="jointMarketTypeExample1", EmitDefaultValue=false)]
        public string JointMarketTypeExample1 { get; set; }

        /// <summary>
        /// Gets or Sets LimitSharing1
        /// </summary>
        [DataMember(Name="limitSharing1", EmitDefaultValue=false)]
        public string LimitSharing1 { get; set; }

        /// <summary>
        /// Gets or Sets LimitSharing2
        /// </summary>
        [DataMember(Name="limitSharing2", EmitDefaultValue=false)]
        public string LimitSharing2 { get; set; }

        /// <summary>
        /// Gets or Sets LimitSharing3
        /// </summary>
        [DataMember(Name="limitSharing3", EmitDefaultValue=false)]
        public string LimitSharing3 { get; set; }

        /// <summary>
        /// Gets or Sets LimitSharing4
        /// </summary>
        [DataMember(Name="limitSharing4", EmitDefaultValue=false)]
        public string LimitSharing4 { get; set; }

        /// <summary>
        /// Gets or Sets LimitSharing5
        /// </summary>
        [DataMember(Name="limitSharing5", EmitDefaultValue=false)]
        public string LimitSharing5 { get; set; }

        /// <summary>
        /// Gets or Sets LimitSharing6
        /// </summary>
        [DataMember(Name="limitSharing6", EmitDefaultValue=false)]
        public string LimitSharing6 { get; set; }

        /// <summary>
        /// Gets or Sets LimitSharing7
        /// </summary>
        [DataMember(Name="limitSharing7", EmitDefaultValue=false)]
        public string LimitSharing7 { get; set; }

        /// <summary>
        /// Gets or Sets NonaffiliateType
        /// </summary>
        [DataMember(Name="nonaffiliateType", EmitDefaultValue=false)]
        public string NonaffiliateType { get; set; }

        /// <summary>
        /// Gets or Sets NonaffiliateTypeExample1
        /// </summary>
        [DataMember(Name="nonaffiliateTypeExample1", EmitDefaultValue=false)]
        public string NonaffiliateTypeExample1 { get; set; }

        /// <summary>
        /// Gets or Sets NotesForProtectPrivacy
        /// </summary>
        [DataMember(Name="notesForProtectPrivacy", EmitDefaultValue=false)]
        public string NotesForProtectPrivacy { get; set; }

        /// <summary>
        /// Gets or Sets OtherInformation
        /// </summary>
        [DataMember(Name="otherInformation", EmitDefaultValue=false)]
        public string OtherInformation { get; set; }

        /// <summary>
        /// Gets or Sets PhoneForQuestion
        /// </summary>
        [DataMember(Name="phoneForQuestion", EmitDefaultValue=false)]
        public string PhoneForQuestion { get; set; }

        /// <summary>
        /// Gets or Sets PhoneToLimit
        /// </summary>
        [DataMember(Name="phoneToLimit", EmitDefaultValue=false)]
        public string PhoneToLimit { get; set; }

        /// <summary>
        /// Gets or Sets PrintSelection
        /// </summary>
        [DataMember(Name="printSelection", EmitDefaultValue=false)]
        public string PrintSelection { get; set; }

        /// <summary>
        /// Gets or Sets ShareInfoWithJointMarketing
        /// </summary>
        [DataMember(Name="shareInfoWithJointMarketing", EmitDefaultValue=false)]
        public string ShareInfoWithJointMarketing { get; set; }

        /// <summary>
        /// Gets or Sets TimesToCollect1
        /// </summary>
        [DataMember(Name="timesToCollect1", EmitDefaultValue=false)]
        public string TimesToCollect1 { get; set; }

        /// <summary>
        /// Gets or Sets TimesToCollect2
        /// </summary>
        [DataMember(Name="timesToCollect2", EmitDefaultValue=false)]
        public string TimesToCollect2 { get; set; }

        /// <summary>
        /// Gets or Sets TimesToCollect3
        /// </summary>
        [DataMember(Name="timesToCollect3", EmitDefaultValue=false)]
        public string TimesToCollect3 { get; set; }

        /// <summary>
        /// Gets or Sets TimesToCollect4
        /// </summary>
        [DataMember(Name="timesToCollect4", EmitDefaultValue=false)]
        public string TimesToCollect4 { get; set; }

        /// <summary>
        /// Gets or Sets TimesToCollect5
        /// </summary>
        [DataMember(Name="timesToCollect5", EmitDefaultValue=false)]
        public string TimesToCollect5 { get; set; }

        /// <summary>
        /// Gets or Sets WebsiteForQuestion
        /// </summary>
        [DataMember(Name="websiteForQuestion", EmitDefaultValue=false)]
        public string WebsiteForQuestion { get; set; }

        /// <summary>
        /// Gets or Sets WebsiteToLimit
        /// </summary>
        [DataMember(Name="websiteToLimit", EmitDefaultValue=false)]
        public string WebsiteToLimit { get; set; }

        /// <summary>
        /// Gets or Sets Month
        /// </summary>
        [DataMember(Name="month", EmitDefaultValue=false)]
        public string Month { get; set; }

        /// <summary>
        /// Gets or Sets Year
        /// </summary>
        [DataMember(Name="year", EmitDefaultValue=false)]
        public int? Year { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractPrivacyPolicy {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AdditionalRightsDescription: ").Append(AdditionalRightsDescription).Append("\n");
            sb.Append("  AffiliateType: ").Append(AffiliateType).Append("\n");
            sb.Append("  AffiliateTypeExample1: ").Append(AffiliateTypeExample1).Append("\n");
            sb.Append("  AffiliateTypeExample2: ").Append(AffiliateTypeExample2).Append("\n");
            sb.Append("  AffiliateTypeExample3: ").Append(AffiliateTypeExample3).Append("\n");
            sb.Append("  AlsoCollectFrom: ").Append(AlsoCollectFrom).Append("\n");
            sb.Append("  DaysToUse: ").Append(DaysToUse).Append("\n");
            sb.Append("  HowToShare: ").Append(HowToShare).Append("\n");
            sb.Append("  InformationShare1: ").Append(InformationShare1).Append("\n");
            sb.Append("  InformationShare2: ").Append(InformationShare2).Append("\n");
            sb.Append("  InformationShare3: ").Append(InformationShare3).Append("\n");
            sb.Append("  InformationShare4: ").Append(InformationShare4).Append("\n");
            sb.Append("  InformationShare5: ").Append(InformationShare5).Append("\n");
            sb.Append("  InformationShare6: ").Append(InformationShare6).Append("\n");
            sb.Append("  InformationShare7: ").Append(InformationShare7).Append("\n");
            sb.Append("  InformationTypesWeCollect1: ").Append(InformationTypesWeCollect1).Append("\n");
            sb.Append("  InformationTypesWeCollect2: ").Append(InformationTypesWeCollect2).Append("\n");
            sb.Append("  InformationTypesWeCollect3: ").Append(InformationTypesWeCollect3).Append("\n");
            sb.Append("  InformationTypesWeCollect4: ").Append(InformationTypesWeCollect4).Append("\n");
            sb.Append("  InformationTypesWeCollect5: ").Append(InformationTypesWeCollect5).Append("\n");
            sb.Append("  JointMarketType: ").Append(JointMarketType).Append("\n");
            sb.Append("  JointMarketTypeExample1: ").Append(JointMarketTypeExample1).Append("\n");
            sb.Append("  LimitSharing1: ").Append(LimitSharing1).Append("\n");
            sb.Append("  LimitSharing2: ").Append(LimitSharing2).Append("\n");
            sb.Append("  LimitSharing3: ").Append(LimitSharing3).Append("\n");
            sb.Append("  LimitSharing4: ").Append(LimitSharing4).Append("\n");
            sb.Append("  LimitSharing5: ").Append(LimitSharing5).Append("\n");
            sb.Append("  LimitSharing6: ").Append(LimitSharing6).Append("\n");
            sb.Append("  LimitSharing7: ").Append(LimitSharing7).Append("\n");
            sb.Append("  NonaffiliateType: ").Append(NonaffiliateType).Append("\n");
            sb.Append("  NonaffiliateTypeExample1: ").Append(NonaffiliateTypeExample1).Append("\n");
            sb.Append("  NotesForProtectPrivacy: ").Append(NotesForProtectPrivacy).Append("\n");
            sb.Append("  OtherInformation: ").Append(OtherInformation).Append("\n");
            sb.Append("  PhoneForQuestion: ").Append(PhoneForQuestion).Append("\n");
            sb.Append("  PhoneToLimit: ").Append(PhoneToLimit).Append("\n");
            sb.Append("  PrintSelection: ").Append(PrintSelection).Append("\n");
            sb.Append("  ShareInfoWithJointMarketing: ").Append(ShareInfoWithJointMarketing).Append("\n");
            sb.Append("  TimesToCollect1: ").Append(TimesToCollect1).Append("\n");
            sb.Append("  TimesToCollect2: ").Append(TimesToCollect2).Append("\n");
            sb.Append("  TimesToCollect3: ").Append(TimesToCollect3).Append("\n");
            sb.Append("  TimesToCollect4: ").Append(TimesToCollect4).Append("\n");
            sb.Append("  TimesToCollect5: ").Append(TimesToCollect5).Append("\n");
            sb.Append("  WebsiteForQuestion: ").Append(WebsiteForQuestion).Append("\n");
            sb.Append("  WebsiteToLimit: ").Append(WebsiteToLimit).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
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
            return this.Equals(input as LoanContractPrivacyPolicy);
        }

        /// <summary>
        /// Returns true if LoanContractPrivacyPolicy instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractPrivacyPolicy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractPrivacyPolicy input)
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
                    this.AdditionalRightsDescription == input.AdditionalRightsDescription ||
                    (this.AdditionalRightsDescription != null &&
                    this.AdditionalRightsDescription.Equals(input.AdditionalRightsDescription))
                ) && 
                (
                    this.AffiliateType == input.AffiliateType ||
                    (this.AffiliateType != null &&
                    this.AffiliateType.Equals(input.AffiliateType))
                ) && 
                (
                    this.AffiliateTypeExample1 == input.AffiliateTypeExample1 ||
                    (this.AffiliateTypeExample1 != null &&
                    this.AffiliateTypeExample1.Equals(input.AffiliateTypeExample1))
                ) && 
                (
                    this.AffiliateTypeExample2 == input.AffiliateTypeExample2 ||
                    (this.AffiliateTypeExample2 != null &&
                    this.AffiliateTypeExample2.Equals(input.AffiliateTypeExample2))
                ) && 
                (
                    this.AffiliateTypeExample3 == input.AffiliateTypeExample3 ||
                    (this.AffiliateTypeExample3 != null &&
                    this.AffiliateTypeExample3.Equals(input.AffiliateTypeExample3))
                ) && 
                (
                    this.AlsoCollectFrom == input.AlsoCollectFrom ||
                    (this.AlsoCollectFrom != null &&
                    this.AlsoCollectFrom.Equals(input.AlsoCollectFrom))
                ) && 
                (
                    this.DaysToUse == input.DaysToUse ||
                    (this.DaysToUse != null &&
                    this.DaysToUse.Equals(input.DaysToUse))
                ) && 
                (
                    this.HowToShare == input.HowToShare ||
                    (this.HowToShare != null &&
                    this.HowToShare.Equals(input.HowToShare))
                ) && 
                (
                    this.InformationShare1 == input.InformationShare1 ||
                    (this.InformationShare1 != null &&
                    this.InformationShare1.Equals(input.InformationShare1))
                ) && 
                (
                    this.InformationShare2 == input.InformationShare2 ||
                    (this.InformationShare2 != null &&
                    this.InformationShare2.Equals(input.InformationShare2))
                ) && 
                (
                    this.InformationShare3 == input.InformationShare3 ||
                    (this.InformationShare3 != null &&
                    this.InformationShare3.Equals(input.InformationShare3))
                ) && 
                (
                    this.InformationShare4 == input.InformationShare4 ||
                    (this.InformationShare4 != null &&
                    this.InformationShare4.Equals(input.InformationShare4))
                ) && 
                (
                    this.InformationShare5 == input.InformationShare5 ||
                    (this.InformationShare5 != null &&
                    this.InformationShare5.Equals(input.InformationShare5))
                ) && 
                (
                    this.InformationShare6 == input.InformationShare6 ||
                    (this.InformationShare6 != null &&
                    this.InformationShare6.Equals(input.InformationShare6))
                ) && 
                (
                    this.InformationShare7 == input.InformationShare7 ||
                    (this.InformationShare7 != null &&
                    this.InformationShare7.Equals(input.InformationShare7))
                ) && 
                (
                    this.InformationTypesWeCollect1 == input.InformationTypesWeCollect1 ||
                    (this.InformationTypesWeCollect1 != null &&
                    this.InformationTypesWeCollect1.Equals(input.InformationTypesWeCollect1))
                ) && 
                (
                    this.InformationTypesWeCollect2 == input.InformationTypesWeCollect2 ||
                    (this.InformationTypesWeCollect2 != null &&
                    this.InformationTypesWeCollect2.Equals(input.InformationTypesWeCollect2))
                ) && 
                (
                    this.InformationTypesWeCollect3 == input.InformationTypesWeCollect3 ||
                    (this.InformationTypesWeCollect3 != null &&
                    this.InformationTypesWeCollect3.Equals(input.InformationTypesWeCollect3))
                ) && 
                (
                    this.InformationTypesWeCollect4 == input.InformationTypesWeCollect4 ||
                    (this.InformationTypesWeCollect4 != null &&
                    this.InformationTypesWeCollect4.Equals(input.InformationTypesWeCollect4))
                ) && 
                (
                    this.InformationTypesWeCollect5 == input.InformationTypesWeCollect5 ||
                    (this.InformationTypesWeCollect5 != null &&
                    this.InformationTypesWeCollect5.Equals(input.InformationTypesWeCollect5))
                ) && 
                (
                    this.JointMarketType == input.JointMarketType ||
                    (this.JointMarketType != null &&
                    this.JointMarketType.Equals(input.JointMarketType))
                ) && 
                (
                    this.JointMarketTypeExample1 == input.JointMarketTypeExample1 ||
                    (this.JointMarketTypeExample1 != null &&
                    this.JointMarketTypeExample1.Equals(input.JointMarketTypeExample1))
                ) && 
                (
                    this.LimitSharing1 == input.LimitSharing1 ||
                    (this.LimitSharing1 != null &&
                    this.LimitSharing1.Equals(input.LimitSharing1))
                ) && 
                (
                    this.LimitSharing2 == input.LimitSharing2 ||
                    (this.LimitSharing2 != null &&
                    this.LimitSharing2.Equals(input.LimitSharing2))
                ) && 
                (
                    this.LimitSharing3 == input.LimitSharing3 ||
                    (this.LimitSharing3 != null &&
                    this.LimitSharing3.Equals(input.LimitSharing3))
                ) && 
                (
                    this.LimitSharing4 == input.LimitSharing4 ||
                    (this.LimitSharing4 != null &&
                    this.LimitSharing4.Equals(input.LimitSharing4))
                ) && 
                (
                    this.LimitSharing5 == input.LimitSharing5 ||
                    (this.LimitSharing5 != null &&
                    this.LimitSharing5.Equals(input.LimitSharing5))
                ) && 
                (
                    this.LimitSharing6 == input.LimitSharing6 ||
                    (this.LimitSharing6 != null &&
                    this.LimitSharing6.Equals(input.LimitSharing6))
                ) && 
                (
                    this.LimitSharing7 == input.LimitSharing7 ||
                    (this.LimitSharing7 != null &&
                    this.LimitSharing7.Equals(input.LimitSharing7))
                ) && 
                (
                    this.NonaffiliateType == input.NonaffiliateType ||
                    (this.NonaffiliateType != null &&
                    this.NonaffiliateType.Equals(input.NonaffiliateType))
                ) && 
                (
                    this.NonaffiliateTypeExample1 == input.NonaffiliateTypeExample1 ||
                    (this.NonaffiliateTypeExample1 != null &&
                    this.NonaffiliateTypeExample1.Equals(input.NonaffiliateTypeExample1))
                ) && 
                (
                    this.NotesForProtectPrivacy == input.NotesForProtectPrivacy ||
                    (this.NotesForProtectPrivacy != null &&
                    this.NotesForProtectPrivacy.Equals(input.NotesForProtectPrivacy))
                ) && 
                (
                    this.OtherInformation == input.OtherInformation ||
                    (this.OtherInformation != null &&
                    this.OtherInformation.Equals(input.OtherInformation))
                ) && 
                (
                    this.PhoneForQuestion == input.PhoneForQuestion ||
                    (this.PhoneForQuestion != null &&
                    this.PhoneForQuestion.Equals(input.PhoneForQuestion))
                ) && 
                (
                    this.PhoneToLimit == input.PhoneToLimit ||
                    (this.PhoneToLimit != null &&
                    this.PhoneToLimit.Equals(input.PhoneToLimit))
                ) && 
                (
                    this.PrintSelection == input.PrintSelection ||
                    (this.PrintSelection != null &&
                    this.PrintSelection.Equals(input.PrintSelection))
                ) && 
                (
                    this.ShareInfoWithJointMarketing == input.ShareInfoWithJointMarketing ||
                    (this.ShareInfoWithJointMarketing != null &&
                    this.ShareInfoWithJointMarketing.Equals(input.ShareInfoWithJointMarketing))
                ) && 
                (
                    this.TimesToCollect1 == input.TimesToCollect1 ||
                    (this.TimesToCollect1 != null &&
                    this.TimesToCollect1.Equals(input.TimesToCollect1))
                ) && 
                (
                    this.TimesToCollect2 == input.TimesToCollect2 ||
                    (this.TimesToCollect2 != null &&
                    this.TimesToCollect2.Equals(input.TimesToCollect2))
                ) && 
                (
                    this.TimesToCollect3 == input.TimesToCollect3 ||
                    (this.TimesToCollect3 != null &&
                    this.TimesToCollect3.Equals(input.TimesToCollect3))
                ) && 
                (
                    this.TimesToCollect4 == input.TimesToCollect4 ||
                    (this.TimesToCollect4 != null &&
                    this.TimesToCollect4.Equals(input.TimesToCollect4))
                ) && 
                (
                    this.TimesToCollect5 == input.TimesToCollect5 ||
                    (this.TimesToCollect5 != null &&
                    this.TimesToCollect5.Equals(input.TimesToCollect5))
                ) && 
                (
                    this.WebsiteForQuestion == input.WebsiteForQuestion ||
                    (this.WebsiteForQuestion != null &&
                    this.WebsiteForQuestion.Equals(input.WebsiteForQuestion))
                ) && 
                (
                    this.WebsiteToLimit == input.WebsiteToLimit ||
                    (this.WebsiteToLimit != null &&
                    this.WebsiteToLimit.Equals(input.WebsiteToLimit))
                ) && 
                (
                    this.Month == input.Month ||
                    (this.Month != null &&
                    this.Month.Equals(input.Month))
                ) && 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
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
                if (this.AdditionalRightsDescription != null)
                    hashCode = hashCode * 59 + this.AdditionalRightsDescription.GetHashCode();
                if (this.AffiliateType != null)
                    hashCode = hashCode * 59 + this.AffiliateType.GetHashCode();
                if (this.AffiliateTypeExample1 != null)
                    hashCode = hashCode * 59 + this.AffiliateTypeExample1.GetHashCode();
                if (this.AffiliateTypeExample2 != null)
                    hashCode = hashCode * 59 + this.AffiliateTypeExample2.GetHashCode();
                if (this.AffiliateTypeExample3 != null)
                    hashCode = hashCode * 59 + this.AffiliateTypeExample3.GetHashCode();
                if (this.AlsoCollectFrom != null)
                    hashCode = hashCode * 59 + this.AlsoCollectFrom.GetHashCode();
                if (this.DaysToUse != null)
                    hashCode = hashCode * 59 + this.DaysToUse.GetHashCode();
                if (this.HowToShare != null)
                    hashCode = hashCode * 59 + this.HowToShare.GetHashCode();
                if (this.InformationShare1 != null)
                    hashCode = hashCode * 59 + this.InformationShare1.GetHashCode();
                if (this.InformationShare2 != null)
                    hashCode = hashCode * 59 + this.InformationShare2.GetHashCode();
                if (this.InformationShare3 != null)
                    hashCode = hashCode * 59 + this.InformationShare3.GetHashCode();
                if (this.InformationShare4 != null)
                    hashCode = hashCode * 59 + this.InformationShare4.GetHashCode();
                if (this.InformationShare5 != null)
                    hashCode = hashCode * 59 + this.InformationShare5.GetHashCode();
                if (this.InformationShare6 != null)
                    hashCode = hashCode * 59 + this.InformationShare6.GetHashCode();
                if (this.InformationShare7 != null)
                    hashCode = hashCode * 59 + this.InformationShare7.GetHashCode();
                if (this.InformationTypesWeCollect1 != null)
                    hashCode = hashCode * 59 + this.InformationTypesWeCollect1.GetHashCode();
                if (this.InformationTypesWeCollect2 != null)
                    hashCode = hashCode * 59 + this.InformationTypesWeCollect2.GetHashCode();
                if (this.InformationTypesWeCollect3 != null)
                    hashCode = hashCode * 59 + this.InformationTypesWeCollect3.GetHashCode();
                if (this.InformationTypesWeCollect4 != null)
                    hashCode = hashCode * 59 + this.InformationTypesWeCollect4.GetHashCode();
                if (this.InformationTypesWeCollect5 != null)
                    hashCode = hashCode * 59 + this.InformationTypesWeCollect5.GetHashCode();
                if (this.JointMarketType != null)
                    hashCode = hashCode * 59 + this.JointMarketType.GetHashCode();
                if (this.JointMarketTypeExample1 != null)
                    hashCode = hashCode * 59 + this.JointMarketTypeExample1.GetHashCode();
                if (this.LimitSharing1 != null)
                    hashCode = hashCode * 59 + this.LimitSharing1.GetHashCode();
                if (this.LimitSharing2 != null)
                    hashCode = hashCode * 59 + this.LimitSharing2.GetHashCode();
                if (this.LimitSharing3 != null)
                    hashCode = hashCode * 59 + this.LimitSharing3.GetHashCode();
                if (this.LimitSharing4 != null)
                    hashCode = hashCode * 59 + this.LimitSharing4.GetHashCode();
                if (this.LimitSharing5 != null)
                    hashCode = hashCode * 59 + this.LimitSharing5.GetHashCode();
                if (this.LimitSharing6 != null)
                    hashCode = hashCode * 59 + this.LimitSharing6.GetHashCode();
                if (this.LimitSharing7 != null)
                    hashCode = hashCode * 59 + this.LimitSharing7.GetHashCode();
                if (this.NonaffiliateType != null)
                    hashCode = hashCode * 59 + this.NonaffiliateType.GetHashCode();
                if (this.NonaffiliateTypeExample1 != null)
                    hashCode = hashCode * 59 + this.NonaffiliateTypeExample1.GetHashCode();
                if (this.NotesForProtectPrivacy != null)
                    hashCode = hashCode * 59 + this.NotesForProtectPrivacy.GetHashCode();
                if (this.OtherInformation != null)
                    hashCode = hashCode * 59 + this.OtherInformation.GetHashCode();
                if (this.PhoneForQuestion != null)
                    hashCode = hashCode * 59 + this.PhoneForQuestion.GetHashCode();
                if (this.PhoneToLimit != null)
                    hashCode = hashCode * 59 + this.PhoneToLimit.GetHashCode();
                if (this.PrintSelection != null)
                    hashCode = hashCode * 59 + this.PrintSelection.GetHashCode();
                if (this.ShareInfoWithJointMarketing != null)
                    hashCode = hashCode * 59 + this.ShareInfoWithJointMarketing.GetHashCode();
                if (this.TimesToCollect1 != null)
                    hashCode = hashCode * 59 + this.TimesToCollect1.GetHashCode();
                if (this.TimesToCollect2 != null)
                    hashCode = hashCode * 59 + this.TimesToCollect2.GetHashCode();
                if (this.TimesToCollect3 != null)
                    hashCode = hashCode * 59 + this.TimesToCollect3.GetHashCode();
                if (this.TimesToCollect4 != null)
                    hashCode = hashCode * 59 + this.TimesToCollect4.GetHashCode();
                if (this.TimesToCollect5 != null)
                    hashCode = hashCode * 59 + this.TimesToCollect5.GetHashCode();
                if (this.WebsiteForQuestion != null)
                    hashCode = hashCode * 59 + this.WebsiteForQuestion.GetHashCode();
                if (this.WebsiteToLimit != null)
                    hashCode = hashCode * 59 + this.WebsiteToLimit.GetHashCode();
                if (this.Month != null)
                    hashCode = hashCode * 59 + this.Month.GetHashCode();
                if (this.Year != null)
                    hashCode = hashCode * 59 + this.Year.GetHashCode();
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
