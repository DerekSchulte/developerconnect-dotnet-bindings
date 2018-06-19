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
 * Credit
 *
 * Credit APIs
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
using SwaggerDateConverter = Elli.Api.Services.Client.SwaggerDateConverter;

namespace Elli.Api.Services.Model
{
    /// <summary>
    /// Encapsulates the various product options used by the service Partner to contextualize and process a service request. This is a free form object that service Partners determine. The internal structure differs accross service categories as well as accross Partners within a service category.
    /// </summary>
    [DataContract]
    public partial class ProductOptions :  IEquatable<ProductOptions>, IValidatableObject
    {
    
        
        /// <summary>
        /// The type of Underwriting request you would like to place with Fannie Mae. This can be a new request, or the reissue of an existing request (re-perform the Underwriting service for a request that already exists). For the latter, you need to pass an identifier for the existing request on Fannie Mae&#39;s platform. Possible values are - &lt;br&gt;&lt;/br&gt; 1. newOrder - place a new underwriting service request for the referenced loan. &lt;br&gt;&lt;/br&gt; 2. reissue - reissue an underwriting service request for the referenced loan.
        /// </summary>
        /// <value>The type of Underwriting request you would like to place with Fannie Mae. This can be a new request, or the reissue of an existing request (re-perform the Underwriting service for a request that already exists). For the latter, you need to pass an identifier for the existing request on Fannie Mae&#39;s platform. Possible values are - &lt;br&gt;&lt;/br&gt; 1. newOrder - place a new underwriting service request for the referenced loan. &lt;br&gt;&lt;/br&gt; 2. reissue - reissue an underwriting service request for the referenced loan.</value>
        [DataMember(Name="requestType", EmitDefaultValue=false)]
        public string RequestType { get; set; }

        /// <summary>
        /// If Standard LCOR is passed as the value, the loan will be considered a standard limited cash out refinance. Otherwise, the loan is analyzed for DU ReFi Plus qualification - this qualification allows for high loan-to-value ratios (outside of standard underwriting guidelines) when the loan can be verified as owned by Fannie Mae.
        /// </summary>
        /// <value>If Standard LCOR is passed as the value, the loan will be considered a standard limited cash out refinance. Otherwise, the loan is analyzed for DU ReFi Plus qualification - this qualification allows for high loan-to-value ratios (outside of standard underwriting guidelines) when the loan can be verified as owned by Fannie Mae.</value>
        [DataMember(Name="productDescription", EmitDefaultValue=false)]
        public string ProductDescription { get; set; }

        /// <summary>
        /// This is an identifier for an existing request on Fannie Mae&#39;s platform - this is a required field if you are requesting a reissue of an existing underwriting request. If &#39;newRequest&#39; is passed in the requestType, this field will be ignored.
        /// </summary>
        /// <value>This is an identifier for an existing request on Fannie Mae&#39;s platform - this is a required field if you are requesting a reissue of an existing underwriting request. If &#39;newRequest&#39; is passed in the requestType, this field will be ignored.</value>
        [DataMember(Name="ausReportIdentifier", EmitDefaultValue=false)]
        public string AusReportIdentifier { get; set; }

        /// <summary>
        /// This is an identifier for the Credit service provider with whom you placed your credit service request for the loan in reference. This is required as Fannie Mae needs to access your credit report information to process your underwriting service request.
        /// </summary>
        /// <value>This is an identifier for the Credit service provider with whom you placed your credit service request for the loan in reference. This is required as Fannie Mae needs to access your credit report information to process your underwriting service request.</value>
        [DataMember(Name="creditProviderCode", EmitDefaultValue=false)]
        public string CreditProviderCode { get; set; }

        /// <summary>
        /// Gets or Sets OrderCreditDetails
        /// </summary>
        [DataMember(Name="orderCreditDetails", EmitDefaultValue=false)]
        public ProductOptionsOrderCreditDetails OrderCreditDetails { get; set; }

