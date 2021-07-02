using System.Linq;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace Shipwreck.BootstrapControls
{
    public sealed class ButtonFrame : Frame
    {
        public static readonly BindableProperty IsOpaqueProperty
            = BindableProperty.Create(nameof(IsOpaque), typeof(bool), typeof(ButtonFrame), defaultValue: true, propertyChanged: SetColors);

        public static readonly BindableProperty HasBorderProperty
            = BindableProperty.Create(nameof(HasBorder), typeof(bool), typeof(ButtonFrame), defaultValue: true, propertyChanged: SetColors);

        public static readonly BindableProperty IsPressedProperty
            = BindableProperty.Create(nameof(IsPressed), typeof(bool), typeof(ButtonFrame), defaultValue: false, propertyChanged: SetColors);

        public static readonly BindableProperty IsActiveProperty
            = BindableProperty.Create(nameof(IsActive), typeof(bool), typeof(ButtonFrame), defaultValue: false, propertyChanged: SetColors);

        public static readonly BindableProperty SchemeProperty
            = BindableProperty.Create(nameof(Scheme), typeof(ColorScheme), typeof(ButtonFrame), defaultValue: ColorScheme.OutlineSecondary, propertyChanged: SetColors);

        public static readonly BindableProperty TextColorProperty
            = BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(ButtonFrame), defaultValue: ColorScheme.GetColor(ColorScheme.OutlineSecondary.Foreground));

        public ButtonFrame()
        {
            HasShadow = false;
            SetColors(this, false, true);
        }

        public bool IsPressed
        {
            get => (bool)GetValue(IsPressedProperty);
            set => SetValue(IsPressedProperty, value);
        }

        public bool IsOpaque
        {
            get => (bool)GetValue(IsOpaqueProperty);
            set => SetValue(IsOpaqueProperty, value);
        }

        public bool HasBorder
        {
            get => (bool)GetValue(HasBorderProperty);
            set => SetValue(HasBorderProperty, value);
        }

        public bool IsActive
        {
            get => (bool)GetValue(IsActiveProperty);
            set => SetValue(IsActiveProperty, value);
        }

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public ColorScheme Scheme
        {
            get => (ColorScheme)GetValue(SchemeProperty);
            set => SetValue(SchemeProperty, value);
        }

        protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            base.OnPropertyChanged(propertyName);

            switch (propertyName)
            {
                case nameof(IsFocused):
                case nameof(IsEnabled):
                    SetColors();
                    break;
            }
        }

        protected override void OnParentSet()
        {
            if (!GestureRecognizers.Any(e => e is TapGestureRecognizer))
            {
                GestureRecognizers.Add(new TapGestureRecognizer());
            }

            base.OnParentSet();
        }

        private static void SetColors<TPropertyType>(BindableObject bindable, TPropertyType oldValue, TPropertyType newValue)
        {
            if (bindable is ButtonFrame f)
            {
                f.SetColors();
            }
        }

        private void SetColors()
        {
            var s = Scheme;
            if (s != null)
            {
                Color bg, bo, fg;

                if (IsEnabled && (IsPressed || IsActive))
                {
                    bg = ColorScheme.GetColor(s.ActiveBackground);
                    bo = ColorScheme.GetColor(s.ActiveBorder);
                    fg = ColorScheme.GetColor(s.ActiveForeground);
                }
                else if (IsEnabled && IsFocused)
                {
                    bg = ColorScheme.GetColor(s.FocusBackground);
                    bo = ColorScheme.GetColor(s.FocusBorder);
                    fg = ColorScheme.GetColor(s.Foreground);
                }
                else
                {
                    bg = ColorScheme.GetColor(s.Background);
                    bo = ColorScheme.GetColor(s.Border);
                    fg = ColorScheme.GetColor(s.Foreground);
                }

                if (!IsEnabled)
                {
                    bg = ColorScheme.WithOpacity(bg, 0.65);
                    bo = ColorScheme.WithOpacity(bo, 0.65);
                    fg = ColorScheme.WithOpacity(fg, 0.65);
                }

                if (IsOpaque)
                {
                    bg = ColorScheme.AsRgb(bg);
                }
                if (!HasBorder)
                {
                    bo = bg;
                }
                BackgroundColor = bg;
                BorderColor = bo;
                TextColor = fg;
            }
        }
    }
}
