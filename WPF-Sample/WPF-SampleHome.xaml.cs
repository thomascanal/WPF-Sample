using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Sample
{
    /// <summary>
    /// Interaction logic for WPF_SampleHome.xaml
    /// </summary>
    public partial class WPF_SampleHome : Page
    {
        public WPF_SampleHome()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // View Expense Report
            var wpfSampleReportPage = new WPF_SampleReportPage(this.peopleListBox.SelectedItem);
            this.NavigationService.Navigate(wpfSampleReportPage);
        }
    }
}
