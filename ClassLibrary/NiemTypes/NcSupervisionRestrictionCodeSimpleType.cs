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
        /// A data type for restrictions placed upon a person under supervision.
        /// </summary>
        /// <value>A data type for restrictions placed upon a person under supervision.</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum NcSupervisionRestrictionCodeSimpleType
        {
            /// <summary>
            /// Enum ABSCONDINGEnum for ABSCONDING
            /// </summary>
            [EnumMember(Value = "ABSCONDING")]
            ABSCONDINGEnum = 0,
            /// <summary>
            /// Enum ALCOHOLEnum for ALCOHOL
            /// </summary>
            [EnumMember(Value = "ALCOHOL")]
            ALCOHOLEnum = 1,
            /// <summary>
            /// Enum ALCOHOLESTABLISHMNTEnum for ALCOHOL ESTABLISHMNT
            /// </summary>
            [EnumMember(Value = "ALCOHOL ESTABLISHMNT")]
            ALCOHOLESTABLISHMNTEnum = 2,
            /// <summary>
            /// Enum ARRESTCITATIONSEnum for ARREST-CITATIONS
            /// </summary>
            [EnumMember(Value = "ARREST-CITATIONS")]
            ARRESTCITATIONSEnum = 3,
            /// <summary>
            /// Enum ASSOCIATIONEnum for ASSOCIATION
            /// </summary>
            [EnumMember(Value = "ASSOCIATION")]
            ASSOCIATIONEnum = 4,
            /// <summary>
            /// Enum CHEMICALANALYSISEnum for CHEMICAL ANALYSIS
            /// </summary>
            [EnumMember(Value = "CHEMICAL ANALYSIS")]
            CHEMICALANALYSISEnum = 5,
            /// <summary>
            /// Enum CHILDRENCONGREGATEEnum for CHILDREN CONGREGATE
            /// </summary>
            [EnumMember(Value = "CHILDREN CONGREGATE")]
            CHILDRENCONGREGATEEnum = 6,
            /// <summary>
            /// Enum CHILDRENUNDER18Enum for CHILDREN UNDER 18
            /// </summary>
            [EnumMember(Value = "CHILDREN UNDER 18")]
            CHILDRENUNDER18Enum = 7,
            /// <summary>
            /// Enum CONDUCTEnum for CONDUCT
            /// </summary>
            [EnumMember(Value = "CONDUCT")]
            CONDUCTEnum = 8,
            /// <summary>
            /// Enum CURFEWEnum for CURFEW
            /// </summary>
            [EnumMember(Value = "CURFEW")]
            CURFEWEnum = 9,
            /// <summary>
            /// Enum DISCONNECTPHONEEnum for DISCONNECT PHONE
            /// </summary>
            [EnumMember(Value = "DISCONNECT PHONE")]
            DISCONNECTPHONEEnum = 10,
            /// <summary>
            /// Enum DNAEnum for DNA
            /// </summary>
            [EnumMember(Value = "DNA")]
            DNAEnum = 11,
            /// <summary>
            /// Enum DOCUMENTSDATAPHOTOEnum for DOCUMENTS/DATA/PHOTO
            /// </summary>
            [EnumMember(Value = "DOCUMENTS/DATA/PHOTO")]
            DOCUMENTSDATAPHOTOEnum = 12,
            /// <summary>
            /// Enum DRIVERLICENSEIDEnum for DRIVER LICENSE/ID
            /// </summary>
            [EnumMember(Value = "DRIVER LICENSE/ID")]
            DRIVERLICENSEIDEnum = 13,
            /// <summary>
            /// Enum DRUGSEnum for DRUGS
            /// </summary>
            [EnumMember(Value = "DRUGS")]
            DRUGSEnum = 14,
            /// <summary>
            /// Enum ELECTRONICMONITOREnum for ELECTRONIC MONITOR
            /// </summary>
            [EnumMember(Value = "ELECTRONIC MONITOR")]
            ELECTRONICMONITOREnum = 15,
            /// <summary>
            /// Enum EMPLOYMENTEnum for EMPLOYMENT
            /// </summary>
            [EnumMember(Value = "EMPLOYMENT")]
            EMPLOYMENTEnum = 16,
            /// <summary>
            /// Enum EMPLOYMENTVERIFYEnum for EMPLOYMENT VERIFY
            /// </summary>
            [EnumMember(Value = "EMPLOYMENT VERIFY")]
            EMPLOYMENTVERIFYEnum = 17,
            /// <summary>
            /// Enum ENTERTAINLUREEnum for ENTERTAIN/LURE
            /// </summary>
            [EnumMember(Value = "ENTERTAIN/LURE")]
            ENTERTAINLUREEnum = 18,
            /// <summary>
            /// Enum EXPLOITMATERIALEnum for EXPLOIT MATERIAL
            /// </summary>
            [EnumMember(Value = "EXPLOIT MATERIAL")]
            EXPLOITMATERIALEnum = 19,
            /// <summary>
            /// Enum FEESEnum for FEES
            /// </summary>
            [EnumMember(Value = "FEES")]
            FEESEnum = 20,
            /// <summary>
            /// Enum FINANCIALAGREEMENTEnum for FINANCIAL AGREEMENT
            /// </summary>
            [EnumMember(Value = "FINANCIAL AGREEMENT")]
            FINANCIALAGREEMENTEnum = 21,
            /// <summary>
            /// Enum FIREARMAMMUITIONEnum for FIREARM/AMMUITION
            /// </summary>
            [EnumMember(Value = "FIREARM/AMMUITION")]
            FIREARMAMMUITIONEnum = 22,
            /// <summary>
            /// Enum FIREARMSUSEDEnum for FIREARMS USED
            /// </summary>
            [EnumMember(Value = "FIREARMS USED")]
            FIREARMSUSEDEnum = 23,
            /// <summary>
            /// Enum FREQUENTGANGPLACESEnum for FREQUENT GANG PLACES
            /// </summary>
            [EnumMember(Value = "FREQUENT GANG PLACES")]
            FREQUENTGANGPLACESEnum = 24,
            /// <summary>
            /// Enum FREQUENTSCHOOLSEnum for FREQUENT SCHOOLS
            /// </summary>
            [EnumMember(Value = "FREQUENT SCHOOLS")]
            FREQUENTSCHOOLSEnum = 25,
            /// <summary>
            /// Enum GANGMEMBERSEnum for GANG MEMBERS
            /// </summary>
            [EnumMember(Value = "GANG MEMBERS")]
            GANGMEMBERSEnum = 26,
            /// <summary>
            /// Enum GEDDIPLOMAEnum for GED/DIPLOMA
            /// </summary>
            [EnumMember(Value = "GED/DIPLOMA")]
            GEDDIPLOMAEnum = 27,
            /// <summary>
            /// Enum HMUABUSEEnum for HMU ABUSE
            /// </summary>
            [EnumMember(Value = "HMU ABUSE")]
            HMUABUSEEnum = 28,
            /// <summary>
            /// Enum HMUMOVEEnum for HMU MOVE
            /// </summary>
            [EnumMember(Value = "HMU MOVE")]
            HMUMOVEEnum = 29,
            /// <summary>
            /// Enum HOMEVISITSEnum for HOME VISITS
            /// </summary>
            [EnumMember(Value = "HOME VISITS")]
            HOMEVISITSEnum = 30,
            /// <summary>
            /// Enum INSIGNIASEMBLEMSEnum for INSIGNIAS/EMBLEMS
            /// </summary>
            [EnumMember(Value = "INSIGNIAS/EMBLEMS")]
            INSIGNIASEMBLEMSEnum = 31,
            /// <summary>
            /// Enum INTERSTATECOMPACTEnum for INTERSTATE COMPACT
            /// </summary>
            [EnumMember(Value = "INTERSTATE COMPACT")]
            INTERSTATECOMPACTEnum = 32,
            /// <summary>
            /// Enum LAWENFORCECONTACTEnum for LAW ENFORCE CONTACT
            /// </summary>
            [EnumMember(Value = "LAW ENFORCE CONTACT")]
            LAWENFORCECONTACTEnum = 33,
            /// <summary>
            /// Enum LEAVECOUNTYEnum for LEAVE COUNTY
            /// </summary>
            [EnumMember(Value = "LEAVE COUNTY")]
            LEAVECOUNTYEnum = 34,
            /// <summary>
            /// Enum MONTHLYPAYMENTSEnum for MONTHLY PAYMENTS
            /// </summary>
            [EnumMember(Value = "MONTHLY PAYMENTS")]
            MONTHLYPAYMENTSEnum = 35,
            /// <summary>
            /// Enum NOALCOHOLEnum for NO ALCOHOL
            /// </summary>
            [EnumMember(Value = "NO ALCOHOL")]
            NOALCOHOLEnum = 36,
            /// <summary>
            /// Enum NOCONTACTWVICTMEnum for NO CONTACT W/VICTM
            /// </summary>
            [EnumMember(Value = "NO CONTACT W/VICTM")]
            NOCONTACTWVICTMEnum = 37,
            /// <summary>
            /// Enum NOTATCOURTEnum for NOT AT COURT
            /// </summary>
            [EnumMember(Value = "NOT AT COURT")]
            NOTATCOURTEnum = 38,
            /// <summary>
            /// Enum NOTDATEEnum for NOT DATE
            /// </summary>
            [EnumMember(Value = "NOT DATE")]
            NOTDATEEnum = 39,
            /// <summary>
            /// Enum PAGEREnum for PAGER
            /// </summary>
            [EnumMember(Value = "PAGER")]
            PAGEREnum = 40,
            /// <summary>
            /// Enum PAINTPENSEnum for PAINT/PENS
            /// </summary>
            [EnumMember(Value = "PAINT/PENS")]
            PAINTPENSEnum = 41,
            /// <summary>
            /// Enum PHONESERVICESEnum for PHONE SERVICES
            /// </summary>
            [EnumMember(Value = "PHONE SERVICES")]
            PHONESERVICESEnum = 42,
            /// <summary>
            /// Enum POLYGRAPHEnum for POLYGRAPH
            /// </summary>
            [EnumMember(Value = "POLYGRAPH")]
            POLYGRAPHEnum = 43,
            /// <summary>
            /// Enum PORNOGRAPHYEnum for PORNOGRAPHY
            /// </summary>
            [EnumMember(Value = "PORNOGRAPHY")]
            PORNOGRAPHYEnum = 44,
            /// <summary>
            /// Enum PROVIDEPHONELINEEnum for PROVIDE PHONE LINE
            /// </summary>
            [EnumMember(Value = "PROVIDE PHONE LINE")]
            PROVIDEPHONELINEEnum = 45,
            /// <summary>
            /// Enum REGISTRATIONDNAEnum for REGISTRATION/DNA
            /// </summary>
            [EnumMember(Value = "REGISTRATION/DNA")]
            REGISTRATIONDNAEnum = 46,
            /// <summary>
            /// Enum RELEASEEnum for RELEASE
            /// </summary>
            [EnumMember(Value = "RELEASE")]
            RELEASEEnum = 47,
            /// <summary>
            /// Enum REPORTINGEnum for REPORTING
            /// </summary>
            [EnumMember(Value = "REPORTING")]
            REPORTINGEnum = 48,
            /// <summary>
            /// Enum RESIDENCEEnum for RESIDENCE
            /// </summary>
            [EnumMember(Value = "RESIDENCE")]
            RESIDENCEEnum = 49,
            /// <summary>
            /// Enum SEARCHESEnum for SEARCHES
            /// </summary>
            [EnumMember(Value = "SEARCHES")]
            SEARCHESEnum = 50,
            /// <summary>
            /// Enum SEXSTIMULUSMATERIAEnum for SEX STIMULUS MATERIA
            /// </summary>
            [EnumMember(Value = "SEX STIMULUS MATERIA")]
            SEXSTIMULUSMATERIAEnum = 51,
            /// <summary>
            /// Enum SIGNSGESTURESEnum for SIGNS/GESTURES
            /// </summary>
            [EnumMember(Value = "SIGNS/GESTURES")]
            SIGNSGESTURESEnum = 52,
            /// <summary>
            /// Enum SPECIALEnum for SPECIAL
            /// </summary>
            [EnumMember(Value = "SPECIAL")]
            SPECIALEnum = 53,
            /// <summary>
            /// Enum STOLENVEHICLEEnum for STOLEN VEHICLE
            /// </summary>
            [EnumMember(Value = "STOLEN VEHICLE")]
            STOLENVEHICLEEnum = 54,
            /// <summary>
            /// Enum SUBSTANCETESTINGEnum for SUBSTANCE TESTING
            /// </summary>
            [EnumMember(Value = "SUBSTANCE TESTING")]
            SUBSTANCETESTINGEnum = 55,
            /// <summary>
            /// Enum SUPERVISIONFEEEnum for SUPERVISION FEE
            /// </summary>
            [EnumMember(Value = "SUPERVISION FEE")]
            SUPERVISIONFEEEnum = 56,
            /// <summary>
            /// Enum THERAPYEnum for THERAPY
            /// </summary>
            [EnumMember(Value = "THERAPY")]
            THERAPYEnum = 57,
            /// <summary>
            /// Enum TREATMENTCOUNSELINGEnum for TREATMENT/COUNSELING
            /// </summary>
            [EnumMember(Value = "TREATMENT/COUNSELING")]
            TREATMENTCOUNSELINGEnum = 58,
            /// <summary>
            /// Enum TRUTHFULNESSEnum for TRUTHFULNESS
            /// </summary>
            [EnumMember(Value = "TRUTHFULNESS")]
            TRUTHFULNESSEnum = 59,
            /// <summary>
            /// Enum UNEMPLOYEDEnum for UNEMPLOYED
            /// </summary>
            [EnumMember(Value = "UNEMPLOYED")]
            UNEMPLOYEDEnum = 60,
            /// <summary>
            /// Enum VEHICLEEnum for VEHICLE
            /// </summary>
            [EnumMember(Value = "VEHICLE")]
            VEHICLEEnum = 61,
            /// <summary>
            /// Enum VICIOUSDOGSEnum for VICIOUS DOGS
            /// </summary>
            [EnumMember(Value = "VICIOUS DOGS")]
            VICIOUSDOGSEnum = 62,
            /// <summary>
            /// Enum VICTIMCONTACTEnum for VICTIM CONTACT
            /// </summary>
            [EnumMember(Value = "VICTIM CONTACT")]
            VICTIMCONTACTEnum = 63,
            /// <summary>
            /// Enum VISITSEnum for VISITS
            /// </summary>
            [EnumMember(Value = "VISITS")]
            VISITSEnum = 64,
            /// <summary>
            /// Enum WEAPONSEnum for WEAPONS
            /// </summary>
            [EnumMember(Value = "WEAPONS")]
            WEAPONSEnum = 65        }
}
