using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace Shipwreck.BootstrapControls.Blazor
{
    public partial class BootstrapCheckBox : ComponentBase
    {
        private static int _NewId;
        private readonly string _Id = "checkbox--" + (++_NewId);

        [Parameter]
        public string Header { get; set; }

        private bool _IsChecked;

        [Parameter]
        public bool IsChecked
        {
            get => _IsChecked;
            set
            {
                if (_IsChecked != value)
                {
                    _IsChecked = value;
                    StateHasChanged();
                    IsCheckedChanged?.Invoke(_IsChecked);
                }
            }
        }

        [Parameter]
        public Action<bool> IsCheckedChanged { get; set; }

        private bool _IsEnabled = true;

        [Parameter]
        public bool IsEnabled
        {
            get => _IsEnabled;
            set
            {
                if (_IsEnabled != value)
                {
                    _IsEnabled = value;
                    StateHasChanged();
                }
            }
        }

        [Parameter(CaptureUnmatchedValues = true)]
        public IDictionary<string, object> AdditionalAttributes { get; set; }
    }
}
