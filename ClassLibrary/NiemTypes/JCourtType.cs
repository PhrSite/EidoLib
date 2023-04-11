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
    /// A data type for a court or a unit of a court responsible for trying justice proceedings.
    /// </summary>
    [DataContract]
    public partial class JCourtType : NcOrganizationType, IEquatable<JCourtType>
    { 
        /// <summary>
        /// A name of a unit of a court. NIEM reference is j:CourtName
        /// </summary>
        /// <value>A name of a unit of a court. NIEM reference is j:CourtName</value>

        [DataMember(Name="name")]
        public List<NcTextType> Name { get; set; }

        /// <summary>
        /// A person who performs the clerk duties in a court. NIEM reference is j:CourtClerk
        /// </summary>
        /// <value>A person who performs the clerk duties in a court. NIEM reference is j:CourtClerk</value>

        [DataMember(Name="clerk")]
        public List<JJudicialOfficialType> Clerk { get; set; }

        /// <summary>
        /// A person in employ of the court who transcribes a court proceeding. NIEM reference is j:CourtReporter
        /// </summary>
        /// <value>A person in employ of the court who transcribes a court proceeding. NIEM reference is j:CourtReporter</value>

        [DataMember(Name="reporter")]
        public List<JJudicialOfficialType> Reporter { get; set; }

        /// <summary>
        /// A person who is responsible for officially filing and stamping court documents. NIEM reference is j:CourtFilingClerk
        /// </summary>
        /// <value>A person who is responsible for officially filing and stamping court documents. NIEM reference is j:CourtFilingClerk</value>

        [DataMember(Name="filingClerk")]
        public List<JJudicialOfficialType> FilingClerk { get; set; }

        /// <summary>
        /// An area of case processing and the law governing specific types of matters before the court and governed by distinct court rule and processes. NIEM reference is j:CourtDivisionText
        /// </summary>
        /// <value>An area of case processing and the law governing specific types of matters before the court and governed by distinct court rule and processes. NIEM reference is j:CourtDivisionText</value>

        [DataMember(Name="division")]
        public List<NcTextType> Division { get; set; }

        /// <summary>
        /// A supervising agency that performs court services for a court unit. NIEM reference is j:CourtSupervisingAgency
        /// </summary>
        /// <value>A supervising agency that performs court services for a court unit. NIEM reference is j:CourtSupervisingAgency</value>

        [DataMember(Name="supervisingAgency")]
        public List<NcOrganizationType> SupervisingAgency { get; set; }

        /// <summary>
        /// A unit within a court system responsible for record maintenance. NIEM reference is j:CourtAdministrativeUnitText
        /// </summary>
        /// <value>A unit within a court system responsible for record maintenance. NIEM reference is j:CourtAdministrativeUnitText</value>

        [DataMember(Name="administrativeUnit")]
        public List<NcTextType> AdministrativeUnit { get; set; }

        /// <summary>
        /// A kind of court. NIEM reference is j:CourtCategoryCode
        /// </summary>
        /// <value>A kind of court. NIEM reference is j:CourtCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<AamvaD20CourtCategoryCodeType> CategoryCode { get; set; }

        /// <summary>
        /// jCourtType JSON-LD context
        /// </summary>
        /// <value>jCourtType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjCourtTypeContextJsonldEnum for ../JSON-LD_Contexts/jCourtTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jCourtTypeContext.jsonld")]
            JSONLDContextsjCourtTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jCourtType JSON-LD context
        /// </summary>
        /// <value>jCourtType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JCourtType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Clerk: ").Append(Clerk).Append("\n");
            sb.Append("  Reporter: ").Append(Reporter).Append("\n");
            sb.Append("  FilingClerk: ").Append(FilingClerk).Append("\n");
            sb.Append("  Division: ").Append(Division).Append("\n");
            sb.Append("  SupervisingAgency: ").Append(SupervisingAgency).Append("\n");
            sb.Append("  AdministrativeUnit: ").Append(AdministrativeUnit).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
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
            return obj.GetType() == GetType() && Equals((JCourtType)obj);
        }

        /// <summary>
        /// Returns true if JCourtType instances are equal
        /// </summary>
        /// <param name="other">Instance of JCourtType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JCourtType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.SequenceEqual(other.Name)
                ) && 
                (
                    Clerk == other.Clerk ||
                    Clerk != null &&
                    Clerk.SequenceEqual(other.Clerk)
                ) && 
                (
                    Reporter == other.Reporter ||
                    Reporter != null &&
                    Reporter.SequenceEqual(other.Reporter)
                ) && 
                (
                    FilingClerk == other.FilingClerk ||
                    FilingClerk != null &&
                    FilingClerk.SequenceEqual(other.FilingClerk)
                ) && 
                (
                    Division == other.Division ||
                    Division != null &&
                    Division.SequenceEqual(other.Division)
                ) && 
                (
                    SupervisingAgency == other.SupervisingAgency ||
                    SupervisingAgency != null &&
                    SupervisingAgency.SequenceEqual(other.SupervisingAgency)
                ) && 
                (
                    AdministrativeUnit == other.AdministrativeUnit ||
                    AdministrativeUnit != null &&
                    AdministrativeUnit.SequenceEqual(other.AdministrativeUnit)
                ) && 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
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
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Clerk != null)
                    hashCode = hashCode * 59 + Clerk.GetHashCode();
                    if (Reporter != null)
                    hashCode = hashCode * 59 + Reporter.GetHashCode();
                    if (FilingClerk != null)
                    hashCode = hashCode * 59 + FilingClerk.GetHashCode();
                    if (Division != null)
                    hashCode = hashCode * 59 + Division.GetHashCode();
                    if (SupervisingAgency != null)
                    hashCode = hashCode * 59 + SupervisingAgency.GetHashCode();
                    if (AdministrativeUnit != null)
                    hashCode = hashCode * 59 + AdministrativeUnit.GetHashCode();
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JCourtType left, JCourtType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JCourtType left, JCourtType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
