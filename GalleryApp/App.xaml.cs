﻿namespace GalleryApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new DynamicControls();
        }
    }
}
