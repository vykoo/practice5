using System.ComponentModel;
using System.Windows;
using FontAwesome.WPF;

namespace Sukhoviy05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    internal partial class MainWindow : Window
    {
        private ImageAwesome _loader;
        private ProcessesListView _processesListView;

        public MainWindow()
        {
            InitializeComponent();
            ShowProcessesListView();
        }

        private void ShowProcessesListView()
        {
            MainGrid.Children.Clear();
            if (_processesListView == null)
                _processesListView = new ProcessesListView(ShowLoader);
            MainGrid.Children.Add(_processesListView);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _processesListView?.Close();
            ProcessDb.Close();
            base.OnClosing(e);
        }

        private void ShowLoader(bool isShow)
        {
            LoaderHelper.OnRequestLoader(MainGrid, ref _loader, isShow);
        }
    }
}
