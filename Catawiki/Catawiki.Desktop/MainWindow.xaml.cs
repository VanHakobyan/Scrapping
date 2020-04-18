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
            dataModels.Add(new Lib.DataModel { CurrentBid = "3", Name = "Mane", CurrentBidAmount = 6, BiddingEndTime = DateTime.Now });//TODO: will remove
            Grid.ItemsSource = dataModels;
        }
    }
}
