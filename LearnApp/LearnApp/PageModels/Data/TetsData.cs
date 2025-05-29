using Java.Lang.Annotation;
using LearnApp.Models;
using LearnApp.PageModels.Base;
using LearnApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace LearnApp.PageModels.Data
{
    public static class TetsData
    {
        public static async Task<ObservableRangeCollection<Test>> GetDataAsync()
        {
            var Test = new ObservableRangeCollection<Test>();
            var item = await PageModelLocator.Resolve<IRepositoryTests<DataTests>>().Get("Id");

            Question[] questionsArrayhouse = {
                new Question { text = "Слово ''Hostel'' означает:", answer = "Общежитие", textAnswer="",answerArray=new string[4] { "Квартира", "Отдельно стоящий дом", "Общежитие", "Многоэтажка" }  },
                new Question { text = "Словосочетание ''Block of flats'' означает:", answer = "Многоэтажка", textAnswer="", answerArray=new string[4] { "Многоэтажка", "Общежитие", "Средняя школа", "Чердак" } },
                new Question { text = "Слово ''Крошечный'' на английском:", answer = "Tiny", textAnswer="", answerArray=new string[4] { "Light", "Tiny", "Shower", "Attic" }  },
                new Question { text = "Слово ''Bungalow'' означает:", answer = "Одноэтажный небольшой домик", textAnswer="", answerArray=new string[4] { "Туалет", "Гостинная", "Снимать (квартиру и т.п.)", "Одноэтажный небольшой домик" }  },
                new Question { text = "Слово ''Nursery'' означает:", answer = "Детская комната", textAnswer="", answerArray=new string[4] { "Детский сад", "Детская комната", "Ванная", "Подвал" }  },
                new Question { text = "Слово ''Спальня'' на английском:", answer = "Bedroom", textAnswer="", answerArray=new string[4] { "Bedroom", "Dining room", "Bathroom", "Kitchen" }  },
                new Question { text = "Словосочетание ''On the outskirts'' означает:", answer = "На окраине", textAnswer="", answerArray=new string[4] { "Рядом с", "Прямо в центре", "В пригороде", "На окраине" }  },
                new Question { text = "Слово ''Share'' означает:", answer = "Делиться", textAnswer="", answerArray=new string[4] { "Делиться", "Шумный", "Просторный", "Светлый" }  },
                new Question { text = "Слово ''Камин'' на английском:", answer = "Fireplace", textAnswer="", answerArray=new string[4] { "Cooker", "Freezer", "Fireplace", "Electricity" }  },
                new Question { text = "Словосочетание ''Стиральная машина'' на английском:", answer = "Washing machine", textAnswer="", answerArray=new string[4] { "Comfy chair", "Washing machine", "Water supply", "Central heating" }  },
                new Question { text = "Слово ''Freezer'' означает:", answer = "Морозильник", textAnswer="",answerArray=new string[4] { "Морозильник", "Холодильник", "Холод", "Жара" }  },
                new Question { text = "Слово ''Carpet'' означает:", answer = "Ковёр", textAnswer="", answerArray=new string[4] { "Раковина", "Кресло", "Зеркало", "Ковёр" } },
                new Question { text = "Слово ''Кран'' на английском:", answer = "Tap", textAnswer="", answerArray=new string[4] { "Cooker", "Carpet", "Sink", "Tap" }  },
                new Question { text = "Словосочетание ''Detached house'' означает:", answer = "Отдельно стоящий дом", textAnswer="", answerArray=new string[4] { "Отдельно стоящий дом", "Многоэтажка", "Квартира", "Одноэтажный дом" } },
                new Question { text = "Слово ''Шумный'' на английском:", answer = "Noisy", textAnswer="", answerArray=new string[4] { "Tiny", "Noisy", "Quiet", "Huge" }  },
                new Question { text = "Слово ''Attic'' означает:", answer = "Чердак", textAnswer="", answerArray=new string[4] { "Гостинная", "На окраине", "Чердак", "Кухня" }  },
                new Question { text = "Слово ''Shower'' означает:", answer = "Душ", textAnswer="", answerArray=new string[4] { "Спальня", "Ванная", "Кабинет", "Душ" }  },
                new Question { text = "Словосочетание ''Система охлаждения'' на английском:", answer = "Cooling", textAnswer="", answerArray=new string[4] { "Water supply", "Central heating", "Cooling", "Ceiling" }  },
                new Question { text = "Словосочетание ''Comfy chair'' означает:", answer = "Кресло", textAnswer="", answerArray=new string[4] { "Кран", "Телевизор", "Диван", "Кресло" }  },
                new Question { text = "Слово ''Floor'' означает:", answer = "Пол", textAnswer="", answerArray=new string[4] { "Пол", "Потолок", "Стена", "Дверь" }  },
                new Question { text = "Слово ''Холодильник'' на английском:", answer = "Fridge", textAnswer="", answerArray=new string[4] { "Mirror", "Frezze", "Freezer", "Fridge" }  },
                new Question { text = "Слово ''Sink'' означает:", answer = "Раковина", textAnswer="",answerArray=new string[4] { "Раковина", "Кран", "Окно", "Дверь" }  },
                new Question { text = "Слово ''Electricity'' означает:", answer = "Электричество", textAnswer="", answerArray=new string[4] { "Электронный", "Зеркало", "Ковёр", "Электричество" } },
                new Question { text = "Слово ''Прямо в центре'' на английском:", answer = "Right in the center", textAnswer="", answerArray=new string[4] { "Rent", "In the suburbs", "On the outskirts", "Right in the center" }  },



                };

            Question[] questionsArrayeduc = {
                new Question { text = "Слово ''Education'' означает:", answer = "Образование", textAnswer="",answerArray=new string[4] { "Гражданин", "Образование", "Обеспечивать", "Детский сад" }  },
                new Question { text = "Словосочетание ''Primary school'' означает:", answer = "Начальная школа", textAnswer="", answerArray=new string[4] { "Начальная школа", "Высшая школа", "Средняя школа", "Ясли" } },
                new Question { text = "Слово ''Директор'' на английском:", answer = "Headmaster", textAnswer="", answerArray=new string[4] { "Term", "Headmaster", "Grades", "Kindergarten" }  },
                new Question { text = "Слово ''Institution'' означает:", answer = "Учреждение", textAnswer="", answerArray=new string[4] { "Средняя школа", "Институт", "Лицей", "Учреждение" }  },
                new Question { text = "Слово ''Kindergarten'' означает:", answer = "Детский сад", textAnswer="", answerArray=new string[4] { "Детский сад", "Средняя школа", "Каникулы", "Стипендия" }  },
                new Question { text = "Слово ''Поступить'' на английском:", answer = "Enter", textAnswer="", answerArray=new string[4] { "Occupy", "Canteen", "Enter", "Break" }  },
                new Question { text = "Словосочетание ''Cloak-room'' означает:", answer = "Гардероб", textAnswer="", answerArray=new string[4] { "Гардероб", "Столовая", "Кабинет директора", "Класс" }  },
                new Question { text = "Слово ''Library'' означает:", answer = "Библиотека", textAnswer="", answerArray=new string[4] { "Библиотека", "Куратор", "Староста", "Предмет" }  },
                new Question { text = "Слово ''Куратор'' на английском:", answer = "Tutor", textAnswer="", answerArray=new string[4] { "Headmaster", "Subject", "Monitor", "Tutor" }  },
                new Question { text = "Фраза ''Общая средняя школа'' на английском:", answer = "General secondary school", textAnswer="", answerArray=new string[4] { "A guaranteed right to education", "General secondary school", "Primary school", "Basic school" }  },
                new Question { text = "Фраза ''Free of charge'' означает:", answer = "Бесплатный", textAnswer="",answerArray=new string[4] { "Гражданин", "Кабинет директора", "Обеспечивать", "Бесплатный" }  },
                new Question { text = "Слово ''Lyceum'' означает:", answer = "Лицей", textAnswer="", answerArray=new string[4] { "Лицей", "Высшая школа", "Средняя школа", "Гимназия" } },
                new Question { text = "Аббревиатура ''ГГАЭК'' на английском:", answer = "Gomel State Agro-Economic College", textAnswer="", answerArray=new string[4] { "Nursery", "Gomel State Agro-Economic College", "Double period", "Kindergarten" }  },
                new Question { text = "Слово ''Gym'' означает:", answer = "Спортзал", textAnswer="", answerArray=new string[4] { "Колледж", "Институт", "Библиотека", "Спортзал" }  },
                new Question { text = "Слово ''Citizen'' означает:", answer = "Гражданин", textAnswer="", answerArray=new string[4] { "Гражданин", "Директор", "Куратор", "Староста" }  },
                new Question { text = "Слово ''Stipend'' означает:", answer = "Стипендия", textAnswer="",answerArray=new string[4] { "Студент", "Стипендиат", "Стипендия", "Куратор" }  },
                new Question { text = "Словосочетание ''A first year student'' означает:", answer = "Первокурсник", textAnswer="", answerArray=new string[4] { "Студент", "Первокурсник", "Заканчивающий обучение", "Второкурсник" } },
                new Question { text = "Слово ''Каникулы'' на английском:", answer = "Vacation", textAnswer="", answerArray=new string[4] { "Nursery", "Gymnasium", "Double period", "Vacation" }  },
                new Question { text = "Слово ''Canteen'' означает:", answer = "Столовая", textAnswer="", answerArray=new string[4] { "Столовая", "Буфет", "Перерыв", "Кабинет" }  },
                new Question { text = "Слово ''Library'' означает:", answer = "Библиотека", textAnswer="", answerArray=new string[4] { "Спортзал", "Кабинет", "Библиотека", "Актовый зал" }  },
                new Question { text = "Слово ''Староста'' на английском:", answer = "Monitor", textAnswer="", answerArray=new string[4] { "Subject", "Teacher", "Tutor", "Monitor" }  },
                new Question { text = "Словосочетание ''Gomel State Agro-Economic College'' означает:", answer = "ГГАЭК", textAnswer="", answerArray=new string[4] { "ГГАЭК", "ЮНЭСКО", "МТЗ", "R2D2" }  },
                new Question { text = "Слово ''Occupy'' означает:", answer = "Занимать", textAnswer="", answerArray=new string[4] { "Занимать", "Частный", "Государственный", "Поступить" }  },
                new Question { text = "Слово ''Успешно'' на английском:", answer = "Successfully", textAnswer="", answerArray=new string[4] { "Congratulations", "Canteen", "Successfully", "Break" }  },
                new Question { text = "Словосочетание ''Сдавать экзамены (процесс)'' на английском:", answer = "Take exams", textAnswer="", answerArray=new string[4] { "State-owned", "Take exams", "Be situated", "Pass exams" }  },
                new Question { text = "Словосочетание ''Assembly hall'' означает:", answer = "Актовый зал", textAnswer="",answerArray=new string[4] { "Актовый зал", "Спортзал", "Библиотека", "Кабинет" }  },
                new Question { text = "Слово ''Subject'' означает:", answer = "Предмет", textAnswer="", answerArray=new string[4] { "Директор", "Куратор", "Староста", "Предмет" } },
                new Question { text = "Слово ''Пара'' на английском:", answer = "Double period", textAnswer="", answerArray=new string[4] { "Double time", "Part-time", "Headmaster’s office", "Double period" }  },


                
            };

            Question[] questionsArraymass = {
                new Question { text = "Слово ''Mass media'' означает:", answer = "Средства массовой информации", textAnswer="",answerArray=new string[4] { "Средства массовой информации", "Событие", "Сообщать", "Источник" }  },
                new Question { text = "Слово ''Disaster'' означает:", answer = "Бедствие", textAnswer="", answerArray=new string[4] { "СМИ", "Бедствие", "Печатать", "Авария" } },
                new Question { text = "Слово ''Источник'' на английском:", answer = "Source", textAnswer="", answerArray=new string[4] { "Advertisement", "Series", "Influence", "Source" }  },
                new Question { text = "Слово ''Tabloid'' означает:", answer = "Небольшая газета", textAnswer="", answerArray=new string[4] { "Статья", "Заголовок", "Небольшая газета", "Реклама" }  },
                new Question { text = "Словосочетание ''Chat show'' означает:", answer = "Ток шоу", textAnswer="", answerArray=new string[4] { "Мультфильм", "Прогноз погоды", "Шоу викторина", "Ток шоу" }  },
                new Question { text = "Слово ''Жестокий'' на английском:", answer = "Violent", textAnswer="", answerArray=new string[4] { "Violent", "Violence", "Valentin", "Romance" }  },
                new Question { text = "Словосочетание ''Soap opera'' означает:", answer = "Мыльная опера", textAnswer="", answerArray=new string[4] { "Триллер", "Шоу викторина", "Ток шоу", "Мыльная опера" }  },
                new Question { text = "Слово ''Cartoon'' означает:", answer = "Мультфильм", textAnswer="", answerArray=new string[4] { "Мультфильм", "Фильм", "Боевик", "Триллер" }  },
                new Question { text = "Слово ''Cообщать'' на английском:", answer = "Report", textAnswer="", answerArray=new string[4] { "Recently", "Untrue", "Report", "Ordinary" }  },
                new Question { text = "Фраза ''Что происходит?'' на английском:", answer = "What's going on?", textAnswer="", answerArray=new string[4] { "Make Headlines?", "What's going on?", "Seeing is believing?", "Half-True?" }  },
                new Question { text = "Слово ''Crash'' означает:", answer = "Авария", textAnswer="",answerArray=new string[4] { "Авария", "Событие", "Боевик", "Статья" }  },
                new Question { text = "Слово ''Terrible'' означает:", answer = "Ужасный", textAnswer="", answerArray=new string[4] { "Захватывающий", "Волнующий", "Великолепный", "Ужасный" } },
                new Question { text = "Слово ''Боевик'' на английском:", answer = "Action film", textAnswer="", answerArray=new string[4] { "Action film", "Romance", "Series", "Feature film" }  },
                new Question { text = "Словосочетание ''Cable TV'' означает:", answer = "Кабельное телевидение", textAnswer="",answerArray=new string[4] { "Кабельное телевидение", "Спутниковое телевидение", "Телевидение", "Интернет-соединение" }  },
                new Question { text = "Словосочетание ''Quiz show'' означает:", answer = "Викторина", textAnswer="", answerArray=new string[4] { "Боевик", "Викторина", "Мыльная опера", "Рекламное объявление" } },
                new Question { text = "Слово ''Новости'' на английском:", answer = "Current affairs", textAnswer="", answerArray=new string[4] { "Current affairs", "News", "Commercial", "Tabloid" }  },
                new Question { text = "Слово ''Untrue'' означает:", answer = "Ложный", textAnswer="", answerArray=new string[4] { "Недостаточный", "Правдивый", "Предпочтительный", "Ложный" }  },
                new Question { text = "Слово ''Murder'' означает:", answer = "Убийство", textAnswer="", answerArray=new string[4] { "Убийство", "Авария", "Бедствие", "Событие" }  },
                new Question { text = "Слово ''Crash'' означает:", answer = "Авария", textAnswer="", answerArray=new string[4] { "Убийство", "Авария", "Бедствие", "Событие" }  },
                new Question { text = "Словосочетание ''Make Headlines'' означает:", answer = "Попасть в заголовки", textAnswer="", answerArray=new string[4] { "Попасть в заголовки", "Источник информации", "Транслировать", "''Закулисная'' информация" }  },
                new Question { text = "Слово ''Print'' означает:", answer = "Печатать", textAnswer="", answerArray=new string[4] { "Печатать", "Влиять", "Комментировать", "Вести шоу" }  },
                new Question { text = "Слово ''Полуправдивый'' на английском:", answer = "Half-True", textAnswer="", answerArray=new string[4] { "Half-True", "Untrue", "True", "False" }  },
                new Question { text = "Слово ''Documentary'' означает:", answer = "Документальный фильм", textAnswer="",answerArray=new string[4] { "Документальный фильм", "Ток шоу", "Викторина", "Мыльная опера" }  },
                new Question { text = "Слово ''Commercial'' означает:", answer = "Реклама на ТВ", textAnswer="", answerArray=new string[4] { "Коммерция", "Реклама на ТВ", "Шоу", "Заголовок" } },
                new Question { text = "Слово ''Любимый'' на английском:", answer = "Favourite", textAnswer="", answerArray=new string[4] { "Article", "Series", "Tabloid", "Favourite" }  },



            };

            Question[] questionsArrayyouth = {
                new Question { text = "Слово ''Misunderstanding'' означает:", answer = "Непонимание", textAnswer="",answerArray=new string[4] { "Непонимание", "Понимание", "Плахая привычка", " Деятельность" }  },
                new Question { text = "Словосочетание ''Generation gap'' означает:", answer = "Проблема ''отцов и детей''", textAnswer="", answerArray=new string[4] { "Заботиться о ...", "Человек с недостатками", "Проблема ''отцов и детей''", "Включать в себя" } },
                new Question { text = "Слово ''Многочисленный'' на английском:", answer = "Numerous", textAnswer="", answerArray=new string[4] { "Society", "Aim", "Tolerance", "Promote" }  },
                new Question { text = "Слово ''Activity'' означает:", answer = "Деятельность", textAnswer="", answerArray=new string[4] { "Общество", "Терпимость", "Благотворительность", "Деятельность" }  },
                new Question { text = "Слово ''Support'' означает:", answer = "Поддержка", textAnswer="", answerArray=new string[4] { "Поддержка", "Недопонимание", "Девиз", "Терпимость" }  },
                new Question { text = "Слово ''Девиз'' на английском:", answer = "Motto", textAnswer="", answerArray=new string[4] { "Tolerance", "Motto", "Misunderstanding", "Handicapped" }  },
                new Question { text = "Слово ''Member'' означает:", answer = "Член организации", textAnswer="", answerArray=new string[4] { "Достижение", "Работник", "Организация", "Член организации" }  },
                new Question { text = "Словосочетание ''Patriotic values'' означает:", answer = "", textAnswer="", answerArray=new string[4] { "Патриотические ценности", "Нравственные ценности", "Финансовые ценности", "Ценности" }  },
                new Question { text = "Фраза ''Принимать активное участие'' на английском:", answer = "To take an active part", textAnswer="", answerArray=new string[4] { "Carry out", "To reach", "To take an active part", "Informal youth movements" }  },
                new Question { text = "Слово ''Involve'' означает:", answer = "Включать в себя", textAnswer="", answerArray=new string[4] { "Включать в себя", "Достигать", "Продвигать", "Терпимость" }  },
                new Question { text = "Слово ''Handicapped'' означает:", answer = "Человек с физическими или умственными недостатками", textAnswer="",answerArray=new string[4] { "Заботиться о …", "По моему мнению", "Человек с физическими или умственными недостатками", "Разрыв между поколениями" }  },
                new Question { text = "Словосочетание ''Point of view'' означает:", answer = "Точка зрения", textAnswer="", answerArray=new string[4] { "Ставить цель", "Точка зрения", "Продвигать", "Принимать участие" } },
                new Question { text = "Словосочетание ''Bad habits'' означает:", answer = "Плохие привычки", textAnswer="", answerArray=new string[4] { "По моему мнению", "Включать в себя", "Заботиться о …", "Плохие привычки" }  },
                new Question { text = "Слово ''Volunteer'' означает:", answer = "Доброволец", textAnswer="", answerArray=new string[4] { "Человек", "Студент", "Директор", "Доброволец" }  },
                new Question { text = "Словосочетание ''Carry out'' означает:", answer = "Выполнять", textAnswer="", answerArray=new string[4] { "Поддерживать", "Продвигать", "Выполнять", "Включать в себя" }  },
                new Question { text = "Слово ''Promote'' означает:", answer = "Продвигать", textAnswer="", answerArray=new string[4] { "Продвигать", "Поддерживать", "Выполнять", "Включать в себя" }  },
                new Question { text = "Слово ''Благотворительность'' на английском:", answer = "Charity", textAnswer="", answerArray=new string[4] { "Member", "Support", "Reach", "Charity" }  },
                new Question { text = "Слово ''Терпимость'' на английском:", answer = "Tolerance", textAnswer="", answerArray=new string[4] { "Member", "Support", "Tolerance", "Charity" }  },
                new Question { text = "Словосочетание ''Take care of'' означает:", answer = "Заботиться о …", textAnswer="",answerArray=new string[4] { "Точка зрения", "Плохие привычки", "Включать в себя", "Заботиться о …" }  },
                new Question { text = "Словосочетание ''To reach'' означает:", answer = "Достигать", textAnswer="", answerArray=new string[4] { "Поддерживать", "Выполнять", "Включать в себя", "Достигать" } },
                new Question { text = "Фраза ''Включать в себя'' на английском:", answer = "Involve", textAnswer="", answerArray=new string[4] { "To reach", "Carry out", "Involve", "Support" }  },
            };

            Question[] questionsArrayart = {
                new Question { text = "Слово ''Content'' означает:", answer = "Содержание", textAnswer="",answerArray=new string[4] { "Абстрактный", "Содержание", "Публика", "Визуальный" }  },
                new Question { text = "Слово ''Express'' означает:", answer = "Выражать", textAnswer="", answerArray=new string[4] { "Впечатлять", "Граффити", "Надпись", "Выражать" } },
                new Question { text = "Слово ''Художник'' на английском:", answer = "Artist", textAnswer="", answerArray=new string[4] { "Artist", "Author", "Painter", "Composer" }  },
                new Question { text = "Слово ''Architecture'' означает:", answer = "Архитектура", textAnswer="", answerArray=new string[4] { "Живопись", "Архитектура", "Комикс", "Мультипликация" }  },
                new Question { text = "Слово ''Exhibition'' означает:", answer = "Выставка", textAnswer="", answerArray=new string[4] { "Дизайн", "Гравюра", "Фотография", "Выставка" }  },
                new Question { text = "Слово ''Запретить'' на английском:", answer = "Ban", textAnswer="", answerArray=new string[4] { "Exhibition", "Ban", "Filmmaking", "Unique" }  },
                new Question { text = "Слово ''Spectacular'' означает:", answer = "Зрелищный", textAnswer="", answerArray=new string[4] { "Уникальный", "Узнаваемый", "Зрелищный", "Символический" }  },
                new Question { text = "Слово ''Background'' означает:", answer = "Задний план", textAnswer="", answerArray=new string[4] { "Передний план", "Выставка", "Ландшафт", "Задний план" }  },
                new Question { text = "Слово ''Гравюра'' на английском:", answer = "Printmaking", textAnswer="", answerArray=new string[4] { "Oil painting", "Design", "Drawing", "Printmaking" }  },
                new Question { text = "Слово ''Передний план'' на английском:", answer = "Foreground", textAnswer="", answerArray=new string[4] { "Foreground", "Background", "Landmark", "Recognizable" }  },
                new Question { text = "Словосочетание ''Computer art'' означает:", answer = "Компьютерная графика", textAnswer="",answerArray=new string[4] { "Производство фильмов", "Компьютерная графика", "Мультипликация", "Архитектура" }  },
                new Question { text = "Словосочетание ''Piece of art'' означает:", answer = "Произведение искусства", textAnswer="", answerArray=new string[4] { "Ландшафт", "Передний план", "Произведение искусства", "Дизайн" } },
                new Question { text = "Словосочетание ''Писатель граффити'' на английском:", answer = "Writer", textAnswer="", answerArray=new string[4] { "Painter", "Writer", "Graffiti writter", "Unique" }  },
                new Question { text = "Слово ''Recognizable'' означает:", answer = "Узнаваемый", textAnswer="",answerArray=new string[4] { "Узнаваемый", "Зрелищный", "Уникальный", "Символический" }  },
                new Question { text = "Словосочетание ''Oil painting'' означает:", answer = "Живопись", textAnswer="", answerArray=new string[4] { "Скульптура", "Дизайн", "Графика", "Живопись" } },
                new Question { text = "Слово ''Композитор'' на английском:", answer = "Composer", textAnswer="", answerArray=new string[4] { "Artist", "Composer", "Painter", "Author" }  },
                new Question { text = "Слово ''Animation'' означает:", answer = "Мультипликация", textAnswer="", answerArray=new string[4] { "Комикс", "Мультипликация", "Графика", "Композитор" }  },
                new Question { text = "Слово ''Landmark'' означает:", answer = "Ландшафт", textAnswer="", answerArray=new string[4] { "Фотография", "Фон", "Передний план", "Ландшафт" }  },
                new Question { text = "Слово ''Tag'' означает:", answer = "Надпись", textAnswer="", answerArray=new string[4] { "Граффити", "Надпись", "Изображение", "Картинка" }  },
                new Question { text = "Слово ''Enjoy -ing'' означает:", answer = "Любить что-то делать", textAnswer="", answerArray=new string[4] { "Любить что-то делать", "Иконический", "Выставка", "Нрав" }  },
                new Question { text = "Слово ''Архитектура'' на английском:", answer = "Architecture", textAnswer="", answerArray=new string[4] { "Architecture", "Exhibition", "Animation", "Sculpture" }  },
                new Question { text = "Слово ''Впечатлять'' на английском:", answer = "Impress", textAnswer="",answerArray=new string[4] { "Abstract", "Audience", "Express", "Impress" }  },
                

            };

            Question[] questionsArrayscience = {
                new Question { text = "Слово ''App'' означает:", answer = "Приложение", textAnswer="",answerArray=new string[4] { "Приложение", "Данные", "Наушники", "Всемирная паутина" }  },
                new Question { text = "Слово ''Science'' означает:", answer = "Наука", textAnswer="", answerArray=new string[4] { "Научный", "Наука", "Данные", "Ученый" } },
                new Question { text = "Слово ''Чудо'' на английском:", answer = "Wonder", textAnswer="", answerArray=new string[4] { "Vehicle", "Achievement", "Digital", "Wonder" }  },
                new Question { text = "Слово ''Take part'' означает:", answer = "Принимать участие", textAnswer="", answerArray=new string[4] { "Принимать участие", "Сельское хозяйство", "Продолжительность жизни", "Естественные науки" }  },
                new Question { text = "Слово ''Vehicle'' означает:", answer = "Транспортное cредство", textAnswer="", answerArray=new string[4] { "Наука", "Мотоцикл", "Машина", "Транспортное cредство" }  },
                new Question { text = "Слово ''Прибор'' на английском:", answer = "Device", textAnswer="", answerArray=new string[4] { "Genetic", "Invent", "Device", "Gadget" }  },
                new Question { text = "Словосочетание ''Drug abuse'' означает:", answer = "Злоупотребление наркотиками", textAnswer="", answerArray=new string[4] { "Злоупотребление наркотиками", "Цифровой", "Выдающийся / Знаменитый", "Многофункциональное устройство" }  },
                new Question { text = "Слово ''Famine'' означает:", answer = "Голод", textAnswer="", answerArray=new string[4] { "Голод", "Машиностроение", "Старомодный", "Продвинутый" }  },
                new Question { text = "Словосочетание ''Social and behavioral sciences'' означает:", answer = "Социальные и поведенческие науки", textAnswer="", answerArray=new string[4] { "Социальные и поведенческие науки", "Математические науки", "Биологические науки", "Физиологические науки" }  },
                new Question { text = "Слово ''Устройство'' на английском:", answer = "Appliance", textAnswer="", answerArray=new string[4] { "Appliance", "Gadget", "Device", "Mechanical" }  },
                new Question { text = "Слово ''Development'' означает:", answer = "Развитие", textAnswer="",answerArray=new string[4] { "Продвинутый", "Цифровой", "Открытие", "Развитие" }  },
                new Question { text = "Слово ''Mankind'' означает:", answer = "Человечество", textAnswer="", answerArray=new string[4] { "Изобретение", "Развитие", "Человечество", "Открытие" } },
                new Question { text = "Слово ''Открывать'' на английском:", answer = "Discover", textAnswer="", answerArray=new string[4] { "Discovery", "Discover", "Research", "Researcher" }  },
                new Question { text = "Слово ''Scientist'' означает:", answer = "Учёный", textAnswer="", answerArray=new string[4] { "Учёный", "Цифровой", "Научный", "Наука" }  },
                new Question { text = "Слово ''Agroculture'' означает:", answer = "Cельское хозяйство", textAnswer="",answerArray=new string[4] { "Биоорганическая химия", "Агроусадьба", "Агрокультура", "Cельское хозяйство" }  },
                new Question { text = "Словосочетание ''Old-fashioned'' означает:", answer = "Старомодный", textAnswer="", answerArray=new string[4] { "Высокоразвитый", "Высокотехнологичный", "Механический", "Старомодный" } },
                new Question { text = "Слово ''Hunger'' означает:", answer = "Голод", textAnswer="", answerArray=new string[4] { "Изобретение", "Голод", "Машиномтроение", "Голодание" }  },
                new Question { text = "Слово ''Researcher'' означает:", answer = "Исследователь", textAnswer="", answerArray=new string[4] { "Ученый", "Изучение", "Исследовать", "Исследователь" }  },
                new Question { text = "Словосочетание ''Узконаправленное устройство'' на английском:", answer = "Gadget", textAnswer="", answerArray=new string[4] { "Gadget", "Device", "Machine building", "Discover" }  },
                new Question { text = "Словосочетание ''Bioorganic сhemistry'' означает:", answer = "Биоорганическая химия", textAnswer = "", answerArray = new string[4] { "Биоорганическая химия", "Органическая химия", "Генетическая химия", "Химия" } },
                new Question { text = "Слово ''Gadget'' означает:", answer = "Устройство", textAnswer = "", answerArray = new string[4] { "Устройство", "Открытие", "Прибор", "МФУ" } },
                new Question { text = "Слово ''Изобретение'' на английском:", answer = "Invention", textAnswer = "", answerArray = new string[4] { "Invent", "Invention", "Mechanical", "Development" } },
                new Question { text = "Словосочетание ''Злоупотребление наркотиками'' на английском:", answer = "Drug abuse", textAnswer = "", answerArray = new string[4] { "Abuse", "Drug diller", "Drug abuse", "Drug" } },
                new Question { text = "Слово ''Ecology'' означает:", answer = "Экология", textAnswer = "", answerArray = new string[4] { "Точные науки", "Данные", "Экология", "Естественные науки" } },
                new Question { text = "Слово ''Data'' означает:", answer = "Данные", textAnswer = "", answerArray = new string[4] { "Точные науки", "Данные", "Экология", "Естественные науки" } },
                new Question { text = "Слово ''Web'' на английском:", answer = "Всемирная паутина", textAnswer = "", answerArray = new string[4] { "Сеть", "Локальная сеть", "Наушники", "Всемирная паутина" } },

            };



            Question[] questionsArrayfamily = {

                new Question { text = "Слово ''Parents'' означает:", answer = "Родители", textAnswer="",answerArray=new string[4] { "Сын", "Родители", "Дочь", "Братья" }  },
                new Question { text = "Слово ''Son'' означает:", answer = "Сын", textAnswer="", answerArray=new string[4] { "Сын", "Дочь", "Дядя", "Тётя" } },
                new Question { text = "Слово ''Grandson'' означает:", answer = "Внук", textAnswer="", answerArray=new string[4] { "Правнук", "Внучка", "Внук", "Правнучка" }  },
                new Question { text = "Слово ''Sibling'' означает:", answer = "Брат и сестра", textAnswer="", answerArray=new string[4] { "Братья", "Брат и сестра", "Сёстры", "Родители" }  },
                new Question { text = "Слово ''Niece'' означает:", answer = "Племянница", textAnswer="", answerArray=new string[4] { "Брат", "Племянник", "Племянница", "Сестра" }  },
                new Question { text = "Слово ''Племянник'' на английском:", answer = "Nephew", textAnswer="", answerArray=new string[4] { "Nephew", "Aunt", "Niece", "Uncle" }  },
                new Question { text = "Словосочетание ''The only child'' означает:", answer = "Единственный ребенок", textAnswer="", answerArray=new string[4] { "Двоюродный брат / сестра", "Сводная сестра", "Сводный брат", "Единственный ребенок" }  },
                new Question { text = "Слово ''Stepsister'' означает:", answer = "Сводная cестра", textAnswer="", answerArray=new string[4] { "Сводная cестра", "Двоюродный брат / сестра", "Внучка", "Сводный брат" }  },
                new Question { text = "Слово ''Жена'' на английском:", answer = "Wife", textAnswer="", answerArray=new string[4] { "Bride", "Husband", "Groom", "Wife" }  },
                new Question { text = "Словосочетание ''Муж дочери / Зять'' на английском:", answer = "Son-in-law", textAnswer="", answerArray=new string[4] { "Father-in-law", "Mother-in-law", "Daughter-in-law", "Son-in-law" }  },
                new Question { text = "Слово ''Divorced'' означает:", answer = "Разведен(а)", textAnswer="",answerArray=new string[4] { "Дальний (родственник)", "Не замужем", "Холост", "Разведен(а)" }  },
                new Question { text = "Слово ''Twins'' означает:", answer = "Близнецы", textAnswer="", answerArray=new string[4] { "Близнецы", "Дедушка и бабушка", "Родители", "Внуки" } },
                new Question { text = "Словосочетание ''Father-in-law'' означает:", answer = "Свекор / тесть", textAnswer="", answerArray=new string[4] { "Свекор / тесть", "Свекровь / теща", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Словосочетание ''Mother-in-law'' означает:", answer = "Свекровь / теща", textAnswer="", answerArray=new string[4] { "Свекор / тесть", "Свекровь / теща", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Словосочетание ''Son-in-law'' означает:", answer = "Муж дочери / зять", textAnswer="", answerArray=new string[4] { "Свекор / тесть", "Свекровь / теща", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Словосочетание ''Daughter-in-law'' означает:", answer = "Жена сына / невестка", textAnswer="", answerArray=new string[4] { "Свекор / тесть", "Свекровь / теща", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Словосочетание ''Ex-Wife'' означает:", answer = "Бывшая жена", textAnswer="",answerArray=new string[4] { "Неполная семья", "Бывшая жена", "Бывший муж", "Приемный сын" }  },
                new Question { text = "Словосочетание ''Ex-Husband'' означает:", answer = "Бывший муж", textAnswer="", answerArray=new string[4] { "Бывший муж", "Неполная семья", "Бывшая жена", "Приемная дочь" } },
                new Question { text = "Слово ''Ценить'' на английском:", answer = "Appreciate", textAnswer="", answerArray=new string[4] { "Appreciate", "Turn for help", "Tight-knit", "Get on well" }  },
                new Question { text = "Словосочетание ''Get on well'' означает:", answer = "Ладить с кем-то", textAnswer="", answerArray=new string[4] { "Ценить", "Помогать друг другу", "Семейные связи", "Ладить с кем-то" }  },
                new Question { text = "Словосочетание ''Tight-knit'' означает:", answer = "Дружная", textAnswer="", answerArray=new string[4] { "Дружная", "Ценить", "Помогать друг другу", "Семейные связи" }  },
                new Question { text = "Слово ''Холост / не замужем'' на английском:", answer = "Single / Bachelor", textAnswer="", answerArray=new string[4] { "Single / Bachelor", "Groom / Bride", "Wife / Husband", "Mother-in-law / Father-in-law" }  },
                new Question { text = "Слово ''Cousin'' означает:", answer = "Двоюродный брат / сестра", textAnswer="", answerArray=new string[4] { "Двоюродный брат / сестра", "Тётя", "Дядя", "Внучка" }  },
                new Question { text = "Слово ''Мачеха'' на английском:", answer = "Stepmother", textAnswer="", answerArray=new string[4] { "Stepmother", "Stepfather", "Stepdaughter", "Stepson" }  },
                

            };

            Question[] questionsArrayjobs = {

                new Question { text = "Слово ''Electrician'' означает:", answer = "Электрик", textAnswer="",answerArray=new string[4] { "Инженер", "Повар", "Водитель", "Электрик" }  },
                new Question { text = "Слово ''Librarian'' означает:", answer = "Библиотекарь", textAnswer="", answerArray=new string[4] { "Уборщик", "Экономист", "Библиотекарь", "Бизнесмен" } },
                new Question { text = "Слово ''Водитель'' на английском:", answer = "Driver", textAnswer="", answerArray=new string[4] { "Artist", "Banker", "Driver", "Book-Keeper" }  },
                new Question { text = "Слово ''Plumber'' означает:", answer = "Сантехник", textAnswer="", answerArray=new string[4] { "Сантехник", "Библиотекарь", "Продавец", "Кассир" }  },
                new Question { text = "Слово ''Programmer'' означает:", answer = "Программист", textAnswer="", answerArray=new string[4] { "Официант", "Уборщик", "Милиционер", "Программист" }  },
                new Question { text = "Слово ''Продавец'' на английском:", answer = "Shop-assistant", textAnswer="", answerArray=new string[4] { "Shop-assistant", "Waiter", "Engineer", "Postman" }  },
                new Question { text = "Слово ''Postman'' означает:", answer = "Почтальон", textAnswer="", answerArray=new string[4] { "Почтальон", "Инженер", "Секретарь", "Ветеринар" }  },
                new Question { text = "Слово ''Vet'' означает:", answer = "Ветеринар", textAnswer="", answerArray=new string[4] { "Милиционер", "Официант", "Ветеринар", "Сантехник" }  },
                new Question { text = "Слово ''Уборщик'' на английском:", answer = "Cleaner", textAnswer="", answerArray=new string[4] { "Engineer", "Cleaner", "Carpenter", "Secretary" }  },
                new Question { text = "Слово ''Бизнесмен'' на английском:", answer = "Businessman", textAnswer="", answerArray=new string[4] { "Businessman", "Carpenter", "Accountant", "Artist" }  },
                new Question { text = "Слово ''Cook'' означает:", answer = "Повар", textAnswer="",answerArray=new string[4] { "Повар", "Милиционер", "Библиотекарь", "Водитель" }  },
                new Question { text = "Слово ''Book-Keeper'' означает:", answer = "Бухгалтер (со средним образованием)", textAnswer="", answerArray=new string[4] { "Бухгалтер (со средним образованием)", "Бухгалтер (с высшим образованием)", "Столяр / плотник", "Энергетик" } },
                new Question { text = "Словосочетание ''Сильная cторона'' на английском:", answer = "Strength", textAnswer="", answerArray=new string[4] { "Weakness", "Salary", "Strength", "Qualified" }  },
                new Question { text = "Слово ''Career'' означает:", answer = "Карьера", textAnswer="",answerArray=new string[4] { "Карьера", "Льготы", "Требовать", "Жалованье" }  },
                new Question { text = "Слово ''Earn'' означает:", answer = "Зарабатывать", textAnswer="", answerArray=new string[4] { "Квалифицированный", "Требовать", "Сильная cторона", "Зарабатывать" } },
                new Question { text = "Словосочетание ''Слабые cтороны'' на английском:", answer = "Weakness", textAnswer="", answerArray=new string[4] { "Weakness", "Salary", "Strength", "Qualified" }  },
                new Question { text = "Слово ''Nurse'' означает:", answer = "Медсестра", textAnswer="", answerArray=new string[4] { "Медсестра", "Инженер", "Официант", "Милиционер" }  },
                new Question { text = "Слово ''Challenging'' означает:", answer = "Требующий напряжения", textAnswer="", answerArray=new string[4] { "Требующий напряжения", "Жалованье", "Нагрузка", "Гарантия занятости" }  },
                new Question { text = "Слово ''Нагрузка'' на английском:", answer = "Load", textAnswer="", answerArray=new string[4] { "Benefit", "Career", "Load", "Challenging" }  },
                new Question { text = "Слово ''Entrepreneur'' означает:", answer = "Предприниматель", textAnswer="", answerArray=new string[4] { "Медсестра", "Предприниматель", "Официант", "Ветеринар" }  },
                new Question { text = "Словосочетание ''Job security'' означает:", answer = "Гарантия занятости", textAnswer="", answerArray=new string[4] { "Слабая сторона", "Сильная сторона", "Защищенность", "Гарантия занятости" }  },
                new Question { text = "Слово ''Зарабатывать'' на английском:", answer = "Earn", textAnswer="", answerArray=new string[4] { "Earn", "Load", "Benefit", "Well-paid" }  },
                new Question { text = "Слово ''Льготы'' на английском:", answer = "Benefit", textAnswer="", answerArray=new string[4] { "Earn", "Load", "Benefit", "Well-paid" }  },
                new Question { text = "Фраза ''Work as…'' означает:", answer = "Работать кем-то", textAnswer="",answerArray=new string[4] { "Иметь хорошие условия", "Гарантия занятости", "Работать кем-то", "Иметь дело с клиентами" }  },
                new Question { text = "Слово ''Benefit'' означает:", answer = "Льготы", textAnswer="", answerArray=new string[4] { "Высокооплачиваемый", "Карьера", "Нагрузка", "Льготы" } },
                new Question { text = "Слово ''Жалованье'' на английском:", answer = "Salary", textAnswer="", answerArray=new string[4] { "Salary", "Earn", "Well-paid", "Benefit" }  },

            };


            Question[] questionsArraynaccar = {

                new Question { text = "Слово ''Stereotype'' означает:", answer = "Стереотип", textAnswer="",answerArray=new string[4] { "Обобщение", "Стереотип", "Гибкий", "Стремление" }  },
                new Question { text = "Слово ''Ambitious'' означает:", answer = "Амбициозный", textAnswer="", answerArray=new string[4] { "Амбициозный", "Высокомерный", "Напористый", "Импульсивный" } },
                new Question { text = "Слово ''Приятный'' на английском:", answer = "Agreeable", textAnswer="", answerArray=new string[4] { "Ambitious", "Assertive", "Agreeable", "Caring" }  },
                new Question { text = "Слово ''Arrogant'' означает:", answer = "Высокомерный", textAnswer="", answerArray=new string[4] { "Высокомерный", "Щедрый", "Честный", "Импульсивный" }  },
                new Question { text = "Слово ''Humble'' означает:", answer = "Скромный", textAnswer="", answerArray=new string[4] { "Скромный", "Высокомерный", "Гибкий", "Честный" }  },
                new Question { text = "Слово ''Гибкий'' на английском:", answer = "Flexible", textAnswer="", answerArray=new string[4] { "Generous", "Assertive", "Aspiration", "Arrogant" }  },
                new Question { text = "Слово ''Honest'' означает:", answer = "Честный", textAnswer="", answerArray=new string[4] { "Честный", "Обобщение", "Гибкий", "Импульсивный" }  },
                new Question { text = "Слово ''Organized'' означает:", answer = "Организованный", textAnswer="", answerArray=new string[4] { "Организованный", "Импульсивный", "Уважительный", "Неглубокий" }  },
                new Question { text = "Слово ''Прямолинейный'' на английском:", answer = "Straightforward", textAnswer="", answerArray=new string[4] { "Amusing", "Shallow", "Straightforward", "Polite" }  },
                new Question { text = "Слово ''Унижающий'' на английском:", answer = "Humiliating", textAnswer="", answerArray=new string[4] { "Technical", "Humiliating", "Submissive", "Talkative" }  },
                new Question { text = "Слово ''Polite'' означает:", answer = "Вежливый", textAnswer="",answerArray=new string[4] { "Вежливый", "Гордый", "Забавный", "Добросердечный" }  },
                new Question { text = "Слово ''Humble'' означает:", answer = "Скромный", textAnswer="", answerArray=new string[4] { "Организованный", "Импульсивный", "Гордый", "Скромный" } },
                new Question { text = "Слово ''Законопослушный'' на английском:", answer = "Law-abiding", textAnswer="", answerArray=new string[4] { "Funky", "Law-abiding", "Obsessive", "Confident" }  },
                new Question { text = "Слово ''Funky'' означает:", answer = "Клевый", textAnswer="",answerArray=new string[4] { "Тупоголовый", "Организованный", "Болтливый", "Унижающий" }  },
                new Question { text = "Слово ''Indolent'' означает:", answer = "Очень ленивый", textAnswer="", answerArray=new string[4] { "Скучный", "Очень ленивый", "Пассивный", "Терпимый" } },
                new Question { text = "Слово ''Грубый'' на английском:", answer = "Rude", textAnswer="", answerArray=new string[4] { "Dull", "Rude", "Strict", "Thankful" }  },
                new Question { text = "Слово ''Biased'' означает:", answer = "Предвзятый", textAnswer="", answerArray=new string[4] { "Благодарный", "Грубый", "Предвзятый", "Скучный" }  },
                new Question { text = "Словосочетание ''Kind-hearted'' означает:", answer = "Добросердечный", textAnswer="", answerArray=new string[4] { "Добросердечный", "Упрямый", "Непредвзятый", "Предвзятый" }  },
                new Question { text = "Слово ''Уверенный'' на английском:", answer = "Confident", textAnswer="", answerArray=new string[4] { "Amusing", "Reasonable", "Rude", "Confident" }  },
                new Question { text = "Слово ''Рациональный'' на английском:", answer = "Reasonable", textAnswer="", answerArray=new string[4] { "Humiliating", "Reasonable", "Stubborn", "Proud" }  },
                new Question { text = "Слово ''Болтливый'' на английском:", answer = "Talkative", textAnswer="", answerArray=new string[4] { "Strict", "Talkative", "Outgoing", "Biased" }  },
                new Question { text = "Слово ''Общительный'' на английском:", answer = "Outgoing", textAnswer="", answerArray=new string[4] { "Ambitious", "Generous", "Controlled", "Outgoing" }  },
                new Question { text = "Слово ''Тревожный'' на английском:", answer = "Anxious", textAnswer="", answerArray=new string[4] { "Anxious", "Ambitious", "Humble", "Generalization" }  },
                new Question { text = "Слово ''Покорный'' на английском:", answer = "Submissive", textAnswer="",answerArray=new string[4] { "Submissive", "Reasonable", "Talkative", "Shallow" }  },
                new Question { text = "Слово ''Навязчивый'' на английском:", answer = "Obsessive", textAnswer="", answerArray=new string[4] { "Law-abiding", "Obsessive", "Modest", "Materialistic" } },
                new Question { text = "Слово ''Практичный'' на английском:", answer = "Materialistic", textAnswer="", answerArray=new string[4] { "Impulsive", "Thankful", "Agreeable", "Materialistic" }  },

            };


            Question[] questionsArrayintcult = {

                new Question { text = "Слово ''Annual'' означает:", answer = "Ежегодный", textAnswer="",answerArray=new string[4] { "Ежегодный", "Общественный", "Современный", "Совместный" }  },
                new Question { text = "Словосочетание ''Comfort zone'' означает:", answer = "Зона комфорта", textAnswer="", answerArray=new string[4] { "Посольство", "Сообщество", "Зона комфорта", "Современник" } },
                new Question { text = "Слово ''Independent'' означает:", answer = "Независимый", textAnswer="", answerArray=new string[4] { "Общественный", "Независимый", "Современный", "Ежегодный" }  },
                new Question { text = "Слово ''Community'' означает:", answer = "Сообщество", textAnswer="", answerArray=new string[4] { "Культурный шок", "Современный", "Ежегодный", "Сообщество" }  },
                new Question { text = "Слово ''Contemporary'' означает:", answer = "Современный", textAnswer="", answerArray=new string[4] { "Современный", "Низовой", "Годовой", "Месячный" }  },
                new Question { text = "Слово ''Cooperation'' на английском:", answer = "Сотрудничество", textAnswer="", answerArray=new string[4] { "Общество", "Сотрудничество", "Совместный", "Современник" }  },
                new Question { text = "Словосочетание ''Culture shock'' означает:", answer = "Культурный шок", textAnswer="", answerArray=new string[4] { "Кульминация", "Современник", "Сотрудничество", "Культурный шок" }  },
                new Question { text = "Слово ''Embassy'' означает:", answer = "Посольство", textAnswer="", answerArray=new string[4] { "Министерство", "Посольство", "Государство", "Консульство" }  },
                new Question { text = "Слово ''Гарантировать'' на английском:", answer = "Ensure", textAnswer="", answerArray=new string[4] { "Establish", "Ensure", "Independent", "Contemporary" }  },
                new Question { text = "Слово ''Установить'' на английском:", answer = "Establish", textAnswer="", answerArray=new string[4] { "Independent", "Establish", "Cooperation", "Contemporary" }  },
                new Question { text = "Слово ''Gain'' означает:", answer = "Приобретать", textAnswer="",answerArray=new string[4] { "Нанимать", "Иметь", "Приобретать", "Покупать" }  },
                new Question { text = "Слово ''Grassroots'' означает:", answer = "Низовой", textAnswer="", answerArray=new string[4] { "Низовой", "Высший", "Средний", "Годовой" } },
                new Question { text = "Слово ''Вершина'' на английском:", answer = "Highlight", textAnswer="", answerArray=new string[4] { "Joint", "Highlight", "Gain", "Grassroots" }  },
                new Question { text = "Слово ''Joint'' означает:", answer = "Совместный", textAnswer="",answerArray=new string[4] { "Совместный", "Ежегодный", "Годовой", "Независимый" }  },
                

            };


            Question[] questionsArraytourism = {

                new Question { text = "Фраза ''To swear by something'' означает:", answer = "Свято верить", textAnswer="",answerArray=new string[4] { "Вырваться из зоны комфорта", "Свято верить", "Выходить за рамки", "Переживать трудные времена" }  },
                new Question { text = "Фраза ''Burst out of someone’s comfort zone'' означает:", answer = "Вырваться из зоны комфорта", textAnswer="", answerArray=new string[4] { "Вырваться из зоны комфорта", "Свято верить", "Выходить за рамки", "Переживать трудные времена" } },
                new Question { text = "Фраза ''Выходить за рамки'' на английском:", answer = "Go beyond something", textAnswer="", answerArray=new string[4] { "Last resort", "Immerse yourself in something", "Go through a rough patch", "Go beyond something" }  },
                new Question { text = "Фраза ''Immerse yourself in something'' означает:", answer = "Погрузиться во что-либо", textAnswer="", answerArray=new string[4] { "Путешествовать по миру", "Cклонность к чему-либо", "Выходить за рамки", "Погрузиться во что-либо" }  },
                new Question { text = "Слово ''Travel'' означает:", answer = "Путешествие", textAnswer="", answerArray=new string[4] { "Путешествие", "Маршрут", "Путь", "Экскурсия" }  },
                new Question { text = "Слово ''Маршрут'' на английском:", answer = "Itinerary", textAnswer="", answerArray=new string[4] { "Trip", "Itinerary", "Benefit", "Travel" }  },
                new Question { text = "Словосочетание ''Stamping grounds'' означает:", answer = "Излюбленное место", textAnswer="", answerArray=new string[4] { "Длительное путещшествие", "Быть на высоте", "Крайняя мера", "Излюбленное место" }  },
                new Question { text = "Слово ''Perk'' означает:", answer = "Преимущество", textAnswer="", answerArray=new string[4] { "Преимущество", "Бонус", "Путь", "Поездка" }  },
                new Question { text = "Слово ''Рейс'' на английском:", answer = "Flight", textAnswer="", answerArray=new string[4] { "Flight", "Trip", "Cruise", "Voyage" }  },
                new Question { text = "Слово ''Круиз'' на английском:", answer = "Cruise", textAnswer="", answerArray=new string[4] { "Trip", "Tour", "Flight", "Cruise" }  },
                new Question { text = "Словосочетание ''Travel agency'' означает:", answer = "Туристическое агентство", textAnswer="",answerArray=new string[4] { "Камера хранения", "Требующий много времени", "Длинный полет", "Туристическое агентство" }  },
                new Question { text = "Слово ''Luggage'' означает:", answer = "Багаж", textAnswer="", answerArray=new string[4] { "Рюкзак", "Багаж", "Справочное бюро", "Полет" } },
                new Question { text = "Слово ''Рюкзак'' на английском:", answer = "Backpack", textAnswer="", answerArray=new string[4] { "Backpack", "Information desk", "Trip", "Package tour" }  },
                new Question { text = "Слово ''Voyage'' означает:", answer = "Путешествие по морю", textAnswer="",answerArray=new string[4] { "Рейс", "Путешествие по морю", "Полет", "Поездка" }  },
                new Question { text = "Словосочетание ''Stay in a hotel'' означает:", answer = "Остановиться в отеле", textAnswer="", answerArray=new string[4] { "Камера хранения", "Справочное бюро", "Отправиться в путешествие", "Остановиться в отеле" } },
                new Question { text = "Словосочетание ''Камера хранения'' на английском:", answer = "Left luggage office", textAnswer="", answerArray=new string[4] { "Information desk", "Left luggage office", "To go hitchhiking", "Unconventional" }  },
                new Question { text = "Фраза ''To go hitchhiking'' означает:", answer = "Отправиться в путешествие автостопом", textAnswer="", answerArray=new string[4] { "Длительное путешествие", "Отправиться в путешествие автостопом", "Отправляться в путь", "Быть на высоте" }  },
                new Question { text = "Словосочетание ''Information desk'' означает:", answer = "Справочное бюро", textAnswer="", answerArray=new string[4] { "Турагенство", "Отель", "Справочное бюро", "Камера хранения" }  },
                new Question { text = "Слово ''Излюбленное место'' на английском:", answer = "Stamping grounds", textAnswer="", answerArray=new string[4] { "Travel agency", "Stamping grounds", "Set off", "Last resort" }  },
                new Question { text = "Слово ''Бонус'' на английском:", answer = "Benefit", textAnswer="", answerArray=new string[4] { "Benefit", "Perk", "Flight", "Journey" }  },
                new Question { text = "Словосочетание ''Time-consuming'' означает:", answer = "Требующий много времени", textAnswer="", answerArray=new string[4] { "Крайняя мера", "Требующий много времени", "Нетрадиционный", "Последнее средтво" }  },


            };


            Question[] questionsArrayenvir = {

                new Question { text = "Слово ''Nature'' означает:", answer = "Природа", textAnswer="",answerArray=new string[4] { "Природа", "Окружающая среда", "Человечество", "Загрязнение" }  },
                new Question { text = "Слово ''Humanity'' означает:", answer = "Человечество", textAnswer="", answerArray=new string[4] { "Человек", "Человечество", "природа", "Загрязнение" } },
                new Question { text = "Слово ''Загрязнение'' на английском:", answer = "Contamination", textAnswer="", answerArray=new string[4] { "Substance", "Harmful", "Contamination", "Pollution" }  },
                new Question { text = "Слово ''Разрушать'' на английском:", answer = "Destroy", textAnswer="", answerArray=new string[4] { "Destroy", "Contaminate", "Pollute", "Protect" }  },
                new Question { text = "Слово ''Emission'' означает:", answer = "Выброс", textAnswer="", answerArray=new string[4] { "Пыль", "Кислотный дождь", "Выброс", "Яд" }  },
                new Question { text = "Слово ''Отходы'' на английском:", answer = "Wastes", textAnswer="", answerArray=new string[4] { "Reduce", "Soil", "Dust", "Wastes" }  },
                new Question { text = "Слово ''Защищать'' означает:", answer = "To protect", textAnswer="", answerArray=new string[4] { "To protect", "To pollute", "To сontaminate", "To destroy" }  },
                new Question { text = "Слово ''Landfill'' означает:", answer = "Свалка", textAnswer="", answerArray=new string[4] { "Озоновая дыра", "Род", "Ядро", "Свалка" }  },
                new Question { text = "Словосочетание ''Парниковый эффект'' на английском:", answer = "Greenhouse effect", textAnswer="", answerArray=new string[4] { "Acid rains", "Global warming", "Ozone holes", "Greenhouse effect" }  },
                new Question { text = "Словосочетание ''Кислотные дожди'' на английском:", answer = "Acid rains", textAnswer="", answerArray=new string[4] { "Acid rains", "Global warming", "Ozone holes", "Greenhouse effect" }  },
                new Question { text = "Слово ''Household'' означает:", answer = "Бытовой", textAnswer="",answerArray=new string[4] { "Использованный", "Возобновляемый", "Бытовой", "Вымерший" }  },
                new Question { text = "Слово ''Renewable'' означает:", answer = "Возобновляемый", textAnswer="", answerArray=new string[4] { "Бытовой", "Возобновляемый", "Вымерший", "Нетрадиционный" } },
                new Question { text = "Слово ''Таять'' на английском:", answer = "Melt", textAnswer="", answerArray=new string[4] { "Melt", "Reuse", "Species", "Nuclear" }  },
                new Question { text = "Словосочетание ''Использовать снова'' на английском:", answer = "Reuse", textAnswer="",answerArray=new string[4] { "Extinct", "Reuse", "Species", "Nuclear" }  },
                new Question { text = "Слово ''Recycle'' означает:", answer = "Возвращать в оборот", textAnswer="", answerArray=new string[4] { "Таять", "Уменьшать", "Возвращать в оборот", "Использовать снова" } },
                new Question { text = "Слово ''Ядерный'' на английском:", answer = "Nuclear", textAnswer="", answerArray=new string[4] { "Landfill", "Nuclear", "Valuable", "Melt" }  },
                new Question { text = "Слово ''Valuable'' означает:", answer = "Ценный", textAnswer="", answerArray=new string[4] { "Ядерный", "Вымерший", "Бытовой", "Ценный" }  },
                new Question { text = "Слово ''Endless'' означает:", answer = "Бесконечный", textAnswer="", answerArray=new string[4] { "Бесконечный", "Конечный", "Возобновляемый", "Невозобновляемый" }  },
                new Question { text = "Слово ''Бытовой'' на английском:", answer = "Household", textAnswer="", answerArray=new string[4] { "Household", "Landfill", "Nuclear", "Mankind" }  },
                new Question { text = "Словосочетание ''Global warming'' означает:", answer = "Глобальное потепление", textAnswer="", answerArray=new string[4] { "Глобальная опасность", "Кислотные дожди", "Озоновые дыры", "Глобальное потепление" }  },
                new Question { text = "Слово ''List'' означает:", answer = "Список", textAnswer="", answerArray=new string[4] { "Порода", "Список", "Почва", "Вид" }  },


            };



            Question[] questionsArrayathome = {

                new Question { text = "Слово ''Conquer'' означает:", answer = "Завоевать", textAnswer="",answerArray=new string[4] { "Распространить", "Состоять из", "Граничить", "Завоевать" }  },
                new Question { text = "Словосочетание ''The lungs of Europe'' означает:", answer = "Легкие Европы", textAnswer="", answerArray=new string[4] { "Руки Европы", "Лицо Европы", "Тело Европы", "Легкие Европы" } },
                new Question { text = "Слово ''Распространить'' на английском:", answer = "Spread", textAnswer="", answerArray=new string[4] { "Spread", "Numerous", "Mild", "Changeable" }  },
                new Question { text = "Слово ''Зубр'' означает:", answer = "Bison", textAnswer="", answerArray=new string[4] { "Island", "Cornflower", "Stork", "Bison" }  },
                new Question { text = "Слово ''Mountainous'' означает:", answer = "Горный", textAnswer="", answerArray=new string[4] { "Валютный", "Валюты", "Горы", "Горный" }  },
                new Question { text = "Слово ''Поверхность'' на английском:", answer = "The surface", textAnswer="", answerArray=new string[4] { "Swamp", "The surface", "The currency", "The anthem" }  },
                new Question { text = "Словосочетание ''A vast plain'' означает:", answer = "Широкая долина", textAnswer="", answerArray=new string[4] { "Широкая долина", "Узкая долина", "Кривая долина", "Волнистая долина" }  },
                new Question { text = "Слово ''Stork'' означает:", answer = "Аист", textAnswer="", answerArray=new string[4] { "Аист", "Зубр", "Василек", "Луг" }  },
                new Question { text = "Слово ''Василек'' на английском:", answer = "Cornflower", textAnswer="", answerArray=new string[4] { "Cornflower", "Bison", "Mountain", "Stork" }  },
                new Question { text = "Словосочетание ''Наиболее густо заселенный'' на английском:", answer = "The most densely populated", textAnswer="", answerArray=new string[4] { "The anthem", "The currency", "The most densely populated", "The lungs of Europe" }  },
                new Question { text = "Слово ''Important'' означает:", answer = "Важный", textAnswer="",answerArray=new string[4] { "Изменчивый", "Управлящий", "Называющийся", "Важный" }  },
                new Question { text = "Фраза ''To be separated from'' означает:", answer = "Отделяться", textAnswer="", answerArray=new string[4] { "Отделяться", "Граничить", "Влиять", "Управлять" } },
                new Question { text = "Словосочетание ''Состоять из'' на английском:", answer = "To consist of", textAnswer="", answerArray=new string[4] { "To border on", "To be separated from", "To be situated", "To consist of" }  },
                new Question { text = "Словосочетание ''To border on'' означает:", answer = "Граничить", textAnswer="",answerArray=new string[4] { "Влиять", "Граничить", "Отделяться", "Завоевать" }  },
                new Question { text = "Словосочетание ''To be called'' означает:", answer = "Называться", textAnswer="", answerArray=new string[4] { "Влиять", "Отделяться", "Называться", "Завоевать" } },
                new Question { text = "Словосочетание ''Влиять на климат'' на английском:", answer = "To influence the climate", textAnswer="", answerArray=new string[4] { "To influence the climate", "To be situated", "To consist of", "To be separated from" }  },
                new Question { text = "Словосочетание ''The surface'' означает:", answer = "Поверхность", textAnswer="", answerArray=new string[4] { "Валюта", "Поверхность", "Гимн", "Граница" }  },
                new Question { text = "Слово ''The anthem'' означает:", answer = "Гимн", textAnswer="", answerArray=new string[4] { "Гимн", "Валюта", "Граница", "Поверхность" }  },
                new Question { text = "Слово ''Остров'' на английском:", answer = "An island", textAnswer="", answerArray=new string[4] { "An island", "Spread", "Conquer", "Grassland" }  },
                new Question { text = "Слово ''Spread'' означает:", answer = "Распространить", textAnswer="", answerArray=new string[4] { "Состоять из", "Граничить", "Распространить", "Сильно изменяться" }  },
                new Question { text = "Словосочетание ''The head of the state'' означает:", answer = "Глава государства", textAnswer="", answerArray=new string[4] { "Правитель", "Гимн", "Глава государства", "Король" }  },
                new Question { text = "Слово ''Управлять'' на английском:", answer = "To rule", textAnswer="", answerArray=new string[4] { "To vary greatly", "To be called", "To influence", "To rule" }  },
                new Question { text = "Словосочетание ''Сильно изменяться'' на английском:", answer = "To vary greatly", textAnswer="", answerArray=new string[4] { "To vary greatly", "To be called", "A vast plain", "The most densely populated" }  },
               
            };


            Question[] questionsArraywohn = {

                new Question { text = "Слово ''das Haus'' означает:", answer = "Дом", textAnswer="",answerArray=new string[4] { "Дом", "Таунхаус", "Особняк", "Многоквартирный дом" }  },
                new Question { text = "Слово ''das Reihenhaus'' означает:", answer = "Таунхаус", textAnswer="", answerArray=new string[4] { "Таунхаус", "Особняк", "Многоквартирный дом", "Дом" } },
                new Question { text = "Слово ''Особняк'' на немецком:", answer = "das Einfamilienhaus", textAnswer="", answerArray=new string[4] { "das Reihenhaus", "das Haus", "das Einfamilienhaus", "das Mehrfamilienhaus" }  },
                new Question { text = "Слово ''das Bauernhaus'' означает:", answer = "Крестьянский дом", textAnswer="", answerArray=new string[4] { "Таунхаус", "Крестьянский дом", "Дом", "Особняк" }  },
                new Question { text = "Слово ''ein eigenes Haus'' означает:", answer = "Собственный дом", textAnswer="", answerArray=new string[4] { "Собственный дом", "Крестьянский дом", "Дом", "Многоквартирный дом" }  },
                new Question { text = "Слово ''Лестница'' на немецком:", answer = "die Treppe", textAnswer="", answerArray=new string[4] { "der Innenhof", "die Wohnfläche", "der Fensterladen", "die Treppe" }  },
                new Question { text = "Слово ''der Eingang'' означает:", answer = "Вход", textAnswer="", answerArray=new string[4] { "Дом", "Лестница", "Вход", "Внутренний двор" }  },
                new Question { text = "Слово ''idas Treppenhaus'' означает:", answer = "Лестничная клетка", textAnswer="", answerArray=new string[4] { "Лестница", "Аренда", "Лестничная клетка", "Жилая площадь" }  },
                new Question { text = "Слово ''Арендодатель'' на немецком:", answer = "der Vermieter", textAnswer="", answerArray=new string[4] { "vermieten", "der Mieter", "mieten", "der Vermieter" }  },
                new Question { text = "Слово ''Комфорт'' на немецком:", answer = "die Gemütlichkeit", textAnswer="", answerArray=new string[4] { "die Gemütlichkeit", "gemütlich", "möblieren", "der Vorhang" }  },
                new Question { text = "Слово ''Рисовать'' означает:", answer = "streichen", textAnswer="",answerArray=new string[4] { "das Poster", "möblieren", "streichen", "gemütlich" }  },
                new Question { text = "Слово ''einziehen'' означает:", answer = "Переезжать", textAnswer="", answerArray=new string[4] { "Переезжать", "Переехать", "Выезжать", "Переезд" } },
                new Question { text = "Слово ''Жилая площадь'' на немецком:", answer = "die Wohnfläche", textAnswer="", answerArray=new string[4] { "das Reihenhaus", "das Haus", "idas Treppenhaus", "die Wohnfläche" }  },
                new Question { text = "Слово ''die Ausstattung'' означает:", answer = "Оборудование", textAnswer="",answerArray=new string[4] { "Жилая площадь", "Оборудование", "Комфорт", "Плакат" }  },
                new Question { text = "Слово ''das Poster'' означает:", answer = "Плакат", textAnswer="", answerArray=new string[4] { "Обои", "Оборудование", "Плакат", "Рисовать" } },
                new Question { text = "Слово ''Обои'' на немецком:", answer = "die Tapete", textAnswer="", answerArray=new string[4] { "die Tapete", "die Miete", "das Poster", "der Vorhang" }  },
                new Question { text = "Слово ''Занавески'' на немецком:", answer = "der Vorhang", textAnswer="", answerArray=new string[4] { "die Tapete", "die Miete", "das Poster", "der Vorhang" }  },
                new Question { text = "Слово ''die Heizung'' означает:", answer = "Утепление", textAnswer="", answerArray=new string[4] { "Обставлять квартиру мебелью", "Утепление", "Оборудовать", "Переезжать" }  },
                new Question { text = "Слово ''Аренда'' на немецком:", answer = "mieten", textAnswer="", answerArray=new string[4] { "mieten", "die Miete", "zur Miete wohnen", "der Mieter" }  },
                new Question { text = "Слово ''die Gemütlichkeit'' означает:", answer = "Комфорт", textAnswer="", answerArray=new string[4] { "Переезд", "Комфортно", "Комфорт", "Расходы" }  },
                new Question { text = "Слово ''die Wohnatmosphäre'' означает:", answer = "Атмосфера в квартире", textAnswer="", answerArray=new string[4] { "Недостаток", "Плакат", "Квартира", "Атмосфера в квартире" }  },
                new Question { text = "Словосочетание ''Двойное окно'' на немецком:", answer = "das Doppelfenster", textAnswer="", answerArray=new string[4] { "das Doppelfenster", "bevorzugen", "der Innenhof", "das Eigentum" }  },
                new Question { text = "Фраза ''Арендовать комнату'' на немецком:", answer = "zur Untermiete wohnen", textAnswer="", answerArray=new string[4] { "zur Untermiete wohnen", "zur Miete wohnen", "die Miete", "der Vermieter" }  },
                
            };

            Question[] questionsArrayshul = {

                new Question { text = "Слово ''außerschulisch'' означает:", answer = "Внешкольный", textAnswer="",answerArray=new string[4] { "Внешкольный", "Внешкольная работа", "Школа", "Начальная школа" }  },
                new Question { text = "Слово ''die Berufsschule'' означает:", answer = "Профессиональная школа", textAnswer="", answerArray=new string[4] { "Гимназия", "Начальная школа", "Профессиональная школа", "Ясли" } },
                new Question { text = "Слово ''Гимназия'' на немецком:", answer = "das Gymnasium", textAnswer="", answerArray=new string[4] { "die Schulstufe", "die Realschule", "die Hauptschule", "das Gymnasium" }  },
                new Question { text = "Слово ''die Hauptschule'' означает:", answer = "Базовая школа", textAnswer="", answerArray=new string[4] { "Ступень (обучения)", "Гимназия", "Реальная школа", "Базовая школа" }  },
                new Question { text = "Слово ''die Oberstufe'' означает:", answer = "Старшие классы", textAnswer="", answerArray=new string[4] { "Классы средней ступени", "Старшие классы", "Младшие классы", "Ступень (обучения)" }  },
                new Question { text = "Словосочетание ''Младшие классы'' на немецком:", answer = "die Grundstufe", textAnswer="", answerArray=new string[4] { "die Grundstufe", "die Oberstufe", "die Mittelstufe", "die Schulstufe" }  },
                new Question { text = "Слово ''der Schulbeginn'' означает:", answer = "Начало учебного года", textAnswer="", answerArray=new string[4] { "Четверть", "Полугодие", "Начало учебного года", "Учебный месяц" }  },
                new Question { text = "Слово ''Четверть'' означает:", answer = "das Viertel", textAnswer="", answerArray=new string[4] { "das Halbjahr", "das Viertel", "das Schulfach", "der Schulbeginn" }  },
                new Question { text = "Словосочетание ''Обязательный предмет на выбор'' на немецком:", answer = "das Wahlfach", textAnswer="", answerArray=new string[4] { "das Schulfach", "das Viertel", "das Wahlfach", "die Klassenarbeit" }  },
                new Question { text = "Словосочетание ''Учебный предмет'' на немецком:", answer = "das Schulfach", textAnswer="", answerArray=new string[4] { "die Klassenarbeit", "das Wahlfach", "das Viertel", "das Schulfach" }  },
                new Question { text = "Слово ''die Klassenarbeit'' означает:", answer = "Контрольная работа", textAnswer="",answerArray=new string[4] { "Достижение", "Успех", "Экзамен", "Контрольная работа" }  },
                new Question { text = "Слово ''die Prüfung'' означает:", answer = "Экзамен", textAnswer="", answerArray=new string[4] { "Достижение", "Успех", "Экзамен", "Контрольная работа" } },
                new Question { text = "Словосочетание ''Выпускной экзамен'' на немецком:", answer = "die Abschlussprüfung", textAnswer="", answerArray=new string[4] { "die Abschlussprüfung", "die Aufnahmeprüfung", "eine Prüfung ablegen", "die Prüfung" }  },
                new Question { text = "Словосочетание ''Приёмный экзамен'' на немецком:", answer = "die Aufnahmeprüfung", textAnswer="",answerArray=new string[4] { "eine Prüfung ablegen", "die Verantwortung", "die Abschlussprüfung", "die Aufnahmeprüfung" }  },
                new Question { text = "Слово ''das Abschlusszeugnis'' означает:", answer = "Аттестат об окончании средней школы", textAnswer="", answerArray=new string[4] { "Аттестат об окончании средней школы", "Удостоверение", "Свидетельство", "Справка" } },
                new Question { text = "Слово ''Решать'' на немецком:", answer = "lösen", textAnswer="", answerArray=new string[4] { "das Zeugnis", "lösen", "eine Prüfung ablegen", "seinen Abschluss machen" }  },
                new Question { text = "Слово ''das Halbjahr'' означает:", answer = "Полугодие", textAnswer="", answerArray=new string[4] { "Полугодие", "Четверть", "Ступень (обучения)", "Внешкольная работа" }  },
                new Question { text = "Слово ''die Leistung'' означает:", answer = "Успех", textAnswer="", answerArray=new string[4] { "Ответственность", "Решение", "Решать", "Успех" }  },
                new Question { text = "Словосочетание ''Окончание учебного заведения'' на немецком:", answer = "der Abschluss", textAnswer="", answerArray=new string[4] { "der Abschluss", "der Hauptschulabschluss", "der Schulbeginn", "die Berufsschule" }  },
                new Question { text = "Слово ''eine Prüfung ablegen'' означает:", answer = "Сдавать экзамен", textAnswer="", answerArray=new string[4] { "Выпускной экзамен", "Сдавать экзамен", "Приемный экзамен", "Аттестат" }  },
                new Question { text = "Слово ''die Verantwortung'' означает:", answer = "Ответственность", textAnswer="", answerArray=new string[4] { "Свидетельство", "Брать ответственность", "Ответственность", "Аттестат" }  },
                new Question { text = "Словосочетание ''Брать ответственность'' на немецком:", answer = "die Verantwortung übernehmen", textAnswer="", answerArray=new string[4] { "die Verantwortung übernehmen", "das Zeugnis", "die Verantwortung", "das Abiturzeugnis" }  },
                new Question { text = "Словосочетание ''Свидетельство об окончании неполной средней школы'' на немецком:", answer = "das Zeugnis der mittleren Reife", textAnswer="", answerArray=new string[4] { "das Zeugnis der mittleren Reife", "das Reifezeugnis", "das Abiturzeugnis", "das Zeugnis" }  },
                
            };




            Question[] questionsArraymessen = {

                new Question { text = "Слово ''das Medium'' означает:", answer = "СМИ", textAnswer="",answerArray=new string[4] { "ТВ", "СМИ", "Факт", "Сообщение" }  },
                new Question { text = "Слово ''die Tatsache'' означает:", answer = "Факт", textAnswer="", answerArray=new string[4] { "Сообщение", "Факт", "ТВ", "СМИ" } },
                new Question { text = "Слово ''Сообщение'' на немецком:", answer = "die Nachricht", textAnswer="", answerArray=new string[4] { "die Nachricht", "der Kommentar", "der Leserbrief", "das Interview" }  },
                new Question { text = "Слово ''das Interview'' означает:", answer = "Интервью", textAnswer="", answerArray=new string[4] { "Интервью", "Комментарий", "Статья", "Реклама" }  },
                new Question { text = "Слово ''die Anzeige'' означает:", answer = "Объявление", textAnswer="", answerArray=new string[4] { "Статья", "Объявление", "Комментарий", "Сообщение" }  },
                new Question { text = "Слово ''Комментарий'' на немецком:", answer = "der Kommentar", textAnswer="", answerArray=new string[4] { "die Tatsache", "der Kommentar", "das Interview", "der Leserbrief" }  },
                new Question { text = "Слово ''der Leserbrief'' означает:", answer = "Письмо читателя", textAnswer="", answerArray=new string[4] { "Факт", "Интервью", "Комментарий", "Письмо читателя" }  },
                new Question { text = "Слово ''kritisieren'' означает:", answer = "Критиковать", textAnswer="", answerArray=new string[4] { "Сообщать", "Подписывать", "Критиковать", "Развлекать" }  },
                new Question { text = "Слово ''Статья'' на немецком:", answer = "der Artikel", textAnswer="", answerArray=new string[4] { "der Leserbrief", "der Artikel", "die Tatsache", "der Kommentar" }  },
                new Question { text = "Словосочетание ''Титульная страница'' на немецком:", answer = "die Titelseite", textAnswer="", answerArray=new string[4] { "die Werbung", "die Zeile", "die Schlagzeile", "die Titelseite" }  },
                new Question { text = "Слово ''das Ereignis'' означает:", answer = "Событие", textAnswer="",answerArray=new string[4] { "Статья", "Событие", "Сообщение", "Трансляция" }  },
                new Question { text = "Слово ''die Nachricht'' означает:", answer = "Сообщение", textAnswer="", answerArray=new string[4] { "Трансляция", "Сообщение", "Событие", "Статья" } },
                new Question { text = "Словосочетание ''Крупный заголовок'' на немецком:", answer = "die Schlagzeile", textAnswer="", answerArray=new string[4] { "die Schlagzeile", "die Werbung", "die Zeile", "die Titelseite" }  },
                new Question { text = "Слово ''abonnieren'' означает:", answer = "Подписываться", textAnswer="",answerArray=new string[4] { "Писать письмо", "Сообщать", "Подписываться", "Выпускать" }  },
                new Question { text = "Слово ''die Quizsendung'' означает:", answer = "(Теле)викторина", textAnswer="", answerArray=new string[4] { "(Теле)викторина", "Передача", "Телевидение", "Развлекательная передача" } },
                new Question { text = "Слово ''Передача'' на немецком:", answer = "die Sendung", textAnswer="", answerArray=new string[4] { "die Unterhaltungssendung", "die Quizsendung", "das Fernsehen", "die Sendung" }  },
                new Question { text = "Слово ''die Informationssendung'' означает:", answer = "Информационная передача", textAnswer="", answerArray=new string[4] { "Информационная передача", "(Теле)викторина", "Передача", "Газета" }  },
                new Question { text = "Слово ''herausgeben'' означает:", answer = "Выпускать газету", textAnswer="", answerArray=new string[4] { "Выпускать газету", "Снимать фильм", "Сниматься в кино", "Критиковать" }  },
                new Question { text = "Слово ''Реклама'' на немецком:", answer = "die Werbung", textAnswer="", answerArray=new string[4] { "der Kommentar", "die Werbung", "der Leserbrief", "der Artikel" }  },
                new Question { text = "Слово ''Региональный'' на немецком:", answer = "regional", textAnswer="", answerArray=new string[4] { "regional", "berichten", "lokal", "herausgeben" }  },
                new Question { text = "Слово ''elektronische'' означает:", answer = "Электронные СМИ", textAnswer="", answerArray=new string[4] { "СМИ", "Печатные СМИ", "Аудиовизуальные СМИ", "Электронные СМИ" }  },
                new Question { text = "Словосочетание ''Информационный журнал'' на немецком:", answer = "das Nachrichtenmagazin", textAnswer="", answerArray=new string[4] { "der Artikel", "die Nachricht", "das Nachrichtenmagazin", "der Bericht" }  },
                new Question { text = "Словосочетание ''Печатные СМИ'' на немецком:", answer = "printmedian", textAnswer="", answerArray=new string[4] { "printmedian", "audiovisuelle Medien", "elektronische", "das Medium" }  },
             
            };


            Question[] questionsArraykunst = {

                new Question { text = "Слово ''die Kunst'' означает:", answer = "Искусство", textAnswer="",answerArray=new string[4] { "Художник", "Искусство", "Скульптура", "Натюрморт" }  },
                new Question { text = "Слово ''die Malerei'' означает:", answer = "Живопись", textAnswer="", answerArray=new string[4] { "Живопись", "Архитектура", "Скульптура", "Натюрморт" } },
                new Question { text = "Слово ''Автопортрет'' на немецком:", answer = "das Selbstbildnis", textAnswer="", answerArray=new string[4] { "das Selbstbildnis", "das Stillleben", "die Zeichnung", "das Bildnis" }  },
                new Question { text = "Слово ''der Bildhauer'' означает:", answer = "Скульптор", textAnswer="", answerArray=new string[4] { "Живопись", "Скульптор", "Архитектура", "Натюрморт" }  },
                new Question { text = "Слово ''die Zeichnung'' означает:", answer = "Чертеж", textAnswer="", answerArray=new string[4] { "Художник", "Скульптура", "Картина", "Чертеж" }  },
                new Question { text = "Слово ''Художник'' на немецком:", answer = "der Kunstler", textAnswer="", answerArray=new string[4] { "der Kunstler", "das Selbstbildnis", "der Bildhauer", "die Malerei" }  },
                new Question { text = "Слово ''der Entwurf'' означает:", answer = "Эскиз", textAnswer="", answerArray=new string[4] { "Впечатление", "Рисунок", "Чертеж", "Эскиз" }  },
                new Question { text = "Слово ''die Ausstellung'' означает:", answer = "Выставка", textAnswer="", answerArray=new string[4] { "Картинная галерея", "Коллекция картин", "Выставка", "Краска" }  },
                new Question { text = "Слово ''die Gemäldegalerie'' означает:", answer = "Картинная галерея", textAnswer="", answerArray=new string[4] { "Картинная галерея", "Коллекция картин", "Выставка", "Влияние" }  },
                new Question { text = "Слово ''Коллекция картин'' на немецком:", answer = "die Gemaldesammlung", textAnswer="", answerArray=new string[4] { "die Gemäldegalerie", "die Wirkung", "die Gemaldesammlung", "die Ausstellung" }  },
                new Question { text = "Слово ''glatt'' означает:", answer = "Ровный", textAnswer="",answerArray=new string[4] { "Наклонный", "Мягкий", "Ровный", "Твердый" }  },
                new Question { text = "Слово ''hart'' означает:", answer = "Твердый", textAnswer="", answerArray=new string[4] { "Наклонный", "Мягкий", "Ровный", "Твердый" } },
                new Question { text = "Слово ''weich'' означает:", answer = "Мягкий", textAnswer="", answerArray=new string[4] { "Наклонный", "Мягкий", "Ровный", "Твердый" }  },
                new Question { text = "Слово ''das Material'' означает:", answer = "Материал", textAnswer="",answerArray=new string[4] { "Холст", "Материал", "Ровный", "Твердый" }  },
                new Question { text = "Слово ''die Leinwand'' означает:", answer = "Холст", textAnswer="", answerArray=new string[4] { "Ровный", "Наклонный", "Материал", "Холст" } },
                new Question { text = "Слово ''gerade'' означает:", answer = "Прямой", textAnswer="", answerArray=new string[4] { "Прямой", "Наклонный", "Твердый", "Кривой" }  },
                new Question { text = "Слово ''schief'' означает:", answer = "Наклонный", textAnswer="", answerArray=new string[4] { "Прямой", "Наклонный", "Твердый", "Кривой" }  },
                new Question { text = "Слово ''die Farbe'' означает:", answer = "Краска", textAnswer="", answerArray=new string[4] { "Краска", "Краситель", "Холст", "Цвет" }  },
                new Question { text = "Слово ''Холст'' на немецком:", answer = "die Leinwand", textAnswer="", answerArray=new string[4] { "die Flache", "das Material", "die Leinwand", "die Bildersammlung" }  },
                new Question { text = "Слово ''Поверхность'' на немецком:", answer = "die Flache", textAnswer="", answerArray=new string[4] { "die Flache", "das Material", "die Leinwand", "die Bildersammlung" }  },
                new Question { text = "Слово ''der Eindruck'' означает:", answer = "Впечатление", textAnswer="", answerArray=new string[4] { "Впечатление", "Представление", "Влияние", "Изображение" }  },
                new Question { text = "Слово ''Прозрачный'' на немецком:", answer = "durchsichtig", textAnswer="", answerArray=new string[4] { "die Flache", "die Skizze", "durchsichtig", "das Material" }  },
                new Question { text = "Слово ''Художественный'' на немецком:", answer = "kunstlerisch", textAnswer="", answerArray=new string[4] { "die Kunst", "durchsichtig", "darstellen", "kunstlerisch" }  },
               

            };
            Question[] questionsArrayjugend = {

                new Question { text = "Слово ''die Jugend'' означает:", answer = "Молодёжь", textAnswer="",answerArray=new string[4] { "Молодёжь", "Взрослый", "Старый", "Молодой" }  },
                new Question { text = "Слово ''unabhängig'' означает:", answer = "Независимый", textAnswer="", answerArray=new string[4] { "Независимый", "Равнодушный", "Уверенный", "Самоуверенный" } },
                new Question { text = "Слово ''Любопытный'' на немецком:", answer = "neugierig", textAnswer="", answerArray=new string[4] { "neugierig", "gleichgültig", "launisch", "selbstbewusst" }  },
                new Question { text = "Слово ''launisch'' означает:", answer = "Капризный", textAnswer="", answerArray=new string[4] { "neugierig", "gleichgültig", "launisch", "selbstbewusst" }  },
                new Question { text = "Слово ''selbstbewusst'' означает:", answer = "Самоуверенный", textAnswer="", answerArray=new string[4] { "Уверенный", "Самоуверенный", "Гордый", "Неуверенный" }  },
                new Question { text = "Слово ''Гордый'' на немецком:", answer = "stolz", textAnswer="", answerArray=new string[4] { "selbstsicher", "unsicher", "sorglos", "stolz" }  },
                new Question { text = "Слово ''sorglos'' означает:", answer = "Беззаботный", textAnswer="", answerArray=new string[4] { "Уверенный", "Неуверенный", "Беззаботный", "Гордый" }  },
                new Question { text = "Слово ''neugierig'' означает:", answer = "Любопытный", textAnswer="", answerArray=new string[4] { "Любопытный", "Гордый", "Уверенный", "избалованный" }  },
                new Question { text = "Слово ''Избалованный'' на немецком:", answer = "verwohnt", textAnswer="", answerArray=new string[4] { "jung", "stolz", "unsicher", "verwohnt" }  },
                new Question { text = "Слово ''Молодой'' на немецком:", answer = "jung", textAnswer="", answerArray=new string[4] { "jung", "stolz", "unsicher", "verwohnt" }  },
                new Question { text = "Слово ''die Erwachsene'' означает:", answer = "Взрослый", textAnswer="",answerArray=new string[4] { "Взрослый", "Общественный", "Добровольный", "Бедный" }  },
                new Question { text = "Слово ''gesellschaftlich'' означает:", answer = "Общественный", textAnswer="", answerArray=new string[4] { "Взрослый", "Общественный", "Добровольный", "Бедный" } },
                new Question { text = "Слово ''Акция'' на немецком:", answer = "die Aktion", textAnswer="", answerArray=new string[4] { "freiwillig", "die Aktion", "das Rote Kreuz", "arm" }  },
                new Question { text = "Слово ''arm'' означает:", answer = "Бедный", textAnswer="",answerArray=new string[4] { "Акция", "Красный крест", "Честь", "Бедный" }  },
                new Question { text = "Слово ''die Ehre'' означает:", answer = "Честь", textAnswer="", answerArray=new string[4] { "Воспитание", "Акция", "Бедный", "Честь" } },
                new Question { text = "Слово ''Член (органиации)'' на немецком:", answer = "das Mitglied", textAnswer="", answerArray=new string[4] { "erziehen", "das Mitglied", "der Verband", "das Rote Kreuz" }  },
                new Question { text = "Слово ''der Verband'' означает:", answer = "Общество", textAnswer="", answerArray=new string[4] { "Красный крест", "Член (организации)", "Осуществление", "Общество" }  },
                new Question { text = "Словосочетание ''das Rote Kreuz'' означает:", answer = "Красный крест", textAnswer="", answerArray=new string[4] { "Красный крест", "Член (организации)", "Осуществление", "Общество" }  },
                new Question { text = "Слово ''Требование'' на немецком:", answer = "die Forderung", textAnswer="", answerArray=new string[4] { "das Mitglied", "der Verband", "erziehen", "die Forderung" }  },
                new Question { text = "Слово ''Воспитывать'' на немецком:", answer = "erziehen", textAnswer="", answerArray=new string[4] { "bevorzugen", "die Forderung", "verbinden", "erziehen" }  },
                new Question { text = "Слово ''Предпочитать'' на немецком:", answer = "bevorzugen", textAnswer="", answerArray=new string[4] { "bevorzugen", "die Forderung", "verbinden", "erziehen" }  },


            };

            Question[] questionsArraywissen = {

                new Question { text = "Слово ''die Zukunft'' означает:", answer = "Будущее", textAnswer="",answerArray=new string[4] { "Будущее", "Прошлое", "Настоящее", "Столетие" }  },
                new Question { text = "Слово ''die Vergangenheit'' означает:", answer = "Прошлое", textAnswer="", answerArray=new string[4] { "Будущее", "Прошлое", "Настоящее", "Столетие" } },
                new Question { text = "Слово ''die Gegenwart'' означает:", answer = "Настоящее", textAnswer="", answerArray=new string[4] { "Будущее", "Прошлое", "Настоящее", "Столетие" }  },
                new Question { text = "Слово ''das Jahrhundert'' означает:", answer = "Столетие", textAnswer="", answerArray=new string[4] { "Столетие", "Тысячелетие", "Десятилетие", "Будущее" }  },
                new Question { text = "Слово ''das Jahrtausend'' означает:", answer = "Тысячелетие", textAnswer="", answerArray=new string[4] { "Столетие", "Тысячелетие", "Десятилетие", "Прошлое" }  },
                new Question { text = "Слово ''das Jahrzehnt'' означает:", answer = "Десятилетие", textAnswer="", answerArray=new string[4] { "Столетие", "Тысячелетие", "Десятилетие", "Прошлое" }  },
                new Question { text = "Слово ''erfinden'' означает:", answer = "Изобретать", textAnswer="", answerArray=new string[4] { "Изобретать", "Изобретение", "Изобретатель", "Открывать" }  },
                new Question { text = "Слово ''die Erfindung'' означает:", answer = "Изобретение", textAnswer="", answerArray=new string[4] { "Изобретатель", "Изобретение", "Изобретать", "Открывать" }  },
                new Question { text = "Слово ''der Erfinder'' означает:", answer = "Изобретатель", textAnswer="", answerArray=new string[4] { "Изобретатель", "Изобретение", "Изобретать", "Открывать" }  },
                new Question { text = "Слово ''Умственный труд'' на немецком:", answer = "geistige Arbeit", textAnswer="", answerArray=new string[4] { "korperliche Arbeit", "die Messe", "geistige Arbeit", "die Arbeit" }  },
                new Question { text = "Слово ''Физический труд'' на немецком:", answer = "korperliche Arbeit", textAnswer="",answerArray=new string[4] { "die Messe", "korperliche Arbeit", "die Arbeit", "geistige Arbeit" }  },
                new Question { text = "Слово ''Ярмарка'' на немецком:", answer = "die Messe", textAnswer="", answerArray=new string[4] { "die Messe", "korperliche Arbeit", "die Arbeit", "geistige Arbeit" } },
                new Question { text = "Слово ''Труд'' на немецком:", answer = "die Arbeit", textAnswer="", answerArray=new string[4] { "korperliche Arbeit", "die Messe", "geistige Arbeit", "die Arbeit" }  },
                new Question { text = "Слово ''der Wissenschaftler'' означает:", answer = "Учёный", textAnswer="",answerArray=new string[4] { "Учёный", "Наука", "Исследователь", "Учитель" }  },
                new Question { text = "Слово ''der Forscher'' означает:", answer = "Исследователь", textAnswer="", answerArray=new string[4] { "Учёный", "Наука", "Исследователь", "Учитель" } },
                new Question { text = "Слово ''Знаниe'' на немецком:", answer = "das Wissen", textAnswer="", answerArray=new string[4] { "das Wissen", "die Messe", "geistige Arbeit", "die Arbeit" }  },
                new Question { text = "Слово ''die Naturwissenschaft'' означает:", answer = "Естествознание", textAnswer="", answerArray=new string[4] { "Точная наука", "Наука", "Естествознание", "Познание" }  },
                new Question { text = "Слово ''der Erforscher'' означает:", answer = "Исследователь", textAnswer="", answerArray=new string[4] { "Учёный", "Наука", "Исследователь", "Учитель" } },
                new Question { text = "Слово ''Электростанция'' на немецком:", answer = "das Kraftwerk", textAnswer="", answerArray=new string[4] { "das Kraftwerk", "das Atomkraftwerk", "das Windrad", "der Preis" }  },
                new Question { text = "Слово ''die Produktion'' означает:", answer = "Производство", textAnswer="", answerArray=new string[4] { "Производство", "Производитель", "Станция", "Завод" }  },
                new Question { text = "Слово ''das Windrad'' означает:", answer = "Ветряк", textAnswer="", answerArray=new string[4] { "das Windrad", "das Kraftwerk", "das Atomkraftwerk", "der Preis" }  },
                new Question { text = "Словосочетание ''Атомная электростанция'' на немецком:", answer = "das Atomkraftwerk", textAnswer="", answerArray=new string[4] { "das Windrad", "das Kraftwerk", "das Atomkraftwerk", "der Preis" }  },
                new Question { text = "Слово ''Деятельность'' на немецком:", answer = "die Tatigkeit", textAnswer="", answerArray=new string[4] { "das Vorbild", "die Tatigkeit", "die Gegenwart", "der Nobelpreis" }  },


            };

            Question[] questionsArrayberuf = {

                new Question { text = "Слово ''ausüben'' означает:", answer = "Исполнять", textAnswer="",answerArray=new string[4] { "Исполнять", "Обслуживать", "Возделывать", "Обрабатывать" }  },
                new Question { text = "Словосочетание ''einen Beruf ausüben'' означает:", answer = "Заниматься чем-либо", textAnswer="", answerArray=new string[4] { "Исполнять", "Обрабатывать", "Заниматься чем-либо", "Обслуживать" } },
                new Question { text = "Слово ''Возделывать'' на немецком:", answer = "bebauen", textAnswer="", answerArray=new string[4] { "ausüben", "einen Beruf ausüben", "bedienen", "bebauen" }  },
                new Question { text = "Слово ''bedienen'' означает:", answer = "Обслуживать", textAnswer="", answerArray=new string[4] { "Исполнять", "Обслуживать", "Возделывать", "Обрабатывать" }  },
                new Question { text = "Слово ''reparieren'' означает:", answer = "Ремонтировать", textAnswer="", answerArray=new string[4] { "Исследовать", "Развлекать", "Ремонтировать", "Обслуживать" }  },
                new Question { text = "Слово ''Развлекать'' на немецком:", answer = "unterhalten", textAnswer="", answerArray=new string[4] { "untersuchen", "bedienen", "reparieren", "unterhalten" }  },
                new Question { text = "Слово ''untersuchen'' означает:", answer = "Исследовать", textAnswer="", answerArray=new string[4] { "Исследовать", "Развлекать", "Ремонтировать", "Обслуживать" }  },
                new Question { text = "Слово ''die Begabung'' означает:", answer = "Талант", textAnswer="", answerArray=new string[4] { "Гениальность", "Талант", "Везение", "Удача" }  },
                new Question { text = "Слово ''Подвижный'' на немецком:", answer = "beweglich", textAnswer="", answerArray=new string[4] { "beweglich", "untersuchen", "reparieren", "bedienen" }  },
                new Question { text = "Слово ''die Fähigkeit'' означает:", answer = "Способность", textAnswer="", answerArray=new string[4] { "Способность", "Талант", "Ловкость", "Добросовестность" }  },
                new Question { text = "Слово ''die Geschicklichkeit'' означает:", answer = "Ловкость", textAnswer="",answerArray=new string[4] { "Способность", "Талант", "Ловкость", "Добросовестность" }  },
                new Question { text = "Слово ''die Gewissenhaftigkeit'' означает:", answer = "Добросовестность", textAnswer="", answerArray=new string[4] { "Ловкость", "Добросовестность", "Способность", "Талант" } },
                new Question { text = "Слово ''Работоспособность'' на немецком:", answer = "die Leistungsfähigkeit", textAnswer="", answerArray=new string[4] { "die Zuverlässigkeit", "die Flexibilität", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "Слово ''Надежность'' на немецком:", answer = "die Zuverlässigkeit", textAnswer="",answerArray=new string[4] { "die Zuverlässigkeit", "die Flexibilität", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "Слово ''geschickt'' означает:", answer = "Искусный", textAnswer="", answerArray=new string[4] { "Талантливый", "Способный", "Искусный", "Ловкий" } },
                new Question { text = "Слово ''Гибкость'' на немецком:", answer = "die Flexibilität", textAnswer="", answerArray=new string[4] { "die Zuverlässigkeit", "die Flexibilität", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "Фраза ''geschickte Hände'' означает:", answer = "Умелые руки", textAnswer="", answerArray=new string[4] { "Умелые руки", "Неумелые руки", "Чистые руки", "Кривые руки" }  },
                new Question { text = "Слово ''die Kraft'' означает:", answer = "Сила", textAnswer="", answerArray=new string[4] { "Юмор", "Красота", "Мудрость", "Сила" }  },
                new Question { text = "Слово ''Творчество'' на немецком:", answer = "die Kreativität", textAnswer="", answerArray=new string[4] { "das Angebot", "die Kraft", "die Kreativität", "ausbilden" }  },
                new Question { text = "Слово ''der Bereich'' означает:", answer = "Сфера", textAnswer="", answerArray=new string[4] { "Сила", "Сфера", "Искусство", "Красота" }  },
                new Question { text = "Слово ''das Studium'' означает:", answer = "Учеба", textAnswer="", answerArray=new string[4] { "Сфера", "Красота", "Учеба", "Мудрость" }  },
                new Question { text = "Слово ''Выпускной экзамен'' на немецком:", answer = "die Abschlussprüfung", textAnswer="", answerArray=new string[4] { "ausbilden", "das Angebot", "die Abschlussprüfung", "die Flexibilität" }  },
              
                

            };


            Question[] questionsArrayfamilie = {

                new Question { text = "Слово ''aufwachsen'' означает:", answer = "Вырастать", textAnswer="",answerArray=new string[4] { "Вырастать", "Заботиться", "Уход", "Забота" }  },
                new Question { text = "Слово ''betreuen'' означает:", answer = "Заботиться", textAnswer="", answerArray=new string[4] { "Вырастать", "Заботиться", "Уход", "Забота" } },
                new Question { text = "Слово ''die Betreuung'' означает:", answer = "Уход", textAnswer="", answerArray=new string[4] { "Ухаживать", "Забота", "Уход", "Вырастать" }  },
                new Question { text = "Слово ''einsam'' означает:", answer = "Одинокий", textAnswer="", answerArray=new string[4] { "Одинокий", "Воспитание", "Поколение", "Ссорится" }  },
                new Question { text = "Слово ''die Erziehung'' означает:", answer = "Воспитание", textAnswer="", answerArray=new string[4] { "Ссориться", "Забота", "Воспитание", "Поведение" }  },
                new Question { text = "Слово ''Ссориться'' на немецком:", answer = "sich Streiten", textAnswer="", answerArray=new string[4] { "sich Streiten", "minderjährig", "die Generation", "einsam" }  },
                new Question { text = "Слово ''minderjährig'' означает:", answer = "Несовершеннолетний", textAnswer="", answerArray=new string[4] { "Молодой", "Старый", "Совершеннолетний", "Несовершеннолетний" }  },
                new Question { text = "Слово ''sich Versöhnen'' означает:", answer = "Помириться", textAnswer="", answerArray=new string[4] { "Посориться", "Помириться", "Ругаться", "Дружить" }  },
                new Question { text = "Слово ''Ладить'' на немецком:", answer = "sich Vertragen", textAnswer="", answerArray=new string[4] { "sich Versöhnen", "sich Vertragen", "die Ehe schließen", "das Ehepaar" }  },
                new Question { text = "Слово ''Брак'' на немецком:", answer = "die Ehe", textAnswer="", answerArray=new string[4] { "sich Versöhnen", "die Ehe schließen", "die Ehe", "volljährig" }  },
                new Question { text = "Фраза ''Вступать в брак'' на немецком:", answer = "die Ehe schließen", textAnswer="",answerArray=new string[4] { "sich Versöhnen", "die Ehe schließen", "die Ehe", "volljährig" }  },
                new Question { text = "Слово ''das Ehepaar'' означает:", answer = "Супруги", textAnswer="", answerArray=new string[4] { "Супружество", "Супруги", "Родители", "Семья" } },
                new Question { text = "Слово ''Разведенный'' на немецком:", answer = "geschieden", textAnswer="", answerArray=new string[4] { "geschieden", "heiraten", "sich Versöhnen", "die Ehe schließen" }  },
                new Question { text = "Слово ''ledig'' означает:", answer = "Холостой", textAnswer="",answerArray=new string[4] { "Холостой", "Разведенный", "Женатый", "Супружество" }  },
                new Question { text = "Слово ''Развод'' на немецком:", answer = "die Scheidung", textAnswer="", answerArray=new string[4] { "geschieden", "heiraten", "ledig", "die Scheidung" } },
                new Question { text = "Слово ''Усыновление'' на немецком:", answer = "die Adoption", textAnswer="", answerArray=new string[4] { "alleinsteehend", "das Adoptivkind", "die Adoption", "die Adoptivneltern" }  },
                new Question { text = "Словосочетание ''Приемный ребенок'' на немецком:", answer = "das Adoptivkind", textAnswer="", answerArray=new string[4] { "alleinsteehend", "das Adoptivkind", "die Adoptivneltern", "die Adoption" }  },
                new Question { text = "Словосочетание ''Приемный отец'' на немецком:", answer = "der Pflegevater", textAnswer="", answerArray=new string[4] { "die Braut", "die Pflegemutter", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Словосочетание ''Приемная мать'' на немецком:", answer = "", textAnswer="die Pflegemutter", answerArray=new string[4] { "die Braut", "die Pflegemutter", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Слово ''Невеста'' на немецком:", answer = "die Braut", textAnswer="", answerArray=new string[4] { "die Braut", "die Pflegemutter", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Слово ''Жених'' на немецком:", answer = "der Bräutigam", textAnswer="", answerArray=new string[4] { "die Braut", "die Pflegemutter", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Словосочетание ''Обручальное кольцо'' на немецком:", answer = "der Trauring", textAnswer="", answerArray=new string[4] { "der Trauring", "die Braut", "der Pflegevater", "das Adoptivkind" }  },
                

            };

            Question[] questionsArraytour = {

                new Question { text = "Слово ''der Ausflug'' означает:", answer = "экскурсия", textAnswer="",answerArray=new string[4] { "путеводитель", "путешествие", "экскурсия", "справочное бюро" }  },
                new Question { text = "Слово ''die Reise'' означает:", answer = "путешествие", textAnswer="", answerArray=new string[4] { "путеводитель", "путешествие", "экскурсия", "справочное бюро" } },
                new Question { text = "Слово ''der Reiseführer'' означает:", answer = "путеводитель", textAnswer="", answerArray=new string[4] { "уезжать", "экскурсия", "путеводитель", "путешествие" }  },
                new Question { text = "Слово ''abreisen'' означает:", answer = "уезжать", textAnswer="", answerArray=new string[4] { "справка", "прибытие", "отъезд", "уезжать" }  },
                new Question { text = "Слово ''die Ankunft'' означает:", answer = "прибытие", textAnswer="", answerArray=new string[4] { "справка", "прибытие", "отъезд", "уезжать" }  },
                new Question { text = "Слово ''die Auskunft'' означает:", answer = "справка", textAnswer="", answerArray=new string[4] { "справка", "прибытие", "отъезд", "уезжать" }  },
                new Question { text = "Слово ''das Auskunftsbüro'' означает:", answer = "справочное бюро", textAnswer="", answerArray=new string[4] { "справочное бюро", "вокзал", "бюро находок", "билетная касса" }  },
                new Question { text = "Слово ''der Schalter'' означает:", answer = "билетная касса", textAnswer="", answerArray=new string[4] { "справочное бюро", "бюро находок", "вокзал", "билетная касса" }  },
                new Question { text = "Слово ''das Fundbüro'' означает:", answer = "бюро находок", textAnswer="", answerArray=new string[4] { "бюро находок", "вокзал", "путеводитель", "справочное бюро" }  },
                new Question { text = "Слово ''das Gepack'' означает:", answer = "багаж", textAnswer="", answerArray=new string[4] { "багаж", "сдать багаж", "путь", "рельсовый путь" }  },
                new Question { text = "Слово ''das Gepäck aufgeben'' означает:", answer = "сдать багаж", textAnswer="",answerArray=new string[4] { "сдать багаж", "рельсовый путь", "билетная касса", "туристская база" }  },
                new Question { text = "Слово ''поезд'' на немецком:", answer = "der Zug", textAnswer="", answerArray=new string[4] { "der Zug", "reisen", "die Bahn", "einsteigen" } },
                new Question { text = "Слово ''aussteigen'' означает:", answer = "выходить (из транспорта)", textAnswer="", answerArray=new string[4] { "садиться (в транспорт)", "выходить (из транспорта)", "выходить (из дома)", "входить (в дом)" }  },
                new Question { text = "Слово ''besorgen'' означает:", answer = "покупать", textAnswer="",answerArray=new string[4] { "путешествовать", "заказывать", "бронировать", "покупать" }  },
                new Question { text = "Слово ''bestellen'' означает:", answer = "заказывать", textAnswer="", answerArray=new string[4] { "путешествовать", "заказывать", "бронировать", "покупать" } },
                new Question { text = "Слово ''buchen'' означает:", answer = "бронировать", textAnswer="", answerArray=new string[4] { "путешествовать", "заказывать", "бронировать", "покупать" }  },
                new Question { text = "Слово ''das Erlebnis'' означает:", answer = "событие", textAnswer="", answerArray=new string[4] { "событие", "сдать багаж", "путешествовать", "рельсовый путь" }  },
                new Question { text = "Словосочетание ''рельсовый путь'' на немецком:", answer = "das Gleis", textAnswer="", answerArray=new string[4] { "das Gleis", "das Gepäck aufgeben", "der Schalter", "die Jugendherberge" }  },
                new Question { text = "Словосочетание ''туристическая база'' на немецком:", answer = "die Jugendherberge", textAnswer="", answerArray=new string[4] { "üderbernachten", "die Jugendherberge", "das Gepack", "das Auskunftsbüro" }  },
                new Question { text = "Словосочетание ''железная дорога'' на немецком:", answer = "die Eisenbahn", textAnswer="", answerArray=new string[4] { "die Jugendherberge", "die Eisenbahn", "das Gleis", "reisen" }  },
                new Question { text = "Слово ''ночевать'' на немецком:", answer = "üderbernachten", textAnswer="", answerArray=new string[4] { "üderbernachten", "das Erlebnis", "bestellen", "besorgen" }  },


            };


            Question[] questionsArrayunwelt = {

                new Question { text = "Слово ''der Abfall'' означает:", answer = "oтброcы", textAnswer="",answerArray=new string[4] { "грязь", "oтброcы", "засарять", "мусор" }  },
                new Question { text = "Слово ''das Abgas'' означает:", answer = "выхлопной газ", textAnswer="", answerArray=new string[4] { "выхлопной газ", "отбросы", "грязь", "мусор" } },
                new Question { text = "Слово ''шум'' на немецком:", answer = "der Lärm", textAnswer="", answerArray=new string[4] { "der Schmutz", "das Düngemittel", "der Müll", "der Lärm" }  },
                new Question { text = "Слово ''мусор'' на немецком:", answer = "der Müll", textAnswer="", answerArray=new string[4] { "der Schmutz", "das Düngemittel", "der Müll", "der Lärm" }  },
                new Question { text = "Слово ''der Schmutz'' означает:", answer = "грязь", textAnswer="", answerArray=new string[4] { "отбросы", "грязь", "выхлопной газ", "мусор" }  },
                new Question { text = "Слово ''удобрение'' на немецком:", answer = "das Düngemittel", textAnswer="", answerArray=new string[4] { "das Düngemittel", "der Müll", "der Lärm", "der Schmutz" }  },
                new Question { text = "Слово ''der Staub'' означает:", answer = "пыль", textAnswer="", answerArray=new string[4] { "загрязнение", "грязь", "пыль", "музор" }  },
                new Question { text = "Слово ''das Gift'' означает:", answer = "яд", textAnswer="", answerArray=new string[4] { "яд", "пыль", "опасность", "вред" }  },
                new Question { text = "Фраза ''животные, которым грозит исчезновение'' на немецком:", answer = "bedrohte Tiere", textAnswer="", answerArray=new string[4] { "bedrohte Tiere", "der Staub", "das Gift", "die Gefahr" }  },
                new Question { text = "Слово ''вредить'' на немецком:", answer = "schaden", textAnswer="", answerArray=new string[4] { "der Müll", "schaden", "das Düngemittel", "bedrohte Tiere" }  },
                new Question { text = "Слово ''verbrennen'' означает:", answer = "сжигать", textAnswer="",answerArray=new string[4] { "пыль", "отравлять", "вредить", "сжигать" }  },
                new Question { text = "Слово ''vergiften'' означает:", answer = "отравлять", textAnswer="", answerArray=new string[4] { "пыль", "отравлять", "вредить", "сжигать" } },
                new Question { text = "Слово ''загрязнять'' на немецком:", answer = "verschmutzen", textAnswer="", answerArray=new string[4] { "bedrohte Tiere", "der Müll", "das Düngemittel", "verschmutzen" }  },
                new Question { text = "Слово ''verseuchte'' означает:", answer = "заражать", textAnswer="",answerArray=new string[4] { "заражать", "загрязнять", "разрушать", "удалять" }  },
                new Question { text = "Слово ''zerstören'' означает:", answer = "разрушать", textAnswer="", answerArray=new string[4] { "разрушать", "утилизировать", "заражать", "удалять" } },
                new Question { text = "Слово ''удалять'' на немецком:", answer = "entsorgen", textAnswer="", answerArray=new string[4] { "zerstören", "verseuchte", "bedrohte Tiere", "entsorgen" }  },
                new Question { text = "Слово ''herstellen'' означает:", answer = "производить", textAnswer="", answerArray=new string[4] { "убирать", "очищать", "производить", "утилизировать" }  },
                new Question { text = "Слово ''die Herstellung'' означает:", answer = "производство", textAnswer="", answerArray=new string[4] { "производство", "производить", "утилизировать", "убирать" }  },
                new Question { text = "Слово ''заповедник'' на немецком:", answer = "das Naturschutzgebiet", textAnswer="", answerArray=new string[4] { "der Schutz", "der Sauerstoff", "die Herstellung", "das Naturschutzgebiet" }  },
                new Question { text = "Слово ''sparen'' означает:", answer = "экономить", textAnswer="", answerArray=new string[4] { "экономить", "кислород", "спасать", "чистить" }  },
                new Question { text = "Слово ''die Umwelt'' означает:", answer = "окружающая cреда", textAnswer="", answerArray=new string[4] { "кислород", "окружающая cреда", "производство", "заповедник" }  },
                new Question { text = "Словосочетание ''защита окружающей среды'' на немецком:", answer = "der Umweltschutz", textAnswer="", answerArray=new string[4] { "verarbeiten etwas", "umweltfreundlich", "verbrauchen", "der Umweltschutz" }  },


            };

            Question[] questionsArraysozio = {

                new Question { text = "Слово ''der/die Abgeordnete'' означает:", answer = "депутат", textAnswer="",answerArray=new string[4] { "премьер-министр", "мэр", "президент", "депутат" }  },
                new Question { text = "Слово ''das Gericht'' означает:", answer = "суд", textAnswer="", answerArray=new string[4] { "депутат", "суд", "закон", "правительство" } },
                new Question { text = "Слово ''закон'' на немецком:", answer = "das Gesetz", textAnswer="", answerArray=new string[4] { "das Gericht", "das Parlament", "das Gesetz", "ein Gesetz beachten" }  },
                new Question { text = "Слово ''die Politik'' означает:", answer = "политика", textAnswer="", answerArray=new string[4] { "парламент", "политика", "депутат", "закон" }  },
                new Question { text = "Слово ''der Ministerrat'' означает:", answer = "совет министров", textAnswer="", answerArray=new string[4] { "президент", "министр", "совет министров", "парламент" }  },
                new Question { text = "Слово ''правительство'' на немецком:", answer = "die Regierung", textAnswer="", answerArray=new string[4] { "die Politik", "die Regierung", "gleich", "der Ministerrat" }  },
                new Question { text = "Слово ''der Staat'' означает:", answer = "государство", textAnswer="", answerArray=new string[4] { "государственный", "закон", "суд", "государство" }  },
                new Question { text = "Слово ''der Ausländer'' означает:", answer = "иностранец", textAnswer="", answerArray=new string[4] { "председатель", "меньшинство", "иностранец", "президент" }  },
                new Question { text = "Слово ''герб'' на немецком:", answer = "das Wappen", textAnswer="", answerArray=new string[4] { "die Minderheit", "das Wappen", "der Ausländer", "die Lebensweise" }  },
                new Question { text = "Слово ''меньшинство'' означает:", answer = "die Minderheit", textAnswer="", answerArray=new string[4] { "die Wurzel", "die Verwaltung", "die Minderheit", "das Recht auf etwas" }  },
                new Question { text = "Слово ''die Verwaltung'' означает:", answer = "администрация", textAnswer="",answerArray=new string[4] { "администрация", "государство", "правительство", "совет министр" }  },
                new Question { text = "Слово ''der/die Vorsitzende'' означает:", answer = "председатель", textAnswer="", answerArray=new string[4] { "мэр", "президент", "министр", "председатель" } },
                new Question { text = "Слово ''памятник'' на немецком:", answer = "das Denkmal", textAnswer="", answerArray=new string[4] { "die Wurzel", "errichten", "die Lebensweise", "das Denkmal" }  },
                new Question { text = "Слово ''корень'' означает:", answer = "die Wurzel", textAnswer="",answerArray=new string[4] { "die Wurzel", "errichten", "die Lebensweise", "das Denkmal" }  },
                new Question { text = "Словосочетание ''национальный костюм'' на немецком:", answer = "das Volkstracht", textAnswer="", answerArray=new string[4] { "errichten", "die Lebensweise", "das Volkstracht", "das Denkmal" } },
                new Question { text = "Словосочетание ''литературный язык'' на немецком:", answer = "das Schriftsprache", textAnswer="", answerArray=new string[4] { "das Schriftsprache", "das Wappen", "der Ausländer", "die Lebensweise" }  },
                new Question { text = "Слово ''die Verfassung'' означает:", answer = "конституция", textAnswer="", answerArray=new string[4] { "министр", "закон", "суд", "конституция" }  },
                new Question { text = "Слово ''равноправие'' на немецком:", answer = "die Gleichberechtigung", textAnswer="", answerArray=new string[4] { "das Vielfalt", "die Gleichberechtigung", "der Ministerrat", "die Wurzel" }  },
                new Question { text = "Слово ''воздвигать'' на немецком:", answer = "errichten", textAnswer="", answerArray=new string[4] { "gesetzlich", "das Denkmal", "gleich", "errichten" }  },
                new Question { text = "Слово ''das Vielfalt'' означает:", answer = "разнообразие", textAnswer="", answerArray=new string[4] { "равноправие", "разнообразие", "корень", "меньшинство" }  },
                new Question { text = "Слово ''die Repräsentantenkammer der Nationalversammlung'' означает:", answer = "палата представителей", textAnswer="", answerArray=new string[4] { "правительство", "президент", "совет министров", "палата представителей" }  },
                new Question { text = "Слово ''законный'' на немецком:", answer = "gesetzlich", textAnswer="", answerArray=new string[4] { "gesetzlich", "das Denkmal", "gleich", "errichten" }  },

            };
            Question[] questionsArraynac = {

                new Question { text = "Слово ''anständig'' означает:", answer = "приличный", textAnswer="",answerArray=new string[4] { "приличный", "честолюбивый", "гостеприимный", "общительный" }  },
                new Question { text = "Слово ''gesellig'' означает:", answer = "общительный", textAnswer="", answerArray=new string[4] { "приличный", "честолюбивый", "гостеприимный", "общительный" } },
                new Question { text = "Слово ''ehrgeizig'' означает:", answer = "честолюбивый", textAnswer="", answerArray=new string[4] { "приличный", "честолюбивый", "гостеприимный", "общительный" }  },
                new Question { text = "Слово ''gutmitig'' означает:", answer = "добродушный", textAnswer="", answerArray=new string[4] { "радушие", "добродушный", "добросовестный", "последовательный" }  },
                new Question { text = "Слово ''konsequent'' означает:", answer = "последовательный", textAnswer="", answerArray=new string[4] { "надежный", "бережливый", "добродушный", "последовательный" }  },
                new Question { text = "Слово ''sparsam'' означает:", answer = "бережливый", textAnswer="", answerArray=new string[4] { "надежный", "бережливый", "добродушный", "последовательный" }  },
                new Question { text = "Слово ''milde'' означает:", answer = "мягкие", textAnswer="", answerArray=new string[4] { "мягкие", "острые", "строгие", "нежные" }  },
                new Question { text = "Слово ''scharfe'' означает:", answer = "острые", textAnswer="", answerArray=new string[4] { "мягкие", "острые", "строгие", "нежные" }  },
                new Question { text = "Слово ''strenge'' означает:", answer = "строгие", textAnswer="", answerArray=new string[4] { "мягкие", "острые", "строгие", "нежные"}  },
                new Question { text = "Слово ''надежный'' на немецком:", answer = "zuverlässig", textAnswer="", answerArray=new string[4] { "ernst", "gewissenhaft", "zuverlässig", "beneiden" }  },
                new Question { text = "Слово ''rücksichtslos'' означает:", answer = "бесцеремонный", textAnswer="",answerArray=new string[4] { "бесцеремонный", "добросовестный", "скупой", "серьезный" }  },
                new Question { text = "Слово ''umganglich'' означает:", answer = "обходительный", textAnswer="", answerArray=new string[4] { "близкий", "обходительный", "знакомый", "надежный" } },
                new Question { text = "Слово ''бесцеремонный'' на немецком:", answer = "rücksichtslos", textAnswer="", answerArray=new string[4] { "vertraut", "gewissenhaft", "sparsam", "rücksichtslos" }  },
                new Question { text = "Слово ''der Respekt'' означает:", answer = "уважение", textAnswer="",answerArray=new string[4] { "неуважение", "уважение", "зависть", "скупость" }  },
                new Question { text = "Слово ''vertraut'' означает:", answer = "знакомый", textAnswer="", answerArray=new string[4] { "бесцеремонный", "знакомый", "близкий", "родной" } },
                new Question { text = "Слово ''die Gesichtszüge (Pl.)'' означает:", answer = "черты лица", textAnswer="", answerArray=new string[4] { "черты лица", "нация", "устанавливать личность", "уважать" }  },
                new Question { text = "Слово ''geizig'' означает:", answer = "скупой", textAnswer="", answerArray=new string[4] { "щедрый", "добродушный", "скупой", "последовательный" }  },
                new Question { text = "Слово ''die Großzügigkeit'' означает:", answer = "щедрость", textAnswer="", answerArray=new string[4] { "экономичность", "надёжность", "щедрость", "скупость" }  },
                new Question { text = "Слово ''серьёзный'' на немецком:", answer = "ernst", textAnswer="", answerArray=new string[4] { "identifizieren", "der Respekt", "ernst", "die Nation" }  },
                new Question { text = "Фраза ''überzeugen jemanden (Akk.) von etwas (Dat.)'' означает:", answer = "убеждать кого-либо", textAnswer="", answerArray=new string[4] { "объяснять кому-либо", "знакомиться", "уважать", "убеждать кого-либо" }  },
                new Question { text = "Слово ''добросовестный'' на немецком:", answer = "gewissenhaft", textAnswer="", answerArray=new string[4] { "gewissenhaft", "zuverlässig", "beneiden", "rücksichtslos" }  },


            };
            Question[] questionsArrayintz = {

                new Question { text = "Слово ''die Botschaft'' означает:", answer = "Посольство", textAnswer="",answerArray=new string[4] { "Посольство", "Правительство", "Президент", "Организация" }  },
                new Question { text = "Слово ''UNESCO'' означает:", answer = "ЮНЕСКО", textAnswer="", answerArray=new string[4] { "ООН", "ЮНЕСКО", "ГГАЭК", "Европейский Союз" } },
                new Question { text = "Слово ''die UNO'' означает:", answer = "ООН", textAnswer="", answerArray=new string[4] { "ГГАЭК", "ЮНЕСКО", "ООН", "Европейский Союз" }  },
                new Question { text = "Слово ''die Europäische Union'' означает:", answer = "Европейский Союз", textAnswer="", answerArray=new string[4] { "Европейский Союз", "ГГАЭК", "ООН", "ЮНЕСКО" }  },
                new Question { text = "Слово ''gewährleisten'' означает:", answer = "Гарантировать", textAnswer="", answerArray=new string[4] { "Соединять", "Объединять", "Гарантировать", "Защищать" }  },
                new Question { text = "Слово ''Безопасность'' на немецком:", answer = "die Sicherheit", textAnswer="", answerArray=new string[4] { "die Sicherheit", "der Frieden", "die Vereinigung", "der Verständigung" }  },
                new Question { text = "Слово ''respektieren'' означает:", answer = "Уважать", textAnswer="", answerArray=new string[4] { "Уважать", "Уважение", "Обобщать", "Обобщение" }  },
                new Question { text = "Слово ''die Gemeinschaft'' означает:", answer = "Общность", textAnswer="", answerArray=new string[4] { "Сообщество", "Общность", "Мероприятие", "Ответственность" }  },
                new Question { text = "Слово ''Мероприятие'' на немецком:", answer = "die Veranstaltung", textAnswer="", answerArray=new string[4] { "die Sicherheit", "die Veranstaltung", "die Vereinigung", "der Verständigung" }  },
                new Question { text = "Слово ''Ответственный'' на немецком:", answer = "verantwortungsvoll", textAnswer="", answerArray=new string[4] { "die Verantwortung", "die Toleranz", "verantwortungsvoll", "respektieren" }  },
                new Question { text = "Слово ''die Toleranz'' означает:", answer = "Терпимость", textAnswer="",answerArray=new string[4] { "Терпимость", "Ответственность", "Уважение", "Характер" }  },
                new Question { text = "Слово ''die Vereinigung'' означает:", answer = "Союз", textAnswer="", answerArray=new string[4] { "Союз", "Кооперация", "Наследие", "Ответственность" } },
                new Question { text = "Слово ''Мир'' на немецком:", answer = "der Frieden", textAnswer="", answerArray=new string[4] { "die Vereinigung", "das Erbe", "die Vereinigung", "der Frieden" }  },
                new Question { text = "Слово ''das Erbe'' означает:", answer = "Наследие", textAnswer="",answerArray=new string[4] { "Мир", "Мероприятие", "Наследие", "Содружество" }  },
                new Question { text = "Слово ''vereinen'' означает:", answer = "Объединять", textAnswer="", answerArray=new string[4] { "Объединять", "Соединение", "Содружество", "Наследие" } },
                new Question { text = "Слово ''der Verständigung'' означает:", answer = "Взаимопонимание", textAnswer="", answerArray=new string[4] { "Объединять", "Взаимопонимание", "Содружество", "Наследие" }  },
                new Question { text = "Фраза ''die Bereitschaft zu etwas'' означает:", answer = "Готовность к (чему-л.)", textAnswer="", answerArray=new string[4] { "Готовность к (чему-л.)", "Быть готовым", "Быть ответственным", "Уважать" }  },
                new Question { text = "Фраза ''bereit sein zu etwas'' означает:", answer = "Быть готовым на (что-л.)", textAnswer="", answerArray=new string[4] { "Быть готовым", "Готовность к (чему-л.)", "Уважать", "Быть ответственным" }  },
                new Question { text = "Фраза ''eine Veranstaltung durchführen'' означает:", answer = "Проводить мероприятие", textAnswer="", answerArray=new string[4] { "Проводить мероприятие", "Быть на мероприятии", "Относиться с уважением", "Быть ответственным" }  },
                new Question { text = "Слово ''Общность'' на немецком:", answer = "die Gemeinschaft", textAnswer="", answerArray=new string[4] { "die Toleranz", "das Erbe", "die Gemeinschaft", "der Frieden" }  },
               
            };
            




            var rand = new Random();
           
            
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Тест Houses and homes",
                TestNumber = "1",
                Preload = "Тест на проверку знаний из главы Houses and homes",
                Complited = item.Task1_comp,
                CorrectCount = Convert.ToInt32(item.Test1),
                Questions = questionsArrayhouse.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест Unit Education",
                Complited = item.Task2_comp,
                Preload = "Тест на проверку знаний из главы Education",
                TestNumber = "2",
                CorrectCount = Convert.ToInt32(item.Test2),
                Questions = questionsArrayeduc.OrderBy(x => rand.Next()).Take(10).ToList(),

                //Questions = {
                //    new Question { text = "Слово ''Hello'' означает:", answer = "Привет", textAnswer = "Привет", answerArray = new string[4] { "Пока", "Привет", "Прощай", "До свидания" } },
                //    new Question { text = "Слово ''Goodbye'' означает:", answer = "До свидания", textAnswer = "До свидания", answerArray = new string[4] { "Привет", "Пока", "До свидания", "Прощай" } },
                //    new Question { text = "Слово ''Сон'' на английском:", answer = "Dream", textAnswer = "Dream", answerArray = new string[4] { "Dream", "Night", "Day", "Child" } },
                //    new Question { text = "Слово ''Human'' означает:", answer = "Человек", textAnswer = "Человек", answerArray = new string[4] { "Человек", "Сон", "Ночь", "День" } },
                //    new Question { text = "Слово ''Child'' означает:", answer = "Ребенок", textAnswer = "Ребенок", answerArray = new string[4] { "Мужчина", "Девушка", "Мама", "Ребенок" } },
                //    new Question { text = "Слово ''День'' на английском:", answer = "Day", textAnswer = "Day", answerArray = new string[4] { "Night", "Day", "Monday", "Sunday" } },
                //    new Question { text = "Слово ''Computer'' означает:", answer = "Компьютер", textAnswer = "Компьютер", answerArray = new string[4] { "Телевизор", "Смартфон", "Компьютер", "Планшет" } },
                //    new Question { text = "Слово ''Word'' означает:", answer = "Слово", textAnswer = "Слово", answerArray = new string[4] { "Слово", "Текст", "Дом", "Арбуз" } },
                //    new Question { text = "Слово ''Ночь'' на английском:", answer = "Night", textAnswer = "Night", answerArray = new string[4] { "Day", "Night", "Country", "College" } },
                //    new Question { text = "Слово ''Тест'' на английском:", answer = "Test", textAnswer = "Test", answerArray = new string[4] { "Word", "House", "Day", "Test" } },
                //},




            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Тест Mass Media",
                TestNumber = "3",
                Preload = "Тест на проверку знаний из главы Mass Media",
                Complited = item.Task3_comp,
                CorrectCount = Convert.ToInt32(item.Test3),
                Questions = questionsArraymass.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест Youth and society",
                TestNumber = "4",
                Preload = "Тест на проверку знаний из главы Youth and society",
                Complited = item.Task4_comp,
                CorrectCount = Convert.ToInt32(item.Test4),
                Questions = questionsArrayyouth.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест Art",
                TestNumber = "5",
                Preload = "Тест на проверку знаний из главы Art",
                Complited = item.Task5_comp,
                CorrectCount = Convert.ToInt32(item.Test5),
                Questions = questionsArrayart.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест Science",
                TestNumber = "6",
                Preload = "Тест на проверку знаний из главы Science",
                Complited = item.Task6_comp,
                CorrectCount = Convert.ToInt32(item.Test6),
                Questions = questionsArrayscience.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест Family",
                TestNumber = "7",
                Preload = "Тест на проверку знаний из главы Family",
                Complited = item.Task7_comp,
                CorrectCount = Convert.ToInt32(item.Test7),
                Questions = questionsArrayfamily.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест Jobs",
                TestNumber = "8",
                Preload = "Тест на проверку знаний из главы Jobs",
                Complited = item.Task8_comp,
                CorrectCount = Convert.ToInt32(item.Test8),
                Questions = questionsArrayjobs.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест National character",
                TestNumber = "9",
                Preload = "Тест на проверку знаний из главы National character",
                Complited = item.Task9_comp,
                CorrectCount = Convert.ToInt32(item.Test9),
                Questions = questionsArraynaccar.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест International Cultural ties",
                TestNumber = "10",
                Preload = "Тест на проверку знаний из главы International Cultural ties",
                Complited = item.Task10_comp,
                CorrectCount = Convert.ToInt32(item.Test10),
                Questions = questionsArrayintcult.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест Tourism",
                TestNumber = "11",
                Preload = "Тест на проверку знаний из главы Tourism",
                Complited = item.Task11_comp,
                CorrectCount = Convert.ToInt32(item.Test11),
                Questions = questionsArraytourism.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест Environment",
                TestNumber = "12",
                Preload = "Тест на проверку знаний из главы Environment",
                Complited = item.Task12_comp,
                CorrectCount = Convert.ToInt32(item.Test12),
                Questions = questionsArrayenvir.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 1",
                Title = "Tест At home and abroad",
                TestNumber = "13",
                Preload = "Тест на проверку знаний из главы At home and abroad",
                Complited = item.Task13_comp,
                CorrectCount = Convert.ToInt32(item.Test13),
                Questions = questionsArrayathome.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Wohnomoglichleiten",
                TestNumber = "14",
                Preload = "Тест на проверку знаний из главы Wohnomoglichleiten",
                Complited = item.Task14_comp,
                CorrectCount = Convert.ToInt32(item.Test14),
                Questions = questionsArraywohn.OrderBy(x => rand.Next()).Take(10).ToList(),
            });


            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Shulsystem",
                TestNumber = "15",
                Preload = "Тест на проверку знаний из главы Shulsystem",
                Complited = item.Task15_comp,
                CorrectCount = Convert.ToInt32(item.Test15),
                Questions = questionsArrayshul.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Messenmedien",
                TestNumber = "16",
                Preload = "Тест на проверку знаний из главы Messenmedien",
                Complited = item.Task16_comp,
                CorrectCount = Convert.ToInt32(item.Test16),
                Questions = questionsArraymessen.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Kunst und Kunstler",
                TestNumber = "17",
                Preload = "Тест на проверку знаний из главы Kunst und Kunstler",
                Complited = item.Task17_comp,
                CorrectCount = Convert.ToInt32(item.Test17),
                Questions = questionsArraykunst.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Jugend und Gesellschaft",
                TestNumber = "18",
                Preload = "Тест на проверку знаний из главы Jugend und Gesellschaft",
                Complited = item.Task18_comp,
                CorrectCount = Convert.ToInt32(item.Test18),
                Questions = questionsArrayjugend.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            
            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Wissenschaft und Technik",
                TestNumber = "19",
                Preload = "Тест на проверку знаний из главы Wissenschaft und Technik",
                Complited = item.Task19_comp,
                CorrectCount = Convert.ToInt32(item.Test19),
                Questions = questionsArraywissen.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Berufswahl",
                TestNumber = "20",
                Preload = "Тест на проверку знаний из главы Berufswahl",
                Complited = item.Task20_comp,
                CorrectCount = Convert.ToInt32(item.Test20),
                Questions = questionsArrayberuf.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Familie",
                TestNumber = "21",
                Preload = "Тест на проверку знаний из главы Familie",
                Complited = item.Task21_comp,
                CorrectCount = Convert.ToInt32(item.Test21),
                Questions = questionsArrayfamilie.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Tourismus",
                TestNumber = "22",
                Preload = "Тест на проверку знаний из главы Tourismus",
                Complited = item.Task22_comp,
                CorrectCount = Convert.ToInt32(item.Test22),
                Questions = questionsArraytour.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Unwelt",
                TestNumber = "23",
                Preload = "Тест на проверку знаний из главы Unwelt",
                Complited = item.Task23_comp,
                CorrectCount = Convert.ToInt32(item.Test23),
                Questions = questionsArrayunwelt.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Nationalcharakter",
                TestNumber = "24",
                Preload = "Тест на проверку знаний из главы Soziolkulturelles Portat des Landes",
                Complited = item.Task24_comp,
                CorrectCount = Convert.ToInt32(item.Test24),
                Questions = questionsArraysozio.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Nationalcharakter",
                TestNumber = "25",
                Preload = "Тест на проверку знаний из главы Nationalcharakter",
                Complited = item.Task25_comp,
                CorrectCount = Convert.ToInt32(item.Test25),
                Questions = questionsArraynac.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 2",
                Title = "Tест Internationale Zusammenarbeit",
                TestNumber = "26",
                Preload = "Тест на проверку знаний из главы Internationale Zusammenarbeit",
                Complited = item.Task26_comp,
                CorrectCount = Convert.ToInt32(item.Test26),
                Questions = questionsArrayintz.OrderBy(x => rand.Next()).Take(10).ToList(),
            });





















            Question[] Missquestions1 = {
                new Question { text = "Block of ... ", answer = "Flats", textAnswer="", answerArray=new string[4] { "Quiets", "Flats", "Shower", "Attics" } },
                new Question { text = "On ... outskirts ", answer = "The", textAnswer="", answerArray=new string[4] { "In", "A", "The", "Of" }  },
                new Question { text = "Washing ... ", answer = "Machine", textAnswer="", answerArray=new string[4] { "Shower", "Car", "Machine", "Tap" }  },
                new Question { text = "Detached ... ", answer = "House", textAnswer="", answerArray=new string[4] { "House", "Flat", "Home", "Block of flats" } },
                new Question { text = ".... in the center", answer = "Right", textAnswer="", answerArray=new string[4] { "Up", "Left", "On", "Right" }  },
                new Question { text = "Primary ...", answer = "School", textAnswer="", answerArray=new string[4] { "School", "House", "College", "Institution" } },
                new Question { text = "Cloak-...", answer = "Room", textAnswer="", answerArray=new string[4] { "School", "Home", "Flat", "Room" }  },
                new Question { text = "General ... school", answer = "Secondary", textAnswer="", answerArray=new string[4] { "Primary", "Secondary", "Tertiary", "Quaternary" }  },
                new Question { text = "... of charge", answer = "Free", textAnswer="",answerArray=new string[4] { "Paid", "Free", "Freemium", "Paidium" }  },
                new Question { text = "Gomel ... Agro-Economic College", answer = "State", textAnswer="", answerArray=new string[4] { "State", "United", "General", "Canteen" }  },
                new Question { text = "A first ... student", answer = "Year", textAnswer="", answerArray=new string[4] { "Month", "Year", "Day", "Minute" } },
                new Question { text = "... exams", answer = "Pass", textAnswer="", answerArray=new string[4] { "Assembly", "Success", "Double", "Pass" }  },
                new Question { text = "Assembly ...", answer = "Hall", textAnswer="",answerArray=new string[4] { "Class", "Room", "Gym", "Hall" }  },
                new Question { text = "Double ...", answer = "Period", textAnswer="", answerArray=new string[4] { "Period", "Cloak", "Office", "Day" }  },
                new Question { text = "Mass ...", answer = "Media", textAnswer="",answerArray=new string[4] { "Room", "Magazine", "Day", "Media" }  },

                };




            Question[] Missquestions2 = {
                new Question { text = "Generation ...", answer = "Gap", textAnswer="", answerArray=new string[4] { "Far", "Car", "Gap", "Cap" } },
                new Question { text = "... values", answer = "Patriotic", textAnswer="", answerArray=new string[4] { "Patriotic", "Spectacular", "Content", "Express" }  },
                new Question { text = "Point of ...", answer = "View", textAnswer="", answerArray=new string[4] { "View", "Habits", "Point", "Promote" } },
                new Question { text = "Bad ...", answer = "Habits", textAnswer="", answerArray=new string[4] { "Point", "View", "Habits", "Promote" }  },
                new Question { text = "Take ... of", answer = "Care", textAnswer="",answerArray=new string[4] { "Part", "View", "Care", "Drug" }  },
                new Question { text = "Take ...", answer = "Part", textAnswer="", answerArray=new string[4] { "Part", "Care", "View", "Device" }  },
                new Question { text = "Drug ...", answer = "Abuse", textAnswer="", answerArray=new string[4] { "Habits", "Part", "Abuse", "View" }  },
                new Question { text = "Old-...", answer = "Fashioned", textAnswer="", answerArray=new string[4] { "Content", "Part", "Fashioned", "Promote" } },
                new Question { text = "Assembly ...", answer = "Hall", textAnswer="",answerArray=new string[4] { "Class", "Room", "Gym", "Hall" }  },
                new Question { text = "Double ...", answer = "Period", textAnswer="", answerArray=new string[4] { "Period", "Cloak", "Office", "Day" }  },
                new Question { text = "Mass ...", answer = "Media", textAnswer="",answerArray=new string[4] { "Room", "Magazine", "Day", "Media" }  },
                new Question { text = ".... in the center", answer = "Right", textAnswer="", answerArray=new string[4] { "Up", "Left", "On", "Right" }  },
                new Question { text = "Primary ...", answer = "School", textAnswer="", answerArray=new string[4] { "School", "House", "College", "Institution" } },
                new Question { text = "Father-in-...", answer = "Law", textAnswer="", answerArray=new string[4] { "Law", "Ex", "Husband", "Wife" }  },
                new Question { text = "Mother-...-law", answer = "In", textAnswer="", answerArray=new string[4] { "On", "In", "With", "Under" }  },
                new Question { text = "...-Wife", answer = "Ex", textAnswer="",answerArray=new string[4] { "In", "Xe", "Ex", "With" }  },

            };




            Question[] Missquestions3 = {

                new Question { text = "Law-...", answer = "Abiding", textAnswer="", answerArray=new string[4] { "Zone", "Shock", "Kind", "Abiding" }  },
                new Question { text = "Kind-...", answer = "Hearted", textAnswer="", answerArray=new string[4] { "Zone", "Hearted", "Abiding", "Fashioned" }  }, 
                new Question { text = "... zone", answer = "Comfort", textAnswer="", answerArray=new string[4] { "Kind", "Law", "Comfort", "Abiding" } },
                new Question { text = "... shock", answer = "Culture", textAnswer="", answerArray=new string[4] { "Sun", "Electric", "Confort", "Culture" }  },
                new Question { text = "To swear by ...", answer = "Something", textAnswer="",answerArray=new string[4] { "Something", "Shock", "Comfort", "Law" }  },
                new Question { text = "... of someone’s comfort zone", answer = "Burst out", textAnswer="", answerArray=new string[4] { "To swear", "Burst out", "Go beyond", "Immerse" } },
                new Question { text = "Immerse ... in something", answer = "Yourself", textAnswer="", answerArray=new string[4] { "Go", "Grounds", "Yourself", "Beyond" }  },
                new Question { text = "... beyond something", answer = "Go", textAnswer="", answerArray=new string[4] { "Shock", "Go", "Kind", "Take" }  },
                new Question { text = "Stamping ...", answer = "Grounds", textAnswer="", answerArray=new string[4] { "Beyond", "Yourself", "Something", "Grounds" }  },
                new Question { text = "Take ...", answer = "Part", textAnswer="", answerArray=new string[4] { "Part", "Care", "View", "Device" }  },
                new Question { text = "Drug ...", answer = "Abuse", textAnswer="", answerArray=new string[4] { "Habits", "Part", "Abuse", "View" }  },
                new Question { text = "Old-...", answer = "Fashioned", textAnswer="", answerArray=new string[4] { "Content", "Part", "Fashioned", "Promote" } },
                new Question { text = "Block of ... ", answer = "Flats", textAnswer="", answerArray=new string[4] { "Quiets", "Flats", "Shower", "Attics" } },
                new Question { text = "On ... outskirts ", answer = "The", textAnswer="", answerArray=new string[4] { "In", "A", "The", "Of" }  },
                new Question { text = "Washing ... ", answer = "Machine", textAnswer="", answerArray=new string[4] { "Shower", "Car", "Machine", "Tap" }  },
                new Question { text = "Father-in-...", answer = "Law", textAnswer="", answerArray=new string[4] { "Law", "Ex", "Husband", "Wife" }  },
                new Question { text = "Mother-...-law", answer = "In", textAnswer="", answerArray=new string[4] { "On", "In", "With", "Under" }  },
                new Question { text = "...-Wife", answer = "Ex", textAnswer="",answerArray=new string[4] { "In", "Xe", "Ex", "With" }  },

            };

            Question[] Missquestions4 = {


                new Question { text = "Acid ...", answer = "Rains", textAnswer="", answerArray=new string[4] { "Rains", "Effect", "Holes", "Plain" }  },
                new Question { text = "... effect", answer = "Greenhouse", textAnswer="", answerArray=new string[4] { "Global", "Greenhouse", "Ozone", "Acid" }  },
                new Question { text = "Global ...", answer = "Warming", textAnswer="", answerArray=new string[4] { "Effect", "Rains", "Warming", "Holes" }  },
                new Question { text = "The ... of Europe", answer = "Lungs", textAnswer="", answerArray=new string[4] { "Plain", "Lungs", "Effect", "Holes" } },
                new Question { text = "A vast ...", answer = "Plain", textAnswer="", answerArray=new string[4] { "Rains", "Effect", "Holes", "Plain" }  },
                new Question { text = "To be ... from", answer = "Separated", textAnswer="", answerArray=new string[4] { "Separated", "Greenhouse", "Effect", "Global" } },
                new Question { text = "To consist ...", answer = "Of", textAnswer="", answerArray=new string[4] { "On", "Of", "In", "To" }  },
                new Question { text = "To border ...", answer = "On", textAnswer="",answerArray=new string[4] { "On", "Of", "In", "To" }  },
                new Question { text = "To be ...", answer = "Called", textAnswer="", answerArray=new string[4] { "Global", "Rains", "Effect", "Called" } },
                new Question { text = "To influence the ...", answer = "Climate", textAnswer="", answerArray=new string[4] { "Climate", "Rains", "Effect", "Global" }  },
                new Question { text = "Old-...", answer = "Fashioned", textAnswer="", answerArray=new string[4] { "Content", "Part", "Fashioned", "Promote" } },
                new Question { text = "Block of ... ", answer = "Flats", textAnswer="", answerArray=new string[4] { "Quiets", "Flats", "Shower", "Attics" } },
                new Question { text = "On ... outskirts ", answer = "The", textAnswer="", answerArray=new string[4] { "In", "A", "The", "Of" }  },
                new Question { text = "Washing ... ", answer = "Machine", textAnswer="", answerArray=new string[4] { "Shower", "Car", "Machine", "Tap" }  },
                new Question { text = "Gomel ... Agro-Economic College", answer = "State", textAnswer="", answerArray=new string[4] { "State", "United", "General", "Canteen" }  },
                new Question { text = "A first ... student", answer = "Year", textAnswer="", answerArray=new string[4] { "Month", "Year", "Day", "Minute" } },
                new Question { text = "... exams", answer = "Pass", textAnswer="", answerArray=new string[4] { "Assembly", "Success", "Double", "Pass" }  },

            };


            Question[] Missquestions5 = {
                
                new Question { text = "Block of ... ", answer = "Flats", textAnswer="", answerArray=new string[4] { "Quiets", "Flats", "Shower", "Attics" } },
                new Question { text = "On ... outskirts ", answer = "The", textAnswer="", answerArray=new string[4] { "In", "A", "The", "Of" }  },
                new Question { text = "Washing ... ", answer = "Machine", textAnswer="", answerArray=new string[4] { "Shower", "Car", "Machine", "Tap" }  },
                new Question { text = "Gomel ... Agro-Economic College", answer = "State", textAnswer="", answerArray=new string[4] { "State", "United", "General", "Canteen" }  },
                new Question { text = "A first ... student", answer = "Year", textAnswer="", answerArray=new string[4] { "Month", "Year", "Day", "Minute" } },
                new Question { text = "... exams", answer = "Pass", textAnswer="", answerArray=new string[4] { "Assembly", "Success", "Double", "Pass" }  },
                new Question { text = ".... in the center", answer = "Right", textAnswer="", answerArray=new string[4] { "Up", "Left", "On", "Right" }  },
                new Question { text = "Primary ...", answer = "School", textAnswer="", answerArray=new string[4] { "School", "House", "College", "Institution" } },
                new Question { text = "Cloak-...", answer = "Room", textAnswer="", answerArray=new string[4] { "School", "Home", "Flat", "Room" }  },
                new Question { text = "General ... school", answer = "Secondary", textAnswer="", answerArray=new string[4] { "Primary", "Secondary", "Tertiary", "Quaternary" }  },
                new Question { text = "A vast ...", answer = "Plain", textAnswer="", answerArray=new string[4] { "Rains", "Effect", "Holes", "Plain" }  },
                new Question { text = "To be ... from", answer = "Separated", textAnswer="", answerArray=new string[4] { "Separated", "Greenhouse", "Effect", "Global" } },
                new Question { text = "To consist ...", answer = "Of", textAnswer="", answerArray=new string[4] { "On", "Of", "In", "To" }  },
                new Question { text = "To border ...", answer = "On", textAnswer="",answerArray=new string[4] { "On", "Of", "In", "To" }  },
                new Question { text = "Law-...", answer = "Abiding", textAnswer="", answerArray=new string[4] { "Zone", "Shock", "Kind", "Abiding" }  },
                new Question { text = "Kind-...", answer = "Hearted", textAnswer="", answerArray=new string[4] { "Zone", "Hearted", "Abiding", "Fashioned" }  },

            };

            Question[] MissGerquestions1 = {
               
                new Question { text = "... Haus", answer = "das", textAnswer="",answerArray=new string[4] { "das", "der", "die", "ein" }  },
                new Question { text = "... Reihenhaus", answer = "das", textAnswer="", answerArray=new string[4] { "ein", "die", "das", "der" } },
                new Question { text = "ein ... Haus", answer = "eigenes", textAnswer="", answerArray=new string[4] { "das", "streichen", "der", "eigenes" }  },
                new Question { text = "... Treppe", answer = "die", textAnswer="", answerArray=new string[4] { "das", "der", "die", "ein" }  },
                new Question { text = "... Treppenhaus", answer = "idas", textAnswer="", answerArray=new string[4] { "die", "idas", "ein", "der" }  },
                new Question { text = "... Gemütlichkeit", answer = "die", textAnswer="", answerArray=new string[4] { "idas", "ein", "der", "die" }  },
                new Question { text = "... Wohnfläche", answer = "die", textAnswer="", answerArray=new string[4] { "idas", "ein", "der", "die" }  },
                new Question { text = "... Poster", answer = "das", textAnswer="", answerArray=new string[4] { "eigenes", "idas", "ein", "das" } },
                new Question { text = "... Vorhang", answer = "der", textAnswer="", answerArray=new string[4] { "der", "das", "die", "idas" }  },
                new Question { text = "... Untermiete wohnen", answer = "zur", textAnswer="", answerArray=new string[4] { "der", "idas", "zur", "ein" }  },

                new Question { text = "... Berufsschule", answer = "die", textAnswer="", answerArray=new string[4] { "das", "die", "der", "zur" } },
                new Question { text = "... Gymnasium", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "zur", "idas" }  },
                new Question { text = "... Schulbeginn", answer = "der", textAnswer="", answerArray=new string[4] { "der", "die", "das", "zur" }  },
                new Question { text = "... Wahlfach", answer = "das", textAnswer="", answerArray=new string[4] { "der", "die", "das", "zur" }  },
                new Question { text = "... Viertel", answer = "das", textAnswer="", answerArray=new string[4] { "das", "der", "die", "idas" }  },
                new Question { text = "... Schulfach", answer = "das", textAnswer="", answerArray=new string[4] {"der", "die", "das", "zur" }  },
                new Question { text = "... Klassenarbeit", answer = "die", textAnswer="",answerArray=new string[4] { "idas", "eigenes", "die", "das" }  },
                new Question { text = "... Prüfung", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "zur" } },
                new Question { text = "eine ... ablegen", answer = "Prüfung", textAnswer="", answerArray=new string[4] { "Schulbeginn", "Schulfach", "Klassenarbeit", "Prüfung" }  },
               
              

            };

            Question[] MissGerquestions2 = {

                new Question { text = "... Hauptschule", answer = "die", textAnswer="", answerArray=new string[4] { "das", "die", "zur", "der" }  },
                new Question { text = "... Oberstufe", answer = "die", textAnswer="", answerArray=new string[4] { "das", "die", "zur", "der" }  },
                new Question { text = "... Grundstufe", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "zur" }  },
                new Question { text = "... Medium", answer = "das", textAnswer="",answerArray=new string[4] { "eigenes", "zur", "das", "die" }  },
                new Question { text = "... Interview", answer = "das", textAnswer="", answerArray=new string[4] { "das", "eigenes", "die", "zur" }  },
                new Question { text = "... Kommentar", answer = "der", textAnswer="", answerArray=new string[4] { "der", "zur", "eigenes", "streichen" }  },
                new Question { text = "... Leserbrief", answer = "der", textAnswer="", answerArray=new string[4] { "zur", "der", "streichen", "eigenes" }  },
                new Question { text = "... Artikel", answer = "der", textAnswer="", answerArray=new string[4] { "zur", "der", "streichen", "eigenes" }  },
                new Question { text = "... Ereignis", answer = "das", textAnswer="",answerArray=new string[4] { "das", "die", "zur", "der" }  },
                new Question { text = "... Nachricht", answer = "die", textAnswer="", answerArray=new string[4] { "das", "zur", "der", "die" } },
                new Question { text = "... Schlagzeile", answer = "die", textAnswer="", answerArray=new string[4] { "das", "zur", "der", "die" }  },

                new Question { text = "... Kunst", answer = "die", textAnswer="",answerArray=new string[4] { "zur", "der", "die", "das" }  },
                new Question { text = "... Selbstbildnis", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "zur", "der" }  },
                new Question { text = "... Bildhauer", answer = "der", textAnswer="", answerArray=new string[4] { "die", "das", "zur", "der" }  },
                new Question { text = "... Entwurf", answer = "der", textAnswer="", answerArray=new string[4] { "der", "idas", "das", "eigenes" }  },
                new Question { text = "... Ausstellung", answer = "die", textAnswer="", answerArray=new string[4] {"die", "das", "zur", "der" }  },
                new Question { text = "... Gemäldegalerie", answer = "die", textAnswer="", answerArray=new string[4] { "eigenes", "idas", "die", "das" }  },
                new Question { text = "... Material", answer = "das", textAnswer="",answerArray=new string[4] { "das", "eigenes", "idas", "der" }  },
                new Question { text = "... Leinwand", answer = "die", textAnswer="", answerArray=new string[4] { "das", "zur", "der", "die" } },
               
            };

            Question[] MissGerquestions3 = {



                new Question { text = "... Jugend", answer = "die", textAnswer="",answerArray=new string[4] { "idas", "zur", "die", "das" }  },
                new Question { text = "... Erwachsene", answer = "die", textAnswer="",answerArray=new string[4] { "idas", "zur", "die", "das" }  },
                new Question { text = "... Aktion", answer = "die", textAnswer="", answerArray=new string[4] {"idas", "zur", "die", "das" }  },
                new Question { text = "... Mitglied", answer = "das", textAnswer="", answerArray=new string[4] { "das", "der", "zur", "idas" }  },
                new Question { text = "... Verband", answer = "der", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "das ... Kreuz", answer = "Rote", textAnswer="", answerArray=new string[4] { "Rote", "Grün", "Gelb", "Blau" }  },
                new Question { text = "... Forderung", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
               
                new Question { text = "... Zukunft", answer = "die", textAnswer="",answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Vergangenheit", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" } },
                new Question { text = "... Gegenwart", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Jahrhundert", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Jahrtausend", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Jahrzehnt", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Erfindung", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Erfinder", answer = "der", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "korperliche ...", answer = "falsch", textAnswer="", answerArray=new string[4] { "Arbeit", "geistige", "Grün", "Kreuz" }  },
                new Question { text = "... Arbeit", answer = "falsch", textAnswer="",answerArray=new string[4] { "Kreuz", "geistige", "Erfindung", "Erfinder" }  },


            };

            Question[] MissGerquestions4 = {

                new Question { text = "... Betreuung", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Erziehung", answer = "die", textAnswer="", answerArray=new string[4] { "das", "die", "idas", "der" }  },
                new Question { text = "... Vertragen", answer = "sich", textAnswer="", answerArray=new string[4] { "geistige", "sich", "eigenes", "erfinder" }  },
                new Question { text = "... Versöhnen", answer = "sich", textAnswer="", answerArray=new string[4] { "geistige", "sich", "eigenes", "erfinder" }  },
                new Question { text = "... Streiten", answer = "sich", textAnswer="", answerArray=new string[4] { "erfinder", "geistige", "sich", "ehe" }  },
                new Question { text = "... Ehe'':", answer = "die", textAnswer="", answerArray=new string[4] { "die", "idas", "der", "das" }  },
                new Question { text = "die Ehe ...", answer = "schließen", textAnswer="",answerArray=new string[4] { "erfinder", "schließen", "sich", "volljährig" }  },
                new Question { text = "... Ehepaar", answer = "das", textAnswer="", answerArray=new string[4] { "das", "die", "idas", "der" } },
                new Question { text = "... Adoption", answer = "die", textAnswer="", answerArray=new string[4] { "der", "idas", "das", "die" } },
                new Question { text = "... Pflegevater", answer = "der", textAnswer="", answerArray=new string[4] { "idas", "der", "die", "das" }  },
                new Question { text = "... Adoptivkind", answer = "das", textAnswer="", answerArray=new string[4] { "idas", "der", "die", "das" }  },
                new Question { text = "... Braut", answer = "die", textAnswer="", answerArray=new string[4] { "idas", "der", "die", "das" }  },
                new Question { text = "... Pflegemutter", answer = "die", textAnswer="", answerArray=new string[4] { "idas", "der", "die", "das" }  },
                new Question { text = "... Trauring", answer = "der", textAnswer="", answerArray=new string[4] { "idas", "der", "die", "das" }  },
                new Question { text = "... Bräutigam", answer = "der", textAnswer="", answerArray=new string[4] { "idas", "schließen", "das", "der" }  },
                new Question { text = "... Ausflug", answer = "der", textAnswer="",answerArray=new string[4] { "die", "der", "das", "idas" }  },
                new Question { text = "... Reise", answer = "die", textAnswer="", answerArray=new string[4] { "der", "die", "das", "idas" } },

            };
            
            Question[] MissGerquestions5 = {

                
                new Question { text = "... Reiseführer", answer = "der", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Ankunft", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Auskunft", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Auskunftsbüro", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Schalter", answer = "der", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Fundbüro", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Gepack", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Gepäck aufgeben", answer = "das", textAnswer="",answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Zug", answer = "der", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" } },
                new Question { text = "... Erlebnis", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Jugendherberge", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Gleis", answer = "das", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },
                new Question { text = "... Eisenbahn", answer = "die", textAnswer="", answerArray=new string[4] { "die", "das", "der", "idas" }  },

                new Question { text = "die Europäische ...", answer = "Union", textAnswer="", answerArray=new string[4] { "Zustand", "Sicherheit", "OON", "Union" }  },
                new Question { text = "die Bereitschaft zu ...", answer = "etwas", textAnswer="", answerArray=new string[4] { "etwas", "sein", "eine", "der" }  },
                new Question { text = "bereit ... zu etwas", answer = "sein", textAnswer="", answerArray=new string[4] { "etwas", "sein", "eine", "der" }  },
                new Question { text = "... Veranstaltung durchführen", answer = "eine", textAnswer="", answerArray=new string[4] { "eine", "die", "das", "der" }  },
              
            };







            Test.Add(new Test
            {
                Chapter = "Глава 3",
                Title = "Задание ''Missing words'' №1",
                TestNumber = "27",
                Preload = "Задание ''Missing words'' №1",
                Complited = item.Task27_comp,
                CorrectCount = Convert.ToInt32(item.Test27),
                Questions = Missquestions1.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 3",
                Title = "Задание ''Missing words'' №2",
                TestNumber = "28",
                Preload = "Задание ''Missing words'' №2",
                Complited = item.Task28_comp,
                CorrectCount = Convert.ToInt32(item.Test28),
                Questions = Missquestions2.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 3",
                Title = "Задание ''Missing words'' №3",
                TestNumber = "29",
                Preload = "Задание ''Missing words'' №3",
                Complited = item.Task29_comp,
                CorrectCount = Convert.ToInt32(item.Test29),
                Questions = Missquestions3.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 3",
                Title = "Задание ''Missing words'' №4",
                TestNumber = "30",
                Preload = "Задание ''Missing words'' №4",
                Complited = item.Task30_comp,
                CorrectCount = Convert.ToInt32(item.Test30),
                Questions = Missquestions4.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 3",
                Title = "Задание ''Missing words'' №5",
                TestNumber = "31",
                Preload = "Задание ''Missing words'' №5",
                Complited = item.Task31_comp,
                CorrectCount = Convert.ToInt32(item.Test31),
                Questions = Missquestions5.OrderBy(x => rand.Next()).Take(10).ToList(),
            });




            

                Test.Add(new Test
                {
                    Chapter = "Глава 4",
                    Title = "Задание ''Fehlende Wörter'' №1",
                    TestNumber = "32",
                    Preload = "Задание ''Fehlende Wörter'' №1",
                    Complited = item.Task32_comp,
                    CorrectCount = Convert.ToInt32(item.Test32),
                    Questions = MissGerquestions1.OrderBy(x => rand.Next()).Take(10).ToList(),
                });
            Test.Add(new Test
            {
                Chapter = "Глава 4",
                Title = "Задание ''Fehlende Wörter'' №2",
                TestNumber = "33",
                Preload = "Задание ''Fehlende Wörter'' №2",
                Complited = item.Task33_comp,
                CorrectCount = Convert.ToInt32(item.Test33),
                Questions = MissGerquestions2.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 4",
                Title = "Задание ''Fehlende Wörter'' №3",
                TestNumber = "34",
                Preload = "Задание ''Fehlende Wörter'' №3",
                Complited = item.Task34_comp,
                CorrectCount = Convert.ToInt32(item.Test34),
                Questions = MissGerquestions3.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 4",
                Title = "Задание ''Fehlende Wörter'' №4",
                TestNumber = "35",
                Preload = "Задание ''Fehlende Wörter'' №4",
                Complited = item.Task35_comp,
                CorrectCount = Convert.ToInt32(item.Test35),
                Questions = MissGerquestions4.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new Test
            {
                Chapter = "Глава 4",
                Title = "Задание ''Fehlende Wörter'' №5",
                TestNumber = "36",
                Preload = "Задание ''Fehlende Wörter'' №5",
                Complited = item.Task36_comp,
                CorrectCount = Convert.ToInt32(item.Test36),
                Questions = MissGerquestions5.OrderBy(x => rand.Next()).Take(10).ToList(),
            });



























            // Test.Add(new Test
            //{
            //    Chapter = "Глава 2",
            //    Title = "Tест 3",
            //    Complited = item.Task3_comp,
            //    TestNumber = "3",
            //    Preload = "Тест на проверку знаний по главе 2",
            //    CorrectCount = Convert.ToInt32(item.Test3),
            //    Questions = {
            //    new Question { text = "Где правильно объявлен ступенчаытый массив?", answer = "int[][] a = new int[2][3];", textAnswer="", answerArray=new string[4]{ "int[][] a = new int[2][3];", "int[][] a = new int[2];", "int a = new int[2][3];", "int[] a = 4" } },
            //    new Question { text = "Какой версии C# нет?", answer = "16", textAnswer="C# уже не молодой язык и как и вся платформа .NET уже прошел большой путь. Первая версия языка вышла вместе с релизом Microsoft Visual Studio .NET в феврале 2002 года. Текущей версией языка является версия C# 10.0, которая вышла 8 ноября 2021 года вместе с релизом .NET 6.", answerArray=new string[4]{ "8", "16", "6", "7" } },
            //    new Question { text = "Console.WriteLine(\"Hello, World\");, что будет выведено на экран?", answer = "Hello, World", textAnswer="", answerArray=new string[4]{ "Helo, World", "Hollo, world", "hello, World;;;;", "Hello, World" } },
            //    new Question { text = "Как предотвратить закрытие консоли после выполнения программы?", answer = "ReadLine", textAnswer="", answerArray=new string[4]{ "WriteLine", "ReadTitle", "ReadLine", "Write" } },
            //    new Question { text = "Какой цикл сначало проверяет условие?", answer = "While",  textAnswer="", answerArray=new string[4]{ "Do While", "While", "break", "continue"} },
            //    new Question { text = "Поддерживает ли C# множественное наследование?", answer = "Да",  textAnswer="", answerArray=new string[4]{ "Нет", "Да", "При подключении бибилеотек", "Было раньше"} },
            //    new Question { text = "Где правильно объявлена переменная?", answer = "string name;", textAnswer="тип имя_переменной;",answerArray=new string[4] { "str name;", "string name;", "string name:", "let name;" }  },
            //    new Question { text = "Что выведет код string name = \"Tom\";\nConsole.WriteLine(name);", answer = "Tom", textAnswer="Будет выведена объявленная переменная.", answerArray=new string[4] { "TOd", "mot", "tim", "Tom" } },
            //    new Question { text = "Что такое .NET?", answer = "Framework", textAnswer="", answerArray=new string[4] { "Framework", "DDL", "Класс", "Переменная" }  },
            //    new Question { text = "Сколько байт занимает long?", answer = "8", textAnswer="long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт. Представлен системным типом System.Int64.", answerArray=new string[4]{ "10", "7", "8", "11"} },

            //    },
            //});

            return Test;

        }
    }
}