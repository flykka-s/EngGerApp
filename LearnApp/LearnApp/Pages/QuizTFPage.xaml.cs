using LearnApp.Models;
using LearnApp.PageModels.Base;
using LearnApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuizTFPage : ContentPage
    {
        TF gameManager;
        int contV = 0;

        public QuizTFPage(TF test)
        {
            InitializeComponent();
            gameManager = test;
            gameManager.currentindexquestion = 0;
            gameManager.currentQuestion = gameManager.Questions[0];
            gameManager.CorrectCount = 0;
            gameManager.WrongCount = 0;
            count.Text = $"{contV}/15";
            updateView();
        }

        private async void But_Clicked(object sender, EventArgs e)
        {
            Boolean answer = false;    
            Button btn = (Button)sender;
            correctLabel.Text = "";
            correctText.Text = "";
            correctLabel.IsVisible = false;
            correctText.IsVisible = false;
            switch (btn.StyleId)
            {
                case "1":
                    answer = gameManager.checkAnswer(But1.Text);
                    if (answer)
                    {
                        correctLabel.IsVisible = true;
                        correctLabel.Text = $"{gameManager.getCurrentQuestion().answer}";
                        But5.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        correctLabel.TextColor = Color.LightGreen;
                    }
                    else
                    {
                        correctLabel.IsVisible = true;
                        correctText.IsVisible = true;
                        correctLabel.Text = $"Правильный ответ: {gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But5.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        correctLabel.TextColor = Color.Red;
                    }
                    if (gameManager.currentindexquestion == gameManager.Questions.Count - 1 && answer)
                    {

                        correctLabel.IsVisible = true;
                        
                        correctLabel.Text = $"{gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But6.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        But5.IsVisible = false;
                        correctLabel.TextColor = Color.LightGreen;


                    }
                    else if (gameManager.currentindexquestion == gameManager.Questions.Count - 1 && answer == false)
                    {

                        correctLabel.IsVisible = true;
                        correctText.IsVisible = true;
                        correctLabel.Text = $"Правильный ответ: {gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But6.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        But5.IsVisible = false;
                        correctLabel.TextColor = Color.Red;
                    }
                    break;
                case "2":
                    answer = gameManager.checkAnswer(But2.Text);
                    if (answer)
                    {

                        correctLabel.IsVisible = true;
                        correctLabel.Text = $"{gameManager.getCurrentQuestion().answer}";
                        But5.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        correctLabel.TextColor = Color.LightGreen;
                    }
                    else
                    {

                        correctLabel.IsVisible = true;
                        correctText.IsVisible = true;
                        correctLabel.Text = $"Правильный ответ: {gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But5.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        correctLabel.TextColor= Color.Red;
                    }
                    if (gameManager.currentindexquestion == gameManager.Questions.Count - 1 && answer)
                    {

                        correctLabel.IsVisible = true;
                        correctLabel.Text = $"{gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But6.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        But5.IsVisible = false;
                        correctLabel.TextColor = Color.LightGreen;

                    }
                    else if (gameManager.currentindexquestion == gameManager.Questions.Count - 1 && answer == false)
                    {

                        correctLabel.IsVisible = true;
                        correctText.IsVisible = true;
                        correctLabel.Text = $"Правильный ответ: {gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But6.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        But5.IsVisible = false;
                        correctLabel.TextColor = Color.Red;
                    }
                    break;
                case "3":
                    answer = gameManager.checkAnswer(But3.Text);
                    if (answer)
                    {

                        correctLabel.IsVisible = true;
                        correctLabel.Text = $"{gameManager.getCurrentQuestion().answer}";
                        But5.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        correctLabel.TextColor = Color.LightGreen;
                    }
                    else
                    {

                        correctLabel.IsVisible = true;
                        correctText.IsVisible = true;
                        correctLabel.Text = $"Правильный ответ: {gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But5.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        correctLabel.TextColor = Color.Red;
                    }
                    if (gameManager.currentindexquestion == gameManager.Questions.Count - 1 && answer)
                    {

                        correctLabel.IsVisible = true;
                        correctLabel.Text = $"{gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But6.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        But5.IsVisible = false;
                        correctLabel.TextColor = Color.LightGreen;
                    }
                    else if (gameManager.currentindexquestion == gameManager.Questions.Count - 1 && answer == false)
                    {

                        correctLabel.IsVisible = true;
                        correctText.IsVisible = true;
                        correctLabel.Text = $"Правильный ответ: {gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But6.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        But5.IsVisible = false;
                        correctLabel.TextColor = Color.Red;
                    }
                    break;
                case "4":
                    answer = gameManager.checkAnswer(But4.Text);
                    if (answer)
                    {

                        correctLabel.IsVisible = true;
                        correctLabel.Text = $"{gameManager.getCurrentQuestion().answer}";
                        But5.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        correctLabel.TextColor = Color.LightGreen;
                    }
                    else
                    {

                        correctLabel.IsVisible = true;
                        correctText.IsVisible = true;
                        correctLabel.Text = $"Правильный ответ: {gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But5.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        correctLabel.TextColor = Color.Red;
                    }
                    if (gameManager.currentindexquestion == gameManager.Questions.Count - 1 && answer)
                    {

                        correctLabel.IsVisible = true;
                        correctLabel.Text = $"{gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But6.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        But5.IsVisible = false;
                        correctLabel.TextColor = Color.LightGreen;

                    }
                    else if (gameManager.currentindexquestion == gameManager.Questions.Count - 1 && answer == false)
                    {

                        correctLabel.IsVisible = true;
                        correctText.IsVisible = true;
                        correctLabel.Text = $"Правильный ответ: {gameManager.getCurrentQuestion().answer}";
                        correctText.Text = gameManager.getCurrentQuestion().textAnswer;
                        But6.IsVisible = true;
                        But2.IsEnabled = false;
                        But1.IsEnabled = false;
                        But3.IsEnabled = false;
                        But4.IsEnabled = false;
                        But5.IsVisible = false;
                        correctLabel.TextColor = Color.Red;
                    }
                    break;
                case "5":
                    gameManager.generateQuestion();
                    updateView();
                    But5.IsVisible = false;
                    But2.IsEnabled = true;
                    But1.IsEnabled = true;
                    But3.IsEnabled = true;
                    But4.IsEnabled = true;
                    break;
                case "6":
                    switch (gameManager.TestNumber)
                    {
                        case "1":
                            var item1 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test1 = gameManager.CorrectCount.ToString(),
                                    Task1_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "2":
                            var item2 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test2 = gameManager.CorrectCount.ToString(),
                                    Task2_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;

                        case "3":
                            var item3 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test3 = gameManager.CorrectCount.ToString(),
                                    Task3_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "4":
                            var item4 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test4 = gameManager.CorrectCount.ToString(),
                                    Task4_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "5":
                            var item5 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test5 = gameManager.CorrectCount.ToString(),
                                    Task5_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;

                        case "6":
                            var item6 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test6 = gameManager.CorrectCount.ToString(),
                                    Task6_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "7":
                            var item7 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test7 = gameManager.CorrectCount.ToString(),
                                    Task7_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "8":
                            var item8 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test8 = gameManager.CorrectCount.ToString(),
                                    Task8_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;

                        case "9":
                            var item9 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test9 = gameManager.CorrectCount.ToString(),
                                    Task9_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "10":
                            var item10 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test10 = gameManager.CorrectCount.ToString(),
                                    Task10_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;

                        case "11":
                            var item11 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test11 = gameManager.CorrectCount.ToString(),
                                    Task11_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "12":
                            var item12 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test2 = gameManager.CorrectCount.ToString(),
                                    Task2_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;

                        case "13":
                            var item13 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test13 = gameManager.CorrectCount.ToString(),
                                    Task13_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "14":
                            var item14 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test14 = gameManager.CorrectCount.ToString(),
                                    Task14_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "15":
                            var item15 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test15 = gameManager.CorrectCount.ToString(),
                                    Task15_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;

                        case "16":
                            var item16 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test16 = gameManager.CorrectCount.ToString(),
                                    Task16_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "17":
                            var item17 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test17 = gameManager.CorrectCount.ToString(),
                                    Task17_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                        case "18":
                            var item18 = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>()
                                .Update(new DataTF
                                {
                                    Test18 = gameManager.CorrectCount.ToString(),
                                    Task18_comp = gameManager.CorrectCount == 15 ? "dodgerblue" : "dodgerblue"
                                });
                            break;
                    }
                    questionText.Text = $"Вы ответили правильно на {gameManager.CorrectCount} из 15";
                    AnswerBut.IsVisible = false;
                    AnswerField.IsVisible = false;
                    image.IsVisible = true;
                    But5.IsVisible = false;
                    But6.IsVisible = false;
                    But7.IsVisible = true;
                    count.IsVisible = false;

                    break;
                case "7":
                    await App.Current.MainPage.Navigation.PopAsync();
                    break;
            }
           
        }

        private void updateView()
        {
            contV += 1;
            count.Text = $"{contV}/15";
            But1.Text = gameManager.getCurrentQuestion().getAnswerArray()[0].ToString();
                But2.Text = gameManager.getCurrentQuestion().getAnswerArray()[1].ToString();
                But3.Text = gameManager.getCurrentQuestion().getAnswerArray()[2].ToString();
                But4.Text = gameManager.getCurrentQuestion().getAnswerArray()[3].ToString();

                questionText.Text = gameManager.getCurrentQuestion().getQuestionPhrase();

                //correctLabel.Text = "Correct = " + gameManager.CorrectCount;
                //wrongLabel.Text = "Wrong = " + gameManager.WrongCount;
           
           
        }
    }
}