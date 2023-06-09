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
    /// A data type for additional information about a program.
    /// </summary>
    [DataContract]
    public partial class ImProgramAugmentationType : IEquatable<ImProgramAugmentationType>
    { 
        /// <summary>
        /// A comment on the completion of the program. NIEM reference is im:ProgramCompletionCommentText
        /// </summary>
        /// <value>A comment on the completion of the program. NIEM reference is im:ProgramCompletionCommentText</value>

        [DataMember(Name="programCompletionComment")]
        public List<NcTextType> ProgramCompletionComment { get; set; }

        /// <summary>
        /// A date on which the Exchange Visitor is expected to complete the requirements of his/her program. NIEM reference is im:ProgramEffectiveCompletionDate
        /// </summary>
        /// <value>A date on which the Exchange Visitor is expected to complete the requirements of his/her program. NIEM reference is im:ProgramEffectiveCompletionDate</value>

        [DataMember(Name="programEffectiveCompletionDate")]
        public List<NcDateType> ProgramEffectiveCompletionDate { get; set; }

        /// <summary>
        /// True if the person has begun participation in his/her program; false otherwise. NIEM reference is im:ProgramParticipationBegunIndicator
        /// </summary>
        /// <value>True if the person has begun participation in his/her program; false otherwise. NIEM reference is im:ProgramParticipationBegunIndicator</value>

        [DataMember(Name="isProgramParticipationBegun")]
        public List<NiemXsboolean> IsProgramParticipationBegun { get; set; }

        /// <summary>
        /// A date on which program participation will terminate. NIEM reference is im:ProgramTerminationDate
        /// </summary>
        /// <value>A date on which program participation will terminate. NIEM reference is im:ProgramTerminationDate</value>

        [DataMember(Name="programTerminationDate")]
        public List<NcDateType> ProgramTerminationDate { get; set; }

        /// <summary>
        /// A field indicating free text about the program termination. NIEM reference is im:ProgramTerminationText
        /// </summary>
        /// <value>A field indicating free text about the program termination. NIEM reference is im:ProgramTerminationText</value>

        [DataMember(Name="programTermination")]
        public List<NcTextType> ProgramTermination { get; set; }

        /// <summary>
        /// imProgramAugmentationType JSON-LD context
        /// </summary>
        /// <value>imProgramAugmentationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsimProgramAugmentationTypeContextJsonldEnum for ../JSON-LD_Contexts/imProgramAugmentationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/imProgramAugmentationTypeContext.jsonld")]
            JSONLDContextsimProgramAugmentationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// imProgramAugmentationType JSON-LD context
        /// </summary>
        /// <value>imProgramAugmentationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImProgramAugmentationType {\n");
            sb.Append("  ProgramCompletionComment: ").Append(ProgramCompletionComment).Append("\n");
            sb.Append("  ProgramEffectiveCompletionDate: ").Append(ProgramEffectiveCompletionDate).Append("\n");
            sb.Append("  IsProgramParticipationBegun: ").Append(IsProgramParticipationBegun).Append("\n");
            sb.Append("  ProgramTerminationDate: ").Append(ProgramTerminationDate).Append("\n");
            sb.Append("  ProgramTermination: ").Append(ProgramTermination).Append("\n");
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
            return obj.GetType() == GetType() && Equals((ImProgramAugmentationType)obj);
        }

        /// <summary>
        /// Returns true if ImProgramAugmentationType instances are equal
        /// </summary>
        /// <param name="other">Instance of ImProgramAugmentationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImProgramAugmentationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ProgramCompletionComment == other.ProgramCompletionComment ||
                    ProgramCompletionComment != null &&
                    ProgramCompletionComment.SequenceEqual(other.ProgramCompletionComment)
                ) && 
                (
                    ProgramEffectiveCompletionDate == other.ProgramEffectiveCompletionDate ||
                    ProgramEffectiveCompletionDate != null &&
                    ProgramEffectiveCompletionDate.SequenceEqual(other.ProgramEffectiveCompletionDate)
                ) && 
                (
                    IsProgramParticipationBegun == other.IsProgramParticipationBegun ||
                    IsProgramParticipationBegun != null &&
                    IsProgramParticipationBegun.SequenceEqual(other.IsProgramParticipationBegun)
                ) && 
                (
                    ProgramTerminationDate == other.ProgramTerminationDate ||
                    ProgramTerminationDate != null &&
                    ProgramTerminationDate.SequenceEqual(other.ProgramTerminationDate)
                ) && 
                (
                    ProgramTermination == other.ProgramTermination ||
                    ProgramTermination != null &&
                    ProgramTermination.SequenceEqual(other.ProgramTermination)
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
                    if (ProgramCompletionComment != null)
                    hashCode = hashCode * 59 + ProgramCompletionComment.GetHashCode();
                    if (ProgramEffectiveCompletionDate != null)
                    hashCode = hashCode * 59 + ProgramEffectiveCompletionDate.GetHashCode();
                    if (IsProgramParticipationBegun != null)
                    hashCode = hashCode * 59 + IsProgramParticipationBegun.GetHashCode();
                    if (ProgramTerminationDate != null)
                    hashCode = hashCode * 59 + ProgramTerminationDate.GetHashCode();
                    if (ProgramTermination != null)
                    hashCode = hashCode * 59 + ProgramTermination.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(ImProgramAugmentationType left, ImProgramAugmentationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ImProgramAugmentationType left, ImProgramAugmentationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
