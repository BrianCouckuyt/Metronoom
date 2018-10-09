using MetronoomAPI;
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

namespace WpfMetronoom
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Toevoegen van Handler aan event Metro.getikt

        Metronoom metro = new Metronoom();

        public MainWindow()
        {
            InitializeComponent();
            tbOutput.Text = "";
            metro.Getikt += Metro_Getikt; // of new MetroNoomHandler(Metro_Getikt)

        }

        private void Metro_Getikt(object sender, MetronoomTiktEventArgs e)
        {
            Dispatcher.Invoke(delegate () {
                tbOutput.Text += $"{e.TijdstipVanTik} : TIK\n";
            }
);
        }

        private void btnStartKlok_Click(object sender, RoutedEventArgs e)
        {
            metro.Start();
        }

        private void btnStopKlok_Click(object sender, RoutedEventArgs e)
        {
            metro.Stop();
        }
    }
}
