﻿using System.Windows;

namespace Dev2.Activities.Designers2.FormatNumber
{
    public partial class Small
    {
        public Small()
        {
            InitializeComponent();
        }

        protected override IInputElement GetInitialFocusElement()
        {
            return InitialFocusElement;
        }
    }
}