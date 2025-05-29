using Java.Lang;
using LearnApp.Models;
using LearnApp.PageModels.Base;
using LearnApp.Pages;
using LearnApp.Services.Account;
using LearnApp.Services.Navigation;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LearnApp.PageModels
{
    public class SelectPageModel : PageModelBase
    {
        private INavigationService _navigationService;
        private IAccountService _accountService;
        private ICommand _goEng;
        private ICommand _goNem;
        public string _lang;

        public string Lang
        {
            get { return _lang; }
            set
            {
                SetProperty(ref _lang, value);
            }
        }

        public ICommand GoEng
        {
            get => _goEng;
            set => SetProperty(ref _goEng, value);
        }

        public ICommand GoNem
        {
            get => _goNem;
            set => SetProperty(ref _goNem, value);
        }
        public SelectPageModel()
        {
            _goEng = new Command(GoEn);
            _goNem = new Command(GoNe);
        }
        public SelectPageModel(INavigationService navigationService, IAccountService accountService)
        {
            _navigationService = navigationService;
            _accountService = accountService;
            _goEng = new Command(GoEn);
            _goNem = new Command(GoNe);
        }
        private async void GoEn(object obj)
        {   
            
            await _navigationService.NavigateToAsync<DashBoardPageModel>();
           
        }
        private async void GoNe(object obj)
        {
           
            await _navigationService.NavigateToAsync<DashBoardGerPageModel>();
        }
    }
}
