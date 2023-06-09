/*
 * NiemTypes
 *
 * NIEM Types for the EIDO
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace NiemTypes
{ 
    /// <summary>
    /// A data type for a result or outcome that is the product of handling, processing, or finalizing something.
    /// </summary>
    [DataContract]
    public partial class NcDispositionType : IEquatable<NcDispositionType>
    { 
        /// <summary>
        /// A kind of disposition. NIEM reference is j:DispositionCategoryCodeText
        /// </summary>
        /// <value>A kind of disposition. NIEM reference is j:DispositionCategoryCodeText</value>

        [DataMember(Name="categoryCode")]
        public List<NcTextType> CategoryCode { get; set; }

        /// <summary>
        /// A kind of disposition. NIEM reference is nc:DispositionCategoryText
        /// </summary>
        /// <value>A kind of disposition. NIEM reference is nc:DispositionCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// An agency responsible for making a disposition decision. NIEM reference is nc:DispositionEntity
        /// </summary>
        /// <value>An agency responsible for making a disposition decision. NIEM reference is nc:DispositionEntity</value>

        [DataMember(Name="entity")]
        public List<NcEntityType> Entity { get; set; }

        /// <summary>
        /// A date a disposition occurred. NIEM reference is nc:DispositionDate
        /// </summary>
        /// <value>A date a disposition occurred. NIEM reference is nc:DispositionDate</value>

        [DataMember(Name="date")]
        public List<NcDateType> Date { get; set; }

        /// <summary>
        /// A description of a disposition. NIEM reference is nc:DispositionDescriptionText
        /// </summary>
        /// <value>A description of a disposition. NIEM reference is nc:DispositionDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A reason for a disposition. NIEM reference is nc:DispositionReasonText
        /// </summary>
        /// <value>A reason for a disposition. NIEM reference is nc:DispositionReasonText</value>

        [DataMember(Name="reason")]
        public List<NcTextType> Reason { get; set; }

        /// <summary>
        /// A name of an authority to which a disposition was reported. NIEM reference is nc:DispositionReportedAuthorityText
        /// </summary>
        /// <value>A name of an authority to which a disposition was reported. NIEM reference is nc:DispositionReportedAuthorityText</value>

        [DataMember(Name="reportedAuthority")]
        public List<NcTextType> ReportedAuthority { get; set; }

        /// <summary>
        /// A result or outcome of a disposition. NIEM reference is nc:DispositionText
        /// </summary>
        /// <value>A result or outcome of a disposition. NIEM reference is nc:DispositionText</value>

        [DataMember(Name="text")]
        public List<NcTextType> Text { get; set; }

        /// <summary>
        /// An official document filed to formally document the disposition of a specific charge. NIEM reference is nc:DispositionInstrument
        /// </summary>
        /// <value>An official document filed to formally document the disposition of a specific charge. NIEM reference is nc:DispositionInstrument</value>

        [DataMember(Name="instrument")]
        public List<NcDocumentType> Instrument { get; set; }

        /// <summary>
        /// Additional information about a disposition. NIEM reference is hs:DispositionAugmentation
        /// </summary>
        /// <value>Additional information about a disposition. NIEM reference is hs:DispositionAugmentation</value>

        [DataMember(Name="augmentation")]
        public List<HsDispositionAugmentationType> Augmentation { get; set; }

        /// <summary>
        /// ncDispositionType JSON-LD context
        /// </summary>
        /// <value>ncDispositionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncDispositionTypeContextJsonldEnum for ../JSON-LD_Contexts/ncDispositionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncDispositionTypeContext.jsonld")]
            JSONLDContextsncDispositionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncDispositionType JSON-LD context
        /// </summary>
        /// <value>ncDispositionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcDispositionType {\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Entity: ").Append(Entity).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  ReportedAuthority: ").Append(ReportedAuthority).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Instrument: ").Append(Instrument).Append("\n");
            sb.Append("  Augmentation: ").Append(Augmentation).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
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
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((NcDispositionType)obj);
        }

        /// <summary>
        /// Returns true if NcDispositionType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcDispositionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcDispositionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    Entity == other.Entity ||
                    Entity != null &&
                    Entity.SequenceEqual(other.Entity)
                ) && 
                (
                    Date == other.Date ||
                    Date != null &&
                    Date.SequenceEqual(other.Date)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    Reason == other.Reason ||
                    Reason != null &&
                    Reason.SequenceEqual(other.Reason)
                ) && 
                (
                    ReportedAuthority == other.ReportedAuthority ||
                    ReportedAuthority != null &&
                    ReportedAuthority.SequenceEqual(other.ReportedAuthority)
                ) && 
                (
                    Text == other.Text ||
                    Text != null &&
                    Text.SequenceEqual(other.Text)
                ) && 
                (
                    Instrument == other.Instrument ||
                    Instrument != null &&
                    Instrument.SequenceEqual(other.Instrument)
                ) && 
                (
                    Augmentation == other.Augmentation ||
                    Augmentation != null &&
                    Augmentation.SequenceEqual(other.Augmentation)
                ) && 
                (
                    Context == other.Context ||
                    Context != null &&
                    Context.Equals(other.Context)
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
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (Entity != null)
                    hashCode = hashCode * 59 + Entity.GetHashCode();
                    if (Date != null)
                    hashCode = hashCode * 59 + Date.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Reason != null)
                    hashCode = hashCode * 59 + Reason.GetHashCode();
                    if (ReportedAuthority != null)
                    hashCode = hashCode * 59 + ReportedAuthority.GetHashCode();
                    if (Text != null)
                    hashCode = hashCode * 59 + Text.GetHashCode();
                    if (Instrument != null)
                    hashCode = hashCode * 59 + Instrument.GetHashCode();
                    if (Augmentation != null)
                    hashCode = hashCode * 59 + Augmentation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcDispositionType left, NcDispositionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcDispositionType left, NcDispositionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
