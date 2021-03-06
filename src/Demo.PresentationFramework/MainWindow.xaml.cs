﻿using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Shipwreck.BootstrapControls.Demo.PresentationFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

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

        public static IEnumerable<ColorScheme> OutlineSchemes
            => Schemes.Where(e => e.Name.StartsWith("Outline") || Schemes.All(a => a.Name != "Outline" + e.Name));
    }
}
