using Humanizer;

namespace RadarAndComms.Calculator.Utils;

public enum AppNavsType
{
    Home,
    About,
    Calculator,
    FeedBack,
}

public class AppNavItem
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public AppNavsType NavType { get; set; } = AppNavsType.Home;
    public string Title => NavType.Humanize(LetterCasing.Title);
    public string Url { get; set; }
    public string Icon { get; set; }
    public string Description { get; set; }
    public int Order { get; set; }

    public bool IsActive { get; set; } = false;


    public MudBlazor.Color GetColor() => IsActive ? MudBlazor.Color.Primary : MudBlazor.Color.Default;
    public string GetActiveHomeNavCSS() => IsActive ? "active-home-nav" : "";
    // public MudBlazor.Size GetSize() => IsActive ? MudBlazor.Size.Medium : MudBlazor.Size.Small;
    //public MudBlazor.Size GetSize() => IsActive ? MudBlazor.Size.Medium : MudBlazor.Size.Small;
    public MudBlazor.Size GetSize() => MudBlazor.Size.Small;

}