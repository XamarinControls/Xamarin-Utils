using Android.Graphics;
using Android.Graphics.Drawables;
using Utils.Droid.CustomRenders;
using Xamarin.Forms;
using Utils.CustomRenders;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(BorderedEntry), typeof(BorderedEntryCustom))]
namespace Utils.Droid.CustomRenders
{
    public class BorderedEntryCustom : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                var element = Element as BorderedEntry;

                var nativeEditText = (global::Android.Widget.EditText)Control;

                float[] R = new float[] { element.BorderWidth, element.BorderWidth, element.BorderWidth, element.BorderWidth, element.BorderWidth, element.BorderWidth, element.BorderWidth, element.BorderWidth };

                RectF inset = new RectF(10, 10, 10, 10);

                if (element.TypeBorder == 1 || element.TypeBorder > 3)
                {
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RoundRectShape(R, null, null));
                    shape.Paint.Color = element.BorderColor.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.Stroke);
                    nativeEditText.Background = shape;
                }

                if (element.TypeBorder == 2)
                {
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RoundRectShape(R, inset, R));
                    shape.Paint.Color = element.BorderColor.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.Stroke);
                    nativeEditText.Background = shape;
                }

                if (element.TypeBorder == 3)
                {
                    var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.OvalShape());
                    shape.Paint.Color = element.BorderColor.ToAndroid();
                    shape.Paint.SetStyle(Paint.Style.Stroke);
                    shape.GetHotspotBounds(new Rect(20, 120, 100, 200));
                    nativeEditText.Background = shape;
                }
            }
        }
    }
}
