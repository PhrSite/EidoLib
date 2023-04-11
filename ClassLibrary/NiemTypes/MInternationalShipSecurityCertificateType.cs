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
    /// A data type for an International Ship Security Certificate (ISSC).
    /// </summary>
    [DataContract]
    public partial class MInternationalShipSecurityCertificateType : MCertificateType, IEquatable<MInternationalShipSecurityCertificateType>
    { 
        /// <summary>
        /// A reason why an interim International Ship Security Certificate (ISSC) was issued. NIEM reference is m:ReasonInterimISSCIssuedText
        /// </summary>
        /// <value>A reason why an interim International Ship Security Certificate (ISSC) was issued. NIEM reference is m:ReasonInterimISSCIssuedText</value>

        [DataMember(Name="reasonInterimIsscIssued")]
        public List<NcTextType> ReasonInterimIsscIssued { get; set; }

        /// <summary>
        /// A Recognized Security Organization/Flag Administration for an International Ship Security Certificate (ISSC). NIEM reference is m:RecognizedISSCSecurityEntity
        /// </summary>
        /// <value>A Recognized Security Organization/Flag Administration for an International Ship Security Certificate (ISSC). NIEM reference is m:RecognizedISSCSecurityEntity</value>

        [DataMember(Name="recognizedIsscSecurityEntity")]
        public List<NcEntityType> RecognizedIsscSecurityEntity { get; set; }

        /// <summary>
        /// A kind of International Ship Security Certificate (ISSC). NIEM reference is m:ISSCCategoryText
        /// </summary>
        /// <value>A kind of International Ship Security Certificate (ISSC). NIEM reference is m:ISSCCategoryText</value>

        [DataMember(Name="isscCategory")]
        public List<NcTextType> IsscCategory { get; set; }

        /// <summary>
        /// A set of contact information for the appointed Company Security Officer (CSO) of a vessel. NIEM reference is m:VesselSecurityOfficerContactInformation
        /// </summary>
        /// <value>A set of contact information for the appointed Company Security Officer (CSO) of a vessel. NIEM reference is m:VesselSecurityOfficerContactInformation</value>

        [DataMember(Name="vesselSecurityOfficerContactInformation")]
        public List<NcContactInformationType> VesselSecurityOfficerContactInformation { get; set; }

        /// <summary>
        /// True if a vessel has implemented a Vessel Security Plan (VSP); false otherwise. NIEM reference is m:VesselSecurityPlanImplementedIndicator
        /// </summary>
        /// <value>True if a vessel has implemented a Vessel Security Plan (VSP); false otherwise. NIEM reference is m:VesselSecurityPlanImplementedIndicator</value>

        [DataMember(Name="isVesselSecurityPlanImplemented")]
        public List<NiemXsboolean> IsVesselSecurityPlanImplemented { get; set; }

        /// <summary>
        /// mInternationalShipSecurityCertificateType JSON-LD context
        /// </summary>
        /// <value>mInternationalShipSecurityCertificateType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsmInternationalShipSecurityCertificateTypeContextJsonldEnum for ../JSON-LD_Contexts/mInternationalShipSecurityCertificateTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/mInternationalShipSecurityCertificateTypeContext.jsonld")]
            JSONLDContextsmInternationalShipSecurityCertificateTypeContextJsonldEnum = 0        }

        /// <summary>
        /// mInternationalShipSecurityCertificateType JSON-LD context
        /// </summary>
        /// <value>mInternationalShipSecurityCertificateType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MInternationalShipSecurityCertificateType {\n");
            sb.Append("  ReasonInterimIsscIssued: ").Append(ReasonInterimIsscIssued).Append("\n");
            sb.Append("  RecognizedIsscSecurityEntity: ").Append(RecognizedIsscSecurityEntity).Append("\n");
            sb.Append("  IsscCategory: ").Append(IsscCategory).Append("\n");
            sb.Append("  VesselSecurityOfficerContactInformation: ").Append(VesselSecurityOfficerContactInformation).Append("\n");
            sb.Append("  IsVesselSecurityPlanImplemented: ").Append(IsVesselSecurityPlanImplemented).Append("\n");
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
            return obj.GetType() == GetType() && Equals((MInternationalShipSecurityCertificateType)obj);
        }

        /// <summary>
        /// Returns true if MInternationalShipSecurityCertificateType instances are equal
        /// </summary>
        /// <param name="other">Instance of MInternationalShipSecurityCertificateType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MInternationalShipSecurityCertificateType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ReasonInterimIsscIssued == other.ReasonInterimIsscIssued ||
                    ReasonInterimIsscIssued != null &&
                    ReasonInterimIsscIssued.SequenceEqual(other.ReasonInterimIsscIssued)
                ) && 
                (
                    RecognizedIsscSecurityEntity == other.RecognizedIsscSecurityEntity ||
                    RecognizedIsscSecurityEntity != null &&
                    RecognizedIsscSecurityEntity.SequenceEqual(other.RecognizedIsscSecurityEntity)
                ) && 
                (
                    IsscCategory == other.IsscCategory ||
                    IsscCategory != null &&
                    IsscCategory.SequenceEqual(other.IsscCategory)
                ) && 
                (
                    VesselSecurityOfficerContactInformation == other.VesselSecurityOfficerContactInformation ||
                    VesselSecurityOfficerContactInformation != null &&
                    VesselSecurityOfficerContactInformation.SequenceEqual(other.VesselSecurityOfficerContactInformation)
                ) && 
                (
                    IsVesselSecurityPlanImplemented == other.IsVesselSecurityPlanImplemented ||
                    IsVesselSecurityPlanImplemented != null &&
                    IsVesselSecurityPlanImplemented.SequenceEqual(other.IsVesselSecurityPlanImplemented)
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
                    if (ReasonInterimIsscIssued != null)
                    hashCode = hashCode * 59 + ReasonInterimIsscIssued.GetHashCode();
                    if (RecognizedIsscSecurityEntity != null)
                    hashCode = hashCode * 59 + RecognizedIsscSecurityEntity.GetHashCode();
                    if (IsscCategory != null)
                    hashCode = hashCode * 59 + IsscCategory.GetHashCode();
                    if (VesselSecurityOfficerContactInformation != null)
                    hashCode = hashCode * 59 + VesselSecurityOfficerContactInformation.GetHashCode();
                    if (IsVesselSecurityPlanImplemented != null)
                    hashCode = hashCode * 59 + IsVesselSecurityPlanImplemented.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(MInternationalShipSecurityCertificateType left, MInternationalShipSecurityCertificateType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(MInternationalShipSecurityCertificateType left, MInternationalShipSecurityCertificateType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
