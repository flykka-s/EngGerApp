using LearnApp.Models;
using LearnApp.PageModels.Base;
using LearnApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace LearnApp.PageModels.Data
{
    public static class TaskData
    {
        public static async Task<ObservableRangeCollection<Task_>> GetDataAsync()
        {
            var task = new ObservableRangeCollection<Task_>();
            var item = await PageModelLocator.Resolve<IRepositoryTask<DataTask>>().Get("Id");
            
            task.Add(new Task_
            {
                Chapter = "Глава 1",
                Aswer = "Semi-detached house",
                TextTask = "Переведите фразу ''Дом, имеющий общую стену с соседним домом''",
                Complited = item.Task1_comp,
                TaskNumber = "1",
                AnswerText = item.Task1_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 1",
                Aswer = "A guaranteed right to education",
                TextTask = "Переведите фразу ''Гарантированное право на образование''",
                Complited = item.Task2_comp,
                TaskNumber = "2",
                AnswerText = item.Task2_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 1",
                Aswer = "Immerse yourself in something ",
                TextTask = "Переведите фразу ''Погрузиться во что-либо''",
                Complited = item.Task3_comp,
                TaskNumber = "3",
                AnswerText = item.Task3_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 1",
                Aswer = "To influence the climate",
                TextTask = "Переведите фразу \"Влиять на климат\"",
                Complited = item.Task4_comp,
                TaskNumber = "4",
                AnswerText = item.Task4_answer
            });

            task.Add(new Task_
            {
                Chapter = "Глава 1",
                Aswer = "To go hitchhiking",
                TextTask = "Переведите фразу \"Отправиться в путешествие автостопом\"",
                Complited = item.Task5_comp,
                TaskNumber = "5",
                AnswerText = item.Task5_answer
            });

            task.Add(new Task_
            {
                Chapter = "Глава 1",
                Aswer = "Plough through something",
                TextTask = "Переведите фразу \"Осилить что-либо\"",
                Complited = item.Task6_comp,
                TaskNumber = "6",
                AnswerText = item.Task6_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 2",
                Aswer = "die Ausbildungsmoglichkeit",
                TextTask = "Переведите фразу \"Возможность для получения образования\"",
                Complited = item.Task7_comp,
                TaskNumber = "7",
                AnswerText = item.Task7_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 2",
                Aswer = "die allgemeinbildende Schule",
                TextTask = "Переведите фразу \"Общеобразовательная школа\"",
                Complited = item.Task8_comp,
                TaskNumber = "8",
                AnswerText = item.Task8_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 2",
                Aswer = "sich auf die Klassenarbeit vorbereiten",
                TextTask = "Переведите фразу \"Подготовиться к контрольной работе\"",
                Complited = item.Task9_comp,
                TaskNumber = "9",
                AnswerText = item.Task9_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 2",
                Aswer = "das Fernsehen bevorzugen",
                TextTask = "Переведите фразу \"Отдавать предпочтение телевиденью\"",
                Complited = item.Task10_comp,
                TaskNumber = "10",
                AnswerText = item.Task10_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 2",
                Aswer = "die Kommunikationsfahigkeit",
                TextTask = "Переведите фразу \"Умение общаться\"",
                Complited = item.Task11_comp,
                TaskNumber = "11",
                AnswerText = item.Task11_answer
            });

            task.Add(new Task_
            {
                Chapter = "Глава 2",
                Aswer = "in schlechten Verhältnissen aufwachsen",
                TextTask = "Переведите фразу \"Вырастать в плохих условиях\"",
                Complited = item.Task12_comp,
                TaskNumber = "12",
                AnswerText = item.Task12_answer
            });
            task.Add(new Task_
            {
                Chapter = "Глава 2",
                Aswer = "Право на что-либо",
                TextTask = "Переведите фразу \"das Recht auf etwas (Akk.)\"",
                Complited = item.Task13_comp,
                TaskNumber = "13",
                AnswerText = item.Task13_answer
            });
            //task.Add(new Task_
            //{
            //    Chapter = "Глава 1",
            //    Aswer = "int[][] a = new int[444][4];",
            //    TextTask = "Объявите целочисленный зубчатый массив \"a\" c количеством элементов по горизонтали 444 и 4 по вертикали.",
            //    Complited = item.Task4_comp,
            //    TaskNumber = "4",
            //    AnswerText = item.Task4_answer
            //});
            //task.Add(new Task_
            //{
            //    Chapter = "Глава 1",
            //    Aswer = "int[] a = new int[4];\nfor(int i = 0; i < a.Lenght; i++)\n{\nConsole.WriteLine(a[i]);\n}",
            //    TextTask = "Объявите целочисленный массив \"a\" c количеством элементов 4. Выведите его на экран в формате \n1\n2\n3\n4.",
            //    Complited = item.Task5_comp,
            //    TaskNumber = "5",
            //    AnswerText = item.Task5_answer
            //});
            return task;
        }
    }
}
