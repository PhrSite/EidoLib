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
        /// A data type for a target gender of the sexual interest of a person.
        /// </summary>
        /// <value>A data type for a target gender of the sexual interest of a person.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum HsPersonSexualOrientationCodeSimpleType
        {
            /// <summary>
            /// Enum BisexualEnum for Bisexual
            /// </summary>
            [EnumMember(Value = "Bisexual")]
            BisexualEnum = 0,
            /// <summary>
            /// Enum DidNotDiscloseEnum for Did not disclose
            /// </summary>
            [EnumMember(Value = "Did not disclose")]
            DidNotDiscloseEnum = 1,
            /// <summary>
            /// Enum DoNotKnowNotSureEnum for Do not know/Not sure
            /// </summary>
            [EnumMember(Value = "Do not know/Not sure")]
            DoNotKnowNotSureEnum = 2,
            /// <summary>
            /// Enum LesbianOrGayEnum for Lesbian or gay
            /// </summary>
            [EnumMember(Value = "Lesbian or gay")]
            LesbianOrGayEnum = 3,
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 4,
            /// <summary>
            /// Enum StraightEnum for Straight
            /// </summary>
            [EnumMember(Value = "Straight")]
            StraightEnum = 5        }
}
