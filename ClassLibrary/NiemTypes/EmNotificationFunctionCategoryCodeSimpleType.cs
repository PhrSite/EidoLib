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
        /// A data type for a notification function type codes
        /// </summary>
        /// <value>A data type for a notification function type codes</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum EmNotificationFunctionCategoryCodeSimpleType
        {
            /// <summary>
            /// Enum AckEnum for Ack
            /// </summary>
            [EnumMember(Value = "Ack")]
            AckEnum = 0,
            /// <summary>
            /// Enum AlarmEnum for Alarm
            /// </summary>
            [EnumMember(Value = "Alarm")]
            AlarmEnum = 1,
            /// <summary>
            /// Enum AlertEnum for Alert
            /// </summary>
            [EnumMember(Value = "Alert")]
            AlertEnum = 2,
            /// <summary>
            /// Enum CancelEnum for Cancel
            /// </summary>
            [EnumMember(Value = "Cancel")]
            CancelEnum = 3,
            /// <summary>
            /// Enum ErrorEnum for Error
            /// </summary>
            [EnumMember(Value = "Error")]
            ErrorEnum = 4,
            /// <summary>
            /// Enum OtherEnum for Other
            /// </summary>
            [EnumMember(Value = "Other")]
            OtherEnum = 5,
            /// <summary>
            /// Enum StatusEnum for Status
            /// </summary>
            [EnumMember(Value = "Status")]
            StatusEnum = 6,
            /// <summary>
            /// Enum UpdateEnum for Update
            /// </summary>
            [EnumMember(Value = "Update")]
            UpdateEnum = 7        }
}
