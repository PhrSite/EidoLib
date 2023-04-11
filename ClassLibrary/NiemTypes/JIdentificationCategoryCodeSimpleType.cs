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
        /// A data type for a kind of identification.
        /// </summary>
        /// <value>A data type for a kind of identification.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum JIdentificationCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum AirForceSerialEnum for Air Force Serial
            /// </summary>
            [EnumMember(Value = "Air Force Serial")]
            AirForceSerialEnum = 0,
            /// <summary>
            /// Enum AirNationalGuardSerialEnum for Air National Guard Serial
            /// </summary>
            [EnumMember(Value = "Air National Guard Serial")]
            AirNationalGuardSerialEnum = 1,
            /// <summary>
            /// Enum AlienRegistrationEnum for Alien Registration
            /// </summary>
            [EnumMember(Value = "Alien Registration")]
            AlienRegistrationEnum = 2,
            /// <summary>
            /// Enum ArmySerialEnum for Army Serial
            /// </summary>
            [EnumMember(Value = "Army Serial")]
            ArmySerialEnum = 3,
            /// <summary>
            /// Enum BureauFugitiveIndexEnum for Bureau Fugitive Index
            /// </summary>
            [EnumMember(Value = "Bureau Fugitive Index")]
            BureauFugitiveIndexEnum = 4,
            /// <summary>
            /// Enum CanadianSocialInsuranceEnum for Canadian Social Insurance
            /// </summary>
            [EnumMember(Value = "Canadian Social Insurance")]
            CanadianSocialInsuranceEnum = 5,
            /// <summary>
            /// Enum CorrectionalIDEnum for Correctional ID
            /// </summary>
            [EnumMember(Value = "Correctional ID")]
            CorrectionalIDEnum = 6,
            /// <summary>
            /// Enum IdentificationOrderEnum for Identification Order
            /// </summary>
            [EnumMember(Value = "Identification Order")]
            IdentificationOrderEnum = 7,
            /// <summary>
            /// Enum MarineCorpsSerialEnum for Marine Corps Serial
            /// </summary>
            [EnumMember(Value = "Marine Corps Serial")]
            MarineCorpsSerialEnum = 8,
            /// <summary>
            /// Enum MarinersDocumentIDEnum for Mariner's Document ID
            /// </summary>
            [EnumMember(Value = "Mariner's Document ID")]
            MarinersDocumentIDEnum = 9,
            /// <summary>
            /// Enum NationalAgencyCaseEnum for National Agency Case
            /// </summary>
            [EnumMember(Value = "National Agency Case")]
            NationalAgencyCaseEnum = 10,
            /// <summary>
            /// Enum NationalGuardSerialEnum for National Guard Serial
            /// </summary>
            [EnumMember(Value = "National Guard Serial")]
            NationalGuardSerialEnum = 11,
            /// <summary>
            /// Enum NavySerialEnum for Navy Serial
            /// </summary>
            [EnumMember(Value = "Navy Serial")]
            NavySerialEnum = 12,
            /// <summary>
            /// Enum OffenderIDEnum for Offender ID
            /// </summary>
            [EnumMember(Value = "Offender ID")]
            OffenderIDEnum = 13,
            /// <summary>
            /// Enum OriginatingAgencyPoliceIDEnum for Originating Agency Police ID
            /// </summary>
            [EnumMember(Value = "Originating Agency Police ID")]
            OriginatingAgencyPoliceIDEnum = 14,
            /// <summary>
            /// Enum PassportEnum for Passport
            /// </summary>
            [EnumMember(Value = "Passport")]
            PassportEnum = 15,
            /// <summary>
            /// Enum PersonalIdentificationEnum for Personal Identification
            /// </summary>
            [EnumMember(Value = "Personal Identification")]
            PersonalIdentificationEnum = 16,
            /// <summary>
            /// Enum PortSecurityCardEnum for Port Security Card
            /// </summary>
            [EnumMember(Value = "Port Security Card")]
            PortSecurityCardEnum = 17,
            /// <summary>
            /// Enum RoyalCanadianMountedPoliceIDEnum for Royal Canadian Mounted Police ID
            /// </summary>
            [EnumMember(Value = "Royal Canadian Mounted Police ID")]
            RoyalCanadianMountedPoliceIDEnum = 18,
            /// <summary>
            /// Enum SelectiveServiceEnum for Selective Service
            /// </summary>
            [EnumMember(Value = "Selective Service")]
            SelectiveServiceEnum = 19,
            /// <summary>
            /// Enum StateIDCardEnum for State ID Card
            /// </summary>
            [EnumMember(Value = "State ID Card")]
            StateIDCardEnum = 20,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 21,
            /// <summary>
            /// Enum USCoastGuardSerialEnum for US Coast Guard Serial
            /// </summary>
            [EnumMember(Value = "US Coast Guard Serial")]
            USCoastGuardSerialEnum = 22,
            /// <summary>
            /// Enum VeteransAdministrationClaimEnum for Veterans Administration Claim
            /// </summary>
            [EnumMember(Value = "Veterans Administration Claim")]
            VeteransAdministrationClaimEnum = 23        }
}