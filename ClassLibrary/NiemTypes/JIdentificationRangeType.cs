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
    /// A data type for a range of identifications.
    /// </summary>
    [DataContract]
    public partial class JIdentificationRangeType : IEquatable<JIdentificationRangeType>
    { 
        /// <summary>
        /// A highest value identification number in a consecutive number range. NIEM reference is j:MaximumRangeIdentification
        /// </summary>
        /// <value>A highest value identification number in a consecutive number range. NIEM reference is j:MaximumRangeIdentification</value>

        [DataMember(Name="maximumRangeIdentification")]
        public List<NcIdentificationType> MaximumRangeIdentification { get; set; }

        /// <summary>
        /// A lowest value identification number in a consecutive number range. NIEM reference is j:MinimumRangeIdentification
        /// </summary>
        /// <value>A lowest value identification number in a consecutive number range. NIEM reference is j:MinimumRangeIdentification</value>

        [DataMember(Name="minimumRangeIdentification")]
        public List<NcIdentificationType> MinimumRangeIdentification { get; set; }

        /// <summary>
        /// jIdentificationRangeType JSON-LD context
        /// </summary>
        /// <value>jIdentificationRangeType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjIdentificationRangeTypeContextJsonldEnum for ../JSON-LD_Contexts/jIdentificationRangeTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jIdentificationRangeTypeContext.jsonld")]
            JSONLDContextsjIdentificationRangeTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jIdentificationRangeType JSON-LD context
        /// </summary>
        /// <value>jIdentificationRangeType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JIdentificationRangeType {\n");
            sb.Append("  MaximumRangeIdentification: ").Append(MaximumRangeIdentification).Append("\n");
            sb.Append("  MinimumRangeIdentification: ").Append(MinimumRangeIdentification).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JIdentificationRangeType)obj);
        }

        /// <summary>
        /// Returns true if JIdentificationRangeType instances are equal
        /// </summary>
        /// <param name="other">Instance of JIdentificationRangeType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JIdentificationRangeType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MaximumRangeIdentification == other.MaximumRangeIdentification ||
                    MaximumRangeIdentification != null &&
                    MaximumRangeIdentification.SequenceEqual(other.MaximumRangeIdentification)
                ) && 
                (
                    MinimumRangeIdentification == other.MinimumRangeIdentification ||
                    MinimumRangeIdentification != null &&
                    MinimumRangeIdentification.SequenceEqual(other.MinimumRangeIdentification)
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
                    if (MaximumRangeIdentification != null)
                    hashCode = hashCode * 59 + MaximumRangeIdentification.GetHashCode();
                    if (MinimumRangeIdentification != null)
                    hashCode = hashCode * 59 + MinimumRangeIdentification.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JIdentificationRangeType left, JIdentificationRangeType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JIdentificationRangeType left, JIdentificationRangeType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
