using LearnApp.PageModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.PageModels
{
    public class DashBoardGerPageModel : PageModelBase
    {
        private LecturesGerPageModel _lecturePM;
        public LecturesGerPageModel LecturesGerPageModel
        {
            get => _lecturePM;
            set => SetProperty(ref _lecturePM, value);
        }
        private TestsGerPageModel _testPM;
        public TestsGerPageModel TestsGerPageModel
        {
            get => _testPM;
            set => SetProperty(ref _testPM, value);
        }

        private TaskGerPageModel _taskPM;
        public TaskGerPageModel TaskGerPageModel
        {
            get => _taskPM;
            set => SetProperty(ref _taskPM, value);
        }
        private SettingsPageModel _settingsPM;
        public SettingsPageModel SettingsPageModel
        {
            get => _settingsPM;
            set => SetProperty(ref _settingsPM, value);
        }
        public DashBoardGerPageModel(LecturesGerPageModel lecturePM, TestsGerPageModel testPM,
            TaskGerPageModel taskPM, SettingsPageModel settingsPM)
        {
            LecturesGerPageModel = lecturePM;
            TestsGerPageModel = testPM;
            TaskGerPageModel = taskPM;
            SettingsPageModel = settingsPM;
        }
        public override Task InitializeAsync(object navigationDate)
        {
            return Task.WhenAny(base.InitializeAsync(navigationDate),
                LecturesGerPageModel.InitializeAsync(null),
                TestsGerPageModel.InitializeAsync(null),
                TaskGerPageModel.InitializeAsync(null),
                SettingsPageModel.InitializeAsync(null));
        }
    }
}
