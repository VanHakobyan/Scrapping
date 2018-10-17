using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Xml;
using CsvHelper;
using Newtonsoft.Json;
using ScrappingHelpers;
using ScrappingHelpers.Models;

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
        public void WriteCSV<T>(IEnumerable<T> items, string path)
        {
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);


            using (var writer = new StreamWriter(path))
            {
                writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                foreach (var item in items)
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                }
            }
        }
        private async void ScrapNBA_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var path = Path.Text;
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                var nba = _scrapping.GetNba();
                var saved = $@"{path}\NBA_{DateTime.Now:yyyy-dd-M--HH-mm-ss}.csv";
                WriteCSV(nba, saved);
                MessageBox.Show($"Completed and svaed to {saved} ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private async void ScrapCleaningtheglass_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var path = Path.Text;
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                var leaningtheglass = await _scrapping.GetCleaningtheglass();
                var saved = $@"{path}\leaningtheglass_{DateTime.Now:yyyy-dd-M--HH-mm-ss}.csv";
                WriteCSV(leaningtheglass, saved);
                MessageBox.Show($"Completed and svaed to {saved} ");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private async void ScrapBasketball_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                var path = Path.Text;
                if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                var resultBasketball = await _scrapping.GetBasketball();
                var saved = $@"{path}\resultBasketball_{DateTime.Now:yyyy-dd-M--HH-mm-ss}i.csv";
                WriteCSV(resultBasketball, saved);
                MessageBox.Show($"Completed and svaed to {saved} ");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
