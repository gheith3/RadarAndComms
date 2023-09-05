using Android.Views;

namespace RadarAndComms.Calculator;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    protected override void OnHandlerChanged()
    {
        base.OnHandlerChanged();
#if ANDROID
        //stop stretching animation
        var blazorView = this.blazorWebView;
        var platformView = (Android.Webkit.WebView)blazorView.Handler.PlatformView;
        platformView.OverScrollMode = OverScrollMode.Never;
#endif
    }
}