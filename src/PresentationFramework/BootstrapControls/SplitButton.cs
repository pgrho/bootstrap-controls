using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Shipwreck.BootstrapControls
{
    public class SplitButton : MahApps.Metro.Controls.DropDownButton
    {
        private static readonly object TRUE = true;
        private Button _Button;
        private Button _ArrowButton;
        private ContextMenu _ContextMenu;

        public override void OnApplyTemplate()
        {
            if (_Button != null)
            {
                _Button.Click -= Button_Click;
            }
            if (_ArrowButton != null)
            {
                _ArrowButton.Click -= ArrowButton_Click;
            }
            _Button = GetTemplateChild("PART_Button") as Button;
            if (_Button != null)
            {
                _Button.Click += Button_Click;
            }
            base.OnApplyTemplate();
            _ContextMenu = GetTemplateChild("PART_Menu") as ContextMenu;
            _ArrowButton = GetTemplateChild("PART_ArrowButton") as Button;
            if (_ArrowButton != null)
            {
                _ArrowButton.Click += ArrowButton_Click;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;

            Command?.Execute(CommandParameter);

            if (_ArrowButton == null && _ContextMenu?.HasItems == true)
            {
                SetCurrentValue(IsExpandedProperty, TRUE);
            }

            e.RoutedEvent = ClickEvent;
            RaiseEvent(e);
        }

        private void ArrowButton_Click(object sender, RoutedEventArgs e)
        {
            if (_ContextMenu?.HasItems == true)
            {
                SetCurrentValue(IsExpandedProperty, TRUE);
            }
        }

        #region IsPressed

        private static readonly DependencyPropertyKey IsPressedPropertyKey
            = DependencyProperty.RegisterReadOnly(nameof(IsPressed), typeof(bool), typeof(SplitButton), new FrameworkPropertyMetadata(false));

        public static readonly DependencyProperty IsPressedProperty
            = IsPressedPropertyKey.DependencyProperty;

        public bool IsPressed
        {
            get => (bool)GetValue(IsPressedProperty);
            private set => SetValue(IsPressedPropertyKey, value);
        }

        #endregion IsPressed

        #region ArrowPadding

        public static readonly DependencyProperty ArrowPaddingProperty
            = DependencyProperty.Register(
                nameof(ArrowPadding),
                typeof(Thickness), typeof(SplitButton), new FrameworkPropertyMetadata(new Thickness()));

        public Thickness ArrowPadding
        {
            get => (Thickness)GetValue(ArrowPaddingProperty);
            set => SetValue(ArrowPaddingProperty, value);
        }

        #endregion ArrowPadding

        #region CornerRadiusMode

        public static readonly DependencyProperty CornerRadiusModeProperty = BootstrapHelper.CornerRadiusModeProperty.AddOwner(typeof(SplitButton));

        public CornerRadiusMode CornerRadiusMode
        {
            get => (CornerRadiusMode)GetValue(CornerRadiusModeProperty);
            set => SetValue(CornerRadiusModeProperty, value);
        }

        #endregion CornerRadiusMode

        protected override void OnPreviewMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            IsPressed = true;
            base.OnPreviewMouseLeftButtonDown(e);
        }

        protected override void OnPreviewMouseUp(MouseButtonEventArgs e)
        {
            IsPressed = false;
            base.OnPreviewMouseUp(e);
        }
    }
}
