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
    /// A data type for a set of angular offsets of a subject from a full face or a profile, for a determined 3D pose
    /// </summary>
    [DataContract]
    public partial class BiomPoseAngleType : IEquatable<BiomPoseAngleType>
    { 
        /// <summary>
        /// A rotation about the horizontal &#x27;x&#x27; axis NIEM reference is biom:PosePitchAngleMeasure
        /// </summary>
        /// <value>A rotation about the horizontal &#x27;x&#x27; axis NIEM reference is biom:PosePitchAngleMeasure</value>

        [DataMember(Name="posePitchAngleMeasure")]
        public List<NiemXsinteger> PosePitchAngleMeasure { get; set; }

        /// <summary>
        /// A pitch uncertainty NIEM reference is biom:PosePitchUncertaintyValue
        /// </summary>
        /// <value>A pitch uncertainty NIEM reference is biom:PosePitchUncertaintyValue</value>

        [DataMember(Name="posePitchUncertaintyValue")]
        public List<NiemXsnonNegativeInteger> PosePitchUncertaintyValue { get; set; }

        /// <summary>
        /// A rotation about the &#x27;z&#x27; axis NIEM reference is biom:PoseRollAngleMeasure
        /// </summary>
        /// <value>A rotation about the &#x27;z&#x27; axis NIEM reference is biom:PoseRollAngleMeasure</value>

        [DataMember(Name="poseRollAngleMeasure")]
        public List<NiemXsinteger> PoseRollAngleMeasure { get; set; }

        /// <summary>
        /// A roll uncertainty NIEM reference is biom:PoseRollUncertaintyValue
        /// </summary>
        /// <value>A roll uncertainty NIEM reference is biom:PoseRollUncertaintyValue</value>

        [DataMember(Name="poseRollUncertaintyValue")]
        public List<NiemXsnonNegativeInteger> PoseRollUncertaintyValue { get; set; }

        /// <summary>
        /// A rotation about the vertical &#x27;y&#x27; axis NIEM reference is biom:PoseYawAngleMeasure
        /// </summary>
        /// <value>A rotation about the vertical &#x27;y&#x27; axis NIEM reference is biom:PoseYawAngleMeasure</value>

        [DataMember(Name="poseYawAngleMeasure")]
        public List<NiemXsinteger> PoseYawAngleMeasure { get; set; }

        /// <summary>
        /// A yaw uncertainty NIEM reference is biom:PoseYawUncertaintyValue
        /// </summary>
        /// <value>A yaw uncertainty NIEM reference is biom:PoseYawUncertaintyValue</value>

        [DataMember(Name="poseYawUncertaintyValue")]
        public List<NiemXsnonNegativeInteger> PoseYawUncertaintyValue { get; set; }

        /// <summary>
        /// biomPoseAngleType JSON-LD context
        /// </summary>
        /// <value>biomPoseAngleType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomPoseAngleTypeContextJsonldEnum for ../JSON-LD_Contexts/biomPoseAngleTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomPoseAngleTypeContext.jsonld")]
            JSONLDContextsbiomPoseAngleTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomPoseAngleType JSON-LD context
        /// </summary>
        /// <value>biomPoseAngleType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomPoseAngleType {\n");
            sb.Append("  PosePitchAngleMeasure: ").Append(PosePitchAngleMeasure).Append("\n");
            sb.Append("  PosePitchUncertaintyValue: ").Append(PosePitchUncertaintyValue).Append("\n");
            sb.Append("  PoseRollAngleMeasure: ").Append(PoseRollAngleMeasure).Append("\n");
            sb.Append("  PoseRollUncertaintyValue: ").Append(PoseRollUncertaintyValue).Append("\n");
            sb.Append("  PoseYawAngleMeasure: ").Append(PoseYawAngleMeasure).Append("\n");
            sb.Append("  PoseYawUncertaintyValue: ").Append(PoseYawUncertaintyValue).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomPoseAngleType)obj);
        }

        /// <summary>
        /// Returns true if BiomPoseAngleType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomPoseAngleType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomPoseAngleType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    PosePitchAngleMeasure == other.PosePitchAngleMeasure ||
                    PosePitchAngleMeasure != null &&
                    PosePitchAngleMeasure.SequenceEqual(other.PosePitchAngleMeasure)
                ) && 
                (
                    PosePitchUncertaintyValue == other.PosePitchUncertaintyValue ||
                    PosePitchUncertaintyValue != null &&
                    PosePitchUncertaintyValue.SequenceEqual(other.PosePitchUncertaintyValue)
                ) && 
                (
                    PoseRollAngleMeasure == other.PoseRollAngleMeasure ||
                    PoseRollAngleMeasure != null &&
                    PoseRollAngleMeasure.SequenceEqual(other.PoseRollAngleMeasure)
                ) && 
                (
                    PoseRollUncertaintyValue == other.PoseRollUncertaintyValue ||
                    PoseRollUncertaintyValue != null &&
                    PoseRollUncertaintyValue.SequenceEqual(other.PoseRollUncertaintyValue)
                ) && 
                (
                    PoseYawAngleMeasure == other.PoseYawAngleMeasure ||
                    PoseYawAngleMeasure != null &&
                    PoseYawAngleMeasure.SequenceEqual(other.PoseYawAngleMeasure)
                ) && 
                (
                    PoseYawUncertaintyValue == other.PoseYawUncertaintyValue ||
                    PoseYawUncertaintyValue != null &&
                    PoseYawUncertaintyValue.SequenceEqual(other.PoseYawUncertaintyValue)
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
                    if (PosePitchAngleMeasure != null)
                    hashCode = hashCode * 59 + PosePitchAngleMeasure.GetHashCode();
                    if (PosePitchUncertaintyValue != null)
                    hashCode = hashCode * 59 + PosePitchUncertaintyValue.GetHashCode();
                    if (PoseRollAngleMeasure != null)
                    hashCode = hashCode * 59 + PoseRollAngleMeasure.GetHashCode();
                    if (PoseRollUncertaintyValue != null)
                    hashCode = hashCode * 59 + PoseRollUncertaintyValue.GetHashCode();
                    if (PoseYawAngleMeasure != null)
                    hashCode = hashCode * 59 + PoseYawAngleMeasure.GetHashCode();
                    if (PoseYawUncertaintyValue != null)
                    hashCode = hashCode * 59 + PoseYawUncertaintyValue.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomPoseAngleType left, BiomPoseAngleType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomPoseAngleType left, BiomPoseAngleType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
