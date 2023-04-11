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
    /// A data type for a set of information regarding the captured voice information
    /// </summary>
    [DataContract]
    public partial class BiomAudioSourceRecorderType : IEquatable<BiomAudioSourceRecorderType>
    { 
        /// <summary>
        /// A description of a biometric capture device NIEM reference is biom:DeviceDescriptionText
        /// </summary>
        /// <value>A description of a biometric capture device NIEM reference is biom:DeviceDescriptionText</value>

        [DataMember(Name="deviceDescription")]
        public List<NcTextType> DeviceDescription { get; set; }

        /// <summary>
        /// A make of an image capture device NIEM reference is biom:DeviceMakeText
        /// </summary>
        /// <value>A make of an image capture device NIEM reference is biom:DeviceMakeText</value>

        [DataMember(Name="deviceMake")]
        public List<NcTextType> DeviceMake { get; set; }

        /// <summary>
        /// A model of an image capture device NIEM reference is biom:DeviceModelText
        /// </summary>
        /// <value>A model of an image capture device NIEM reference is biom:DeviceModelText</value>

        [DataMember(Name="deviceModel")]
        public List<NcTextType> DeviceModel { get; set; }

        /// <summary>
        /// A serial number of the image capture device NIEM reference is biom:DeviceSerialNumberText
        /// </summary>
        /// <value>A serial number of the image capture device NIEM reference is biom:DeviceSerialNumberText</value>

        [DataMember(Name="deviceSerialNumber")]
        public List<NcTextType> DeviceSerialNumber { get; set; }

        /// <summary>
        /// biomAudioSourceRecorderType JSON-LD context
        /// </summary>
        /// <value>biomAudioSourceRecorderType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomAudioSourceRecorderTypeContextJsonldEnum for ../JSON-LD_Contexts/biomAudioSourceRecorderTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomAudioSourceRecorderTypeContext.jsonld")]
            JSONLDContextsbiomAudioSourceRecorderTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomAudioSourceRecorderType JSON-LD context
        /// </summary>
        /// <value>biomAudioSourceRecorderType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomAudioSourceRecorderType {\n");
            sb.Append("  DeviceDescription: ").Append(DeviceDescription).Append("\n");
            sb.Append("  DeviceMake: ").Append(DeviceMake).Append("\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  DeviceSerialNumber: ").Append(DeviceSerialNumber).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomAudioSourceRecorderType)obj);
        }

        /// <summary>
        /// Returns true if BiomAudioSourceRecorderType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomAudioSourceRecorderType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomAudioSourceRecorderType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DeviceDescription == other.DeviceDescription ||
                    DeviceDescription != null &&
                    DeviceDescription.SequenceEqual(other.DeviceDescription)
                ) && 
                (
                    DeviceMake == other.DeviceMake ||
                    DeviceMake != null &&
                    DeviceMake.SequenceEqual(other.DeviceMake)
                ) && 
                (
                    DeviceModel == other.DeviceModel ||
                    DeviceModel != null &&
                    DeviceModel.SequenceEqual(other.DeviceModel)
                ) && 
                (
                    DeviceSerialNumber == other.DeviceSerialNumber ||
                    DeviceSerialNumber != null &&
                    DeviceSerialNumber.SequenceEqual(other.DeviceSerialNumber)
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
                    if (DeviceDescription != null)
                    hashCode = hashCode * 59 + DeviceDescription.GetHashCode();
                    if (DeviceMake != null)
                    hashCode = hashCode * 59 + DeviceMake.GetHashCode();
                    if (DeviceModel != null)
                    hashCode = hashCode * 59 + DeviceModel.GetHashCode();
                    if (DeviceSerialNumber != null)
                    hashCode = hashCode * 59 + DeviceSerialNumber.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomAudioSourceRecorderType left, BiomAudioSourceRecorderType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomAudioSourceRecorderType left, BiomAudioSourceRecorderType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
