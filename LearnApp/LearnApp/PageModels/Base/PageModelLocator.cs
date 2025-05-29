using LearnApp.Models;
using LearnApp.PageModels.test;
using LearnApp.Pages;
using LearnApp.Services;
using LearnApp.Services.Account;
using LearnApp.Services.Navigation;
using LearnApp.Services.Register;
using System;
using System.Collections.Generic;
using System.Text;
using TinyIoC;
using Xamarin.Forms;

namespace LearnApp.PageModels.Base
{
    public class PageModelLocator
    {
        static TinyIoCContainer _container;
        static Dictionary<Type, Type> _viewLookup;

        static PageModelLocator()
        {
            _container = new TinyIoCContainer();
            _viewLookup = new Dictionary<Type, Type>();

            // Register pages and page models
            Register<LoginPageModel, LoginPage>();
            Register<RegisterPageModel, RegisterPage>();
            Register<DashBoardPageModel, DashBoardPage>();
            Register<LecturesPageModel, LecturesPage>();
            Register<TestsPageModel, TestsPage>();
            Register<TFPageModel, TFPage>();
            Register<TestsMissPageModel, TestsMissPage>();
            Register<TestsImPageModel, TestsImPage>();
            Register<StatisticsPageModel, StatisticsPage>();
            Register<SettingsPageModel, SettingsPage>();
            Register<LecturePModel, LectureP>();
            Register<QuizPageModel, QuizPage>();
            Register<QuizTrueFalsePageModel, QuizTrueFalsePage>();
            Register<ChoicePageModel, ChoicePage>();
            Register<BeginPageModel, BeginPage>();
            Register<LoginPhoneModel, LoginPhonePage>();
            Register<SendEmailResetPasswordModel, SendEmailResetPassword>();
            Register<QuizTrueFalsePageBeginModel, QuizTrueFalsePage>();
            Register<QuizPageBeginModel, QuizPageBegin>();
            Register<TaskPageModel, TaskPage>();
            Register<SelectPageModel, SelectPage>();
            Register<DashBoardGerPageModel, DashBoardPageGer>();
            Register<LecturesGerPageModel, LecturesGerPage>();
            Register<TestsGerPageModel, TestsGerPage>();
            Register<TaskGerPageModel, TaskGerPage>();
            Register<TFGerPageModel, TFGerPage>();
            // Register services (services  are registered as Singletons default)
            _container.Register<INavigationService, NavigationService>();
            _container.Register<IAccountService>(DependencyService.Get<IAccountService>());
            _container.Register<IRegisterService>(DependencyService.Get<IRegisterService>());
            _container.Register(DependencyService.Get<IRepositoryLectures<DataLectures>>());
            _container.Register(DependencyService.Get<IRepositoryTests<DataTests>>());
            _container.Register(DependencyService.Get<IRepositoryImTests<DataImTests>>());
            _container.Register(DependencyService.Get<IRepositoryTask<DataTask>>());
            _container.Register(DependencyService.Get<IRepositoryTF<DataTF>>());
            
        }


        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>(); // Метод разрешения страницы после загрузки в контейнер
        }

        public static Page CreatePageFor(Type pageModelType)
        {
            var pageType = _viewLookup[pageModelType]; // Получение страницы по модели
            var page = (Page)Activator.CreateInstance(pageType); // Создание активатора(зависимости)
            var pageModel = _container.Resolve(pageModelType); // Разрешение модели страницы
            page.BindingContext = pageModel;
            return page;
        }

        static void Register<TPageModel, TPage>() where TPageModel : PageModelBase where TPage : Page
        {
            _viewLookup.Add(typeof(TPageModel), typeof(TPage)); // Регистрация модели страницы с самой страницей
            _container.Register<TPageModel>(); // Регистрация модели в контейнере
        }
    }
}
