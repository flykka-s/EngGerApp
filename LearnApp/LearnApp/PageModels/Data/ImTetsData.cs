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
    public static class ImTetsData
    {
        public static async Task<ObservableRangeCollection<ImTest>> GetDataAsync()
        {
            var Test = new ObservableRangeCollection<ImTest>();
            var item = await PageModelLocator.Resolve<IRepositoryImTests<DataImTests>>().Get("Id");

            Question[] questionsArrayhouse = {
                new Question { text = "Hostel.jpg", answer = "Общежитие", textAnswer="",answerArray=new string[4] { "Квартира", "Отдельно стоящий дом", "Общежитие", "Многоэтажка" }  },
                new Question { text = "Block_of_flats.jpg:", answer = "Многоэтажка", textAnswer="", answerArray=new string[4] { "Многоэтажка", "Общежитие", "Средняя школа", "Чердак" } },
                new Question { text = "Tiny.jpg", answer = "Tiny", textAnswer="", answerArray=new string[4] { "Light", "Tiny", "Shower", "Attic" }  },
                new Question { text = "Bungalow.jpg", answer = "Одноэтажный небольшой домик", textAnswer="", answerArray=new string[4] { "Туалет", "Гостинная", "Снимать (квартиру и т.п.)", "Одноэтажный небольшой домик" }  },
                new Question { text = "nursery.jpg", answer = "Детская комната", textAnswer="", answerArray=new string[4] { "Дети", "Детская комната", "Ванная", "Подвал" }  },
                new Question { text = "Bedroom.jpg", answer = "Bedroom", textAnswer="", answerArray=new string[4] { "Bedroom", "Dining room", "Bathroom", "Kitchen" }  },
                new Question { text = "On_the_outskirts.jpg", answer = "На окраине", textAnswer="", answerArray=new string[4] { "Рядом с", "Прямо в центре", "В пригороде", "На окраине" }  },
                new Question { text = "Share.png", answer = "Делиться", textAnswer="", answerArray=new string[4] { "Делиться", "Шумный", "Просторный", "Светлый" }  },
                new Question { text = "Fireplace.jpg", answer = "Fireplace", textAnswer="", answerArray=new string[4] { "Cooker", "Freezer", "Fireplace", "Electricity" }  },
                new Question { text = "Washing_machine.jpg", answer = "Washing machine", textAnswer="", answerArray=new string[4] { "Comfy chair", "Washing machine", "Water supply", "Central heating" }  },
                new Question { text = "Fridge_freezer.jpg", answer = "Морозильник", textAnswer="",answerArray=new string[4] { "Морозильник", "Зима", "Холод", "Жара" }  },
                new Question { text = "Carpet.jpg", answer = "Ковёр", textAnswer="", answerArray=new string[4] { "Раковина", "Кресло", "Зеркало", "Ковёр" } },
                new Question { text = "Sink_tap.jpg", answer = "Tap", textAnswer="", answerArray=new string[4] { "Cooker", "Carpet", "Sink", "Freezer" }  },
                new Question { text = "Detached_house.jpg", answer = "Отдельно стоящий дом", textAnswer="", answerArray=new string[4] { "Отдельно стоящий дом", "Многоэтажка", "Квартира", "Одноэтажный дом" } },
                new Question { text = "Noisy.jpg", answer = "Noisy", textAnswer="", answerArray=new string[4] { "Tiny", "Noisy", "Quiet", "Huge" }  },
                new Question { text = "Attic.jpg", answer = "Чердак", textAnswer="", answerArray=new string[4] { "Гостинная", "На окраине", "Чердак", "Кухня" }  },
                new Question { text = "Bathroom_shower.jpg", answer = "Душ", textAnswer="", answerArray=new string[4] { "Спальня", "Ванная", "Кабинет", "Душ" }  },
                new Question { text = "Cooling.jpg", answer = "Cooling", textAnswer="", answerArray=new string[4] { "Water supply", "Central heating", "Cooling", "Ceiling" }  },
                new Question { text = "Comfy_chair.jpg", answer = "Кресло", textAnswer="", answerArray=new string[4] { "Кран", "Телевизор", "Диван", "Кресло" }  },
                new Question { text = "Floor.jpg", answer = "Пол", textAnswer="", answerArray=new string[4] { "Пол", "Потолок", "Стена", "Дверь" }  },
                new Question { text = "Sink_tap.jpg", answer = "Раковина", textAnswer="",answerArray=new string[4] { "Раковина", "Лестница", "Окно", "Дверь" }  },
                new Question { text = "Electricity.jpg", answer = "Электричество", textAnswer="", answerArray=new string[4] { "Электронный", "Зеркало", "Ковёр", "Электричество" } },
                new Question { text = "Right_in_the_center.jpg", answer = "Right in the center", textAnswer="", answerArray=new string[4] { "Rent", "In the suburbs", "On the outskirts", "Right in the center" }  },



                };

            Question[] questionsArrayeduc = {
                new Question { text = "education.jpg", answer = "Образование", textAnswer="",answerArray=new string[4] { "Гражданин", "Образование", "Обеспечивать", "Детский сад" }  },
                new Question { text = "primary_school.jpg", answer = "Начальная школа", textAnswer="", answerArray=new string[4] { "Начальная школа", "Высшая школа", "Средняя школа", "Ясли" } },
                new Question { text = "headmaster.png", answer = "Headmaster", textAnswer="", answerArray=new string[4] { "Term", "Headmaster", "Grades", "Kindergarten" }  },
                new Question { text = "institution.jpg", answer = "Учреждение", textAnswer="", answerArray=new string[4] { "Средняя школа", "Институт", "Лицей", "Учреждение" }  },
                new Question { text = "kid_gard.jpg", answer = "Детский сад", textAnswer="", answerArray=new string[4] { "Детский сад", "Средняя школа", "Каникулы", "Стипендия" }  },
                new Question { text = "enter.jpg", answer = "Enter", textAnswer="", answerArray=new string[4] { "Occupy", "Canteen", "Enter", "Break" }  },
                new Question { text = "cloak_room.jpg", answer = "Гардероб", textAnswer="", answerArray=new string[4] { "Гардероб", "Столовая", "Кабинет директора", "Класс" }  },
                new Question { text = "library.jpg", answer = "Библиотека", textAnswer="", answerArray=new string[4] { "Библиотека", "Куратор", "Староста", "Предмет" }  },
                new Question { text = "tutor.jpg", answer = "Tutor", textAnswer="", answerArray=new string[4] { "Headmaster", "Subject", "Monitor", "Tutor" }  },
                new Question { text = "gen_sec_educ.jpg", answer = "General secondary school", textAnswer="", answerArray=new string[4] { "A guaranteed right to education", "General secondary school", "Primary school", "Basic school" }  },
                new Question { text = "free.png", answer = "Бесплатный", textAnswer="",answerArray=new string[4] { "Гражданин", "Кабинет директора", "Обеспечивать", "Бесплатный" }  },
                new Question { text = "liceium.jpg", answer = "Лицей", textAnswer="", answerArray=new string[4] { "Лицей", "Высшая школа", "Средняя школа", "Гимназия" } },
                new Question { text = "ggaek.png", answer = "Gomel State Agro-Economic College", textAnswer="", answerArray=new string[4] { "Nursery", "Gomel State Agro-Economic College", "Double period", "Kindergarten" }  },
                new Question { text = "gym.jpg", answer = "Спортзал", textAnswer="", answerArray=new string[4] { "Колледж", "Институт", "Библиотека", "Спортзал" }  },
                new Question { text = "citizen.jpg", answer = "Гражданин", textAnswer="", answerArray=new string[4] { "Гражданин", "Директор", "Куратор", "Староста" }  },
                new Question { text = "stipend.jpg", answer = "Стипендия", textAnswer="",answerArray=new string[4] { "Студент", "Стипендиат", "Стипендия", "Куратор" }  },
                new Question { text = "first_year_st.jpg", answer = "Первокурсник", textAnswer="", answerArray=new string[4] { "Студент", "Первокурсник", "Заканчивающий обучение", "Второкурсник" } },
                new Question { text = "vacations.jpg", answer = "Vacation", textAnswer="", answerArray=new string[4] { "Nursery", "Gymnasium", "Double period", "Vacation" }  },
                new Question { text = "canteen.jpg", answer = "Столовая", textAnswer="", answerArray=new string[4] { "Столовая", "Буфет", "Перерыв", "Кабинет" }  },
                new Question { text = "monitor.jpg", answer = "Monitor", textAnswer="", answerArray=new string[4] { "Subject", "Teacher", "Tutor", "Monitor" }  },
                new Question { text = "ggaek.png", answer = "ГГАЭК", textAnswer="", answerArray=new string[4] { "ГГАЭК", "ЮНЭСКО", "МТЗ", "R2D2" }  },
                new Question { text = "occupy.png", answer = "Занимать", textAnswer="", answerArray=new string[4] { "Занимать", "Частный", "Государственный", "Поступить" }  },
                new Question { text = "successfuly.png", answer = "Successfully", textAnswer="", answerArray=new string[4] { "Congratulations", "Canteen", "Successfully", "Break" }  },
                new Question { text = "take_exams.jpg", answer = "Take exams", textAnswer="", answerArray=new string[4] { "State-owned", "Take exams", "Be situated", "Pass exams" }  },
                new Question { text = "assembly_hall.jpg", answer = "Актовый зал", textAnswer="",answerArray=new string[4] { "Актовый зал", "Спортзал", "Библиотека", "Кабинет" }  },
                new Question { text = "Subject \nпредмет", answer = "Предмет", textAnswer="", answerArray=new string[4] { "Директор", "Куратор", "Староста", "Предмет" } },
                new Question { text = "double_period.jpg", answer = "Double period", textAnswer="", answerArray=new string[4] { "Double time", "Part-time", "Headmaster’s office", "Double period" }  },


                
            };

            Question[] questionsArraymass = {
                new Question { text = "mass_media.png", answer = "Средства массовой информации", textAnswer="",answerArray=new string[4] { "Средства массовой информации", "Событие", "Сообщать", "Источник" }  },
                new Question { text = "disaster.png", answer = "Бедствие", textAnswer="", answerArray=new string[4] { "СМИ", "Бедствие", "Печатать", "Авария" } },
                new Question { text = "source.png", answer = "Source", textAnswer="", answerArray=new string[4] { "Advertisement", "Series", "Influence", "Source" }  },
                new Question { text = "tabloid.png", answer = "Небольшая газета", textAnswer="", answerArray=new string[4] { "Статья", "Заголовок", "Небольшая газета", "Реклама" }  },
                new Question { text = "chat_show.png", answer = "Ток шоу", textAnswer="", answerArray=new string[4] { "Мультфильм", "Прогноз погоды", "Шоу викторина", "Ток шоу" }  },
                new Question { text = "violent.png", answer = "Violent", textAnswer="", answerArray=new string[4] { "Violent", "Violence", "Valentin", "Romance" }  },
                new Question { text = "soap_opera.jpg", answer = "Мыльная опера", textAnswer="", answerArray=new string[4] { "Триллер", "Шоу викторина", "Ток шоу", "Мыльная опера" }  },
                new Question { text = "cartoon.png", answer = "Мультфильм", textAnswer="", answerArray=new string[4] { "Мультфильм", "Фильм", "Боевик", "Триллер" }  },
                new Question { text = "report.png", answer = "Report", textAnswer="", answerArray=new string[4] { "Recently", "Untrue", "Report", "Ordinary" }  },
                new Question { text = "whats_going_on.png", answer = "What's going on?", textAnswer="", answerArray=new string[4] { "Make Headlines?", "What's going on?", "Seeing is believing?", "Half-True?" }  },
                new Question { text = "crash.png", answer = "Авария", textAnswer="",answerArray=new string[4] { "Авария", "Событие", "Боевик", "Статья" }  },
                new Question { text = "terrible.png", answer = "Ужасный", textAnswer="", answerArray=new string[4] { "Захватывающий", "Волнующий", "Великолепный", "Ужасный" } },
                new Question { text = "war_action_film.png", answer = "Action film", textAnswer="", answerArray=new string[4] { "Action film", "Romance", "Series", "Feature film" }  },
                new Question { text = "cable_tv.png", answer = "Кабельное телевидение", textAnswer="",answerArray=new string[4] { "Кабельное телевидение", "Спутниковое телевидение", "Телевидение", "Интернет-соединение" }  },
                new Question { text = "quiz_show.png", answer = "Викторина", textAnswer="", answerArray=new string[4] { "Боевик", "Викторина", "Мыльная опера", "Рекламное объявление" } },
                new Question { text = "current_affairs.png", answer = "Current affairs", textAnswer="", answerArray=new string[4] { "Current affairs", "News", "Commercial", "Tabloid" }  },
                new Question { text = "untrue.png", answer = "Ложный", textAnswer="", answerArray=new string[4] { "Недостаточный", "Правдивый", "Предпочтительный", "Ложный" }  },
                new Question { text = "murder.png", answer = "Убийство", textAnswer="", answerArray=new string[4] { "Убийство", "Авария", "Бедствие", "Событие" }  },
                new Question { text = "crash.png", answer = "Авария", textAnswer="", answerArray=new string[4] { "Убийство", "Авария", "Бедствие", "Событие" }  },
                new Question { text = "make_headlines.jpg", answer = "Попасть в заголовки", textAnswer="", answerArray=new string[4] { "Попасть в заголовки", "Источник информации", "Транслировать", "11Закулисная11 информация" }  },
                new Question { text = "print.png", answer = "Печатать", textAnswer="", answerArray=new string[4] { "Печатать", "Влиять", "Комментировать", "Вести шоу" }  },
                new Question { text = "half_true.png", answer = "Half-True", textAnswer="", answerArray=new string[4] { "Half-True", "Untrue", "True", "False" }  },
                
                new Question { text = "documentary.png", answer = "Документальный фильм", textAnswer="",answerArray=new string[4] { "Документальный фильм", "Ток шоу", "Викторина", "Мыльная опера" }  },
                new Question { text = "commercial.png", answer = "Реклама на ТВ", textAnswer="", answerArray=new string[4] { "Коммерция", "Реклама на ТВ", "Шоу", "Заголовок" } },
                new Question { text = "favourite.png", answer = "Favourite", textAnswer="", answerArray=new string[4] { "Article", "Series", "Tabloid", "Favourite" }  },



            };

            Question[] questionsArrayyouth = {
                new Question { text = "Misunderstanding.png", answer = "Непонимание", textAnswer="",answerArray=new string[4] { "Непонимание", "Понимание", "Плахая привычка", " Деятельность" }  },
                new Question { text = "Generation_gap.jpg", answer = "Проблема 11отцов и детей11", textAnswer="", answerArray=new string[4] { "Заботиться о ...", "Человек с недостатками", "Проблема 11отцов и детей11", "Включать в себя" } },
                new Question { text = "Numerous.png", answer = "Numerous", textAnswer="", answerArray=new string[4] { "Society", "Aim", "Tolerance", "Promote" }  },
                new Question { text = "Activity.png", answer = "Деятельность", textAnswer="", answerArray=new string[4] { "Общество", "Терпимость", "Благотворительность", "Деятельность" }  },
                new Question { text = "Support.png", answer = "Поддержка", textAnswer="", answerArray=new string[4] { "Поддержка", "Недопонимание", "Девиз", "Терпимость" }  },
                new Question { text = "Motto.png", answer = "Motto", textAnswer="", answerArray=new string[4] { "Tolerance", "Motto", "Misunderstanding", "Handicapped" }  },
                new Question { text = "Member.png", answer = "Член организации", textAnswer="", answerArray=new string[4] { "Достижение", "Работник", "Организация", "Член организации" }  },
                new Question { text = "Patriotic_and_moral_values.jpg", answer = "", textAnswer="", answerArray=new string[4] { "Патриотические ценности", "Нравственные ценности", "Финансовые ценности", "Ценности" }  },
                new Question { text = "To_take_an_active_part.jpg", answer = "To take an active part", textAnswer="", answerArray=new string[4] { "Carry out", "To reach", "To take an active part", "Informal youth movements" }  },
                new Question { text = "Involve.png", answer = "Включать в себя", textAnswer="", answerArray=new string[4] { "Включать в себя", "Достигать", "Продвигать", "Терпимость" }  },
                new Question { text = "Handicapped.png", answer = "Человек с физическими или умственными недостатками", textAnswer="",answerArray=new string[4] { "Заботиться о …", "По моему мнению", "Человек с физическими или умственными недостатками", "Разрыв между поколениями" }  },
                new Question { text = "Point_of_view_View.png", answer = "Точка зрения", textAnswer="", answerArray=new string[4] { "Ставить цель", "Точка зрения", "Продвигать", "Принимать участие" } },
                new Question { text = "Bad_habits.png", answer = "Плохие привычки", textAnswer="", answerArray=new string[4] { "По моему мнению", "Включать в себя", "Заботиться о …", "Плохие привычки" }  },
                new Question { text = "Volunteer.png", answer = "Доброволец", textAnswer="", answerArray=new string[4] { "Человек", "Студент", "Директор", "Доброволец" }  },
                new Question { text = "successfuly.png", answer = "Выполнять", textAnswer="", answerArray=new string[4] { "Поддерживать", "Продвигать", "Выполнять", "Включать в себя" }  },
                new Question { text = "Promote.png", answer = "Продвигать", textAnswer="", answerArray=new string[4] { "Продвигать", "Поддерживать", "Выполнять", "Включать в себя" }  },
                new Question { text = "Charity.png", answer = "Charity", textAnswer="", answerArray=new string[4] { "Member", "Support", "Reach", "Charity" }  },
                new Question { text = "Tolerance.png", answer = "Tolerance", textAnswer="", answerArray=new string[4] { "Member", "Support", "Tolerance", "Charity" }  },
                new Question { text = "Take_care_of.png", answer = "Заботиться о …", textAnswer="",answerArray=new string[4] { "Точка зрения", "Плохие привычки", "Включать в себя", "Заботиться о …" }  },
                new Question { text = "To_reach.png", answer = "Достигать", textAnswer="", answerArray=new string[4] { "Поддерживать", "Выполнять", "Включать в себя", "Достигать" } },
                new Question { text = "Involve.png", answer = "Involve", textAnswer="", answerArray=new string[4] { "To reach", "Carry out", "Involve", "Support" }  },
            };

            Question[] questionsArrayart = {
                new Question { text = "Content.png", answer = "Содержание", textAnswer="",answerArray=new string[4] { "Абстрактный", "Содержание", "Публика", "Визуальный" }  },
                new Question { text = "Express.jpg", answer = "Выражать", textAnswer="", answerArray=new string[4] { "Впечатлять", "Граффити", "Надпись", "Выражать" } },
                new Question { text = "Artist_Painter.png", answer = "Artist", textAnswer="", answerArray=new string[4] { "Artist", "Author", "Painter", "Composer" }  },
                new Question { text = "Architecture.png", answer = "Архитектура", textAnswer="", answerArray=new string[4] { "Живопись", "Архитектура", "Комикс", "Мультипликация" }  },
                new Question { text = "Exhibition.png", answer = "Выставка", textAnswer="", answerArray=new string[4] { "Дизайн", "Гравюра", "Фотография", "Выставка" }  },
                new Question { text = "Ban.png", answer = "Ban", textAnswer="", answerArray=new string[4] { "Exhibition", "Ban", "Filmmaking", "Unique" }  },
                new Question { text = "Spectacular.jpg", answer = "Зрелищный", textAnswer="", answerArray=new string[4] { "Уникальный", "Узнаваемый", "Зрелищный", "Символический" }  },
                new Question { text = "Background.png", answer = "Задний план", textAnswer="", answerArray=new string[4] { "Передний план", "Выставка", "Ландшафт", "Задний план" }  },
                new Question { text = "Printmaking.png", answer = "Printmaking", textAnswer="", answerArray=new string[4] { "Oil painting", "Design", "Drawing", "Printmaking" }  },
                new Question { text = "Foreground.png", answer = "Foreground", textAnswer="", answerArray=new string[4] { "Foreground", "Background", "Landmark", "Recognizable" }  },
                new Question { text = "Computer_art.png", answer = "Компьютерная графика", textAnswer="",answerArray=new string[4] { "Производство фильмов", "Компьютерная графика", "Мультипликация", "Архитектура" }  },
                new Question { text = "Piece_of_art.png", answer = "Произведение искусства", textAnswer="", answerArray=new string[4] { "Ландшафт", "Передний план", "Произведение искусства", "Дизайн" } },
                new Question { text = "Mural_Writer.png", answer = "Writer", textAnswer="", answerArray=new string[4] { "Painter", "Writer", "Graffiti writter", "Unique" }  },
                new Question { text = "Recognizable.png", answer = "Узнаваемый", textAnswer="",answerArray=new string[4] { "Узнаваемый", "Зрелищный", "Уникальный", "Символический" }  },
                new Question { text = "Oil_painting.png", answer = "Живопись", textAnswer="", answerArray=new string[4] { "Скульптура", "Дизайн", "Графика", "Живопись" } },
                new Question { text = "Composer.png", answer = "Composer", textAnswer="", answerArray=new string[4] { "Artist", "Composer", "Painter", "Author" }  },
                new Question { text = "Animation.png", answer = "Мультипликация", textAnswer="", answerArray=new string[4] { "Комикс", "Мультипликация", "Графика", "Композитор" }  },
                new Question { text = "Landmark.png", answer = "Ландшафт", textAnswer="", answerArray=new string[4] { "Фотография", "Фон", "Передний план", "Ландшафт" }  },
                new Question { text = "Tag.png", answer = "Надпись", textAnswer="", answerArray=new string[4] { "Граффити", "Надпись", "Изображение", "Картинка" }  },
                new Question { text = "Enjoy.png", answer = "Любить что-то делать", textAnswer="", answerArray=new string[4] { "Любить что-то делать", "Иконический", "Выставка", "Нрав" }  },
                new Question { text = "Architecture.png", answer = "Architecture", textAnswer="", answerArray=new string[4] { "Architecture", "Exhibition", "Animation", "Sculpture" }  },
                new Question { text = "Impress.png", answer = "Impress", textAnswer="",answerArray=new string[4] { "Abstract", "Audience", "Express", "Impress" }  },
                

            };

            Question[] questionsArrayscience = {
                new Question { text = "app.png", answer = "Приложение", textAnswer="",answerArray=new string[4] { "Приложение", "Данные", "Наушники", "Всемирная паутина" }  },
                new Question { text = "science.png", answer = "Наука", textAnswer="", answerArray=new string[4] { "Научный", "Наука", "Данные", "Ученый" } },
                new Question { text = "wonder.png", answer = "Wonder", textAnswer="", answerArray=new string[4] { "Vehicle", "Achievement", "Digital", "Wonder" }  },
                new Question { text = "take_part.png", answer = "Принимать участие", textAnswer="", answerArray=new string[4] { "Принимать участие", "Сельское хозяйство", "Продолжительность жизни", "Естественные науки" }  },
                new Question { text = "vehicle.png", answer = "Транспортное cредство", textAnswer="", answerArray=new string[4] { "Наука", "Мотоцикл", "Машина", "Транспортное cредство" }  },
                new Question { text = "device.png", answer = "Device", textAnswer="", answerArray=new string[4] { "Genetic", "Invent", "Device", "Gadget" }  },
                new Question { text = "drug_abuse.png", answer = "Злоупотребление наркотиками", textAnswer="", answerArray=new string[4] { "Злоупотребление наркотиками", "Цифровой", "Выдающийся / Знаменитый", "Многофункциональное устройство" }  },
                new Question { text = "famine.png", answer = "Голод", textAnswer="", answerArray=new string[4] { "Голод", "Машиностроение", "Старомодный", "Продвинутый" }  },
                new Question { text = "social_science.png", answer = "Социальные и поведенческие науки", textAnswer="", answerArray=new string[4] { "Социальные и поведенческие науки", "Математические науки", "Биологические науки", "Физиологические науки" }  },
                new Question { text = "appliance.png", answer = "Appliance", textAnswer="", answerArray=new string[4] { "Appliance", "Gadget", "Device", "Mechanical" }  },
                new Question { text = "development.png", answer = "Развитие", textAnswer="",answerArray=new string[4] { "Продвинутый", "Цифровой", "Открытие", "Развитие" }  },
                new Question { text = "Humanity_Mankind.png", answer = "Человечество", textAnswer="", answerArray=new string[4] { "Изобретение", "Развитие", "Человечество", "Открытие" } },
                new Question { text = "scientist.png", answer = "Учёный", textAnswer="", answerArray=new string[4] { "Учёный", "Цифровой", "Научный", "Наука" }  },
                new Question { text = "agriculture.png", answer = "Cельское хозяйство", textAnswer="",answerArray=new string[4] { "Биоорганическая химия", "Агроусадьба", "Агрокультура", "Cельское хозяйство" }  },
                new Question { text = "old_fashioned.png", answer = "Старомодный", textAnswer="", answerArray=new string[4] { "Высокоразвитый", "Высокотехнологичный", "Механический", "Старомодный" } },
                new Question { text = "discover.png", answer = "Discover", textAnswer="", answerArray=new string[4] { "Discover", "Discovery", "Device", "Appliance" }  },
                new Question { text = "hunger.png", answer = "Голод", textAnswer="", answerArray=new string[4] { "Изобретение", "Голод", "Машиномтроение", "Голодание" }  },
                new Question { text = "researcher.png", answer = "Исследователь", textAnswer="", answerArray=new string[4] { "Ученый", "Изучение", "Исследовать", "Исследователь" }  },
                new Question { text = "gadget.png", answer = "Gadget", textAnswer="", answerArray=new string[4] { "Gadget", "Device", "Machine building", "Discover" }  },
                new Question { text = "natural_sciences.png", answer = "Биоорганическая химия", textAnswer = "", answerArray = new string[4] { "Биоорганическая химия", "Органическая химия", "Генетическая химия", "Химия" } },
                new Question { text = "gadget.png", answer = "Устройство", textAnswer = "", answerArray = new string[4] { "Устройство", "Открытие", "Прибор", "МФУ" } },
                new Question { text = "invention.png", answer = "Invention", textAnswer = "", answerArray = new string[4] { "Invent", "Invention", "Mechanical", "Development" } },
                new Question { text = "drug_abuse.png", answer = "Drug abuse", textAnswer = "", answerArray = new string[4] { "Abuse", "Drug diller", "Drug abuse", "Drug" } },
                new Question { text = "ecology.png", answer = "Экология", textAnswer = "", answerArray = new string[4] { "Точные науки", "Данные", "Экология", "Естественные науки" } },
                new Question { text = "data.png", answer = "Данные", textAnswer = "", answerArray = new string[4] { "Точные науки", "Данные", "Экология", "Естественные науки" } },
                new Question { text = "web.png", answer = "Всемирная паутина", textAnswer = "", answerArray = new string[4] { "Сеть", "Локальная сеть", "Наушники", "Всемирная паутина" } },

            };



            Question[] questionsArrayfamily = {

                new Question { text = "Parents.png", answer = "Родители", textAnswer="",answerArray=new string[4] { "Сын", "Родители", "Дочь", "Братья" }  },
                new Question { text = "Son.png", answer = "Сын", textAnswer="", answerArray=new string[4] { "Сын", "Дочь", "Дядя", "Тётя" } },
                new Question { text = "Grandchild_Grandson.png", answer = "Внук", textAnswer="", answerArray=new string[4] { "Правнук", "Внучка", "Внук", "Правнучка" }  },
                new Question { text = "Sibling.png", answer = "Брат и сестра", textAnswer="", answerArray=new string[4] { "Братья", "Брат и сестра", "Сёстры", "Родители" }  },
                new Question { text = "Niece.png", answer = "Племянница", textAnswer="", answerArray=new string[4] { "Брат", "Племянник", "Племянница", "Сестра" }  },
                new Question { text = "Nephew.png", answer = "Nephew", textAnswer="", answerArray=new string[4] { "Nephew", "Aunt", "Niece", "Uncle" }  },
                new Question { text = "The_only_child.png", answer = "Единственный ребенок", textAnswer="", answerArray=new string[4] { "Двоюродный брат / сестра", "Сводная сестра", "Сводный брат", "Единственный ребенок" }  },
                new Question { text = "Stepdaughter_Stepsister.png", answer = "Сводная cестра", textAnswer="", answerArray=new string[4] { "Сводная cестра", "Двоюродный брат / сестра", "Внучка", "Сводный брат" }  },
                new Question { text = "Wife_Bride.png", answer = "Wife", textAnswer="", answerArray=new string[4] { "Bride", "Husband", "Groom", "Wife" }  },
                new Question { text = "Son_in_law.png", answer = "Son-in-law", textAnswer="", answerArray=new string[4] { "Father-in-law", "Mother-in-law", "Daughter-in-law", "Son-in-law" }  },
                new Question { text = "Divorced_Ex_Wife_Ex_Husband.png", answer = "Разведен(а)", textAnswer="",answerArray=new string[4] { "Дальний (родственник)", "Не замужем", "Холост", "Разведен(а)" }  },
                new Question { text = "Twins.png", answer = "Близнецы", textAnswer="", answerArray=new string[4] { "Близнецы", "Дедушка и бабушка", "Родители", "Внуки" } },
                new Question { text = "Grandparents_Father_in_law_Mother_in_law.png", answer = "Свекор / тесть", textAnswer="", answerArray=new string[4] { "Свекор / тесть", "Сводный сын", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Grandparents_Father_in_law_Mother_in_law.png", answer = "Свекровь / теща", textAnswer="", answerArray=new string[4] { "Сводный сын", "Свекровь / теща", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Son_in_law.png", answer = "Муж дочери / зять", textAnswer="", answerArray=new string[4] { "Свекор / тесть", "Свекровь / теща", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Daughter_in_law.png", answer = "Жена сына / невестка", textAnswer="", answerArray=new string[4] { "Свекор / тесть", "Свекровь / теща", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Divorced_Ex_Wife_Ex_Husband.png", answer = "Бывшая жена", textAnswer="",answerArray=new string[4] { "Неполная семья", "Бывшая жена", "Сводная сестра", "Приемный сын" }  },
                new Question { text = "Divorced_Ex_Wife_Ex_Husband.png", answer = "Бывший муж", textAnswer="", answerArray=new string[4] { "Бывший муж", "Неполная семья", "Сводная сестра", "Приемная дочь" } },
                new Question { text = "Appreciate.png", answer = "Appreciate", textAnswer="", answerArray=new string[4] { "Appreciate", "Turn for help", "Tight-knit", "Get on well" }  },
                new Question { text = "Get_on_well.jpg", answer = "Ладить с кем-то", textAnswer="", answerArray=new string[4] { "Ценить", "Помогать друг другу", "Семейные связи", "Ладить с кем-то" }  },
                new Question { text = "Tight_knit.png", answer = "Дружная", textAnswer="", answerArray=new string[4] { "Дружная", "Ценить", "Помогать друг другу", "Семейные связи" }  },
                new Question { text = "Single_Bachelor.jpg", answer = "Single / Bachelor", textAnswer="", answerArray=new string[4] { "Single / Bachelor", "Groom / Bride", "Wife / Husband", "Mother-in-law / Father-in-law" }  },
                new Question { text = "Cousin.png", answer = "Двоюродный брат / сестра", textAnswer="", answerArray=new string[4] { "Двоюродный брат / сестра", "Тётя", "Дядя", "Внучка" }  },
                new Question { text = "Stepmother_Stepson.png", answer = "Stepmother", textAnswer="", answerArray=new string[4] { "Stepmother", "Stepfather", "Stepdaughter", "Stepsister" }  },
                

            };

            Question[] questionsArrayjobs = {

                new Question { text = "Electrician.png", answer = "Электрик", textAnswer="",answerArray=new string[4] { "Инженер", "Повар", "Водитель", "Электрик" }  },
                new Question { text = "Librarian.png", answer = "Библиотекарь", textAnswer="", answerArray=new string[4] { "Уборщик", "Экономист", "Библиотекарь", "Бизнесмен" } },
                new Question { text = "Driver.png", answer = "Driver", textAnswer="", answerArray=new string[4] { "Artist", "Banker", "Driver", "Book-Keeper" }  },
                new Question { text = "Plumber.png", answer = "Сантехник", textAnswer="", answerArray=new string[4] { "Сантехник", "Библиотекарь", "Продавец", "Кассир" }  },
                new Question { text = "Programmer.png", answer = "Программист", textAnswer="", answerArray=new string[4] { "Официант", "Уборщик", "Милиционер", "Программист" }  },
                new Question { text = "Shop_assistant.png", answer = "Shop-assistant", textAnswer="", answerArray=new string[4] { "Shop-assistant", "Waiter", "Engineer", "Postman" }  },
                new Question { text = "Postman.png", answer = "Почтальон", textAnswer="", answerArray=new string[4] { "Почтальон", "Инженер", "Секретарь", "Ветеринар" }  },
                new Question { text = "Vet.png", answer = "Ветеринар", textAnswer="", answerArray=new string[4] { "Милиционер", "Официант", "Ветеринар", "Сантехник" }  },
                new Question { text = "Cleaner.png", answer = "Cleaner", textAnswer="", answerArray=new string[4] { "Engineer", "Cleaner", "Carpenter", "Secretary" }  },
                new Question { text = "Entrepreneur_Businessman.png", answer = "Businessman", textAnswer="", answerArray=new string[4] { "Businessman", "Carpenter", "Accountant", "Artist" }  },
                new Question { text = "Cook.png", answer = "Повар", textAnswer="",answerArray=new string[4] { "Повар", "Милиционер", "Библиотекарь", "Водитель" }  },
                new Question { text = "Accountant_Book_Keeper.png", answer = "Бухгалтер (со средним образованием)", textAnswer="", answerArray=new string[4] { "Бухгалтер (со средним образованием)", "Бухгалтер (с высшим образованием)", "Столяр / плотник", "Энергетик" } },
                new Question { text = "Strength.png", answer = "Strength", textAnswer="", answerArray=new string[4] { "Weakness", "Salary", "Strength", "Qualified" }  },
                new Question { text = "Career.png", answer = "Карьера", textAnswer="",answerArray=new string[4] { "Карьера", "Льготы", "Требовать", "Жалованье" }  },
                new Question { text = "Well_paid_Salary_Earn.png", answer = "Зарабатывать", textAnswer="", answerArray=new string[4] { "Квалифицированный", "Требовать", "Сильная cторона", "Зарабатывать" } },
                new Question { text = "Weakness.png", answer = "Weakness", textAnswer="", answerArray=new string[4] { "Weakness", "Salary", "Strength", "Qualified" }  },
                new Question { text = "Nurse.png", answer = "Медсестра", textAnswer="", answerArray=new string[4] { "Медсестра", "Инженер", "Официант", "Милиционер" }  },
                new Question { text = "Challenging.jpg", answer = "Требующий напряжения", textAnswer="", answerArray=new string[4] { "Требующий напряжения", "Жалованье", "Нагрузка", "Гарантия занятости" }  },
                new Question { text = "Load.png", answer = "Load", textAnswer="", answerArray=new string[4] { "Benefit", "Career", "Load", "Challenging" }  },
                new Question { text = "Entrepreneur_Businessman.png", answer = "Предприниматель", textAnswer="", answerArray=new string[4] { "Медсестра", "Предприниматель", "Официант", "Ветеринар" }  },
                new Question { text = "Job_security.jpg", answer = "Гарантия занятости", textAnswer="", answerArray=new string[4] { "Слабая сторона", "Сильная сторона", "Защищенность", "Гарантия занятости" }  },
                new Question { text = "Well_paid_Salary_Earn.png", answer = "Earn", textAnswer="", answerArray=new string[4] { "Earn", "Load", "Benefit", "Well-paid" }  },
                new Question { text = "Benefit.jpg", answer = "Benefit", textAnswer="", answerArray=new string[4] { "Earn", "Load", "Benefit", "Well-paid" }  },
                new Question { text = "Work_as.jpg", answer = "Работать кем-то", textAnswer="",answerArray=new string[4] { "Иметь хорошие условия", "Гарантия занятости", "Работать кем-то", "Иметь дело с клиентами" }  },
                new Question { text = "Benefit.jpg", answer = "Льготы", textAnswer="", answerArray=new string[4] { "Высокооплачиваемый", "Карьера", "Нагрузка", "Льготы" } },
                new Question { text = "Well_paid_Salary_Earn.png", answer = "Salary", textAnswer="", answerArray=new string[4] { "Salary", "Require", "Entrepreneur", "Benefit" }  },

            };

            
            Question[] questionsArraynaccar = {

                new Question { text = "Stereotype.png", answer = "Стереотип", textAnswer="",answerArray=new string[4] { "Обобщение", "Стереотип", "Гибкий", "Стремление" }  },
                new Question { text = "Ambitious_Aspiration.png", answer = "Амбициозный", textAnswer="", answerArray=new string[4] { "Амбициозный", "Высокомерный", "Напористый", "Импульсивный" } },
                new Question { text = "Agreeable.png", answer = "Agreeable", textAnswer="", answerArray=new string[4] { "Ambitious", "Assertive", "Agreeable", "Caring" }  },
                new Question { text = "Arrogant.png", answer = "Высокомерный", textAnswer="", answerArray=new string[4] { "Высокомерный", "Щедрый", "Честный", "Импульсивный" }  },
                new Question { text = "Humble.png", answer = "Скромный", textAnswer="", answerArray=new string[4] { "Скромный", "Высокомерный", "Гибкий", "Честный" }  },
                new Question { text = "Flexible.png", answer = "Flexible", textAnswer="", answerArray=new string[4] { "Generous", "Assertive", "Aspiration", "Arrogant" }  },
                new Question { text = "Honest.png", answer = "Честный", textAnswer="", answerArray=new string[4] { "Честный", "Обобщение", "Гибкий", "Импульсивный" }  },
                new Question { text = "Organized.png", answer = "Организованный", textAnswer="", answerArray=new string[4] { "Организованный", "Импульсивный", "Уважительный", "Неглубокий" }  },
                new Question { text = "Straightforward.png", answer = "Straightforward", textAnswer="", answerArray=new string[4] { "Amusing", "Shallow", "Straightforward", "Polite" }  },
                new Question { text = "Humiliating.png", answer = "Humiliating", textAnswer="", answerArray=new string[4] { "Technical", "Humiliating", "Submissive", "Talkative" }  },
                new Question { text = "Polite.png", answer = "Вежливый", textAnswer="",answerArray=new string[4] { "Вежливый", "Гордый", "Забавный", "Добросердечный" }  },
                new Question { text = "Humble.png", answer = "Скромный", textAnswer="", answerArray=new string[4] { "Организованный", "Импульсивный", "Гордый", "Скромный" } },
                new Question { text = "Law_abiding.png", answer = "Law-abiding", textAnswer="", answerArray=new string[4] { "Funky", "Law-abiding", "Obsessive", "Confident" }  },
                new Question { text = "Funky.png", answer = "Клевый", textAnswer="",answerArray=new string[4] { "Тупоголовый", "Организованный", "Болтливый", "Унижающий" }  },
                new Question { text = "Indolent.png", answer = "Очень ленивый", textAnswer="", answerArray=new string[4] { "Скучный", "Очень ленивый", "Пассивный", "Терпимый" } },
                new Question { text = "Rude.png", answer = "Rude", textAnswer="", answerArray=new string[4] { "Dull", "Rude", "Strict", "Thankful" }  },
                new Question { text = "Biased.png", answer = "Предвзятый", textAnswer="", answerArray=new string[4] { "Благодарный", "Грубый", "Предвзятый", "Скучный" }  },
                new Question { text = "Caring_Kind_hearted.png", answer = "Добросердечный", textAnswer="", answerArray=new string[4] { "Добросердечный", "Упрямый", "Непредвзятый", "Предвзятый" }  },
                new Question { text = "Proud_Confident.png", answer = "Confident", textAnswer="", answerArray=new string[4] { "Amusing", "Reasonable", "Rude", "Confident" }  },
                new Question { text = "Reasonable.png", answer = "Reasonable", textAnswer="", answerArray=new string[4] { "Humiliating", "Reasonable", "Stubborn", "Proud" }  },
                new Question { text = "Talkative.png", answer = "Talkative", textAnswer="", answerArray=new string[4] { "Strict", "Talkative", "Outgoing", "Biased" }  },
                new Question { text = "Outgoing.png", answer = "Outgoing", textAnswer="", answerArray=new string[4] { "Ambitious", "Generous", "Controlled", "Outgoing" }  },
                new Question { text = "Anxious.png", answer = "Anxious", textAnswer="", answerArray=new string[4] { "Anxious", "Ambitious", "Humble", "Generalization" }  },
                new Question { text = "Submissive.png", answer = "Submissive", textAnswer="",answerArray=new string[4] { "Submissive", "Reasonable", "Talkative", "Shallow" }  },
                new Question { text = "Obsessive.png", answer = "Obsessive", textAnswer="", answerArray=new string[4] { "Law-abiding", "Obsessive", "Modest", "Materialistic" } },
                new Question { text = "Materialistic.png", answer = "Materialistic", textAnswer="", answerArray=new string[4] { "Impulsive", "Thankful", "Agreeable", "Materialistic" }  },

            };


            Question[] questionsArrayintcult = {

                new Question { text = "Annual.png", answer = "Ежегодный", textAnswer="",answerArray=new string[4] { "Ежегодный", "Общественный", "Современный", "Совместный" }  },
                new Question { text = "Burst_out_of_someones_comfort_zone.png", answer = "Зона комфорта", textAnswer="", answerArray=new string[4] { "Посольство", "Сообщество", "Зона комфорта", "Современник" } },
                new Question { text = "Independent.png", answer = "Независимый", textAnswer="", answerArray=new string[4] { "Общественный", "Независимый", "Современный", "Ежегодный" }  },
                new Question { text = "Community.png", answer = "Сообщество", textAnswer="", answerArray=new string[4] { "Культурный шок", "Современный", "Ежегодный", "Сообщество" }  },
                new Question { text = "Contemporary.png", answer = "Современный", textAnswer="", answerArray=new string[4] { "Современный", "Низовой", "Годовой", "Месячный" }  },
                new Question { text = "Cooperation.png", answer = "Сотрудничество", textAnswer="", answerArray=new string[4] { "Общество", "Сотрудничество", "Совместный", "Современник" }  },
                new Question { text = "Culture_shock.jpg", answer = "Культурный шок", textAnswer="", answerArray=new string[4] { "Кульминация", "Современник", "Сотрудничество", "Культурный шок" }  },
                new Question { text = "Embassy.png", answer = "Посольство", textAnswer="", answerArray=new string[4] { "Министерство", "Посольство", "Государство", "Консульство" }  },
                new Question { text = "Ensure.png", answer = "Ensure", textAnswer="", answerArray=new string[4] { "Establish", "Ensure", "Independent", "Contemporary" }  },
                new Question { text = "Establish.png", answer = "Establish", textAnswer="", answerArray=new string[4] { "Independent", "Establish", "Cooperation", "Contemporary" }  },
                new Question { text = "Gain.png", answer = "Приобретать", textAnswer="",answerArray=new string[4] { "Нанимать", "Иметь", "Приобретать", "Покупать" }  },
                new Question { text = "Grassroots.png", answer = "Низовой", textAnswer="", answerArray=new string[4] { "Низовой", "Высший", "Средний", "Годовой" } },
                new Question { text = "Highlight.png", answer = "Highlight", textAnswer="", answerArray=new string[4] { "Joint", "Highlight", "Gain", "Grassroots" }  },
                new Question { text = "Joint.png", answer = "Совместный", textAnswer="",answerArray=new string[4] { "Совместный", "Ежегодный", "Годовой", "Независимый" }  },
                

            };


            Question[] questionsArraytourism = {

                new Question { text = "To_swear_by_something.jpg", answer = "Свято верить", textAnswer="",answerArray=new string[4] { "Вырваться из зоны комфорта", "Свято верить", "Выходить за рамки", "Переживать трудные времена" }  },
                new Question { text = "Burst_out_of_someones_comfort_zone.png", answer = "Вырваться из зоны комфорта", textAnswer="", answerArray=new string[4] { "Вырваться из зоны комфорта", "Свято верить", "Выходить за рамки", "Переживать трудные времена" } },
                new Question { text = "Go_beyond_something.png", answer = "Go beyond something", textAnswer="", answerArray=new string[4] { "Last resort", "Immerse yourself in something", "Go through a rough patch", "Go beyond something" }  },
                new Question { text = "Immerse_yourself_in_something.jpg", answer = "Погрузиться во что-либо", textAnswer="", answerArray=new string[4] { "Путешествовать по миру", "Cклонность к чему-либо", "Выходить за рамки", "Погрузиться во что-либо" }  },
                new Question { text = "Travelling_Travel_Journey_Flight.png", answer = "Путешествие", textAnswer="", answerArray=new string[4] { "Путешествие", "Маршрут", "Путь", "Экскурсия" }  },
                new Question { text = "Itinerary.png", answer = "Itinerary", textAnswer="", answerArray=new string[4] { "Trip", "Itinerary", "Benefit", "Travel" }  },
                new Question { text = "Stamping_grounds.png", answer = "Излюбленное место", textAnswer="", answerArray=new string[4] { "Длительное путещшествие", "Быть на высоте", "Крайняя мера", "Излюбленное место" }  },
                new Question { text = "Perk.png", answer = "Преимущество", textAnswer="", answerArray=new string[4] { "Преимущество", "Бонус", "Путь", "Поездка" }  },
                new Question { text = "Travelling_Travel_Journey_Flight.png", answer = "Flight", textAnswer="", answerArray=new string[4] { "Flight", "Trip", "Cruise", "Voyage" }  },
                new Question { text = "Cruise.png", answer = "Cruise", textAnswer="", answerArray=new string[4] { "Trip", "Tour", "Flight", "Cruise" }  },
                new Question { text = "Travel_agency.png", answer = "Туристическое агентство", textAnswer="",answerArray=new string[4] { "Камера хранения", "Требующий много времени", "Длинный полет", "Туристическое агентство" }  },
                new Question { text = "Luggage.png", answer = "Багаж", textAnswer="", answerArray=new string[4] { "Рюкзак", "Багаж", "Справочное бюро", "Полет" } },
                new Question { text = "Backpack.png", answer = "Backpack", textAnswer="", answerArray=new string[4] { "Backpack", "Information desk", "Trip", "Package tour" }  },
                new Question { text = "Voyage.png", answer = "Путешествие по морю", textAnswer="",answerArray=new string[4] { "Рейс", "Путешествие по морю", "Полет", "Поездка" }  },
                new Question { text = "Stay_in_a_hotel.png", answer = "Остановиться в отеле", textAnswer="", answerArray=new string[4] { "Камера хранения", "Справочное бюро", "Отправиться в путешествие", "Остановиться в отеле" } },
                new Question { text = "Left_luggage_office.jpg", answer = "Left luggage office", textAnswer="", answerArray=new string[4] { "Information desk", "Left luggage office", "To go hitchhiking", "Unconventional" }  },
                new Question { text = "To_go_hitchhiking.png", answer = "Отправиться в путешествие автостопом", textAnswer="", answerArray=new string[4] { "Длительное путешествие", "Отправиться в путешествие автостопом", "Отправляться в путь", "Быть на высоте" }  },
                new Question { text = "Information_desk.png", answer = "Справочное бюро", textAnswer="", answerArray=new string[4] { "Турагенство", "Отель", "Справочное бюро", "Камера хранения" }  },
                new Question { text = "Stamping_grounds.png", answer = "Stamping grounds", textAnswer="", answerArray=new string[4] { "Travel agency", "Stamping grounds", "Set off", "Last resort" }  },
                new Question { text = "Benefit.jpg", answer = "Benefit", textAnswer="", answerArray=new string[4] { "Benefit", "Perk", "Flight", "Journey" }  },
                new Question { text = "Time_consuming.png", answer = "Требующий много времени", textAnswer="", answerArray=new string[4] { "Крайняя мера", "Требующий много времени", "Нетрадиционный", "Последнее средтво" }  },


            };


            Question[] questionsArrayenvir = {

                new Question { text = "Nature.png", answer = "Природа", textAnswer="",answerArray=new string[4] { "Природа", "Окружающая среда", "Человечество", "Загрязнение" }  },
                new Question { text = "Humanity_Mankind.png", answer = "Человечество", textAnswer="", answerArray=new string[4] { "Человек", "Человечество", "природа", "Загрязнение" } },
                new Question { text = "Cont.png", answer = "Contamination", textAnswer="", answerArray=new string[4] { "Substance", "Harmful", "Contamination", "Pollution" }  },
                new Question { text = "Destroy.png", answer = "Destroy", textAnswer="", answerArray=new string[4] { "Destroy", "Contaminate", "Pollute", "Protect" }  },
                new Question { text = "Emission.png", answer = "Выброс", textAnswer="", answerArray=new string[4] { "Пыль", "Кислотный дождь", "Выброс", "Яд" }  },
                new Question { text = "Wastes.png", answer = "Wastes", textAnswer="", answerArray=new string[4] { "Reduce", "Soil", "Dust", "Wastes" }  },
                new Question { text = "To_protect.png", answer = "To protect", textAnswer="", answerArray=new string[4] { "To protect", "To pollute", "To сontaminate", "To destroy" }  },
                new Question { text = "Landfill.png", answer = "Свалка", textAnswer="", answerArray=new string[4] { "Озоновая дыра", "Род", "Ядро", "Свалка" }  },
                new Question { text = "Greenhouse_effect.png", answer = "Greenhouse effect", textAnswer="", answerArray=new string[4] { "Acid rains", "Global warming", "Ozone holes", "Greenhouse effect" }  },
                new Question { text = "Acid_rains.png", answer = "Acid rains", textAnswer="", answerArray=new string[4] { "Acid rains", "Global warming", "Ozone holes", "Greenhouse effect" }  },
                new Question { text = "Household.png", answer = "Бытовой", textAnswer="",answerArray=new string[4] { "Использованный", "Возобновляемый", "Бытовой", "Вымерший" }  },
                new Question { text = "Renewable.png", answer = "Возобновляемый", textAnswer="", answerArray=new string[4] { "Бытовой", "Возобновляемый", "Вымерший", "Нетрадиционный" } },
                new Question { text = "Melt.png", answer = "Melt", textAnswer="", answerArray=new string[4] { "Melt", "Reuse", "Species", "Nuclear" }  },
                new Question { text = "Reuse.png", answer = "Reuse", textAnswer="",answerArray=new string[4] { "Extinct", "Reuse", "Species", "Nuclear" }  },
                new Question { text = "Recycle.png", answer = "Возвращать в оборот", textAnswer="", answerArray=new string[4] { "Таять", "Уменьшать", "Возвращать в оборот", "Использовать снова" } },
                new Question { text = "Nuclear.png", answer = "Nuclear", textAnswer="", answerArray=new string[4] { "Landfill", "Nuclear", "Valuable", "Melt" }  },
                new Question { text = "Valuable.png", answer = "Ценный", textAnswer="", answerArray=new string[4] { "Ядерный", "Вымерший", "Бытовой", "Ценный" }  },
                new Question { text = "Endless.png", answer = "Бесконечный", textAnswer="", answerArray=new string[4] { "Бесконечный", "Конечный", "Возобновляемый", "Невозобновляемый" }  },
                new Question { text = "Household.png", answer = "Household", textAnswer="", answerArray=new string[4] { "Household", "Landfill", "Nuclear", "Mankind" }  },
                new Question { text = "Global_warming.png", answer = "Глобальное потепление", textAnswer="", answerArray=new string[4] { "Глобальная опасность", "Кислотные дожди", "Озоновые дыры", "Глобальное потепление" }  },
                new Question { text = "List.png", answer = "Список", textAnswer="", answerArray=new string[4] { "Порода", "Список", "Почва", "Вид" }  },


            };



            Question[] questionsArrayathome = {

                new Question { text = "Conquer.png", answer = "Завоевать", textAnswer="",answerArray=new string[4] { "Распространить", "Состоять из", "Граничить", "Завоевать" }  },
                new Question { text = "The_lungs_of_Europe.jpg", answer = "Легкие Европы", textAnswer="", answerArray=new string[4] { "Руки Европы", "Лицо Европы", "Тело Европы", "Легкие Европы" } },
                new Question { text = "Spread.png", answer = "Spread", textAnswer="", answerArray=new string[4] { "Spread", "Numerous", "Mild", "Changeable" }  },
                new Question { text = "Bison.png", answer = "Bison", textAnswer="", answerArray=new string[4] { "Island", "Cornflower", "Stork", "Bison" }  },
                new Question { text = "Mountainous.png", answer = "Горный", textAnswer="", answerArray=new string[4] { "Валютный", "Валюты", "Горы", "Горный" }  },
                new Question { text = "The_surface.png", answer = "The surface", textAnswer="", answerArray=new string[4] { "Swamp", "The surface", "The currency", "The anthem" }  },
                new Question { text = "Grassland_A_vast_plain.png", answer = "Широкая долина", textAnswer="", answerArray=new string[4] { "Широкая долина", "Узкая долина", "Кривая долина", "Волнистая долина" }  },
                new Question { text = "Stork.png", answer = "Аист", textAnswer="", answerArray=new string[4] { "Аист", "Зубр", "Василек", "Луг" }  },
                new Question { text = "Cornflower.png", answer = "Cornflower", textAnswer="", answerArray=new string[4] { "Cornflower", "Bison", "Mountain", "Stork" }  },
                new Question { text = "The_most_densely_populated.png", answer = "The most densely populated", textAnswer="", answerArray=new string[4] { "The anthem", "The currency", "The most densely populated", "The lungs of Europe" }  },
                new Question { text = "Important.png", answer = "Важный", textAnswer="",answerArray=new string[4] { "Изменчивый", "Управлящий", "Называющийся", "Важный" }  },
                new Question { text = "To_be_separated_from.png", answer = "Отделяться", textAnswer="", answerArray=new string[4] { "Отделяться", "Граничить", "Влиять", "Управлять" } },
                new Question { text = "To_consist_of_Changeable.png", answer = "To consist of", textAnswer="", answerArray=new string[4] { "To border on", "To be separated from", "To be situated", "To consist of" }  },
                new Question { text = "To_border_on.png", answer = "Граничить", textAnswer="",answerArray=new string[4] { "Влиять", "Граничить", "Отделяться", "Завоевать" }  },
                new Question { text = "To_be_called.png", answer = "Называться", textAnswer="", answerArray=new string[4] { "Влиять", "Отделяться", "Называться", "Завоевать" } },
                new Question { text = "To_influence_the_climate.png", answer = "To influence the climate", textAnswer="", answerArray=new string[4] { "To influence the climate", "To be situated", "To consist of", "To be separated from" }  },
                new Question { text = "The_surface.png", answer = "Поверхность", textAnswer="", answerArray=new string[4] { "Валюта", "Поверхность", "Гимн", "Граница" }  },
                new Question { text = "The_anthem.png", answer = "Гимн", textAnswer="", answerArray=new string[4] { "Гимн", "Валюта", "Граница", "Поверхность" }  },
                new Question { text = "An_island.png", answer = "An island", textAnswer="", answerArray=new string[4] { "An island", "Spread", "Conquer", "Grassland" }  },
                new Question { text = "Spread.png", answer = "Распространить", textAnswer="", answerArray=new string[4] { "Состоять из", "Граничить", "Распространить", "Сильно изменяться" }  },
                new Question { text = "The_head_of_the_state.png", answer = "Глава государства", textAnswer="", answerArray=new string[4] { "Правитель", "Гимн", "Глава государства", "Король" }  },
                new Question { text = "To_rule.png", answer = "To rule", textAnswer="", answerArray=new string[4] { "To vary greatly", "To be called", "To influence", "To rule" }  },
                new Question { text = "To_vary_greatly.png", answer = "To vary greatly", textAnswer="", answerArray=new string[4] { "To vary greatly", "To be called", "A vast plain", "The most densely populated" }  },
               
            };


            Question[] questionsArraywohn = {

                new Question { text = "Detached_house.jpg", answer = "Дом", textAnswer="",answerArray=new string[4] { "Дом", "Таунхаус", "Особняк", "Многоквартирный дом" }  },
                new Question { text = "Terraced_house.jpg", answer = "Таунхаус", textAnswer="", answerArray=new string[4] { "Таунхаус", "Особняк", "Многоквартирный дом", "Дом" } },
                new Question { text = "Detached_house.jpg", answer = "das Einfamilienhaus", textAnswer="", answerArray=new string[4] { "das Reihenhaus", "das Bauernhaus", "das Einfamilienhaus", "das Mehrfamilienhaus" }  },
                new Question { text = "Cottage.jpg", answer = "Крестьянский дом", textAnswer="", answerArray=new string[4] { "Таунхаус", "Крестьянский дом", "Дом", "Особняк" }  },
                new Question { text = "Bungalow.jpg", answer = "Собственный дом", textAnswer="", answerArray=new string[4] { "Собственный дом", "Крестьянский дом", "Дом", "Многоквартирный дом" }  },
                new Question { text = "ladder.jpg", answer = "die Treppe", textAnswer="", answerArray=new string[4] { "der Innenhof", "die Wohnfläche", "der Fensterladen", "die Treppe" }  },
                new Question { text = "Cottage.jpg", answer = "Вход", textAnswer="", answerArray=new string[4] { "Квартира", "Лестница", "Вход", "Внутренний двор" }  },
                new Question { text = "Ladder_room.jpg", answer = "Лестничная клетка", textAnswer="", answerArray=new string[4] { "Лестница", "Аренда", "Лестничная клетка", "Жилая площадь" }  },
                new Question { text = "arentator.jpg", answer = "der Vermieter", textAnswer="", answerArray=new string[4] { "vermieten", "der Mieter", "mieten", "der Vermieter" }  },
                new Question { text = "Flat_Apartment.jpg", answer = "die Gemütlichkeit", textAnswer="", answerArray=new string[4] { "die Gemütlichkeit", "gemütlich", "möblieren", "der Vorhang" }  },
                new Question { text = "paint.png", answer = "streichen", textAnswer="",answerArray=new string[4] { "das Poster", "möblieren", "streichen", "gemütlich" }  },
                new Question { text = "move.png", answer = "Переезжать", textAnswer="", answerArray=new string[4] { "Переезжать", "Переехать", "Выезжать", "Переезд" } },
                new Question { text = "Flat_Apartment.jpg", answer = "die Wohnfläche", textAnswer="", answerArray=new string[4] { "das Reihenhaus", "das Haus", "idas Treppenhaus", "die Wohnfläche" }  },
                new Question { text = "machine_building.png", answer = "Оборудование", textAnswer="",answerArray=new string[4] { "Жилая площадь", "Оборудование", "Комфорт", "Плакат" }  },
                new Question { text = "article.png", answer = "Плакат", textAnswer="", answerArray=new string[4] { "Обои", "Оборудование", "Плакат", "Рисовать" } },
                new Question { text = "wallpaper.png", answer = "die Tapete", textAnswer="", answerArray=new string[4] { "die Tapete", "die Miete", "das Poster", "der Vorhang" }  },
                new Question { text = "Curtains.jpg", answer = "der Vorhang", textAnswer="", answerArray=new string[4] { "die Tapete", "die Miete", "das Poster", "der Vorhang" }  },
                new Question { text = "Central_heating.jpg", answer = "Утепление", textAnswer="", answerArray=new string[4] { "Обставлять квартиру мебелью", "Утепление", "Оборудовать", "Переезжать" }  },
                new Question { text = "Rent.png", answer = "mieten", textAnswer="", answerArray=new string[4] { "mieten", "die Miete", "zur Miete wohnen", "der Mieter" }  },
                new Question { text = "Flat_Apartment.jpg", answer = "Комфорт", textAnswer="", answerArray=new string[4] { "Переезд", "Комфортно", "Комфорт", "Расходы" }  },
                new Question { text = "Flat_Apartment.jpg", answer = "Квартира", textAnswer="", answerArray=new string[4] { "Недостаток", "Плакат", "Квартира", "Атмосфера в квартире" }  },
                new Question { text = "wind.jpg", answer = "das Doppelfenster", textAnswer="", answerArray=new string[4] { "das Doppelfenster", "bevorzugen", "der Innenhof", "das Eigentum" }  },
                new Question { text = "Spacious.jpg", answer = "zur Untermiete wohnen", textAnswer="", answerArray=new string[4] { "zur Untermiete wohnen", "zur Miete wohnen", "die Miete", "der Vermieter" }  },
                
            };

            Question[] questionsArrayshul = {

                new Question { text = "citizen.jpg", answer = "Внешкольный", textAnswer="",answerArray=new string[4] { "Внешкольный", "Внешкольная работа", "Школа", "Начальная школа" }  },
                new Question { text = "sec_spec_educ.jpg", answer = "Профессиональная школа", textAnswer="", answerArray=new string[4] { "Гимназия", "Начальная школа", "Профессиональная школа", "Ясли" } },
                new Question { text = "gymnasium.jpg", answer = "das Gymnasium", textAnswer="", answerArray=new string[4] { "die Schulstufe", "die Realschule", "die Hauptschule", "das Gymnasium" }  },
                new Question { text = "basic_school.jpg", answer = "Базовая школа", textAnswer="", answerArray=new string[4] { "Ступень (обучения)", "Гимназия", "Реальная школа", "Базовая школа" }  },
                new Question { text = "higher_educ.jpg", answer = "Старшие классы", textAnswer="", answerArray=new string[4] { "Классы средней ступени", "Старшие классы", "Младшие классы", "Ступень (обучения)" }  },
                new Question { text = "primary_school.jpg", answer = "die Grundstufe", textAnswer="", answerArray=new string[4] { "die Grundstufe", "die Oberstufe", "die Mittelstufe", "die Schulstufe" }  },
                new Question { text = "start_school.jpg", answer = "Начало учебного года", textAnswer="", answerArray=new string[4] { "Четверть", "Полугодие", "Начало учебного года", "Учебный месяц" }  },
                new Question { text = "term.jpg", answer = "das Viertel", textAnswer="", answerArray=new string[4] { "das Halbjahr", "das Viertel", "das Schulfach", "der Schulbeginn" }  },
                new Question { text = "subject.png", answer = "das Wahlfach", textAnswer="", answerArray=new string[4] { "die Grundstufe", "das Viertel", "das Wahlfach", "die Klassenarbeit" }  },
                new Question { text = "subject.png", answer = "das Schulfach", textAnswer="", answerArray=new string[4] { "die Klassenarbeit", "die Mittelstufe", "das Viertel", "das Schulfach" }  },
                new Question { text = "gen_sec_educ.jpg", answer = "Контрольная работа", textAnswer="",answerArray=new string[4] { "Достижение", "Успех", "Экзамен", "Контрольная работа" }  },
                new Question { text = "take_exams.jpg", answer = "Экзамен", textAnswer="", answerArray=new string[4] { "Достижение", "Успех", "Экзамен", "Контрольная работа" } },
                new Question { text = "pass_exams.jpg", answer = "die Abschlussprüfung", textAnswer="", answerArray=new string[4] { "die Abschlussprüfung", "die Aufnahmeprüfung", "eine Prüfung ablegen", "die Prüfung" }  },
                new Question { text = "take_exams.jpg", answer = "die Aufnahmeprüfung", textAnswer="",answerArray=new string[4] { "eine Prüfung ablegen", "die Verantwortung", "die Abschlussprüfung", "die Aufnahmeprüfung" }  },
                new Question { text = "atest.jpg", answer = "Аттестат об окончании средней школы", textAnswer="", answerArray=new string[4] { "Аттестат об окончании средней школы", "Удостоверение", "Свидетельство", "Справка" } },
                new Question { text = "part_time.jpg", answer = "lösen", textAnswer="", answerArray=new string[4] { "das Zeugnis", "lösen", "eine Prüfung ablegen", "seinen Abschluss machen" }  },
                new Question { text = "term.jpg", answer = "Полугодие", textAnswer="", answerArray=new string[4] { "Полугодие", "Школьная работа", "Ступень (обучения)", "Внешкольная работа" }  },
                new Question { text = "successfuly.png", answer = "Успех", textAnswer="", answerArray=new string[4] { "Ответственность", "Решение", "Решать", "Успех" }  },
                new Question { text = "gen_sec_educ.jpg", answer = "der Abschluss", textAnswer="", answerArray=new string[4] { "der Abschluss", "der Hauptschulabschluss", "der Schulbeginn", "die Berufsschule" }  },
                new Question { text = "take_exams.jpg", answer = "Сдавать экзамен", textAnswer="", answerArray=new string[4] { "Сдать экзамен", "Сдавать экзамен", "Приемная коммисия", "Аттестат" }  },
                new Question { text = "otvets.jpg", answer = "Ответственность", textAnswer="", answerArray=new string[4] { "Свидетельство", "Брать ответственность", "Ответственность", "Аттестат" }  },
                new Question { text = "otvets.jpg", answer = "die Verantwortung übernehmen", textAnswer="", answerArray=new string[4] { "die Verantwortung übernehmen", "das Zeugnis", "die Verantwortung", "das Abiturzeugnis" }  },
                new Question { text = "atest.jpg", answer = "das Zeugnis der mittleren Reife", textAnswer="", answerArray=new string[4] { "das Zeugnis der mittleren Reife", "das Reifezeugnis", "das Abiturzeugnis", "das Zeugnis" }  },
                
            };




            Question[] questionsArraymessen = {

                new Question { text = "smi.png", answer = "СМИ", textAnswer="",answerArray=new string[4] { "ТВ", "СМИ", "Факт", "Сообщение" }  },
                new Question { text = "fact.png", answer = "Факт", textAnswer="", answerArray=new string[4] { "Сообщение", "Факт", "ТВ", "СМИ" } },
                new Question { text = "broadcast.png", answer = "die Nachricht", textAnswer="", answerArray=new string[4] { "die Nachricht", "der Kommentar", "der Leserbrief", "das Interview" }  },
                new Question { text = "interview.png", answer = "Интервью", textAnswer="", answerArray=new string[4] { "Интервью", "Комментарий", "Статья", "Реклама" }  },
                new Question { text = "make_headlines.jpg", answer = "Объявление", textAnswer="", answerArray=new string[4] { "Статья", "Объявление", "Комментарий", "Сообщение" }  },
                new Question { text = "comment.png", answer = "der Kommentar", textAnswer="", answerArray=new string[4] { "die Tatsache", "der Kommentar", "das Interview", "der Leserbrief" }  },
                new Question { text = "headline.png", answer = "Письмо читателя", textAnswer="", answerArray=new string[4] { "Факт", "Интервью", "Комментарий", "Письмо читателя" }  },
                new Question { text = "disadvantage.png", answer = "Критиковать", textAnswer="", answerArray=new string[4] { "Сообщать", "Подписывать", "Критиковать", "Развлекать" }  },
                new Question { text = "article.png", answer = "der Artikel", textAnswer="", answerArray=new string[4] { "der Leserbrief", "der Artikel", "die Tatsache", "der Kommentar" }  },
                new Question { text = "broadsheet.jpg", answer = "die Titelseite", textAnswer="", answerArray=new string[4] { "die Werbung", "die Zeile", "die Schlagzeile", "die Titelseite" }  },
                new Question { text = "event.png", answer = "Событие", textAnswer="",answerArray=new string[4] { "Статья", "Событие", "Сообщение", "Трансляция" }  },
                new Question { text = "broadcast.png", answer = "Сообщение", textAnswer="", answerArray=new string[4] { "Трансляция", "Сообщение", "Событие", "Статья" } },
                new Question { text = "make_headlines.jpg", answer = "die Schlagzeile", textAnswer="", answerArray=new string[4] { "die Schlagzeile", "die Werbung", "die Zeile", "die Titelseite" }  },
                new Question { text = "advantage.png", answer = "Подписываться", textAnswer="",answerArray=new string[4] { "Писать письмо", "Сообщать", "Подписываться", "Выпускать" }  },
                new Question { text = "quiz_show.png", answer = "(Теле)викторина", textAnswer="", answerArray=new string[4] { "(Теле)викторина", "Передача", "Телевидение", "Развлекательная передача" } },
                new Question { text = "comedy.png", answer = "die Sendung", textAnswer="", answerArray=new string[4] { "die Unterhaltungssendung", "die Quizsendung", "das Fernsehen", "die Sendung" }  },
                new Question { text = "info.png", answer = "Информационная передача", textAnswer="", answerArray=new string[4] { "Информационная передача", "(Теле)викторина", "Передача", "Газета" }  },
                new Question { text = "broadsheet.jpg", answer = "Выпускать газету", textAnswer="", answerArray=new string[4] { "Выпускать газету", "Снимать фильм", "Сниматься в кино", "Критиковать" }  },
                new Question { text = "commercial.png", answer = "die Werbung", textAnswer="", answerArray=new string[4] { "der Kommentar", "die Werbung", "der Leserbrief", "der Artikel" }  },
                new Question { text = "current_affairs.png", answer = "regional", textAnswer="", answerArray=new string[4] { "regional", "berichten", "lokal", "herausgeben" }  },
                new Question { text = "smi.png", answer = "Электронные СМИ", textAnswer="", answerArray=new string[4] { "СМИ", "Печатные СМИ", "Аудиовизуальные СМИ", "Электронные СМИ" }  },
                new Question { text = "front_page.png", answer = "das Nachrichtenmagazin", textAnswer="", answerArray=new string[4] { "der Artikel", "die Nachricht", "das Nachrichtenmagazin", "der Bericht" }  },
               
            };


            Question[] questionsArraykunst = {

                new Question { text = "die_Kunst.png", answer = "Искусство", textAnswer="",answerArray=new string[4] { "Художник", "Искусство", "Скульптура", "Натюрморт" }  },
                new Question { text = "Landmark.png", answer = "Живопись", textAnswer="", answerArray=new string[4] { "Живопись", "Архитектура", "Скульптура", "Натюрморт" } },
                new Question { text = "Piece_of_art.png", answer = "das Selbstbildnis", textAnswer="", answerArray=new string[4] { "das Selbstbildnis", "das Stillleben", "die Zeichnung", "das Bildnis" }  },
                new Question { text = "Sculptor.png", answer = "Скульптор", textAnswer="", answerArray=new string[4] { "Живопись", "Скульптор", "Архитектура", "Натюрморт" }  },
                new Question { text = "BP.png", answer = "Чертеж", textAnswer="", answerArray=new string[4] { "Художник", "Скульптура", "Картина", "Чертеж" }  },
                new Question { text = "Artist_Painter.png", answer = "der Kunstler", textAnswer="", answerArray=new string[4] { "der Kunstler", "das Selbstbildnis", "der Bildhauer", "die Malerei" }  },
                new Question { text = "eskiz.png", answer = "Эскиз", textAnswer="", answerArray=new string[4] { "Впечатление", "Рисунок", "Чертеж", "Эскиз" }  },
                new Question { text = "Exhibition.png", answer = "Выставка", textAnswer="", answerArray=new string[4] { "КЧертеж", "Эскиз", "Выставка", "Краска" }  },
                new Question { text = "Exhibition.png", answer = "Картинная галерея", textAnswer="", answerArray=new string[4] { "Картинная галерея", "Коллекция картин", "Натюрморт", "Влияние" }  },
                new Question { text = "gal.png", answer = "die Gemaldesammlung", textAnswer="", answerArray=new string[4] { "die Gemäldegalerie", "die Wirkung", "die Gemaldesammlung", "die Ausstellung" }  },
                new Question { text = "rovn.png", answer = "Ровный", textAnswer="",answerArray=new string[4] { "Наклонный", "Мягкий", "Ровный", "Твердый" }  },
                new Question { text = "solid.png", answer = "Твердый", textAnswer="", answerArray=new string[4] { "Наклонный", "Мягкий", "Ровный", "Твердый" } },
                new Question { text = "handi.png", answer = "Мягкий", textAnswer="", answerArray=new string[4] { "Наклонный", "Мягкий", "Ровный", "Твердый" }  },
                new Question { text = "mat.png", answer = "Материал", textAnswer="",answerArray=new string[4] { "Холст", "Материал", "Ровный", "Твердый" }  },
                new Question { text = "canv.png", answer = "Холст", textAnswer="", answerArray=new string[4] { "Ровный", "Наклонный", "Материал", "Холст" } },
                new Question { text = "rovn.png", answer = "Прямой", textAnswer="", answerArray=new string[4] { "Прямой", "Наклонный", "Твердый", "Кривой" }  },
                new Question { text = "krivoi.png", answer = "Наклонный", textAnswer="", answerArray=new string[4] { "Прямой", "Наклонный", "Твердый", "Кривой" }  },
                new Question { text = "Oil_painting.png", answer = "Краска", textAnswer="", answerArray=new string[4] { "Краска", "Краситель", "Холст", "Цвет" }  },
                new Question { text = "canv.png", answer = "die Leinwand", textAnswer="", answerArray=new string[4] { "die Flache", "das Material", "die Leinwand", "die Bildersammlung" }  },
                new Question { text = "Mural_Writer.png", answer = "die Flache", textAnswer="", answerArray=new string[4] { "die Flache", "das Material", "die Leinwand", "die Bildersammlung" }  },
                new Question { text = "Impress.png", answer = "Впечатление", textAnswer="", answerArray=new string[4] { "Впечатление", "Представление", "Влияние", "Изображение" }  },
                new Question { text = "prozrach.png", answer = "durchsichtig", textAnswer="", answerArray=new string[4] { "die Flache", "die Skizze", "durchsichtig", "das Material" }  },
                new Question { text = "Landmark.png", answer = "kunstlerisch", textAnswer="", answerArray=new string[4] { "die Kunst", "durchsichtig", "darstellen", "kunstlerisch" }  },
               

            };
            Question[] questionsArrayjugend = {

                new Question { text = "die_Jugend.png", answer = "Молодёжь", textAnswer="",answerArray=new string[4] { "Молодёжь", "Взрослый", "Старый", "Молодой" }  },
                new Question { text = "unabhangig.png", answer = "Независимый", textAnswer="", answerArray=new string[4] { "Независимый", "Равнодушный", "Уверенный", "Самоуверенный" } },
                new Question { text = "neugierig.png", answer = "neugierig", textAnswer="", answerArray=new string[4] { "neugierig", "gleichgültig", "launisch", "selbstbewusst" }  },
                new Question { text = "launisch.png", answer = "Капризный", textAnswer="", answerArray=new string[4] { "neugierig", "gleichgültig", "launisch", "selbstbewusst" }  },
                new Question { text = "selbstbewusst.png", answer = "Самоуверенный", textAnswer="", answerArray=new string[4] { "Уверенный", "Самоуверенный", "Гордый", "Неуверенный" }  },
                new Question { text = "stolz.png", answer = "stolz", textAnswer="", answerArray=new string[4] { "selbstsicher", "unsicher", "sorglos", "stolz" }  },
                new Question { text = "sorglos.jpg", answer = "Беззаботный", textAnswer="", answerArray=new string[4] { "Уверенный", "Неуверенный", "Беззаботный", "Гордый" }  },
                new Question { text = "neugierig.png", answer = "Любопытный", textAnswer="", answerArray=new string[4] { "Любопытный", "Гордый", "Уверенный", "избалованный" }  },
                new Question { text = "verwohnt.jpg", answer = "verwohnt", textAnswer="", answerArray=new string[4] { "jung", "stolz", "unsicher", "verwohnt" }  },
                new Question { text = "die_Jugend.png", answer = "jung", textAnswer="", answerArray=new string[4] { "jung", "stolz", "unsicher", "verwohnt" }  },
                new Question { text = "der_die_Erwachsene.png", answer = "Взрослый", textAnswer="",answerArray=new string[4] { "Взрослый", "Общественный", "Добровольный", "Бедный" }  },
                new Question { text = "Society.png", answer = "Общественный", textAnswer="", answerArray=new string[4] { "Взрослый", "Общественный", "Добровольный", "Бедный" } },
                new Question { text = "die_Aktion.png", answer = "die Aktion", textAnswer="", answerArray=new string[4] { "freiwillig", "die Aktion", "das Rote Kreuz", "arm" }  },
                new Question { text = "arm.png", answer = "Бедный", textAnswer="",answerArray=new string[4] { "Акция", "Красный крест", "Честь", "Бедный" }  },
                new Question { text = "die_Ehre.png", answer = "Честь", textAnswer="", answerArray=new string[4] { "Воспитание", "Акция", "Бедный", "Честь" } },
                new Question { text = "Member.png", answer = "das Mitglied", textAnswer="", answerArray=new string[4] { "erziehen", "das Mitglied", "der Verband", "das Rote Kreuz" }  },
                new Question { text = "Society.png", answer = "Общество", textAnswer="", answerArray=new string[4] { "Красный крест", "Член (организации)", "Осуществление", "Общество" }  },
                new Question { text = "das_Rote_Kreuz.jpg", answer = "Красный крест", textAnswer="", answerArray=new string[4] { "Красный крест", "Член (организации)", "Осуществление", "Общество" }  },
                new Question { text = "die_Forderung.png", answer = "die Forderung", textAnswer="", answerArray=new string[4] { "das Mitglied", "der Verband", "erziehen", "die Forderung" }  },
                new Question { text = "erziehen.png", answer = "erziehen", textAnswer="", answerArray=new string[4] { "bevorzugen", "die Forderung", "verbinden", "erziehen" }  },
                new Question { text = "prefer.png", answer = "bevorzugen", textAnswer="", answerArray=new string[4] { "bevorzugen", "die Forderung", "verbinden", "erziehen" }  },


            };

            Question[] questionsArraywissen = {

                new Question { text = "high_tech.png", answer = "Будущее", textAnswer="",answerArray=new string[4] { "Будущее", "Прошлое", "Настоящее", "Столетие" }  },
                new Question { text = "century.png", answer = "Прошлое", textAnswer="", answerArray=new string[4] { "Будущее", "Прошлое", "Настоящее", "Столетие" } },
                new Question { text = "life_.png", answer = "Настоящее", textAnswer="", answerArray=new string[4] { "Будущее", "Прошлое", "Настоящее", "Столетие" }  },
                new Question { text = "century.png", answer = "Столетие", textAnswer="", answerArray=new string[4] { "Столетие", "Тысячелетие", "Десятилетие", "Будущее" }  },
                new Question { text = "mill.jpg", answer = "Тысячелетие", textAnswer="", answerArray=new string[4] { "Столетие", "Тысячелетие", "Десятилетие", "Прошлое" }  },
                new Question { text = "ten.png", answer = "Десятилетие", textAnswer="", answerArray=new string[4] { "Столетие", "Тысячелетие", "Десятилетие", "Прошлое" }  },
                new Question { text = "invent.png", answer = "Изобретать", textAnswer="", answerArray=new string[4] { "Изобретать", "Изобретение", "Изобретатель", "Открывать" }  },
                new Question { text = "invention.png", answer = "Изобретение", textAnswer="", answerArray=new string[4] { "Изобретатель", "Изобретение", "Изобретать", "Открывать" }  },
                new Question { text = "inventor.png", answer = "Изобретатель", textAnswer="", answerArray=new string[4] { "Изобретатель", "Изобретение", "Изобретать", "Открывать" }  },
                new Question { text = "brain.png", answer = "geistige Arbeit", textAnswer="", answerArray=new string[4] { "korperliche Arbeit", "die Messe", "geistige Arbeit", "die Arbeit" }  },
                new Question { text = "century.png", answer = "korperliche Arbeit", textAnswer="",answerArray=new string[4] { "die Messe", "korperliche Arbeit", "das Kraftwerk", "geistige Arbeit" }  },
                new Question { text = "fair.png", answer = "die Messe", textAnswer="", answerArray=new string[4] { "die Messe", "korperliche Arbeit", "die Arbeit", "geistige Arbeit" } },
                new Question { text = "century.png", answer = "die Arbeit", textAnswer="", answerArray=new string[4] { "das Kraftwerk", "die Messe", "geistige Arbeit", "die Arbeit" }  },
                new Question { text = "scientist.png", answer = "Учёный", textAnswer="",answerArray=new string[4] { "Учёный", "Наука", "Исследователь", "Учитель" }  },
                new Question { text = "explorer.png", answer = "Исследователь", textAnswer="", answerArray=new string[4] { "Учёный", "Наука", "Исследователь", "Учитель" } },
                new Question { text = "discovery.png", answer = "das Wissen", textAnswer="", answerArray=new string[4] { "das Wissen", "die Messe", "geistige Arbeit", "die Arbeit" }  },
                new Question { text = "ecology.png", answer = "Естествознание", textAnswer="", answerArray=new string[4] { "Точная наука", "Наука", "Естествознание", "Познание" }  },
                new Question { text = "reactor.png", answer = "das Kraftwerk", textAnswer="", answerArray=new string[4] { "das Kraftwerk", "das Atomkraftwerk", "das Windrad", "der Preis" }  },
                new Question { text = "device.png", answer = "Производство", textAnswer="", answerArray=new string[4] { "Производство", "Производитель", "Станция", "Завод" }  },
                new Question { text = "windmill.png", answer = "Ветряк", textAnswer="", answerArray=new string[4] { "das Windrad", "das Kraftwerk", "das Atomkraftwerk", "der Preis" }  },
                new Question { text = "pp.png", answer = "das Atomkraftwerk", textAnswer="", answerArray=new string[4] { "das Windrad", "das Kraftwerk", "das Atomkraftwerk", "der Preis" }  },
                new Question { text = "researcher.png", answer = "die Tatigkeit", textAnswer="", answerArray=new string[4] { "das Vorbild", "die Tatigkeit", "die Gegenwart", "der Nobelpreis" }  },


            };

            Question[] questionsArrayberuf = {

                new Question { text = "app.png", answer = "Исполнять", textAnswer="",answerArray=new string[4] { "Исполнять", "Обслуживать", "Возделывать", "Обрабатывать" }  },
                new Question { text = "br_mind.png", answer = "Заниматься чем-либо", textAnswer="", answerArray=new string[4] { "Исполнять", "Обрабатывать", "Заниматься чем-либо", "Обслуживать" } },
                new Question { text = "Soil.png", answer = "bebauen", textAnswer="", answerArray=new string[4] { "ausüben", "einen Beruf ausüben", "bedienen", "bebauen" }  },
                new Question { text = "Controlled.png", answer = "Обслуживать", textAnswer="", answerArray=new string[4] { "Исполнять", "Обслуживать", "Возделывать", "Обрабатывать" }  },
                new Question { text = "repair.png", answer = "Ремонтировать", textAnswer="", answerArray=new string[4] { "Исследовать", "Развлекать", "Ремонтировать", "Обслуживать" }  },
                new Question { text = "Carpenter.png", answer = "unterhalten", textAnswer="", answerArray=new string[4] { "untersuchen", "bedienen", "reparieren", "unterhalten" }  },
                new Question { text = "exploration.png", answer = "Исследовать", textAnswer="", answerArray=new string[4] { "Исследовать", "Развлекать", "Ремонтировать", "Обслуживать" }  },
                new Question { text = "Unique.png", answer = "Талант", textAnswer="", answerArray=new string[4] { "Гениальность", "Талант", "Везение", "Удача" }  },
                new Question { text = "Contemporary.png", answer = "beweglich", textAnswer="", answerArray=new string[4] { "beweglich", "untersuchen", "reparieren", "bedienen" }  },
                new Question { text = "Flexible.png", answer = "Способность", textAnswer="", answerArray=new string[4] { "Способность", "Талант", "Ловкость", "Добросовестность" }  },
                new Question { text = "Flexible.png", answer = "Ловкость", textAnswer="",answerArray=new string[4] { "Развлечение", "Талант", "Ловкость", "Добросовестность" }  },
                new Question { text = "Honest.png", answer = "Добросовестность", textAnswer="", answerArray=new string[4] { "Ловкость", "Добросовестность", "Способность", "Талант" } },
                new Question { text = "Work_as.jpg", answer = "die Leistungsfähigkeit", textAnswer="", answerArray=new string[4] { "die Zuverlässigkeit", "die Flexibilität", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "To_protect.png", answer = "die Zuverlässigkeit", textAnswer="",answerArray=new string[4] { "die Zuverlässigkeit", "die Flexibilität", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "Flexible.png", answer = "Ловкий", textAnswer="", answerArray=new string[4] { "Радостный", "Способный", "Ловкий", "Добросовестный" } },
                new Question { text = "Flexible.png", answer = "die Flexibilität", textAnswer="", answerArray=new string[4] { "die Zuverlässigkeit", "die Flexibilität", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "hand.png", answer = "Умелые руки", textAnswer="", answerArray=new string[4] { "Умелые руки", "Неумелые руки", "Чистые руки", "Кривые руки" }  },
                new Question { text = "Strength.png", answer = "Сила", textAnswer="", answerArray=new string[4] { "Юмор", "Красота", "Мудрость", "Сила" }  },
                new Question { text = "die_Kunst.png", answer = "die Kreativität", textAnswer="", answerArray=new string[4] { "das Angebot", "die Kraft", "die Kreativität", "ausbilden" }  },
                new Question { text = "In_the_field_of.jpg", answer = "Сфера", textAnswer="", answerArray=new string[4] { "Сила", "Сфера", "Искусство", "Красота" }  },
                new Question { text = "primary_school.jpg", answer = "Учеба", textAnswer="", answerArray=new string[4] { "Мудрость", "Сила", "Учеба", "Красота" }  },
                new Question { text = "pass_exams.jpg", answer = "die Abschlussprüfung", textAnswer="", answerArray=new string[4] { "ausbilden", "das Angebot", "die Abschlussprüfung", "die Flexibilität" }  },
              
                

            };


            Question[] questionsArrayfamilie = {

                new Question { text = "Daughter_in_law.png", answer = "Вырастать", textAnswer="",answerArray=new string[4] { "Вырастать", "Заботиться", "Уход", "Забота" }  },
                new Question { text = "Appreciate.png", answer = "Заботиться", textAnswer="", answerArray=new string[4] { "Вырастать", "Заботиться", "Уход", "Забота" } },
                new Question { text = "Single_Bachelor.jpg", answer = "Одинокий", textAnswer="", answerArray=new string[4] { "Одинокий", "Воспитание", "Поколение", "Ссорится" }  },
                new Question { text = "Single_parent_family.png", answer = "Воспитание", textAnswer="", answerArray=new string[4] { "Ссориться", "Забота", "Воспитание", "Поведение" }  },
                new Question { text = "Divorced_Ex_Wife_Ex_Husband.png", answer = "sich Streiten", textAnswer="", answerArray=new string[4] { "sich Streiten", "minderjährig", "die Generation", "einsam" }  },
                new Question { text = "Stepbrother.png", answer = "Несовершеннолетний", textAnswer="", answerArray=new string[4] { "Молодой", "Старый", "Совершеннолетний", "Несовершеннолетний" }  },
                new Question { text = "piace.png", answer = "Помириться", textAnswer="", answerArray=new string[4] { "Посориться", "Помириться", "Ругаться", "Дружить" }  },
                new Question { text = "piace.png", answer = "sich Vertragen", textAnswer="", answerArray=new string[4] { "sich Versöhnen", "sich Vertragen", "die Ehe schließen", "das Ehepaar" }  },
                new Question { text = "Parents.png", answer = "die Ehe", textAnswer="", answerArray=new string[4] { "sich Versöhnen", "die Ehe schließen", "die Ehe", "volljährig" }  },
                new Question { text = "Wife_Bride.png", answer = "Супруга", textAnswer="", answerArray=new string[4] { "Супруга", "Супруги", "Родители", "Семья" } },
                new Question { text = "Divorced_Ex_Wife_Ex_Husband.png", answer = "geschieden", textAnswer="", answerArray=new string[4] { "geschieden", "heiraten", "sich Versöhnen", "die Ehe schließen" }  },
                new Question { text = "Single_Bachelor.jpg", answer = "Холостой", textAnswer="",answerArray=new string[4] { "Холостой", "Разведенный", "Женатый", "Супружество" }  },
                new Question { text = "Divorced_Ex_Wife_Ex_Husband.png", answer = "Развод", textAnswer="", answerArray=new string[4] { "Развод", "Разрыв сердца", "Обида", "Отвернуться" } },
                new Question { text = "Stepmother_Stepson.png", answer = "die Adoption", textAnswer="", answerArray=new string[4] { "alleinsteehend", "das Adoptivkind", "die Adoption", "die Adoptivneltern" }  },
                new Question { text = "Foster_family.png", answer = "das Adoptivkind", textAnswer="", answerArray=new string[4] { "alleinsteehend", "das Adoptivkind", "die Adoptivneltern", "die Adoption" }  },
                new Question { text = "Stepfather.png", answer = "der Pflegevater", textAnswer="", answerArray=new string[4] { "die Braut", "die Pflegemutter", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Stepmother_Stepson.png", answer = "", textAnswer="die Pflegemutter", answerArray=new string[4] { "die Braut", "die Pflegemutter", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Wife_Bride.png", answer = "die Braut", textAnswer="", answerArray=new string[4] { "die Braut", "die Pflegemutter", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Husband_Groom.png", answer = "der Bräutigam", textAnswer="", answerArray=new string[4] { "die Braut", "die Pflegemutter", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "rings.png", answer = "der Trauring", textAnswer="", answerArray=new string[4] { "der Trauring", "die Braut", "der Pflegevater", "das Adoptivkind" }  },
                

            };

            Question[] questionsArraytour = {

                new Question { text = "Trip.png", answer = "экскурсия", textAnswer="",answerArray=new string[4] { "путеводитель", "путепровод", "экскурсия", "справочное бюро" }  },
                new Question { text = "Trip.png", answer = "путешествие", textAnswer="", answerArray=new string[4] { "путеводитель", "путешествие", "экскурсовод", "справочное бюро" } },
                new Question { text = "Set_off.jpg", answer = "путеводитель", textAnswer="", answerArray=new string[4] { "уезжать", "экскурсия", "путеводитель", "путешествие" }  },
                new Question { text = "Information_desk.png", answer = "справка", textAnswer="", answerArray=new string[4] { "справка", "прибытие", "отъезд", "уезжать" }  },
                new Question { text = "Information_desk.png", answer = "справочное бюро", textAnswer="", answerArray=new string[4] { "справочное бюро", "вокзал", "бюро находок", "билетная касса" }  },
                new Question { text = "Kassa.png", answer = "билетная касса", textAnswer="", answerArray=new string[4] { "справочное бюро", "бюро находок", "вокзал", "билетная касса" }  },
                new Question { text = "Left_luggage_office.jpg", answer = "бюро находок", textAnswer="", answerArray=new string[4] { "бюро находок", "вокзал", "путеводитель", "справочное бюро" }  },
                new Question { text = "Luggage.png", answer = "багаж", textAnswer="", answerArray=new string[4] { "багаж", "сдать багаж", "путь", "рельсовый путь" }  },
                new Question { text = "Luggage.png", answer = "сдать багаж", textAnswer="",answerArray=new string[4] { "сдать багаж", "рельсовый путь", "билетная касса", "туристская база" }  },
                new Question { text = "Vokzal.png", answer = "der Zug", textAnswer="", answerArray=new string[4] { "der Zug", "reisen", "die Bahn", "einsteigen" } },
                new Question { text = "Vix.png", answer = "выходить (из транспорта)", textAnswer="", answerArray=new string[4] { "садиться (в транспорт)", "выходить (из транспорта)", "выходить (из дома)", "входить (в дом)" }  },
                new Question { text = "Package_tour.png", answer = "покупать", textAnswer="",answerArray=new string[4] { "путешествовать", "выходить из транспорта", "садиться в транспорт", "покупать" }  },
                new Question { text = "Package_tour.png", answer = "заказывать", textAnswer="", answerArray=new string[4] { "путешествовать", "заказывать", "бронировать", "садиться в транспорт" } },
                new Question { text = "confetti.png", answer = "событие", textAnswer="", answerArray=new string[4] { "событие", "сдать багаж", "путешествовать", "рельсовый путь" }  },
                new Question { text = "Vokzal.png", answer = "das Gleis", textAnswer="", answerArray=new string[4] { "das Gleis", "das Gepäck aufgeben", "der Schalter", "die Jugendherberge" }  },
                new Question { text = "Otd.png", answer = "die Jugendherberge", textAnswer="", answerArray=new string[4] { "üderbernachten", "die Jugendherberge", "das Gepack", "das Auskunftsbüro" }  },
                new Question { text = "Vokzal.png", answer = "die Eisenbahn", textAnswer="", answerArray=new string[4] { "die Jugendherberge", "die Eisenbahn", "der Schalter", "reisen" }  },
                new Question { text = "Nochevka.png", answer = "üderbernachten", textAnswer="", answerArray=new string[4] { "üderbernachten", "das Erlebnis", "bestellen", "besorgen" }  },


            };


            Question[] questionsArrayunwelt = {

                new Question { text = "Pollution_To_pollute.png", answer = "oтброcы", textAnswer="",answerArray=new string[4] { "грязь", "oтброcы", "засарять", "мусор" }  },
                new Question { text = "co.png", answer = "выхлопной газ", textAnswer="", answerArray=new string[4] { "выхлопной газ", "отбросы", "грязь", "мусор" } },
                new Question { text = "noise.png", answer = "der Lärm", textAnswer="", answerArray=new string[4] { "der Schmutz", "das Düngemittel", "der Müll", "der Lärm" }  },
                new Question { text = "Wastes.png", answer = "der Müll", textAnswer="", answerArray=new string[4] { "der Schmutz", "das Düngemittel", "der Müll", "der Lärm" }  },
                new Question { text = "Landfill.png", answer = "грязь", textAnswer="", answerArray=new string[4] { "отбросы", "грязь", "выхлопной газ", "мусор" }  },
                new Question { text = "fertilizer.png", answer = "das Düngemittel", textAnswer="", answerArray=new string[4] { "das Düngemittel", "der Müll", "der Lärm", "der Schmutz" }  },
                new Question { text = "Dust.png", answer = "пыль", textAnswer="", answerArray=new string[4] { "загрязнение", "грязь", "пыль", "музор" }  },
                new Question { text = "Poison.png", answer = "яд", textAnswer="", answerArray=new string[4] { "яд", "пыль", "опасность", "вред" }  },
                new Question { text = "Tiere.jpg", answer = "bedrohte Tiere", textAnswer="", answerArray=new string[4] { "bedrohte Tiere", "der Staub", "das Gift", "die Gefahr" }  },
                new Question { text = "Emission.png", answer = "schaden", textAnswer="", answerArray=new string[4] { "der Müll", "schaden", "das Düngemittel", "bedrohte Tiere" }  },
                new Question { text = "wildfire.png", answer = "сжигать", textAnswer="",answerArray=new string[4] { "пыль", "отравлять", "вредить", "сжигать" }  },
                new Question { text = "Poison.png", answer = "отравлять", textAnswer="", answerArray=new string[4] { "пыль", "отравлять", "вредить", "сжигать" } },
                new Question { text = "Pollution_To_pollute.png", answer = "verschmutzen", textAnswer="", answerArray=new string[4] { "bedrohte Tiere", "der Müll", "das Düngemittel", "verschmutzen" }  },
                new Question { text = "virus.png", answer = "заражать", textAnswer="",answerArray=new string[4] { "заражать", "загрязнять", "разрушать", "удалять" }  },
                new Question { text = "Destroy.png", answer = "разрушать", textAnswer="", answerArray=new string[4] { "разрушать", "утилизировать", "заражать", "удалять" } },
                new Question { text = "waste.png", answer = "entsorgen", textAnswer="", answerArray=new string[4] { "zerstören", "verseuchte", "bedrohte Tiere", "entsorgen" }  },
                new Question { text = "production.png", answer = "производить", textAnswer="", answerArray=new string[4] { "убирать", "очищать", "производить", "утилизировать" }  },
                new Question { text = "production.png", answer = "производство", textAnswer="", answerArray=new string[4] { "производство", "производить", "утилизировать", "убирать" }  },
                new Question { text = "zoo.png", answer = "das Naturschutzgebiet", textAnswer="", answerArray=new string[4] { "der Schutz", "der Sauerstoff", "die Herstellung", "das Naturschutzgebiet" }  },
                new Question { text = "growth.png", answer = "экономить", textAnswer="", answerArray=new string[4] { "экономить", "кислород", "спасать", "чистить" }  },
                new Question { text = "Environment.png", answer = "окружающая cреда", textAnswer="", answerArray=new string[4] { "кислород", "окружающая cреда", "производство", "заповедник" }  },
                new Question { text = "To_protect.png", answer = "der Umweltschutz", textAnswer="", answerArray=new string[4] { "verarbeiten etwas", "umweltfreundlich", "verbrauchen", "der Umweltschutz" }  },


            };

            Question[] questionsArraysozio = {

                new Question { text = "deputat.png", answer = "депутат", textAnswer="",answerArray=new string[4] { "премьер-министр", "мэр", "президент", "депутат" }  },
                new Question { text = "syd.png", answer = "суд", textAnswer="", answerArray=new string[4] { "депутат", "суд", "законный", "правительство" } },
                new Question { text = "syd.png", answer = "das Gesetz", textAnswer="", answerArray=new string[4] { "das Gericht", "das Parlament", "das Gesetz", "ein Gesetz beachten" }  },
                new Question { text = "politics.png", answer = "политика", textAnswer="", answerArray=new string[4] { "парламент", "политика", "депутат", "закон" }  },
                new Question { text = "politics.png", answer = "совет министров", textAnswer="", answerArray=new string[4] { "президент", "министр", "совет министров", "парламент" }  },
                new Question { text = "government.png", answer = "die Regierung", textAnswer="", answerArray=new string[4] { "die Politik", "die Regierung", "gleich", "der Ministerrat" }  },
                new Question { text = "germany.png", answer = "государство", textAnswer="", answerArray=new string[4] { "государственный", "закон", "суд", "государство" }  },
                new Question { text = "foreigner.png", answer = "иностранец", textAnswer="", answerArray=new string[4] { "председатель", "меньшинство", "иностранец", "президент" }  },
                new Question { text = "germ_gerb.png", answer = "das Wappen", textAnswer="", answerArray=new string[4] { "die Minderheit", "das Wappen", "der Ausländer", "die Lebensweise" }  },
                new Question { text = "pride.png", answer = "die Minderheit", textAnswer="", answerArray=new string[4] { "die Wurzel", "die Verwaltung", "die Minderheit", "das Recht auf etwas" }  },
                new Question { text = "administration.png", answer = "администрация", textAnswer="",answerArray=new string[4] { "администрация", "государство", "правительство", "совет министр" }  },
                new Question { text = "politician.png", answer = "председатель", textAnswer="", answerArray=new string[4] { "мэр", "президент", "министр", "председатель" } },
                new Question { text = "obelisk.png", answer = "das Denkmal", textAnswer="", answerArray=new string[4] { "die Wurzel", "errichten", "die Lebensweise", "das Denkmal" }  },
                new Question { text = "root.png", answer = "die Wurzel", textAnswer="",answerArray=new string[4] { "die Wurzel", "errichten", "die Lebensweise", "das Denkmal" }  },
                new Question { text = "russian.png", answer = "das Volkstracht", textAnswer="", answerArray=new string[4] { "errichten", "die Lebensweise", "das Volkstracht", "das Denkmal" } },
                new Question { text = "literary.png", answer = "das Schriftsprache", textAnswer="", answerArray=new string[4] { "das Schriftsprache", "das Wappen", "der Ausländer", "die Lebensweise" }  },
                new Question { text = "constitution.png", answer = "конституция", textAnswer="", answerArray=new string[4] { "министр", "закон", "суд", "конституция" }  },
                new Question { text = "equality.png", answer = "die Gleichberechtigung", textAnswer="", answerArray=new string[4] { "das Vielfalt", "die Gleichberechtigung", "der Ministerrat", "die Wurzel" }  },
                new Question { text = "trowel.png", answer = "errichten", textAnswer="", answerArray=new string[4] { "gesetzlich", "das Denkmal", "gleich", "errichten" }  },
                new Question { text = "diversity.png", answer = "разнообразие", textAnswer="", answerArray=new string[4] { "равноправие", "разнообразие", "корень", "меньшинство" }  },
                new Question { text = "politics.png", answer = "палата представителей", textAnswer="", answerArray=new string[4] { "правительство", "президент", "министерство", "палата представителей" }  },
                new Question { text = "fair.png", answer = "gesetzlich", textAnswer="", answerArray=new string[4] { "gesetzlich", "das Denkmal", "gleich", "errichten" }  },

            };
            Question[] questionsArraynac = {

                new Question { text = "Polite.png", answer = "приличный", textAnswer="",answerArray=new string[4] { "приличный", "честолюбивый", "гостеприимный", "общительный" }  },
                new Question { text = "Talkative.png", answer = "общительный", textAnswer="", answerArray=new string[4] { "приличный", "честолюбивый", "гостеприимный", "общительный" } },
                new Question { text = "Assertive.png", answer = "честолюбивый", textAnswer="", answerArray=new string[4] { "приличный", "честолюбивый", "гостеприимный", "общительный" }  },
                new Question { text = "Honest.png", answer = "добродушный", textAnswer="", answerArray=new string[4] { "радушие", "добродушный", "добросовестный", "последовательный" }  },
                new Question { text = "Generalization.png", answer = "последовательный", textAnswer="", answerArray=new string[4] { "надежный", "бережливый", "добродушный", "последовательный" }  },
                new Question { text = "growth.png", answer = "бережливый", textAnswer="", answerArray=new string[4] { "надежный", "бережливый", "добродушный", "последовательный" }  },
                new Question { text = "myag.jpg", answer = "мягкие", textAnswer="", answerArray=new string[4] { "мягкие", "острые", "строгие", "нежные" }  },
                new Question { text = "ostr.jpg", answer = "острые", textAnswer="", answerArray=new string[4] { "мягкие", "острые", "строгие", "нежные" }  },
                new Question { text = "strog.jpg", answer = "строгие", textAnswer="", answerArray=new string[4] { "мягкие", "острые", "строгие", "нежные"}  },
                new Question { text = "To_protect.png", answer = "zuverlässig", textAnswer="", answerArray=new string[4] { "ernst", "gewissenhaft", "zuverlässig", "beneiden" }  },
                new Question { text = "Strict.png", answer = "бесцеремонный", textAnswer="",answerArray=new string[4] { "бесцеремонный", "добросовестный", "скупой", "серьезный" }  },
                new Question { text = "Humble.png", answer = "обходительный", textAnswer="", answerArray=new string[4] { "близкий", "обходительный", "знакомый", "надежный" } },
                new Question { text = "Strict.png", answer = "rücksichtslos", textAnswer="", answerArray=new string[4] { "vertraut", "gewissenhaft", "sparsam", "rücksichtslos" }  },
                new Question { text = "respect.png", answer = "уважение", textAnswer="",answerArray=new string[4] { "неуважение", "уважение", "зависть", "скупость" }  },
                new Question { text = "respect.png", answer = "знакомый", textAnswer="", answerArray=new string[4] { "бесцеремонный", "знакомый", "близкий", "родной" } },
                new Question { text = "botox.png", answer = "черты лица", textAnswer="", answerArray=new string[4] { "черты лица", "нация", "устанавливать личность", "уважать" }  },
                new Question { text = "greedy.png", answer = "скупой", textAnswer="", answerArray=new string[4] { "щедрый", "добродушный", "скупой", "последовательный" }  },
                new Question { text = "generous.png", answer = "щедрость", textAnswer="", answerArray=new string[4] { "экономичность", "надёжность", "щедрость", "скупость" }  },
                new Question { text = "Strict.png", answer = "ernst", textAnswer="", answerArray=new string[4] { "identifizieren", "der Respekt", "ernst", "die Nation" }  },
                new Question { text = "passport.png", answer = "", textAnswer="", answerArray=new string[4] { "уважение", "президент", "государство", "нация" }  },
                new Question { text = "conv.png", answer = "убеждать кого-либо", textAnswer="", answerArray=new string[4] { "объяснять кому-либо", "знакомиться", "уважать", "убеждать кого-либо" }  },
                new Question { text = "Honest.png", answer = "gewissenhaft", textAnswer="", answerArray=new string[4] { "gewissenhaft", "zuverlässig", "beneiden", "rücksichtslos" }  },


            };
            Question[] questionsArrayintz = {

                new Question { text = "embassy.png", answer = "Посольство", textAnswer="",answerArray=new string[4] { "Посольство", "Правительство", "Президент", "Организация" }  },
                new Question { text = "unesco.png", answer = "ЮНЕСКО", textAnswer="", answerArray=new string[4] { "ООН", "ЮНЕСКО", "ГГАЭК", "Европейский Союз" } },
                new Question { text = "oon.jpg", answer = "ООН", textAnswer="", answerArray=new string[4] { "ГГАЭК", "ЮНЕСКО", "ООН", "Европейский Союз" }  },
                new Question { text = "union.jpg", answer = "Европейский Союз", textAnswer="", answerArray=new string[4] { "Европейский Союз", "ГГАЭК", "ООН", "ЮНЕСКО" }  },
                new Question { text = "guarantee.png", answer = "Гарантировать", textAnswer="", answerArray=new string[4] { "Соединять", "Объединять", "Гарантировать", "Защищать" }  },
                new Question { text = "To_protect.png", answer = "die Sicherheit", textAnswer="", answerArray=new string[4] { "die Sicherheit", "der Frieden", "die Vereinigung", "der Verständigung" }  },
                new Question { text = "Respectful.png", answer = "Уважать", textAnswer="", answerArray=new string[4] { "Уважать", "Уважение", "Обобщать", "Обобщение" }  },
                new Question { text = "Humanity_Mankind.png", answer = "Общность", textAnswer="", answerArray=new string[4] { "Сообщество", "Общность", "Мероприятие", "Ответственность" }  },
                new Question { text = "evt.png", answer = "die Veranstaltung", textAnswer="", answerArray=new string[4] { "die Sicherheit", "die Veranstaltung", "die Vereinigung", "der Verständigung" }  },
                new Question { text = "Honest.png", answer = "verantwortungsvoll", textAnswer="", answerArray=new string[4] { "die Verantwortung", "die Toleranz", "verantwortungsvoll", "respektieren" }  },
                new Question { text = "Anxious.png", answer = "Терпимость", textAnswer="",answerArray=new string[4] { "Терпимость", "Ответственность", "Уважение", "Характер" }  },
                new Question { text = "united.png", answer = "Союз", textAnswer="", answerArray=new string[4] { "Союз", "Кооперация", "Наследие", "Ответственность" } },
                new Question { text = "peace.png", answer = "der Frieden", textAnswer="", answerArray=new string[4] { "die Vereinigung", "das Erbe", "die Vereinigung", "der Frieden" }  },
                new Question { text = "beneficiary.png", answer = "Наследие", textAnswer="",answerArray=new string[4] { "Мир", "Мероприятие", "Наследие", "Содружество" }  },
                new Question { text = "united.png", answer = "Объединять", textAnswer="", answerArray=new string[4] { "Объединять", "Соединение", "Содружество", "Наследие" } },
                new Question { text = "understandable.png", answer = "Взаимопонимание", textAnswer="", answerArray=new string[4] { "Объединять", "Взаимопонимание", "Содружество", "Наследие" }  },
                new Question { text = "running.png", answer = "Готовность к (чему-л.)", textAnswer="", answerArray=new string[4] { "Готовность к (чему-л.)", "Быть готовым", "Быть ответственным", "Уважать" }  },
                new Question { text = "running.png", answer = "Быть готовым на (что-л.)", textAnswer="", answerArray=new string[4] { "Быть готовым", "Готовность к (чему-л.)", "Уважать", "Быть ответственным" }  },
                new Question { text = "evt.png", answer = "Проводить мероприятие", textAnswer="", answerArray=new string[4] { "Проводить мероприятие", "Быть на мероприятии", "Относиться с уважением", "Уважать" }  },
                new Question { text = "Humanity_Mankind.png", answer = "die Gemeinschaft", textAnswer="", answerArray=new string[4] { "die Toleranz", "das Erbe", "die Gemeinschaft", "der Frieden" }  },
               
            };
            




            var rand = new Random();
           
            
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Тест Houses and homes",
                TestNumber = "1",
                Preload = "Тест на проверку знаний из главы Houses and homes",
                Complited = item.Task1_comp,
                CorrectCount = Convert.ToInt32(item.Test1),
                Questions = questionsArrayhouse.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест Unit Education",
                Complited = item.Task2_comp,
                Preload = "Тест на проверку знаний из главы Education",
                TestNumber = "2",
                CorrectCount = Convert.ToInt32(item.Test2),
                Questions = questionsArrayeduc.OrderBy(x => rand.Next()).Take(10).ToList(),

                //Questions = {
                //    new Question { text = "Слово 11Hello11 означает:", answer = "Привет", textAnswer = "Привет", answerArray = new string[4] { "Пока", "Привет", "Прощай", "До свидания" } },
                //    new Question { text = "Слово 11Goodbye11 означает:", answer = "До свидания", textAnswer = "До свидания", answerArray = new string[4] { "Привет", "Пока", "До свидания", "Прощай" } },
                //    new Question { text = "Слово 11Сон11 на английском:", answer = "Dream", textAnswer = "Dream", answerArray = new string[4] { "Dream", "Night", "Day", "Child" } },
                //    new Question { text = "Слово 11Human11 означает:", answer = "Человек", textAnswer = "Человек", answerArray = new string[4] { "Человек", "Сон", "Ночь", "День" } },
                //    new Question { text = "Слово 11Child11 означает:", answer = "Ребенок", textAnswer = "Ребенок", answerArray = new string[4] { "Мужчина", "Девушка", "Мама", "Ребенок" } },
                //    new Question { text = "Слово 11День11 на английском:", answer = "Day", textAnswer = "Day", answerArray = new string[4] { "Night", "Day", "Monday", "Sunday" } },
                //    new Question { text = "Слово 11Computer11 означает:", answer = "Компьютер", textAnswer = "Компьютер", answerArray = new string[4] { "Телевизор", "Смартфон", "Компьютер", "Планшет" } },
                //    new Question { text = "Слово 11Word11 означает:", answer = "Слово", textAnswer = "Слово", answerArray = new string[4] { "Слово", "Текст", "Дом", "Арбуз" } },
                //    new Question { text = "Слово 11Ночь11 на английском:", answer = "Night", textAnswer = "Night", answerArray = new string[4] { "Day", "Night", "Country", "College" } },
                //    new Question { text = "Слово 11Тест11 на английском:", answer = "Test", textAnswer = "Test", answerArray = new string[4] { "Word", "House", "Day", "Test" } },
                //},




            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Тест Mass Media",
                TestNumber = "3",
                Preload = "Тест на проверку знаний из главы Mass Media",
                Complited = item.Task3_comp,
                CorrectCount = Convert.ToInt32(item.Test3),
                Questions = questionsArraymass.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест Youth and society",
                TestNumber = "4",
                Preload = "Тест на проверку знаний из главы Youth and society",
                Complited = item.Task4_comp,
                CorrectCount = Convert.ToInt32(item.Test4),
                Questions = questionsArrayyouth.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест Art",
                TestNumber = "5",
                Preload = "Тест на проверку знаний из главы Art",
                Complited = item.Task5_comp,
                CorrectCount = Convert.ToInt32(item.Test5),
                Questions = questionsArrayart.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест Science",
                TestNumber = "6",
                Preload = "Тест на проверку знаний из главы Science",
                Complited = item.Task6_comp,
                CorrectCount = Convert.ToInt32(item.Test6),
                Questions = questionsArrayscience.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест Family",
                TestNumber = "7",
                Preload = "Тест на проверку знаний из главы Family",
                Complited = item.Task7_comp,
                CorrectCount = Convert.ToInt32(item.Test7),
                Questions = questionsArrayfamily.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест Jobs",
                TestNumber = "8",
                Preload = "Тест на проверку знаний из главы Jobs",
                Complited = item.Task8_comp,
                CorrectCount = Convert.ToInt32(item.Test8),
                Questions = questionsArrayjobs.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест National character",
                TestNumber = "9",
                Preload = "Тест на проверку знаний из главы National character",
                Complited = item.Task9_comp,
                CorrectCount = Convert.ToInt32(item.Test9),
                Questions = questionsArraynaccar.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест International Cultural ties",
                TestNumber = "10",
                Preload = "Тест на проверку знаний из главы International Cultural ties",
                Complited = item.Task10_comp,
                CorrectCount = Convert.ToInt32(item.Test10),
                Questions = questionsArrayintcult.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест Tourism",
                TestNumber = "11",
                Preload = "Тест на проверку знаний из главы Tourism",
                Complited = item.Task11_comp,
                CorrectCount = Convert.ToInt32(item.Test11),
                Questions = questionsArraytourism.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест Environment",
                TestNumber = "12",
                Preload = "Тест на проверку знаний из главы Environment",
                Complited = item.Task12_comp,
                CorrectCount = Convert.ToInt32(item.Test12),
                Questions = questionsArrayenvir.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 1",
                Title = "Tест At home and abroad",
                TestNumber = "13",
                Preload = "Тест на проверку знаний из главы At home and abroad",
                Complited = item.Task13_comp,
                CorrectCount = Convert.ToInt32(item.Test13),
                Questions = questionsArrayathome.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Wohnomoglichleiten",
                TestNumber = "14",
                Preload = "Тест на проверку знаний из главы Wohnomoglichleiten",
                Complited = item.Task14_comp,
                CorrectCount = Convert.ToInt32(item.Test14),
                Questions = questionsArraywohn.OrderBy(x => rand.Next()).Take(10).ToList(),
            });


            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Shulsystem",
                TestNumber = "15",
                Preload = "Тест на проверку знаний из главы Shulsystem",
                Complited = item.Task15_comp,
                CorrectCount = Convert.ToInt32(item.Test15),
                Questions = questionsArrayshul.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Messenmedien",
                TestNumber = "16",
                Preload = "Тест на проверку знаний из главы Messenmedien",
                Complited = item.Task16_comp,
                CorrectCount = Convert.ToInt32(item.Test16),
                Questions = questionsArraymessen.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Kunst und Kunstler",
                TestNumber = "17",
                Preload = "Тест на проверку знаний из главы Kunst und Kunstler",
                Complited = item.Task17_comp,
                CorrectCount = Convert.ToInt32(item.Test17),
                Questions = questionsArraykunst.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Jugend und Gesellschaft",
                TestNumber = "18",
                Preload = "Тест на проверку знаний из главы Jugend und Gesellschaft",
                Complited = item.Task18_comp,
                CorrectCount = Convert.ToInt32(item.Test18),
                Questions = questionsArrayjugend.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            
            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Wissenschaft und Technik",
                TestNumber = "19",
                Preload = "Тест на проверку знаний из главы Wissenschaft und Technik",
                Complited = item.Task19_comp,
                CorrectCount = Convert.ToInt32(item.Test19),
                Questions = questionsArraywissen.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Berufswahl",
                TestNumber = "20",
                Preload = "Тест на проверку знаний из главы Berufswahl",
                Complited = item.Task20_comp,
                CorrectCount = Convert.ToInt32(item.Test20),
                Questions = questionsArrayberuf.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Familie",
                TestNumber = "21",
                Preload = "Тест на проверку знаний из главы Familie",
                Complited = item.Task21_comp,
                CorrectCount = Convert.ToInt32(item.Test21),
                Questions = questionsArrayfamilie.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Tourismus",
                TestNumber = "22",
                Preload = "Тест на проверку знаний из главы Tourismus",
                Complited = item.Task22_comp,
                CorrectCount = Convert.ToInt32(item.Test22),
                Questions = questionsArraytour.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Unwelt",
                TestNumber = "23",
                Preload = "Тест на проверку знаний из главы Unwelt",
                Complited = item.Task23_comp,
                CorrectCount = Convert.ToInt32(item.Test23),
                Questions = questionsArrayunwelt.OrderBy(x => rand.Next()).Take(10).ToList(),
            });

            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Nationalcharakter",
                TestNumber = "24",
                Preload = "Тест на проверку знаний из главы Soziolkulturelles Portat des Landes",
                Complited = item.Task24_comp,
                CorrectCount = Convert.ToInt32(item.Test24),
                Questions = questionsArraysozio.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Nationalcharakter",
                TestNumber = "25",
                Preload = "Тест на проверку знаний из главы Nationalcharakter",
                Complited = item.Task25_comp,
                CorrectCount = Convert.ToInt32(item.Test25),
                Questions = questionsArraynac.OrderBy(x => rand.Next()).Take(10).ToList(),
            });
            Test.Add(new ImTest
            {
                Chapter = "Глава 2",
                Title = "Tест Internationale Zusammenarbeit",
                TestNumber = "26",
                Preload = "Тест на проверку знаний из главы Internationale Zusammenarbeit",
                Complited = item.Task26_comp,
                CorrectCount = Convert.ToInt32(item.Test26),
                Questions = questionsArrayintz.OrderBy(x => rand.Next()).Take(10).ToList(),
            });







































            // Test.Add(new ImTest
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