        /// <summary>
        /// Determines how to authenticate to CoreLogic Credco. &#39;true - Indicates a DigiCert SSL certificate will be used. false - Indicates the user name and password will be used to authenticate.&#39;&#39;
        /// </summary>
        /// <value>Determines how to authenticate to CoreLogic Credco. &#39;true - Indicates a DigiCert SSL certificate will be used. false - Indicates the user name and password will be used to authenticate.&#39;&#39;</value>
        [DataMember(Name="digiCert", EmitDefaultValue=false)]
        public bool? DigiCert { get; set; }

        /// <summary>
        /// Possible values are: Individual - Requests a report on on borrower. Joint - Requests reports on both borrowers.
        /// </summary>
        /// <value>Possible values are: Individual - Requests a report on on borrower. Joint - Requests reports on both borrowers.</value>
        [DataMember(Name="reportOn", EmitDefaultValue=false)]
        public string ReportOn { get; set; }

        /// <summary>
        /// Whether to order an individual or merged credit report
        /// </summary>
        /// <value>Whether to order an individual or merged credit report</value>
        [DataMember(Name="reportType", EmitDefaultValue=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// Identifier assigned by CoreLogic Credco. It is returned in the response and is required to reissue or update a report
        /// </summary>
        /// <value>Identifier assigned by CoreLogic Credco. It is returned in the response and is required to reissue or update a report</value>
        [DataMember(Name="creditReportIdentifier", EmitDefaultValue=false)]
        public string CreditReportIdentifier { get; set; }

        /// <summary>
        /// Comment or note to add to the request
        /// </summary>
        /// <value>Comment or note to add to the request</value>
        [DataMember(Name="note", EmitDefaultValue=false)]
        public string Note { get; set; }

        /// <summary>
        /// Indicates whether the request is submitted to Experian. This is a &#39;Y&#39; or &#39;N&#39;
        /// </summary>
        /// <value>Indicates whether the request is submitted to Experian. This is a &#39;Y&#39; or &#39;N&#39;</value>
        [DataMember(Name="creditBureauExperian", EmitDefaultValue=false)]
        public bool? CreditBureauExperian { get; set; }

        /// <summary>
        /// Indicates whether the request is submitted to Equifax. This is a &#39;Y&#39; or &#39;N&#39;
        /// </summary>
        /// <value>Indicates whether the request is submitted to Equifax. This is a &#39;Y&#39; or &#39;N&#39;</value>
        [DataMember(Name="creditBureauEquifax", EmitDefaultValue=false)]
        public bool? CreditBureauEquifax { get; set; }

        /// <summary>
        /// Indicates whether the request is submitted to TransUnion. This is a &#39;Y&#39; or &#39;N&#39;
        /// </summary>
        /// <value>Indicates whether the request is submitted to TransUnion. This is a &#39;Y&#39; or &#39;N&#39;</value>
        [DataMember(Name="creditBureauTransUnion", EmitDefaultValue=false)]
        public bool? CreditBureauTransUnion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductOptions {\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  ProductDescription: ").Append(ProductDescription).Append("\n");
            sb.Append("  AusReportIdentifier: ").Append(AusReportIdentifier).Append("\n");
            sb.Append("  CreditProviderCode: ").Append(CreditProviderCode).Append("\n");
            sb.Append("  OrderCreditDetails: ").Append(OrderCreditDetails).Append("\n");
            sb.Append("  DigiCert: ").Append(DigiCert).Append("\n");
            sb.Append("  ReportOn: ").Append(ReportOn).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  CreditReportIdentifier: ").Append(CreditReportIdentifier).Append("\n");
            sb.Append("  Note: ").Append(Note).Append("\n");
            sb.Append("  CreditBureauExperian: ").Append(CreditBureauExperian).Append("\n");
            sb.Append("  CreditBureauEquifax: ").Append(CreditBureauEquifax).Append("\n");
            sb.Append("  CreditBureauTransUnion: ").Append(CreditBureauTransUnion).Append("\n");
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
            return this.Equals(input as ProductOptions);
        }

        /// <summary>
        /// Returns true if ProductOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestType == input.RequestType ||
                    (this.RequestType != null &&
                    this.RequestType.Equals(input.RequestType))
                ) && 
                (
                    this.ProductDescription == input.ProductDescription ||
                    (this.ProductDescription != null &&
                    this.ProductDescription.Equals(input.ProductDescription))
                ) && 
                (
                    this.AusReportIdentifier == input.AusReportIdentifier ||
                    (this.AusReportIdentifier != null &&
                    this.AusReportIdentifier.Equals(input.AusReportIdentifier))
                ) && 
                (
                    this.CreditProviderCode == input.CreditProviderCode ||
                    (this.CreditProviderCode != null &&
                    this.CreditProviderCode.Equals(input.CreditProviderCode))
                ) && 
                (
                    this.OrderCreditDetails == input.OrderCreditDetails ||
                    (this.OrderCreditDetails != null &&
                    this.OrderCreditDetails.Equals(input.OrderCreditDetails))
                ) && 
                (
                    this.DigiCert == input.DigiCert ||
                    (this.DigiCert != null &&
                    this.DigiCert.Equals(input.DigiCert))
                ) && 
                (
                    this.ReportOn == input.ReportOn ||
                    (this.ReportOn != null &&
                    this.ReportOn.Equals(input.ReportOn))
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
                ) && 
                (
                    this.CreditReportIdentifier == input.CreditReportIdentifier ||
                    (this.CreditReportIdentifier != null &&
                    this.CreditReportIdentifier.Equals(input.CreditReportIdentifier))
                ) && 
                (
                    this.Note == input.Note ||
                    (this.Note != null &&
                    this.Note.Equals(input.Note))
                ) && 
                (
                    this.CreditBureauExperian == input.CreditBureauExperian ||
                    (this.CreditBureauExperian != null &&
                    this.CreditBureauExperian.Equals(input.CreditBureauExperian))
                ) && 
                (
                    this.CreditBureauEquifax == input.CreditBureauEquifax ||
                    (this.CreditBureauEquifax != null &&
                    this.CreditBureauEquifax.Equals(input.CreditBureauEquifax))
                ) && 
                (
                    this.CreditBureauTransUnion == input.CreditBureauTransUnion ||
                    (this.CreditBureauTransUnion != null &&
                    this.CreditBureauTransUnion.Equals(input.CreditBureauTransUnion))
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
                if (this.RequestType != null)
                    hashCode = hashCode * 59 + this.RequestType.GetHashCode();
                if (this.ProductDescription != null)
                    hashCode = hashCode * 59 + this.ProductDescription.GetHashCode();
                if (this.AusReportIdentifier != null)
                    hashCode = hashCode * 59 + this.AusReportIdentifier.GetHashCode();
                if (this.CreditProviderCode != null)
                    hashCode = hashCode * 59 + this.CreditProviderCode.GetHashCode();
                if (this.OrderCreditDetails != null)
                    hashCode = hashCode * 59 + this.OrderCreditDetails.GetHashCode();
                if (this.DigiCert != null)
                    hashCode = hashCode * 59 + this.DigiCert.GetHashCode();
                if (this.ReportOn != null)
                    hashCode = hashCode * 59 + this.ReportOn.GetHashCode();
                if (this.ReportType != null)
                    hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.CreditReportIdentifier != null)
                    hashCode = hashCode * 59 + this.CreditReportIdentifier.GetHashCode();
                if (this.Note != null)
                    hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.CreditBureauExperian != null)
                    hashCode = hashCode * 59 + this.CreditBureauExperian.GetHashCode();
                if (this.CreditBureauEquifax != null)
                    hashCode = hashCode * 59 + this.CreditBureauEquifax.GetHashCode();
                if (this.CreditBureauTransUnion != null)
                    hashCode = hashCode * 59 + this.CreditBureauTransUnion.GetHashCode();
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
