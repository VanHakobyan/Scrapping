using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Catawiki.Desktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly Lib.Scrapping Scrapping = new Lib.Scrapping();
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var dataModels = await Scrapping.Start(Link.Text);
            //dataModels.Add(new Lib.DataModel { CurrentBid = "3", Name = "Mane", CurrentBidAmount = 6, BiddingEndTime = DateTime.Now });//TODO: will remove
            Grid.ItemsSource = dataModels;
        }

        private void Export_Click(object sender, RoutedEventArgs e)
        {
            Grid.SelectAllCells();

            Grid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, Grid);

            Grid.UnselectAllCells();
            Grid.SelectAllCells();

            Grid.ClipboardCopyMode = DataGridClipboardCopyMode.IncludeHeader;
            ApplicationCommands.Copy.Execute(null, Grid);

            Grid.UnselectAllCells();

            var result = Clipboard.GetData(System.Windows.DataFormats.CommaSeparatedValue) as string;

            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Something went wrong");
                return;
            }
            using (StreamWriter writer = new StreamWriter(@"D:/test/catawiki.csv"))
            {
                writer.Write(result);
            }
            MessageBox.Show("Successfully exported");
           // File.AppendAllText(@"D:/test/catawiki.csv", result, UnicodeEncoding.UTF8);
        }
    }
}
