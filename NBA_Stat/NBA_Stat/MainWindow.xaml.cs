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
using ScrappingHelpers;

namespace NBA_Stat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ScrappingHelpers.Scrapping _scrapping;
        public MainWindow()
        {
            InitializeComponent();
            _scrapping = new Scrapping();
        }
        
        private  void ScrapNBA_OnClick(object sender, RoutedEventArgs e)
        {
            var nba =  _scrapping.GetNba();
        }

        private async void ScrapCleaningtheglass_OnClick(object sender, RoutedEventArgs e)
        {

            var leaningtheglass = await _scrapping.GetCleaningtheglass();
        }

        private async void ScrapBasketball_OnClick(object sender, RoutedEventArgs e)
        {

            var resultBasketball = await _scrapping.GetBasketball();
        }
    }
}
