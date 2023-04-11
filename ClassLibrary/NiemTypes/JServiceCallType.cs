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
    /// A data type for a call for service received from a person alerting an authority of a situation.
    /// </summary>
    [DataContract]
    public partial class JServiceCallType : NcActivityType, IEquatable<JServiceCallType>
    { 
        /// <summary>
        /// A kind of service call clearance. NIEM reference is j:ServiceCallClearanceCategoryCode
        /// </summary>
        /// <value>A kind of service call clearance. NIEM reference is j:ServiceCallClearanceCategoryCode</value>

        [DataMember(Name="clearanceCategoryCode")]
        public List<NdexCADCallCodeType> ClearanceCategoryCode { get; set; }

        /// <summary>
        /// A kind of service call clearance. NIEM reference is j:ServiceCallClearanceCategoryText
        /// </summary>
        /// <value>A kind of service call clearance. NIEM reference is j:ServiceCallClearanceCategoryText</value>

        [DataMember(Name="clearanceCategory")]
        public List<NcTextType> ClearanceCategory { get; set; }

        /// <summary>
        /// A date a response unit arrived at the scene designated by a call for service. NIEM reference is j:ServiceCallArrivedDate
        /// </summary>
        /// <value>A date a response unit arrived at the scene designated by a call for service. NIEM reference is j:ServiceCallArrivedDate</value>

        [DataMember(Name="arrivedDate")]
        public List<NcDateType> ArrivedDate { get; set; }

        /// <summary>
        /// A kind of service call as determined at the time of call receipt. NIEM reference is j:ServiceCallCategoryText
        /// </summary>
        /// <value>A kind of service call as determined at the time of call receipt. NIEM reference is j:ServiceCallCategoryText</value>

        [DataMember(Name="category")]
        public List<NcTextType> Category { get; set; }

        /// <summary>
        /// A response unit responsible for handling a call for service. NIEM reference is j:ServiceCallAssignedUnit
        /// </summary>
        /// <value>A response unit responsible for handling a call for service. NIEM reference is j:ServiceCallAssignedUnit</value>

        [DataMember(Name="assignedUnit")]
        public List<NcOrganizationType> AssignedUnit { get; set; }

        /// <summary>
        /// A unit that assists the assigned response unit in handling a call for service. NIEM reference is j:ServiceCallAssistingUnit
        /// </summary>
        /// <value>A unit that assists the assigned response unit in handling a call for service. NIEM reference is j:ServiceCallAssistingUnit</value>

        [DataMember(Name="assistingUnit")]
        public List<NcOrganizationType> AssistingUnit { get; set; }

        /// <summary>
        /// A description that identifies the incident conditions or status when a response unit cleared or left the scene designated by a call for service. NIEM reference is j:ServiceCallClearanceText
        /// </summary>
        /// <value>A description that identifies the incident conditions or status when a response unit cleared or left the scene designated by a call for service. NIEM reference is j:ServiceCallClearanceText</value>

        [DataMember(Name="clearance")]
        public List<NcTextType> Clearance { get; set; }

        /// <summary>
        /// A date when a response unit cleared or left the scene designated by a call for service. NIEM reference is j:ServiceCallClearedDate
        /// </summary>
        /// <value>A date when a response unit cleared or left the scene designated by a call for service. NIEM reference is j:ServiceCallClearedDate</value>

        [DataMember(Name="clearedDate")]
        public List<NcDateType> ClearedDate { get; set; }

        /// <summary>
        /// A date a service call was received by a dispatcher. NIEM reference is j:ServiceCallDispatchedDate
        /// </summary>
        /// <value>A date a service call was received by a dispatcher. NIEM reference is j:ServiceCallDispatchedDate</value>

        [DataMember(Name="dispatchedDate")]
        public List<NcDateType> DispatchedDate { get; set; }

        /// <summary>
        /// An official assigned specifically to handle a call for service. NIEM reference is j:ServiceCallDispatchedOfficial
        /// </summary>
        /// <value>An official assigned specifically to handle a call for service. NIEM reference is j:ServiceCallDispatchedOfficial</value>

        [DataMember(Name="dispatchedOfficial")]
        public List<JEnforcementOfficialType> DispatchedOfficial { get; set; }

        /// <summary>
        /// A person who determines the course of action to be taken in response to a call for service and sends out appropriate response units as necessary. NIEM reference is j:ServiceCallDispatcher
        /// </summary>
        /// <value>A person who determines the course of action to be taken in response to a call for service and sends out appropriate response units as necessary. NIEM reference is j:ServiceCallDispatcher</value>

        [DataMember(Name="dispatcher")]
        public List<NcPersonType> Dispatcher { get; set; }

        /// <summary>
        /// A way in which a call for service is received. NIEM reference is j:ServiceCallMechanismText
        /// </summary>
        /// <value>A way in which a call for service is received. NIEM reference is j:ServiceCallMechanismText</value>

        [DataMember(Name="mechanism")]
        public List<NcTextType> Mechanism { get; set; }

        /// <summary>
        /// A person who receives a call for service. NIEM reference is j:ServiceCallOperator
        /// </summary>
        /// <value>A person who receives a call for service. NIEM reference is j:ServiceCallOperator</value>

        [DataMember(Name="operator")]
        public List<NcPersonType> _Operator { get; set; }

        /// <summary>
        /// A person who places a call for service. NIEM reference is j:ServiceCallOriginator
        /// </summary>
        /// <value>A person who places a call for service. NIEM reference is j:ServiceCallOriginator</value>

        [DataMember(Name="originator")]
        public List<NcPersonType> Originator { get; set; }

        /// <summary>
        /// A location from which a call for service was placed. NIEM reference is j:ServiceCallPlacedLocation
        /// </summary>
        /// <value>A location from which a call for service was placed. NIEM reference is j:ServiceCallPlacedLocation</value>

        [DataMember(Name="placedLocation")]
        public List<NcLocationType> PlacedLocation { get; set; }

        /// <summary>
        /// A location where a response unit should be sent to handle a call for service. NIEM reference is j:ServiceCallResponseLocation
        /// </summary>
        /// <value>A location where a response unit should be sent to handle a call for service. NIEM reference is j:ServiceCallResponseLocation</value>

        [DataMember(Name="responseLocation")]
        public List<NcLocationType> ResponseLocation { get; set; }

        /// <summary>
        /// A person who needs the assistance of a response unit from a call for service. NIEM reference is j:ServiceCallResponsePerson
        /// </summary>
        /// <value>A person who needs the assistance of a response unit from a call for service. NIEM reference is j:ServiceCallResponsePerson</value>

        [DataMember(Name="responsePerson")]
        public List<NcPersonType> ResponsePerson { get; set; }

        /// <summary>
        /// A kind of service call as determined at the time of call receipt. NIEM reference is j:ServiceCallCategoryCode
        /// </summary>
        /// <value>A kind of service call as determined at the time of call receipt. NIEM reference is j:ServiceCallCategoryCode</value>

        [DataMember(Name="categoryCode")]
        public List<NdexCADCallCodeType> CategoryCode { get; set; }

        /// <summary>
        /// A kind of source of the call. NIEM reference is j:ServiceCallMechanismCode
        /// </summary>
        /// <value>A kind of source of the call. NIEM reference is j:ServiceCallMechanismCode</value>

        [DataMember(Name="mechanismCode")]
        public List<NdexCADCallSourceCodeType> MechanismCode { get; set; }

        /// <summary>
        /// Additional information about a service call NIEM reference is em:ServiceCallAugmentation
        /// </summary>
        /// <value>Additional information about a service call NIEM reference is em:ServiceCallAugmentation</value>

        [DataMember(Name="augmentation")]
        public List<EmServiceCallAugmentationType> Augmentation { get; set; }

        /// <summary>
        /// jServiceCallType JSON-LD context
        /// </summary>
        /// <value>jServiceCallType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsjServiceCallTypeContextJsonldEnum for ../JSON-LD_Contexts/jServiceCallTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/jServiceCallTypeContext.jsonld")]
            JSONLDContextsjServiceCallTypeContextJsonldEnum = 0        }

        /// <summary>
        /// jServiceCallType JSON-LD context
        /// </summary>
        /// <value>jServiceCallType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JServiceCallType {\n");
            sb.Append("  ClearanceCategoryCode: ").Append(ClearanceCategoryCode).Append("\n");
            sb.Append("  ClearanceCategory: ").Append(ClearanceCategory).Append("\n");
            sb.Append("  ArrivedDate: ").Append(ArrivedDate).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  AssignedUnit: ").Append(AssignedUnit).Append("\n");
            sb.Append("  AssistingUnit: ").Append(AssistingUnit).Append("\n");
            sb.Append("  Clearance: ").Append(Clearance).Append("\n");
            sb.Append("  ClearedDate: ").Append(ClearedDate).Append("\n");
            sb.Append("  DispatchedDate: ").Append(DispatchedDate).Append("\n");
            sb.Append("  DispatchedOfficial: ").Append(DispatchedOfficial).Append("\n");
            sb.Append("  Dispatcher: ").Append(Dispatcher).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  Originator: ").Append(Originator).Append("\n");
            sb.Append("  PlacedLocation: ").Append(PlacedLocation).Append("\n");
            sb.Append("  ResponseLocation: ").Append(ResponseLocation).Append("\n");
            sb.Append("  ResponsePerson: ").Append(ResponsePerson).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  MechanismCode: ").Append(MechanismCode).Append("\n");
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
            return obj.GetType() == GetType() && Equals((JServiceCallType)obj);
        }

        /// <summary>
        /// Returns true if JServiceCallType instances are equal
        /// </summary>
        /// <param name="other">Instance of JServiceCallType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JServiceCallType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    ClearanceCategoryCode == other.ClearanceCategoryCode ||
                    ClearanceCategoryCode != null &&
                    ClearanceCategoryCode.SequenceEqual(other.ClearanceCategoryCode)
                ) && 
                (
                    ClearanceCategory == other.ClearanceCategory ||
                    ClearanceCategory != null &&
                    ClearanceCategory.SequenceEqual(other.ClearanceCategory)
                ) && 
                (
                    ArrivedDate == other.ArrivedDate ||
                    ArrivedDate != null &&
                    ArrivedDate.SequenceEqual(other.ArrivedDate)
                ) && 
                (
                    Category == other.Category ||
                    Category != null &&
                    Category.SequenceEqual(other.Category)
                ) && 
                (
                    AssignedUnit == other.AssignedUnit ||
                    AssignedUnit != null &&
                    AssignedUnit.SequenceEqual(other.AssignedUnit)
                ) && 
                (
                    AssistingUnit == other.AssistingUnit ||
                    AssistingUnit != null &&
                    AssistingUnit.SequenceEqual(other.AssistingUnit)
                ) && 
                (
                    Clearance == other.Clearance ||
                    Clearance != null &&
                    Clearance.SequenceEqual(other.Clearance)
                ) && 
                (
                    ClearedDate == other.ClearedDate ||
                    ClearedDate != null &&
                    ClearedDate.SequenceEqual(other.ClearedDate)
                ) && 
                (
                    DispatchedDate == other.DispatchedDate ||
                    DispatchedDate != null &&
                    DispatchedDate.SequenceEqual(other.DispatchedDate)
                ) && 
                (
                    DispatchedOfficial == other.DispatchedOfficial ||
                    DispatchedOfficial != null &&
                    DispatchedOfficial.SequenceEqual(other.DispatchedOfficial)
                ) && 
                (
                    Dispatcher == other.Dispatcher ||
                    Dispatcher != null &&
                    Dispatcher.SequenceEqual(other.Dispatcher)
                ) && 
                (
                    Mechanism == other.Mechanism ||
                    Mechanism != null &&
                    Mechanism.SequenceEqual(other.Mechanism)
                ) && 
                (
                    _Operator == other._Operator ||
                    _Operator != null &&
                    _Operator.SequenceEqual(other._Operator)
                ) && 
                (
                    Originator == other.Originator ||
                    Originator != null &&
                    Originator.SequenceEqual(other.Originator)
                ) && 
                (
                    PlacedLocation == other.PlacedLocation ||
                    PlacedLocation != null &&
                    PlacedLocation.SequenceEqual(other.PlacedLocation)
                ) && 
                (
                    ResponseLocation == other.ResponseLocation ||
                    ResponseLocation != null &&
                    ResponseLocation.SequenceEqual(other.ResponseLocation)
                ) && 
                (
                    ResponsePerson == other.ResponsePerson ||
                    ResponsePerson != null &&
                    ResponsePerson.SequenceEqual(other.ResponsePerson)
                ) && 
                (
                    CategoryCode == other.CategoryCode ||
                    CategoryCode != null &&
                    CategoryCode.SequenceEqual(other.CategoryCode)
                ) && 
                (
                    MechanismCode == other.MechanismCode ||
                    MechanismCode != null &&
                    MechanismCode.SequenceEqual(other.MechanismCode)
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
                    if (ClearanceCategoryCode != null)
                    hashCode = hashCode * 59 + ClearanceCategoryCode.GetHashCode();
                    if (ClearanceCategory != null)
                    hashCode = hashCode * 59 + ClearanceCategory.GetHashCode();
                    if (ArrivedDate != null)
                    hashCode = hashCode * 59 + ArrivedDate.GetHashCode();
                    if (Category != null)
                    hashCode = hashCode * 59 + Category.GetHashCode();
                    if (AssignedUnit != null)
                    hashCode = hashCode * 59 + AssignedUnit.GetHashCode();
                    if (AssistingUnit != null)
                    hashCode = hashCode * 59 + AssistingUnit.GetHashCode();
                    if (Clearance != null)
                    hashCode = hashCode * 59 + Clearance.GetHashCode();
                    if (ClearedDate != null)
                    hashCode = hashCode * 59 + ClearedDate.GetHashCode();
                    if (DispatchedDate != null)
                    hashCode = hashCode * 59 + DispatchedDate.GetHashCode();
                    if (DispatchedOfficial != null)
                    hashCode = hashCode * 59 + DispatchedOfficial.GetHashCode();
                    if (Dispatcher != null)
                    hashCode = hashCode * 59 + Dispatcher.GetHashCode();
                    if (Mechanism != null)
                    hashCode = hashCode * 59 + Mechanism.GetHashCode();
                    if (_Operator != null)
                    hashCode = hashCode * 59 + _Operator.GetHashCode();
                    if (Originator != null)
                    hashCode = hashCode * 59 + Originator.GetHashCode();
                    if (PlacedLocation != null)
                    hashCode = hashCode * 59 + PlacedLocation.GetHashCode();
                    if (ResponseLocation != null)
                    hashCode = hashCode * 59 + ResponseLocation.GetHashCode();
                    if (ResponsePerson != null)
                    hashCode = hashCode * 59 + ResponsePerson.GetHashCode();
                    if (CategoryCode != null)
                    hashCode = hashCode * 59 + CategoryCode.GetHashCode();
                    if (MechanismCode != null)
                    hashCode = hashCode * 59 + MechanismCode.GetHashCode();
                    if (Augmentation != null)
                    hashCode = hashCode * 59 + Augmentation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(JServiceCallType left, JServiceCallType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(JServiceCallType left, JServiceCallType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
