﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;

namespace System.Windows.Controls.Theming
{
    /// <summary>
    /// Implicitly applies the Twilight Blue theme to all of its descendent
    /// FrameworkElements.
    /// </summary>
    /// <QualityBand>Preview</QualityBand>
    public partial class TwilightBlueTheme : Theme
    {
        /// <summary>
        /// Initializes a new instance of the TwilightBlueTheme class.
        /// </summary>
        public TwilightBlueTheme()
            : base(typeof(TwilightBlueTheme).Assembly, "System.Windows.Controls.Theming.Theme.xaml")
        {
            DefaultStyleKey = typeof(TwilightBlueTheme);
        }
    }
}