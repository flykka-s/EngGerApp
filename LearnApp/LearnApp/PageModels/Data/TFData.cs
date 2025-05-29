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
    public static class TFData
    {
        public static async Task<ObservableRangeCollection<TF>> GetDataAsync()
        {
            var Test = new ObservableRangeCollection<TF>();
            var item = await PageModelLocator.Resolve<IRepositoryTF<DataTF>>().Get("Id");

            Question[] questionsArrayhouse = {
                new Question { text = "Слово ''Hostel'' означает ''Общежитие'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Общежитие", "Многоэтажка" }  },
                new Question { text = "Словосочетание ''Block of flats'' означает ''Многоэтажка'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Средняя школа", "Чердак" } },
                new Question { text = "Слово ''Крошечный'' на английском ''Tiny'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Shower", "Attic" }  },
                new Question { text = "Слово ''Bungalow'' означает ''Ванная'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Снимать (квартиру и т.п.)", "Одноэтажный небольшой домик" }  },
                new Question { text = "Слово ''Nursery'' означает ''Детская комната'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Ванная", "Подвал" }  },
                new Question { text = "Слово ''Спальня'' на английском ''Hostel'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Bathroom", "Kitchen" }  },
                new Question { text = "Словосочетание ''On the outskirts'' означает ''Близко'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "В пригороде", "На окраине" }  },
                new Question { text = "Слово ''Share'' означает ''Делиться'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Просторный", "Светлый" }  },
                new Question { text = "Слово ''Камин'' на английском ''Fireplace'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Fireplace", "Electricity" }  },
                new Question { text = "Словосочетание ''Стиральная машина'' на английском ''Washing machine'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Water supply", "Central heating" }  },
                new Question { text = "Слово ''Freezer'' означает ''Морозильник'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Холод", "Жара" }  },
                new Question { text = "Слово ''Carpet'' означает ''Ковёр'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Зеркало", "Ковёр" } },
                new Question { text = "Слово ''Кран'' на английском ''Sink'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Sink", "Tap" }  },
                new Question { text = "Словосочетание ''Detached house'' означает ''Дом'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Квартира", "Одноэтажный дом" } },
                new Question { text = "Слово ''Шумный'' на английском ''Noisy'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Quiet", "Huge" }  },
                new Question { text = "Слово ''Attic'' означает ''Душ'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Чердак", "Кухня" }  },
                new Question { text = "Слово ''Shower'' означает ''Чердак'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Кабинет", "Душ" }  },
                new Question { text = "Словосочетание ''Система охлаждения'' на английском ''Cooling'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Cooling", "Ceiling" }  },
                new Question { text = "Словосочетание ''Comfy chair'' означает ''Кресло'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Диван", "Кресло" }  },
                new Question { text = "Слово ''Floor'' означает ''Потолок'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Стена", "Дверь" }  },
                new Question { text = "Слово ''Холодильник'' на английском ''Freezer'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Freezer", "Fridge" }  },
                new Question { text = "Слово ''Sink'' означает ''Кран'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Окно", "Дверь" }  },
                new Question { text = "Слово ''Electricity'' означает ''Электричество'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Ковёр", "Электричество" } },
                new Question { text = "Слово ''Прямо в центре'' на английском ''Right in the center'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "On the outskirts", "Right in the center" }  },
                new Question { text = "Слово ''Education'' означает ''Образование'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Обеспечивать", "Детский сад" }  },
                new Question { text = "Словосочетание ''Primary school'' означает ''Детский сад'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Средняя школа", "Ясли" } },
                new Question { text = "Слово ''Директор'' на английском ''Headmaster'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Grades", "Kindergarten" }  },
                new Question { text = "Слово ''Institution'' означает ''Учреждение'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Лицей", "Учреждение" }  },
                new Question { text = "Слово ''Kindergarten'' означает ''Ясли'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Каникулы", "Стипендия" }  },
                new Question { text = "Слово ''Поступить'' на английском ''To go'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Enter", "Break" }  },
                new Question { text = "Словосочетание ''Cloak-room'' означает ''Временная комната'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Кабинет директора", "Класс" }  },
                new Question { text = "Слово ''Library'' означает ''Библиотека'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Староста", "Предмет" }  },
                new Question { text = "Слово ''Куратор'' на английском ''Tutor'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Monitor", "Tutor" }  },
                new Question { text = "Фраза ''Общая средняя школа'' на английском ''General secondary school'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Primary school", "Basic school" }  },
                new Question { text = "Фраза ''Free of charge'' означает ''Платный'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Обеспечивать", "Бесплатный" }  },
                new Question { text = "Слово ''Lyceum'' означает ''Гимназия'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Средняя школа", "Гимназия" } },
                new Question { text = "Аббревиатура ''ГГАЭК'' на английском ''GGWP'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Double period", "Kindergarten" }  },
                new Question { text = "Слово ''Gym'' означает ''Спортзал'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Библиотека", "Спортзал" }  },
                new Question { text = "Слово ''Citizen'' означает ''Гражданин'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Куратор", "Староста" }  },
                new Question { text = "Слово ''Stipend'' означает ''Стипендия'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Стипендия", "Куратор" }  },
                new Question { text = "Словосочетание ''A first year student'' означает ''Первокурсник'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Заканчивающий обучение", "Второкурсник" } },
                new Question { text = "Слово ''Каникулы'' на английском ''Lyceum'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Double period", "Vacation" }  },
                new Question { text = "Слово ''Canteen'' означает ''Библиотека'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Перерыв", "Кабинет" }  },
                new Question { text = "Слово ''Library'' означает ''Столовая'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Библиотека", "Актовый зал" }  },
                new Question { text = "Слово ''Староста'' на английском ''Monitor'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Tutor", "Monitor" }  },
                new Question { text = "Словосочетание ''Gomel State Agro-Economic College'' означает аббревиатуру ''ГГАЭК'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "МТЗ", "R2D2" }  },
                new Question { text = "Слово ''Occupy'' означает ''Занимать'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Государственный", "Поступить" }  },
                new Question { text = "Слово ''Успешно'' на английском ''Success'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Successfully", "Break" }  },
                new Question { text = "Словосочетание ''Сдавать экзамены (процесс)'' на английском ''Pass exams'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Be situated", "Pass exams" }  },
                new Question { text = "Словосочетание ''Assembly hall'' означает ''Спорт зал'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Библиотека", "Кабинет" }  },
                new Question { text = "Слово ''Subject'' означает ''Предмет'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Староста", "Предмет" } },
                new Question { text = "Слово ''Пара'' на английском ''Double period'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Headmaster’s office", "Double period" }  },
                new Question { text = "Слово ''Mass media'' означает ''Средства массовой информации'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Сообщать", "Источник" }  },
               



                };

           

           

            Question[] questionsArrayyouth = {
                new Question { text = "Слово ''Misunderstanding'' означает ''Непонимание'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Плахая привычка", " Деятельность" }  },
                new Question { text = "Словосочетание ''Generation gap'' означает ''Девиз'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Проблема ''отцов и детей''", "Включать в себя" } },
                new Question { text = "Слово ''Многочисленный'' на английском ''Numerous'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Tolerance", "Promote" }  },
                new Question { text = "Слово ''Activity'' означает ''Деятельность'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Благотворительность", "Деятельность" }  },
                new Question { text = "Слово ''Support'' означает ''Поддержка'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Девиз", "Терпимость" }  },
                new Question { text = "Слово ''Девиз'' на английском ''Motto'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Misunderstanding", "Handicapped" }  },
                new Question { text = "Слово ''Member'' означает ''Мембрана'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Организация", "Член организации" }  },
                new Question { text = "Словосочетание ''Patriotic values'' означает ''Патриот'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Финансовые ценности", "Ценности" }  },
                new Question { text = "Фраза ''Принимать активное участие'' на английском ''Patriotic values'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "To take an active part", "Informal youth movements" }  },
                new Question { text = "Слово ''Involve'' означает ''Включать в себя'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Продвигать", "Терпимость" }  },
                new Question { text = "Слово ''Handicapped'' означает ''Точка зрения'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Человек с физическими или умственными недостатками", "Разрыв между поколениями" }  },
                new Question { text = "Словосочетание ''Point of view'' означает ''Плохая привычка'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Продвигать", "Принимать участие" } },
                new Question { text = "Словосочетание ''Bad habits'' означает ''Точка зрения'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Заботиться о …", "Плохие привычки" }  },
                new Question { text = "Слово ''Volunteer'' означает ''Доброволец'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Директор", "Доброволец" }  },
                new Question { text = "Словосочетание ''Carry out'' означает ''Выполнять'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Выполнять", "Включать в себя" }  },
                new Question { text = "Слово ''Promote'' означает '''':", answer = "Продвигать", textAnswer="", answerArray=new string[4] { "True", "False", "Выполнять", "Включать в себя" }  },
                new Question { text = "Слово ''Благотворительность'' на английском ''Charity'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Reach", "Charity" }  },
                new Question { text = "Слово ''Терпимость'' на английском ''Tolerance'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Tolerance", "Charity" }  },
                new Question { text = "Словосочетание ''Take care of'' означает ''Заботиться о …'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Включать в себя", "Заботиться о …" }  },
                new Question { text = "Словосочетание ''To reach'' означает ''Достигать'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Включать в себя", "Достигать" } },
                new Question { text = "Фраза ''Включать в себя'' на английском ''Involve'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Involve", "Support" }  },
                new Question { text = "Слово ''Content'' означает ''Выражать'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Публика", "Визуальный" }  },
                new Question { text = "Слово ''Express'' означает ''Содержание'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Надпись", "Выражать" } },
                new Question { text = "Слово ''Художник'' на английском ''Artist'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Painter", "Composer" }  },
                new Question { text = "Слово ''Architecture'' означает ''Архитектура'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Комикс", "Мультипликация" }  },
                new Question { text = "Слово ''Exhibition'' означает ''Галерея'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Фотография", "Выставка" }  },
                new Question { text = "Слово ''Запретить'' на английском ''Ban'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Filmmaking", "Unique" }  },
                new Question { text = "Слово ''Spectacular'' означает ''Зрелищный'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Зрелищный", "Символический" }  },
                new Question { text = "Слово ''Take part'' означает ''Принимать участие'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Продолжительность жизни", "Естественные науки" }  },
                new Question { text = "Слово ''Vehicle'' означает ''Устройство'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Машина", "Транспортное cредство" }  },
                new Question { text = "Слово ''Прибор'' на английском ''Device'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Device", "Gadget" }  },
                new Question { text = "Словосочетание ''Drug abuse'' означает ''Злоупотребление наркотиками'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Выдающийся / Знаменитый", "Многофункциональное устройство" }  },
                new Question { text = "Слово ''Famine'' означает ''Голод'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Старомодный", "Продвинутый" }  },
                new Question { text = "Слово ''Устройство'' на английском ''Appliance'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Device", "Mechanical" }  },
                new Question { text = "Слово ''Development'' означает ''Развитие'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Открытие", "Развитие" }  },
                new Question { text = "Слово ''Mankind'' означает ''Человечество'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Человечество", "Открытие" } },
                new Question { text = "Слово ''Открывать'' на английском ''Discovery'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Research", "Researcher" }  },
                new Question { text = "Слово ''Scientist'' означает ''Учёный'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Научный", "Наука" }  },
                new Question { text = "Слово ''Agroculture'' означает ''Агрокультура'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Агрокультура", "Cельское хозяйство" }  },
                new Question { text = "Словосочетание ''Old-fashioned'' означает ''Старомодный'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Механический", "Старомодный" } },
                new Question { text = "Слово ''Ecology'' означает ''Экология'':", answer = "True", textAnswer = "", answerArray = new string[4] { "True", "False", "Экология", "Естественные науки" } },
                new Question { text = "Слово ''Data'' означает ''Данные'':", answer = "True", textAnswer = "", answerArray = new string[4] { "True", "False", "Экология", "Естественные науки" } },
                new Question { text = "Слово ''Web'' на английском ''Всемирная паутина'':", answer = "True", textAnswer = "", answerArray = new string[4] { "True", "False", "Наушники", "Всемирная паутина" } },



            };

            
           



            Question[] questionsArrayfamily = {

                new Question { text = "Слово ''Parents'' означает ''Родители'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Дочь", "Братья" }  },
                new Question { text = "Слово ''Son'' означает ''Сын'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Дядя", "Тётя" } },
                new Question { text = "Слово ''Grandson'' означает ''Внук'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Внук", "Правнучка" }  },
                new Question { text = "Слово ''Sibling'' означает ''Правнуки'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Сёстры", "Родители" }  },
                new Question { text = "Слово ''Niece'' означает ''Племянник'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Племянница", "Сестра" }  },
                new Question { text = "Слово ''Племянник'' на английском ''Племянница'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Niece", "Uncle" }  },
                new Question { text = "Словосочетание ''The only child'' означает ''Единственный ребенок'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Сводный брат", "Единственный ребенок" }  },
                new Question { text = "Слово ''Stepsister'' означает ''Сводная cестра'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Внучка", "Сводный брат" }  },
                new Question { text = "Слово ''Жена'' на английском ''Groom'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Groom", "Wife" }  },
                new Question { text = "Словосочетание ''Муж дочери / Зять'' на английском ''Daughter-in-law'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Daughter-in-law", "Son-in-law" }  },
                new Question { text = "Слово ''Divorced'' означает ''Жената'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Холост", "Разведен(а)" }  },
                new Question { text = "Слово ''Twins'' означает ''Брат и сестра'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Родители", "Внуки" } },
                new Question { text = "Словосочетание ''Father-in-law'' означает ''Свекор / тесть'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Словосочетание ''Mother-in-law'' означает ''Свекровь / теща'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Словосочетание ''Son-in-law'' означает ''Муж дочери / зять'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Словосочетание ''Daughter-in-law'' означает ''Жена сына / невестка'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Муж дочери / зять", "Жена сына / невестка" }  },
                new Question { text = "Словосочетание ''Ex-Wife'' означает ''Бывший муж'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Бывший муж", "Приемный сын" }  },
                new Question { text = "Словосочетание ''Ex-Husband'' означает ''Бывшая жена'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Бывшая жена", "Приемная дочь" } },
               
                new Question { text = "Слово ''Electrician'' означает ''Электрик'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Водитель", "Электрик" }  },
                new Question { text = "Слово ''Водитель'' на английском ''Driver'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Driver", "Book-Keeper" }  },
                new Question { text = "Слово ''Plumber'' означает ''Программист'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Продавец", "Кассир" }  },
                new Question { text = "Слово ''Programmer'' означает ''Сантехник'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Милиционер", "Программист" }  },
                new Question { text = "Слово ''Продавец'' на английском ''Shop-assistant'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Engineer", "Postman" }  },
                new Question { text = "Слово ''Postman'' означает ''Почтальон'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Секретарь", "Ветеринар" }  },
                new Question { text = "Слово ''Vet'' означает ''Ветеринар'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Ветеринар", "Сантехник" }  },
                new Question { text = "Слово ''Уборщик'' на английском ''Businessman'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Carpenter", "Secretary" }  },
                new Question { text = "Слово ''Бизнесмен'' на английском ''Cleaner'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Accountant", "Artist" }  },
                new Question { text = "Слово ''Cook'' означает ''Водитель'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Библиотекарь", "Водитель" }  },
                new Question { text = "Слово ''Book-Keeper'' означает ''Библиотекарь'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Столяр / плотник", "Энергетик" } },
                new Question { text = "Словосочетание ''Сильная cторона'' на английском ''Cook'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Strength", "Qualified" }  },
                new Question { text = "Слово ''Career'' означает ''Карьера'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Требовать", "Жалованье" }  },
                new Question { text = "Слово ''Earn'' означает ''Зарабатывать'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Сильная cторона", "Зарабатывать" } },
                new Question { text = "Словосочетание ''Слабые cтороны'' на английском ''Weakness'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Strength", "Qualified" }  },
                new Question { text = "Слово ''Nurse'' означает ''Медсестра'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Официант", "Милиционер" }  },
                new Question { text = "Слово ''Challenging'' означает ''Требующий напряжения'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Нагрузка", "Гарантия занятости" }  },
                new Question { text = "Слово ''Нагрузка'' на английском ''Load'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Load", "Challenging" }  },
                new Question { text = "Слово ''Entrepreneur'' означает ''Бизнесмен'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Официант", "Ветеринар" }  },
                new Question { text = "Словосочетание ''Job security'' означает ''Гарантия занятости'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Защищенность", "Гарантия занятости" }  },
               
            };

          


            Question[] questionsArraynaccar = {

                new Question { text = "Слово ''Stereotype'' означает ''Стереотип'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Гибкий", "Стремление" }  },
                new Question { text = "Слово ''Ambitious'' означает ''Амбициозный'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Напористый", "Импульсивный" } },
                new Question { text = "Слово ''Приятный'' на английском ''Agreeable'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Agreeable", "Caring" }  },
                new Question { text = "Слово ''Arrogant'' означает ''Высокомерный'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Честный", "Импульсивный" }  },
                new Question { text = "Слово ''Humble'' означает ''Распущенный'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Гибкий", "Честный" }  },
                new Question { text = "Слово ''Гибкий'' на английском ''Humiliating'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Aspiration", "Arrogant" }  },
                new Question { text = "Слово ''Honest'' означает ''Нечестный'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Гибкий", "Импульсивный" }  },
                new Question { text = "Слово ''Organized'' означает ''Организованный'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Уважительный", "Неглубокий" }  },
                new Question { text = "Слово ''Прямолинейный'' на английском ''Straightforward'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Straightforward", "Polite" }  },
                new Question { text = "Слово ''Унижающий'' на английском ''Humiliating'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Submissive", "Talkative" }  },
                new Question { text = "Слово ''Polite'' означает ''Скромный'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Забавный", "Добросердечный" }  },
                new Question { text = "Слово ''Humble'' означает ''Вежливый'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Гордый", "Скромный" } },
                new Question { text = "Слово ''Законопослушный'' на английском ''Law-abiding'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Obsessive", "Confident" }  },
                new Question { text = "Слово ''Funky'' означает ''Клевый'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Болтливый", "Унижающий" }  },
                new Question { text = "Слово ''Indolent'' означает ''Очень ленивый'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Пассивный", "Терпимый" } },
                new Question { text = "Слово ''Грубый'' на английском ''Rude'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Strict", "Thankful" }  },
                new Question { text = "Слово ''Biased'' означает ''Непредвзятый'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Предвзятый", "Скучный" }  },
                new Question { text = "Словосочетание ''Kind-hearted'' означает ''Добросердечный'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Непредвзятый", "Предвзятый" }  },
                new Question { text = "Слово ''Уверенный'' на английском ''Confident'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Rude", "Confident" }  },
                new Question { text = "Слово ''Рациональный'' на английском ''Reasonable'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Stubborn", "Proud" }  },
                new Question { text = "Слово ''Болтливый'' на английском ''Talkative'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Outgoing", "Biased" }  },
                new Question { text = "Слово ''Общительный'' на английском ''Anxious'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Controlled", "Outgoing" }  },
                new Question { text = "Слово ''Тревожный'' на английском ''Outgoing'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Humble", "Generalization" }  },
                new Question { text = "Слово ''Покорный'' на английском ''Submissive'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Talkative", "Shallow" }  },
                new Question { text = "Слово ''Навязчивый'' на английском ''Obsessive'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Modest", "Materialistic" } },
                new Question { text = "Слово ''Практичный'' на английском ''Materialistic'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Agreeable", "Materialistic" }  },

                new Question { text = "Слово ''Annual'' означает ''Ежегодный'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Современный", "Совместный" }  },
                new Question { text = "Словосочетание ''Comfort zone'' означает ''Зона комфорта'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Зона комфорта", "Современник" } },
                new Question { text = "Слово ''Independent'' означает ''Зависимый'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Современный", "Ежегодный" }  },
                new Question { text = "Слово ''Community'' означает ''Общество'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Ежегодный", "Сообщество" }  },
                new Question { text = "Слово ''Contemporary'' означает ''Современный'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Годовой", "Месячный" }  },
                new Question { text = "Слово ''Cooperation'' на английском ''Сотрудничество'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Совместный", "Современник" }  },
                new Question { text = "Словосочетание ''Culture shock'' означает ''Культурный шок'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Сотрудничество", "Культурный шок" }  },
                
                new Question { text = "Фраза ''To swear by something'' означает ''Свято верить'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Выходить за рамки", "Переживать трудные времена" }  },
                new Question { text = "Фраза ''Burst out of someone’s comfort zone'' означает ''Выходить за рамки'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Выходить за рамки", "Переживать трудные времена" } },
                new Question { text = "Фраза ''Выходить за рамки'' на английском ''Immerse yourself in something'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Go through a rough patch", "Go beyond something" }  },
                new Question { text = "Фраза ''Immerse yourself in something'' означает ''Погрузиться во что-либо'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Выходить за рамки", "Погрузиться во что-либо" }  },
                new Question { text = "Слово ''Travel'' означает ''Путешествие'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Путь", "Экскурсия" }  },
                new Question { text = "Слово ''Маршрут'' на английском ''Go beyond something'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Benefit", "Travel" }  },
                new Question { text = "Словосочетание ''Stamping grounds'' означает ''Излюбленное место'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Крайняя мера", "Излюбленное место" }  },
                new Question { text = "Слово ''Perk'' означает ''Преимущество'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Путь", "Поездка" }  },
                new Question { text = "Слово ''Рейс'' на английском ''Cruise'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Cruise", "Voyage" }  },
                new Question { text = "Слово ''Круиз'' на английском ''Flight'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Flight", "Cruise" }  },
             
            };


            


            Question[] questionsArraytourism = {

                
                new Question { text = "Слово ''Nature'' означает ''Природа'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Человечество", "Загрязнение" }  },
                new Question { text = "Слово ''Humanity'' означает ''Человечество'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "природа", "Загрязнение" } },
                new Question { text = "Слово ''Загрязнение'' на английском ''Contamination'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Contamination", "Pollution" }  },
                new Question { text = "Слово ''Разрушать'' на английском ''Destroy'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Pollute", "Protect" }  },
                new Question { text = "Слово ''Emission'' означает ''Выброс'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Выброс", "Яд" }  },
                new Question { text = "Слово ''Отходы'' на английском ''Wastes'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Dust", "Wastes" }  },
                new Question { text = "Слово ''Защищать'' означает ''To protect'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "To сontaminate", "To destroy" }  },
                new Question { text = "Слово ''Landfill'' означает ''Свалка'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Ядро", "Свалка" }  },
                new Question { text = "Словосочетание ''Парниковый эффект'' на английском ''Acid rains'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Ozone holes", "Greenhouse effect" }  },
                new Question { text = "Словосочетание ''Кислотные дожди'' на английском ''Greenhouse effect'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Ozone holes", "Greenhouse effect" }  },
                new Question { text = "Слово ''Household'' означает ''Возобновляемый'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Бытовой", "Вымерший" }  },
                new Question { text = "Слово ''Renewable'' означает ''Бытовой'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Вымерший", "Нетрадиционный" } },
                new Question { text = "Слово ''Таять'' на английском ''Melt'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Species", "Nuclear" }  },
                new Question { text = "Словосочетание ''Использовать снова'' на английском ''Reuse'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Species", "Nuclear" }  },
                new Question { text = "Слово ''Recycle'' означает ''Возвращать в оборот'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Возвращать в оборот", "Использовать снова" } },
                new Question { text = "Слово ''Ядерный'' на английском ''Nuclear'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Valuable", "Melt" }  },
                new Question { text = "Слово ''Valuable'' означает ''Бесконечный'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Бытовой", "Ценный" }  },
                new Question { text = "Слово ''Endless'' означает ''Ценный'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Возобновляемый", "Невозобновляемый" }  },
                new Question { text = "Слово ''Бытовой'' на английском ''Household'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Nuclear", "Mankind" }  },
                new Question { text = "Словосочетание ''Global warming'' означает ''Глобальное потепление'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Озоновые дыры", "Глобальное потепление" }  },
                new Question { text = "Слово ''List'' означает ''Список'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Почва", "Вид" }  },

                new Question { text = "Слово ''Conquer'' означает ''Завоевать'':", answer = "True", textAnswer="",answerArray=new string[4] { "True", "False", "Граничить", "Завоевать" }  },
                new Question { text = "Словосочетание ''The lungs of Europe'' означает ''Легкие Европы'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Тело Европы", "Легкие Европы" } },
                new Question { text = "Слово ''Распространить'' на английском ''Spread'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Mild", "Changeable" }  },
                new Question { text = "Слово ''Зубр'' означает ''Bison'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Stork", "Bison" }  },
                new Question { text = "Слово ''Mountainous'' означает ''Горный'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Горы", "Горный" }  },
                new Question { text = "Слово ''Поверхность'' на английском ''The surface'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "The currency", "The anthem" }  },
                new Question { text = "Словосочетание ''A vast plain'' означает ''Широкая долина'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Кривая долина", "Волнистая долина" }  },
                new Question { text = "Слово ''Stork'' означает ''Важный'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Василек", "Луг" }  },
                new Question { text = "Слово ''Василек'' на английском ''Cornflower'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Mountain", "Stork" }  },
                new Question { text = "Словосочетание ''Наиболее густо заселенный'' на английском ''Important'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "The most densely populated", "The lungs of Europe" }  },
                new Question { text = "Слово ''Important'' означает ''Аист'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Называющийся", "Важный" }  },
                new Question { text = "Фраза ''To be separated from'' означает ''Отделяться'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Влиять", "Управлять" } },
                new Question { text = "Словосочетание ''Состоять из'' на английском ''To consist of'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "To be situated", "To consist of" }  },
                new Question { text = "Словосочетание ''To border on'' означает ''Называться'':", answer = "False", textAnswer="",answerArray=new string[4] { "True", "False", "Отделяться", "Завоевать" }  },
                new Question { text = "Словосочетание ''To be called'' означает ''Граничить'':", answer = "False", textAnswer="", answerArray=new string[4] { "True", "False", "Называться", "Завоевать" } },
                new Question { text = "Словосочетание ''Влиять на климат'' на английском ''To influence the climate'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "To consist of", "To be separated from" }  },
                new Question { text = "Словосочетание ''The surface'' означает ''Поверхность'':", answer = "True", textAnswer="", answerArray=new string[4] { "True", "False", "Гимн", "Граница" }  },
               
            };


           



          


            Question[] questionsArraywohn = {

                new Question { text = "Слово ''das Haus'' означает ''Дом'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Особняк", "Многоквартирный дом" }  },
                new Question { text = "Слово ''das Reihenhaus'' означает ''Таунхаус'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Многоквартирный дом", "Дом" } },
                new Question { text = "Слово ''Особняк'' на немецком ''das Einfamilienhaus'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Einfamilienhaus", "das Mehrfamilienhaus" }  },
                new Question { text = "Слово ''das Bauernhaus'' означает ''Собственный дом'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Дом", "Особняк" }  },
                new Question { text = "Слово ''ein eigenes Haus'' означает ''Крестьянский дом'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Дом", "Многоквартирный дом" }  },
                new Question { text = "Слово ''Лестница'' на немецком ''die Treppe'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Fensterladen", "die Treppe" }  },
                new Question { text = "Слово ''der Eingang'' означает ''Вход'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Вход", "Внутренний двор" }  },
                new Question { text = "Слово ''idas Treppenhaus'' означает ''Лестничная клетка'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Лестничная клетка", "Жилая площадь" }  },
                new Question { text = "Слово ''Арендодатель'' на немецком ''die Gemütlichkeit'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "mieten", "der Vermieter" }  },
                new Question { text = "Слово ''Комфорт'' на немецком ''der Vermieter'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "möblieren", "der Vorhang" }  },
                new Question { text = "Слово ''Рисовать'' означает ''streichen'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "streichen", "gemütlich" }  },
                new Question { text = "Слово ''einziehen'' означает ''Переезжать'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Выезжать", "Переезд" } },
                new Question { text = "Слово ''Жилая площадь'' на немецком ''die Wohnfläche'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "idas Treppenhaus", "die Wohnfläche" }  },
                new Question { text = "Слово ''die Ausstattung'' означает ''Плакат'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Комфорт", "Плакат" }  },
                new Question { text = "Слово ''das Poster'' означает ''Оборудование'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Плакат", "Рисовать" } },
                new Question { text = "Слово ''Обои'' на немецком ''der Vorhang'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Poster", "der Vorhang" }  },
                new Question { text = "Слово ''Занавески'' на немецком ''die Tapete'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Poster", "der Vorhang" }  },
                new Question { text = "Слово ''die Heizung'' означает ''Утепление'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Оборудовать", "Переезжать" }  },
                new Question { text = "Слово ''Аренда'' на немецком ''mieten'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "zur Miete wohnen", "der Mieter" }  },
                new Question { text = "Слово ''die Gemütlichkeit'' означает ''Комфорт'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Комфорт", "Расходы" }  },
                new Question { text = "Слово ''die Wohnatmosphäre'' означает ''Атмосфера в квартире'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Квартира", "Атмосфера в квартире" }  },
                new Question { text = "Словосочетание ''Двойное окно'' на немецком ''das Doppelfenster'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Innenhof", "das Eigentum" }  },
                new Question { text = "Фраза ''Арендовать комнату'' на немецком ''zur Untermiete wohnen'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Miete", "der Vermieter" }  },

                new Question { text = "Слово ''außerschulisch'' означает ''Внешкольный'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Школа", "Начальная школа" }  },
                new Question { text = "Слово ''die Berufsschule'' означает ''Профессиональная школа'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Профессиональная школа", "Ясли" } },
                new Question { text = "Слово ''Гимназия'' на немецком ''das Gymnasium'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Hauptschule", "das Gymnasium" }  },
                new Question { text = "Слово ''die Hauptschule'' означает ''Старшие классы'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Реальная школа", "Базовая школа" }  },
                new Question { text = "Слово ''die Oberstufe'' означает ''Базовая школа'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Младшие классы", "Ступень (обучения)" }  },
                new Question { text = "Словосочетание ''Младшие классы'' на немецком ''die Grundstufe'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Mittelstufe", "die Schulstufe" }  },
                new Question { text = "Слово ''der Schulbeginn'' означает ''Начало учебного года'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Начало учебного года", "Учебный месяц" }  },
                new Question { text = "Слово ''Четверть'' означает ''das Wahlfach'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Schulfach", "der Schulbeginn" }  },
                new Question { text = "Словосочетание ''Обязательный предмет на выбор'' на немецком ''das Viertel'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Wahlfach", "die Klassenarbeit" }  },
                new Question { text = "Словосочетание ''Учебный предмет'' на немецком ''das Schulfach'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Viertel", "das Schulfach" }  },
                new Question { text = "Слово ''die Klassenarbeit'' означает ''Экзамен'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Экзамен", "Контрольная работа" }  },
                new Question { text = "Слово ''die Prüfung'' означает ''Контрольная работа'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Экзамен", "Контрольная работа" } },
                new Question { text = "Словосочетание ''Выпускной экзамен'' на немецком ''die Abschlussprüfung'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "eine Prüfung ablegen", "die Prüfung" }  },
                new Question { text = "Словосочетание ''Приёмный экзамен'' на немецком ''die Aufnahmeprüfung'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "die Abschlussprüfung", "die Aufnahmeprüfung" }  },
                new Question { text = "Слово ''das Abschlusszeugnis'' означает ''Аттестат об окончании средней школы'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Свидетельство", "Справка" } },
                new Question { text = "Слово ''Решать'' на немецком ''lösen'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "eine Prüfung ablegen", "seinen Abschluss machen" }  },
                new Question { text = "Слово ''das Halbjahr'' означает ''Успех'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Ступень (обучения)", "Внешкольная работа" }  },
                new Question { text = "Слово ''die Leistung'' означает ''Полугодие'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Решать", "Успех" }  },
                new Question { text = "Словосочетание ''Окончание учебного заведения'' на немецком ''der Abschluss'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Schulbeginn", "die Berufsschule" }  },
                new Question { text = "Слово ''eine Prüfung ablegen'' означает ''Сдавать экзамен'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Приемный экзамен", "Аттестат" }  },
                new Question { text = "Слово ''die Verantwortung'' означает ''Ответственность'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Ответственность", "Аттестат" }  },
                
                new Question { text = "Слово ''das Medium'' означает ''СМИ'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Факт", "Сообщение" }  },
                new Question { text = "Слово ''die Tatsache'' означает ''Факт'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "ТВ", "СМИ" } },
                new Question { text = "Слово ''Сообщение'' на немецком ''die Nachricht'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Leserbrief", "das Interview" }  },
                new Question { text = "Слово ''das Interview'' означает ''Объявление'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Статья", "Реклама" }  },
                new Question { text = "Слово ''die Anzeige'' означает ''Интервью'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Комментарий", "Сообщение" }  },
                new Question { text = "Слово ''Комментарий'' на немецком ''der Kommentar'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Interview", "der Leserbrief" }  },
                new Question { text = "Слово ''der Leserbrief'' означает ''Письмо читателя'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Комментарий", "Письмо читателя" }  },
                new Question { text = "Слово ''kritisieren'' означает ''Критиковать'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Критиковать", "Развлекать" }  },
                new Question { text = "Слово ''Статья'' на немецком ''der Artikel'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Tatsache", "der Kommentar" }  },
                new Question { text = "Словосочетание ''Титульная страница'' на немецком ''die Titelseite'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Schlagzeile", "die Titelseite" }  },
                new Question { text = "Слово ''das Ereignis'' означает ''Сообщение'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Сообщение", "Трансляция" }  },
                new Question { text = "Слово ''die Nachricht'' означает ''Событие'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Событие", "Статья" } },
                new Question { text = "Словосочетание ''Крупный заголовок'' на немецком ''die Schlagzeile'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Zeile", "die Titelseite" }  },
                new Question { text = "Слово ''abonnieren'' означает ''Подписываться'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Подписываться", "Выпускать" }  },
           
            };

           





            Question[] questionsArraykunst = {

                new Question { text = "Слово ''die Kunst'' означает ''Искусство'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Скульптура", "Натюрморт" }  },
                new Question { text = "Слово ''die Malerei'' означает ''Живопись'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Скульптура", "Натюрморт" } },
                new Question { text = "Слово ''Автопортрет'' на немецком ''das Selbstbildnis'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Zeichnung", "das Bildnis" }  },
                new Question { text = "Слово ''der Bildhauer'' означает ''Чертеж'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Архитектура", "Натюрморт" }  },
                new Question { text = "Слово ''die Zeichnung'' означает ''Скульптор'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Картина", "Чертеж" }  },
                new Question { text = "Слово ''Художник'' на немецком ''der Kunstler'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Bildhauer", "die Malerei" }  },
                new Question { text = "Слово ''der Entwurf'' означает ''Выставка'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Чертеж", "Эскиз" }  },
                new Question { text = "Слово ''die Ausstellung'' означает ''Эскиз'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Выставка", "Краска" }  },
                new Question { text = "Слово ''die Gemäldegalerie'' означает ''Картинная галерея'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Выставка", "Влияние" }  },
                new Question { text = "Слово ''Коллекция картин'' на немецком ''die Gemaldesammlung'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Gemaldesammlung", "die Ausstellung" }  },
                new Question { text = "Слово ''glatt'' означает ''Твердый'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Ровный", "Твердый" }  },
                new Question { text = "Слово ''hart'' означает ''Ровный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Ровный", "Твердый" } },
                new Question { text = "Слово ''weich'' означает ''Материал'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Ровный", "Твердый" }  },
                new Question { text = "Слово ''das Material'' означает ''Мягкий'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Ровный", "Твердый" }  },
                new Question { text = "Слово ''die Leinwand'' означает ''Прямой'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Материал", "Холст" } },
                new Question { text = "Слово ''gerade'' означает ''Холст'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Твердый", "Кривой" }  },
                new Question { text = "Слово ''schief'' означает ''Наклонный'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Твердый", "Кривой" }  },
                new Question { text = "Слово ''die Farbe'' означает ''Краска'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Холст", "Цвет" }  },
                new Question { text = "Слово ''Холст'' на немецком ''die Leinwand'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Leinwand", "die Bildersammlung" }  },
                new Question { text = "Слово ''Поверхность'' на немецком ''die Flache'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Leinwand", "die Bildersammlung" }  },
                new Question { text = "Слово ''der Eindruck'' означает ''Впечатление'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Влияние", "Изображение" }  },
                new Question { text = "Слово ''Прозрачный'' на немецком ''durchsichtig'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "durchsichtig", "das Material" }  },
                new Question { text = "Слово ''Художественный'' на немецком ''kunstlerisch'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "darstellen", "kunstlerisch" }  },
               
                new Question { text = "Слово ''die Jugend'' означает ''Молодёжь'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Старый", "Молодой" }  },
                new Question { text = "Слово ''unabhängig'' означает ''Независимый'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Уверенный", "Самоуверенный" } },
                new Question { text = "Слово ''Любопытный'' на немецком ''neugierig'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "launisch", "selbstbewusst" }  },
                new Question { text = "Слово ''launisch'' означает ''Самоуверенный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "launisch", "selbstbewusst" }  },
                new Question { text = "Слово ''selbstbewusst'' означает ''Капризный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Гордый", "Неуверенный" }  },
                new Question { text = "Слово ''Гордый'' на немецком ''stolz'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "sorglos", "stolz" }  },
                new Question { text = "Слово ''sorglos'' означает ''Любопытный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Беззаботный", "Гордый" }  },
                new Question { text = "Слово ''neugierig'' означает ''Беззаботный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Уверенный", "избалованный" }  },
                new Question { text = "Слово ''Избалованный'' на немецком ''verwohnt'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "unsicher", "verwohnt" }  },
                new Question { text = "Слово ''Молодой'' на немецком ''jung'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "unsicher", "verwohnt" }  },
                new Question { text = "Слово ''die Erwachsene'' означает ''Общественный'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Добровольный", "Бедный" }  },
                new Question { text = "Слово ''gesellschaftlich'' означает ''Взрослый'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Добровольный", "Бедный" } },
                new Question { text = "Слово ''Акция'' на немецком ''die Aktion'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Rote Kreuz", "arm" }  },
                new Question { text = "Слово ''arm'' означает ''Бедный'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Честь", "Бедный" }  },
                new Question { text = "Слово ''die Ehre'' означает ''Честь'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Бедный", "Честь" } },
                new Question { text = "Слово ''Член (органиации)'' на немецком ''das Mitglied'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Verband", "das Rote Kreuz" }  },
                new Question { text = "Слово ''der Verband'' означает ''Общество'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Осуществление", "Общество" }  },
                new Question { text = "Словосочетание ''das Rote Kreuz'' означает ''Красный крест'':", answer = "", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Осуществление", "Общество" }  },
                new Question { text = "Слово ''Требование'' на немецком ''die Forderung'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "erziehen", "die Forderung" }  },
                new Question { text = "Слово ''Воспитывать'' на немецком ''bevorzugen'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "verbinden", "erziehen" }  },
                new Question { text = "Слово ''Предпочитать'' на немецком ''erziehen'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "verbinden", "erziehen" }  },

                new Question { text = "Слово ''die Zukunft'' означает ''Будущее'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Настоящее", "Столетие" }  },
                new Question { text = "Слово ''die Vergangenheit'' означает ''Прошлое'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Настоящее", "Столетие" } },
                new Question { text = "Слово ''die Gegenwart'' означает ''Настоящее'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Настоящее", "Столетие" }  },
                new Question { text = "Слово ''das Jahrhundert'' означает ''Тысячелетие'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Десятилетие", "Будущее" }  },
                new Question { text = "Слово ''das Jahrtausend'' означает ''Столетие'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Десятилетие", "Прошлое" }  },
                new Question { text = "Слово ''das Jahrzehnt'' означает ''Десятилетие'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Десятилетие", "Прошлое" }  },
                new Question { text = "Слово ''erfinden'' означает ''Изобретать'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Изобретатель", "Открывать" }  },
                new Question { text = "Слово ''die Erfindung'' означает ''Изобретение'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Изобретать", "Открывать" }  },
                new Question { text = "Слово ''der Erfinder'' означает ''Изобретатель'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Изобретать", "Открывать" }  },
                new Question { text = "Слово ''Умственный труд'' на немецком ''korperliche Arbeit'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "geistige Arbeit", "die Arbeit" }  },
                new Question { text = "Слово ''Физический труд'' на немецком ''geistige Arbeit'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "die Arbeit", "geistige Arbeit" }  },
               
            };
            

            Question[] questionsArrayberuf = {

                new Question { text = "Слово ''ausüben'' означает ''Исполнять'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Возделывать", "Обрабатывать" }  },
                new Question { text = "Словосочетание ''einen Beruf ausüben'' означает ''Заниматься чем-либо'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "Обрабатывать", "Заниматься чем-либо", "Обслуживать" } },
                new Question { text = "Слово ''Возделывать'' на немецком ''bebauen'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "bedienen", "bebauen" }  },
                new Question { text = "Слово ''bedienen'' означает ''Ремонтировать'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Возделывать", "Обрабатывать" }  },
                new Question { text = "Слово ''reparieren'' означает ''Обслуживать'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Ремонтировать", "Обслуживать" }  },
                new Question { text = "Слово ''Развлекать'' на немецком ''unterhalten'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "reparieren", "unterhalten" }  },
                new Question { text = "Слово ''untersuchen'' означает ''Исследовать'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Ремонтировать", "Обслуживать" }  },
                new Question { text = "Слово ''die Begabung'' означает ''Талант'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Везение", "Удача" }  },
                new Question { text = "Слово ''Подвижный'' на немецком ''beweglich'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "reparieren", "bedienen" }  },
                new Question { text = "Слово ''die Fähigkeit'' означает ''Ловкость'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Ловкость", "Добросовестность" }  },
                new Question { text = "Слово ''die Geschicklichkeit'' означает ''Способность'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Ловкость", "Добросовестность" }  },
                new Question { text = "Слово ''die Gewissenhaftigkeit'' означает ''Добросовестность'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Способность", "Талант" } },
                new Question { text = "Слово ''Работоспособность'' на немецком ''die Zuverlässigkeit'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "Слово ''Надежность'' на немецком ''die Leistungsfähigkeit'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "Слово ''geschickt'' означает ''Искусный'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Искусный", "Ловкий" } },
                new Question { text = "Слово ''Гибкость'' на немецком ''die Flexibilität'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Leistungsfähigkeit", "die Kontaktfähigkeit" }  },
                new Question { text = "Фраза ''geschickte Hände'' означает ''Умелые руки'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Чистые руки", "Кривые руки" }  },
                new Question { text = "Слово ''die Kraft'' означает ''Сила'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Мудрость", "Сила" }  },
                new Question { text = "Слово ''Творчество'' на немецком ''die Kreativität'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Kreativität", "ausbilden" }  },
                new Question { text = "Слово ''der Bereich'' означает ''Учеба'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Искусство", "Красота" }  },
                new Question { text = "Слово ''das Studium'' означает ''Сфера'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "1", "2" }  },
                new Question { text = "Слово ''Выпускной экзамен'' на немецком ''die Abschlussprüfung'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Abschlussprüfung", "die Flexibilität" }  },

                new Question { text = "Слово ''aufwachsen'' означает ''Вырастать'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Уход", "Забота" }  },
                new Question { text = "Слово ''betreuen'' означает ''Заботиться'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Уход", "Забота" } },
                new Question { text = "Слово ''die Betreuung'' означает ''Уход'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Уход", "Вырастать" }  },
                new Question { text = "Слово ''einsam'' означает ''Одинокий'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Поколение", "Ссорится" }  },
                new Question { text = "Слово ''die Erziehung'' означает ''Воспитание'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Воспитание", "Поведение" }  },
                new Question { text = "Слово ''Ссориться'' на немецком ''sich Vertragen'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Generation", "einsam" }  },
                new Question { text = "Слово ''minderjährig'' означает ''Помириться'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Совершеннолетний", "Несовершеннолетний" }  },
                new Question { text = "Слово ''sich Versöhnen'' означает ''Несовершеннолетний'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Ругаться", "Дружить" }  },
                new Question { text = "Слово ''Ладить'' на немецком ''sich Streiten'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Ehe schließen", "das Ehepaar" }  },
                new Question { text = "Слово ''Брак'' на немецком ''die Ehe'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Ehe", "volljährig" }  },
                new Question { text = "Фраза ''Вступать в брак'' на немецком ''die Ehe schließen'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "die Ehe", "volljährig" }  },
                new Question { text = "Слово ''das Ehepaar'' означает ''Супруги'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Родители", "Семья" } },
                new Question { text = "Слово ''Разведенный'' на немецком ''geschieden'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "sich Versöhnen", "die Ehe schließen" }  },
                new Question { text = "Слово ''ledig'' означает ''Холостой'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Женатый", "Супружество" }  },
                new Question { text = "Слово ''Развод'' на немецком ''die Adoption'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "ledig", "die Scheidung" } },
                new Question { text = "Слово ''Усыновление'' на немецком ''die Scheidung'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Adoption", "die Adoptivneltern" }  },
                new Question { text = "Словосочетание ''Приемный ребенок'' на немецком ''der Pflegevater'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Adoptivneltern", "die Adoption" }  },
                new Question { text = "Словосочетание ''Приемный отец'' на немецком ''das Adoptivkind'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Словосочетание ''Приемная мать'' на немецком ''die Braut'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Слово ''Невеста'' на немецком ''die Pflegemutter'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "1", "der Bräutigam" }  },
                new Question { text = "Слово ''Жених'' на немецком ''der Trauring'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Pflegevater", "der Bräutigam" }  },
                new Question { text = "Словосочетание ''Обручальное кольцо'' на немецком ''der Bräutigam'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Pflegevater", "das Adoptivkind" }  },


                new Question { text = "Слово ''der Ausflug'' означает ''экскурсия'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "экскурсия", "справочное бюро" }  },
                new Question { text = "Слово ''die Reise'' означает ''путешествие'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "экскурсия", "справочное бюро" } },
                new Question { text = "Слово ''der Reiseführer'' означает ''путеводитель'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "путеводитель", "путешествие" }  },
                new Question { text = "Слово ''abreisen'' означает ''уезжать'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "отъезд", "уезжать" }  },
                new Question { text = "Слово ''die Ankunft'' означает ''справка'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "отъезд", "уезжать" }  },
                new Question { text = "Слово ''die Auskunft'' означает ''прибытие'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "отъезд", "уезжать" }  },
                new Question { text = "Слово ''das Auskunftsbüro'' означает ''билетная касса'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "бюро находок", "билетная касса" }  },
                new Question { text = "Слово ''der Schalter'' означает ''справочное бюро'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "вокзал", "билетная касса" }  },
                new Question { text = "Слово ''das Fundbüro'' означает ''бюро находок'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "путеводитель", "справочное бюро" }  },
                new Question { text = "Слово ''das Gepack'' означает ''багаж'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "путь", "рельсовый путь" }  },
                new Question { text = "Слово ''das Gepäck aufgeben'' означает ''сдать багаж'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "билетная касса", "туристская база" }  },
                new Question { text = "Слово ''поезд'' на немецком ''der Zug'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Bahn", "einsteigen" } },
                new Question { text = "Слово ''aussteigen'' означает ''выходить (из транспорта)'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "выходить (из дома)", "входить (в дом)" }  },
                new Question { text = "Слово ''besorgen'' означает ''покупать'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "бронировать", "покупать" }  },
                new Question { text = "Слово ''bestellen'' означает ''заказывать'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "бронировать", "покупать" } },
                new Question { text = "Слово ''buchen'' означает ''бронировать'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "бронировать", "покупать" }  },
                new Question { text = "Слово ''das Erlebnis'' означает ''событие'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "путешествовать", "рельсовый путь" }  },
                new Question { text = "Словосочетание ''рельсовый путь'' на немецком ''die Jugendherberge'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Schalter", "die Jugendherberge" }  },
                new Question { text = "Словосочетание ''туристическая база'' на немецком ''das Gleis'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Gepack", "das Auskunftsbüro" }  },
                new Question { text = "Словосочетание ''железная дорога'' на немецком ''üderbernachten'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Gleis", "reisen" }  },
                new Question { text = "Слово ''ночевать'' на немецком ''die Eisenbahn'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "bestellen", "besorgen" }  },


            };


         


            Question[] questionsArrayunwelt = {

                new Question { text = "Слово ''der Abfall'' означает ''oтброcы'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "засарять", "мусор" }  },
                new Question { text = "Слово ''das Abgas'' означает ''выхлопной газ'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "грязь", "мусор" } },
                new Question { text = "Слово ''шум'' на немецком ''der Müll'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Müll", "der Lärm" }  },
                new Question { text = "Слово ''мусор'' на немецком ''der Lärm'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Müll", "der Lärm" }  },
                new Question { text = "Слово ''der Schmutz'' означает ''грязь'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "выхлопной газ", "мусор" }  },
                new Question { text = "Слово ''удобрение'' на немецком ''das Düngemittel'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Lärm", "der Schmutz" }  },
                new Question { text = "Слово ''der Staub'' означает ''яд'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "пыль", "музор" }  },
                new Question { text = "Слово ''das Gift'' означает ''пыль'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "опасность", "вред" }  },
                new Question { text = "Фраза ''животные, которым грозит исчезновение'' на немецком ''bedrohte Tiere'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Gift", "die Gefahr" }  },
                new Question { text = "Слово ''вредить'' на немецком ''schaden'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Düngemittel", "bedrohte Tiere" }  },
                new Question { text = "Слово ''verbrennen'' означает ''отравлять'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "вредить", "сжигать" }  },
                new Question { text = "Слово ''vergiften'' означает ''сжигать'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "вредить", "сжигать" } },
                new Question { text = "Слово ''загрязнять'' на немецком ''verschmutzen'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Düngemittel", "verschmutzen" }  },
                new Question { text = "Слово ''verseuchte'' означает ''разрушать'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "разрушать", "удалять" }  },
                new Question { text = "Слово ''zerstören'' означает ''заражать'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "заражать", "удалять" } },
                new Question { text = "Слово ''удалять'' на немецком ''entsorgen'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "bedrohte Tiere", "entsorgen" }  },
                new Question { text = "Слово ''herstellen'' означает ''производство'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "производить", "утилизировать" }  },
                new Question { text = "Слово ''die Herstellung'' означает ''производить'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "утилизировать", "убирать" }  },
                new Question { text = "Слово ''заповедник'' на немецком ''das Naturschutzgebiet'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Herstellung", "das Naturschutzgebiet" }  },
                new Question { text = "Слово ''sparen'' означает ''окружающая cреда'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "спасать", "чистить" }  },
                new Question { text = "Слово ''die Umwelt'' означает ''экономить'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "производство", "заповедник" }  },
                new Question { text = "Словосочетание ''защита окружающей среды'' на немецком ''der Umweltschutz'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "verbrauchen", "der Umweltschutz" }  },

                new Question { text = "Слово ''der/die Abgeordnete'' означает ''суд'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "президент", "депутат" }  },
                new Question { text = "Слово ''das Gericht'' означает ''депутат'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "закон", "правительство" } },
                new Question { text = "Слово ''закон'' на немецком ''das Gesetz'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Gesetz", "ein Gesetz beachten" }  },
                new Question { text = "Слово ''die Politik'' означает ''совет министров'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "депутат", "закон" }  },
                new Question { text = "Слово ''der Ministerrat'' означает ''политика'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "совет министров", "парламент" }  },
                new Question { text = "Слово ''правительство'' на немецком ''die Regierung'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "gleich", "der Ministerrat" }  },
                new Question { text = "Слово ''der Staat'' означает ''иностранец'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "суд", "государство" }  },
                new Question { text = "Слово ''der Ausländer'' означает ''государство'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "иностранец", "президент" }  },
                new Question { text = "Слово ''герб'' на немецком ''das Wappen'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Ausländer", "die Lebensweise" }  },
                new Question { text = "Слово ''меньшинство'' означает ''die Minderheit'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Minderheit", "das Recht auf etwas" }  },
                new Question { text = "Слово ''die Verwaltung'' означает ''администрация'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "правительство", "совет министр" }  },
                new Question { text = "Слово ''der/die Vorsitzende'' означает ''председатель'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "министр", "председатель" } },
                new Question { text = "Слово ''памятник'' на немецком ''das Denkmal'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Lebensweise", "das Denkmal" }  },
                new Question { text = "Слово ''корень'' означает ''die Wurzel'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "die Lebensweise", "das Denkmal" }  },
                new Question { text = "Словосочетание ''национальный костюм'' на немецком ''das Volkstracht'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "das Volkstracht", "das Denkmal" } },
                new Question { text = "Словосочетание ''литературный язык'' на немецком ''das Schriftsprache'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Ausländer", "die Lebensweise" }  },
                new Question { text = "Слово ''die Verfassung'' означает ''конституция'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "суд", "конституция" }  },
                new Question { text = "Слово ''равноправие'' на немецком ''die Gleichberechtigung'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "der Ministerrat", "die Wurzel" }  },
                new Question { text = "Слово ''воздвигать'' на немецком ''errichten'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "gleich", "errichten" }  },
                new Question { text = "Слово ''das Vielfalt'' означает ''разнообразие'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "корень", "меньшинство" }  },
                new Question { text = "Слово ''die Repräsentantenkammer der Nationalversammlung'' означает ''палата представителей'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "совет министров", "палата представителей" }  },
                new Question { text = "Слово ''законный'' на немецком ''gesetzlich'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "gleich", "errichten" }  },

                
            };

            
            
            Question[] questionsArrayintz = {

                new Question { text = "Слово ''die Botschaft'' означает ''Посольство'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Президент", "Организация" }  },
                new Question { text = "Слово ''UNESCO'' означает ''ЮНЕСКО'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "ГГАЭК", "Европейский Союз" } },
                new Question { text = "Слово ''die UNO'' означает ''ООН'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "ООН", "Европейский Союз" }  },
                new Question { text = "Слово ''die Europäische Union'' означает ''Европейский Союз'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "ООН", "ЮНЕСКО" }  },
                new Question { text = "Слово ''gewährleisten'' означает ''Гарантировать'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Гарантировать", "Защищать" }  },
                new Question { text = "Слово ''Безопасность'' на немецком ''die Sicherheit'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Vereinigung", "der Verständigung" }  },
                new Question { text = "Слово ''respektieren'' означает ''Общность'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Обобщать", "Обобщение" }  },
                new Question { text = "Слово ''die Gemeinschaft'' означает ''Уважать'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Мероприятие", "Ответственность" }  },
                new Question { text = "Слово ''Мероприятие'' на немецком ''die Veranstaltung'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Vereinigung", "der Verständigung" }  },
                new Question { text = "Слово ''Ответственный'' на немецком ''verantwortungsvoll'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "verantwortungsvoll", "respektieren" }  },
                new Question { text = "Слово ''die Toleranz'' означает ''Терпимость'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Уважение", "Характер" }  },
                new Question { text = "Слово ''die Vereinigung'' означает ''Союз'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Наследие", "Ответственность" } },
                new Question { text = "Слово ''Мир'' на немецком ''der Frieden'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Vereinigung", "der Frieden" }  },
                new Question { text = "Слово ''das Erbe'' означает ''Объединять'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "Наследие", "Содружество" }  },
                new Question { text = "Слово ''vereinen'' означает ''Наследие'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Содружество", "Наследие" } },
                new Question { text = "Слово ''der Verständigung'' означает ''Взаимопонимание'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Содружество", "Наследие" }  },
                new Question { text = "Фраза ''die Bereitschaft zu etwas'' означает ''Готовность к (чему-л.)'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Быть ответственным", "Уважать" }  },
                new Question { text = "Фраза ''bereit sein zu etwas'' означает ''Быть готовым на (что-л.)'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Уважать", "Быть ответственным" }  },
                new Question { text = "Фраза ''eine Veranstaltung durchführen'' означает ''Проводить мероприятие'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "Относиться с уважением", "" }  },
                new Question { text = "Слово ''Общность'' на немецком ''die Gemeinschaft'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "die Gemeinschaft", "der Frieden" }  },

                new Question { text = "Слово ''anständig'' означает ''общительный'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "гостеприимный", "общительный" }  },
                new Question { text = "Слово ''gesellig'' означает ''приличный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "гостеприимный", "общительный" } },
                new Question { text = "Слово ''ehrgeizig'' означает ''честолюбивый'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "гостеприимный", "общительный" }  },
                new Question { text = "Слово ''gutmitig'' означает ''добродушный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "добросовестный", "последовательный" }  },
                new Question { text = "Слово ''konsequent'' означает ''бережливый'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "добродушный", "последовательный" }  },
                new Question { text = "Слово ''sparsam'' означает ''последовательный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "добродушный", "последовательный" }  },
                new Question { text = "Слово ''milde'' означает ''мягкие'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "строгие", "нежные" }  },
                new Question { text = "Слово ''scharfe'' означает ''острые'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "строгие", "нежные" }  },
                new Question { text = "Слово ''strenge'' означает ''строгие'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "строгие", "нежные"}  },
                new Question { text = "Слово ''надежный'' на немецком ''zuverlässig'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "zuverlässig", "beneiden" }  },
                new Question { text = "Слово ''rücksichtslos'' означает ''обходительный'':", answer = "falsch", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "скупой", "серьезный" }  },
                new Question { text = "Слово ''umganglich'' означает ''бесцеремонный'':", answer = "falsch", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "знакомый", "надежный" } },
                new Question { text = "Слово ''бесцеремонный'' на немецком ''rücksichtslos'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "sparsam", "rücksichtslos" }  },
                new Question { text = "Слово ''der Respekt'' означает ''уважение'':", answer = "wahr", textAnswer="",answerArray=new string[4] { "wahr", "falsch", "зависть", "скупость" }  },
                new Question { text = "Слово ''vertraut'' означает ''знакомый'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "близкий", "родной" } },
                new Question { text = "Слово ''die Gesichtszüge (Pl.)'' означает ''черты лица'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "устанавливать личность", "уважать" }  },
                new Question { text = "Слово ''geizig'' означает ''скупой'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "скупой", "последовательный" }  },
                new Question { text = "Слово ''die Großzügigkeit'' означает ''щедрость'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "щедрость", "скупость" }  },
                new Question { text = "Слово ''серьёзный'' на немецком ''ernst'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "ernst", "die Nation" }  },
                new Question { text = "Фраза ''überzeugen jemanden (Akk.) von etwas (Dat.)'' означает ''убеждать кого-либо'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "уважать", "убеждать кого-либо" }  },
                new Question { text = "Слово ''добросовестный'' на немецком ''gewissenhaft'':", answer = "wahr", textAnswer="", answerArray=new string[4] { "wahr", "falsch", "beneiden", "rücksichtslos" }  },

            };
            




            var rand = new Random();
           
            
            Test.Add(new TF
            {
                Chapter = "Глава 1",
                Title = "Тест ''True or False'' №1",
                TestNumber = "1",
                Preload = "Тест ''True or False'' №1",
                Complited = item.Task1_comp,
                CorrectCount = Convert.ToInt32(item.Test1),
                Questions = questionsArrayhouse.OrderBy(x => rand.Next()).Take(15).ToList(),
            });
            Test.Add(new TF
            {
                Chapter = "Глава 1",
                Title = "Tест ''True or False'' №2",
                Complited = item.Task2_comp,
                Preload = "Тест ''True or False'' №2",
                TestNumber = "2",
                CorrectCount = Convert.ToInt32(item.Test2),
                Questions = questionsArrayyouth.OrderBy(x => rand.Next()).Take(15).ToList(),

                //Questions = {
                //    new Question { text = "Слово ''Hello'' означает '''':", answer = "Привет", textAnswer = "Привет", answerArray = new string[4] { "Пока", "Привет", "Прощай", "До свидания" } },
                //    new Question { text = "Слово ''Goodbye'' означает '''':", answer = "До свидания", textAnswer = "До свидания", answerArray = new string[4] { "Привет", "Пока", "До свидания", "Прощай" } },
                //    new Question { text = "Слово ''Сон'' на английском '''':", answer = "Dream", textAnswer = "Dream", answerArray = new string[4] { "Dream", "Night", "Day", "Child" } },
                //    new Question { text = "Слово ''Human'' означает '''':", answer = "Человек", textAnswer = "Человек", answerArray = new string[4] { "Человек", "Сон", "Ночь", "День" } },
                //    new Question { text = "Слово ''Child'' означает '''':", answer = "Ребенок", textAnswer = "Ребенок", answerArray = new string[4] { "Мужчина", "Девушка", "Мама", "Ребенок" } },
                //    new Question { text = "Слово ''День'' на английском '''':", answer = "Day", textAnswer = "Day", answerArray = new string[4] { "Night", "Day", "Monday", "Sunday" } },
                //    new Question { text = "Слово ''Computer'' означает '''':", answer = "Компьютер", textAnswer = "Компьютер", answerArray = new string[4] { "Телевизор", "Смартфон", "Компьютер", "Планшет" } },
                //    new Question { text = "Слово ''Word'' означает '''':", answer = "Слово", textAnswer = "Слово", answerArray = new string[4] { "Слово", "Текст", "Дом", "Арбуз" } },
                //    new Question { text = "Слово ''Ночь'' на английском '''':", answer = "Night", textAnswer = "Night", answerArray = new string[4] { "Day", "Night", "Country", "College" } },
                //    new Question { text = "Слово ''Тест'' на английском '''':", answer = "Test", textAnswer = "Test", answerArray = new string[4] { "Word", "House", "Day", "Test" } },
                //},




            });
            Test.Add(new TF
            {
                Chapter = "Глава 1",
                Title = "Tест ''True or False'' №3",
                Complited = item.Task2_comp,
                Preload = "Тест ''True or False'' №3",
                TestNumber = "2",
                CorrectCount = Convert.ToInt32(item.Test2),
                Questions = questionsArrayfamily.OrderBy(x => rand.Next()).Take(15).ToList(),

                //Questions = {
                //    new Question { text = "Слово ''Hello'' означает '''':", answer = "Привет", textAnswer = "Привет", answerArray = new string[4] { "Пока", "Привет", "Прощай", "До свидания" } },
                //    new Question { text = "Слово ''Goodbye'' означает '''':", answer = "До свидания", textAnswer = "До свидания", answerArray = new string[4] { "Привет", "Пока", "До свидания", "Прощай" } },
                //    new Question { text = "Слово ''Сон'' на английском '''':", answer = "Dream", textAnswer = "Dream", answerArray = new string[4] { "Dream", "Night", "Day", "Child" } },
                //    new Question { text = "Слово ''Human'' означает '''':", answer = "Человек", textAnswer = "Человек", answerArray = new string[4] { "Человек", "Сон", "Ночь", "День" } },
                //    new Question { text = "Слово ''Child'' означает '''':", answer = "Ребенок", textAnswer = "Ребенок", answerArray = new string[4] { "Мужчина", "Девушка", "Мама", "Ребенок" } },
                //    new Question { text = "Слово ''День'' на английском '''':", answer = "Day", textAnswer = "Day", answerArray = new string[4] { "Night", "Day", "Monday", "Sunday" } },
                //    new Question { text = "Слово ''Computer'' означает '''':", answer = "Компьютер", textAnswer = "Компьютер", answerArray = new string[4] { "Телевизор", "Смартфон", "Компьютер", "Планшет" } },
                //    new Question { text = "Слово ''Word'' означает '''':", answer = "Слово", textAnswer = "Слово", answerArray = new string[4] { "Слово", "Текст", "Дом", "Арбуз" } },
                //    new Question { text = "Слово ''Ночь'' на английском '''':", answer = "Night", textAnswer = "Night", answerArray = new string[4] { "Day", "Night", "Country", "College" } },
                //    new Question { text = "Слово ''Тест'' на английском '''':", answer = "Test", textAnswer = "Test", answerArray = new string[4] { "Word", "House", "Day", "Test" } },
                //},

            });
            Test.Add(new TF
            {
                Chapter = "Глава 1",
                Title = "Тест ''True or False'' №4",
                TestNumber = "3",
                Preload = "Тест ''True or False'' №4",
                Complited = item.Task3_comp,
                CorrectCount = Convert.ToInt32(item.Test3),
                Questions = questionsArraynaccar.OrderBy(x => rand.Next()).Take(15).ToList(),
            });
            Test.Add(new TF
            {
                Chapter = "Глава 1",
                Title = "Tест ''True or False'' №5",
                TestNumber = "4",
                Preload = "Тест ''True or False'' №5",
                Complited = item.Task4_comp,
                CorrectCount = Convert.ToInt32(item.Test4),
                Questions = questionsArraytourism.OrderBy(x => rand.Next()).Take(15).ToList(),
            });
            
            Test.Add(new TF
            {
                Chapter = "Глава 2",
                Title = "Tест ''Wahr oder falsch'' №1",
                TestNumber = "14",
                Preload = "Тест ''Wahr oder falsch'' №1",
                Complited = item.Task14_comp,
                CorrectCount = Convert.ToInt32(item.Test14),
                Questions = questionsArraywohn.OrderBy(x => rand.Next()).Take(15).ToList(),
            });


            Test.Add(new TF
            {
                Chapter = "Глава 2",
                Title = "Tест ''Wahr oder falsch'' №2",
                TestNumber = "15",
                Preload = "Тест ''Wahr oder falsch'' №2",
                Complited = item.Task15_comp,
                CorrectCount = Convert.ToInt32(item.Test15),
                Questions = questionsArraykunst.OrderBy(x => rand.Next()).Take(15).ToList(),
            });

            Test.Add(new TF
            {
                Chapter = "Глава 2",
                Title = "Tест ''Wahr oder falsch'' №3",
                TestNumber = "16",
                Preload = "Тест ''Wahr oder falsch'' №3",
                Complited = item.Task16_comp,
                CorrectCount = Convert.ToInt32(item.Test16),
                Questions = questionsArrayberuf.OrderBy(x => rand.Next()).Take(15).ToList(),
            });
            Test.Add(new TF
            {
                Chapter = "Глава 2",
                Title = "Tест ''Wahr oder falsch'' №4",
                TestNumber = "17",
                Preload = "Тест ''Wahr oder falsch'' №4",
                Complited = item.Task17_comp,
                CorrectCount = Convert.ToInt32(item.Test17),
                Questions = questionsArrayunwelt.OrderBy(x => rand.Next()).Take(15).ToList(),
            });
            Test.Add(new TF
            {
                Chapter = "Глава 2",
                Title = "Tест ''Wahr oder falsch'' №5",
                TestNumber = "18",
                Preload = "Тест ''Wahr oder falsch'' №5",
                Complited = item.Task18_comp,
                CorrectCount = Convert.ToInt32(item.Test18),
                Questions = questionsArrayintz.OrderBy(x => rand.Next()).Take(15).ToList(),
            });
            
          






































            // Test.Add(new Test
            //{
            //    Chapter = "Глава 2",
            //    Title = "Tест 3",
            //    Complited = item.Task3_comp,
            //    TestNumber = "3",
            //    Preload = "Тест на проверку знаний по главе2",
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