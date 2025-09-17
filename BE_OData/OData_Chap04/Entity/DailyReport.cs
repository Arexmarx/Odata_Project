using System;
using System.Collections.Generic;

namespace OData_Chap04.Entity;

public partial class DailyReport
{
    public string? ProvinceState { get; set; }

    public string? CountryRegion { get; set; }

    public string? LastUpdate { get; set; }

    public double? Lat { get; set; }

    public double? Long { get; set; }

    public int? Confirmed { get; set; }

    public int? Deaths { get; set; }

    public string? Recovered { get; set; }

    public string? Active { get; set; }

    public double? Fips { get; set; }

    public double? IncidentRate { get; set; }

    public double? TotalTestResults { get; set; }

    public string? PeopleHospitalized { get; set; }

    public double? CaseFatalityRatio { get; set; }

    public double? Uid { get; set; }

    public string? Iso3 { get; set; }

    public double? TestingRate { get; set; }

    public string? HospitalizationRate { get; set; }

    public string? Date { get; set; }

    public string? PeopleTested { get; set; }

    public string? MortalityRate { get; set; }
}
