using _1135AirportClient.mvvm;
using _1135AirportClient.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1135AirportClient.ViewModel
{
    class MainVM : BaseViewModel 
    {
        public CustomCommand GoToAirCompList { get; set; }

        public MainVM()
        {
            GoToAirCompList = new CustomCommand(() =>
                {
                    MainWindow.MainNavigate(new AirCopms());
                });
        }
    }
}
