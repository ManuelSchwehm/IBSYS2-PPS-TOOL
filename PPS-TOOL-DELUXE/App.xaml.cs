using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace PPS_TOOL_DELUXE
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public CultureInfo CurrentCulture { get; set; }
        public string GetLanguage
        {
            get => CurrentCulture.DisplayName;
        }

        public App()
        {
            CurrentCulture = CultureInfo.CurrentCulture;
        }
    }
}
