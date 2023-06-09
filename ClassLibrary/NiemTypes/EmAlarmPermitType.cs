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
    /// A data type for a permit for the alarm event site
    /// </summary>
    [DataContract]
    public partial class EmAlarmPermitType : IEquatable<EmAlarmPermitType>
    { 
        /// <summary>
        /// A kind of permit. NIEM reference is nc:PermitCategoryText
        /// </summary>
        /// <value>A kind of permit. NIEM reference is nc:PermitCategoryText</value>

        [DataMember(Name="permitCategory")]
        public List<NcTextType> PermitCategory { get; set; }

        /// <summary>
        /// A permit identification. NIEM reference is nc:PermitIdentification
        /// </summary>
        /// <value>A permit identification. NIEM reference is nc:PermitIdentification</value>

        [DataMember(Name="permitIdentification")]
        public List<NcIdentificationType> PermitIdentification { get; set; }

        /// <summary>
        /// emAlarmPermitType JSON-LD context
        /// </summary>
        /// <value>emAlarmPermitType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsemAlarmPermitTypeContextJsonldEnum for ../JSON-LD_Contexts/emAlarmPermitTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/emAlarmPermitTypeContext.jsonld")]
            JSONLDContextsemAlarmPermitTypeContextJsonldEnum = 0        }

        /// <summary>
        /// emAlarmPermitType JSON-LD context
        /// </summary>
        /// <value>emAlarmPermitType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmAlarmPermitType {\n");
            sb.Append("  PermitCategory: ").Append(PermitCategory).Append("\n");
            sb.Append("  PermitIdentification: ").Append(PermitIdentification).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EmAlarmPermitType)obj);
        }

        /// <summary>
        /// Returns true if EmAlarmPermitType instances are equal
        /// </summary>
        /// <param name="other">Instance of EmAlarmPermitType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmAlarmPermitType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PermitCategory == other.PermitCategory ||
                    PermitCategory != null &&
                    PermitCategory.SequenceEqual(other.PermitCategory)
                ) && 
                (
                    PermitIdentification == other.PermitIdentification ||
                    PermitIdentification != null &&
                    PermitIdentification.SequenceEqual(other.PermitIdentification)
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
                    if (PermitCategory != null)
                    hashCode = hashCode * 59 + PermitCategory.GetHashCode();
                    if (PermitIdentification != null)
                    hashCode = hashCode * 59 + PermitIdentification.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EmAlarmPermitType left, EmAlarmPermitType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmAlarmPermitType left, EmAlarmPermitType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
