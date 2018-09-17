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

        private async void Scrap_OnClick(object sender, RoutedEventArgs e)
        {
            //var resultBasketball = await _scrapping.GetBasketball();
            //var leaningtheglass = await _scrapping.GetCleaningtheglass();
            var nba =await _scrapping.GetNba();
        }
    }
}
