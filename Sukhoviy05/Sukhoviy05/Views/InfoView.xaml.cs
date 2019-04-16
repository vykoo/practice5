using System.Windows.Controls;

namespace Sukhoviy05
{
    
    internal partial class InfoView : UserControl
    {
        internal InfoView(System.Diagnostics.Process process)
        {
            InitializeComponent();
            DataContext = new InfoViewModel(process.Modules, process.Threads);
        }
    }
}
