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
        /// A data type for a 100-meter precision level MGRS UTM coordinate.
        /// </summary>
        /// <value>A data type for a 100-meter precision level MGRS UTM coordinate.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MoMGRSUTM100MeterCoordinateSimpleType
        {
            /// <summary>
            /// Enum _019150960CHJNPXAHJNPZAHJNPV093093Enum for (0[1-9]|[1-5][0-9]|60)([C-HJ-NP-X])([A-HJ-NP-Z])([A-HJ-NP-V])([0-9]{3}[0-9]{3})
            /// </summary>
            [EnumMember(Value = "(0[1-9]|[1-5][0-9]|60)([C-HJ-NP-X])([A-HJ-NP-Z])([A-HJ-NP-V])([0-9]{3}[0-9]{3})")]
            _019150960CHJNPXAHJNPZAHJNPV093093Enum = 0,
            /// <summary>
            /// Enum NUMBER_11 for 11
            /// </summary>
            [EnumMember(Value = "11")]
            NUMBER_11 = 1        }
}
