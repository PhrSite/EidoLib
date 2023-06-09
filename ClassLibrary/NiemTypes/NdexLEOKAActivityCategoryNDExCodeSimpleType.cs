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
        /// A data type for a code that identifies the type of law enforcement activity which the officer was involved in at the time of incident.  Includes all NIBRS codes, plus additional codes.
        /// </summary>
        /// <value>A data type for a code that identifies the type of law enforcement activity which the officer was involved in at the time of incident.  Includes all NIBRS codes, plus additional codes.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexLEOKAActivityCategoryNDExCodeSimpleType
        {
            /// <summary>
            /// Enum AmbushNoWarningEnum for Ambush_No warning
            /// </summary>
            [EnumMember(Value = "Ambush_No warning")]
            AmbushNoWarningEnum = 0,
            /// <summary>
            /// Enum AttemptingOtherArrestEnum for Attempting other arrest
            /// </summary>
            [EnumMember(Value = "Attempting other arrest")]
            AttemptingOtherArrestEnum = 1,
            /// <summary>
            /// Enum BurglaryInProgressOrPursuingEnum for Burglary in progress or pursuing
            /// </summary>
            [EnumMember(Value = "Burglary in progress or pursuing")]
            BurglaryInProgressOrPursuingEnum = 2,
            /// <summary>
            /// Enum CivilDisorderEnum for Civil disorder
            /// </summary>
            [EnumMember(Value = "Civil disorder")]
            CivilDisorderEnum = 3,
            /// <summary>
            /// Enum DomesticDisturbanceEnum for Domestic Disturbance
            /// </summary>
            [EnumMember(Value = "Domestic Disturbance")]
            DomesticDisturbanceEnum = 4,
            /// <summary>
            /// Enum HandlingTransportingPrisonerEnum for Handling_Transporting prisoner
            /// </summary>
            [EnumMember(Value = "Handling_Transporting prisoner")]
            HandlingTransportingPrisonerEnum = 5,
            /// <summary>
            /// Enum InvestigationSuspiciousPersonEnum for Investigation_Suspicious person
            /// </summary>
            [EnumMember(Value = "Investigation_Suspicious person")]
            InvestigationSuspiciousPersonEnum = 6,
            /// <summary>
            /// Enum MentallyDerangedAssailantEnum for Mentally deranged assailant
            /// </summary>
            [EnumMember(Value = "Mentally deranged assailant")]
            MentallyDerangedAssailantEnum = 7,
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 8,
            /// <summary>
            /// Enum RespondingToDisturbanceCallEnum for Responding to disturbance call
            /// </summary>
            [EnumMember(Value = "Responding to disturbance call")]
            RespondingToDisturbanceCallEnum = 9,
            /// <summary>
            /// Enum RobberyInProgressOrPursuingEnum for Robbery in progress or pursuing
            /// </summary>
            [EnumMember(Value = "Robbery in progress or pursuing")]
            RobberyInProgressOrPursuingEnum = 10,
            /// <summary>
            /// Enum TrafficPursuitEnum for Traffic Pursuit
            /// </summary>
            [EnumMember(Value = "Traffic Pursuit")]
            TrafficPursuitEnum = 11,
            /// <summary>
            /// Enum TrafficPursuitStopEnum for Traffic Pursuit_Stop
            /// </summary>
            [EnumMember(Value = "Traffic Pursuit_Stop")]
            TrafficPursuitStopEnum = 12,
            /// <summary>
            /// Enum TrafficStopEnum for Traffic Stop
            /// </summary>
            [EnumMember(Value = "Traffic Stop")]
            TrafficStopEnum = 13        }
}
