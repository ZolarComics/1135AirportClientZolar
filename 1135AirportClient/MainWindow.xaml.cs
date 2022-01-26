using ModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using System.Text.Json;
using _1135AirportClient.ViewModel;
using _1135AirportClient.View;

namespace _1135AirportClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow window;
        public MainWindow()
        {
            InitializeComponent();
            window = this;
            DataContext = new MainVM();
            MainNavigate(new EmtyPage());

            Test();
        }

        public static void MainNavigate(Page page)
        {
            window.mainFrame.Navigate(page);
        }

        async Task Test()
        {
            var result = await Api.GetAsync<AircompanyApi>(1, "Aircompany");
            var city = await Api.GetListAsync<CityApi[]>("City");
        }
    }
}
