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
        /// A data type for the units of measurement associated with an odometer reading.
        /// </summary>
        /// <value>A data type for the units of measurement associated with an odometer reading.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AamvaD20VehicleOdometerReadingUnitCodeSimpleType
        {
            /// <summary>
            /// Enum KEnum for K
            /// </summary>
            [EnumMember(Value = "K")]
            KEnum = 0,
            /// <summary>
            /// Enum MEnum for M
            /// </summary>
            [EnumMember(Value = "M")]
            MEnum = 1        }
}
