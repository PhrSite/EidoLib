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
        /// A data type for an Operational Condition of Equipment (OCE) of a vessel.
        /// </summary>
        /// <value>A data type for an Operational Condition of Equipment (OCE) of a vessel.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum MVesselOperationalConditionOfEquipmentCodeSimpleType
        {
            /// <summary>
            /// Enum NotOperationalEnum for Not Operational
            /// </summary>
            [EnumMember(Value = "Not Operational")]
            NotOperationalEnum = 0,
            /// <summary>
            /// Enum NotRequiredEnum for Not Required
            /// </summary>
            [EnumMember(Value = "Not Required")]
            NotRequiredEnum = 1,
            /// <summary>
            /// Enum OperationalEnum for Operational
            /// </summary>
            [EnumMember(Value = "Operational")]
            OperationalEnum = 2        }
}
