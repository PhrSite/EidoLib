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
    /// A data type definition contains a set of information regarding the captured device information
    /// </summary>
    [DataContract]
    public partial class BiomDeviceType : IEquatable<BiomDeviceType>
    { 
        /// <summary>
        /// An identifier for a capture device NIEM reference is biom:DeviceID
        /// </summary>
        /// <value>An identifier for a capture device NIEM reference is biom:DeviceID</value>

        [DataMember(Name="deviceId")]
        public List<NcTextType> DeviceId { get; set; }

        /// <summary>
        /// A name of a biometric capture system or device NIEM reference is biom:DeviceName
        /// </summary>
        /// <value>A name of a biometric capture system or device NIEM reference is biom:DeviceName</value>

        [DataMember(Name="name")]
        public List<NcTextType> Name { get; set; }

        /// <summary>
        /// A kind of device type NIEM reference is biom:DeviceCategoryText
        /// </summary>
        /// <value>A kind of device type NIEM reference is biom:DeviceCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A kind of device manufacturer NIEM reference is biom:DeviceManufacturerText
        /// </summary>
        /// <value>A kind of device manufacturer NIEM reference is biom:DeviceManufacturerText</value>

        [DataMember(Name="manufacturer")]
        public List<NcTextType> Manufacturer { get; set; }

        /// <summary>
        /// A description of a biometric capture device NIEM reference is biom:DeviceDescriptionText
        /// </summary>
        /// <value>A description of a biometric capture device NIEM reference is biom:DeviceDescriptionText</value>

        [DataMember(Name="description")]
        public List<NcTextType> Description { get; set; }

        /// <summary>
        /// A make of an image capture device NIEM reference is biom:DeviceMakeText
        /// </summary>
        /// <value>A make of an image capture device NIEM reference is biom:DeviceMakeText</value>

        [DataMember(Name="make")]
        public List<NcTextType> Make { get; set; }

        /// <summary>
        /// A model of an image capture device NIEM reference is biom:DeviceModelText
        /// </summary>
        /// <value>A model of an image capture device NIEM reference is biom:DeviceModelText</value>

        [DataMember(Name="model")]
        public List<NcTextType> Model { get; set; }

        /// <summary>
        /// A serial number of the image capture device NIEM reference is biom:DeviceSerialNumberText
        /// </summary>
        /// <value>A serial number of the image capture device NIEM reference is biom:DeviceSerialNumberText</value>

        [DataMember(Name="serialNumber")]
        public List<NcTextType> SerialNumber { get; set; }

        /// <summary>
        /// A version of the data generated by a biometric capture device NIEM reference is biom:DeviceVersionText
        /// </summary>
        /// <value>A version of the data generated by a biometric capture device NIEM reference is biom:DeviceVersionText</value>

        [DataMember(Name="version")]
        public List<NcTextType> Version { get; set; }

        /// <summary>
        /// A text that describes the firmware version for the image capture equipment. NIEM reference is biom:DeviceFirmwareVersionText
        /// </summary>
        /// <value>A text that describes the firmware version for the image capture equipment. NIEM reference is biom:DeviceFirmwareVersionText</value>

        [DataMember(Name="firmwareVersion")]
        public List<NcTextType> FirmwareVersion { get; set; }

        /// <summary>
        /// biomDeviceType JSON-LD context
        /// </summary>
        /// <value>biomDeviceType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsbiomDeviceTypeContextJsonldEnum for ../JSON-LD_Contexts/biomDeviceTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/biomDeviceTypeContext.jsonld")]
            JSONLDContextsbiomDeviceTypeContextJsonldEnum = 0        }

        /// <summary>
        /// biomDeviceType JSON-LD context
        /// </summary>
        /// <value>biomDeviceType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BiomDeviceType {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Manufacturer: ").Append(Manufacturer).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Make: ").Append(Make).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  SerialNumber: ").Append(SerialNumber).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  FirmwareVersion: ").Append(FirmwareVersion).Append("\n");
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
            return obj.GetType() == GetType() && Equals((BiomDeviceType)obj);
        }

        /// <summary>
        /// Returns true if BiomDeviceType instances are equal
        /// </summary>
        /// <param name="other">Instance of BiomDeviceType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BiomDeviceType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DeviceId == other.DeviceId ||
                    DeviceId != null &&
                    DeviceId.SequenceEqual(other.DeviceId)
                ) && 
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.SequenceEqual(other.Name)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    Manufacturer == other.Manufacturer ||
                    Manufacturer != null &&
                    Manufacturer.SequenceEqual(other.Manufacturer)
                ) && 
                (
                    Description == other.Description ||
                    Description != null &&
                    Description.SequenceEqual(other.Description)
                ) && 
                (
                    Make == other.Make ||
                    Make != null &&
                    Make.SequenceEqual(other.Make)
                ) && 
                (
                    Model == other.Model ||
                    Model != null &&
                    Model.SequenceEqual(other.Model)
                ) && 
                (
                    SerialNumber == other.SerialNumber ||
                    SerialNumber != null &&
                    SerialNumber.SequenceEqual(other.SerialNumber)
                ) && 
                (
                    Version == other.Version ||
                    Version != null &&
                    Version.SequenceEqual(other.Version)
                ) && 
                (
                    FirmwareVersion == other.FirmwareVersion ||
                    FirmwareVersion != null &&
                    FirmwareVersion.SequenceEqual(other.FirmwareVersion)
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
                    if (DeviceId != null)
                    hashCode = hashCode * 59 + DeviceId.GetHashCode();
                    if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (Manufacturer != null)
                    hashCode = hashCode * 59 + Manufacturer.GetHashCode();
                    if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                    if (Make != null)
                    hashCode = hashCode * 59 + Make.GetHashCode();
                    if (Model != null)
                    hashCode = hashCode * 59 + Model.GetHashCode();
                    if (SerialNumber != null)
                    hashCode = hashCode * 59 + SerialNumber.GetHashCode();
                    if (Version != null)
                    hashCode = hashCode * 59 + Version.GetHashCode();
                    if (FirmwareVersion != null)
                    hashCode = hashCode * 59 + FirmwareVersion.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(BiomDeviceType left, BiomDeviceType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(BiomDeviceType left, BiomDeviceType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}