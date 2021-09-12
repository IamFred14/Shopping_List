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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ButtonAddEntry_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entryBox.Text) && !shpnList.Items.Contains(entryBox.Text))
            {
                shpnList.Items.Add(entryBox.Text);
                entryBox.Clear();
            }
        }
        private void ButtonDeleteEntry_Click(object sender, RoutedEventArgs e)
        {
            shpnList.Items.Clear();
        }
    }

}
