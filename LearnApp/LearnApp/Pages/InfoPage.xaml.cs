using Android;
using Android.Media;
using Android.Graphics;
using LearnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using Plugin.SimpleAudioPlayer;
using LearnApp.PageModels.Base;


using System.IO;
using System.Threading.Tasks;



using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;
using Java.Lang;
using Android.Opengl;
using Xamarin.CommunityToolkit.ObjectModel;
using Android.Telephony.Euicc;
using static Xamarin.Essentials.Permissions;
using Stream = Android.Media.Stream;

namespace LearnApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InfoPage : ContentPage
    {
        Lecture lecture;
        int numb;

        private ISimpleAudioPlayer player;

        string path = AppDomain.CurrentDomain.BaseDirectory;

 

        public InfoPage(Lecture lecture, int number)
        {
            InitializeComponent();
            numb = number;

            try
            {
                Dictionary<(int, string), (string, string, string)> lectureParams = new Dictionary<(int, string), (string, string, string)>()
            {

                 {(1, "Detached house \nотдельно стоящий дом"), ("Detached_house.jpg", "Detached house \nотдельно стоящий дом", "Houses/Detached.mp3")},
                 {(2, "Semi-detached (house) \nдом, имеющий общую стену с соседним домом"), ("Semi_detached_house.jpg", "Semi-detached (house) \nдом, имеющий общую стену с соседним домом", "Houses/Semi_detached.mp3")},
                 {(3, "Terraced house \nдом, имеющий общие стены с соседними домами"), ("Terraced_house.jpg", "Terraced house \nдом, имеющий общие стены с соседними домами", "Houses/Terraced_house.mp3")},
                 {(4, "Flat / Apartament \nквартира"), ("Flat_Apartment.jpg", "Flat / Apartament \nквартира", "Houses/Flat_Apartment.mp3")},
                 {(5, "Block of flats \nмногоэтажка"), ("Block_of_flats.jpg", "Block of flats \nмногоэтажка", "Houses/Block_of_flats.mp3")},
                 {(6, "Hostel \nобщежитие"), ("Hostel.jpg", "Hostel \nобщежитие", "Houses/Hostel.mp3")},
                 {(7, "Cottage \nнебольшой дом в сельской местности"), ("Cottage.jpg", "Cottage \nнебольшой дом в сельской местности", "Houses/Cottage.mp3")},
                 {(8, "Bungalow \nодноэтажный небольшой домик"), ("Bungalow.jpg", "Bungalow \nодноэтажный небольшой домик", "Houses/Bungalow.mp3")},
                 {(9, "Close to \nрядом с"), ("Close_to.jpg", "Close to \nрядом с", "Houses/Close_to.mp3")},
                 {(10, "Right in the center \nпрямо в центре"), ("Right_in_the_center.jpg", "Right in the center \nпрямо в центре", "Houses/Right_in_the_center.mp3")},
                 {(11, "On the outskirts \nна окраине"), ("On_the_outskirts.jpg", "On the outskirts \nна окраине", "Houses/On_the_outskirts.mp3")},
                 {(12, "In the suburbs \nв пригороде"), ("In_the_suburbs.jpg", "In the suburbs \nв пригороде", "Houses/In_the_suburbs.mp3")},
                 {(13, "Own \nвладеть"), ("Own.png", "Own \nвладеть", "Houses/Own.mp3")},
                 {(14, "Rent \nснимать (квартиру и т.п.)"), ("Rent.png", "Rent \nснимать (квартиру и т.п.)", "Houses/Rent.mp3")},
                 {(15, "Share \nделить / делиться"), ("Share.png", "Share \nделить / делиться", "Houses/Share.mp3")},
                 {(16, "Tiny \nкрошечный"), ("Tiny.jpg", "Tiny \nкрошечный", "Houses/Tiny.mp3")},
                 {(17, "Huge \nогромный"), ("Huge.jpg", "Huge \nогромный", "Houses/Huge.mp3")},
                 {(18, "Quiet \nтихий"), ("Quiet.jpg", "Quiet \nтихий", "Houses/Quiet.mp3")},
                 {(19, "Noisy \nшумный"), ("Noisy.jpg", "Noisy \nшумный", "Houses/Noisy.mp3")},
                 {(20, "Dark \nтемный"), ("Dark.png", "Dark \nтемный", "Houses/Dark.mp3")},
                 {(21, "Light \nсветлый"), ("Light.png", "Light \nсветлый", "Houses/Light.mp3")},
                 {(22, "Spacious \nпросторный"), ("Spacious.jpg", "Spacious \nпросторный", "Houses/Spacious.mp3")},
                 {(23, "Attic \nчердак"), ("Attic.jpg", "Attic \nчердак", "Houses/Attic.mp3")},
                 {(24, "Basement \nподвал"), ("Basement.jpg", "Basement \nподвал", "Houses/Basement.mp3")},
                 {(25, "Bedroom \nспальня"), ("Bedroom.jpg", "Bedroom \nспальня", "Houses/Bedroom.mp3")},
                 {(26, "Living room / Lounge \nгостинная"), ("Flat_Apartment.jpg", "Living room / Lounge \nгостинная", "Houses/Living_room_Lounge.mp3")},
                 {(27, "Dining room \nстоловая"), ("Dining_room.jpg", "Dining room \nстоловая", "Houses/Dining_room.mp3")},
                 {(28, "Kitchen \nкухня"), ("Kitchen.jpg", "Kitchen \nкухня", "Houses/Kitchen.mp3")},
                 {(29, "Bathroom \nванная"), ("Bathroom_shower.jpg", "Bathroom \nванная", "Houses/Bathroom.mp3")},
                 {(30, "Shower \nдуш"), ("Bathroom_shower.jpg", "Shower \nдуш", "Houses/Shower.mp3")},
                 {(31, "WC / Toilet \nтуалет"), ("Toilet.jpg", "WC / Toilet \nтуалет", "Houses/WC_Toilet.mp3")},
                 {(32, "Nursery \nдетская комната"), ("Nursery_r.jpg", "Nursery \nдетская комната", "Houses/Nursery.mp3")},
                 {(33, "Study \nкабинет"), ("room.jpg", "Study \nкабинет", "Houses/Study.mp3")},                
                 {(37, "Central heating \nцентральное отопление"), ("Central_heating.jpg", "Central heating \nцентральное отопление", "Houses/Central_heating.mp3")},
                 {(38, "Cooling \nсистема охлаждения"), ("Cooling.jpg", "Cooling \nсистема охлаждения", "Houses/Cooling.mp3")},
                 {(39, "Water supply \nводоснабжение"), ("Water_supply_Tap.png", "Water supply \nводоснабжение", "Houses/Water_supply.mp3")},
                 {(40, "Electricity \nэлектричество"), ("Electricity.jpg", "Electricity \nэлектричество", "Houses/Electricity.mp3")},                 
                 {(43, "Ceiling \nпотолок"), ("Ceiling.jpg", "Ceiling \nпотолок", "Houses/Ceiling.mp3")},
                 {(44, "Floor \nпол"), ("Floor.jpg", "Floor \nпол", "Houses/Floor.mp3")},
                 {(45, "Fireplace \nкамин"), ("Fireplace.jpg", "Fireplace \nкамин", "Houses/Fireplace.mp3")},
                 {(46, "Microwave \nмикроволновая печь"), ("Microwave.jpg", "Microwave \nмикроволновая печь", "Houses/Microwave.mp3")},
                 {(47, "Fridge \nхолодильник"), ("Fridge_freezer.jpg", "Fridge \nхолодильник", "Houses/Fridge.mp3")},
                 {(48, "Freezer \nморозильник"), ("Fridge_freezer.jpg", "Freezer \nморозильник", "Houses/Freezer.mp3")},
                 {(49, "Dishwasher \nпосудомоечная машина"), ("Dishwasher.jpg", "Dishwasher \nпосудомоечная машина", "Houses/Dishwasher.mp3")},
                 {(50, "Cooker \nплита"), ("Cooker.jpg", "Cooker \nплита", "Houses/Cooker.mp3")},                
                 {(53, "Washing machine \nстиральная машина"), ("Washing_machine.jpg", "Washing machine \nстиральная машина", "Houses/Washing_machine.mp3")},             
                 {(56, "Carpet \nковёр"), ("Carpet.jpg", "Carpet \nковёр", "Houses/Carpet.mp3")},
                 {(57, "Mirror \nзеркало"), ("Mirror.jpg", "Mirror \nзеркало", "Houses/Mirror.mp3")},
                 {(58, "Сurtains \nзанавески"), ("Curtains.jpg", "Curtains \nзанавески", "Houses/Curtains.mp3")},
                 {(60, "Comfy chair \nкресло"), ("Comfy_chair.jpg", "Comfy chair \nкресло", "Houses/Comfy_chair.mp3")},
                 {(62, "Sofa \nдиван"), ("Sofa.jpg", "Sofa \nдиван", "Houses/Sofa.mp3")},
                 {(63, "Sink \nраковина"), ("Sink_tap.jpg", "Sink \nраковина", "Houses/Sink.mp3")},
                 {(64, "Tap \nкран"), ("Sink_tap.jpg", "Tap \nкран", "Houses/Tap.mp3")},

                 {(1, "Point of view / View \nточка зрения"), ("Point_of_view_View.png", "Point of view / View \nточка зрения", "Youth/Point_of_view_view.mp3")},
                 {(2, "In my opinion \nпо моему мнению"), ("In_my_opinion.jpg", "In my opinion \nпо моему мнению", "Youth/In_my_opinion.mp3")},
                 {(3, "Generation gap \nпроблема «отцов и детей» / разрыв между поколениями"), ("Generation_gap.jpg", "Generation gap \nпроблема «отцов и детей» / разрыв между поколениями", "Youth/Generation_gap.mp3")},
                 {(4, "Bad habits \nплохие привычки"), ("Bad_habits.png", "Bad habits \nплохие привычки", "Youth/Bad_habits.mp3")},
                 {(5, "Society \nобщество"), ("Society.png", "Society \nобщество", "Youth/Society.mp3")},
                 {(6, "Aim / To aim \nцель / ставить цель"), ("Aim_To_aim.png", "Aim / To aim \nцель / ставить цель", "Youth/Aim_To_aim.mp3")},
                 {(7, "Goal \nцель"), ("Goal.png", "Goal \nцель", "Youth/Goal.mp3")},
                 {(8, "Involve \nвключать в себя"), ("Involve.png", "Involve \nвключать в себя", "Youth/Involve.mp3")},
                 {(9, "Activity \nдеятельность"), ("Activity.png", "Activity \nдеятельность", "Youth/Activity.mp3")},
                 {(10, "Volunteer \nдоброволец"), ("Volunteer.png", "Volunteer \nдоброволец", "Youth/Volunteer.mp3")},
                 {(11, "Take care of \nзаботиться о …"), ("Take_care_of.png", "Take care of \nзаботиться о …", "Youth/Take_care_of.mp3")},
                 {(12, "Handicapped \nчеловек с физическими или умственными недостатками (инвалид)"), ("Handicapped.png", "Handicapped \nчеловек с физическими или умственными недостатками (инвалид)", "Youth/Handicapped.mp3")},
                 {(13, "Carry out \nвыполнять / осуществлять"), ("successfuly.png", "Carry out \nвыполнять / осуществлять", "Youth/Carry_out.mp3")},
                 {(14, "Numerous \nмногочисленные"), ("Numerous.png", "Numerous \nмногочисленные", "Youth/Numerous.mp3")},
                 {(16, "Promote \nпродвигать"), ("Promote.png", "Promote \nпродвигать", "Youth/Promote.mp3")},
                 {(17, "Patriotic and moral values \nпатриотические и нравственные ценности"), ("Patriotic_and_moral_values.jpg", "Patriotic and moral values \nпатриотические и нравственные ценности", "Youth/Patriotic_and_moral_values.mp3")},
                 {(18, "To reach \nдостигать"), ("To_reach.png", "To reach \nдостигать", "Youth/To_reach.mp3")},
                 {(19, "Charity \nблаготворительность"), ("Charity.png", "Charity \nблаготворительность", "Youth/Charity.mp3")},
                 {(20, "Support \nподдерживать / поддержка"), ("Support.png", "Support \nподдерживать / поддержка", "Youth/Support.mp3")},
                 {(21, "Member \nчлен организации"), ("Member.png", "Member \nчлен организации", "Youth/Member.mp3")},
                 {(22, "Motto \nдевиз"), ("Motto.png", "Motto \nдевиз", "Youth/Motto.mp3")},
                 {(23, "Tolerance \nтерпимость"), ("Tolerance.png", "Tolerance \nтерпимость", "Youth/Tolerance.mp3")},
                 {(24, "Misunderstanding \nнедопонимание"), ("Misunderstanding.png", "Misunderstanding \nнедопонимание", "Youth/Misunderstanding.mp3")},
                 {(25, "Informal youth movements \nнеформальные молодежные движения"), ("Informal_youth_movements.jpg", "Informal youth movements \nнеформальные молодежные движения", "Youth/Informal_youth_movements.mp3")},
                 {(26, "To take an active part \nпринимать активное участие"), ("To_take_an_active_part.jpg", "To take an active part \nпринимать активное участие", "Youth/To_take_an_active_part.mp3")},


                 {(1, "Abstract \nабстрасктный"), ("A.png", "Abstract \nабстрасктный", "Art/abstract.mp3")},
                 {(2, "Visual \nвизуальный"), ("Visual.png", "Visual \nвизуальный", "Art/visual.mp3")},
                 {(3, "Audience \nпублика / зрители"), ("Audience.png", "Audience \nпублика / зрители", "Art/audience.mp3")},
                 {(4, "Content \nсодержание"), ("Content.png", "Content \nсодержание", "Art/content.mp3")},
                 {(5, "Communicate \nпередавать / общаться / сообщать"), ("Communicate.png", "Communicate \nпередавать / общаться / сообщать", "Art/communicate.mp3")},
                 {(6, "Understandable \nпонятный"), ("Understandable.png", "Understandable \nпонятный", "Art/understandable.mp3")},
                 {(7, "Express \nвыражать"), ("Express.jpg", "Express \nвыражать", "Art/express.mp3")},
                 {(8, "Impress \nвпечатлять"), ("Impress.png", "Impress \nвпечатлять", "Art/empress.mp3")},
                 {(11, "Graffiti \nграффити"), ("Graffiti.png", "Graffiti \nграффити", "Art/graffity.mp3")},
                 {(12, "Mural \nбольшое граффити / 3D изображение"), ("Mural_Writer.png", "Mural \nбольшое граффити / 3D изображение", "Art/mural.mp3")},
                 {(13, "Tag \nнадпись"), ("Tag.png", "Tag \nнадпись", "Art/tag.mp3")},
                 {(14, "Writer \nписатель граффити"), ("Mural_Writer.png", "Writer \nписатель граффити", "Art/writer.mp3")},
                 {(15, "Author \nавтор"), ("Author.png", "Author \nавтор", "Art/author.mp3")},
                 {(16, "Artist \nхудожник"), ("Artist_Painter.png", "Artist \nхудожник", "Art/artist.mp3")},
                 {(17, "Painter \nхудожник / живописец"), ("Artist_Painter.png", "Painter \nхудожник / живописец", "Art/painter.mp3")},
                 {(18, "Composer \nкомпозитор"), ("Composer.png", "Composer \nкомпозитор", "Art/compouser.mp3")},
                 {(21, "Drawing \nграфика"), ("Drawing.png", "Drawing \nграфика", "Art/drawing.mp3")},
                 {(22, "Oil painting \nживопись"), ("Oil_painting.png", "Oil painting \nживопись", "Art/oil_painting.mp3")},
                 {(23, "Architecture \nархитектура"), ("Architecture.png", "Architecture \nархитектура", "Art/architecture.mp3")},
                 {(24, "Animation \nмультипликация"), ("Animation.png", "Animation \nмультипликация", "Art/animation.mp3")},
                 {(26, "Comics \nкомикс"), ("Comics.png", "Comics \nкомикс", "Art/comics.mp3")},
                 {(27, "Computer art \nкомпьютерная графика"), ("Computer_art.png", "Computer art \nкомпьютерная графика", "Art/computer_art.mp3")},
                 {(28, "Design \nдизайн"), ("Design.png", "Design \nдизайн", "Art/design.mp3")},
                 {(29, "Filmmaking \nпроизводство фильмов"), ("Filmmaking.png", "Filmmaking \nпроизводство фильмов", "Art/filmmaking.mp3")},
                 {(31, "Photography \nфотография"), ("Photography.png", "Photography \nфотография", "Art/photography.mp3")},
                 {(32, "Sculpture \nскульптура"), ("Sculpture.png", "Sculpture \nскульптура", "Art/sculpture.mp3")},
                 {(33, "Printmaking \nгравюра"), ("Printmaking.png", "Printmaking \nгравюра", "Art/print_making.mp3")},
                 {(35, "Exhibition \nвыставка"), ("Exhibition.png", "Exhibition \nвыставка", "Art/exibition.mp3")},
                 {(36, "Ban \nзапретить"), ("Ban.png", "Ban \nзапретить", "Art/ban.mp3")},
                 {(37, "Piece of art \nпроизведение искусства"), ("Piece_of_art.png", "Piece of art \nпроизведение искусства", "Art/peace_of_art.mp3")},
                 {(38, "Enjoy -ing \nлюбить что-то делать"), ("Enjoy.png", "Enjoy -ing \nлюбить что-то делать", "Art/enjoying.mp3")},
                 {(39, "Iconic \nиконический / символический"), ("Iconic.png", "Iconic \nиконический / символический", "Art/iconic.mp3")},
                 {(40, "Unique \nуникальный"), ("Unique.png", "Unique \nуникальный", "Art/unique.mp3")},
                 {(41, "Recognizable \nузнаваемый"), ("Recognizable.png", "Recognizable \nузнаваемый", "Art/recognizable.mp3")},
                 {(43, "Spectacular \nзрелищный"), ("Spectacular.jpg", "Spectacular \nзрелищный", "Art/spectacular.mp3")},
                 {(46, "Background \nзадний план / фон"), ("Background.png", "Background \nзадний план / фон", "Art/background.mp3")},
                 {(47, "Foreground \nпередний план"), ("Foreground.png", "Foreground \nпередний план", "Art/foreground.mp3")},
                 {(48, "Landmark \nландшафт"), ("Landmark.png", "Landmark \nландшафт", "Art/landmark.mp3")},




                 {(1, "Relative \nродственник"), ("Relative.png", "Relative \nродственник", "Family/Relative.mp3")},
                 {(2, "Distant \nдальний"), ("Distant.png", "Distant \nдальний", "Family/Distant.mp3")},
                 {(3, "Close \nблизкий"), ("Close.png", "Close \nблизкий", "Family/Close.mp3")},
                 {(6, "Parents \nродители"), ("Parents.png", "Parents \nродители", "Family/Parents.mp3")},
                 {(7, "Daughter \nдочь"), ("Daughter.png", "Daughter \nдочь", "Family/Daughter.mp3")},
                 {(8, "Son \nсын"), ("Son.png", "Son \nсын", "Family/Son.mp3")},
                 {(9, "Sibling \nродной брат или сестра"), ("Sibling.png", "Sibling \nродной брат или сестра", "Family/Sibling.mp3")},
                 {(10, "Twins \nблизнецы / двойня"), ("Twins.png", "Twins \nблизнецы / двойня", "Family/Twins.mp3")},
                 {(11, "Grandparents \nдедушка и бабушка"), ("Grandparents_Father_in_law_Mother_in_law.png", "Grandparents \nдедушка и бабушка", "Family/Grandparents.mp3")},
                 {(12, "Grandchild (мн. Grandchildren) \nвнук / внучка (внуки)"), ("Grandchild_Grandson.png", "Grandchild (мн. Grandchildren) \nвнук / внучка (внуки)", "Family/Grandchild.mp3")},
                 {(13, "Grandson \nвнук"), ("Grandchild_Grandson.png", "Grandson \nвнук", "Family/Grandson.mp3")},
                 {(14, "Granddaughter  \nвнучка"), ("Granddaughter_Great_grandchildren.png", "Granddaughter  \nвнучка", "Family/Granddaughter.mp3")},
                 {(16, "Aunt \nтетя"), ("Aunt.png", "Aunt \nтетя", "Family/Aunt.mp3")},
                 {(17, "Uncle \nдядя"), ("Uncle.png", "Uncle  \nдядя", "Family/Uncle.mp3")},
                 {(18, "Niece \nплемянница"), ("Niece.png", "Niece \nплемянница", "Family/Niece.mp3")},
                 {(19, "Nephew \nплемянник"), ("Nephew.png", "Nephew \nплемянник", "Family/Nephew.mp3")},
                 {(20, "Cousin \nдвоюродный брат / сестра"), ("Cousin.png", "Cousin \nдвоюродный брат / сестра", "Family/Cousin.mp3")},
                 {(21, "Stepfather \nотчим"), ("Stepfather.png", "Stepfather \nотчим", "Family/Stepfather.mp3")},
                 {(22, "Stepmother \nмачеха"), ("Stepmother_Stepson.png", "Stepmother \nмачеха", "Family/Stepmother.mp3")},
                 {(23, "Stepson \nприемный сын"), ("Stepmother_Stepson.png", "Stepson \nприемный сын", "Family/Stepson.mp3")},
                 {(24, "Stepdaughter \nпадчерица"), ("Stepdaughter_Stepsister.png", "Stepdaughter \nпадчерица", "Family/Stepdaughter.mp3")},
                 {(25, "Stepbrother \nсводный брат"), ("Stepbrother.png", "Stepbrother \nсводный брат", "Family/Stepbrother.mp3")},
                 {(26, "Stepsister \nсводная cестра"), ("Stepdaughter_Stepsister.png", "Stepsister \nсводная cестра", "Family/Stepsister.mp3")},
                 {(29, "The only child \nединственный ребенок"), ("The_only_child.png", "The only child \nединственный ребенок", "Family/The_only_child.mp3")},
                 {(31, "Father-in-law \nсвекор / тесть"), ("Grandparents_Father_in_law_Mother_in_law.png", "Father-in-law \nсвекор / тесть", "Family/Father_in_law.mp3")},
                 {(32, "Mother-in-law \nсвекровь / теща"), ("Grandparents_Father_in_law_Mother_in_law.png", "Mother-in-law \nсвекровь / теща", "Family/Mother_in_law.mp3")},
                 {(33, "Son-in-law \nмуж дочери / зять"), ("Son_in_law.png", "Son-in-law \nмуж дочери / зять", "Family/Son_in_law.mp3")},
                 {(34, "Daughter-in-law \nжена сына / невестка"), ("Daughter_in_law.png", "Daughter-in-law \nжена сына / невестка", "Family/Daughter_in_law.mp3")},
                 {(35, "Wife \nжена"), ("Wife_Bride.png", "Wife \nжена", "Family/Wife.mp3")},
                 {(36, "Husband \nмуж"), ("Husband_Groom.png", "Husband \nмуж", "Family/Husband.mp3")},
                 {(37, "Groom \nжених (на свадьбе)"), ("Husband_Groom.png", "Groom \nжених (на свадьбе)", "Family/Groom.mp3")},
                 {(38, "Bride \nневеста (на свадьбе)"), ("Wife_Bride.png", "Bride \nневеста (на свадьбе)", "Family/Bride.mp3")},
                 {(39, "Bachelor \nхолост / не замужем / холостяк"), ("Single_Bachelor.jpg", "Single / Bachelor \nхолост / не замужем / холостяк", "Family/Bachelor.mp3")},
                 {(41, "Divorced \nразведен(а)"), ("Divorced_Ex_Wife_Ex_Husband.png", "Divorced \nразведен(а)", "Family/Divorced.mp3")},
                 {(42, "Ex-Wife \nбывшая жена"), ("Divorced_Ex_Wife_Ex_Husband.png", "Ex-Wife \nбывшая жена", "Family/Ex_wife.mp3")},
                 {(43, "Ex-Husband \nбывший муж"), ("Divorced_Ex_Wife_Ex_Husband.png", "Ex-Husband \nбывший муж", "Family/Ex_husband.mp3")},
                 {(44, "Single-parent family \nнеполная семья (с одним родителем)"), ("Single_parent_family.png", "Single-parent family \nнеполная семья (с одним родителем)", "Family/Single_parent_family.mp3")},
                 {(45, "Foster family \nприемная семья"), ("Foster_family.png", "Foster family \nприемная семья", "Family/Foster_family.mp3")},
                 {(48, "Get on well \nладить с кем-то из членов семьи"), ("Get_on_well.jpg", "Get on well \nладить с кем-то из членов семьи", "Family/Get_on_well.mp3")},
                 {(50, "Help each other \nпомогать друг другу"), ("Help_each_other_Turn_for_help.png", "Help each other \nпомогать друг другу", "Family/Help_each_other.mp3")},
                 {(53, "Turn for help \nобратиться за помощью"), ("Help_each_other_Turn_for_help.png", "Turn for help \nобратиться за помощью", "Family/Turn_for_help.mp3")},
                 {(54, "Appreciate \nценить"), ("Appreciate.png", "Appreciate \nценить", "Family/Appreciate.mp3")},
                 {(55, "Tight-knit \nдружная"), ("Tight_knit.png", "Tight-knit \nдружная", "Family/Tight_knit.mp3")},
                 {(56, "Family ties \nсемейные связи"), ("Family_ties.png", "Family ties \nсемейные связи", "Family/Family_ties.mp3")},




                 {(1, "Badly-paid \nнизкооплачиваемый"), ("Badly_paid.png", "Badly-paid \nнизкооплачиваемый", "Jobs/Badly_paid.mp3")},
                 {(2, "Well-paid \nвысокооплачиваемый"), ("Well_paid_Salary_Earn.png", "Well-paid \nвысокооплачиваемый", "Jobs/Well_paid.mp3")},
                 {(3, "Be in high demand \nпользоваться большим спросом"), ("Be_in_high_demand_Require.jpg", "Be in high demand \nпользоваться большим спросом", "Jobs/Be_in_high_demand.mp3")},
                 {(4, "Benefit \nльготы / пособия"), ("Benefit.jpg", "Benefit \nльготы / пособия", "Jobs/Benefit.mp3")},
                 {(6, "Career \nкарьера"), ("Career.png", "Career \nкарьера", "Jobs/Career.mp3")},
                 {(7, "Challenging \nтребующий напряжения (сил)"), ("Challenging.jpg", "Challenging \nтребующий напряжения (сил)", "Jobs/Challenging.mp3")},
                 {(8, "Deal with clients \nиметь дело с клиентами"), ("Deal_with_clients.jpg", "Deal with clients \nиметь дело с клиентами", "Jobs/Deal_with_clients.mp3")},
                 {(9, "Entrepreneur \nпредприниматель"), ("Entrepreneur_Businessman.png", "Entrepreneur \nпредприниматель", "Jobs/Entrepreneur.mp3")},
                 {(10, "Follow in someone’s footsteps \nидти по стопам кого-либо"), ("Follow_in_someones_footsteps.jpg", "Follow in someone’s footsteps \nидти по стопам кого-либо", "Jobs/Follow_in_someones_footsteps.mp3")},
                 {(11, "Have good / poor working conditions \nиметь хорошие / плохие условия для работы"), ("Have_good_poor_working_conditions.jpg", "Have good / poor working conditions \nиметь хорошие / плохие условия для работы", "Jobs/Have_good_poor_working_conditions.mp3")},
                 {(12, "Highly skilled \nвысококвалифицированный"), ("Highly_skilled_Qualified.jpg", "Highly skilled \nвысококвалифицированный", "Jobs/Highly_skilled.mp3")},
                 {(13, "Job security \nгарантия занятости"), ("Job_security.jpg", "Job security \nгарантия занятости", "Jobs/Job_security.mp3")},
                 {(14, "Load \nнагрузка"), ("Load.png", "Load \nнагрузка", "Jobs/Load.mp3")},
                 {(15, "Nurse \nмедсестра"), ("Nurse.png", "Nurse \nмедсестра", "Jobs/Nurse.mp3")},
                 {(16, "Qualification \nквалификация / право занимать какую-либо должность"), ("Qualification.jpg", "Qualification \nквалификация / право занимать какую-либо должность", "Jobs/Qualification.mp3")},
                 {(17, "Qualified \nквалифицированный / компетентный / сведущий"), ("Highly_skilled_Qualified.jpg", "Qualified \nквалифицированный / компетентный / сведущий", "Jobs/Qualified.mp3")},
                 {(18, "Require \nтребовать"), ("Be_in_high_demand_Require.jpg", "Require \nтребовать", "Jobs/Require.mp3")},
                 {(19, "Salary \nжалованье / заработная плата / оклад"), ("Well_paid_Salary_Earn.png", "Salary \nжалованье / заработная плата / оклад", "Jobs/Salary.mp3")},
                 {(20, "Strength \nсильная cторона"), ("Strength.png", "Strength \nсильная cторона", "Jobs/Strength.mp3")},
                 {(21, "Weakness \nслабые cтороны"), ("Weakness.png", "Weakness \nслабые cтороны", "Jobs/Weakness.mp3")},
                 {(24, "In the field of \nв сфере"), ("In_the_field_of.jpg", "In the field of \nв сфере", "Jobs/In_the_field_of.mp3")},
                 {(26, "Experienced \nопытный"), ("Experienced.png", "Experienced \nопытный", "Jobs/Experienced.mp3")},
                 {(27, "Inexperienced \nнеопытный"), ("Inexperienced.jpg", "Inexperienced \nнеопытный", "Jobs/Inexperienced.mp3")},
                 {(29, "Earn \nзарабатывать"), ("Well_paid_Salary_Earn.png", "Earn \nзарабатывать", "Jobs/Earn.mp3")},
                 {(31, "Work as… \nработать кем-то / в качестве кого-то"), ("Work_as.jpg", "Work as… \nработать кем-то / в качестве кого-то", "Jobs/Work_as.mp3")},
                 {(32, "Accountant \nбухгалтер (с высшим образованием)"), ("Accountant_Book_Keeper.png", "Accountant \nбухгалтер (с высшим образованием)", "Jobs/Accountant.mp3")},
                 {(33, "Book-Keeper \nбухгалтер (со средним образованием)"), ("Accountant_Book_Keeper.png", "Book-Keeper \nбухгалтер (со средним образованием)", "Jobs/Book_keeper.mp3")},
                 {(34, "Artist \nхудожник"), ("Artist_Painter.png", "Artist \nхудожник", "Jobs/Artist.mp3")},
                 {(35, "Banker \nбанкир"), ("Banker.png", "Banker \nбанкир", "Jobs/Banker.mp3")},
                 {(36, "Builder \nстроитель"), ("Builder.png", "Builder \nстроитель", "Jobs/Builder.mp3")},
                 {(37, "Businessman \nбизнесмен"), ("Entrepreneur_Businessman.png", "Businessman \nбизнесмен", "Jobs/Businessman.mp3")},
                 {(38, "Carpenter \nстоляр / плотник"), ("Carpenter.png", "Carpenter \nстоляр / плотник", "Jobs/Carpenter.mp3")},
                 {(39, "Cleaner \nуборщик"), ("Cleaner.png", "Cleaner \nуборщик", "Jobs/Cleaner.mp3")},
                 {(40, "Cook \nповар"), ("Cook.png", "Cook \nповар", "Jobs/Cook.mp3")},
                 {(41, "Driver \nводитель"), ("Driver.png", "Driver \nводитель", "Jobs/Driver.mp3")},
                 {(42, "Economist \nэкономист"), ("Economist.png", "Economist \nэкономист", "Jobs/Economist.mp3")},
                 {(43, "Electrician \nэлектрик"), ("Electrician.png", "Electrician \nэлектрик", "Jobs/Electrician.mp3")},
                 {(44, "Engineer \nинженер"), ("Engineer.png", "Engineer \nинженер", "Jobs/Engineer.mp3")},
                 {(46, "Librarian \nбиблиотекарь"), ("Librarian.png", "Librarian \nбиблиотекарь", "Jobs/Librarian.mp3")},
                 {(48, "Militiaman \nмилиционер"), ("Militiaman.png", "Militiaman \nмилиционер", "Jobs/Militiaman.mp3")},
                 {(49, "Plumber \nсантехник"), ("Plumber.png", "Plumber \nсантехник", "Jobs/Plumber.mp3")},
                 {(50, "Postman \nпочтальон"), ("Postman.png", "Postman \nпочтальон", "Jobs/Postman.mp3")},
                 {(51, "Programmer \nпрограммист"), ("Programmer.png", "Programmer \nпрограммист", "Jobs/Programmer.mp3")},
                 {(52, "Secretary \nсекретарь"), ("Secretary.png", "Secretary \nсекретарь", "Jobs/Secretary.mp3")},
                 {(53, "Shop-assistant \nпродавец"), ("Shop_assistant.png", "Shop-assistant \nпродавец", "Jobs/Shop_assistant.mp3")},
                 {(55, "Vet \nветеринар"), ("Vet.png", "Vet \nветеринар", "Jobs/Vet.mp3")},
                 {(56, "Waiter \nофициант"), ("Waiter.png", "Waiter \nофициант", "Jobs/Waiter.mp3")},




                 {(1, "Stereotype \nстереотип"), ("Stereotype.png", "Stereotype \nстереотип", "National/Stereotype.mp3")},
                 {(2, "Generalization \nобобщение"), ("Generalization.png", "Generalization \nобобщение", "National/Generalization.mp3")},
                 {(3, "Agreeable \nприятный / милый / подходящий"), ("Agreeable.png", "Agreeable \nприятный / милый / подходящий", "National/Agreeable.mp3")},
                 {(4, "Ambitious \nамбициозный"), ("Ambitious_Aspiration.png", "Ambitious \nамбициозный", "National/Ambitious.mp3")},
                 {(5, "Anxious \nтревожный / беспокойный / суетливый"), ("Anxious.png", "Anxious \nтревожный / беспокойный / суетливый", "National/Anxious.mp3")},
                 {(6, "Arrogant \nвысокомерный"), ("Arrogant.png", "Arrogant \nвысокомерный", "National/Arrogant.mp3")},
                 {(7, "Aspiration \nстремление"), ("Ambitious_Aspiration.png", "Aspiration \nстремление", "National/Aspiration.mp3")},
                 {(8, "Assertive \nнапористый"), ("Assertive.png", "Assertive \nнапористый", "National/Assertive.mp3")},
                 {(9, "Caring \nзаботливый"), ("Caring_Kind_hearted.png", "Caring \nзаботливый", "National/Caring.mp3")},
                 {(10, "Controlled \nконтролируемый"), ("Controlled.png", "Controlled \nконтролируемый", "National/Controlled.mp3")},
                 {(11, "Flexible \nгибкий"), ("Flexible.png", "Flexible \nгибкий", "National/Flexible.mp3")},
                 {(12, "Generous \nщедрый"), ("Generous.png", "Generous \nщедрый", "National/Generous.mp3")},
                 {(13, "Honest \nчестный"), ("Honest.png", "Honest \nчестный", "National/Honest.mp3")},
                 {(14, "Humble \nскромный"), ("Humble.png", "Humble \nскромный", "National/Humble.mp3")},
                 {(16, "Impulsive \nимпульсивный"), ("Impulsive.png", "Impulsive \nимпульсивный", "National/Impulsive.mp3")},
                 {(18, "Law-abiding \nзаконопослушный"), ("Law_abiding.png", "Law-abiding \nзаконопослушный", "National/Law_abiding.mp3")},
                 {(19, "Materialistic \nпрактичный"), ("Materialistic.png", "Materialistic \nпрактичный", "National/Materialistic.mp3")},
                 {(21, "Obsessive \nнавязчивый"), ("Obsessive.png", "Obsessive \nнавязчивый", "National/Obsessive.mp3")},
                 {(23, "Organized \nорганизованный"), ("Organized.png", "Organized \nорганизованный", "National/Organized.mp3")},
                 {(24, "Respectful \nуважительный / почтительный"), ("Respectful.png", "Respectful \nуважительный / почтительный", "National/Respectful.mp3")},
                 {(25, "Shallow \nнеглубокий / поверхностный"), ("Shallow.png", "Shallow \nнеглубокий / поверхностный", "National/Shallow.mp3")},
                 {(26, "Straightforward \nпрямолинейный"), ("Straightforward.png", "Straightforward \nпрямолинейный", "National/Straightforward.mp3")},
                 {(27, "Submissive \nпокорный"), ("Submissive.png", "Submissive \nпокорный", "National/Submissive.mp3")},
                 {(28, "Talkative \nболтливый / разговорчивый"), ("Talkative.png", "Talkative \nболтливый / разговорчивый", "National/Talkative.mp3")},
                 {(29, "Technical \nтехнический"), ("Technical.png", "Technical \nтехнический", "National/Technical.mp3")},
                 {(30, "Proud \nгордый"), ("Proud_Confident.png", "Proud \nгордый", "National/Proud.mp3")},
                 {(31, "Amusing \nзабавный / прикольный"), ("Amusing.png", "Amusing \nзабавный / прикольный", "National/Amusing.mp3")},
                 {(32, "Polite \nвежливый"), ("Polite.png", "Polite \nвежливый", "National/Polite.mp3")},
                 {(33, "Humiliating \nунижающий"), ("Humiliating.png", "Humiliating \nунижающий", "National/Humiliating.mp3")},
                 {(34, "Confident \nуверенный / самоуверенный"), ("Proud_Confident.png", "Confident \nуверенный / самоуверенный", "National/Confident.mp3")},
                 {(35, "Kind-hearted \nдобросердечный"), ("Caring_Kind_hearted.png", "Kind-hearted \nдобросердечный", "National/Kind_hearted.mp3")},
                 {(36, "Outgoing \nобщительный / коммуникабельный"), ("Outgoing.png", "Outgoing \nобщительный / коммуникабельный", "National/Outgoing.mp3")},
                 {(37, "Funky \nклевый / броский / прикольный"), ("Funky.png", "Funky \nклевый / броский / прикольный", "National/Funky.mp3")},
                 {(39, "Reasonable \nрациональный / благоразумный"), ("Reasonable.png", "Reasonable \nрациональный / благоразумный", "National/Reasonable.mp3")},
                 {(40, "Thick-headed \nтупоголовый"), ("Thick_headed.png", "Thick-headed \nтупоголовый", "National/Thick_headed.mp3")},
                 {(41, "Stubborn \nупрямый / упертый"), ("Stubborn.png", "Stubborn \nупрямый / упертый", "National/Stubborn.mp3")},
                 {(42, "Biased \nпредвзятый"), ("Biased.png", "Biased \nпредвзятый", "National/Biased.mp3")},
                 {(43, "Unbiased \nнепредвзятый"), ("Unbiased.png", "Unbiased \nнепредвзятый", "National/Unbiased.mp3")},
                 {(45, "Rude \nгрубый"), ("Rude.png", "Rude \nгрубый", "National/Rude.mp3")},
                 {(46, "Strict \nстрогий"), ("Strict.png", "Strict \nстрогий", "National/Strict.mp3")},
                 {(47, "Thankful \nблагодарный"), ("Thankful.png", "Thankful \nблагодарный", "National/Thankful.mp3")},
                 {(48, "Dull \nскучный"), ("Dull.png", "Dull \nскучный", "National/Dull.mp3")},
                 {(51, "Passive \nпассивный"), ("Passive.png", "Passive \nпассивный", "National/Passive.mp3")},
                 {(52, "Tolerant \nтерпимый / толерантный"), ("Tolerant.png", "Tolerant \nтерпимый / толерантный", "National/Tolerant.mp3")},
                 {(53, "Indolent \nочень ленивый"), ("Indolent.png", "Indolent \nочень ленивый", "National/Indolent.mp3")},



                 {(1, "Annual \nежегодный / годовой"), ("Annual.png", "Annual \nежегодный / годовой", "InterCult/Annual.mp3")},
                 {(2, "Comfort zone \nзона комфорта"), ("Comfort_zone.png", "Comfort zone \nзона комфорта", "InterCult/Comfort_zone.mp3")},
                 {(3, "Community \nсообщество / община"), ("Community.png", "Community \nсообщество / община", "InterCult/Community.mp3")},
                 {(4, "Contemporary \nсовременный / современник"), ("Contemporary.png", "Contemporary \nсовременный / современник", "InterCult/Contemporary.mp3")},
                 {(5, "Cooperation \nсотрудничество"), ("Cooperation.png", "Cooperation \nсотрудничество", "InterCult/Cooperation.mp3")},
                 {(6, "Culture shock \nкультурный шок"), ("Culture_shock.jpg", "Culture shock \nкультурный шок", "InterCult/Culture_shock.mp3")},
                 {(7, "Embassy \nпосольство"), ("Embassy.png", "Embassy \nпосольство", "InterCult/Embassy.mp3")},
                 {(8, "Ensure \nгарантировать / обеспечить"), ("Ensure.png", "Ensure \nгарантировать / обеспечить", "InterCult/Ensure.mp3")},
                 {(9, "Establish \nустановить / учредить"), ("Establish.png", "Establish \nустановить / учредить", "InterCult/Establish.mp3")},
                 {(10, "Gain \nприобретать"), ("Gain.png", "Gain \nприобретать", "InterCult/Gain.mp3")},
                 {(11, "Grassroots \nнизовой"), ("Grassroots.png", "Grassroots \nнизовой", "InterCult/Grassroots.mp3")},
                 {(12, "Highlight \nвершина / кульминация / основной момент"), ("Highlight.png", "Highlight \nвершина / кульминация / основной момент", "InterCult/Highlight.mp3")},
                 {(13, "Joint \nсовместный"), ("Joint.png", "Joint \nсовместный", "InterCult/Joint.mp3")},
                 {(14, "Independent \nнезависимый"), ("Independent.png", "Independent \nнезависимый", "InterCult/Independent.mp3")},



                 {(1, "To swear by something \ncвято верить / поклясться чем-то"), ("To_swear_by_something.jpg", "To swear by something \nCвято верить / поклясться чем-то", "Tour/To_swear_by_something.mp3")},
                 {(2, "Burst out of someone’s comfort zone \nвырваться из зоны комфорта"), ("Burst_out_of_someones_comfort_zone.png", "Burst out of someone’s comfort zone \nвырваться из зоны комфорта", "Tour/Burst__out_of_someones_comfort_zone.mp3")},
                 {(4, "Go beyond something \nвыходить за рамки"), ("Go_beyond_something.png", "Go beyond something \nвыходить за рамки", "Tour/Go_beyond_something.mp3")},
                 {(5, "Go through a rough patch \nпереживать трудные времена"), ("Go_through_a_rough_patch.jpg", "Go through a rough patch \nпереживать трудные времена", "Tour/Go_through_a_rough_patch.mp3")},
                 {(6, "Have a head for something \nиметь способность / Cклонность к чему-либо"), ("Have_a_head_for_something.jpg", "Have a head for something \nиметь способность / Cклонность к чему-либо", "Tour/Have_a_head_for_something.mp3")},
                 {(7, "Immerse yourself in something \nпогрузиться во что-либо"), ("Immerse_yourself_in_something.jpg", "Immerse yourself in something \nпогрузиться во что-либо", "Tour/Immerse_yourself_in_something.mp3")},
                 {(8, "Itinerary \nмаршрут"), ("Itinerary.png", "Itinerary \nмаршрут", "Tour/Itinerary.mp3")},
                 {(9, "Last resort \nкрайняя мера / последнее средство"), ("Last_resort.jpg", "Last resort \nкрайняя мера / последнее средство", "Tour/Last_resort.mp3")},
                 {(11, "Perk \nпреимущество / привилегия"), ("Perk.png", "Perk \nпреимущество / привилегия", "Tour/Perk.mp3")},
                 {(12, "Benefit \nбонус"), ("Benefit.jpg", "Benefit \nбонус", "Tour/Benefit.mp3")},
                 {(13, "Plough through something \nосилить что-либо"), ("Plough_through_something.jpg", "Plough through something \nосилить что-либо", "Tour/Plough_through_something.mp3")},
                 {(14, "Set off \nотправляться в путь"), ("Set_off.jpg", "Set off \nотправляться в путь", "Tour/Set_off.mp3")},
                 {(15, "Stamping grounds \nизлюбленное место"), ("Stamping_grounds.png", "Stamping grounds \nизлюбленное место", "Tour/Stamping_grounds.mp3")},
                 {(16, "Stay on top of something \nбыть на высоте"), ("Stay_on_top_of_something.jpg", "Stay on top of something \nбыть на высоте", "Tour/Stay_on_top_of_something.mp3")},
                 {(19, "Time-consuming \nтребующий много времени"), ("Time_consuming.png", "Time-consuming \nтребующий много времени", "Tour/Time_consuming.mp3")},
                 {(21, "Unconventional \nнетрадиционный / нестандартный"), ("Unconventional.jpg", "Unconventional \nнетрадиционный / нестандартный", "Tour/Unconventional.mp3")},
                 {(22, "Travelling / Travel \nпутешествие"), ("Travelling_Travel_Journey_Flight.png", "Travelling / Travel \nпутешествие", "Tour/Travelling_Travel.mp3")},
                 {(24, "Journey \nдлительное путешествие (по суше)"), ("Trip.png", "Journey \nдлительное путешествие (по суше)", "Tour/Journey.mp3")},
                 {(25, "Trip \nпоездка / экскурсия"), ("Trip.png", "Trip \nпоездка / экскурсия", "Tour/Trip.mp3")},
                 {(26, "Package tour \nпутешествие по путевке"), ("Package_tour.png", "Package tour \nпутешествие по путевке", "Tour/Package_tour.mp3")},
                 {(27, "Cruise \nкруиз"), ("Cruise.png", "Cruise \nкруиз", "Tour/Cruise.mp3")},
                 {(28, "Voyage \nпутешествие по морю"), ("Voyage.png", "Voyage \nпутешествие по морю", "Tour/Voyage.mp3")},
                 {(29, "Flight \nполет / рейс"), ("Travelling_Travel_Journey_Flight.png", "Flight \nполет / рейс", "Tour/Flight.mp3")},
                 {(30, "To go hitchhiking \nотправиться в путешествие автостопом"), ("To_go_hitchhiking.png", "To go hitchhiking \nотправиться в путешествие автостопом", "Tour/To_go_hitchhiking.mp3")},
                 {(31, "Travel agency \nтуристическое агентство"), ("Travel_agency.png", "Travel agency \nтуристическое агентство", "Tour/Travel_agency.mp3")},
                 {(35, "Stay in a hotel \nостановиться в отеле"), ("Stay_in_a_hotel.png", "Stay in a hotel \nостановиться в отеле", "Tour/Stay_in_a_hotel.mp3")},
                 {(36, "Luggage (baggage) \nбагаж"), ("Luggage.png", "Luggage (baggage) \nбагаж", "Tour/Luggage.mp3")},
                 {(37, "Backpack \nрюкзак"), ("Backpack.png", "Backpack \nрюкзак", "Tour/Backpack.mp3")},
                 {(38, "Information desk \nсправочное бюро"), ("Information_desk.png", "Information desk \nсправочное бюро", "Tour/Information_desk.mp3")},
                 {(39, "Left luggage office \nкамера хранения"), ("Left_luggage_office.jpg", "Left luggage office \nкамера хранения", "Tour/Left_luggage_office.mp3")},






                 {(1, "Nature \nприрода"), ("Nature.png", "Nature \nприрода", "Envir/Nature.mp3")},
                 {(2, "Environment \nокружающая среда"), ("Environment.png", "Environment \nокружающая среда", "Envir/Environment.mp3")},
                 {(3, "Changeable \nменяющийся"), ("Changeable.png", "Changeable \nменяющийся", "Envir/Changeable.mp3")},
                 {(4, "Humanity \nчеловечество"), ("Humanity_Mankind.png", "Humanity \nчеловечество", "Envir/Humanity.mp3")},
                 {(5, "Pollution \nзагрязнение"), ("Pollution_To_pollute.png", "Pollution \nзагрязнение", "Envir/Pollution.mp3")},
                 {(6, "To pollute \nзагрязнять"), ("Pollution_To_pollute.png", "To pollute \nзагрязнять", "Envir/To_pollute.mp3")},
                 {(7, "Contamination \nзагрязнение / заражение"), ("Cont.png", "Contamination \nзагрязнение / заражение", "Envir/Contamination.mp3")},
                 {(8, "To contaminate \nзагрязнять / заражать"), ("Cont.png", "To сontaminate \nзагрязнять / заражать", "Envir/To_contaminate.mp3")},
                 {(9, "Uncontrolled \nнеконтролируемый"), ("Uncontrolled.png", "Uncontrolled \nнеконтролируемый", "Envir/Uncontrolled.mp3")},
                 {(10, "Emission \nвыброс"), ("Emission.png", "Emission \nвыброс", "Envir/Emission.mp3")},
                 {(11, "Harmful \nвредный"), ("Harmful.png", "Harmful \nвредный", "Envir/Harmful.mp3")},
                 {(12, "Substance \nвещество"), ("Substance.png", "Substance \nвещество", "Envir/Substance.mp3")},
                 {(13, "Dust \nпыль"), ("Dust.png", "Dust \nпыль", "Envir/Dust.mp3")},
                 {(14, "Reason \nпричина"), ("Reason.png", "Reason \nпричина", "Envir/Reason.mp3")},
                 {(15, "Poison \nяд / отравлять"), ("Poison.png", "Poison \nяд / отравлять", "Envir/Poison.mp3")},
                 {(16, "Destroy \nразрушать"), ("Destroy.png", "Destroy \nразрушать", "Envir/Destroy.mp3")},
                 {(20, "Wastes \nотходы"), ("Wastes.png", "Wastes \nотходы", "Envir/Wastes.mp3")},
                 {(21, "Soil \nпочва"), ("Soil.png", "Soil \nпочва", "Envir/Soil.mp3")},
                 {(22, "Dangerous \nопасный"), ("Dangerous.png", "Dangerous \nопасный", "Envir/Dangerous.mp3")},
                 {(23, "List \nсписок"), ("List.png", "List \nсписок", "Envir/List.mp3")},
                 {(24, "Endless \nбесконечный"), ("Endless.png", "Endless \nбесконечный", "Envir/Endless.mp3")},
                 {(26, "To protect \nзащищать"), ("To_protect.png", "To protect \nзащищать", "Envir/To_protect.mp3")},
                 {(27, "Mankind \nчеловечество"), ("Humanity_Mankind.png", "Mankind \nчеловечество", "Envir/Mankind.mp3")},
                 {(28, "Reduce \nуменьшать / сокращать"), ("Reduce.png", "Reduce \nуменьшать / сокращать", "Envir/Reduce.mp3")},
                 {(29, "Household \nбытовой"), ("Household.png", "Household \nбытовой", "Envir/Household.mp3")},
                 {(30, "Acid rains \nкислотные дожди"), ("Acid_rains.png", "Acid rains \nкислотные дожди", "Envir/Acid_rains.mp3")},
                 {(31, "Greenhouse effect \nпарниковый эффект"), ("Greenhouse_effect.png", "Greenhouse effect \nпарниковый эффект", "Envir/Greenhouse_effect.mp3")},
                 {(32, "Ozone holes \nозоновые дыры"), ("Ozone_holes.png", "Ozone holes \nозоновые дыры", "Envir/Ozone_holes.mp3")},
                 {(34, "Global warming \nглобальное потепление"), ("Global_warming.png", "Global warming \nглобальное потепление", "Envir/Global_warming.mp3")},
                 {(35, "Recycle \nповторно использовать / возвращать в оборот"), ("Recycle.png", "Recycle \nповторно использовать / возвращать в оборот", "Envir/Recycle.mp3")},
                 {(36, "Landfill \nсвалка"), ("Landfill.png", "Landfill \nсвалка", "Envir/Landfill.mp3")},
                 {(37, "Extinct \nвымерший"), ("Extinct.png", "Extinct \nвымерший", "Envir/Extinct.mp3")},
                 {(39, "Renewable \nвозобновляемый"), ("Renewable.png", "Renewable \nвозобновляемый", "Envir/Renewable.mp3")},
                 {(40, "Reuse \nиспользовать снова"), ("Reuse.png", "Reuse \nиспользовать снова", "Envir/Reuse.mp3")},
                 {(41, "Species \nрод / вид / порода"), ("Species.png", "Species \nрод / вид / порода", "Envir/Species.mp3")},
                 {(42, "Melt \nтаять"), ("Melt.png", "Melt \nтаять", "Envir/Melt.mp3")},
                 {(43, "Nuclear \nядерный"), ("Nuclear.png", "Nuclear \nядерный", "Envir/Nuclear.mp3")},
                 {(44, "Valuable \nценный"), ("Valuable.png", "Valuable \nценный", "Envir/Valuable.mp3")},


                 {(1, "Conquer \nзавоевать"), ("Conquer.png", "Conquer \nзавоевать", "Abroad/Conquer.mp3")},
                 {(3, "The lungs of Europe \nлегкие Европы"), ("The_lungs_of_Europe.jpg", "The lungs of Europe \nлегкие Европы", "Abroad/The_lungs_of_Europe.mp3")},
                 {(5, "Spread \nраспространить"), ("Spread.png", "Spread \nраспространить", "Abroad/Spread.mp3")},
                 {(6, "Swamp \nболото"), ("Swamp.png", "Swamp \nболото", "Abroad/Swamp.mp3")},
                 {(7, "Grassland \nлуга"), ("Grassland_A_vast_plain.png", "Grassland \nлуга", "Abroad/Grassland.mp3")},
                 {(9, "Bison \nзубр"), ("Bison.png", "Bison \nзубр", "Abroad/Bison.mp3")},
                 {(10, "Stork \nаист"), ("Stork.png", "Stork \nаист", "Abroad/Stork.mp3")},
                 {(11, "Cornflower \nвасилек"), ("Cornflower.png", "Cornflower \nвасилек", "Abroad/Cornflower.mp3")},
                 {(13, "To consist of \nсостоять из"), ("To_consist_of_Changeable.png", "To consist of \nсостоять из", "Abroad/To_consist_of.mp3")},
                 {(14, "To be situated \nнаходиться"), ("To_be_situated.png", "To be situated \nнаходиться", "Abroad/To_be_situated.mp3")},
                 {(15, "An island \nостров"), ("An_island.png", "An island \nостров", "Abroad/An_island.mp3")},
                 {(18, "To be separated from \nотделяться"), ("To_be_separated_from.png", "To be separated from \nотделяться", "Abroad/To_be_separated_from.mp3")},
                 {(19, "To border on \nграничить"), ("To_border_on.png", "To border on \nграничить", "Abroad/To_border_on.mp3")},
                 {(23, "The anthem \nгимн"), ("The_anthem.png", "The anthem \nгимн", "Abroad/The_anthem.mp3")},
                 {(24, "The currency \nвалюта"), ("The_currency.png", "The currency \nвалюта", "Abroad/The_currency.mp3")},
                 {(25, "The most densely populated \nнаиболее густо заселенный"), ("The_most_densely_populated.png", "The most densely populated \nнаиболее густо заселенный", "Abroad/The_most_densely_populated.mp3")},
                 {(26, "The surface \nповерхность"), ("The_surface.png", "The surface \nповерхность", "Abroad/The_surface.mp3")},
                 {(27, "To vary greatly \nсильно изменяться"), ("To_vary_greatly.png", "To vary greatly \nсильно изменяться", "Abroad/To_vary_greatly.mp3")},
                 {(28, "Mountainous \nгорный"), ("Mountainous.png", "Mountainous \nгорный", "Abroad/Mountainous.mp3")},
                 {(29, "To be called \nназываться"), ("To_be_called.png", "To be called \nназываться", "Abroad/To_be_called.mp3")},
                 {(30, "A vast plain \nширокая долина (равнина)"), ("Grassland_A_vast_plain.png", "A vast plain \nширокая долина (равнина)", "Abroad/A_vast_plain.mp3")},
                 {(31, "Important \nважный"), ("Important.png", "Important \nважный", "Abroad/Important.mp3")},
                 {(32, "To influence the climate \nвлиять на климат"), ("To_influence_the_climate.png", "To influence the climate \nвлиять на климат", "Abroad/To_influence_the_climate.mp3")},
                 {(33, "Mild \nмягкий"), ("Mild.png", "Mild \nмягкий", "Abroad/Mild.mp3")},
                 {(34, "Changeable \nизменчивая"), ("To_consist_of_Changeable.png", "Changeable \nизменчивая", "Abroad/Changeable.mp3")},
                 {(37, "The head of the state \nглава государства"), ("The_head_of_the_state.png", "The head of the state \nглава государства", "Abroad/The_head_of_the_State.mp3")},
                 {(38, "To rule \nуправлять"), ("To_rule.png", "To rule \nуправлять", "Abroad/To_rule.mp3")},
               


                 {(1, "das Haus \nдом"), ("Detached_house.jpg", "das Haus \nдом", "NemAud/Wohnomoglichleiten/das_Haus.mp3")},
                 {(2, "das Reihenhaus \nтаунхаус"), ("Terraced_house.jpg", "das Reihenhaus \nтаунхаус", "NemAud/Wohnomoglichleiten/das_Reihenhaus.mp3")},
                 {(3, "das Einfamilienhaus \nособняк"), ("Detached_house.jpg", "das Einfamilienhaus \nособняк", "NemAud/Wohnomoglichleiten/das_Einfamilienhaus.mp3")},
                 {(4, "das Mehrfamilienhaus \nмногоквартирный дом"), ("Block_of_flats.jpg", "das Mehrfamilienhaus \nмногоквартирный дом", "NemAud/Wohnomoglichleiten/das_Mehrfamilienhaus.mp3")},
                 {(5, "das Bauernhaus \nкрестьянский дом"), ("Cottage.jpg", "das Bauernhaus \nкрестьянский дом", "NemAud/Wohnomoglichleiten/das_Bauernhaus.mp3")},
                 {(7, "das Doppelfenster \nдвойное окно"), ("wind.jpg", "das Doppelfenster \nдвойное окно", "NemAud/Wohnomoglichleiten/das_Doppelfenster.mp3")},
                 {(8, "bevorzugen \nпредпочитать"), ("prefer.png", "bevorzugen \nпредпочитать", "NemAud/Wohnomoglichleiten/bevorzugen.mp3")},
                 {(9, "der Eingang \nвход"), ("Cottage.jpg", "der Eingang \nвход", "NemAud/Wohnomoglichleiten/der_Eingang.mp3")},
                 {(11, "ein eigenes Haus \nсобственный дом"), ("Bungalow.jpg", "ein eigenes Haus \nсобственный дом", "NemAud/Wohnomoglichleiten/ein_eigenes_Haus.mp3")},
                 {(12, "eine eigene Wohnung \nсобственная квартира"), ("Flat_Apartment.jpg", "eine eigene Wohnung \nсобственная квартира", "NemAud/Wohnomoglichleiten/eine_eigene_Wohnung.mp3")},
                 {(13, "das Eigentum \nимущество"), ("Own.png", "das Eigentum \nимущество", "NemAud/Wohnomoglichleiten/das_Eigentum.mp3")},
                 {(15, "der Fensterladen \nподоконник"), ("podok.jpg", "der Fensterladen \nподоконник", "NemAud/Wohnomoglichleiten/der_Fensterladen.mp3")},
                 {(16, "der Innenhof \nвнутренний двор"), ("dvor.jpg", "der Innenhof \nвнутренний двор", "NemAud/Wohnomoglichleiten/der_Innenhof.mp3")},
                 {(18, "die Ausbildungsmöglichkeit \nвозможность для получения образования"), ("guaranteed_right_to_education.jpg", "die Ausbildungsmöglichkeit \nвозможность для получения образования", "NemAud/Wohnomoglichleiten/die_Ausbildungsmoglichkeit.mp3")},
                 {(19, "die Einkaufsmöglichkeit \nвозможность совершать покупки"), ("receive.png", "die Einkaufsmöglichkeit \nвозможность совершать покупки", "NemAud/Wohnomoglichleiten/die_Einkaufsmoglichkeit.mp3")},
                 {(21, "die Sportmöglichkeit \nвозможность занятия спортом"), ("sport.png", "die Sportmöglichkeit \nвозможность занятия спортом", "NemAud/Wohnomoglichleiten/die_Sportmoglichkeit.mp3")},
                 {(22, "der Nachteil \nнедостаток"), ("nedost.png", "der Nachteil \nнедостаток", "NemAud/Wohnomoglichleiten/der_Nachteil.mp3")},
                 {(25, "die Treppe \nлестница"), ("ladder.jpg", "die Treppe \nлестница", "NemAud/Wohnomoglichleiten/die_Treppe.mp3")},
                 {(26, "idas Treppenhaus \nлестничная клетка"), ("Ladder_room.jpg", "idas Treppenhaus \nлестничная клетка", "NemAud/Wohnomoglichleiten/idas_Treppenhaus.mp3")},
                 {(27, "der Vorteil \nпереводчик"), ("translate.png", "der Vorteil \nпереводчик", "NemAud/Wohnomoglichleiten/der_Vorteil.mp3")},
                 {(28, "die Wohnatmosphäre \nатмосфера в квартире"), ("Flat_Apartment.jpg", "die Wohnatmosphäre \nатмосфера в квартире", "NemAud/Wohnomoglichleiten/die_Wohnatmosphare.mp3")},
                 {(29, "die Wohnfläche \nжилая площадь"), ("Flat_Apartment.jpg", "die Wohnfläche \nжилая площадь", "NemAud/Wohnomoglichleiten/die_Wohnflache.mp3")},
                 {(30, "mieten \nаренда"), ("Rent.png", "mieten \nаренда", "NemAud/Wohnomoglichleiten/mieten.mp3")},
                 {(31, "die Miete \nплата за аренду"), ("Rent.png", "die Miete \nплата за аренду", "NemAud/Wohnomoglichleiten/die_Miete.mp3")},
                 {(32, "zur Miete wohnen \nарендовать квартиру"), ("Flat_Apartment.jpg", "zur Miete wohnen \nарендовать квартиру", "NemAud/Wohnomoglichleiten/zur_Miete_wohnen.mp3")},
                 {(33, "zur Untermiete wohnen \nарендовать комнату"), ("Spacious.jpg", "zur Untermiete wohnen \nарендовать комнату", "NemAud/Wohnomoglichleiten/zur_Untermiete_wohnen.mp3")},
                 {(34, "der Mieter \nарендатор"), ("arentator.jpg", "der Mieter \nарендатор", "NemAud/Wohnomoglichleiten/der_Mieter.mp3")},
                 {(35, "vermieten \nсдавать в аренду"), ("Rent.png", "vermieten \nсдавать в аренду", "NemAud/Wohnomoglichleiten/vermieten.mp3")},
                 {(36, "der Vermieter \nарендодатель"), ("arentator.jpg", "der Vermieter \nарендодатель", "NemAud/Wohnomoglichleiten/der_Vermieter.mp3")},
                 {(37, "die Kosten \nрасходы"), ("fee.png", "die Kosten \nрасходы", "NemAud/Wohnomoglichleiten/die_Kosten.mp3")},
                 {(39, "die Ausstattung \nоборудование"), ("machine_building.png", "die Ausstattung \nоборудование", "NemAud/Wohnomoglichleiten/die_Ausstattung.mp3")},
                 {(40, "die Gemütlichkeit \nкомфорт"), ("Flat_Apartment.jpg", "die Gemütlichkeit \nкомфорт", "NemAud/Wohnomoglichleiten/die_Gemutlichkeit.mp3")},
                 {(41, "gemütlich \nкомфортно"), ("Carpet.jpg", "gemütlich \nкомфортно", "NemAud/Wohnomoglichleiten/gemutlich.mp3")},
                 {(43, "die Heizung \nутепление"), ("Central_heating.jpg", "die Heizung \nутепление", "NemAud/Wohnomoglichleiten/die_Heizung.mp3")},
                 {(44, "möblieren \nобставлять квартиру мебелью"), ("Flat_Apartment.jpg", "möblieren \nобставлять квартиру мебелью", "NemAud/Wohnomoglichleiten/moblieren.mp3")},
                 {(45, "das Poster \nплакат"), ("article.png", "das Poster \nплакат", "NemAud/Wohnomoglichleiten/das_Poster.mp3")},
                 {(46, "streichen \nрисовать"), ("paint.png", "streichen \nрисовать", "NemAud/Wohnomoglichleiten/streichen.mp3")},
                 {(49, "die Tapete \nобои"), ("wallpaper.png", "die Tapete \nобои", "NemAud/Wohnomoglichleiten/die_Tapete.mp3")},
                 {(50, "der Vorhang \nзанавески"), ("Curtains.jpg", "der Vorhang \nзанавески", "NemAud/Wohnomoglichleiten/der_Vorhang.mp3")},
                 {(51, "ausziehen \nвыезжать"), ("move.png", "ausziehen \nвыезжать", "NemAud/Wohnomoglichleiten/Ausziehen.mp3")},
                 {(52, "einziehen \nпереезжать"), ("move.png", "einziehen \nпереезжать", "NemAud/Wohnomoglichleiten/Einziehen.mp3")},
                 {(53, "in eine Wohnung / ein Haus einziehen \nпереезжать в квартиру/дом"), ("move.png", "in eine Wohnung/ein Haus einziehen \nпереезжать в квартиру/дом", "NemAud/Wohnomoglichleiten/in_eine_Wohnung_ein_Haus_einziehen.mp3")},
                 {(54, "umziehen \nпереехать"), ("move.png", "umziehen \nпереехать", "NemAud/Wohnomoglichleiten/umziehen.mp3")},





                 {(1, "außerschulisch \nвнешкольный"), ("citizen.jpg", "außerschulisch \nвнешкольный", "NemAud/Shulsystem/auberschulisch.mp3")},
                 {(2, "außerschulische Arbeit \nвнешкольная работа"), ("monitor.jpg", "außerschulische Arbeit \nвнешкольная работа", "NemAud/Shulsystem/auberschulische_Arbeit.mp3")},
                 {(4, "die allgemeinbildende Schule \nобщеобразовательная школа"), ("basic_school.jpg", "die allgemeinbildende Schule \nобщеобразовательная школа", "NemAud/Shulsystem/die_allgemeinbildende_Schule.mp3")},
                 {(5, "die Berufsschule \nпрофессиональная школа / профтехучилище"), ("sec_spec_educ.jpg", "die Berufsschule \nпрофессиональная школа / профтехучилище", "NemAud/Shulsystem/die_Berufsschule.mp3")},
                 {(6, "die Grundschule \nначальная школа"), ("primary_school.jpg", "die Grundschule \nначальная школа", "NemAud/Shulsystem/die_Grundschule.mp3")},
                 {(7, "das Gymnasium \nгимназия"), ("gymnasium.jpg", "das Gymnasium \nгимназия", "NemAud/Shulsystem/das_Gymnasium.mp3")},
                 {(8, "die Hauptschule \nбазовая школа"), ("basic_school.jpg", "die Hauptschule \nбазовая школа", "NemAud/Shulsystem/die_Hauptschule.mp3")},
                 {(9, "die Realschule \nреальная школа"), ("gen_sec_educ.jpg", "die Realschule \nреальная школа", "NemAud/Shulsystem/die_Realschule.mp3")},
                 {(10, "die Schulstufe \nступень (обучения)"), ("term.jpg", "die Schulstufe \nступень (обучения)", "NemAud/Shulsystem/die_Schulstufe.mp3")},
                 {(11, "die Grundstufe \nмладшие классы / 1-я ступень"), ("primary_school.jpg", "die Grundstufe \nмладшие классы / 1-я ступень", "NemAud/Shulsystem/die_Grundstufe.mp3")},
                 {(12, "die Mittelstufe \nклассы средней ступени / 2-я ступень"), ("sec_spec_educ.jpg", "die Mittelstufe \nклассы средней ступени / 2-я ступень", "NemAud/Shulsystem/die_Mittelstufe.mp3")},
                 {(13, "die Oberstufe \nстаршие классы / 3-я ступень"), ("higher_educ.jpg", "die Oberstufe \nстаршие классы / 3-я ступень", "NemAud/Shulsystem/die_Oberstufe.mp3")},
                 
                 {(16, "seinen Abschluss machen \nсдавать выпускные экзамены"), ("take_exams.jpg", "seinen Abschluss machen \nсдавать выпускные экзамены", "NemAud/Shulsystem/seinen_Abschluss_machen.mp3")},
                 {(17, "der Hauptschulabschluss \nсвидетельство об окончании базовой школы"), ("atest.jpg", "der Hauptschulabschluss \nсвидетельство об окончании базовой школы", "NemAud/Shulsystem/der_Hauptschulabschluss.mp3")},
                 {(18, "der Schulbeginn \nначало учебного года"), ("start_school.jpg", "der Schulbeginn \nначало учебного года", "NemAud/Shulsystem/der_Schulbeginn.mp3")},
                 {(19, "das Halbjahr \nполугодие"), ("term.jpg", "das Halbjahr \nполугодие", "NemAud/Shulsystem/das_Halbjahr.mp3")},
                 {(20, "das Viertel \nчетверть"), ("term.jpg", "das Viertel \nчетверть", "NemAud/Shulsystem/das_Viertel.mp3")},
                 {(21, "das Schulfach \nучебный предмет"), ("subject.png", "das Schulfach \nучебный предмет", "NemAud/Shulsystem/das_Schulfach.mp3")},
                 {(24, "das Wahlfach \nобязательный предмет по выбору"), ("subject.png", "das Wahlfach \nобязательный предмет по выбору", "NemAud/Shulsystem/das_Wahlfach.mp3")},
                 {(27, "erfolgreich \nуспешный / успешно"), ("successfuly.png", "erfolgreich \nуспешный / успешно", "NemAud/Shulsystem/erfolgreich.mp3")},
                 {(28, "die Klassenarbeit \nконтрольная работа"), ("gen_sec_educ.jpg", "die Klassenarbeit \nконтрольная работа", "NemAud/Shulsystem/die_Klassenarbeit.mp3")},
                 {(29, "sich auf die Klassenarbeit vorbereiten \nподготовиться к контрольной работе"), ("gen_sec_educ.jpg", "sich auf die Klassenarbeit vorbereiten \nподготовиться к контрольной работе", "NemAud/Shulsystem/sich_auf_die_Klassenarbeit_vorbereiten.mp3")},
                 {(30, "die Leistung \nуспех / достижение / успеваемость"), ("successfuly.png", "die Leistung \nуспех / достижение / успеваемость", "NemAud/Shulsystem/die_Leistung.mp3")},
                 {(31, "die Prüfung \nэкзамен"), ("take_exams.jpg", "die Prüfung \nэкзамен", "NemAud/Shulsystem/die_Prufung.mp3")},
                 {(32, "eine Prüfung ablegen \nсдавать экзамен"), ("take_exams.jpg", "eine Prüfung ablegen \nсдавать экзамен", "NemAud/Shulsystem/eine_Prufung_ablegen.mp3")},
                 {(36, "die Aufnahmeprüfung \nприёмный экзамен"), ("take_exams.jpg", "die Aufnahmeprüfung \nприёмный экзамен", "NemAud/Shulsystem/die_Aufnahmeprufung.mp3")},
                 {(37, "lösen \nрешать"), ("part_time.jpg", "lösen \nрешать", "NemAud/Shulsystem/losen.mp3")},
                 {(39, "die Verantwortung \nответственность"), ("otvets.jpg", "die Verantwortung \nответственность", "NemAud/Shulsystem/die_Verantwortung.mp3")},
                 {(40, "die Verantwortung übernehmen \nбрать ответственность"), ("otvets.jpg", "die Verantwortung übernehmen \nбрать ответственность", "NemAud/Shulsystem/die_Verantwortung_uernehmen.mp3")},
                 {(41, "das Zeugnis \nсвидетельство / удостоверение / справка"), ("atest.jpg", "das Zeugnis \nсвидетельство / удостоверение / справка", "NemAud/Shulsystem/das_Zeugnis.mp3")},
                 {(42, "das Abschlusszeugnis \nаттестат об окончании средней школы"), ("atest.jpg", "das Abschlusszeugnis \nаттестат об окончании средней школы", "NemAud/Shulsystem/das_Abschlusszeugnis.mp3")},
                 {(43, "das Reifezeugnis / das Abiturzeugnis \nаттестат об окончании школы (ІІІ ступень обучения в Германии)"), ("atest.jpg", "das Reifezeugnis / das Abiturzeugnis \nаттестат об окончании школы (ІІІ ступень обучения в Германии)", "NemAud/Shulsystem/das_Reifezeugnis_das_Abiturzeugnis.mp3")},
                 {(44, "das Zeugnis der mittleren Reife \nсвидетельство об окончании неполной средней школы"), ("atest.jpg", "das Zeugnis der mittleren Reife \nсвидетельство об окончании неполной средней школы", "NemAud/Shulsystem/das_Zeugnis_der_mittleren_Reife.mp3")},




                 {(1, "benutsen / nutsen \nиспользовать"), ("use.png", "benutsen / nutsen \nиспользовать", "NemAud/Messenmedien/benutsen_nutsen.mp3")},
                 {(3, "das Fernsehen bevorzugen \nотдавать предпочтение телевиденью"), ("commercial.png", "das Fernsehen bevorzugen \nотдавать предпочтение телевиденью", "NemAud/Messenmedien/das_Fernsehen_bevorzugen.mp3")},
                 {(4, "das Medium \nСМИ"), ("smi.png", "das Medium \nСМИ", "NemAud/Messenmedien/das_Medium.mp3")},
                 {(5, "elektronische / audiovisuelle Medien / printmedian \nэлектронные / аудиовизуальные / печатные СМИ"), ("smi.png", "elektronische / audiovisuelle Medien / printmedian \nэлектронные / аудиовизуальные / печатные СМИ", "NemAud/Messenmedien/elektronische_audiovisuelle_Medien_printmedian.mp3")},
                 {(7, "regional \nрегиональный"), ("current_affairs.png", "regional \nрегиональный", "NemAud/Messenmedien/regional.mp3")},
                 {(8, "lokal \nместный"), ("current_affairs.png", "lokal \nместный", "NemAud/Messenmedien/lokal.mp3")},
                 {(9, "die Zeitschrift \nжурнал"), ("sensational.png", "die Zeitschrift \nжурнал", "NemAud/Messenmedien/die_Zeitschrift.mp3")},
                 {(10, "das Nachrichtenmagazin \nинформационный журнал"), ("front_page.png", "das Nachrichtenmagazin \nинформационный журнал", "NemAud/Messenmedien/das_Nachrichtenmagazin.mp3")},
                 {(12, "die Anzeige \nобъявление (в газете)"), ("make_headlines.jpg", "die Anzeige \nобъявление (в газете)", "NemAud/Messenmedien/die_Anzeige.mp3")},
                 {(13, "der Artikel \nстатья"), ("broadsheet.jpg", "der Artikel \nстатья", "NemAud/Messenmedien/der_Artikel.mp3")},
                 {(14, "der Bericht \nсообщение / рассказ"), ("broadcast.png", "der Bericht \nсообщение / рассказ", "NemAud/Messenmedien/der_Bericht.mp3")},
                 {(15, "das Ereignis \nсобытие"), ("event.png", "das Ereignis \nсобытие", "NemAud/Messenmedien/das_Ereignis.mp3")},
                 {(16, "das Interview \nинтервью"), ("interview.png", "das Interview \nинтервью", "NemAud/Messenmedien/das_Interview.mp3")},
                 {(17, "der Kommentar \nкомментарий"), ("comment.png", "der Kommentar \nкомментарий", "NemAud/Messenmedien/der_Kommentar.mp3")},
                 {(18, "der Leserbrief \nписьмо читателя"), ("headline.png", "der Leserbrief \nписьмо читателя", "NemAud/Messenmedien/der_Leserbrief.mp3")},
                 {(19, "die Nachricht \nсообщение / известие"), ("broadcast.png", "die Nachricht \nсообщение / известие", "NemAud/Messenmedien/die_Nachricht.mp3")},
                 {(20, "die Tatsache \nфакт"), ("fact.png", "die Tatsache \nфакт", "NemAud/Messenmedien/die_Tatsache.mp3")},
                 {(23, "eine Umfrage durchfuhren \nпроводить опрос"), ("quiz_show.png", "eine Umfrage durchfuhren \nпроводить опрос", "NemAud/Messenmedien/eine_Umfrage_durchfuhren.mp3")},
                 {(24, "die Werbung \nреклама"), ("advertisement.png", "die Werbung \nреклама", "NemAud/Messenmedien/die_Werbung.mp3")},
                 {(27, "die Schlagzeile \nкрупный заголовок"), ("make_headlines.jpg", "die Schlagzeile \nкрупный заголовок", "NemAud/Messenmedien/die_Schlagzeile.mp3")},
                 {(29, "die Titelseite \nтитульная страница"), ("broadsheet.jpg", "die Titelseite \nтитульная страница", "NemAud/Messenmedien/die_Titelseite.mp3")},
                 {(30, "die Zeile \nстрока"), ("article.png", "die Zeile \nстрока", "NemAud/Messenmedien/die_Zeile.mp3")},
                 {(31, "berichten \nсообщать / рассказывать"), ("broadcast.png", "berichten \nсообщать / рассказывать", "NemAud/Messenmedien/berichten.mp3")},
                 {(32, "informieren jemanden (Akk.) uber etwas (Akk.) \nинформировать кого-либо о чём-либо"), ("broadcast.png", "informieren jemanden (Akk.) uber etwas (Akk.) \nинформировать кого-либо о чём-либо", "NemAud/Messenmedien/informieren_jemanden_uber_etwas.mp3")},
                 {(33, "kritisieren \nкритиковать"), ("disadvantage.png", "kritisieren \nкритиковать", "NemAud/Messenmedien/kritisieren.mp3")},
                 {(35, "abonnieren \nподписываться"), ("advantage.png", "abonnieren \nподписываться", "NemAud/Messenmedien/abonnieren.mp3")},
                 {(37, "behandeln \nобсуждать"), ("influence.png", "behandeln \nобсуждать", "NemAud/Messenmedien/behandeln.mp3")},
                 {(38, "durchblattern \nперелистывать"), ("left.png", "durchblattern \nперелистывать", "NemAud/Messenmedien/durchblattern.mp3")},
                 {(39, "herausgeben \nвыпускать / издавать (газету)"), ("broadsheet.jpg", "herausgeben \nвыпускать / издавать (газету)", "NemAud/Messenmedien/herausgeben.mp3")},
                 {(41, "das Fernsehen \nтелевидение"), ("satellite_tv.png", "das Fernsehen \nтелевидение", "NemAud/Messenmedien/das_Fernsehen.mp3")},
                 {(42, "die Sendung \nпередача"), ("cartoon.png", "die Sendung \nпередача", "NemAud/Messenmedien/die_Sendung.mp3")},
                 {(43, "die Quizsendung \n(теле)викторина"), ("quiz_show.png", "die Quizsendung \n(теле)викторина", "NemAud/Messenmedien/die_Quizsendung.mp3")},
                 {(44, "die Unterhaltungssendung \nразвлекательная передача"), ("comedy.png", "die Unterhaltungssendung \nразвлекательная передача", "NemAud/Messenmedien/die_Unterhaltungssendung.mp3")},
                 {(45, "die Informationssendung \nинформационная передача"), ("info.png", "die Informationssendung \nинформационная передача", "NemAud/Messenmedien/die_Informationssendung.mp3")},
               


                 {(1, "die Kunst \nискусство"), ("die_Kunst.png", "die Kunst \nискусство", "NemAud/Kunst_und_Kunstler/die_Kunst.mp3")},
                 {(3, "zeitgenssische Kunst / moderne Kunst \nсовременное искусство"), ("Tag.png", "zeitgenssische Kunst / moderne Kunst \nсовременное искусство", "NemAud/Kunst_und_Kunstler/zeitgen_ssische_Kunstmoderne_Kunst.mp3")},
                 {(4, "kunstlerisch \nхудожественный"), ("Landmark.png", "kunstlerisch \nхудожественный", "NemAud/Kunst_und_Kunstler/kunstlerisch.mp3")},
                 {(5, "der Kunstler \nхудожник"), ("Artist_Painter.png", "der Kunstler \nхудожник", "NemAud/Kunst_und_Kunstler/der_Kunstler.mp3")},
                 {(6, "die Malerei \nживопись"), ("Landmark.png", "die Malerei \nживопись", "NemAud/Kunst_und_Kunstler/die_Malerei.mp3")},
                 {(8, "die Baukunst \nархитектура"), ("Architecture.png", "die Baukunst \nархитектура", "NemAud/Kunst_und_Kunstler/die_Baukunst.mp3")},
                 {(9, "der Bildhauer \nскульптор"), ("Sculptor.png", "der Bildhauer \nскульптор", "NemAud/Kunst_und_Kunstler/der_Bildhauer.mp3")},
                 {(10, "die Skulptur \nскульптурa"), ("Sculpture.png", "die Skulptur \nскульптурa", "NemAud/Kunst_und_Kunstler/die_Skulptur.mp3")},
                 {(11, "das Stillleben \nнатюрморт"), ("Natur.png", "das Stillleben \nнатюрморт", "NemAud/Kunst_und_Kunstler/das_Stillleben.mp3")},
                 {(12, "das Bildnis / das Portr \nпортрет"), ("Piece_of_art.png", "das Bildnis / das Portr \nпортрет", "NemAud/Kunst_und_Kunstler/das_Bildnis_das_Portr.mp3")},
                 {(13, "das Selbstbildnis \nавтопортрет"), ("Piece_of_art.png", "das Selbstbildnis \nавтопортрет", "NemAud/Kunst_und_Kunstler/das_Selbstbildnis.mp3")},
                 {(14, "die Zeichnung \nрисунок / чертёж"), ("BP.png", "die Zeichnung \nрисунок / чертёж", "NemAud/Kunst_und_Kunstler/die_Zeichnung.mp3")},
                 {(18, "darstellen \nизображать / представлять"), ("Visual.png", "darstellen \nизображать / представлять", "NemAud/Kunst_und_Kunstler/darstellen.mp3")},
                 {(20, "entwerfen \nделать набросок"), ("delat.png", "entwerfen \nделать набросок", "NemAud/Kunst_und_Kunstler/entwerfen.mp3")},
                 {(21, "der Entwurf / die Skizze \nэскиз / набросок"), ("eskiz.png", "der Entwurf / die Skizze \nэскиз / набросок", "NemAud/Kunst_und_Kunstler/der_Entwurf_die_Skizze.mp3")},
                 {(22, "durchsichtig \nпрозрачный"), ("prozrach.png", "durchsichtig \nпрозрачный", "NemAud/Kunst_und_Kunstler/durchsichtig.mp3")},
                 {(23, "der Eindruck / Eindrucke \nвпечатление"), ("Impress.png", "der Eindruck / Eindrucke \nвпечатление", "NemAud/Kunst_und_Kunstler/der_Eindruck_Eindrucke.mp3")},
                 {(25, "wirken auf jemanden / etwas (Akk.) \nвлиять на кого-либо / что-либо"), ("influence.png", "wirken auf jemanden / etwas (Akk.) \nвлиять на кого-либо / что-либо", "NemAud/Kunst_und_Kunstler/wirken_auf_jemanden_etwas.mp3")},
                 {(26, "die Wirkung \nвлияние"), ("influence.png", "die Wirkung \nвлияние", "NemAud/Kunst_und_Kunstler/die_Wirkung.mp3")},
                 {(27, "ausstellen \nвыставлять"), ("post.png", "ausstellen \nвыставлять", "NemAud/Kunst_und_Kunstler/ausstellen.mp3")},
                 {(28, "die Ausstellung \nвыставка"), ("Exhibition.png", "die Ausstellung \nвыставка", "NemAud/Kunst_und_Kunstler/die_Ausstellung.mp3")},
                 {(29, "in der Ausstellung \nна выставке"), ("Exhibition.png", "in der Ausstellung \nна выставке", "NemAud/Kunst_und_Kunstler/in_der_Ausstellung.mp3")},
                 {(30, "die Gemäldegalerie \nкартинная галерея"), ("Exhibition.png", "die Gemäldegalerie \nкартинная галерея", "NemAud/Kunst_und_Kunstler/die_Gemaldegalerie.mp3")},
                 {(32, "die Bildersammlung / die Gemaldesammlung \nколлекция картин"), ("gal.png", "die Bildersammlung / die Gemaldesammlung \nколлекция картин", "NemAud/Kunst_und_Kunstler/die_Bildersammlung_die_Gemaldesammlung.mp3")},
                 {(33, "die Farbe \nкраска"), ("Oil_painting.png", "die Farbe \nкраска", "NemAud/Kunst_und_Kunstler/die_Farbe.mp3")},
                 {(34, "die Flache \nповерхность"), ("Mural_Writer.png", "die Flache \nповерхность", "NemAud/Kunst_und_Kunstler/die_Flache.mp3")},
                 {(35, "hart \nтвёрдый"), ("solid.png", "hart \nтвёрдый", "NemAud/Kunst_und_Kunstler/hart.mp3")},
                 {(36, "weich \nмягкий"), ("handi.png", "weich \nмягкий", "NemAud/Kunst_und_Kunstler/weich.mp3")},
                 {(37, "gerade \nпрямой"), ("rovn.png", "gerade \nпрямой", "NemAud/Kunst_und_Kunstler/gerade.mp3")},
                 {(38, "schief \nнаклонный"), ("krivoi.png", "schief \nнаклонный", "NemAud/Kunst_und_Kunstler/schief.mp3")},
                 {(39, "glatt \nровный"), ("rovn.png", "glatt \nровный", "NemAud/Kunst_und_Kunstler/glatt.mp3")},
                 {(40, "das Material \nматериал"), ("mat.png", "das Material \nматериал", "NemAud/Kunst_und_Kunstler/das_Material.mp3")},
                 {(41, "die Leinwand \nхолст"), ("canv.png", "die Leinwand \nхолст", "NemAud/Kunst_und_Kunstler/die_Leinwand.mp3")},


                 {(1, "die Jugend \nмолодёжь / молодость"), ("die_Jugend.png", "die Jugend \nмолодёжь / молодость", "NemAud/Jug/die_Jugend.mp3")},
                 {(2, "unabhängig \nнезависимый"), ("unabhangig.png", "unabhängig \nнезависимый", "NemAud/Jug/unabhangig.mp3")},
                 {(3, "gleichgültig \nравнодушный"), ("gleichgultig.png", "gleichgültig \nравнодушный", "NemAud/Jug/gleichgultig.mp3")},
                 {(4, "jung \nмолодой"), ("die_Jugend.png", "jung \nмолодой", "NemAud/Jug/jung.mp3")},
                 {(5, "launisch \nкапризный / своенравный"), ("launisch.png", "launisch \nкапризный / своенравный", "NemAud/Jug/launisch.mp3")},
                 {(6, "neugierig \nлюбопытный"), ("neugierig.png", "neugierig \nлюбопытный", "NemAud/Jug/neugierig.mp3")},
                 {(7, "selbstbewusst \nсамоуверенный"), ("selbstbewusst.png", "selbstbewusst \nсамоуверенный", "NemAud/Jug/selbstbewusst.mp3")},
                 {(8, "sorglos \nбеззаботный"), ("sorglos.jpg", "sorglos \nбеззаботный", "NemAud/Jug/sorglos.mp3")},
                 {(9, "stolz \nгордый"), ("stolz.png", "stolz \nгордый", "NemAud/Jug/stolz.mp3")},
                 {(10, "selbstsicher \nуверенный"), ("selbstbewusst.png", "selbstsicher \nуверенный", "NemAud/Jug/selbstsicher.mp3")},
                 {(12, "unsicher \nнеуверенный"), ("unsicher.png", "unsicher \nнеуверенный", "NemAud/Jug/unsicher.mp3")},
                 {(17, "verwohnt \nизбалованный"), ("verwohnt.jpg", "verwohnt \nизбалованный", "NemAud/Jug/verwohnt.mp3")},
                 {(21, "sich engagieren \nобязываться что-либо сделать / участвовать"), ("sich_engagieren.jpg", "sich engagieren \nобязываться что-либо сделать / участвовать", "NemAud/Jug/sich_engagieren.mp3")},
                 {(24, "der / die Erwachsene \nвзрослый / взрослая"), ("der_die_Erwachsene.png", "der / die Erwachsene \nвзрослый / взрослая", "NemAud/Jug/der_die_Erwachsene.mp3")},
                 {(25, "gesellschaftlich \nобщественный"), ("Society.png", "gesellschaftlich \nобщественный", "NemAud/Jug/gesellschaftlich.mp3")},
                 {(27, "handeln \nдействовать"), ("To_reach.png", "handeln \nдействовать", "NemAud/Jug/handeln.mp3")},
                 {(29, "freiwillig \nдобровольный"), ("Volunteer.png", "freiwillig \nдобровольный", "NemAud/Jug/freiwillig.mp3")},
                 {(30, "gemeinsam \nвместе / совместно"), ("Involve.png", "gemeinsam \nвместе / совместно", "NemAud/Jug/gemeinsam.mp3")},
                 {(31, "das Mitglied \nчлен (организации)"), ("Member.png", "das Mitglied \nчлен (организации)", "NemAud/Jug/das_Mitglied.mp3")},
                 {(32, "der Verband \nсоюз / общество"), ("Society.png", "der Verband \nсоюз / общество", "NemAud/Jug/der_Verband.mp3")},
                 {(34, "die Aktion \nдействие / акция"), ("die_Aktion.png", "die Aktion \nдействие / акция", "NemAud/Jug/die_Aktion.mp3")},
                 {(35, "arm \nбедный"), ("arm.png", "arm \nбедный", "NemAud/Jug/arm.mp3")},
                 {(37, "das Rote Kreuz \nкрасный крест"), ("das_Rote_Kreuz.jpg", "das Rote Kreuz \nкрасный Крест", "NemAud/Jug/das_Rote_Kreuz.mp3")},
                 {(41, "die Verwirklichung \nосуществление"), ("die_Verwirklichung.png", "die Verwirklichung \nосуществление", "NemAud/Jug/die_Verwirklichung.mp3")},
                 {(44, "die Ehre \nчесть"), ("die_Ehre.png", "die Ehre \nчесть", "NemAud/Jug/die_Ehre.mp3")},
                 {(46, "erziehen \nвоспитывать"), ("erziehen.png", "erziehen \nвоспитывать", "NemAud/Jug/erziehen.mp3")},
                 
                 {(51, "die Forderung \nтребование"), ("die_Forderung.png", "die Forderung \nтребование", "NemAud/Jug/die_Forderung.mp3")},
                 {(52, "hoffen auf jemanden / etwas (Akk.) \nнадеяться на (кого-либо / что-либо)"), ("hoffen_auf_jemanden_etwas.png", "hoffen auf jemanden / etwas (Akk.) \nнадеяться на (кого-либо / что-либо)", "NemAud/Jug/hoffen_auf_jemanden_etwas.mp3")},
                 {(54, "verbinden \nсоединять / связывать"), ("verbinden.png", "verbinden \nсоединять / связывать", "NemAud/Jug/verbinden.mp3")},

                 
                 {(2, "entwickeln \nразрабатывать / развивать"), ("advanced.png", "entwickeln \nразрабатывать / развивать", "NemAud/Wiss/entwickeln.mp3")},
                 {(3, "forschen / erforschen \nисследовать что-либо"), ("explore.png", "forschen / erforschen \nисследовать что-либо", "NemAud/Wiss/forschen_erforschen.mp3")},
                 {(5, "der Forscher / der Erforscher \nисследователь"), ("explorer.png", "der Forscher / der Erforscher \nисследователь", "NemAud/Wiss/der_Forscher_der_Erforscher.mp3")},
                 {(7, "das Wissen \nзнаниe / познания"), ("discovery.png", "das Wissen \nзнаниe / познания", "NemAud/Wiss/das_Wissen.mp3")},
                 {(8, "die Wissenschaft \nнаука"), ("science.png", "die Wissenschaft \nнаука", "NemAud/Wiss/die_Wissenschaft.mp3")},
                 {(9, "die Naturwissenschaft \nестествознание"), ("ecology.png", "die Naturwissenschaft \nестествознание", "NemAud/Wiss/die_Naturwissenschaft.mp3")},
                 {(11, "der Wissenschaftler \nучёный"), ("scientist.png", "der Wissenschaftler \nучёный", "NemAud/Wiss/der_Wissenschaftler.mp3")},
                 {(13, "die Arbeit \nтруд / работа"), ("century.png", "die Arbeit \nтруд / работа", "NemAud/Wiss/die_Arbeit.mp3")},
                 {(14, "geistige Arbeit \nумственный труд"), ("brain.png", "geistige Arbeit \nумственный труд", "NemAud/Wiss/geistige_Arbeit.mp3")},
                 {(15, "korperliche Arbeit \nфизический труд"), ("century.png", "korperliche Arbeit \nфизический труд", "NemAud/Wiss/korperliche_Arbeit.mp3")},
                 {(19, "durchschnittlich \nсредний / в среднем"), ("medium.png", "durchschnittlich \nсредний / в среднем", "NemAud/Wiss/durchschnittlich.mp3")},
                 {(21, "das Gerat \nприбор"), ("machine_building.png", "das Gerat \nприбор", "NemAud/Wiss/das_Gerat.mp3")},
                 {(22, "die Messe \nярмарка"), ("fair.png", "die Messe \nярмарка", "NemAud/Wiss/die_Messe.mp3")},
                 {(25, "verbessern \nулучшать"), ("highly_developed.png", "verbessern \nулучшать", "NemAud/Wiss/verbessern.mp3")},
                 {(26, "der Fortschritt \nпрогресс"), ("progress.png", "der Fortschritt \nпрогресс", "NemAud/Wiss/der_Fortschritt.mp3")},
                 {(28, "die Folge \nследствие / последствие"), ("technology.png", "die Folge \nследствие / последствие", "NemAud/Wiss/die_Folge.mp3")},
                 {(29, "entdecken \nоткрывать / обнаруживать"), ("research.png", "entdecken \nоткрывать / обнаруживать", "NemAud/Wiss/entdecken.mp3")},
                 {(32, "erfinden \nизобретать"), ("invent.png", "erfinden \nизобретать", "NemAud/Wiss/erfinden.mp3")},
                 {(33, "die Erfindung \nизобретение"), ("invention.png", "die Erfindung \nизобретение", "NemAud/Wiss/die_Erfindung.mp3")},
                 {(34, "der Erfinder \nизобретатель"), ("inventor.png", "der Erfinder \nизобретатель", "NemAud/Wiss/der_Erfinder.mp3")},
                 {(36, "flexibel \nгибкий"), ("Flexible.png", "flexibel \nгибкий", "NemAud/Wiss/flexibel.mp3")},
                 {(37, "grundlegend \nосновной / основополагающий"), ("mm.png", "grundlegend \nосновной / основополагающий", "NemAud/Wiss/grundlegend.mp3")},
                 {(38, "grunden \nсоздавать / основывать"), ("digital.png", "grunden \nсоздавать / основывать", "NemAud/Wiss/grunden.mp3")},
                 {(39, "die Produktion \nпроизводство / продукция"), ("device.png", "die Produktion \nпроизводство / продукция", "NemAud/Wiss/die_Produktion.mp3")},
                 {(40, "das Kraftwerk \nэлектростанция"), ("reactor.png", "das Kraftwerk \nэлектростанция", "NemAud/Wiss/das_Kraftwerk.mp3")},
                 {(41, "das Atomkraftwerk \nатомная электростанция"), ("pp.png", "das Atomkraftwerk \nатомная электростанция", "NemAud/Wiss/das_Atomkraftwerk.mp3")},
                 {(42, "die Technologie \nтехнология"), ("development.png", "die Technologie \nтехнология", "NemAud/Wiss/die_Technologie.mp3")},
                 {(44, "umweltschonend \nне наносящий вреда окружающей среде"), ("famine.png", "umweltschonend \nне наносящий вреда окружающей среде", "NemAud/Wiss/umweltschonend.mp3")},
                 {(45, "der Weltraum \nкосмос"), ("galaxy.png", "der Weltraum \nкосмос", "NemAud/Wiss/der_Weltraum.mp3")},
                 {(46, "der Weltraumflug \nполёт в космос"), ("startup.png", "der Weltraumflug \nполёт в космос", "NemAud/Wiss/der_Weltraumflug.mp3")},
                 {(47, "das Windrad \nветряк"), ("windmill.png", "das Windrad \nветряк", "NemAud/Wiss/das_Windrad.mp3")},
                 {(50, "der Preis \nнаграда / премия"), ("grant_stip.jpg", "der Preis \nнаграда / премия", "NemAud/Wiss/der_Preis.mp3")},
                 {(51, "der Nobelpreis \nнобелевская премия"), ("nobel.png", "der Nobelpreis \nнобелевская премия", "NemAud/Wiss/der_Nobelpreis.mp3")},
                 {(53, "die Tatigkeit \nдеятельность"), ("researcher.png", "die Tatigkeit \nдеятельность", "NemAud/Wiss/die_Tatigkeit.mp3")},
                 {(54, "das Vorbild \nпример / образец"), ("example.png", "das Vorbild \nпример / образец", "NemAud/Wiss/das_Vorbild.mp3")},
                 {(55, "die Gegenwart \nнастоящее"), ("life_.png", "die Gegenwart \nнастоящее", "NemAud/Wiss/die_Gegenwart.mp3")},
                 {(56, "das Jahrhundert \nстолетие"), ("century.png", "das Jahrhundert \nстолетие", "NemAud/Wiss/das_Jahrhundert.mp3")},
                 {(57, "das Jahrtausend \nтысячелетие"), ("mill.jpg", "das Jahrtausend \nтысячелетие", "NemAud/Wiss/das_Jahrtausend.mp3")},
                 {(58, "das Jahrzehnt \nдесятилетие"), ("ten.png", "das Jahrzehnt \nдесятилетие", "NemAud/Wiss/das_Jahrhundert.mp3")},
                 {(59, "die Vergangenheit \nпрошлое"), ("century.png", "die Vergangenheit \nпрошлое", "NemAud/Wiss/die_Vergangenheit.mp3")},
                 {(60, "die Zukunft \nбудущее"), ("high_tech.png", "die Zukunft \nбудущее", "NemAud/Wiss/die_Zukunft.mp3")},



                {(1, "ausüben \nисполнять / совершать"), ("app.png", "ausüben \nисполнять / совершать", "NemAud/Berufswahl/ausuben.mp3")},
                {(2, "einen Beruf ausüben \nзаниматься чем-либо / иметь профессию"), ("br_mind.png", "einen Beruf ausüben \nзаниматься чем-либо / иметь профессию", "NemAud/Berufswahl/einen_Beruf_ausuben.mp3")},
                {(3, "bebauen \nвозделывать / обрабатывать"), ("Soil.png", "bebauen \nвозделывать / обрабатывать", "NemAud/Berufswahl/bebauen.mp3")},
                {(4, "bedienen \nобслуживать"), ("Controlled.png", "bedienen \nобслуживать", "NemAud/Berufswahl/bedienen.mp3")},
                {(13, "reparieren \nремонтировать"), ("repair.png", "reparieren \nремонтировать", "NemAud/Berufswahl/reparieren.mp3")},
                {(14, "unterhalten \nразвлекать"), ("Carpenter.png", "unterhalten \nразвлекать", "NemAud/Berufswahl/unterhalten.mp3")},
                {(15, "untersuchen \nисследовать"), ("exploration.png", "untersuchen \nисследовать", "NemAud/Berufswahl/untersuchen.mp3")},
                {(17, "die Begabung \nодаренность / талант"), ("Unique.png", "die Begabung \nодаренность / талант", "NemAud/Berufswahl/die_Begabung.mp3")},
                {(18, "beweglich \nподвижный"), ("Contemporary.png", "beweglich \nподвижный", "NemAud/Berufswahl/beweglich.mp3")},
                {(21, "die Fähigkeit \nспособность / умение"), ("Flexible.png", "die Fähigkeit \nспособность / умение", "NemAud/Berufswahl/die_Fahigkeit.mp3")},
                {(22, "die Geschicklichkeit \nловкость"), ("Flexible.png", "die Geschicklichkeit \nловкость", "NemAud/Berufswahl/die_Geschicklichkeit.mp3")},
                {(23, "die Gewissenhaftigkeit \nдобросовестность"), ("Honest.png", "die Gewissenhaftigkeit \nдобросовестность", "NemAud/Berufswahl/die_Gewissenhaftigkeit.mp3")},
                {(24, "die Kommunikationsfähigkeit \nумение общаться"), ("Talkative.png", "die Kommunikationsfähigkeit \nумение общаться", "NemAud/Berufswahl/die_Kommunikationsfahigkeit.mp3")},
                {(25, "die Konzentrationsfähigkeit \nумение сосредоточиваться"), ("selbstbewusst.png", "die Konzentrationsfähigkeit \nумение сосредоточиваться", "NemAud/Berufswahl/die_Konzentrationsfahigkeit.mp3")},
                {(26, "die Kontaktfähigkeit \nспособность устанавливать контакт"), ("Plough_through_something.jpg", "die Kontaktfähigkeit \nспособность устанавливать контакт", "NemAud/Berufswahl/die_Kontaktfahigkeit.mp3")},
                {(27, "die Leistungsfähigkeit \nработоспособность"), ("Work_as.jpg", "die Leistungsfähigkeit \nработоспособность", "NemAud/Berufswahl/die_Leistungsfahigkeit.mp3")},
                {(33, "die Zuverlässigkeit \nнадежность"), ("To_protect.png", "die Zuverlässigkeit \nнадежность", "NemAud/Berufswahl/die_Zuverlassigkeit.mp3")},
                {(34, "die Flexibilität \nгибкость / приспособляемость"), ("Flexible.png", "die Flexibilität \nгибкость / приспособляемость", "NemAud/Berufswahl/die_Flexibilitat.mp3")},
                {(35, "geschickt \nискусный / ловкий"), ("Flexible.png", "geschickt \nискусный / ловкий", "NemAud/Berufswahl/geschickt.mp3")},
                {(36, "geschickte Hände \nумелые руки"), ("hand.png", "geschickte Hände \nумелые руки", "NemAud/Berufswahl/geschickte_Hande.mp3")},
                {(38, "kräftig \nсильный"), ("Strength.png", "kräftig \nсильный", "NemAud/Berufswahl/kraftig.mp3")},
                {(39, "die Kraft \nсила"), ("Strength.png", "die Kraft \nсила", "NemAud/Berufswahl/die_Kraft.mp3")},
                {(40, "schöpferisch / kreativ \nтворческий"), ("kr.png", "schöpferisch / kreativ \nтворческий", "NemAud/Berufswahl/schopferisch_kreativ.mp3")},
                {(41, "die Kreativität \nтворчество"), ("die_Kunst.png", "die Kreativität \nтворчество", "NemAud/Berufswahl/die_Kreativitat.mp3")},
                {(42, "sprachbegabt \nспособный к языкам"), ("Talkative.png", "sprachbegabt \nспособный к языкам", "NemAud/Berufswahl/sprachbegabt.mp3")},
                {(45, "umgehen / etwas (Dat.) \nобращаться с чем-либо"), ("Talkative.png", "umgehen / etwas (Dat.) \nобращаться с чем-либо", "NemAud/Berufswahl/umgehen_etwas.mp3")},
                {(49, "ausbilden \nобучать"), ("compl_sec_educ.jpg", "ausbilden \nобучать", "NemAud/Berufswahl/ausbilden.mp3")},
                {(51, "sich bewerben um etw. (Akk.) \nподавать заявление о"), ("Outgoing.png", "sich bewerben um etw. (Akk.) \nподавать заявление о", "NemAud/Berufswahl/sich_bewerben_um_etw.mp3")},
                {(54, "der Bereich \nсфера / область"), ("In_the_field_of.jpg", "der Bereich \nсфера / область", "NemAud/Berufswahl/der_Bereich.mp3")},
                {(57, "eine Prüfung ablegen \nсдавать экзамен"), ("take_exams.jpg", "eine Prüfung ablegen \nсдавать экзамен", "NemAud/Berufswahl/eine_Prufung_ablegen.mp3")},
                {(59, "die Abschlussprüfung \nвыпускной экзамен"), ("pass_exams.jpg", "die Abschlussprüfung \nвыпускной экзамен", "NemAud/Berufswahl/die_Abschlussprufung.mp3")},
                {(60, "abschließen \nзаканчивать"), ("first_year_st.jpg", "abschließen \nзаканчивать", "NemAud/Berufswahl/abschlieben.mp3")},
                {(62, "absolvieren \nоканчивать что-либо"), ("first_year_st.jpg", "absolvieren \nоканчивать что-либо", "NemAud/Berufswahl/absolvieren.mp3")},
                {(63, "der Absolvent \nвыпускник чего-либо"), ("higher_educ.jpg", "der Absolvent \nвыпускник чего-либо", "NemAud/Berufswahl/der_Absolvent.mp3")},
                {(64, "die Ausbildung \nпрофессиональная обучение / подготовка"), ("voc_education.jpg", "die Ausbildung \nпрофессиональная обучение / подготовка", "NemAud/Berufswahl/die_Ausbildung.mp3")},
                {(66, "studieren an etw. (Dat.) \nучиться в высшем учебном заведении"), ("enter.jpg", "studieren an etw. (Dat.) \nучиться в высшем учебном заведении", "NemAud/Berufswahl/studieren_an_etw.mp3")},
                {(67, "das Studium \nучеба"), ("primary_school.jpg", "das Studium \nучеба", "NemAud/Berufswahl/das_Studium.mp3")},
                {(68, "die Umschulungen \nпереквалификация / переобучение"), ("sec_spec_educ.jpg", "die Umschulungen \nпереквалификация / переобучение", "NemAud/Berufswahl/die_Umschulungen.mp3")},



                 {(1, "aufwachsen \nвырастать"), ("Daughter_in_law.png", "aufwachsen \nвырастать", "NemAud/Familie/aufwachsen.mp3")},
                 {(2, "in guten / schlechten Verhältnissen aufwachsen \nвырастать в хороших / плохих условиях"), ("Get_on_well.jpg", "in guten / schlechten Verhältnissen aufwachsen \nвырастать в хороших / плохих условиях", "NemAud/Familie/in_guten_schlechten_Verhaltnissen_aufwachsen.mp3")},
                 {(3, "betreuen jemanden (akk.) \nзаботиться / ухаживать о ком либо"), ("Appreciate.png", "betreuen jemanden (akk.) \nзаботиться / ухаживать о ком либо", "NemAud/Berufswahl/betreuen_jemanden.mp3")},
                 {(4, "die Betreuung \nуход / забота"), ("Appreciate.png", "die Betreuung \nуход / забота", "NemAud/Familie/die_Betreuung.mp3")},
                 {(5, "einsam \nодинокий"), ("Single_Bachelor.jpg", "einsam \nодинокий", "NemAud/Familie/einsam.mp3")},
                 {(9, "die Erziehung \nвоспитание"), ("Single_parent_family.png", "die Erziehung \nвоспитание", "NemAud/Familie/die_Erziehung.mp3")},
                 {(10, "die Generation \nпоколение"), ("Extended_family_Immediate_family.png", "die Generation \nпоколение", "NemAud/Familie/die_Generation.mp3")},
                 {(15, "minderjährig \nнесовершеннолетний"), ("Stepbrother.png", "minderjährig \nнесовершеннолетний", "NemAud/Familie/minderjahrig.mp3")},
                 {(16, "sich Streiten \nссориться"), ("Divorced_Ex_Wife_Ex_Husband.png", "sich Streiten \nссориться", "NemAud/Familie/sich_streiten.mp3")},
                 {(22, "das Verhalten \nповедение / отношение"), ("Single_parent_family.png", "das Verhalten \nповедение / отношение", "NemAud/Familie/das_Verhalten.mp3")},
                 {(25, "sich Versöhnen \nпомириться / мириться"), ("piace.png", "sich Versöhnen \nпомириться / мириться", "NemAud/Familie/sich_versohnen.mp3")},
                 {(27, "sich Vertragen \nладить / уживаться / терпеть / переносить"), ("piace.png", "sich Vertragen \nладить / уживаться / терпеть / переносить", "NemAud/Familie/sich_vertragen.mp3")},
                 {(28, "volljährig \nсовершеннолетний"), ("Uncle.png", "volljährig \nсовершеннолетний", "NemAud/Familie/volljahrig.mp3")},
                 {(29, "die Ehe \nбрак / супружество"), ("Parents.png", "die Ehe \nбрак / супружество", "NemAud/Familie/die_Ehe.mp3")},
                 {(30, "die Ehe schließen \nвступать в брак"), ("Parents.png", "die Ehe schließen \nвступать в брак", "NemAud/Familie/die_Ehe_schlieben.mp3")},
                 {(32, "das Ehepaar \nсупруги"), ("Wife_Bride.png", "das Ehepaar \nсупруги", "NemAud/Familie/das_Ehepaar.mp3")},
                 {(34, "geschieden \nразведенный"), ("Divorced_Ex_Wife_Ex_Husband.png", "geschieden \nразведенный", "NemAud/Familie/geschieden.mp3")},
                 {(35, "heiraten / jemanden \nжениться / выходить замуж"), ("Wife_Bride.png", "heiraten / jemanden \nжениться / выходить замуж", "NemAud/Familie/heiraten_jemanden.mp3")},
                 {(37, "ledig \nхолостой"), ("Single_Bachelor.jpg", "ledig \nхолостой", "NemAud/Familie/ledig.mp3")},
                 {(39, "die Scheidung \npaзвод"), ("Divorced_Ex_Wife_Ex_Husband.png", "die Scheidung \npaзвод", "NemAud/Familie/die_Scheidung.mp3")},
                 {(42, "die Adoption \nусыновление / удочерение"), ("Stepmother_Stepson.png", "die Adoption \nусыновление / удочерение", "NemAud/Familie/die_Adoption.mp3")},
                 {(43, "die Adoptivneltern (plural) \nприемные родители"), ("Foster_family.png", "die Adoptivneltern (plural) \nприемные родители", "NemAud/Familie/die_Adoptivneltern.mp3")},
                 {(44, "das Adoptivkind \nприемный ребенок"), ("Foster_family.png", "das Adoptivkind \nприемный ребенок", "NemAud/Familie/das_Adoptivkind.mp3")},
                 {(45, "alleinsteehend \nодинокий"), ("Single_Bachelor.jpg", "alleinsteehend \nодинокий", "NemAud/Familie/alleinsteehend.mp3")},
                 {(47, "die Pflegemutter \nприемная мать"), ("Stepmother_Stepson.png", "die Pflegemutter \nприемная мать", "NemAud/Familie/die_Pflegemutter.mp3")},
                 {(48, "der Pflegevater \nприемный отец"), ("Stepfather.png", "der Pflegevater \nприемный отец", "NemAud/Familie/der_Pflegevater.mp3")},
                 {(50, "die Braut \nневеста"), ("Wife_Bride.png", "die Braut \nневеста", "NemAud/Familie/die_Braut.mp3")},
                 {(51, "der Bräutigam \nжених"), ("Husband_Groom.png", "der Bräutigam \nжених", "NemAud/Familie/der_Brautigam.mp3")},
                 {(52, "eine Hochzeit feiern \nпраздновать свадьбу"), ("Wedding.png", "eine Hochzeit feiern \nпраздновать свадьбу", "NemAud/Familie/eine_Hochzeit_feiern.mp3")},
                 {(55, "sich In der kirche trauen lassen \nвенчаться в церкви"), ("church.png", "sich In der kirche trauen lassen \nвенчаться в церкви", "NemAud/Familie/sich_in_der_Kirche_trauen_lassen.mp3")},
                 {(57, "die Trauung \nбракосочетание / венчание"), ("couple.png", "die Trauung \nбракосочетание / венчание", "NemAud/Familie/die_Trauung.mp3")},
                 {(58, "der Trauring \nобручальное кольцо"), ("rings.png", "der Trauring \nобручальное кольцо", "NemAud/Familie/der_Trauring.mp3")},





                 {(3, "der Ausflug \nэкскурсия"), ("Trip.png", "der Ausflug \nэкскурсия", "NemAud/Tourismus/der_Ausflug.mp3")},
                 {(4, "die Reise \nпутешествие"), ("Trip.png", "die Reise \nпутешествие", "NemAud/Tourismus/die_Reise.mp3")},
                 {(5, "der Reiseführer \nэкскурсовод / путеводитель"), ("Set_off.jpg", "der Reiseführer \nэкскурсовод / путеводитель", "NemAud/Tourismus/der_Reisefuhrer.mp3")},
                 {(7, "abreisen \nуезжать / заезжать за кем-либо"), ("Trip.png", "abreisen \nуезжать / заезжать за кем-либо", "NemAud/Tourismus/abreisen.mp3")},
                 {(8, "die Abreise \nотъезд"), ("Trip.png", "die Abreise \nотъезд", "NemAud/Tourismus/die_Abreise.mp3")},
                 {(9, "die Ankunft \nприбытие"), ("Trip.png", "die Ankunft \nприбытие", "NemAud/Tourismus/die_Ankunft.mp3")},
                 {(10, "die Auskunft \nсправка"), ("Information_desk.png", "die Auskunft \nсправка", "NemAud/Tourismus/die_Auskunft.mp3")},
                 {(11, "das Auskunftsbüro \nсправочное бюро"), ("Information_desk.png", "das Auskunftsbüro \nсправочное бюро", "NemAud/Tourismus/das_Auskunftsburo.mp3")},
                 {(12, "der Bahnhof \nвокзал"), ("Vokzal.png", "der Bahnhof \nвокзал", "NemAud/Tourismus/der_Bahnhof.mp3")},
                 {(16, "das Fundbüro \nбюро находок"), ("Left_luggage_office.jpg", "das Fundbüro \nбюро находок", "NemAud/Tourismus/das_Fundburo.mp3")},
                 {(17, "das Gepack \nбагаж"), ("Luggage.png", "das Gepack \nбагаж", "NemAud/Tourismus/das_Gepack.mp3")},
                 {(18, "das Gepäck aufgeben \nсдать багаж"), ("Luggage.png", "das Gepäck aufgeben \nсдать багаж", "NemAud/Tourismus/das_Gepack_aufgeben.mp3")},
                 {(19, "das Gleis \nрельсовый путь"), ("Vokzal.png", "das Gleis \nрельсовый путь", "NemAud/Tourismus/das_Gleis.mp3")},
                 {(20, "der Schalter \nбилетная касса"), ("Kassa.png", "der Schalter \nбилетная касса", "NemAud/Tourismus/der_Schalter.mp3")},
                 {(22, "die Jugendherberge \nтуристская база для молодежи"), ("Otd.png", "die Jugendherberge \nтуристская база для молодежи", "NemAud/Tourismus/die_Jugendherberge.mp3")},
                 {(23, "üderbernachten \nночевать / переночевать"), ("Nochevka.png", "üderbernachten \nночевать / переночевать", "NemAud/Tourismus/uderbernachten.mp3")},
                 {(26, "aussteigen \nвыходить (из транспорта)"), ("Vix.png", "aussteigen \nвыходить (из транспорта)", "NemAud/Tourismus/aussteigen.mp3")},
                 {(27, "die Bahn / die Eisenbahn \nжелезная дорога"), ("Vokzal.png", "die Bahn / die Eisenbahn \nжелезная дорога", "NemAud/Tourismus/die_Bahn_die_Eisenbahn.mp3")},
                 {(28, "einsteigen \nвходить / садиться (в транспорт)"), ("Sit.png", "einsteigen \nвходить / садиться (в транспорт)", "NemAud/Tourismus/einsteigen.mp3")},
                 {(30, "reisen \nпутешествовать"), ("Set_off.jpg", "reisen \nпутешествовать", "NemAud/Tourismus/reisen.mp3")},
                 {(35, "der Zug \nпоезд"), ("Vokzal.png", "der Zug \nпоезд", "NemAud/Tourismus/der_Zug.mp3")},
                 {(37, "besorgen \nпокупать (билет)"), ("Package_tour.png", "besorgen \nпокупать (билет)", "NemAud/Tourismus/besorgen.mp3")},
                 {(38, "bestellen \nзаказывать"), ("Package_tour.png", "bestellen \nзаказывать", "NemAud/Tourismus/bestellen.mp3")},
                 {(39, "buchen \nбронировать"), ("Package_tour.png", "buchen \nбронировать", "NemAud/Tourismus/buchen.mp3")},
                 {(40, "das Abenteuer \nприключение"), ("map.png", "das Abenteuer \nприключение", "NemAud/Tourismus/das_Abenteuer.mp3")},
                 {(43, "das Erlebnis \nсобытие / впечатление"), ("confetti.png", "das Erlebnis \nсобытие / впечатление", "NemAud/Tourismus/das_Erlebnis.mp3")},


                 {(1, "der Abfall \noтброcы / отxоды"), ("Pollution_To_pollute.png", "der Abfall \nотброcы / отxоды", "NemAud/Unwelt/der_Abfall.mp3")},
                 {(2, "das Abgas \nвыхлопной газ"), ("co.png", "das Abgas \nвыхлопной газ", "NemAud/Unwelt/das_Abgas.mp3")},
                 {(4, "der Lärm \nшyм"), ("noise.png", "der Lärm \nшyм", "NemAud/Unwelt/der_Larm.mp3")},
                 {(6, "der Müll \nмycop"), ("Wastes.png", "der Müll \nмycop", "NemAud/Unwelt/der_Mull.mp3")},
                 {(7, "der Schmutz \nгрязь"), ("Landfill.png", "der Schmutz \nгрязь", "NemAud/Unwelt/der_Schmutz.mp3")},
                 {(9, "das Düngemittel \nудобрение"), ("fertilizer.png", "das Düngemittel \nудобрение", "NemAud/Unwelt/das_Dungemittel.mp3")},
                 {(10, "der Staub \nпыль"), ("Dust.png", "der Staub \nпыль", "NemAud/Unwelt/der_Staub.mp3")},
                 {(11, "das Gift \nяд"), ("Poison.png", "das Gift \nяд", "NemAud/Unwelt/das_Gift.mp3")},
                 {(14, "bedrohte Tiere \nживотные, которым грозит исчезновение"), ("Tiere.jpg", "bedrohte Tiere \nживотные, которым грозит исчезновение", "NemAud/Unwelt/bedrohte_Tiere.mp3")},
                 {(16, "die Gefahr \nопасность"), ("Dangerous.png", "die Gefahr \nопасность", "NemAud/Unwelt/die_Gefahr.mp3")},
                 {(19, "schaden \nвредить"), ("Emission.png", "schaden \nвредить", "NemAud/Unwelt/schaden.mp3")},
                 {(22, "verbrennen \ncжигать"), ("wildfire.png", "verbrennen \ncжигать", "NemAud/Unwelt/verbrennen.mp3")},
                 {(23, "vergiften \nотравлять"), ("Poison.png", "vergiften \nотравлять", "NemAud/Unwelt/vergiften.mp3")},
                 {(27, "verschmutzen \nзагрязнять"), ("Pollution_To_pollute.png", "verschmutzen \nзагрязнять", "NemAud/Unwelt/verschmutzen.mp3")},
                 {(28, "verseuchte \nзаражать"), ("virus.png", "verseuchte \nзаражать", "NemAud/Unwelt/verseuchte.mp3")},
                 {(29, "zerstören \npaзpyшaть"), ("Destroy.png", "zerstören \npaзpyшaть", "NemAud/Unwelt/zerstoren.mp3")},
                 {(31, "entsorgen \nудалять / утилизировать"), ("waste.png", "entsorgen \nудалять / утилизировать", "NemAud/Unwelt/entsorgen.mp3")},
                 {(35, "herstellen \nпроизводить"), ("production.png", "herstellen \nпроизводить", "NemAud/Unwelt/herstellen.mp3")},
                 {(36, "die Herstellung \nпроизводство"), ("production.png", "die Herstellung \nпроизводство", "NemAud/Unwelt/die_Herstellung.mp3")},
                 {(37, "das Naturschutzgebiet \nзаповедник"), ("zoo.png", "das Naturschutzgebiet \nзаповедник", "NemAud/Unwelt/das_Naturschutzgebiet.mp3")},
                 {(38, "produzieren \nпроизводить"), ("production.png", "produzieren \nпроизводить", "NemAud/Unwelt/produzieren.mp3")},
                 {(39, "reinigen \nчистить / очищать / убирать"), ("Household.png", "reinigen \nчистить / очищать / убирать", "NemAud/Unwelt/reinigen.mp3")},
                 {(40, "retten \nспасать"), ("Environment.png", "retten \nспасать", "NemAud/Unwelt/retten.mp3")},
                 {(41, "der Sauerstoff \nкислород"), ("oxigen.png", "der Sauerstoff \nкислород", "NemAud/Unwelt/der_Sauerstoff.mp3")},
                 {(43, "der Schutz \nзащита"), ("To_protect.png", "der Schutz \nзащита", "NemAud/Unwelt/der_Schutz.mp3")},
                 {(44, "sparen \nэкономить"), ("growth.png", "sparen \nэкономить", "NemAud/Unwelt/sparen.mp3")},
                 {(46, "die Umwelt \nокружающая cреда"), ("Environment.png", "die Umwelt \nокружающая cреда", "NemAud/Unwelt/die_Umwelt.mp3")},
                 {(47, "der Umweltschutz \nзащита окружающей среды"), ("To_protect.png", "der Umweltschutz \nзащита окружающей среды", "NemAud/Unwelt/der_Umweltschutz.mp3")},
                 {(48, "umweltfreundlich \nбезвредный для окружающей среды"), ("Reduce.png", "umweltfreundlich \nбезвредный для окружающей среды", "NemAud/Unwelt/umweltfreundlich.mp3")},
                 {(50, "verarbeiten etwas (akk.) zu etwas (dat.) \nперерабатывать что-либо на что-либо"), ("Recycle.png", "verarbeiten etwas (akk.) zu etwas (dat.) \nперерабатывать что-либо на что-либо", "NemAud/Unwelt/verarbeiten_etwas_zu_etwas.mp3")},
                 {(51, "verbrauchen \nрасходовать / пoтpeблять"), ("Renewable.png", "verbrauchen \nрасходовать / пoтpeблять", "NemAud/Unwelt/verbrauchen.mp3")},
                


                 {(1, "der/die Abgeordnete \nдепутат"), ("deputat.png", "der/die Abgeordnete \nдепутат", "NemAud/Soz/der_die_Abgeordnete.mp3")},
                 {(4, "das Gericht \nсуд"), ("syd.png", "das Gericht \nсуд", "NemAud/Soz/das_Gericht.mp3")},
                 {(5, "das Gesetz \nзакон"), ("syd.png", "das Gesetz \nзакон", "NemAud/Soz/das_Gesetz.mp3")},
                 {(7, "ein Gesetz beachten \nсоблюдать закон"), ("fair.png", "ein Gesetz beachten \nсоблюдать закон", "NemAud/Soz/ein_Gesetz_beachten.mp3")},
                 {(8, "gesetzlich \nзаконный"), ("fair.png", "gesetzlich \nзаконный", "NemAud/Soz/gesetzlich.mp3")},
                 {(9, "gleich \nравный / одинаковый"), ("fair.png", "gleich \nравный / одинаковый", "NemAud/Soz/gleich.mp3")},
                 {(11, "die Nationalhymne \nгосударственный гимн"), ("The_anthem.png", "die Nationalhymne \nгосударственный гимн", "NemAud/Soz/die_Nationalhymne.mp3")},
                 {(12, "das Parlament \nпарламент"), ("parliament.png", "das Parlament \nпарламент", "NemAud/Soz/das_Parlament.mp3")},
                 {(13, "die Politik \nполитика"), ("politics.png", "die Politik \nполитика", "NemAud/Soz/die_Politik.mp3")},
                 {(18, "der Ministerrat \nсовет министров"), ("politics.png", "der Ministerrat \nсовет Mинистров", "NemAud/Soz/der_Ministerrat.mp3")},
                 {(19, "die Regierung \nправительство"), ("government.png", "die Regierung \nправительство", "NemAud/Soz/die_Regierung.mp3")},
                 {(22, "die Repräsentantenkammer der Nationalversammlung \nпалата представителей Национального собрания"), ("politics.png", "die Repräsentantenkammer der Nationalversammlung \nпалата представителей Национального собрания", "NemAud/Soz/die_Reprasentantenkammer_der_Nationalversammlung.mp3")},
                 {(23, "der Staat \nгосударство"), ("germany.png", "der Staat \nгосударство", "NemAud/Soz/der_Staat.mp3")},
                 {(25, "die Verfassung / das Grundgesetz \nконституция"), ("constitution.png", "die Verfassung / das Grundgesetz \nконституция", "NemAud/Soz/die_Verfassung_das_Grundgesetz.mp3")},
                 {(32, "die Verwaltung \nуправление / администрация"), ("administration.png", "die Verwaltung \nуправление / администрация", "NemAud/Soz/die_Verwaltung.mp3")},
                 {(33, "der/die Vorsitzende \nпредседатель"), ("politician.png", "der/die Vorsitzende \nпредседатель", "NemAud/Soz/der_die_Vorsitzende.mp3")},
                 {(34, "das Wappen \nгepб"), ("germ_gerb.png", "das Wappen \nгepб", "NemAud/Soz/das_Wappen.mp3")},
                 {(36, "der Ausländer \nиностранец"), ("foreigner.png", "der Ausländer \nиностранец", "NemAud/Soz/der_Auslander.mp3")},
                 {(38, "die Gleichberechtigung \nравноправие"), ("equality.png", "die Gleichberechtigung \nравноправие", "NemAud/Soz/die_Gleichberechtigung.mp3")},
                 {(40, "die Lebensweise \nобраз жизни"), ("Lifestyle.png", "die Lebensweise \nобраз жизни", "NemAud/Soz/die_Lebensweise.mp3")},
                 {(43, "die Minderheit \nменьшиство"), ("pride.png", "die Minderheit \nменьшиство", "NemAud/Soz/die_Minderheit.mp3")},
                 {(44, "sich unterscheiden von jemandem / etwas (Dat.) \nотличаться от (кого-л.)"), ("race.png", "sich unterscheiden von jemandem / etwas (Dat.) \nотличаться от (кого-л.)", "NemAud/Soz/sich_unterscheiden_von_jemandem_etwas.mp3")},
                 {(45, "der Unterschied zwischen jemandem / etwas (Dat.) \nразличие между (кем / чем-л.)"), ("race.png", "der Unterschied zwischen jemandem / etwas (Dat.) \nразличие между (кем / чем-л.)", "NemAud/Soz/der_Unterschied_zwischen_jemandem_etwas.mp3")},
                 {(46, "das Recht auf etwas (Akk.) \nправо на что-либо"), ("decisions.png", "das Recht auf etwas (Akk.) \nправо на что-либо", "NemAud/Soz/das_Recht_auf_etwas.mp3")},
                 {(48, "die Wurzel \nкорень"), ("root.png", "die Wurzel \nкорень", "NemAud/Soz/die_Wurzel.mp3")},
                 {(49, "errichten \nвоздвигать / сооружать"), ("trowel.png", "errichten \nвоздвигать / сооружать", "NemAud/Soz/errichten.mp3")},
                 {(51, "das Denkmal \nпамятник"), ("obelisk.png", "das Denkmal \nпамятник", "NemAud/Soz/das_Denkmal.mp3")},
                 {(53, "das Schriftsprache \nлитературный язык"), ("literary.png", "das Schriftsprache \nлитературный язык", "NemAud/Soz/das_Schriftsprache.mp3")},
                 {(54, "das Vielfalt \nразнообразие"), ("diversity.png", "das Vielfalt \nразнообразие", "NemAud/Soz/das_Vielfalt.mp3")},
                 {(55, "das Volkstracht \nнациональный костюм"), ("russian.png", "das Volkstracht \nнациональный костюм", "NemAud/Soz/das_Volkstracht.mp3")},




                 {(1, "anständig \nприличный / порядочный"), ("Polite.png", "anständig \nприличный / порядочный", "NemAud/Nationalcharakter/anstandig.mp3")},
                 {(3, "ehrgeizig \nчестолюбивый"), ("Assertive.png", "ehrgeizig \nчестолюбивый", "NemAud/Nationalcharakter/ehrgeizig.mp3")},
                 {(5, "gastfreundlich \nгостеприимный"), ("Respectful.png", "gastfreundlich \nгостеприимный", "NemAud/Nationalcharakter/gastfreundlich.mp3")},
                 {(7, "die Gastfreundschaft \nгостеприимство / радушие"), ("Respectful.png", "die Gastfreundschaft \nгостеприимство / радушие", "NemAud/Nationalcharakter/die_Gastfreundschaft.mp3")},
                 {(8, "gesellig \nобщительный"), ("Talkative.png", "gesellig \nобщительный", "NemAud/Nationalcharakter/gesellig.mp3")},
                 {(10, "die Großzügigkeit \nщедрость / великодушие"), ("generous.png", "die Großzügigkeit \nщедрость / великодушие", "NemAud/Nationalcharakter/die_Grobzugigkeit.mp3")},
                 {(11, "geizig \nскупой"), ("greedy.png", "geizig \nскупой", "NemAud/Nationalcharakter/geizig.mp3")},
                 {(14, "gutmitig \nдобродушный"), ("Honest.png", "gutmitig \nдобродушный", "NemAud/Nationalcharakter/gutmitig.mp3")},
                 {(17, "gewissenhaft \nдобросовестный"), ("Honest.png", "gewissenhaft \nдобросовестный", "NemAud/Nationalcharakter/gewissenhaft.mp3")},
                 {(18, "konsequent \nпоследовательный"), ("Generalization.png", "konsequent \nпоследовательный", "NemAud/Nationalcharakter/konsequent.mp3")},
                 {(19, "sparsam \nбережливый / экономный"), ("growth.png", "sparsam \nбережливый / экономный", "NemAud/Nationalcharakter/sparsam.mp3")},
                 {(20, "umganglich \nобходительный / уживчивый"), ("Humble.png", "umganglich \nобходительный / уживчивый", "NemAud/Nationalcharakter/umganglich.mp3")},
                 {(22, "zuverlässig \nнадежный"), ("To_protect.png", "zuverlässig \nнадежный", "NemAud/Nationalcharakter/zuverlassig.mp3")},
                 {(24, "beneiden \nзавидовать"), ("envy.png", "beneiden \nзавидовать", "NemAud/Nationalcharakter/beneiden.mp3")},
                 {(28, "ernst \nсерьезный"), ("Strict.png", "ernst \nсерьезный", "NemAud/Nationalcharakter/ernst.mp3")},
                 {(29, "die Gesichtszüge (Pl.) \nчерты лица"), ("botox.png", "die Gesichtszüge (Pl.) \nчерты лица", "NemAud/Nationalcharakter/die_Gesichtszuge.mp3")},
                 {(30, "milde \nмягкие"), ("myag.jpg", "milde \nмягкие", "NemAud/Nationalcharakter/milde.mp3")},
                 {(31, "scharfe \nострые"), ("ostr.jpg", "scharfe \nострые", "NemAud/Nationalcharakter/scharfe.mp3")},
                 {(32, "strenge \nстрогие"), ("strog.jpg", "strenge \nстрогие", "NemAud/Nationalcharakter/strenge.mp3")},
                 {(33, "zarte \nнежные"), ("nejn.jpg", "zarte \nнежные", "NemAud/Nationalcharakter/zarte.mp3")},
                 {(34, "identifizieren \nустанавливать личность"), ("recognition.png", "identifizieren \nустанавливать личность", "NemAud/Nationalcharakter/identifizieren.mp3")},
                 {(35, "die Nation \nнация"), ("passport.png", "die Nation \nнация", "NemAud/Nationalcharakter/die_Nation.mp3")},
                 {(38, "der Respekt \nуважение / почтение"), ("respect.png", "der Respekt \nуважение / почтение", "NemAud/Nationalcharakter/der_Respekt.mp3")},
                 {(40, "rücksichtslos \nбесцеремонный / беспощадный"), ("Strict.png", "rücksichtslos \nбесцеремонный / беспощадный", "NemAud/Nationalcharakter/rucksichtslos.mp3")},
                 {(41, "überzeugen jemanden (Akk.) von etwas (Dat.) \nубеждать (кого-л.)"), ("conv.png", "überzeugen jemanden (Akk.) von etwas (Dat.) \nубеждать (кого-л.)", "NemAud/Nationalcharakter/uberzeugen_jemanden_von_etwas.mp3")},
                 {(42, "vertraut \nзнакомый / близкий"), ("respect.png", "vertraut \nзнакомый / близкий", "NemAud/Nationalcharakter/vertraut.mp3")},
                 


                 {(1, "die Botschaft \nпосольство"), ("embassy.png", "die Botschaft \nпосольство", "NemAud/Internationale_Zusammenarbeit/die_Botschaft.mp3")},
                 {(2, "UNESCO \n(die Organisation der Vereinten Nationen für Bildung, Wissenschaft und Kultur) \nЮНЕСКО (Организашия объединенных Наций по вопросам образования, науки)"), ("unesco.png", "UNESCO \n(die Organisation der Vereinten Nationen für Bildung, Wissenschaft und Kultur) \nЮНЕСКО (Организашия объединенных Наций по вопросам образования, науки)", "NemAud/Internationale_Zusammenarbeit/UNESCO.mp3")},
                 {(3, "die Europäische Union (die EU) \nЕвропейский Союз"), ("union.jpg", "die Europäische Union (die EU) \nЕвропейский Союз", "NemAud/Internationale_Zusammenarbeit/die_Europaische_Union.mp3")},
                 {(4, "die UNO (die Vereinten Nationen) \nООН (Организация объединенных наций)"), ("oon.jpg", "die UNO (die Vereinten Nationen) \nООН (Организация объединенных наций)", "NemAud/Internationale_Zusammenarbeit/die_UNO.mp3")},
                 {(7, "der Frieden \nмир"), ("peace.png", "der Frieden \nмир", "NemAud/Internationale_Zusammenarbeit/der_Frieden.mp3")},
                 {(8, "gewährleisten \nобеспечивать / гарантировать"), ("guarantee.png", "gewährleisten \nобеспечивать / гарантировать", "NemAud/Internationale_Zusammenarbeit/gewahrleisten.mp3")},
                 {(9, "die Sicherheit \nбезопасность"), ("To_protect.png", "die Sicherheit \nбезопасность", "NemAud/Internationale_Zusammenarbeit/die_Sicherheit.mp3")},
                 {(10, "vereinen \nобъединять / соединять"), ("united.png", "vereinen \nобъединять / соединять", "NemAud/Internationale_Zusammenarbeit/vereinen.mp3")},
                 {(11, "der Verständigung \nвзаимопонимание"), ("understandable.png", "der Verständigung \nвзаимопонимание", "NemAud/Internationale_Zusammenarbeit/der_Verstandigung.mp3")},
                 {(12, "die Vereinigung \nобъединение / союз"), ("united.png", "die Vereinigung \nобъединение / союз", "NemAud/Internationale_Zusammenarbeit/die_Vereinigung.mp3")},
                 {(14, "die Bereitschaft zu etwas (Dat.) \nготовность к (чему-л.)"), ("running.png", "die Bereitschaft zu etwas (Dat.) \nготовность к (чему-л.)", "NemAud/Internationale_Zusammenarbeit/die_Bereitschaft_zu_etwas.mp3")},
                 {(15, "bereit sein zu etwas (Dat.) \nбыть готовым на (что-л.) / к (чему-л.)"), ("running.png", "bereit sein zu etwas (Dat.) \nбыть готовым на (что-л.) / к (чему-л.)", "NemAud/Internationale_Zusammenarbeit/bereit_sein_zu_etwas.mp3")},
                 {(16, "das Erbe \nнаследие"), ("beneficiary.png", "das Erbe \nнаследие", "NemAud/Internationale_Zusammenarbeit/das_Erbe.mp3")},
                 {(19, "die Gemeinschaft \nобщность / содружество"), ("Humanity_Mankind.png", "die Gemeinschaft \nобщность / содружество", "NemAud/Internationale_Zusammenarbeit/die_Gemeinschaft.mp3")},
                 {(21, "die Veranstaltung \nмероприятие"), ("evt.png", "die Veranstaltung \nмероприятие", "NemAud/Internationale_Zusammenarbeit/die_Veranstaltung.mp3")},
                 {(22, "eine Veranstaltung durchführen \nпроводить мероприятие"), ("evt.png", "eine Veranstaltung durchführen \nпроводить мероприятие", "NemAud/Internationale_Zusammenarbeit/eine_Veranstaltung_durchfuhren.mp3")},
                 {(25, "die Toleranz \nтерпимость"), ("Anxious.png", "die Toleranz \nтерпимость", "NemAud/Internationale_Zusammenarbeit/die_Toleranz.mp3")},
                 {(26, "die Verantwortung \nответственность"), ("Honest.png", "die Verantwortung \nответственность", "NemAud/Internationale_Zusammenarbeit/die_Verantwortung.mp3")},
                 {(27, "verantwortungsvoll \nответственный"), ("Honest.png", "verantwortungsvoll \nответственный", "NemAud/Internationale_Zusammenarbeit/verantwortungsvoll.mp3")},
                 {(28, "respektieren \nуважать / относиться с уважением"), ("Respectful.png", "respektieren \nуважать / относиться с уважением", "NemAud/Internationale_Zusammenarbeit/respektieren.mp3")},






            };

                if (lectureParams.TryGetValue((numb, lecture.Discription1), out var params1))
                {
                    //|| lectureParamsN.TryGetValue((numb, lecture.Discription1), out var params1_2)
                    //if (params1.Item2 != null)
                    //{
                    BannerImg.Source = params1.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params1.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params1.Item3);
                    //}


                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription2), out var params2))
                {
                    BannerImg.Source = params2.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params2.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params2.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription3), out var params3))
                {
                    BannerImg.Source = params3.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params3.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params3.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription4), out var params4))
                {
                    BannerImg.Source = params4.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params4.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params4.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription5), out var params5))
                {
                    BannerImg.Source = params5.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params5.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params5.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription6), out var params6))
                {
                    BannerImg.Source = params6.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params6.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params6.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription7), out var params7))
                {
                    BannerImg.Source = params7.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params7.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params7.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription8), out var params8))
                {
                    BannerImg.Source = params8.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params8.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params8.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription9), out var params9))
                {
                    BannerImg.Source = params9.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params9.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params9.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription10), out var params10))
                {
                    BannerImg.Source = params10.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params10.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params10.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription11), out var params11))
                {
                    BannerImg.Source = params11.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params11.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params11.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription12), out var params12))
                {
                    BannerImg.Source = params12.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params12.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params12.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription13), out var params13))
                {
                    BannerImg.Source = params13.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params13.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params13.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription14), out var params14))
                {
                    BannerImg.Source = params14.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params14.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params14.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription15), out var params15))
                {
                    BannerImg.Source = params15.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params15.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params15.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription16), out var params16))
                {
                    BannerImg.Source = params16.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params16.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params16.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription17), out var params17))
                {
                    BannerImg.Source = params17.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params17.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params17.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription18), out var params18))
                {
                    BannerImg.Source = params18.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params18.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params18.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription19), out var params19))
                {
                    BannerImg.Source = params19.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params19.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params19.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription20), out var params20))
                {
                    BannerImg.Source = params20.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params20.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params20.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription21), out var params21))
                {
                    BannerImg.Source = params21.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params21.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params21.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription22), out var params22))
                {
                    BannerImg.Source = params22.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params22.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params22.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription23), out var params23))
                {
                    BannerImg.Source = params23.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params23.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params23.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription24), out var params24))
                {
                    BannerImg.Source = params24.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params24.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params24.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription25), out var params25))
                {
                    BannerImg.Source = params25.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params25.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params25.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription26), out var params26))
                {
                    BannerImg.Source = params26.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params26.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params26.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription27), out var params27))
                {
                    BannerImg.Source = params27.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params27.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params27.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription28), out var params28))
                {
                    BannerImg.Source = params28.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params28.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params28.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription29), out var params29))
                {
                    BannerImg.Source = params29.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params29.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params29.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription30), out var params30))
                {
                    BannerImg.Source = params30.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params30.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params30.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription31), out var params31))
                {
                    BannerImg.Source = params31.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params31.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params31.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription32), out var params32))
                {
                    BannerImg.Source = params32.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params32.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params32.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription33), out var params33))
                {
                    BannerImg.Source = params33.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params33.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params33.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription34), out var params34))
                {
                    BannerImg.Source = params34.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params34.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params34.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription35), out var params35))
                {
                    BannerImg.Source = params35.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params35.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params35.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription36), out var params36))
                {
                    BannerImg.Source = params36.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params36.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params36.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription37), out var params37))
                {
                    BannerImg.Source = params37.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params37.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params37.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription38), out var params38))
                {
                    BannerImg.Source = params38.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params38.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params38.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription39), out var params39))
                {
                    BannerImg.Source = params39.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params39.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params39.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription40), out var params40))
                {
                    BannerImg.Source = params40.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params40.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params40.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription41), out var params41))
                {
                    BannerImg.Source = params41.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params41.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params41.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription42), out var params42))
                {
                    BannerImg.Source = params42.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params42.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params42.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription43), out var params43))
                {
                    BannerImg.Source = params43.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params43.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params43.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription44), out var params44))
                {
                    BannerImg.Source = params44.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params44.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params44.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription45), out var params45))
                {
                    BannerImg.Source = params45.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params45.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params45.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription46), out var params46))
                {
                    BannerImg.Source = params46.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params46.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params46.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription47), out var params47))
                {
                    BannerImg.Source = params47.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params47.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params47.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription48), out var params48))
                {
                    BannerImg.Source = params48.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params48.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params48.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription49), out var params49))
                {
                    BannerImg.Source = params49.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params49.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params49.Item3);
                }
                if (lectureParams.TryGetValue((numb, lecture.Discription50), out var params50))
                {
                    BannerImg.Source = params50.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params50.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params50.Item3);
                }
                if (lectureParams.TryGetValue((numb, lecture.Discription51), out var params51))
                {
                    BannerImg.Source = params51.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params51.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params51.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription52), out var params52))
                {
                    BannerImg.Source = params52.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params52.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params52.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription53), out var params53))
                {
                    BannerImg.Source = params53.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params53.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params53.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription54), out var params54))
                {
                    BannerImg.Source = params54.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params54.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params54.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription55), out var params55))
                {
                    BannerImg.Source = params55.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params55.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params55.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription56), out var params56))
                {
                    BannerImg.Source = params56.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params56.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params56.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription57), out var params57))
                {
                    BannerImg.Source = params57.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params57.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params57.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription58), out var params58))
                {
                    BannerImg.Source = params58.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params58.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params58.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription59), out var params59))
                {
                    BannerImg.Source = params59.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params59.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params59.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription60), out var params60))
                {
                    BannerImg.Source = params60.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params60.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params60.Item3);
                }
                if (lectureParams.TryGetValue((numb, lecture.Discription61), out var params61))
                {
                    BannerImg.Source = params61.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params61.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params61.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription62), out var params62))
                {
                    BannerImg.Source = params62.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params62.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params62.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription63), out var params63))
                {
                    BannerImg.Source = params63.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params63.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params63.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription64), out var params64))
                {
                    BannerImg.Source = params64.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params64.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params64.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription65), out var params65))
                {
                    BannerImg.Source = params65.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params65.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params65.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription66), out var params66))
                {
                    BannerImg.Source = params66.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params66.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params66.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription67), out var params67))
                {
                    BannerImg.Source = params67.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params67.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params67.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription68), out var params68))
                {
                    BannerImg.Source = params68.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params68.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params68.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription69), out var params69))
                {
                    BannerImg.Source = params69.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params69.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params69.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription70), out var params70))
                {
                    BannerImg.Source = params70.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params70.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params70.Item3);
                }
                if (lectureParams.TryGetValue((numb, lecture.Discription71), out var params71))
                {
                    BannerImg.Source = params71.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params71.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params71.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription72), out var params72))
                {
                    BannerImg.Source = params72.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params72.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params72.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription73), out var params73))
                {
                    BannerImg.Source = params73.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params73.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params73.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription74), out var params74))
                {
                    BannerImg.Source = params74.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params74.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params74.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription75), out var params75))
                {
                    BannerImg.Source = params75.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params75.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params75.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription76), out var params76))
                {
                    BannerImg.Source = params76.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params76.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params76.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription77), out var params77))
                {
                    BannerImg.Source = params77.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params77.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params77.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription78), out var params78))
                {
                    BannerImg.Source = params78.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params78.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params78.Item3);
                }
                else if (lectureParams.TryGetValue((numb, lecture.Discription79), out var params79))
                {
                    BannerImg.Source = params79.Item1;
                    BannerImg.HeightRequest = 400;
                    BannerImg.WidthRequest = 400;
                    name.Text = params79.Item2;
                    player = CrossSimpleAudioPlayer.Current;
                    player.Load(params79.Item3);
                }




                if (numb == 1)
                {
                    if (lecture.Discription1 == "Education \nобразование")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "education.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription1;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Educ/education.mp3");

                    }
                    if (lecture.Discription1 == "Entertainment \nразвлечение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "entertainment.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription1;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/entarteinment.mp3");
                    }
                    if (lecture.Discription1 == "Science \nнаука")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "science.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription1;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/science.mp3");
                    }

                }
                if (numb == 2)
                {
                    if (lecture.Discription2 == "Citizen \nгражданин")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "citizen.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription2;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/citizen.mp3");
                    }
                    if (lecture.Discription2 == "Robbery \nграбеж")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "roberry.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription2;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/robbery.mp3");
                    }
                    if (lecture.Discription2 == "Scientific \nнаучный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "scientific.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription2;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/scientific.mp3");
                    }
                   
                }
                if (numb == 3)
                {
                    if (lecture.Discription3 == "A guaranteed right to education \nгарантированное право на образование")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "guaranteed_right_to_education.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription3;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/garant_educ.mp3");
                    }
                    if (lecture.Discription3 == "Sensational \nсенсационный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "sensational.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription3;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/sensational.mp3");
                    }
                    if (lecture.Discription3 == "Scientist \nученый")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "scientist.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription3;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/scientest.mp3");
                    }

                  /*  if (lecture.Discription3 == "Bebauen \nвозделывать / обрабатывать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "scientist.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription3;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/bebauen.mp3");
                    }*/
                }

                if (numb == 4)
                {
                    if (lecture.Discription4 == "Pre-school education \nдошкольное образование")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "pre_school_educ.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription4;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/pre_school.mp3");
                    }
                    if (lecture.Discription4 == "Untrue \nложный / неверный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "untrue.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription4;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/untrue.mp3");
                    }
                    if (lecture.Discription4 == "Technology \nтехнология")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "technology.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription4;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/tecnology.mp3");
                    }
                 /*   if (lecture.Discription4 == "Bedienen \nобслуживать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "scientist.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription4;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/bedienen.mp3");
                    }*/
                }
                if (numb == 5)
                {
                    if (lecture.Discription5 == "General secondary education \nобщее среднее образование")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "gen_sec_educ.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription5;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/gener_sec_educ.mp3");
                    }
                    if (lecture.Discription5 == "Shape view \nформировать мировоззрение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "shape_view.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription5;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/shape_view.mp3");
                    }
                    if (lecture.Discription5 == "Century \nвек / столетие")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription5;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/century.mp3");
                    }
                    /*if (lecture.Discription5 == "Behandeln \nлечить больных")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription5;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/behandeln.mp3");
                    }*/

                }
                if (numb == 6)
                {
                    if (lecture.Discription6 == "Secondary specialized education \nсреднее специальное образование")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "sec_spec_educ.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription6;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/sec_spec_educ.mp3");
                    }
                    if (lecture.Discription6 == "Broaden mind \nрасширять кругозор")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "br_mind.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription6;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/broad_mind.mp3");
                    }
                    if (lecture.Discription6 == "Man-мade оbject \nискусственный объект")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "man_made_object.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription6;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/man_made_object.mp3");
                    }
                   /* if (lecture.Discription6 == "Beherrschen \nвладеть")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription6;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/beherrschen.mp3");
                    }*/
                }
                if (numb == 7)
                {
                    if (lecture.Discription7 == "Vocational training education \nпрофессионально-техническое образование")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "voc_education.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription7;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/voc_tr_educ.mp3");
                    }
                    if (lecture.Discription7 == "Disadvantage \nнедостаток")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "disadvantage.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription7;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/disadventage.mp3");
                    }
                    if (lecture.Discription7 == "Wonder \nчудо")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "wonder.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription7;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/wonder.mp3");
                    }
                   /* if (lecture.Discription7 == "eine Sprache beherrschen \nвладеть языком")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription7;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/eine_Sprache_beherrschen.mp3");
                    }*/

                }
                if (numb == 8)
                {
                   /* if (lecture.Discription8 == "Beraten \nсоветовать / консультировать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription8;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/beraten.mp3");
                    }*/
                    if (lecture.Discription8 == "Higher education \nвысшее образование")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "higher_educ.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription8;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/higher_educ.mp3");
                    }
                    if (lecture.Discription8 == "Prefer \nпредпочитать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "prefer.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription8;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/prefer.mp3");
                    }
                    if (lecture.Discription8 == "Achievement \nдостижение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "achivment.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription8;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/achivment.mp3");
                    }
                }
                if (numb == 9)
                {
                    /*if (lecture.Discription9 == "der Berater \nконсультант")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription9;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/der_Berater.mp3");
                    }*/
                    if (lecture.Discription9 == "Primary school \nначальная школа")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "primary_school.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription9;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/primary_school.mp3");
                    }
                    if (lecture.Discription9 == "React \nреагировать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "react.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription9;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/react.mp3");
                    }
                    if (lecture.Discription9 == "Perhaps \nвозможно")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "perhaps.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription9;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/perhabs.mp3");
                    }
                }
                if (numb == 10)
                {
                    /*if (lecture.Discription10 == "Betreuen \nзаботиться / обслуживать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription10;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/betreuen.mp3");
                    }*/
                    if (lecture.Discription10 == "Basic school \nбазовая школа")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "basic_school.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription10;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/basic_school.mp3");
                    }
                    if (lecture.Discription10 == "Be front page news \nпопасть на первые страницы прессы")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "broadsheet.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription10;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/be_ront_page_news.mp3");
                    }
                    if (lecture.Discription10 == "Drug abuse \nзлоупотребление наркотиками")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "drug_abuse.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription10;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/drug_abuse.mp3");
                    }
                }
                if (numb == 11)
                {
                    /*if (lecture.Discription11 == "messen (Akk.) \nизмерять что-либо")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription11;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/messen.mp3");
                    }*/
                    if (lecture.Discription11 == "Complete secondary education \nполное среднее образование")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "compl_sec_educ.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription11;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/compl_sec_educ.mp3");
                    }
                    if (lecture.Discription11 == "Mass media \nсредства массовой информации")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "mass_media.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription11;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/mass_media.mp3");
                    }
                    if (lecture.Discription11 == "However \nоднако")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "however.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription11;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/however.mp3");
                    }
                }
                if (numb == 12)
                {
                    /*if (lecture.Discription12 == "Pflegen \nухаживать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "century.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription12;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("NemAud/Berufswahl/pflegen.mp3");
                    }*/
                    if (lecture.Discription12 == "Provide \nобеспечивать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "provide.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription12;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/provide.mp3");
                    }
                    if (lecture.Discription12 == "Inform \nсообщать / информировать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "inform.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription12;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/inform.mp3");
                    }
                    if (lecture.Discription12 == "Mankind / Humanity \nчеловечество")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "mankind.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription12;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/mankind.mp3");
                    }
                }
                if (numb == 13)
                {
                    if (lecture.Discription13 == "Compulsory \nобязательный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "compulsory.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription13;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/compulsory.mp3");
                    }
                    if (lecture.Discription13 == "What's going on? \nчто происходит?")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "whats_going_on.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription13;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/wats_going_on.mp3");
                    }
                    if (lecture.Discription13 == "Advanced \nпродвинутый")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "advanced.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription13;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/advensd.mp3");
                    }
                }
                if (numb == 14)
                {
                    if (lecture.Discription14 == "Free of charge \nбесплатный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "free.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription14;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/free_of.mp3");
                    }
                    if (lecture.Discription14 == "Possibility \nвозможность")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "posibility.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription14;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/posibility.mp3");
                    }
                    if (lecture.Discription14 == "Digital \nцифровой")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "digital.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription14;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/digital.mp3");
                    }
                }
                if (numb == 15)
                {
                    if (lecture.Discription15 == "Fee-paying \nплатный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "fee.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription15;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/fee_pay.mp3");
                    }
                    if (lecture.Discription15 == "Fair \nчестный / справедливый")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "fair.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription15;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/fear.mp3");
                    }
                    if (lecture.Discription15 == "Vehicle \nтранспортное cредство")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "vehicle.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription15;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/vehicle.mp3");
                    }
                }
                if (numb == 16)
                {
                    if (lecture.Discription16 == "Attend \nпосещать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "attend.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription16;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/attend.mp3");
                    }
                    if (lecture.Discription16 == "Besides \nкроме того")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "besides.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription16;
                        //inf.Text = "Это слово означает приветствие!";

                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Media/besides.mp3");
                    }
                    if (lecture.Discription16 == "Prominent \nвыдающийся / знаменитый")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "prominent.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription16;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;

                        player.Load("Science/prominant.mp3");
                    }
                }
                if (numb == 17)
                {
                    if (lecture.Discription17 == "Nursery \nясли")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "nursery.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription17;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/nursery.mp3");
                    }
                    if (lecture.Discription17 == "Recently \nнедавно")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "recently.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription17;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/recently.mp3");
                    }
                    if (lecture.Discription17 == "Highly developed \nвысокоразвитый")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "highly_developed.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription17;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/highly_develop.mp3");
                    }
                }
                if (numb == 18)
                {
                    if (lecture.Discription18 == "Kindergarten \nдетский сад")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "kid_gard.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription18;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/kidengarden.mp3");
                    }
                    if (lecture.Discription18 == "Report \ncообщать / писать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "report.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription18;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/report.mp3");
                    }
                    if (lecture.Discription18 == "Old-fashioned \nстаромодный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "old_fashioned.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription18;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/old_fashioned.mp3");
                    }
                }
                if (numb == 19)
                {
                    if (lecture.Discription19 == "Start school \nначать ходить в школу")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "start_school.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription19;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/start_school.mp3");
                    }
                    if (lecture.Discription19 == "Event \ncобытие / происшествие")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "event.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription19;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/event.mp3");
                    }
                    if (lecture.Discription19 == "Development \nразвитие")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "development.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription19;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/development.mp3");
                    }
                }
                if (numb == 20)
                {
                    if (lecture.Discription20 == "Receive \nполучать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "receive.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription20;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/receive.mp3");
                    }
                    if (lecture.Discription20 == "Оbjectively \nобъективно")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "objectively.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription20;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/objectivly.mp3");
                    }
                    if (lecture.Discription20 == "High-Tech \nвысокотехнологичный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "high_tech.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription20;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/hi_tech.mp3");
                    }
                }
                if (numb == 21)
                {
                    if (lecture.Discription21 == "General secondary school \nобщая средняя школа")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "gen_sec_educ.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription21;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/gen_sec_school.mp3");
                    }
                    if (lecture.Discription21 == "Provide \nобеспечивать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "provide.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription21;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/provide.mp3");
                    }
                    if (lecture.Discription21 == "Mechanical \nмеханический")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "mechanical.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription21;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/mechanical.mp3");
                    }
                }
                if (numb == 22)
                {
                    if (lecture.Discription22 == "Gymnasium \nгимназия")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "gymnasium.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription22;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/gymnasium.mp3");
                    }
                    if (lecture.Discription22 == "Reliable \nнадёжный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "reliable.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription22;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/reliable.mp3");
                    }
                    if (lecture.Discription22 == "Invent \nизобретать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "invent.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription22;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/invent.mp3");
                    }
                }
                if (numb == 23)
                {
                    if (lecture.Discription23 == "Lyceum \nлицей")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "liceium.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription23;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/liceium.mp3");
                    }
                    if (lecture.Discription23 == "Ordinary \nобычный / заурядный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "ordinary.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription23;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/ordinary.mp3");
                    }
                    if (lecture.Discription23 == "Invention \nизобретение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "invention.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription23;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/invention.mp3");
                    }
                }
                if (numb == 24)
                {
                    if (lecture.Discription24 == "Institution \nучреждение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "institution.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription24;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/institution.mp3");
                    }
                    if (lecture.Discription24 == "Disaster \nбедствие")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "disaster.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription24;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/desister.mp3");
                    }
                    if (lecture.Discription24 == "Explore \nисследовать (на месте / на природе)")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "explore.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription24;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/explore.mp3");
                    }
                }
                if (numb == 25)
                {
                    if (lecture.Discription25 == "Term \nсеместр")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "term.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription25;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/term.mp3");
                    }
                    if (lecture.Discription25 == "Crash \nавария")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "crash.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription25;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/crash.mp3");
                    }
                    if (lecture.Discription25 == "Explorer \nисследователь / путешественник")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "explorer.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription25;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/explorer.mp3");
                    }
                }
                if (numb == 26)
                {
                    if (lecture.Discription26 == "Vacation \nканикулы")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "vacations.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription26;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/vacation.mp3");
                    }
                    if (lecture.Discription26 == "Murder \nубийство")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "murder.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription26;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/murder.mp3");
                    }
                    if (lecture.Discription26 == "Exploration \nисследование / разведка")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "exploration.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription26;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/exporation.mp3");
                    }
                }
                if (numb == 27)
                {
                    if (lecture.Discription27 == "Grades / marks \nотметки")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "grades.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription27;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/grates_marks.mp3");
                    }
                    if (lecture.Discription27 == "Make Headlines \nпопасть в заголовки газет / вызвать сенсацию")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "make_headlines.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription27;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/make_headlines.mp3");
                    }
                    if (lecture.Discription27 == "Research \nисследовать / исследование (в помещении)")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "research.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription27;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/research.mp3");
                    }
                }
                if (numb == 28)
                {
                    if (lecture.Discription28 == "Stipend \nстипендия")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "stipend.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription28;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/stipend.mp3");
                    }
                    if (lecture.Discription28 == "Print \nпечатать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "print.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription28;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/print.mp3");
                    }
                    if (lecture.Discription28 == "Researcher \nисследователь / научный cотрудник")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "researcher.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription28;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/researcher.mp3");
                    }
                }
                if (numb == 29)
                {
                    if (lecture.Discription29 == "Grant scholarships \nименная стипендия")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "grant_stip.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription29;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/grant.mp3");
                    }
                    if (lecture.Discription29 == "Broadcast \nвещать / транслировать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "broadcast.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription29;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/broadcast.mp3");
                    }
                    if (lecture.Discription29 == "Discover \nоткрывать / совершать открытие")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "discover.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription29;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/discover.mp3");
                    }
                }
                if (numb == 30)
                {
                    if (lecture.Discription30 == "State-owned \nгосударственный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "state_owned.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription30;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/state_owned.mp3");
                    }
                    if (lecture.Discription30 == "Half-True \nполуправдивый")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "half_true.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription30;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/half_true.mp3");
                    }
                    if (lecture.Discription30 == "Discovery \nоткрытие")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "discovery.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription30;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/discovery.mp3");
                    }
                }
                if (numb == 31)
                {
                    if (lecture.Discription31 == "Privately-owned \nчастный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "privately_owned.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription31;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/privetly_owned.mp3");
                    }
                    if (lecture.Discription31 == "Source \nисточник")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "source.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription31;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/source.mp3");
                    }
                    if (lecture.Discription31 == "Device \nмногофункциональное устройство / прибор")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "device.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription31;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/device.mp3");
                    }
                }
                if (numb == 32)
                {
                    if (lecture.Discription32 == "Comprehensive \nобщеобразовательная")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "gymnasium.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription32;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/comprehensive.mp3");
                    }
                    if (lecture.Discription32 == "Source of information \nисточник информации")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "source_of_information.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription32;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/source_of_inform.mp3");
                    }
                    if (lecture.Discription32 == "Appliance \nустройство / бытовой прибор")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "appliance.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription32;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/aplience.mp3");
                    }
                }
                if (numb == 33)
                {
                    if (lecture.Discription33 == "Enter \nпоступить")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "enter.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription33;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/enter.mp3");
                    }
                    if (lecture.Discription33 == "Influence \nвлиять")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "influence.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription33;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/influence.mp3");
                    }
                    if (lecture.Discription33 == "Gadget \nузконаправленное устройство")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "gadget.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription33;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/gadjet.mp3");
                    }
                }
                if (numb == 34)
                {
                    if (lecture.Discription34 == "Gomel State Agro-Economic College \nГГАЭК")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "ggaek.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription34;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/GGAEK.mp3");
                    }
                    if (lecture.Discription34 == "Advantage \nпреимущество")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "advantage.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription34;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/advantage.mp3");
                    }
                    if (lecture.Discription34 == "Machine building \nмашиностроение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "machine_building.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription34;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/machine_building.mp3");
                    }
                }
                if (numb == 35)
                {
                    if (lecture.Discription35 == "A first year student \nпервокурсник")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "first_year_st.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription35;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/first_year_st.mp3");
                    }
                    if (lecture.Discription35 == "Seeing is believing \nлучше один раз увидеть, чем сто раз услышать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "seeing_is_believing.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription35;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/seeing_is_beliv.mp3");
                    }
                    if (lecture.Discription35 == "Bioorganic сhemistry \nбиоорганическая химия")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "natural_sciences.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription35;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/biorgamic_chem.mp3");
                    }
                }
                if (numb == 36)
                {
                    if (lecture.Discription36 == "Full-time department \nдневное отделение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "full_time.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription36;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/full_time.mp3");
                    }
                    if (lecture.Discription36 == "Extra details \nдополнительные cведения")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "extra_details.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription36;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/extra_details.mp3");
                    }
                    if (lecture.Discription36 == "Genetic \nгенетический")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "genetic.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription36;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/genetic.mp3");
                    }
                }
                if (numb == 37)
                {
                    if (lecture.Discription37 == "Part-time department \nзаочное отделение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "part_time.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription37;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/part_time.mp3");
                    }
                    if (lecture.Discription37 == "Comment \nкомментарий")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "comment.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription37;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/comment.mp3");
                    }
                    if (lecture.Discription37 == "Agroculture \nсельское хозяйство")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "agriculture.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription37;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/agroculture.mp3");
                    }
                }
                if (numb == 38)
                {
                    if (lecture.Discription38 == "It takes me … \nу меня занимает …")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "it_takes_me.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription38;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/it_takes_me.mp3");
                    }
                    if (lecture.Discription38 == "Background information \n''закулисная'' информация")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "background_inf.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription38;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/background_inf.mp3");
                    }
                    if (lecture.Discription38 == "Hunger \nголод, чаще как чувство")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "hunger.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription38;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/hunger.mp3");
                    }
                }
                if (numb == 39)
                {
                    if (lecture.Discription39 == "Double period \nпара")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "double_period.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription39;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/double_period.mp3");
                    }
                    if (lecture.Discription39 == "Soap opera \nмыльная опера")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "soap_opera.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription39;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/soap_opera.mp3");
                    }
                    if (lecture.Discription39 == "Famine \nголод, чаще как стихийное бедствие")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "famine.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription39;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/famine.mp3");
                    }
                }
                if (numb == 40)
                {
                    if (lecture.Discription40 == "Break \nперерыв")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "brek.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription40;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/break.mp3");
                    }
                    if (lecture.Discription40 == "Quiz show \nшоу викторина")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "quiz_show.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription40;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/quiz_show.mp3");
                    }
                    if (lecture.Discription40 == "Life expectancy \nпродолжительность жизни")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "life_.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription40;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/life_expect.mp3");
                    }
                }
                if (numb == 41)
                {
                    if (lecture.Discription41 == "Lunch break \nобеденный перерыв")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "lunch_break.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription41;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/lunch_break.mp3");
                    }
                    if (lecture.Discription41 == "Chat show \nток шоу")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "chat_show.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription41;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/chat_show.mp3");
                    }
                    if (lecture.Discription41 == "Take part \nпринимать участие")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "take_part.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription41;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/take_part.mp3");
                    }
                }
                if (numb == 42)
                {
                    if (lecture.Discription42 == "Canteen \nстоловая")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "canteen.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription42;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/canteen.mp3");
                    }
                    if (lecture.Discription42 == "Documentary \nдокументальный фильм")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "documentary.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription42;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/documentary.mp3");
                    }
                    if (lecture.Discription42 == "Natural sciences \nестественные науки")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "natural_sciences.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription42;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/natural_siencis.mp3");
                    }
                }
                if (numb == 43)
                {
                    if (lecture.Discription43 == "Buffet \nбуфет")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "bufet.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription43;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/buffet.mp3");
                    }
                    if (lecture.Discription43 == "Series \nсериал (каждая cерия cама по себе)")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "series_serial.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription43;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/series.mp3");
                    }
                    if (lecture.Discription43 == "Social and behavioral sciences \nсоциальные и поведенческие науки")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "social_science.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription43;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/soc_beh_sciences.mp3");
                    }
                }
                if (numb == 44)
                {
                    if (lecture.Discription44 == "Take exams \ncдавать экзамены (процесс)")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "take_exams.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription44;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/take_exams.mp3");
                    }
                    if (lecture.Discription44 == "Current affairs \nновости")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "current_affairs.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription44;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/current_affairs.mp3");
                    }
                    if (lecture.Discription44 == "Formal sciences \nточные науки")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "formal_sciences.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription44;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/formal_siens.mp3");
                    }
                }
                if (numb == 45)
                {
                    if (lecture.Discription45 == "Pass exams \nсдать экзамены (результат)")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "pass_exams.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription45;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/pass_exams.mp3");
                    }
                    if (lecture.Discription45 == "Cable TV \nкабельное телевидение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "cable_tv.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription45;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/cable_tv.mp3");
                    }
                    if (lecture.Discription45 == "Applied sciences \nприкладные науки")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "applied_sciences.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription45;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/applied_sienc.mp3");
                    }
                }
                if (numb == 46)
                {
                    if (lecture.Discription46 == "Successfully \nуспешно")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "Successfuly.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription46;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/succesfuly.mp3");
                    }
                    if (lecture.Discription46 == "Satellite TV \nспутниковое телевидение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "satellite_tv.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription46;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/settelite_tv.mp3");
                    }
                    if (lecture.Discription46 == "Ecology \nэкология")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "ecology.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription46;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/ecology.mp3");
                    }
                }
                if (numb == 47)
                {
                    if (lecture.Discription47 == "Be situated \nрасполагаться")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "be_situated.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription47;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/be_situated.mp3");
                    }
                    if (lecture.Discription47 == "Commercial \nреклама на ТВ")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "commercial.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription47;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/commercial.mp3");
                    }
                    if (lecture.Discription47 == "App \nприложение")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "app.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription47;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/app.mp3");
                    }
                }
                if (numb == 48)
                {
                    if (lecture.Discription48 == "Occupy \nзанимать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "occupy.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription48;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/occupy.mp3");
                    }
                    if (lecture.Discription48 == "Advertisement \nрекламное объявление")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "advertisement.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription48;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/advertisement.mp3");
                    }
                    if (lecture.Discription48 == "Data \nданные")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "data.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription48;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/data.mp3");
                    }
                }
                if (numb == 49)
                {
                    if (lecture.Discription49 == "Cloak-room \nгардероб")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "cloak_room.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription49;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/cloak_room.mp3");
                    }
                    if (lecture.Discription49 == "Favourite \nлюбимый")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "favourite.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription49;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/favourite.mp3");
                    }
                    if (lecture.Discription49 == "Web \nвсемирная паутина")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "web.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription49;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/web.mp3");
                    }
                }
                if (numb == 50)
                {
                    if (lecture.Discription50 == "Headmaster \nдиректор")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "headmaster.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription50;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/head_master.mp3");
                    }
                    if (lecture.Discription50 == "Tabloid \nнебольшая газета")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "tabloid.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription50;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/tabloid.mp3");
                    }
                    if (lecture.Discription50 == "Earphones \nнаушники")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "earphones.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription50;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/earph.mp3");
                    }
                    
                }
                if (numb == 51)
                {
                    if (lecture.Discription51 == "Headmaster’s office \nкабинет директора")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "headmast_off.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription51;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/head_masters_off.mp3");
                    }
                    if (lecture.Discription51 == "Article \nстатья")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "article.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription51;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/artical.mp3");
                    }
                    if (lecture.Discription51 == "Launch \nзапускать / начинать")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "launch.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription51;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Science/launch.mp3");
                    }
                }
                if (numb == 52)
                {
                    if (lecture.Discription52 == "Teacher’s room \nпреподавательская")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "teachers_room.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription52;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/teachers_room.mp3");
                    }
                    if (lecture.Discription52 == "Adverts \nреклама")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "adverts.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription52;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/adverts.mp3");
                    }
                }
                if (numb == 53)
                {
                    if (lecture.Discription53 == "Room \nкабинет")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "room.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription53;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/room.mp3");
                    }
                    if (lecture.Discription53 == "Broadsheet \nбольшая газета")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "broadsheet.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription53;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/broadsheet.mp3");
                    }
                }
                if (numb == 54)
                {
                    if (lecture.Discription54 == "Library \nбиблиотека")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "library.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription54;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/library.mp3");
                    }
                    if (lecture.Discription54 == "Headline \nзаголовок")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "headline.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription54;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/headline.mp3");
                    }
                }
                if (numb == 55)
                {
                    if (lecture.Discription55 == "Gym \nспортзал")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "gym.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription55;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/gym.mp3");
                    }
                    if (lecture.Discription55 == "Serial \nсериал (одна тема на все серии)")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "series_serial.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription55;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/serial.mp3");
                    }
                }
                if (numb == 56)
                {
                    if (lecture.Discription56 == "Assembly hall \nактовый зал")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "assembly_hall.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription56;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/asembly_hall.mp3");
                    }
                    if (lecture.Discription56 == "War film \nфильм о войне")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "war_action_film.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription56;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/war_film.mp3");
                    }
                }
                if (numb == 57)
                {
                    if (lecture.Discription57 == "Tutor \nкуратор")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "tutor.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription57;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/tutor.mp3");
                    }
                    if (lecture.Discription57 == "Romance \nмелодрама")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "romance_comedy.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription57;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/romance.mp3");
                    }
                }
                if (numb == 58)
                {
                    if (lecture.Discription58 == "Monitor \ncтароста")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "monitor.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription58;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/monitor.mp3");
                    }
                    if (lecture.Discription58 == "Thriller \nтриллер")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "thriller.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription58;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/thriller.mp3");
                    }
                }
                if (numb == 59)
                {
                    if (lecture.Discription59 == "Subject \nпредмет")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "subject.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription59;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Educ/subject.mp3");
                    }
                    if (lecture.Discription59 == "Disaster movie \nфильм-катастрофа")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "disaster_movie.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription59;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/desister_movie.mp3");
                    }
                }
                if (numb == 60)
                {
                    if (lecture.Discription60 == "Action film \nбоевик")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "war_action_film.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription60;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/action_film.mp3");
                    }
                }
                if (numb == 61)
                {
                    if (lecture.Discription61 == "Horror film \nфильм ужасов")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "horror_film.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription61;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/horror_film.mp3");
                    }
                }
                if (numb == 62)
                {
                    if (lecture.Discription62 == "Comedy \nкомедия")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "comedy.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription62;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/comedy.mp3");
                    }
                }
                if (numb == 63)
                {
                    if (lecture.Discription63 == "Romantic comedy \nромантическая комедия")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "romance_comedy.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription63;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/romantic_comedy.mp3");
                    }
                }
                if (numb == 64)
                {
                    if (lecture.Discription64 == "Moving \nтрогательный / грустный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "moving.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription64;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/moving.mp3");
                    }
                }
                if (numb == 65)
                {
                    if (lecture.Discription65 == "Violent \nжестокий")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "violent.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription65;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/violent.mp3");
                    }
                }
                if (numb == 66)
                {
                    if (lecture.Discription66 == "Violence \nжестокость")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "violent.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription66;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/violence.mp3");
                    }
                }
                if (numb == 67)
                {
                    if (lecture.Discription67 == "Awful \nужасный / плохой")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "awful.jpg";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription67;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/awful.mp3");
                    }
                }
                if (numb == 68)
                {
                    if (lecture.Discription68 == "Slow \nнудный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "slow.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription68;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/slow.mp3");
                    }
                }
                if (numb == 69)
                {
                    if (lecture.Discription69 == "Boring \nскучный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "boring.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription69;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/boring.mp3");
                    }
                }
                if (numb == 70)
                {
                    if (lecture.Discription70 == "Gripping \nзахватывающий")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "gripping.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription70;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/gripping.mp3");
                    }
                }
                if (numb == 71)
                {
                    if (lecture.Discription71 == "Exciting \nволнующий")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "existing.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription71;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/exiting.mp3");
                    }
                }
                if (numb == 72)
                {
                    if (lecture.Discription72 == "Terrible \nужасный")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "terrible.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription72;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/terrible.mp3");
                    }
                }
                if (numb == 73)
                {
                    if (lecture.Discription73 == "Funny \nсмешной")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "funny.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription73;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/funny.mp3");
                    }
                }
                if (numb == 74)
                {
                    if (lecture.Discription74 == "Weather forecast \nпрогноз погоды")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "weather_forecast.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription74;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/weather_forecast.mp3");
                    }
                }
                if (numb == 75)
                {
                    if (lecture.Discription75 == "Cartoon \nмультфильм")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "cartoon.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription75;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/cartoon.mp3");
                    }
                }
                if (numb == 76)
                {
                    if (lecture.Discription76 == "Waste оf time \nпустая трата времени")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "waste_of_time.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription76;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/waste_of_time.mp3");
                    }
                }
                if (numb == 77)
                {
                    if (lecture.Discription77 == "Feature film \nхудожественный фильм")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "feature_film.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription77;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/feature_film.mp3");
                    }
                }
                if (numb == 78)
                {
                    if (lecture.Discription78 == "Touching \nтрогательный / доводящий до слез")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "touching.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription78;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/touching.mp3");
                    }
                }
                if (numb == 79)
                {
                    if (lecture.Discription79 == "Star \nиграющий главную роль")
                    {
                        this.lecture = lecture;
                        BannerImg.Source = "star.png";
                        BannerImg.HeightRequest = 400;
                        BannerImg.WidthRequest = 400;
                        name.Text = lecture.Discription79;
                        //inf.Text = "Это слово означает приветствие!";
                        player = CrossSimpleAudioPlayer.Current;
                        player.Load("Media/star.mp3");
                    }
                }

            }
            catch (System.Exception ex){ Console.WriteLine(ex); }

        }

        private async void But_Clicked(object sender, EventArgs e)
        {
            await App.Current.MainPage.Navigation.PopAsync();
        }
        private async void But_Sound_Click(object sender, EventArgs e)
        {
            try
            {
                player.Play();
            }
            catch { }
        }
    }
}