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
        /// A data type for a code that identifies observations of the subject.
        /// </summary>
        /// <value>A data type for a code that identifies observations of the subject.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NdexSubjectMOObservationCodeSimpleType
        {
            /// <summary>
            /// Enum AlcoholOnBreathEnum for Alcohol on breath
            /// </summary>
            [EnumMember(Value = "Alcohol on breath")]
            AlcoholOnBreathEnum = 0,
            /// <summary>
            /// Enum AngryEnum for Angry
            /// </summary>
            [EnumMember(Value = "Angry")]
            AngryEnum = 1,
            /// <summary>
            /// Enum ApologeticEnum for Apologetic
            /// </summary>
            [EnumMember(Value = "Apologetic")]
            ApologeticEnum = 2,
            /// <summary>
            /// Enum BadBreathEnum for Bad breath
            /// </summary>
            [EnumMember(Value = "Bad breath")]
            BadBreathEnum = 3,
            /// <summary>
            /// Enum BodyOdorEnum for Body odor
            /// </summary>
            [EnumMember(Value = "Body odor")]
            BodyOdorEnum = 4,
            /// <summary>
            /// Enum BodyOdorUnusualOdorEnum for Body odor unusual odor
            /// </summary>
            [EnumMember(Value = "Body odor unusual odor")]
            BodyOdorUnusualOdorEnum = 5,
            /// <summary>
            /// Enum CoerceEnum for Coerce
            /// </summary>
            [EnumMember(Value = "Coerce")]
            CoerceEnum = 6,
            /// <summary>
            /// Enum ComplimentaryEnum for Complimentary
            /// </summary>
            [EnumMember(Value = "Complimentary")]
            ComplimentaryEnum = 7,
            /// <summary>
            /// Enum EgoSatisfyingEnum for Ego Satisfying
            /// </summary>
            [EnumMember(Value = "Ego Satisfying")]
            EgoSatisfyingEnum = 8,
            /// <summary>
            /// Enum GangRelatedEnum for Gang related
            /// </summary>
            [EnumMember(Value = "Gang related")]
            GangRelatedEnum = 9,
            /// <summary>
            /// Enum InquisitiveEnum for Inquisitive
            /// </summary>
            [EnumMember(Value = "Inquisitive")]
            InquisitiveEnum = 10,
            /// <summary>
            /// Enum IntimidateCoerceEnum for Intimidate coerce
            /// </summary>
            [EnumMember(Value = "Intimidate coerce")]
            IntimidateCoerceEnum = 11,
            /// <summary>
            /// Enum IntimidateCommandingEnum for Intimidate_Commanding
            /// </summary>
            [EnumMember(Value = "Intimidate_Commanding")]
            IntimidateCommandingEnum = 12,
            /// <summary>
            /// Enum KindEnum for Kind
            /// </summary>
            [EnumMember(Value = "Kind")]
            KindEnum = 13,
            /// <summary>
            /// Enum KnowledgeableEnum for Knowledgeable
            /// </summary>
            [EnumMember(Value = "Knowledgeable")]
            KnowledgeableEnum = 14,
            /// <summary>
            /// Enum NegotiatingEnum for Negotiating
            /// </summary>
            [EnumMember(Value = "Negotiating")]
            NegotiatingEnum = 15,
            /// <summary>
            /// Enum NeverSpokeEnum for Never spoke
            /// </summary>
            [EnumMember(Value = "Never spoke")]
            NeverSpokeEnum = 16,
            /// <summary>
            /// Enum NeverSpokeQuietEnum for Never spoke quiet
            /// </summary>
            [EnumMember(Value = "Never spoke quiet")]
            NeverSpokeQuietEnum = 17,
            /// <summary>
            /// Enum PersonalEnum for Personal
            /// </summary>
            [EnumMember(Value = "Personal")]
            PersonalEnum = 18,
            /// <summary>
            /// Enum PoliteKindEnum for Polite_Kind
            /// </summary>
            [EnumMember(Value = "Polite_Kind")]
            PoliteKindEnum = 19,
            /// <summary>
            /// Enum ProfaneEnum for Profane
            /// </summary>
            [EnumMember(Value = "Profane")]
            ProfaneEnum = 20,
            /// <summary>
            /// Enum QuietEnum for Quiet
            /// </summary>
            [EnumMember(Value = "Quiet")]
            QuietEnum = 21,
            /// <summary>
            /// Enum QuotesUnusualEnum for Quotes unusual
            /// </summary>
            [EnumMember(Value = "Quotes unusual")]
            QuotesUnusualEnum = 22,
            /// <summary>
            /// Enum RageEnum for Rage
            /// </summary>
            [EnumMember(Value = "Rage")]
            RageEnum = 23,
            /// <summary>
            /// Enum ReassuringEnum for Reassuring
            /// </summary>
            [EnumMember(Value = "Reassuring")]
            ReassuringEnum = 24,
            /// <summary>
            /// Enum SelfDemeaningEnum for Self Demeaning
            /// </summary>
            [EnumMember(Value = "Self Demeaning")]
            SelfDemeaningEnum = 25,
            /// <summary>
            /// Enum ThreateningEnum for Threatening
            /// </summary>
            [EnumMember(Value = "Threatening")]
            ThreateningEnum = 26,
            /// <summary>
            /// Enum TrustViolationEnum for Trust violation
            /// </summary>
            [EnumMember(Value = "Trust violation")]
            TrustViolationEnum = 27,
            /// <summary>
            /// Enum UnderInfluenceEnum for Under influence
            /// </summary>
            [EnumMember(Value = "Under influence")]
            UnderInfluenceEnum = 28,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 29        }
}
