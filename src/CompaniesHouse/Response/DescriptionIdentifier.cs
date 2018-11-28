using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CompaniesHouse.Response
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DescriptionIdentifier
    {
        [EnumMember(Value = "incorporated-on")]
        IncorporatedOn,

        [EnumMember(Value = "registered-on")]
        RegisteredOn,

        [EnumMember(Value = "formed-on")]
        FormedOn,

        [EnumMember(Value = "dissolved-on")]
        DissolvedOn,

        [EnumMember(Value = "closed-on")]
        ClosedOn,

        [EnumMember(Value = "closed")]
        Closed,

        [EnumMember(Value = "first-uk-establishment-opened-on")]
        FirstUkEstablishmentOpenedOn,

        [EnumMember(Value = "opened-on")]
        OpenedOn,

        [EnumMember(Value = "voluntary-arrangement")]
        VoluntaryArrangement,

        [EnumMember(Value = "insolvency-proceedings")]
        InsolvencyProceedings,

        [EnumMember(Value = "liquidation")]
        Liquidation,

        [EnumMember(Value = "administration")]
        Administration,

        [EnumMember(Value = "registered-externally")]
        RegisteredExternally,

        [EnumMember(Value = "appointment-count")]
        AppointmentCount,

        [EnumMember(Value = "born-on")]
        BornOn,
    }
}
