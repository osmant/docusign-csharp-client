/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
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

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// DisplayApplianceDocumentPage
    /// </summary>
    [DataContract]
    public partial class DisplayApplianceDocumentPage :  IEquatable<DisplayApplianceDocumentPage>, IValidatableObject
    {
        public DisplayApplianceDocumentPage()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DisplayApplianceDocumentPage" /> class.
        /// </summary>
        /// <param name="DocPageCountTotal">.</param>
        /// <param name="DocumentId">Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute..</param>
        /// <param name="DocumentName">.</param>
        /// <param name="Extension">.</param>
        /// <param name="Height72DPI">.</param>
        /// <param name="IsAttachmentType">.</param>
        /// <param name="Page">.</param>
        /// <param name="PageId">.</param>
        /// <param name="Type">.</param>
        /// <param name="Width72DPI">.</param>
        public DisplayApplianceDocumentPage(int? DocPageCountTotal = default(int?), string DocumentId = default(string), string DocumentName = default(string), string Extension = default(string), int? Height72DPI = default(int?), bool? IsAttachmentType = default(bool?), int? Page = default(int?), string PageId = default(string), string Type = default(string), int? Width72DPI = default(int?))
        {
            this.DocPageCountTotal = DocPageCountTotal;
            this.DocumentId = DocumentId;
            this.DocumentName = DocumentName;
            this.Extension = Extension;
            this.Height72DPI = Height72DPI;
            this.IsAttachmentType = IsAttachmentType;
            this.Page = Page;
            this.PageId = PageId;
            this.Type = Type;
            this.Width72DPI = Width72DPI;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="docPageCountTotal", EmitDefaultValue=false)]
        public int? DocPageCountTotal { get; set; }
        /// <summary>
        /// Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.
        /// </summary>
        /// <value>Specifies the document ID number that the tab is placed on. This must refer to an existing Document&#39;s ID attribute.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="documentName", EmitDefaultValue=false)]
        public string DocumentName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="extension", EmitDefaultValue=false)]
        public string Extension { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="height72DPI", EmitDefaultValue=false)]
        public int? Height72DPI { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isAttachmentType", EmitDefaultValue=false)]
        public bool? IsAttachmentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="pageId", EmitDefaultValue=false)]
        public string PageId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="width72DPI", EmitDefaultValue=false)]
        public int? Width72DPI { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DisplayApplianceDocumentPage {\n");
            sb.Append("  DocPageCountTotal: ").Append(DocPageCountTotal).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
            sb.Append("  Height72DPI: ").Append(Height72DPI).Append("\n");
            sb.Append("  IsAttachmentType: ").Append(IsAttachmentType).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageId: ").Append(PageId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Width72DPI: ").Append(Width72DPI).Append("\n");
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
            return this.Equals(obj as DisplayApplianceDocumentPage);
        }

        /// <summary>
        /// Returns true if DisplayApplianceDocumentPage instances are equal
        /// </summary>
        /// <param name="other">Instance of DisplayApplianceDocumentPage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisplayApplianceDocumentPage other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DocPageCountTotal == other.DocPageCountTotal ||
                    this.DocPageCountTotal != null &&
                    this.DocPageCountTotal.Equals(other.DocPageCountTotal)
                ) && 
                (
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
                ) && 
                (
                    this.DocumentName == other.DocumentName ||
                    this.DocumentName != null &&
                    this.DocumentName.Equals(other.DocumentName)
                ) && 
                (
                    this.Extension == other.Extension ||
                    this.Extension != null &&
                    this.Extension.Equals(other.Extension)
                ) && 
                (
                    this.Height72DPI == other.Height72DPI ||
                    this.Height72DPI != null &&
                    this.Height72DPI.Equals(other.Height72DPI)
                ) && 
                (
                    this.IsAttachmentType == other.IsAttachmentType ||
                    this.IsAttachmentType != null &&
                    this.IsAttachmentType.Equals(other.IsAttachmentType)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.PageId == other.PageId ||
                    this.PageId != null &&
                    this.PageId.Equals(other.PageId)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Width72DPI == other.Width72DPI ||
                    this.Width72DPI != null &&
                    this.Width72DPI.Equals(other.Width72DPI)
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
                if (this.DocPageCountTotal != null)
                    hash = hash * 59 + this.DocPageCountTotal.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.DocumentName != null)
                    hash = hash * 59 + this.DocumentName.GetHashCode();
                if (this.Extension != null)
                    hash = hash * 59 + this.Extension.GetHashCode();
                if (this.Height72DPI != null)
                    hash = hash * 59 + this.Height72DPI.GetHashCode();
                if (this.IsAttachmentType != null)
                    hash = hash * 59 + this.IsAttachmentType.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.PageId != null)
                    hash = hash * 59 + this.PageId.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Width72DPI != null)
                    hash = hash * 59 + this.Width72DPI.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}
