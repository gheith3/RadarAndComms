using MudBlazor;
using RadarAndComms.Calculator.Data;

namespace RadarAndComms.Calculator.Utils;

public static class AppUtils
{
    public static List<CalculatorDto> GetCalculators()
    {
        return new List<CalculatorDto>()
        {
            new()
            {
                NamePartOne = "Line Of",
                NamePartTow = "Sight Distance",
                //NamePartTow = "LineOfSightDistance",
                Icon = Icons.Material.Outlined.NetworkPing
            },
            new()
            {
                NamePartOne = "Receiver",
                NamePartTow = "Sensitivity",
                //NamePartTow = "ReceiverSensitivity",
                Icon = Icons.Material.Outlined.Router
            },
            new()
            {
                NamePartOne = "Free",
                NamePartTow = "Space Loss",
                //NamePartTow = "FreeSpaceLoss",
                Icon = Icons.Material.Outlined.Language
            },
            new()
            {
                NamePartOne = "Maximum",
                NamePartTow = "Detection Range",
                //NamePartTow = "MaximumDetectionRange",
                Icon = Icons.Material.Outlined.CompareArrows
            },
        };
    }

        public static MudTheme GetAppTheme()
    {
        return new MudTheme()
        {

            Typography = new Typography()
            {
                Default = new Default()
                {
                    FontFamily = new[] { "Ubuntu", "sans-serif" },
                }
            },
            Palette = new ()
            {
                Background = "#f5f6ff"
            }
        };
    }
}


public enum TextFontWeight
{
    Title,
    Subtitle,
    Body,
    Number,
}

