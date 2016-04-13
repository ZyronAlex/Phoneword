using System;

namespace Phoneword.Windows
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new Phoneword.App());
        }
    }
}