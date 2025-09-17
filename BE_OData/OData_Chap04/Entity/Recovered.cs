using System;
using System.Collections.Generic;

namespace OData_Chap04.Entity;

public partial class Recovered
{
    public string? ProvinceState { get; set; }

    public string CountryRegion { get; set; } = null!;

    public double? Lat { get; set; }

    public double? Long { get; set; }

    public DateOnly Date { get; set; }

    public double? Value { get; set; }

    public int Id { get; set; }
}
