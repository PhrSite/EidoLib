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
    /// A data type for an act of officially overseeing, supervising, or keeping track in some capacity of a person.
    /// </summary>
    [DataContract]
    public partial class NcSupervisionType : NcActivityType, IEquatable<NcSupervisionType>
    { 
        /// <summary>
        /// True if a subject is currently under supervision; false otherwise. NIEM reference is nc:SupervisionCurrentIndicator
        /// </summary>
        /// <value>True if a subject is currently under supervision; false otherwise. NIEM reference is nc:SupervisionCurrentIndicator</value>

        [DataMember(Name="isCurrent")]
        public List<NiemXsboolean> IsCurrent { get; set; }

        /// <summary>
        /// A status of the custody of a person under supervision. NIEM reference is nc:SupervisionCustodyStatus
        /// </summary>
        /// <value>A status of the custody of a person under supervision. NIEM reference is nc:SupervisionCustodyStatus</value>

        [DataMember(Name="custodyStatus")]
        public List<NcStatusType> CustodyStatus { get; set; }

        /// <summary>
        /// A facility at which a subject is being supervised. NIEM reference is nc:SupervisionFacility
        /// </summary>
        /// <value>A facility at which a subject is being supervised. NIEM reference is nc:SupervisionFacility</value>

        [DataMember(Name="facility")]
        public List<NcFacilityType> Facility { get; set; }

        /// <summary>
        /// True if a supervision of a person is required; false if a supervision is optional. NIEM reference is nc:SupervisionMandatoryIndicator
        /// </summary>
        /// <value>True if a supervision of a person is required; false if a supervision is optional. NIEM reference is nc:SupervisionMandatoryIndicator</value>

        [DataMember(Name="isMandatory")]
        public List<NiemXsboolean> IsMandatory { get; set; }

        /// <summary>
        /// A complete and unrestricted release of a subject from a supervision. NIEM reference is nc:SupervisionRelease
        /// </summary>
        /// <value>A complete and unrestricted release of a subject from a supervision. NIEM reference is nc:SupervisionRelease</value>

        [DataMember(Name="release")]
        public List<NcReleaseType> Release { get; set; }

        /// <summary>
        /// A person who is being supervised. NIEM reference is nc:SupervisionPerson
        /// </summary>
        /// <value>A person who is being supervised. NIEM reference is nc:SupervisionPerson</value>

        [DataMember(Name="person")]
        public List<NcPersonType> Person { get; set; }

        /// <summary>
        /// A status of a person under supervision. NIEM reference is nc:SupervisionPersonStatus
        /// </summary>
        /// <value>A status of a person under supervision. NIEM reference is nc:SupervisionPersonStatus</value>

        [DataMember(Name="personStatus")]
        public List<NcStatusType> PersonStatus { get; set; }

        /// <summary>
        /// An entity that supervises a person. NIEM reference is nc:SupervisionSupervisor
        /// </summary>
        /// <value>An entity that supervises a person. NIEM reference is nc:SupervisionSupervisor</value>

        [DataMember(Name="supervisor")]
        public List<NcEntityType> Supervisor { get; set; }

        /// <summary>
        /// Additional information about a supervision. NIEM reference is j:SupervisionAugmentation
        /// </summary>
        /// <value>Additional information about a supervision. NIEM reference is j:SupervisionAugmentation</value>

        [DataMember(Name="augmentation")]
        public List<JSupervisionAugmentationType> Augmentation { get; set; }

        /// <summary>
        /// ncSupervisionType JSON-LD context
        /// </summary>
        /// <value>ncSupervisionType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsncSupervisionTypeContextJsonldEnum for ../JSON-LD_Contexts/ncSupervisionTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/ncSupervisionTypeContext.jsonld")]
            JSONLDContextsncSupervisionTypeContextJsonldEnum = 0        }

        /// <summary>
        /// ncSupervisionType JSON-LD context
        /// </summary>
        /// <value>ncSupervisionType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NcSupervisionType {\n");
            sb.Append("  IsCurrent: ").Append(IsCurrent).Append("\n");
            sb.Append("  CustodyStatus: ").Append(CustodyStatus).Append("\n");
            sb.Append("  Facility: ").Append(Facility).Append("\n");
            sb.Append("  IsMandatory: ").Append(IsMandatory).Append("\n");
            sb.Append("  Release: ").Append(Release).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  PersonStatus: ").Append(PersonStatus).Append("\n");
            sb.Append("  Supervisor: ").Append(Supervisor).Append("\n");
            sb.Append("  Augmentation: ").Append(Augmentation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((NcSupervisionType)obj);
        }

        /// <summary>
        /// Returns true if NcSupervisionType instances are equal
        /// </summary>
        /// <param name="other">Instance of NcSupervisionType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NcSupervisionType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsCurrent == other.IsCurrent ||
                    IsCurrent != null &&
                    IsCurrent.SequenceEqual(other.IsCurrent)
                ) && 
                (
                    CustodyStatus == other.CustodyStatus ||
                    CustodyStatus != null &&
                    CustodyStatus.SequenceEqual(other.CustodyStatus)
                ) && 
                (
                    Facility == other.Facility ||
                    Facility != null &&
                    Facility.SequenceEqual(other.Facility)
                ) && 
                (
                    IsMandatory == other.IsMandatory ||
                    IsMandatory != null &&
                    IsMandatory.SequenceEqual(other.IsMandatory)
                ) && 
                (
                    Release == other.Release ||
                    Release != null &&
                    Release.SequenceEqual(other.Release)
                ) && 
                (
                    Person == other.Person ||
                    Person != null &&
                    Person.SequenceEqual(other.Person)
                ) && 
                (
                    PersonStatus == other.PersonStatus ||
                    PersonStatus != null &&
                    PersonStatus.SequenceEqual(other.PersonStatus)
                ) && 
                (
                    Supervisor == other.Supervisor ||
                    Supervisor != null &&
                    Supervisor.SequenceEqual(other.Supervisor)
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
                    if (IsCurrent != null)
                    hashCode = hashCode * 59 + IsCurrent.GetHashCode();
                    if (CustodyStatus != null)
                    hashCode = hashCode * 59 + CustodyStatus.GetHashCode();
                    if (Facility != null)
                    hashCode = hashCode * 59 + Facility.GetHashCode();
                    if (IsMandatory != null)
                    hashCode = hashCode * 59 + IsMandatory.GetHashCode();
                    if (Release != null)
                    hashCode = hashCode * 59 + Release.GetHashCode();
                    if (Person != null)
                    hashCode = hashCode * 59 + Person.GetHashCode();
                    if (PersonStatus != null)
                    hashCode = hashCode * 59 + PersonStatus.GetHashCode();
                    if (Supervisor != null)
                    hashCode = hashCode * 59 + Supervisor.GetHashCode();
                    if (Augmentation != null)
                    hashCode = hashCode * 59 + Augmentation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(NcSupervisionType left, NcSupervisionType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(NcSupervisionType left, NcSupervisionType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
