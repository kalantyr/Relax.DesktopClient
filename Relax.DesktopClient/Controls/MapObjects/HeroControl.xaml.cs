﻿using System.Windows.Media;
using Relax.DesktopClient.Interfaces;

namespace Relax.DesktopClient.Controls.MapObjects
{
    public partial class HeroControl
    {
        private ICharacter _hero;

        public ICharacter Hero
        {
            get => _hero;
            set
            {
                if (_hero == value)
                    return;

                _hero = value;

                if (_hero != null)
                {
                    if (_hero.Info.Name.StartsWith("А"))
                        _grd.Background = Brushes.DarkMagenta;
                    else
                        _grd.Background = Brushes.Chartreuse;
                }
            }
        }

        public HeroControl()
        {
            InitializeComponent();
        }
    }
}