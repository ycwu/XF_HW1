using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace XF_HW1.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Title { get; set; }
        public string Expression { get; set; }
        public decimal Result { get; set; }
        public DelegateCommand<string> ClickCommand { get; set; }
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;

            ClickCommand = new DelegateCommand<string>(x =>
            {
                Expression += x.ToString();
                Result += 100;
                //switch (x)
                //{
                //    case "0":
                //        break;
                //    case "+":
                //        break;
                //    case "-":
                //        break;
                //    case "*":
                //        break;
                //    case "/":
                //        break;
                //}
            });

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("title"))
                Title = (string)parameters["title"] + " and Prism";
        }
    }
}
