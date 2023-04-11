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
        /// A data type for a code that identifies lifestyle characteristics for the victim person based on investigator experience.
        /// </summary>
        /// <value>A data type for a code that identifies lifestyle characteristics for the victim person based on investigator experience.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexVictimMOGeneralLifestyleCodeSimpleType
        {
            /// <summary>
            /// Enum AlcoholicEnum for Alcoholic
            /// </summary>
            [EnumMember(Value = "Alcoholic")]
            AlcoholicEnum = 0,
            /// <summary>
            /// Enum BisexualEnum for Bisexual
            /// </summary>
            [EnumMember(Value = "Bisexual")]
            BisexualEnum = 1,
            /// <summary>
            /// Enum ChildEnum for Child
            /// </summary>
            [EnumMember(Value = "Child")]
            ChildEnum = 2,
            /// <summary>
            /// Enum CriminalActivityEngagedEnum for Criminal Activity Engaged
            /// </summary>
            [EnumMember(Value = "Criminal Activity Engaged")]
            CriminalActivityEngagedEnum = 3,
            /// <summary>
            /// Enum DrugSellerEnum for Drug Seller
            /// </summary>
            [EnumMember(Value = "Drug Seller")]
            DrugSellerEnum = 4,
            /// <summary>
            /// Enum DrugUserEnum for Drug User
            /// </summary>
            [EnumMember(Value = "Drug User")]
            DrugUserEnum = 5,
            /// <summary>
            /// Enum ElderlyEnum for Elderly
            /// </summary>
            [EnumMember(Value = "Elderly")]
            ElderlyEnum = 6,
            /// <summary>
            /// Enum GangMemberEnum for Gang Member
            /// </summary>
            [EnumMember(Value = "Gang Member")]
            GangMemberEnum = 7,
            /// <summary>
            /// Enum HeterosexualEnum for Heterosexual
            /// </summary>
            [EnumMember(Value = "Heterosexual")]
            HeterosexualEnum = 8,
            /// <summary>
            /// Enum HitchhikerEnum for Hitchhiker
            /// </summary>
            [EnumMember(Value = "Hitchhiker")]
            HitchhikerEnum = 9,
            /// <summary>
            /// Enum HomosexualEnum for Homosexual
            /// </summary>
            [EnumMember(Value = "Homosexual")]
            HomosexualEnum = 10,
            /// <summary>
            /// Enum InfantEnum for Infant
            /// </summary>
            [EnumMember(Value = "Infant")]
            InfantEnum = 11,
            /// <summary>
            /// Enum LivedAloneEnum for Lived Alone
            /// </summary>
            [EnumMember(Value = "Lived Alone")]
            LivedAloneEnum = 12,
            /// <summary>
            /// Enum MentallyIllEnum for Mentally Ill
            /// </summary>
            [EnumMember(Value = "Mentally Ill")]
            MentallyIllEnum = 13,
            /// <summary>
            /// Enum PhysicallyDisabledEnum for Physically Disabled
            /// </summary>
            [EnumMember(Value = "Physically Disabled")]
            PhysicallyDisabledEnum = 14,
            /// <summary>
            /// Enum ProstituteEnum for Prostitute
            /// </summary>
            [EnumMember(Value = "Prostitute")]
            ProstituteEnum = 15,
            /// <summary>
            /// Enum RecluseEnum for Recluse
            /// </summary>
            [EnumMember(Value = "Recluse")]
            RecluseEnum = 16,
            /// <summary>
            /// Enum RunawayEnum for Runaway
            /// </summary>
            [EnumMember(Value = "Runaway")]
            RunawayEnum = 17,
            /// <summary>
            /// Enum StreetPersonHomelessEnum for Street Person_Homeless
            /// </summary>
            [EnumMember(Value = "Street Person_Homeless")]
            StreetPersonHomelessEnum = 18,
            /// <summary>
            /// Enum StudentEnum for Student
            /// </summary>
            [EnumMember(Value = "Student")]
            StudentEnum = 19,
            /// <summary>
            /// Enum TransientEnum for Transient
            /// </summary>
            [EnumMember(Value = "Transient")]
            TransientEnum = 20,
            /// <summary>
            /// Enum TransvestiteEnum for Transvestite
            /// </summary>
            [EnumMember(Value = "Transvestite")]
            TransvestiteEnum = 21,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 22,
            /// <summary>
            /// Enum WorkedAloneEnum for Worked Alone
            /// </summary>
            [EnumMember(Value = "Worked Alone")]
            WorkedAloneEnum = 23        }
}