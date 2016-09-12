﻿using System.Windows.Controls;

namespace DamageMeter.UI
{
    /// <summary>
    /// Logique d'interaction pour Balloon.xaml
    /// </summary>
    public partial class Balloon : UserControl
    {
        public Balloon()
        {
            InitializeComponent();
        }

        public void Value(string title, string text)
        {
            Title.Content = title;
            Content.Text = text;
        }
    }
}
