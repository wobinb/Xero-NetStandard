/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.4
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model
{
    /// <summary>
    /// Defines CountryCode
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CountryCode
    {
        /// <summary>
        /// Enum AD for value: AD
        /// </summary>
        [EnumMember(Value = "AD")]
        AD = 1,

        /// <summary>
        /// Enum AE for value: AE
        /// </summary>
        [EnumMember(Value = "AE")]
        AE = 2,

        /// <summary>
        /// Enum AF for value: AF
        /// </summary>
        [EnumMember(Value = "AF")]
        AF = 3,

        /// <summary>
        /// Enum AG for value: AG
        /// </summary>
        [EnumMember(Value = "AG")]
        AG = 4,

        /// <summary>
        /// Enum AI for value: AI
        /// </summary>
        [EnumMember(Value = "AI")]
        AI = 5,

        /// <summary>
        /// Enum AL for value: AL
        /// </summary>
        [EnumMember(Value = "AL")]
        AL = 6,

        /// <summary>
        /// Enum AM for value: AM
        /// </summary>
        [EnumMember(Value = "AM")]
        AM = 7,

        /// <summary>
        /// Enum AN for value: AN
        /// </summary>
        [EnumMember(Value = "AN")]
        AN = 8,

        /// <summary>
        /// Enum AO for value: AO
        /// </summary>
        [EnumMember(Value = "AO")]
        AO = 9,

        /// <summary>
        /// Enum AQ for value: AQ
        /// </summary>
        [EnumMember(Value = "AQ")]
        AQ = 10,

        /// <summary>
        /// Enum AR for value: AR
        /// </summary>
        [EnumMember(Value = "AR")]
        AR = 11,

        /// <summary>
        /// Enum AS for value: AS
        /// </summary>
        [EnumMember(Value = "AS")]
        AS = 12,

        /// <summary>
        /// Enum AT for value: AT
        /// </summary>
        [EnumMember(Value = "AT")]
        AT = 13,

        /// <summary>
        /// Enum AU for value: AU
        /// </summary>
        [EnumMember(Value = "AU")]
        AU = 14,

        /// <summary>
        /// Enum AW for value: AW
        /// </summary>
        [EnumMember(Value = "AW")]
        AW = 15,

        /// <summary>
        /// Enum AZ for value: AZ
        /// </summary>
        [EnumMember(Value = "AZ")]
        AZ = 16,

        /// <summary>
        /// Enum BA for value: BA
        /// </summary>
        [EnumMember(Value = "BA")]
        BA = 17,

        /// <summary>
        /// Enum BB for value: BB
        /// </summary>
        [EnumMember(Value = "BB")]
        BB = 18,

        /// <summary>
        /// Enum BD for value: BD
        /// </summary>
        [EnumMember(Value = "BD")]
        BD = 19,

        /// <summary>
        /// Enum BE for value: BE
        /// </summary>
        [EnumMember(Value = "BE")]
        BE = 20,

        /// <summary>
        /// Enum BF for value: BF
        /// </summary>
        [EnumMember(Value = "BF")]
        BF = 21,

        /// <summary>
        /// Enum BG for value: BG
        /// </summary>
        [EnumMember(Value = "BG")]
        BG = 22,

        /// <summary>
        /// Enum BH for value: BH
        /// </summary>
        [EnumMember(Value = "BH")]
        BH = 23,

        /// <summary>
        /// Enum BI for value: BI
        /// </summary>
        [EnumMember(Value = "BI")]
        BI = 24,

        /// <summary>
        /// Enum BJ for value: BJ
        /// </summary>
        [EnumMember(Value = "BJ")]
        BJ = 25,

        /// <summary>
        /// Enum BL for value: BL
        /// </summary>
        [EnumMember(Value = "BL")]
        BL = 26,

        /// <summary>
        /// Enum BM for value: BM
        /// </summary>
        [EnumMember(Value = "BM")]
        BM = 27,

        /// <summary>
        /// Enum BN for value: BN
        /// </summary>
        [EnumMember(Value = "BN")]
        BN = 28,

        /// <summary>
        /// Enum BO for value: BO
        /// </summary>
        [EnumMember(Value = "BO")]
        BO = 29,

        /// <summary>
        /// Enum BR for value: BR
        /// </summary>
        [EnumMember(Value = "BR")]
        BR = 30,

        /// <summary>
        /// Enum BS for value: BS
        /// </summary>
        [EnumMember(Value = "BS")]
        BS = 31,

        /// <summary>
        /// Enum BT for value: BT
        /// </summary>
        [EnumMember(Value = "BT")]
        BT = 32,

        /// <summary>
        /// Enum BW for value: BW
        /// </summary>
        [EnumMember(Value = "BW")]
        BW = 33,

        /// <summary>
        /// Enum BY for value: BY
        /// </summary>
        [EnumMember(Value = "BY")]
        BY = 34,

        /// <summary>
        /// Enum BZ for value: BZ
        /// </summary>
        [EnumMember(Value = "BZ")]
        BZ = 35,

        /// <summary>
        /// Enum CA for value: CA
        /// </summary>
        [EnumMember(Value = "CA")]
        CA = 36,

        /// <summary>
        /// Enum CC for value: CC
        /// </summary>
        [EnumMember(Value = "CC")]
        CC = 37,

        /// <summary>
        /// Enum CD for value: CD
        /// </summary>
        [EnumMember(Value = "CD")]
        CD = 38,

        /// <summary>
        /// Enum CF for value: CF
        /// </summary>
        [EnumMember(Value = "CF")]
        CF = 39,

        /// <summary>
        /// Enum CG for value: CG
        /// </summary>
        [EnumMember(Value = "CG")]
        CG = 40,

        /// <summary>
        /// Enum CH for value: CH
        /// </summary>
        [EnumMember(Value = "CH")]
        CH = 41,

        /// <summary>
        /// Enum CI for value: CI
        /// </summary>
        [EnumMember(Value = "CI")]
        CI = 42,

        /// <summary>
        /// Enum CK for value: CK
        /// </summary>
        [EnumMember(Value = "CK")]
        CK = 43,

        /// <summary>
        /// Enum CL for value: CL
        /// </summary>
        [EnumMember(Value = "CL")]
        CL = 44,

        /// <summary>
        /// Enum CM for value: CM
        /// </summary>
        [EnumMember(Value = "CM")]
        CM = 45,

        /// <summary>
        /// Enum CN for value: CN
        /// </summary>
        [EnumMember(Value = "CN")]
        CN = 46,

        /// <summary>
        /// Enum CO for value: CO
        /// </summary>
        [EnumMember(Value = "CO")]
        CO = 47,

        /// <summary>
        /// Enum CR for value: CR
        /// </summary>
        [EnumMember(Value = "CR")]
        CR = 48,

        /// <summary>
        /// Enum CU for value: CU
        /// </summary>
        [EnumMember(Value = "CU")]
        CU = 49,

        /// <summary>
        /// Enum CV for value: CV
        /// </summary>
        [EnumMember(Value = "CV")]
        CV = 50,

        /// <summary>
        /// Enum CW for value: CW
        /// </summary>
        [EnumMember(Value = "CW")]
        CW = 51,

        /// <summary>
        /// Enum CX for value: CX
        /// </summary>
        [EnumMember(Value = "CX")]
        CX = 52,

        /// <summary>
        /// Enum CY for value: CY
        /// </summary>
        [EnumMember(Value = "CY")]
        CY = 53,

        /// <summary>
        /// Enum CZ for value: CZ
        /// </summary>
        [EnumMember(Value = "CZ")]
        CZ = 54,

        /// <summary>
        /// Enum DE for value: DE
        /// </summary>
        [EnumMember(Value = "DE")]
        DE = 55,

        /// <summary>
        /// Enum DJ for value: DJ
        /// </summary>
        [EnumMember(Value = "DJ")]
        DJ = 56,

        /// <summary>
        /// Enum DK for value: DK
        /// </summary>
        [EnumMember(Value = "DK")]
        DK = 57,

        /// <summary>
        /// Enum DM for value: DM
        /// </summary>
        [EnumMember(Value = "DM")]
        DM = 58,

        /// <summary>
        /// Enum DO for value: DO
        /// </summary>
        [EnumMember(Value = "DO")]
        DO = 59,

        /// <summary>
        /// Enum DZ for value: DZ
        /// </summary>
        [EnumMember(Value = "DZ")]
        DZ = 60,

        /// <summary>
        /// Enum EC for value: EC
        /// </summary>
        [EnumMember(Value = "EC")]
        EC = 61,

        /// <summary>
        /// Enum EE for value: EE
        /// </summary>
        [EnumMember(Value = "EE")]
        EE = 62,

        /// <summary>
        /// Enum EG for value: EG
        /// </summary>
        [EnumMember(Value = "EG")]
        EG = 63,

        /// <summary>
        /// Enum EH for value: EH
        /// </summary>
        [EnumMember(Value = "EH")]
        EH = 64,

        /// <summary>
        /// Enum ER for value: ER
        /// </summary>
        [EnumMember(Value = "ER")]
        ER = 65,

        /// <summary>
        /// Enum ES for value: ES
        /// </summary>
        [EnumMember(Value = "ES")]
        ES = 66,

        /// <summary>
        /// Enum ET for value: ET
        /// </summary>
        [EnumMember(Value = "ET")]
        ET = 67,

        /// <summary>
        /// Enum FI for value: FI
        /// </summary>
        [EnumMember(Value = "FI")]
        FI = 68,

        /// <summary>
        /// Enum FJ for value: FJ
        /// </summary>
        [EnumMember(Value = "FJ")]
        FJ = 69,

        /// <summary>
        /// Enum FK for value: FK
        /// </summary>
        [EnumMember(Value = "FK")]
        FK = 70,

        /// <summary>
        /// Enum FM for value: FM
        /// </summary>
        [EnumMember(Value = "FM")]
        FM = 71,

        /// <summary>
        /// Enum FO for value: FO
        /// </summary>
        [EnumMember(Value = "FO")]
        FO = 72,

        /// <summary>
        /// Enum FR for value: FR
        /// </summary>
        [EnumMember(Value = "FR")]
        FR = 73,

        /// <summary>
        /// Enum GA for value: GA
        /// </summary>
        [EnumMember(Value = "GA")]
        GA = 74,

        /// <summary>
        /// Enum GB for value: GB
        /// </summary>
        [EnumMember(Value = "GB")]
        GB = 75,

        /// <summary>
        /// Enum GD for value: GD
        /// </summary>
        [EnumMember(Value = "GD")]
        GD = 76,

        /// <summary>
        /// Enum GE for value: GE
        /// </summary>
        [EnumMember(Value = "GE")]
        GE = 77,

        /// <summary>
        /// Enum GG for value: GG
        /// </summary>
        [EnumMember(Value = "GG")]
        GG = 78,

        /// <summary>
        /// Enum GH for value: GH
        /// </summary>
        [EnumMember(Value = "GH")]
        GH = 79,

        /// <summary>
        /// Enum GI for value: GI
        /// </summary>
        [EnumMember(Value = "GI")]
        GI = 80,

        /// <summary>
        /// Enum GL for value: GL
        /// </summary>
        [EnumMember(Value = "GL")]
        GL = 81,

        /// <summary>
        /// Enum GM for value: GM
        /// </summary>
        [EnumMember(Value = "GM")]
        GM = 82,

        /// <summary>
        /// Enum GN for value: GN
        /// </summary>
        [EnumMember(Value = "GN")]
        GN = 83,

        /// <summary>
        /// Enum GQ for value: GQ
        /// </summary>
        [EnumMember(Value = "GQ")]
        GQ = 84,

        /// <summary>
        /// Enum GR for value: GR
        /// </summary>
        [EnumMember(Value = "GR")]
        GR = 85,

        /// <summary>
        /// Enum GT for value: GT
        /// </summary>
        [EnumMember(Value = "GT")]
        GT = 86,

        /// <summary>
        /// Enum GU for value: GU
        /// </summary>
        [EnumMember(Value = "GU")]
        GU = 87,

        /// <summary>
        /// Enum GW for value: GW
        /// </summary>
        [EnumMember(Value = "GW")]
        GW = 88,

        /// <summary>
        /// Enum GY for value: GY
        /// </summary>
        [EnumMember(Value = "GY")]
        GY = 89,

        /// <summary>
        /// Enum HK for value: HK
        /// </summary>
        [EnumMember(Value = "HK")]
        HK = 90,

        /// <summary>
        /// Enum HN for value: HN
        /// </summary>
        [EnumMember(Value = "HN")]
        HN = 91,

        /// <summary>
        /// Enum HR for value: HR
        /// </summary>
        [EnumMember(Value = "HR")]
        HR = 92,

        /// <summary>
        /// Enum HT for value: HT
        /// </summary>
        [EnumMember(Value = "HT")]
        HT = 93,

        /// <summary>
        /// Enum HU for value: HU
        /// </summary>
        [EnumMember(Value = "HU")]
        HU = 94,

        /// <summary>
        /// Enum ID for value: ID
        /// </summary>
        [EnumMember(Value = "ID")]
        ID = 95,

        /// <summary>
        /// Enum IE for value: IE
        /// </summary>
        [EnumMember(Value = "IE")]
        IE = 96,

        /// <summary>
        /// Enum IL for value: IL
        /// </summary>
        [EnumMember(Value = "IL")]
        IL = 97,

        /// <summary>
        /// Enum IM for value: IM
        /// </summary>
        [EnumMember(Value = "IM")]
        IM = 98,

        /// <summary>
        /// Enum IN for value: IN
        /// </summary>
        [EnumMember(Value = "IN")]
        IN = 99,

        /// <summary>
        /// Enum IO for value: IO
        /// </summary>
        [EnumMember(Value = "IO")]
        IO = 100,

        /// <summary>
        /// Enum IQ for value: IQ
        /// </summary>
        [EnumMember(Value = "IQ")]
        IQ = 101,

        /// <summary>
        /// Enum IR for value: IR
        /// </summary>
        [EnumMember(Value = "IR")]
        IR = 102,

        /// <summary>
        /// Enum IS for value: IS
        /// </summary>
        [EnumMember(Value = "IS")]
        IS = 103,

        /// <summary>
        /// Enum IT for value: IT
        /// </summary>
        [EnumMember(Value = "IT")]
        IT = 104,

        /// <summary>
        /// Enum JE for value: JE
        /// </summary>
        [EnumMember(Value = "JE")]
        JE = 105,

        /// <summary>
        /// Enum JM for value: JM
        /// </summary>
        [EnumMember(Value = "JM")]
        JM = 106,

        /// <summary>
        /// Enum JO for value: JO
        /// </summary>
        [EnumMember(Value = "JO")]
        JO = 107,

        /// <summary>
        /// Enum JP for value: JP
        /// </summary>
        [EnumMember(Value = "JP")]
        JP = 108,

        /// <summary>
        /// Enum KE for value: KE
        /// </summary>
        [EnumMember(Value = "KE")]
        KE = 109,

        /// <summary>
        /// Enum KG for value: KG
        /// </summary>
        [EnumMember(Value = "KG")]
        KG = 110,

        /// <summary>
        /// Enum KH for value: KH
        /// </summary>
        [EnumMember(Value = "KH")]
        KH = 111,

        /// <summary>
        /// Enum KI for value: KI
        /// </summary>
        [EnumMember(Value = "KI")]
        KI = 112,

        /// <summary>
        /// Enum KM for value: KM
        /// </summary>
        [EnumMember(Value = "KM")]
        KM = 113,

        /// <summary>
        /// Enum KN for value: KN
        /// </summary>
        [EnumMember(Value = "KN")]
        KN = 114,

        /// <summary>
        /// Enum KP for value: KP
        /// </summary>
        [EnumMember(Value = "KP")]
        KP = 115,

        /// <summary>
        /// Enum KR for value: KR
        /// </summary>
        [EnumMember(Value = "KR")]
        KR = 116,

        /// <summary>
        /// Enum KW for value: KW
        /// </summary>
        [EnumMember(Value = "KW")]
        KW = 117,

        /// <summary>
        /// Enum KY for value: KY
        /// </summary>
        [EnumMember(Value = "KY")]
        KY = 118,

        /// <summary>
        /// Enum KZ for value: KZ
        /// </summary>
        [EnumMember(Value = "KZ")]
        KZ = 119,

        /// <summary>
        /// Enum LA for value: LA
        /// </summary>
        [EnumMember(Value = "LA")]
        LA = 120,

        /// <summary>
        /// Enum LB for value: LB
        /// </summary>
        [EnumMember(Value = "LB")]
        LB = 121,

        /// <summary>
        /// Enum LC for value: LC
        /// </summary>
        [EnumMember(Value = "LC")]
        LC = 122,

        /// <summary>
        /// Enum LI for value: LI
        /// </summary>
        [EnumMember(Value = "LI")]
        LI = 123,

        /// <summary>
        /// Enum LK for value: LK
        /// </summary>
        [EnumMember(Value = "LK")]
        LK = 124,

        /// <summary>
        /// Enum LR for value: LR
        /// </summary>
        [EnumMember(Value = "LR")]
        LR = 125,

        /// <summary>
        /// Enum LS for value: LS
        /// </summary>
        [EnumMember(Value = "LS")]
        LS = 126,

        /// <summary>
        /// Enum LT for value: LT
        /// </summary>
        [EnumMember(Value = "LT")]
        LT = 127,

        /// <summary>
        /// Enum LU for value: LU
        /// </summary>
        [EnumMember(Value = "LU")]
        LU = 128,

        /// <summary>
        /// Enum LV for value: LV
        /// </summary>
        [EnumMember(Value = "LV")]
        LV = 129,

        /// <summary>
        /// Enum LY for value: LY
        /// </summary>
        [EnumMember(Value = "LY")]
        LY = 130,

        /// <summary>
        /// Enum MA for value: MA
        /// </summary>
        [EnumMember(Value = "MA")]
        MA = 131,

        /// <summary>
        /// Enum MC for value: MC
        /// </summary>
        [EnumMember(Value = "MC")]
        MC = 132,

        /// <summary>
        /// Enum MD for value: MD
        /// </summary>
        [EnumMember(Value = "MD")]
        MD = 133,

        /// <summary>
        /// Enum ME for value: ME
        /// </summary>
        [EnumMember(Value = "ME")]
        ME = 134,

        /// <summary>
        /// Enum MF for value: MF
        /// </summary>
        [EnumMember(Value = "MF")]
        MF = 135,

        /// <summary>
        /// Enum MG for value: MG
        /// </summary>
        [EnumMember(Value = "MG")]
        MG = 136,

        /// <summary>
        /// Enum MH for value: MH
        /// </summary>
        [EnumMember(Value = "MH")]
        MH = 137,

        /// <summary>
        /// Enum MK for value: MK
        /// </summary>
        [EnumMember(Value = "MK")]
        MK = 138,

        /// <summary>
        /// Enum ML for value: ML
        /// </summary>
        [EnumMember(Value = "ML")]
        ML = 139,

        /// <summary>
        /// Enum MM for value: MM
        /// </summary>
        [EnumMember(Value = "MM")]
        MM = 140,

        /// <summary>
        /// Enum MN for value: MN
        /// </summary>
        [EnumMember(Value = "MN")]
        MN = 141,

        /// <summary>
        /// Enum MO for value: MO
        /// </summary>
        [EnumMember(Value = "MO")]
        MO = 142,

        /// <summary>
        /// Enum MP for value: MP
        /// </summary>
        [EnumMember(Value = "MP")]
        MP = 143,

        /// <summary>
        /// Enum MR for value: MR
        /// </summary>
        [EnumMember(Value = "MR")]
        MR = 144,

        /// <summary>
        /// Enum MS for value: MS
        /// </summary>
        [EnumMember(Value = "MS")]
        MS = 145,

        /// <summary>
        /// Enum MT for value: MT
        /// </summary>
        [EnumMember(Value = "MT")]
        MT = 146,

        /// <summary>
        /// Enum MU for value: MU
        /// </summary>
        [EnumMember(Value = "MU")]
        MU = 147,

        /// <summary>
        /// Enum MV for value: MV
        /// </summary>
        [EnumMember(Value = "MV")]
        MV = 148,

        /// <summary>
        /// Enum MW for value: MW
        /// </summary>
        [EnumMember(Value = "MW")]
        MW = 149,

        /// <summary>
        /// Enum MX for value: MX
        /// </summary>
        [EnumMember(Value = "MX")]
        MX = 150,

        /// <summary>
        /// Enum MY for value: MY
        /// </summary>
        [EnumMember(Value = "MY")]
        MY = 151,

        /// <summary>
        /// Enum MZ for value: MZ
        /// </summary>
        [EnumMember(Value = "MZ")]
        MZ = 152,

        /// <summary>
        /// Enum NA for value: NA
        /// </summary>
        [EnumMember(Value = "NA")]
        NA = 153,

        /// <summary>
        /// Enum NC for value: NC
        /// </summary>
        [EnumMember(Value = "NC")]
        NC = 154,

        /// <summary>
        /// Enum NE for value: NE
        /// </summary>
        [EnumMember(Value = "NE")]
        NE = 155,

        /// <summary>
        /// Enum NG for value: NG
        /// </summary>
        [EnumMember(Value = "NG")]
        NG = 156,

        /// <summary>
        /// Enum NI for value: NI
        /// </summary>
        [EnumMember(Value = "NI")]
        NI = 157,

        /// <summary>
        /// Enum NL for value: NL
        /// </summary>
        [EnumMember(Value = "NL")]
        NL = 158,

        /// <summary>
        /// Enum NO for value: NO
        /// </summary>
        [EnumMember(Value = "NO")]
        NO = 159,

        /// <summary>
        /// Enum NP for value: NP
        /// </summary>
        [EnumMember(Value = "NP")]
        NP = 160,

        /// <summary>
        /// Enum NR for value: NR
        /// </summary>
        [EnumMember(Value = "NR")]
        NR = 161,

        /// <summary>
        /// Enum NU for value: NU
        /// </summary>
        [EnumMember(Value = "NU")]
        NU = 162,

        /// <summary>
        /// Enum NZ for value: NZ
        /// </summary>
        [EnumMember(Value = "NZ")]
        NZ = 163,

        /// <summary>
        /// Enum OM for value: OM
        /// </summary>
        [EnumMember(Value = "OM")]
        OM = 164,

        /// <summary>
        /// Enum PA for value: PA
        /// </summary>
        [EnumMember(Value = "PA")]
        PA = 165,

        /// <summary>
        /// Enum PE for value: PE
        /// </summary>
        [EnumMember(Value = "PE")]
        PE = 166,

        /// <summary>
        /// Enum PF for value: PF
        /// </summary>
        [EnumMember(Value = "PF")]
        PF = 167,

        /// <summary>
        /// Enum PG for value: PG
        /// </summary>
        [EnumMember(Value = "PG")]
        PG = 168,

        /// <summary>
        /// Enum PH for value: PH
        /// </summary>
        [EnumMember(Value = "PH")]
        PH = 169,

        /// <summary>
        /// Enum PK for value: PK
        /// </summary>
        [EnumMember(Value = "PK")]
        PK = 170,

        /// <summary>
        /// Enum PL for value: PL
        /// </summary>
        [EnumMember(Value = "PL")]
        PL = 171,

        /// <summary>
        /// Enum PM for value: PM
        /// </summary>
        [EnumMember(Value = "PM")]
        PM = 172,

        /// <summary>
        /// Enum PN for value: PN
        /// </summary>
        [EnumMember(Value = "PN")]
        PN = 173,

        /// <summary>
        /// Enum PR for value: PR
        /// </summary>
        [EnumMember(Value = "PR")]
        PR = 174,

        /// <summary>
        /// Enum PS for value: PS
        /// </summary>
        [EnumMember(Value = "PS")]
        PS = 175,

        /// <summary>
        /// Enum PT for value: PT
        /// </summary>
        [EnumMember(Value = "PT")]
        PT = 176,

        /// <summary>
        /// Enum PW for value: PW
        /// </summary>
        [EnumMember(Value = "PW")]
        PW = 177,

        /// <summary>
        /// Enum PY for value: PY
        /// </summary>
        [EnumMember(Value = "PY")]
        PY = 178,

        /// <summary>
        /// Enum QA for value: QA
        /// </summary>
        [EnumMember(Value = "QA")]
        QA = 179,

        /// <summary>
        /// Enum RE for value: RE
        /// </summary>
        [EnumMember(Value = "RE")]
        RE = 180,

        /// <summary>
        /// Enum RO for value: RO
        /// </summary>
        [EnumMember(Value = "RO")]
        RO = 181,

        /// <summary>
        /// Enum RS for value: RS
        /// </summary>
        [EnumMember(Value = "RS")]
        RS = 182,

        /// <summary>
        /// Enum RU for value: RU
        /// </summary>
        [EnumMember(Value = "RU")]
        RU = 183,

        /// <summary>
        /// Enum RW for value: RW
        /// </summary>
        [EnumMember(Value = "RW")]
        RW = 184,

        /// <summary>
        /// Enum SA for value: SA
        /// </summary>
        [EnumMember(Value = "SA")]
        SA = 185,

        /// <summary>
        /// Enum SB for value: SB
        /// </summary>
        [EnumMember(Value = "SB")]
        SB = 186,

        /// <summary>
        /// Enum SC for value: SC
        /// </summary>
        [EnumMember(Value = "SC")]
        SC = 187,

        /// <summary>
        /// Enum SD for value: SD
        /// </summary>
        [EnumMember(Value = "SD")]
        SD = 188,

        /// <summary>
        /// Enum SE for value: SE
        /// </summary>
        [EnumMember(Value = "SE")]
        SE = 189,

        /// <summary>
        /// Enum SG for value: SG
        /// </summary>
        [EnumMember(Value = "SG")]
        SG = 190,

        /// <summary>
        /// Enum SH for value: SH
        /// </summary>
        [EnumMember(Value = "SH")]
        SH = 191,

        /// <summary>
        /// Enum SI for value: SI
        /// </summary>
        [EnumMember(Value = "SI")]
        SI = 192,

        /// <summary>
        /// Enum SJ for value: SJ
        /// </summary>
        [EnumMember(Value = "SJ")]
        SJ = 193,

        /// <summary>
        /// Enum SK for value: SK
        /// </summary>
        [EnumMember(Value = "SK")]
        SK = 194,

        /// <summary>
        /// Enum SL for value: SL
        /// </summary>
        [EnumMember(Value = "SL")]
        SL = 195,

        /// <summary>
        /// Enum SM for value: SM
        /// </summary>
        [EnumMember(Value = "SM")]
        SM = 196,

        /// <summary>
        /// Enum SN for value: SN
        /// </summary>
        [EnumMember(Value = "SN")]
        SN = 197,

        /// <summary>
        /// Enum SO for value: SO
        /// </summary>
        [EnumMember(Value = "SO")]
        SO = 198,

        /// <summary>
        /// Enum SR for value: SR
        /// </summary>
        [EnumMember(Value = "SR")]
        SR = 199,

        /// <summary>
        /// Enum SS for value: SS
        /// </summary>
        [EnumMember(Value = "SS")]
        SS = 200,

        /// <summary>
        /// Enum ST for value: ST
        /// </summary>
        [EnumMember(Value = "ST")]
        ST = 201,

        /// <summary>
        /// Enum SV for value: SV
        /// </summary>
        [EnumMember(Value = "SV")]
        SV = 202,

        /// <summary>
        /// Enum SX for value: SX
        /// </summary>
        [EnumMember(Value = "SX")]
        SX = 203,

        /// <summary>
        /// Enum SY for value: SY
        /// </summary>
        [EnumMember(Value = "SY")]
        SY = 204,

        /// <summary>
        /// Enum SZ for value: SZ
        /// </summary>
        [EnumMember(Value = "SZ")]
        SZ = 205,

        /// <summary>
        /// Enum TC for value: TC
        /// </summary>
        [EnumMember(Value = "TC")]
        TC = 206,

        /// <summary>
        /// Enum TD for value: TD
        /// </summary>
        [EnumMember(Value = "TD")]
        TD = 207,

        /// <summary>
        /// Enum TG for value: TG
        /// </summary>
        [EnumMember(Value = "TG")]
        TG = 208,

        /// <summary>
        /// Enum TH for value: TH
        /// </summary>
        [EnumMember(Value = "TH")]
        TH = 209,

        /// <summary>
        /// Enum TJ for value: TJ
        /// </summary>
        [EnumMember(Value = "TJ")]
        TJ = 210,

        /// <summary>
        /// Enum TK for value: TK
        /// </summary>
        [EnumMember(Value = "TK")]
        TK = 211,

        /// <summary>
        /// Enum TL for value: TL
        /// </summary>
        [EnumMember(Value = "TL")]
        TL = 212,

        /// <summary>
        /// Enum TM for value: TM
        /// </summary>
        [EnumMember(Value = "TM")]
        TM = 213,

        /// <summary>
        /// Enum TN for value: TN
        /// </summary>
        [EnumMember(Value = "TN")]
        TN = 214,

        /// <summary>
        /// Enum TO for value: TO
        /// </summary>
        [EnumMember(Value = "TO")]
        TO = 215,

        /// <summary>
        /// Enum TR for value: TR
        /// </summary>
        [EnumMember(Value = "TR")]
        TR = 216,

        /// <summary>
        /// Enum TT for value: TT
        /// </summary>
        [EnumMember(Value = "TT")]
        TT = 217,

        /// <summary>
        /// Enum TV for value: TV
        /// </summary>
        [EnumMember(Value = "TV")]
        TV = 218,

        /// <summary>
        /// Enum TW for value: TW
        /// </summary>
        [EnumMember(Value = "TW")]
        TW = 219,

        /// <summary>
        /// Enum TZ for value: TZ
        /// </summary>
        [EnumMember(Value = "TZ")]
        TZ = 220,

        /// <summary>
        /// Enum UA for value: UA
        /// </summary>
        [EnumMember(Value = "UA")]
        UA = 221,

        /// <summary>
        /// Enum UG for value: UG
        /// </summary>
        [EnumMember(Value = "UG")]
        UG = 222,

        /// <summary>
        /// Enum US for value: US
        /// </summary>
        [EnumMember(Value = "US")]
        US = 223,

        /// <summary>
        /// Enum UY for value: UY
        /// </summary>
        [EnumMember(Value = "UY")]
        UY = 224,

        /// <summary>
        /// Enum UZ for value: UZ
        /// </summary>
        [EnumMember(Value = "UZ")]
        UZ = 225,

        /// <summary>
        /// Enum VA for value: VA
        /// </summary>
        [EnumMember(Value = "VA")]
        VA = 226,

        /// <summary>
        /// Enum VC for value: VC
        /// </summary>
        [EnumMember(Value = "VC")]
        VC = 227,

        /// <summary>
        /// Enum VE for value: VE
        /// </summary>
        [EnumMember(Value = "VE")]
        VE = 228,

        /// <summary>
        /// Enum VG for value: VG
        /// </summary>
        [EnumMember(Value = "VG")]
        VG = 229,

        /// <summary>
        /// Enum VI for value: VI
        /// </summary>
        [EnumMember(Value = "VI")]
        VI = 230,

        /// <summary>
        /// Enum VN for value: VN
        /// </summary>
        [EnumMember(Value = "VN")]
        VN = 231,

        /// <summary>
        /// Enum VU for value: VU
        /// </summary>
        [EnumMember(Value = "VU")]
        VU = 232,

        /// <summary>
        /// Enum WF for value: WF
        /// </summary>
        [EnumMember(Value = "WF")]
        WF = 233,

        /// <summary>
        /// Enum WS for value: WS
        /// </summary>
        [EnumMember(Value = "WS")]
        WS = 234,

        /// <summary>
        /// Enum XK for value: XK
        /// </summary>
        [EnumMember(Value = "XK")]
        XK = 235,

        /// <summary>
        /// Enum YE for value: YE
        /// </summary>
        [EnumMember(Value = "YE")]
        YE = 236,

        /// <summary>
        /// Enum YT for value: YT
        /// </summary>
        [EnumMember(Value = "YT")]
        YT = 237,

        /// <summary>
        /// Enum ZA for value: ZA
        /// </summary>
        [EnumMember(Value = "ZA")]
        ZA = 238,

        /// <summary>
        /// Enum ZM for value: ZM
        /// </summary>
        [EnumMember(Value = "ZM")]
        ZM = 239,

        /// <summary>
        /// Enum ZW for value: ZW
        /// </summary>
        [EnumMember(Value = "ZW")]
        ZW = 240

    }

}
