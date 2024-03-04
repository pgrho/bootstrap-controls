using System.ComponentModel;

namespace Shipwreck.BootstrapControls.Demo.Maui;

public partial class MainPage : ContentPage
{
    public static ColorScheme[] Schemes { get; } = {
            ColorScheme.Primary,
            ColorScheme.Secondary,
            ColorScheme.Success,
            ColorScheme.Danger,
            ColorScheme.Warning,
            ColorScheme.Info,
            ColorScheme.Dark,
            ColorScheme.OutlinePrimary,
            ColorScheme.OutlineSecondary,
            ColorScheme.OutlineSuccess,
            ColorScheme.OutlineDanger,
            ColorScheme.OutlineWarning,
            ColorScheme.OutlineInfo,
            ColorScheme.OutlineDark,
            ColorScheme.Link,
            ColorScheme.Default,
        };
    public sealed class Context : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private ColorScheme _Scheme = ColorScheme.OutlineSecondary;

        public ColorScheme Scheme
        {
            get => _Scheme;
            set
            {
                if (value != _Scheme)
                {
                    _Scheme = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Scheme)));
                }
            }
        }
    }

    public MainPage()
    {
        BootstrapControlsModule.Init();
        InitializeComponent();
        BindingContext = new Context();
    }
}
