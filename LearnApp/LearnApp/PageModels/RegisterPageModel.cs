using AngleSharp.Text;
using LearnApp.Models;
using LearnApp.PageModels.Base;
using LearnApp.Pages;
using LearnApp.Services;
using LearnApp.Services.Account;
using LearnApp.Services.Navigation;
using LearnApp.Services.Register;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace LearnApp.PageModels
{
    public class RegisterPageModel : PageModelBase
    {
        private string _email;
        public string Email
        {
            get => _email;
            set => SetProperty(ref _email, value);
        }
        private string _password;

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        private string _passwordTwo;

        public string PasswordTwo
        {
            get => _passwordTwo;
            set => SetProperty(ref _passwordTwo, value);
        }


        private ICommand _registerInCommand;
        public ICommand RegisterInCommand
        {
            get => _registerInCommand;
            set => SetProperty(ref _registerInCommand, value);
        }

        private INavigationService _navigationService;
        private IRegisterService _registerService;

        public RegisterPageModel(INavigationService navigationService, IRegisterService registerService)
        {
            _navigationService = navigationService;
            _registerService = registerService;
            _registerInCommand = new Command(RegisterIn);
        }
        public override async Task InitializeAsync(object navigationDate)
        {
            await base.InitializeAsync(navigationDate);
        }
        string[] easyPass = new string[] { "123","1","2","3","4","password", "qwerty", "12345", "123456789", "987654321", "123456789zxc", "123456789qwe",
                "1234qwe","1234zxc","qwerty123","qwerty321","123456","1234567","12345678","wasd123","asdqwe","qwezxc","qwertyzxc","rewqcxz",
                "dasha123","pasha123","masha123","sasha123","natasha123","vlad123","maksim123","nastya123","nikita123","danik123","1212121",
                "123123","12341234","superman","batman","ironman","spiderman","prostoiparol", "password", "password123", "legkiparol", "kizaru",
                "bigbabytape", "123123123","123412341234", "111111","1111111","11111111","111111111","1111111111","11111111111","11111111111",
                "222222", "2222222","22222222","2222222222", "22222222222", "333333","3333333","33333333","333333333","33333333333", "444444",
                "4444444","44444444","4444444444","44444444444","44444444444","444444444444","44444444444444","555555","5555555","55555555",
                "555555555", "55555555555","55555555555","555555555555","555555555555","55555555555555","666666","6666666","66666666","666666666",
                "6666666666","66666666666","666666666666","6666666666666","66666666666666","666666666666666", "777777","7777777","77777777","777777777",
                "77777777777","7777777777", "777777777777", "7777777777777", "77777777777777", "777777777777777", "77777777777777", "888888","8888888",
                "88888888", "888888888", "8888888888", "888888888888", "8888888888888", "88888888888888","888888888888888", "88888888888888888", "999999",
                "9999999", "99999999", "999999999","9999999999", "999999999999", "999999999999", "9999999999999999"};
        private async void RegisterIn(object obj)
        {
            try
            {
                if (!(Email.Trim() is null) && !(Password is null))
                {

                    if (easyPass.Contains(Password))
                    {
                        var pop = new MessageBoxPage("Ошибка!", "Пароль слишком простой!");
                        await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
                        return;
                    }
                    else
                    {
                        if (Password == PasswordTwo)
                        {
                            var registerAttempt = await _registerService.RegisterAsync(Email.Trim(), Password);
                            if (registerAttempt)
                            {
                                var item1 = await PageModelLocator.Resolve<IRepositoryLectures<DataLectures>>().Save(new DataLectures
                                {
                                    Lecture1_test = "0",
                                    Lecture2_test = "0",
                                    Lecture3_test = "0",
                                    Lecture4_test = "0",
                                    Lecture5_test = "0",
                                    Lecture6_test = "0",
                                    Lecture7_test = "0",
                                    Lecture8_test = "0",
                                    Lecture9_test = "0",
                                    Lecture10_test = "0",
                                    Lecture11_test = "0",
                                    Lecture12_test = "0",
                                    Lecture13_test = "0",
                                    Lecture14_test = "0",
                                    Lecture15_test = "0",
                                    Lecture16_test = "0",
                                    Lecture17_test = "0",
                                    Lecture18_test = "0",
                                    Lecture19_test = "0",
                                    Lecture20_test = "0",
                                    Lecture21_test = "0",
                                    Lecture22_test = "0",
                                    Lecture23_test = "0",
                                    Lecture24_test = "0",
                                    Lecture25_test = "0",
                                    Lecture26_test = "0",
                                    Lecture1_comp = "dodgerblue",
                                    Lecture2_comp = "dodgerblue",
                                    Lecture3_comp = "dodgerblue",
                                    Lecture4_comp = "dodgerblue",
                                    Lecture5_comp = "dodgerblue",
                                    Lecture6_comp = "dodgerblue",
                                    Lecture7_comp = "dodgerblue",
                                    Lecture8_comp = "dodgerblue",
                                    Lecture9_comp = "dodgerblue",
                                    Lecture10_comp = "dodgerblue",
                                    Lecture11_comp = "dodgerblue",
                                    Lecture12_comp = "dodgerblue",
                                    Lecture13_comp = "dodgerblue",
                                    Lecture14_comp = "dodgerblue",
                                    Lecture15_comp = "dodgerblue",
                                    Lecture16_comp = "dodgerblue",
                                    Lecture17_comp = "dodgerblue",
                                    Lecture18_comp = "dodgerblue",
                                    Lecture19_comp = "dodgerblue",
                                    Lecture20_comp = "dodgerblue",
                                    Lecture21_comp = "dodgerblue",
                                    Lecture22_comp = "dodgerblue",
                                    Lecture23_comp = "dodgerblue",
                                    Lecture24_comp = "dodgerblue",
                                    Lecture25_comp = "dodgerblue",
                                    Lecture26_comp = "dodgerblue",
                                });
                                var item2 = await PageModelLocator.Resolve<IRepositoryTests<DataTests>>().Save(new DataTests
                                {
                                    Test1 = "0",
                                    Test2 = "0",
                                    Test3 = "0",
                                    Test4 = "0",
                                    Test5 = "0",
                                    Test6 = "0",
                                    Test7 = "0",
                                    Test8 = "0",
                                    Test9 = "0",
                                    Test10 = "0",
                                    Test11 = "0",
                                    Test12 = "0",
                                    Test13 = "0",
                                    Test14 = "0",
                                    Test15 = "0",
                                    Test16 = "0",
                                    Test17 = "0",
                                    Test18 = "0",
                                    Test19 = "0",
                                    Test20 = "0",
                                    Test21 = "0",
                                    Test22 = "0",
                                    Test23 = "0",
                                    Test24 = "0",
                                    Test25 = "0",
                                    Test26 = "0",
                                    Test27 = "0",
                                    Test28 = "0",
                                    Test29 = "0",
                                    Test30 = "0",
                                    Test31 = "0",
                                    Test32 = "0",
                                    Test33 = "0",
                                    Test34 = "0",
                                    Test35 = "0",
                                    Test36 = "0",
                                    Test37 = "0",
                                    Test38 = "0",
                                    Test39 = "0",
                                    Test40 = "0",
                                    
                                   
                                    Task1_comp = "dodgerblue",
                                    Task2_comp = "dodgerblue",
                                    Task3_comp = "dodgerblue",
                                    Task4_comp = "dodgerblue",
                                    Task5_comp = "dodgerblue",
                                    Task6_comp = "dodgerblue",
                                    Task7_comp = "dodgerblue",
                                    Task8_comp = "dodgerblue",
                                    Task9_comp = "dodgerblue",
                                    Task10_comp = "dodgerblue",
                                    Task11_comp = "dodgerblue",
                                    Task12_comp = "dodgerblue",
                                    Task13_comp = "dodgerblue",
                                    Task14_comp = "dodgerblue",
                                    Task15_comp = "dodgerblue",
                                    Task16_comp = "dodgerblue",
                                    Task17_comp = "dodgerblue",
                                    Task18_comp = "dodgerblue",
                                    Task19_comp = "dodgerblue",
                                    Task20_comp = "dodgerblue",
                                    Task21_comp = "dodgerblue",
                                    Task22_comp = "dodgerblue",
                                    Task23_comp = "dodgerblue",
                                    Task24_comp = "dodgerblue",
                                    Task25_comp = "dodgerblue",
                                    Task26_comp = "dodgerblue",
                                    Task27_comp = "dodgerblue",
                                    Task28_comp = "dodgerblue",
                                    Task29_comp = "dodgerblue",
                                    Task30_comp = "dodgerblue",
                                    Task31_comp = "dodgerblue",
                                    Task32_comp = "dodgerblue",
                                    Task33_comp = "dodgerblue",
                                    Task34_comp = "dodgerblue",
                                    Task35_comp = "dodgerblue",
                                    Task36_comp = "dodgerblue",
                                    Task37_comp = "dodgerblue",
                                    Task38_comp = "dodgerblue",
                                    Task39_comp = "dodgerblue",
                                    Task40_comp = "dodgerblue",
                                    
                                    
                                });
                                var item4 = await PageModelLocator.Resolve<IRepositoryImTests<DataImTests>>().Save(new DataImTests
                                {
                                    Test1 = "0",
                                    Test2 = "0",
                                    Test3 = "0",
                                    Test4 = "0",
                                    Test5 = "0",
                                    Test6 = "0",
                                    Test7 = "0",
                                    Test8 = "0",
                                    Test9 = "0",
                                    Test10 = "0",
                                    Test11 = "0",
                                    Test12 = "0",
                                    Test13 = "0",
                                    Test14 = "0",
                                    Test15 = "0",
                                    Test16 = "0",
                                    Test17 = "0",
                                    Test18 = "0",
                                    Test19 = "0",
                                    Test20 = "0",
                                    Test21 = "0",
                                    Test22 = "0",
                                    Test23 = "0",
                                    Test24 = "0",
                                    Test25 = "0",
                                    Test26 = "0",
                                    Task1_comp = "dodgerblue",
                                    Task2_comp = "dodgerblue",
                                    Task3_comp = "dodgerblue",
                                    Task4_comp = "dodgerblue",
                                    Task5_comp = "dodgerblue",
                                    Task6_comp = "dodgerblue",
                                    Task7_comp = "dodgerblue",
                                    Task8_comp = "dodgerblue",
                                    Task9_comp = "dodgerblue",
                                    Task10_comp = "dodgerblue",
                                    Task11_comp = "dodgerblue",
                                    Task12_comp = "dodgerblue",
                                    Task13_comp = "dodgerblue",
                                    Task14_comp = "dodgerblue",
                                    Task15_comp = "dodgerblue",
                                    Task16_comp = "dodgerblue",
                                    Task17_comp = "dodgerblue",
                                    Task18_comp = "dodgerblue",
                                    Task19_comp = "dodgerblue",
                                    Task20_comp = "dodgerblue",
                                    Task21_comp = "dodgerblue",
                                    Task22_comp = "dodgerblue",
                                    Task23_comp = "dodgerblue",
                                    Task24_comp = "dodgerblue",
                                    Task25_comp = "dodgerblue",
                                    Task26_comp = "dodgerblue",

                                });
                                var item5 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>().Save(new DataTF
                                {
                                    Test1 = "0",
                                    Test2 = "0",
                                    Test3 = "0",
                                    Test4 = "0",
                                    Test5 = "0",
                                    Test6 = "0",
                                    Test7 = "0",
                                    Test8 = "0",
                                    Test9 = "0",
                                    Test10 = "0",
                                    Test11 = "0",
                                    Test12 = "0",
                                    Test13 = "0",
                                    Test14 = "0",
                                    Test15 = "0",
                                    Test16 = "0",
                                    Test17 = "0",
                                    Test18 = "0",
                                    Test19 = "0",
                                    Test20 = "0",
                                    Test21 = "0",
                                    Test22 = "0",
                                    Test23 = "0",
                                    Test24 = "0",
                                    Test25 = "0",
                                    Test26 = "0",
                                    Task1_comp = "dodgerblue",
                                    Task2_comp = "dodgerblue",
                                    Task3_comp = "dodgerblue",
                                    Task4_comp = "dodgerblue",
                                    Task5_comp = "dodgerblue",
                                    Task6_comp = "dodgerblue",
                                    Task7_comp = "dodgerblue",
                                    Task8_comp = "dodgerblue",
                                    Task9_comp = "dodgerblue",
                                    Task10_comp = "dodgerblue",
                                    Task11_comp = "dodgerblue",
                                    Task12_comp = "dodgerblue",
                                    Task13_comp = "dodgerblue",
                                    Task14_comp = "dodgerblue",
                                    Task15_comp = "dodgerblue",
                                    Task16_comp = "dodgerblue",
                                    Task17_comp = "dodgerblue",
                                    Task18_comp = "dodgerblue",
                                    Task19_comp = "dodgerblue",
                                    Task20_comp = "dodgerblue",
                                    Task21_comp = "dodgerblue",
                                    Task22_comp = "dodgerblue",
                                    Task23_comp = "dodgerblue",
                                    Task24_comp = "dodgerblue",
                                    Task25_comp = "dodgerblue",
                                    Task26_comp = "dodgerblue",

                                });
                               
                                var item3 = await PageModelLocator.Resolve<IRepositoryTask<DataTask>>().Save(new DataTask
                                {
                                    Task1 = "0",
                                    Task2 = "0",
                                    Task3 = "0",
                                    Task4 = "0",
                                    Task5 = "0",
                                    Task6 = "0",
                                    Task7 = "0",
                                    Task8 = "0",
                                    Task9 = "0",
                                    Task10 = "0",
                                    Task11 = "0",
                                    Task12 = "0",
                                    Task13 = "0",
                                    Task14 = "0",
                                    Task15 = "0",
                                    Task16 = "0",
                                    Task17 = "0",
                                    Task18 = "0",
                                    Task19 = "0",
                                    Task20 = "0",
                                    Task1_comp = "dodgerblue",
                                    Task2_comp = "dodgerblue",
                                    Task3_comp = "dodgerblue",
                                    Task4_comp = "dodgerblue",
                                    Task5_comp = "dodgerblue",
                                    Task6_comp = "dodgerblue",
                                    Task7_comp = "dodgerblue",
                                    Task8_comp = "dodgerblue",
                                    Task9_comp = "dodgerblue",
                                    Task10_comp = "dodgerblue",
                                    Task11_comp = "dodgerblue",
                                    Task12_comp = "dodgerblue",
                                    Task13_comp = "dodgerblue",
                                    Task14_comp = "dodgerblue",
                                    Task15_comp = "dodgerblue",
                                    Task16_comp = "dodgerblue",
                                    Task17_comp = "dodgerblue",
                                    Task18_comp = "dodgerblue",
                                    Task19_comp = "dodgerblue",
                                    Task20_comp = "dodgerblue",
                                    Task1_answer = "",
                                    Task2_answer = "",
                                    Task3_answer = "",
                                    Task4_answer = "",
                                    Task5_answer = "",
                                    Task6_answer = "",
                                    Task7_answer = "",
                                    Task8_answer = "",
                                    Task9_answer = "",
                                    Task10_answer = "",
                                    Task11_answer = "",
                                    Task12_answer = "",
                                    Task13_answer = "",
                                    Task14_answer = "",
                                    Task15_answer = "",
                                    Task16_answer = "",
                                    Task17_answer = "",
                                    Task18_answer = "",
                                    Task19_answer = "",
                                    Task20_answer = "",

                                });
                                var pop = new MessageBoxPage("Почта", "Мы отправили вам письмо на почту!");
                                await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
                                _registerService.SendEmail();
                                await App.Current.MainPage.Navigation.PopAsync();
                            }
                            else
                            {
                                var pop = new MessageBoxPage("Ошибка!", "Произошла ошибка регистрации! \nВозможно отсутствует подключение к интернету либо такая почта уже зарегистрированна или введена некорректно!");
                                await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
                            }
                        }
                        else
                        {
                            var pop = new MessageBoxPage("Ошибка!", "Пароли не совпадают!");
                            await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
                        }
                    }
                }
                else
                {
                    var pop = new MessageBoxPage("Ошибка!", "Вы не ввели Email или Пароль!");
                    await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
                }
            }
            catch(Exception ex) {
                var pop = new MessageBoxPage("Ошибка!", "Вы не ввели Email или Пароль!");
                await App.Current.MainPage.Navigation.PushPopupAsync(pop, true);
                Console.WriteLine(ex.Message);
            }

        }
    }
}
