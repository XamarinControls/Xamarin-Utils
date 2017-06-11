using Utils.Droid.CustomRenders;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Button), typeof(ButtonCustom))]
namespace Utils.Droid.CustomRenders
{
    public class ButtonCustom : ButtonRenderer
    {
        protected override void OnDraw(Android.Graphics.Canvas canvas)
        {
            base.OnDraw(canvas);
        }
    }
}
