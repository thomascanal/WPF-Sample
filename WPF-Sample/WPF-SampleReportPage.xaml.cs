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
    /// Interaction logic for WPF_SampleReportPage.xaml
    /// </summary>
    public partial class WPF_SampleReportPage : Page
    {
        public WPF_SampleReportPage()
        {
            InitializeComponent();
        }

        // Custom constructor to pass expense report data
        public WPF_SampleReportPage(object data) : this()
        {
            // Bind to WPF-Sample Report Data.
            this.DataContext = data;
        }
    }
}
