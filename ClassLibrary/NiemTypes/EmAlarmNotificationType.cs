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
    /// A data type for an alarm
    /// </summary>
    [DataContract]
    public partial class EmAlarmNotificationType : IEquatable<EmAlarmNotificationType>
    { 
        /// <summary>
        /// True if an audible alarm is sounding; false if the alarm is inaudible NIEM reference is em:AlarmAudibleIndicator
        /// </summary>
        /// <value>True if an audible alarm is sounding; false if the alarm is inaudible NIEM reference is em:AlarmAudibleIndicator</value>

        [DataMember(Name="isAlarmAudible")]
        public List<NiemXsboolean> IsAlarmAudible { get; set; }

        /// <summary>
        /// A code indicating whether the alarm is audible or silent NIEM reference is em:AlarmAudibleDescriptionCode
        /// </summary>
        /// <value>A code indicating whether the alarm is audible or silent NIEM reference is em:AlarmAudibleDescriptionCode</value>

        [DataMember(Name="alarmAudibleDescriptionCode")]
        public List<EmAlarmAudibleDescriptionCodeType> AlarmAudibleDescriptionCode { get; set; }

        /// <summary>
        /// A phone number of the monitoring station NIEM reference is em:AlarmCallBackTelephoneNumber
        /// </summary>
        /// <value>A phone number of the monitoring station NIEM reference is em:AlarmCallBackTelephoneNumber</value>

        [DataMember(Name="alarmCallBackTelephoneNumber")]
        public List<NcTelephoneNumberType> AlarmCallBackTelephoneNumber { get; set; }

        /// <summary>
        /// A text describing an alarm event NIEM reference is em:AlarmDetailsText
        /// </summary>
        /// <value>A text describing an alarm event NIEM reference is em:AlarmDetailsText</value>

        [DataMember(Name="alarmDetails")]
        public List<NcTextType> AlarmDetails { get; set; }

        /// <summary>
        /// A response or activity needed when a dispatch agency is activated in response to an alarm NIEM reference is em:AlarmDispatchActivity
        /// </summary>
        /// <value>A response or activity needed when a dispatch agency is activated in response to an alarm NIEM reference is em:AlarmDispatchActivity</value>

        [DataMember(Name="alarmDispatchActivity")]
        public List<NcActivityType> AlarmDispatchActivity { get; set; }

        /// <summary>
        /// An identifier for the agency (PSAP) being requested to respond to an alarm  (typically a police or fire department or central dispatch point) or responder NIEM reference is em:AlarmDispatchAgencyID
        /// </summary>
        /// <value>An identifier for the agency (PSAP) being requested to respond to an alarm  (typically a police or fire department or central dispatch point) or responder NIEM reference is em:AlarmDispatchAgencyID</value>

        [DataMember(Name="alarmDispatchAgencyId")]
        public List<NcIdentificationType> AlarmDispatchAgencyId { get; set; }

        /// <summary>
        /// A name of the agency (PSAP) being requested to respond to an alarm  (typically a police or fire department or central dispatch point) or responder NIEM reference is em:AlarmDispatchAgencyNameText
        /// </summary>
        /// <value>A name of the agency (PSAP) being requested to respond to an alarm  (typically a police or fire department or central dispatch point) or responder NIEM reference is em:AlarmDispatchAgencyNameText</value>

        [DataMember(Name="alarmDispatchAgencyName")]
        public List<NcTextType> AlarmDispatchAgencyName { get; set; }

        /// <summary>
        /// An identifier assigned to Central Station Monitoring Companies NIEM reference is em:AlarmMonitoringServiceProviderID
        /// </summary>
        /// <value>An identifier assigned to Central Station Monitoring Companies NIEM reference is em:AlarmMonitoringServiceProviderID</value>

        [DataMember(Name="alarmMonitoringServiceProviderId")]
        public List<NcIdentificationType> AlarmMonitoringServiceProviderId { get; set; }

        /// <summary>
        /// A name of the dispatch requesting agency (typically an alarm central station) NIEM reference is em:AlarmMonitoringServiceProviderNameText
        /// </summary>
        /// <value>A name of the dispatch requesting agency (typically an alarm central station) NIEM reference is em:AlarmMonitoringServiceProviderNameText</value>

        [DataMember(Name="alarmMonitoringServiceProviderName")]
        public List<NcTextType> AlarmMonitoringServiceProviderName { get; set; }

        /// <summary>
        /// A date and time the monitoring station received the event based on the time zone of the site NIEM reference is em:AlarmMonitoringServiceProviderReceiveDateTime
        /// </summary>
        /// <value>A date and time the monitoring station received the event based on the time zone of the site NIEM reference is em:AlarmMonitoringServiceProviderReceiveDateTime</value>

        [DataMember(Name="alarmMonitoringServiceProviderReceiveDateTime")]
        public List<NiemXsdateTime> AlarmMonitoringServiceProviderReceiveDateTime { get; set; }

        /// <summary>
        /// A description of an action requested of an alarm event responder NIEM reference is em:AlarmRequestedResponseActionDescriptionText
        /// </summary>
        /// <value>A description of an action requested of an alarm event responder NIEM reference is em:AlarmRequestedResponseActionDescriptionText</value>

        [DataMember(Name="alarmRequestedResponseActionDescription")]
        public List<NcTextType> AlarmRequestedResponseActionDescription { get; set; }

        /// <summary>
        /// A container for information related to the confirmation of an alarm NIEM reference is em:AlarmConfirmation
        /// </summary>
        /// <value>A container for information related to the confirmation of an alarm NIEM reference is em:AlarmConfirmation</value>

        [DataMember(Name="alarmConfirmation")]
        public List<EmAlarmConfirmationType> AlarmConfirmation { get; set; }

        /// <summary>
        /// A permit for the alarm site NIEM reference is em:AlarmPermit
        /// </summary>
        /// <value>A permit for the alarm site NIEM reference is em:AlarmPermit</value>

        [DataMember(Name="alarmPermit")]
        public List<EmAlarmPermitType> AlarmPermit { get; set; }

        /// <summary>
        /// An alarm event NIEM reference is em:AlarmEvent
        /// </summary>
        /// <value>An alarm event NIEM reference is em:AlarmEvent</value>

        [DataMember(Name="alarmEvent")]
        public List<EmAlarmEventType> AlarmEvent { get; set; }

        /// <summary>
        /// A location for an alarm NIEM reference is em:AlarmLocation
        /// </summary>
        /// <value>A location for an alarm NIEM reference is em:AlarmLocation</value>

        [DataMember(Name="alarmLocation")]
        public List<NcLocationType> AlarmLocation { get; set; }

        /// <summary>
        /// emAlarmNotificationType JSON-LD context
        /// </summary>
        /// <value>emAlarmNotificationType JSON-LD context</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum ContextEnum
        {
            /// <summary>
            /// Enum JSONLDContextsemAlarmNotificationTypeContextJsonldEnum for ../JSON-LD_Contexts/emAlarmNotificationTypeContext.jsonld
            /// </summary>
            [EnumMember(Value = "../JSON-LD_Contexts/emAlarmNotificationTypeContext.jsonld")]
            JSONLDContextsemAlarmNotificationTypeContextJsonldEnum = 0        }

        /// <summary>
        /// emAlarmNotificationType JSON-LD context
        /// </summary>
        /// <value>emAlarmNotificationType JSON-LD context</value>

        [DataMember(Name="@context")]
        public ContextEnum? Context { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmAlarmNotificationType {\n");
            sb.Append("  IsAlarmAudible: ").Append(IsAlarmAudible).Append("\n");
            sb.Append("  AlarmAudibleDescriptionCode: ").Append(AlarmAudibleDescriptionCode).Append("\n");
            sb.Append("  AlarmCallBackTelephoneNumber: ").Append(AlarmCallBackTelephoneNumber).Append("\n");
            sb.Append("  AlarmDetails: ").Append(AlarmDetails).Append("\n");
            sb.Append("  AlarmDispatchActivity: ").Append(AlarmDispatchActivity).Append("\n");
            sb.Append("  AlarmDispatchAgencyId: ").Append(AlarmDispatchAgencyId).Append("\n");
            sb.Append("  AlarmDispatchAgencyName: ").Append(AlarmDispatchAgencyName).Append("\n");
            sb.Append("  AlarmMonitoringServiceProviderId: ").Append(AlarmMonitoringServiceProviderId).Append("\n");
            sb.Append("  AlarmMonitoringServiceProviderName: ").Append(AlarmMonitoringServiceProviderName).Append("\n");
            sb.Append("  AlarmMonitoringServiceProviderReceiveDateTime: ").Append(AlarmMonitoringServiceProviderReceiveDateTime).Append("\n");
            sb.Append("  AlarmRequestedResponseActionDescription: ").Append(AlarmRequestedResponseActionDescription).Append("\n");
            sb.Append("  AlarmConfirmation: ").Append(AlarmConfirmation).Append("\n");
            sb.Append("  AlarmPermit: ").Append(AlarmPermit).Append("\n");
            sb.Append("  AlarmEvent: ").Append(AlarmEvent).Append("\n");
            sb.Append("  AlarmLocation: ").Append(AlarmLocation).Append("\n");
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
            return obj.GetType() == GetType() && Equals((EmAlarmNotificationType)obj);
        }

        /// <summary>
        /// Returns true if EmAlarmNotificationType instances are equal
        /// </summary>
        /// <param name="other">Instance of EmAlarmNotificationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmAlarmNotificationType other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    IsAlarmAudible == other.IsAlarmAudible ||
                    IsAlarmAudible != null &&
                    IsAlarmAudible.SequenceEqual(other.IsAlarmAudible)
                ) && 
                (
                    AlarmAudibleDescriptionCode == other.AlarmAudibleDescriptionCode ||
                    AlarmAudibleDescriptionCode != null &&
                    AlarmAudibleDescriptionCode.SequenceEqual(other.AlarmAudibleDescriptionCode)
                ) && 
                (
                    AlarmCallBackTelephoneNumber == other.AlarmCallBackTelephoneNumber ||
                    AlarmCallBackTelephoneNumber != null &&
                    AlarmCallBackTelephoneNumber.SequenceEqual(other.AlarmCallBackTelephoneNumber)
                ) && 
                (
                    AlarmDetails == other.AlarmDetails ||
                    AlarmDetails != null &&
                    AlarmDetails.SequenceEqual(other.AlarmDetails)
                ) && 
                (
                    AlarmDispatchActivity == other.AlarmDispatchActivity ||
                    AlarmDispatchActivity != null &&
                    AlarmDispatchActivity.SequenceEqual(other.AlarmDispatchActivity)
                ) && 
                (
                    AlarmDispatchAgencyId == other.AlarmDispatchAgencyId ||
                    AlarmDispatchAgencyId != null &&
                    AlarmDispatchAgencyId.SequenceEqual(other.AlarmDispatchAgencyId)
                ) && 
                (
                    AlarmDispatchAgencyName == other.AlarmDispatchAgencyName ||
                    AlarmDispatchAgencyName != null &&
                    AlarmDispatchAgencyName.SequenceEqual(other.AlarmDispatchAgencyName)
                ) && 
                (
                    AlarmMonitoringServiceProviderId == other.AlarmMonitoringServiceProviderId ||
                    AlarmMonitoringServiceProviderId != null &&
                    AlarmMonitoringServiceProviderId.SequenceEqual(other.AlarmMonitoringServiceProviderId)
                ) && 
                (
                    AlarmMonitoringServiceProviderName == other.AlarmMonitoringServiceProviderName ||
                    AlarmMonitoringServiceProviderName != null &&
                    AlarmMonitoringServiceProviderName.SequenceEqual(other.AlarmMonitoringServiceProviderName)
                ) && 
                (
                    AlarmMonitoringServiceProviderReceiveDateTime == other.AlarmMonitoringServiceProviderReceiveDateTime ||
                    AlarmMonitoringServiceProviderReceiveDateTime != null &&
                    AlarmMonitoringServiceProviderReceiveDateTime.SequenceEqual(other.AlarmMonitoringServiceProviderReceiveDateTime)
                ) && 
                (
                    AlarmRequestedResponseActionDescription == other.AlarmRequestedResponseActionDescription ||
                    AlarmRequestedResponseActionDescription != null &&
                    AlarmRequestedResponseActionDescription.SequenceEqual(other.AlarmRequestedResponseActionDescription)
                ) && 
                (
                    AlarmConfirmation == other.AlarmConfirmation ||
                    AlarmConfirmation != null &&
                    AlarmConfirmation.SequenceEqual(other.AlarmConfirmation)
                ) && 
                (
                    AlarmPermit == other.AlarmPermit ||
                    AlarmPermit != null &&
                    AlarmPermit.SequenceEqual(other.AlarmPermit)
                ) && 
                (
                    AlarmEvent == other.AlarmEvent ||
                    AlarmEvent != null &&
                    AlarmEvent.SequenceEqual(other.AlarmEvent)
                ) && 
                (
                    AlarmLocation == other.AlarmLocation ||
                    AlarmLocation != null &&
                    AlarmLocation.SequenceEqual(other.AlarmLocation)
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
                    if (IsAlarmAudible != null)
                    hashCode = hashCode * 59 + IsAlarmAudible.GetHashCode();
                    if (AlarmAudibleDescriptionCode != null)
                    hashCode = hashCode * 59 + AlarmAudibleDescriptionCode.GetHashCode();
                    if (AlarmCallBackTelephoneNumber != null)
                    hashCode = hashCode * 59 + AlarmCallBackTelephoneNumber.GetHashCode();
                    if (AlarmDetails != null)
                    hashCode = hashCode * 59 + AlarmDetails.GetHashCode();
                    if (AlarmDispatchActivity != null)
                    hashCode = hashCode * 59 + AlarmDispatchActivity.GetHashCode();
                    if (AlarmDispatchAgencyId != null)
                    hashCode = hashCode * 59 + AlarmDispatchAgencyId.GetHashCode();
                    if (AlarmDispatchAgencyName != null)
                    hashCode = hashCode * 59 + AlarmDispatchAgencyName.GetHashCode();
                    if (AlarmMonitoringServiceProviderId != null)
                    hashCode = hashCode * 59 + AlarmMonitoringServiceProviderId.GetHashCode();
                    if (AlarmMonitoringServiceProviderName != null)
                    hashCode = hashCode * 59 + AlarmMonitoringServiceProviderName.GetHashCode();
                    if (AlarmMonitoringServiceProviderReceiveDateTime != null)
                    hashCode = hashCode * 59 + AlarmMonitoringServiceProviderReceiveDateTime.GetHashCode();
                    if (AlarmRequestedResponseActionDescription != null)
                    hashCode = hashCode * 59 + AlarmRequestedResponseActionDescription.GetHashCode();
                    if (AlarmConfirmation != null)
                    hashCode = hashCode * 59 + AlarmConfirmation.GetHashCode();
                    if (AlarmPermit != null)
                    hashCode = hashCode * 59 + AlarmPermit.GetHashCode();
                    if (AlarmEvent != null)
                    hashCode = hashCode * 59 + AlarmEvent.GetHashCode();
                    if (AlarmLocation != null)
                    hashCode = hashCode * 59 + AlarmLocation.GetHashCode();
                    if (Context != null)
                    hashCode = hashCode * 59 + Context.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(EmAlarmNotificationType left, EmAlarmNotificationType right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(EmAlarmNotificationType left, EmAlarmNotificationType right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
