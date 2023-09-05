using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadarAndComms.Calculator.Data;

public class CalculatorDto
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string NamePartOne { get; set; }
    public string NamePartTow { get; set; }
    public string Name => $"{NamePartOne} {NamePartTow}";
    public string Link => $"/Calculator/{Name.Replace(" ", "")}";

    public string Image { get; set; }
    public string Icon { get; set; }
}
