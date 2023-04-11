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
        /// A data type for a gender of a person's identity.
        /// </summary>
        /// <value>A data type for a gender of a person's identity.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HsPersonGenderIdentityCodeSimpleType
        {
            /// <summary>
            /// Enum DidNotDiscloseEnum for Did not disclose
            /// </summary>
            [EnumMember(Value = "Did not disclose")]
            DidNotDiscloseEnum = 0,
            /// <summary>
            /// Enum FemaleEnum for Female
            /// </summary>
            [EnumMember(Value = "Female")]
            FemaleEnum = 1,
            /// <summary>
            /// Enum GenderqueerGenderNonConformingEnum for Genderqueer/Gender Non-conforming
            /// </summary>
            [EnumMember(Value = "Genderqueer/Gender Non-conforming")]
            GenderqueerGenderNonConformingEnum = 2,
            /// <summary>
            /// Enum IntersexNonBinaryGenderEnum for Intersex/Non-binary gender
            /// </summary>
            [EnumMember(Value = "Intersex/Non-binary gender")]
            IntersexNonBinaryGenderEnum = 3,
            /// <summary>
            /// Enum MaleEnum for Male
            /// </summary>
            [EnumMember(Value = "Male")]
            MaleEnum = 4,
            /// <summary>
            /// Enum TransgenderFemaleToMaleFTMEnum for Transgender Female to Male (FTM)
            /// </summary>
            [EnumMember(Value = "Transgender Female to Male (FTM)")]
            TransgenderFemaleToMaleFTMEnum = 5,
            /// <summary>
            /// Enum TransgenderGeneralEnum for Transgender General
            /// </summary>
            [EnumMember(Value = "Transgender General")]
            TransgenderGeneralEnum = 6,
            /// <summary>
            /// Enum TransgenderMaleToFemaleMTFEnum for Transgender Male to Female (MTF)
            /// </summary>
            [EnumMember(Value = "Transgender Male to Female (MTF)")]
            TransgenderMaleToFemaleMTFEnum = 7,
            /// <summary>
            /// Enum UnknownEnum for Unknown
            /// </summary>
            [EnumMember(Value = "Unknown")]
            UnknownEnum = 8        }
}