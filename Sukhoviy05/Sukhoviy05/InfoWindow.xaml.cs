using System.Windows;


namespace Sukhoviy05
{
    /// <summary>
    /// Interaction logic for InfoWindow.xaml
    /// </summary>
    internal partial class InfoWindow : Window
    {
        private InfoView _infoView;

        internal InfoWindow(System.Diagnostics.Process process)
        {
            InitializeComponent();
            Title = $"{process.ProcessName} Info";
            ShowInfoView(process);
        }

        private void ShowInfoView(System.Diagnostics.Process process)
        {
            MainGrid.Children.Clear();
            if (_infoView == null)
                _infoView = new InfoView(process);
            MainGrid.Children.Add(_infoView);
        }
    }
}
