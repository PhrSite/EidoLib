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
    /// A data type for a process of receiving persons into an institution.
    /// </summary>
    [DataContract]
    public partial class JIntakeType : NcActivityType, IEquatable<JIntakeType>
    { 
        /// <summary>
        /// A process of reviewing persons admitted into an institution. NIEM reference is j:IntakeScreening
        /// </summary>
        /// <value>A process of reviewing persons admitted into an institution. NIEM reference is j:IntakeScreening</value>

        [DataMember(Name="screening")]
        public List<NcActivityType> Screening { get; set; }

        /// <summary>
        /// A staff member responsible for screening new intakes subjects. NIEM reference is j:IntakeScreeningStaffMember
        /// </summary>
        /// <value>A staff member responsible for screening new intakes subjects. NIEM reference is j:IntakeScreeningStaffMember</value>

        [DataMember(Name="screeningStaffMember")]
        public List<JStaffMemberType> ScreeningStaffMember { get; set; }

        /// <summary>
        /// jIntakeType JSON-LD context
        /// </summary>
        /// <value>jIntakeType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjIntakeTypeContextJsonldEnum for ../JSON-LD_Contexts/jIntakeTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jIntakeTypeContext.jsonld")]
            JSONLDContextsjIntakeTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jIntakeType JSON-LD context
        /// </summary>
        /// <value>jIntakeType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JIntakeType {\n");
            sb.Append("  Screening: ").Append(Screening).Append("\n");
            sb.Append("  ScreeningStaffMember: ").Append(ScreeningStaffMember).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JIntakeType)obj);
        }

        /// <summary>
        /// Returns true if JIntakeType instances are equal
        /// </summary>
        /// <param name="other">Instance of JIntakeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JIntakeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Screening == other.Screening ||
                    Screening != null &&
                    Screening.SequenceEqual(other.Screening)
                ) && 
                (
                    ScreeningStaffMember == other.ScreeningStaffMember ||
                    ScreeningStaffMember != null &&
                    ScreeningStaffMember.SequenceEqual(other.ScreeningStaffMember)
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
                    if (Screening != null)
                    hashCode = hashCode * 59 + Screening.GetHashCode();
                    if (ScreeningStaffMember != null)
                    hashCode = hashCode * 59 + ScreeningStaffMember.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JIntakeType left, JIntakeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JIntakeType left, JIntakeType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
