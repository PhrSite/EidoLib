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
    /// A data type for a court occurrence.
    /// </summary>
    [DataContract]
    public partial class JCourtEventType : NcActivityType, IEquatable<JCourtEventType>
    { 
        /// <summary>
        /// A court-related action associated with a court case event. NIEM reference is j:CourtEventAction
        /// </summary>
        /// <value>A court-related action associated with a court case event. NIEM reference is j:CourtEventAction</value>

        [DataMember(Name="action")]
        public List<JCourtActivityType> Action { get; set; }

        /// <summary>
        /// An appearance in court required of a party NIEM reference is j:CourtEventAppearance
        /// </summary>
        /// <value>An appearance in court required of a party NIEM reference is j:CourtEventAppearance</value>

        [DataMember(Name="appearance")]
        public List<JCourtAppearanceType> Appearance { get; set; }

        /// <summary>
        /// A case associated with a court event. NIEM reference is j:CourtEventCase
        /// </summary>
        /// <value>A case associated with a court event. NIEM reference is j:CourtEventCase</value>

        [DataMember(Name="case")]
        public List<NcCaseType> _Case { get; set; }

        /// <summary>
        /// A court in which a court event occurs. NIEM reference is j:CourtEventCourt
        /// </summary>
        /// <value>A court in which a court event occurs. NIEM reference is j:CourtEventCourt</value>

        [DataMember(Name="court")]
        public List<JCourtType> Court { get; set; }

        /// <summary>
        /// A judge associated with a court event. NIEM reference is j:CourtEventJudge
        /// </summary>
        /// <value>A judge associated with a court event. NIEM reference is j:CourtEventJudge</value>

        [DataMember(Name="judge")]
        public List<JJudicialOfficialType> Judge { get; set; }

        /// <summary>
        /// A request made to a court for a ruling or an order. NIEM reference is j:CourtEventMotion
        /// </summary>
        /// <value>A request made to a court for a ruling or an order. NIEM reference is j:CourtEventMotion</value>

        [DataMember(Name="motion")]
        public List<JCourtActivityType> Motion { get; set; }

        /// <summary>
        /// A day for which a court event is scheduled. NIEM reference is j:CourtEventSchedule
        /// </summary>
        /// <value>A day for which a court event is scheduled. NIEM reference is j:CourtEventSchedule</value>

        [DataMember(Name="schedule")]
        public List<NcScheduleDayType> Schedule { get; set; }

        /// <summary>
        /// A unique identifier for a court case event record. NIEM reference is j:CourtEventSequenceID
        /// </summary>
        /// <value>A unique identifier for a court case event record. NIEM reference is j:CourtEventSequenceID</value>

        [DataMember(Name="sequenceId")]
        public List<NiemXsstring> SequenceId { get; set; }

        /// <summary>
        /// jCourtEventType JSON-LD context
        /// </summary>
        /// <value>jCourtEventType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjCourtEventTypeContextJsonldEnum for ../JSON-LD_Contexts/jCourtEventTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jCourtEventTypeContext.jsonld")]
            JSONLDContextsjCourtEventTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jCourtEventType JSON-LD context
        /// </summary>
        /// <value>jCourtEventType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JCourtEventType {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Appearance: ").Append(Appearance).Append("\n");
            sb.Append("  _Case: ").Append(_Case).Append("\n");
            sb.Append("  Court: ").Append(Court).Append("\n");
            sb.Append("  Judge: ").Append(Judge).Append("\n");
            sb.Append("  Motion: ").Append(Motion).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  SequenceId: ").Append(SequenceId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JCourtEventType)obj);
        }

        /// <summary>
        /// Returns true if JCourtEventType instances are equal
        /// </summary>
        /// <param name="other">Instance of JCourtEventType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JCourtEventType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Action == other.Action ||
                    Action != null &&
                    Action.SequenceEqual(other.Action)
                ) && 
                (
                    Appearance == other.Appearance ||
                    Appearance != null &&
                    Appearance.SequenceEqual(other.Appearance)
                ) && 
                (
                    _Case == other._Case ||
                    _Case != null &&
                    _Case.SequenceEqual(other._Case)
                ) && 
                (
                    Court == other.Court ||
                    Court != null &&
                    Court.SequenceEqual(other.Court)
                ) && 
                (
                    Judge == other.Judge ||
                    Judge != null &&
                    Judge.SequenceEqual(other.Judge)
                ) && 
                (
                    Motion == other.Motion ||
                    Motion != null &&
                    Motion.SequenceEqual(other.Motion)
                ) && 
                (
                    Schedule == other.Schedule ||
                    Schedule != null &&
                    Schedule.SequenceEqual(other.Schedule)
                ) && 
                (
                    SequenceId == other.SequenceId ||
                    SequenceId != null &&
                    SequenceId.SequenceEqual(other.SequenceId)
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
                    if (Action != null)
                    hashCode = hashCode * 59 + Action.GetHashCode();
                    if (Appearance != null)
                    hashCode = hashCode * 59 + Appearance.GetHashCode();
                    if (_Case != null)
                    hashCode = hashCode * 59 + _Case.GetHashCode();
                    if (Court != null)
                    hashCode = hashCode * 59 + Court.GetHashCode();
                    if (Judge != null)
                    hashCode = hashCode * 59 + Judge.GetHashCode();
                    if (Motion != null)
                    hashCode = hashCode * 59 + Motion.GetHashCode();
                    if (Schedule != null)
                    hashCode = hashCode * 59 + Schedule.GetHashCode();
                    if (SequenceId != null)
                    hashCode = hashCode * 59 + SequenceId.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JCourtEventType left, JCourtEventType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JCourtEventType left, JCourtEventType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
