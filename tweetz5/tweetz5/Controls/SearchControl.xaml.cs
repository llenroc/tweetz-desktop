﻿// Copyright (c) 2013 Blue Onion Software - All rights reserved

using System.Windows;
using tweetz5.Utilities;

namespace tweetz5.Controls
{
    public partial class SearchControl
    {
        public SearchControl()
        {
            InitializeComponent();
        }

        public void SetSearchText(string text)
        {
            if (text != null) SearchText.Text = text;
        }

        private void OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            // It was the only way
            Run.Later(100, () => SearchText.Focus());
        }
    }
}