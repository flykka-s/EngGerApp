using Android.Views;
using LearnApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Markup;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LearnApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LectureP : ContentPage
    {
        Lecture _lecture;
        string language;
        public LectureP(ref Lecture lec, string lang)
        {
            language = lang;
            List<Label> labels = new List<Label> {
            label1, label2, label3, label4, label5, label6, label7, label8, label9, label10,
            label11, label12, label13, label14, label15, label16, label17, label18, label19, label20,
            label21, label22, label23, label24, label25, label26, label27, label28, label29, label30,
            label31, label32, label33, label34, label35, label36, label37, label38, label39, label40,
            label41, label42, label43, label44, label45, label46, label47, label48, label49, label50,
            label51, label52, label53, label54, label55, label56, label57, label58, label59, label60,
            label61, label62, label63, label64, label65, label66, label67, label68, label69, label70,
            label71, label72, label73, label74, label75, label76, label77, label78, label79
            };

           
            _lecture = lec;
            
            List<string> discriptions = new List<string> {
                lec.Discription1,  lec.Discription2,  lec.Discription3, lec.Discription4, lec.Discription5, lec.Discription6, lec.Discription7, lec.Discription8, 
                lec.Discription9, lec.Discription10, lec.Discription11, lec.Discription12, lec.Discription13, lec.Discription14, lec.Discription15, lec.Discription16, 
                lec.Discription17, lec.Discription18, lec.Discription19, lec.Discription20, lec.Discription21, lec.Discription22, lec.Discription23, lec.Discription24,
                lec.Discription25, lec.Discription26, lec.Discription27, lec.Discription28, lec.Discription29, lec.Discription30, lec.Discription31, lec.Discription32, 
                lec.Discription33, lec.Discription34, lec.Discription35, lec.Discription36, lec.Discription37, lec.Discription38, lec.Discription39, lec.Discription40,
                lec.Discription41, lec.Discription42, lec.Discription43, lec.Discription44, lec.Discription45, lec.Discription46, lec.Discription47, lec.Discription48, 
                lec.Discription49, lec.Discription50, lec.Discription51, lec.Discription52, lec.Discription53, lec.Discription54, lec.Discription55, lec.Discription56, 
                lec.Discription57, lec.Discription58, lec.Discription59, lec.Discription60, lec.Discription61, lec.Discription62, lec.Discription63, lec.Discription64, 
                lec.Discription65, lec.Discription66, lec.Discription67, lec.Discription68, lec.Discription69, lec.Discription70, lec.Discription71, lec.Discription72, 
                lec.Discription73, lec.Discription74, lec.Discription75, lec.Discription76, lec.Discription77, lec.Discription78, lec.Discription79
            };

            List<BoxView> bViews = new List<BoxView> {
            bView1, bView2, bView3, bView4, bView5, bView6, bView7, bView8, bView9, bView10,
            bView11, bView12, bView13, bView14, bView15, bView16, bView17, bView18, bView19, bView20,
            bView21, bView22, bView23, bView24, bView25, bView26, bView27, bView28, bView29, bView30,
            bView31, bView32, bView33, bView34, bView35, bView36, bView37, bView38, bView39, bView40,
            bView41, bView42, bView43, bView44, bView45, bView46, bView47, bView48, bView49, bView50,
            bView51, bView52, bView53, bView54, bView55, bView56, bView57, bView58, bView59, bView60,
            bView61, bView62, bView63, bView64, bView65, bView66, bView67, bView68, bView69, bView70,
            bView71, bView72, bView73, bView74, bView75, bView76, bView77, bView78, bView79
            };

            List<Button> buttons = new List<Button> {
                button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
                button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
                button31, button32, button33, button34, button35, button36, button37, button38, button39, button40,
                button41, button42, button43, button44, button45, button46, button47, button48, button49, button50,
                button51, button52, button53, button54, button55, button56, button57, button58, button59, button60,
                button61, button62, button63, button64, button65, button66, button67, button68, button69, button70,
                button71, button72, button73, button74, button75, button76, button77, button78, button79
            };

            InitializeComponent();


            if (lec.Discription1 == "")
            {
                label1.IsVisible = !label1.IsVisible;
                button1.IsVisible = !button1.IsVisible;
                bView1.IsVisible = !bView1.IsVisible;
            }
            if (lec.Discription2 == "")
            {
                label2.IsVisible = !label2.IsVisible;
                button2.IsVisible = !button2.IsVisible;
                bView2.IsVisible = !bView2.IsVisible;
            }
            if (lec.Discription3 == "")
            {
                label3.IsVisible = !label3.IsVisible;
                button3.IsVisible = !button3.IsVisible;
                bView3.IsVisible = !bView3.IsVisible;
            }
            if (lec.Discription4 == "")
            {
                label4.IsVisible = !label4.IsVisible;
                button4.IsVisible = !button4.IsVisible;
                bView4.IsVisible = !bView4.IsVisible;
            }
            if (lec.Discription5 == "")
            {
                label5.IsVisible = !label5.IsVisible;
                button5.IsVisible = !button5.IsVisible;
                bView5.IsVisible = !bView5.IsVisible;
            }
            if (lec.Discription6 == "")
            {
                label6.IsVisible = !label6.IsVisible;
                button6.IsVisible = !button6.IsVisible;
                bView6.IsVisible = !bView6.IsVisible;
            }
            if (lec.Discription7 == "")
            {
                label7.IsVisible = !label7.IsVisible;
                button7.IsVisible = !button7.IsVisible;
                bView7.IsVisible = !bView7.IsVisible;
            }
            if (lec.Discription8 == "")
            {
                label8.IsVisible = !label8.IsVisible;
                button8.IsVisible = !button8.IsVisible;
                bView8.IsVisible = !bView8.IsVisible;
            }
            if (lec.Discription9 == "")
            {
                label9.IsVisible = !label9.IsVisible;
                button9.IsVisible = !button9.IsVisible;
                bView9.IsVisible = !bView9.IsVisible;
            }
            if (lec.Discription10 == "")
            {
                label10.IsVisible = !label10.IsVisible;
                button10.IsVisible = !button10.IsVisible;
                bView10.IsVisible = !bView10.IsVisible;
            }
            if (lec.Discription11 == "")
            {
                label11.IsVisible = !label11.IsVisible;
                button11.IsVisible = !button11.IsVisible;
                bView11.IsVisible = !bView11.IsVisible;
            }
            if (lec.Discription12 == "")
            {
                label12.IsVisible = !label12.IsVisible;
                button12.IsVisible = !button12.IsVisible;
                bView12.IsVisible = !bView12.IsVisible;
            }
            if (lec.Discription13 == "")
            {
                label13.IsVisible = !label13.IsVisible;
                button13.IsVisible = !button13.IsVisible;
                bView13.IsVisible = !bView13.IsVisible;
            }
            if (lec.Discription14 == "")
            {
                label14.IsVisible = !label14.IsVisible;
                button14.IsVisible = !button14.IsVisible;
                bView14.IsVisible = !bView14.IsVisible;
            }
            if (lec.Discription15 == "")
            {
                label15.IsVisible = !label15.IsVisible;
                button15.IsVisible = !button15.IsVisible;
                bView15.IsVisible = !bView15.IsVisible;
            }
            if (lec.Discription16 == "")
            {
                label16.IsVisible = !label16.IsVisible;
                button16.IsVisible = !button16.IsVisible;
                bView16.IsVisible = !bView16.IsVisible;
            }
            if (lec.Discription17 == "")
            {
                label17.IsVisible = !label17.IsVisible;
                button17.IsVisible = !button17.IsVisible;
                bView17.IsVisible = !bView17.IsVisible;
            }
            if (lec.Discription18 == "")
            {
                label18.IsVisible = !label18.IsVisible;
                button18.IsVisible = !button18.IsVisible;
                bView18.IsVisible = !bView18.IsVisible;
            }
            if (lec.Discription19 == "")
            {
                label19.IsVisible = !label19.IsVisible;
                button19.IsVisible = !button19.IsVisible;
                bView19.IsVisible = !bView19.IsVisible;
            }
            if (lec.Discription20 == "")
            {
                label20.IsVisible = !label20.IsVisible;
                button20.IsVisible = !button20.IsVisible;
                bView20.IsVisible = !bView20.IsVisible;
            }
            if (lec.Discription21 == "")
            {
                label21.IsVisible = !label21.IsVisible;
                button21.IsVisible = !button21.IsVisible;
                bView21.IsVisible = !bView21.IsVisible;
            }
            if (lec.Discription22 == "")
            {
                label22.IsVisible = !label22.IsVisible;
                button22.IsVisible = !button22.IsVisible;
                bView22.IsVisible = !bView22.IsVisible;
            }
            if (lec.Discription23 == "")
            {
                label23.IsVisible = !label23.IsVisible;
                button23.IsVisible = !button23.IsVisible;
                bView23.IsVisible = !bView23.IsVisible;
            }
            if (lec.Discription24 == "")
            {
                label24.IsVisible = !label24.IsVisible;
                button24.IsVisible = !button24.IsVisible;
                bView24.IsVisible = !bView24.IsVisible;
            }
            if (lec.Discription25 == "")
            {
                label25.IsVisible = !label25.IsVisible;
                button25.IsVisible = !button25.IsVisible;
                bView25.IsVisible = !bView25.IsVisible;
            }
            if (lec.Discription26 == "")
            {
                label26.IsVisible = !label26.IsVisible;
                button26.IsVisible = !button26.IsVisible;
                bView26.IsVisible = !bView26.IsVisible;
            }
            if (lec.Discription27 == "")
            {
                label27.IsVisible = !label27.IsVisible;
                button27.IsVisible = !button27.IsVisible;
                bView27.IsVisible = !bView27.IsVisible;
            }
            if (lec.Discription28 == "")
            {
                label28.IsVisible = !label28.IsVisible;
                button28.IsVisible = !button28.IsVisible;
                bView28.IsVisible = !bView28.IsVisible;
            }
            if (lec.Discription29 == "")
            {
                label29.IsVisible = !label29.IsVisible;
                button29.IsVisible = !button29.IsVisible;
                bView29.IsVisible = !bView29.IsVisible;
            }
            if (lec.Discription30 == "")
            {
                label30.IsVisible = !label30.IsVisible;
                button30.IsVisible = !button30.IsVisible;
                bView30.IsVisible = !bView30.IsVisible;
            }
            if (lec.Discription31 == "")
            {
                label31.IsVisible = !label31.IsVisible;
                button31.IsVisible = !button31.IsVisible;
                bView31.IsVisible = !bView31.IsVisible;
            }
            if (lec.Discription32 == "")
            {
                label32.IsVisible = !label32.IsVisible;
                button32.IsVisible = !button32.IsVisible;
                bView32.IsVisible = !bView32.IsVisible;
            }
            if (lec.Discription33 == "")
            {
                label33.IsVisible = !label33.IsVisible;
                button33.IsVisible = !button33.IsVisible;
                bView33.IsVisible = !bView33.IsVisible;
            }
            if (lec.Discription34 == "")
            {
                label34.IsVisible = !label34.IsVisible;
                button34.IsVisible = !button34.IsVisible;
                bView34.IsVisible = !bView34.IsVisible;
            }
            if (lec.Discription35 == "")
            {
                label35.IsVisible = !label35.IsVisible;
                button35.IsVisible = !button35.IsVisible;
                bView35.IsVisible = !bView35.IsVisible;
            }
            if (lec.Discription36 == "")
            {
                label36.IsVisible = !label36.IsVisible;
                button36.IsVisible = !button36.IsVisible;
                bView36.IsVisible = !bView36.IsVisible;
            }
            if (lec.Discription37 == "")
            {
                label37.IsVisible = !label37.IsVisible;
                button37.IsVisible = !button37.IsVisible;
                bView37.IsVisible = !bView37.IsVisible;
            }
            if (lec.Discription38 == "")
            {
                label38.IsVisible = !label38.IsVisible;
                button38.IsVisible = !button38.IsVisible;
                bView38.IsVisible = !bView38.IsVisible;
            }
            if (lec.Discription39 == "")
            {
                label39.IsVisible = !label39.IsVisible;
                button39.IsVisible = !button39.IsVisible;
                bView39.IsVisible = !bView39.IsVisible;
            }
            if (lec.Discription40 == "")
            {
                label40.IsVisible = !label40.IsVisible;
                button40.IsVisible = !button40.IsVisible;
                bView40.IsVisible = !bView40.IsVisible;
            }
            if (lec.Discription41 == "")
            {
                label41.IsVisible = !label41.IsVisible;
                button41.IsVisible = !button41.IsVisible;
                bView41.IsVisible = !bView41.IsVisible;
            }
            if (lec.Discription42 == "")
            {
                label42.IsVisible = !label42.IsVisible;
                button42.IsVisible = !button42.IsVisible;
                bView42.IsVisible = !bView42.IsVisible;
            }
            if (lec.Discription43 == "")
            {
                label43.IsVisible = !label43.IsVisible;
                button43.IsVisible = !button43.IsVisible;
                bView43.IsVisible = !bView43.IsVisible;
            }
            if (lec.Discription44 == "")
            {
                label44.IsVisible = !label44.IsVisible;
                button44.IsVisible = !button44.IsVisible;
                bView44.IsVisible = !bView44.IsVisible;
            }
            if (lec.Discription45 == "")
            {
                label45.IsVisible = !label45.IsVisible;
                button45.IsVisible = !button45.IsVisible;
                bView45.IsVisible = !bView45.IsVisible;
            }
            if (lec.Discription46 == "")
            {
                label46.IsVisible = !label46.IsVisible;
                button46.IsVisible = !button46.IsVisible;
                bView46.IsVisible = !bView46.IsVisible;
            }
            if (lec.Discription47 == "")
            {
                label47.IsVisible = !label47.IsVisible;
                button47.IsVisible = !button47.IsVisible;
                bView47.IsVisible = !bView47.IsVisible;
            }
            if (lec.Discription48 == "")
            {
                label48.IsVisible = !label48.IsVisible;
                button48.IsVisible = !button48.IsVisible;
                bView48.IsVisible = !bView48.IsVisible;
            }
            if (lec.Discription49 == "")
            {
                label49.IsVisible = !label49.IsVisible;
                button49.IsVisible = !button49.IsVisible;
                bView49.IsVisible = !bView49.IsVisible;
            }
            if (lec.Discription50 == "")
            {
                label50.IsVisible = !label50.IsVisible;
                button50.IsVisible = !button50.IsVisible;
                bView50.IsVisible = !bView50.IsVisible;
            }
            if (lec.Discription51 == "")
            {
                label51.IsVisible = !label51.IsVisible;
                button51.IsVisible = !button51.IsVisible;
                bView51.IsVisible = !bView51.IsVisible;
            }
            if (lec.Discription52 == "")
            {
                label52.IsVisible = !label52.IsVisible;
                button52.IsVisible = !button52.IsVisible;
                bView52.IsVisible = !bView52.IsVisible;
            }
            if (lec.Discription53 == "")
            {
                label53.IsVisible = !label53.IsVisible;
                button53.IsVisible = !button53.IsVisible;
                bView53.IsVisible = !bView53.IsVisible;
            }
            if (lec.Discription54 == "")
            {
                label54.IsVisible = !label54.IsVisible;
                button54.IsVisible = !button54.IsVisible;
                bView54.IsVisible = !bView54.IsVisible;
            }
            if (lec.Discription55 == "")
            {
                label55.IsVisible = !label55.IsVisible;
                button55.IsVisible = !button55.IsVisible;
                bView55.IsVisible = !bView55.IsVisible;
            }
            if (lec.Discription56 == "")
            {
                label56.IsVisible = !label56.IsVisible;
                button56.IsVisible = !button56.IsVisible;
                bView56.IsVisible = !bView56.IsVisible;
            }
            if (lec.Discription57 == "")
            {
                label57.IsVisible = !label57.IsVisible;
                button57.IsVisible = !button57.IsVisible;
                bView57.IsVisible = !bView57.IsVisible;
            }
            if (lec.Discription58 == "")
            {
                label58.IsVisible = !label58.IsVisible;
                button58.IsVisible = !button58.IsVisible;
                bView58.IsVisible = !bView58.IsVisible;
            }
            if (lec.Discription59 == "")
            {
                label59.IsVisible = !label59.IsVisible;
                button59.IsVisible = !button59.IsVisible;
                bView59.IsVisible = !bView59.IsVisible;
            }
            if (lec.Discription60 == "")
            {
                label60.IsVisible = !label60.IsVisible;
                button60.IsVisible = !button60.IsVisible;
                bView60.IsVisible = !bView60.IsVisible;
            }
            if (lec.Discription61 == "")
            {
                label61.IsVisible = !label61.IsVisible;
                button61.IsVisible = !button61.IsVisible;
                bView61.IsVisible = !bView61.IsVisible;
            }
            if (lec.Discription62 == "")
            {
                label62.IsVisible = !label62.IsVisible;
                button62.IsVisible = !button62.IsVisible;
                bView62.IsVisible = !bView62.IsVisible;
            }
            if (lec.Discription63 == "")
            {
                label63.IsVisible = !label63.IsVisible;
                button63.IsVisible = !button63.IsVisible;
                bView63.IsVisible = !bView63.IsVisible;
            }
            if (lec.Discription64 == "")
            {
                label64.IsVisible = !label64.IsVisible;
                button64.IsVisible = !button64.IsVisible;
                bView64.IsVisible = !bView64.IsVisible;
            }
            if (lec.Discription65 == "")
            {
                label65.IsVisible = !label65.IsVisible;
                button65.IsVisible = !button65.IsVisible;
                bView65.IsVisible = !bView65.IsVisible;
            }
            if (lec.Discription66 == "")
            {
                label66.IsVisible = !label66.IsVisible;
                button66.IsVisible = !button66.IsVisible;
                bView66.IsVisible = !bView66.IsVisible;
            }
            if (lec.Discription67 == "")
            {
                label67.IsVisible = !label67.IsVisible;
                button67.IsVisible = !button67.IsVisible;
                bView67.IsVisible = !bView67.IsVisible;
            }
            if (lec.Discription68 == "")
            {
                label68.IsVisible = !label68.IsVisible;
                button68.IsVisible = !button68.IsVisible;
                bView68.IsVisible = !bView68.IsVisible;
            }
            if (lec.Discription69 == "")
            {
                label69.IsVisible = !label69.IsVisible;
                button69.IsVisible = !button69.IsVisible;
                bView69.IsVisible = !bView69.IsVisible;
            }
            if (lec.Discription70 == "")
            {
                label70.IsVisible = !label70.IsVisible;
                button70.IsVisible = !button70.IsVisible;
                bView70.IsVisible = !bView70.IsVisible;
            }
            if (lec.Discription71 == "")
            {
                label71.IsVisible = !label71.IsVisible;
                button71.IsVisible = !button71.IsVisible;
                bView71.IsVisible = !bView71.IsVisible;
            }
            if (lec.Discription72 == "")
            {
                label72.IsVisible = !label72.IsVisible;
                button72.IsVisible = !button72.IsVisible;
                bView72.IsVisible = !bView72.IsVisible;
            }
            if (lec.Discription73 == "")
            {
                label73.IsVisible = !label73.IsVisible;
                button73.IsVisible = !button73.IsVisible;
                bView73.IsVisible = !bView73.IsVisible;
            }
            if (lec.Discription74 == "")
            {
                label74.IsVisible = !label74.IsVisible;
                button74.IsVisible = !button74.IsVisible;
                bView74.IsVisible = !bView74.IsVisible;
            }
            if (lec.Discription75 == "")
            {
                label75.IsVisible = !label75.IsVisible;
                button75.IsVisible = !button75.IsVisible;
                bView75.IsVisible = !bView75.IsVisible;
            }
            if (lec.Discription76 == "")
            {
                label76.IsVisible = !label76.IsVisible;
                button76.IsVisible = !button76.IsVisible;
                bView76.IsVisible = !bView76.IsVisible;
            }
            if (lec.Discription77 == "")
            {
                label77.IsVisible = !label77.IsVisible;
                button77.IsVisible = !button77.IsVisible;
                bView77.IsVisible = !bView77.IsVisible;
            }
            if (lec.Discription78 == "")
            {
                label78.IsVisible = !label78.IsVisible;
                button78.IsVisible = !button78.IsVisible;
                bView78.IsVisible = !bView78.IsVisible;
            }
            if (lec.Discription79 == "")
            {
                label79.IsVisible = !label79.IsVisible;
                button79.IsVisible = !button79.IsVisible;
                bView79.IsVisible = !bView79.IsVisible;
            }
            







            label1.Text = lec.Discription1;
            //image1.Source = lec.Image1;
            label2.Text = lec.Discription2;
            //image2.Source = lec.Image2;
            label3.Text = lec.Discription3;
            label4.Text = lec.Discription4;
            label5.Text = lec.Discription5;
            label6.Text = lec.Discription6;
            label7.Text = lec.Discription7;
            label8.Text = lec.Discription8;
            label9.Text = lec.Discription9;
            label10.Text = lec.Discription10;
            label11.Text = lec.Discription11;
            label12.Text = lec.Discription12;
            label13.Text = lec.Discription13;
            label14.Text = lec.Discription14;
            label15.Text = lec.Discription15;
            label16.Text = lec.Discription16;
            label17.Text = lec.Discription17;
            label18.Text = lec.Discription18;
            label19.Text = lec.Discription19;
            label20.Text = lec.Discription20;
            label21.Text = lec.Discription21;
            label22.Text = lec.Discription22;
            label23.Text = lec.Discription23;
            label24.Text = lec.Discription24;
            label25.Text = lec.Discription25;
            label26.Text = lec.Discription26;
            label27.Text = lec.Discription27;
            label28.Text = lec.Discription28;
            label29.Text = lec.Discription29;
            label30.Text = lec.Discription30;
            label31.Text = lec.Discription31;
            label32.Text = lec.Discription32;
            label33.Text = lec.Discription33;
            label34.Text = lec.Discription34;
            label35.Text = lec.Discription35;
            label36.Text = lec.Discription36;
            label37.Text = lec.Discription37;
            label38.Text = lec.Discription38;
            label39.Text = lec.Discription39;
            label40.Text = lec.Discription40;
            label41.Text = lec.Discription41;
            label42.Text = lec.Discription42;
            label43.Text = lec.Discription43;
            label44.Text = lec.Discription44;
            label45.Text = lec.Discription45;
            label46.Text = lec.Discription46;
            label47.Text = lec.Discription47;
            label48.Text = lec.Discription48;
            label49.Text = lec.Discription49;
            label50.Text = lec.Discription50;
            label51.Text = lec.Discription51;
            label52.Text = lec.Discription52;
            label53.Text = lec.Discription53;
            label54.Text = lec.Discription54;
            label55.Text = lec.Discription55;
            label56.Text = lec.Discription56;
            label57.Text = lec.Discription57;
            label58.Text = lec.Discription58;
            label59.Text = lec.Discription59;
            label60.Text = lec.Discription60;
            label61.Text = lec.Discription61;
            label62.Text = lec.Discription62;
            label63.Text = lec.Discription63;
            label64.Text = lec.Discription64;
            label65.Text = lec.Discription65;
            label66.Text = lec.Discription66;
            label67.Text = lec.Discription67;
            label68.Text = lec.Discription68;
            label69.Text = lec.Discription69;
            label70.Text = lec.Discription70;
            label71.Text = lec.Discription71;
            label72.Text = lec.Discription72;
            label73.Text = lec.Discription73;
            label74.Text = lec.Discription74;
            label75.Text = lec.Discription75;
            label76.Text = lec.Discription76;
            label77.Text = lec.Discription77;
            label78.Text = lec.Discription78;
            label79.Text = lec.Discription79;
            
            zag.Text = lec.Title;
            //glav.Text = lec.Chapter;
        }


        public async void Skip_Down_Click(object sender, EventArgs e) {
            await scrollView.ScrollToAsync(scrollView.Content, ScrollToPosition.End, true); 
        }
        public async void Skip_Up_Click(object sender, EventArgs e)
        {
            await scrollView.ScrollToAsync(scrollView.Content, ScrollToPosition.Start, true);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            
                try
                {
                
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new Page1(_lecture)));
                }
                catch (System.Exception ex)
                {
                }
                // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
                //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

                // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }

        private async void Button_Clicked1(object sender, EventArgs e)
        {

            try
            {
                if (language == "eng")
                {
                    await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TestsPage())); 
                }
                else if (language == "ger")
                {
                    await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TestsGerPage()));
                }
            }
            catch (System.Exception ex)
            {
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }

        private async void Button_Clicked2t(object sender, EventArgs e)
        {

            try
            {
                if (language == "eng")
                {
                    await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TaskPPage()));
                }
                else if (language == "ger")
                {
                    await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new TaskGerPPage()));
                }
            }
            catch (System.Exception ex)
            {
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }

        private async void Button_Clicked1_1(object sender, EventArgs e)
        {

            try
            {
                int number = 1;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
                
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }
        private async void Button_Clicked2(object sender, EventArgs e)
        {

            try
            {
                int number = 2;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private async void Button_Clicked3_1(object sender, EventArgs e)
        {

            try
            {
                int number = 3;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
          
        }
        private async void Button_Clicked4(object sender, EventArgs e)
        {

            try
            {
                int number = 4;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }
        private async void Button_Clicked5(object sender, EventArgs e)
        {

            try
            {
                int number = 5;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        private async void Button_Clicked6(object sender, EventArgs e)
        {

            try
            {
                int number = 6;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
          
        }
        private async void Button_Clicked7(object sender, EventArgs e)
        {

            try
            {
                int number = 7;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }
        private async void Button_Clicked8(object sender, EventArgs e)
        {

            try
            {
                int number = 8;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
           
        }

        private async void Button_Clicked9(object sender, EventArgs e)
        {

            try
            {
                int number = 9;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }

        private async void Button_Clicked10(object sender, EventArgs e)
        {

            try
            {
                int number = 10;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            
        }
        private async void Button_Clicked11(object sender, EventArgs e)
        {

            try
            {
                int number = 11;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private async void Button_Clicked12(object sender, EventArgs e)
        {

            try
            {
                int number = 12;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private async void Button_Clicked13(object sender, EventArgs e)
        {

            try
            {
                int number = 13;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked14(object sender, EventArgs e)
        {

            try
            {
                int number = 14;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked15(object sender, EventArgs e)
        {

            try
            {
                int number = 15;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked16(object sender, EventArgs e)
        {

            try
            {
                int number = 16;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked17(object sender, EventArgs e)
        {

            try
            {
                int number = 17;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked18(object sender, EventArgs e)
        {

            try
            {
                int number = 18;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private async void Button_Clicked19(object sender, EventArgs e)
        {

            try
            {
                int number = 19;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private async void Button_Clicked20(object sender, EventArgs e)
        {

            try
            {
                int number = 20;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked21(object sender, EventArgs e)
        {

            try
            {
                int number = 21;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private async void Button_Clicked22(object sender, EventArgs e)
        {

            try
            {
                int number = 22;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private async void Button_Clicked23(object sender, EventArgs e)
        {

            try
            {
                int number = 23;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private async void Button_Clicked24(object sender, EventArgs e)
        {

            try
            {
                int number = 24;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked25(object sender, EventArgs e)
        {

            try
            {
                int number = 25;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked26(object sender, EventArgs e)
        {

            try
            {
                int number = 26;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked27(object sender, EventArgs e)
        {

            try
            {
                int number = 27;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked28(object sender, EventArgs e)
        {

            try
            {
                int number = 28;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked29(object sender, EventArgs e)
        {

            try
            {
                int number = 29;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked30(object sender, EventArgs e)
        {

            try
            {
                int number = 30;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked31(object sender, EventArgs e)
        {

            try
            {
                int number = 31;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked32(object sender, EventArgs e)
        {

            try
            {
                int number = 32;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked33(object sender, EventArgs e)
        {

            try
            {
                int number = 33;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked34(object sender, EventArgs e)
        {

            try
            {
                int number = 34;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked35(object sender, EventArgs e)
        {

            try
            {
                int number = 35;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked36(object sender, EventArgs e)
        {

            try
            {
                int number = 36;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked37(object sender, EventArgs e)
        {

            try
            {
                int number = 37;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked38(object sender, EventArgs e)
        {

            try
            {
                int number = 38;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked39(object sender, EventArgs e)
        {

            try
            {
                int number = 39;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked40(object sender, EventArgs e)
        {

            try
            {
                int number = 40;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        private async void Button_Clicked41(object sender, EventArgs e)
        {

            try
            {
                int number = 41;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked42(object sender, EventArgs e)
        {

            try
            {
                int number = 42;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked43(object sender, EventArgs e)
        {

            try
            {
                int number = 43;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked44(object sender, EventArgs e)
        {

            try
            {
                int number = 44;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked45(object sender, EventArgs e)
        {

            try
            {
                int number = 45;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked46(object sender, EventArgs e)
        {

            try
            {
                int number = 46;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked47(object sender, EventArgs e)
        {

            try
            {
                int number = 47;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked48(object sender, EventArgs e)
        {

            try
            {
                int number = 48;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked49(object sender, EventArgs e)
        {

            try
            {
                int number = 49;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked50(object sender, EventArgs e)
        {

            try
            {
                int number = 50;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked51(object sender, EventArgs e)
        {

            try
            {
                int number = 51;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked52(object sender, EventArgs e)
        {

            try
            {
                int number = 52;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked53(object sender, EventArgs e)
        {

            try
            {
                int number = 53;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked54(object sender, EventArgs e)
        {

            try
            {
                int number = 54;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked55(object sender, EventArgs e)
        {

            try
            {
                int number = 55;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked56(object sender, EventArgs e)
        {

            try
            {
                int number = 56;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked57(object sender, EventArgs e)
        {

            try
            {
                int number = 57;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked58(object sender, EventArgs e)
        {

            try
            {
                int number = 58;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked59(object sender, EventArgs e)
        {

            try
            {
                int number = 59;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked60(object sender, EventArgs e)
        {

            try
            {
                int number = 60;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked61(object sender, EventArgs e)
        {

            try
            {
                int number = 61;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked62(object sender, EventArgs e)
        {

            try
            {
                int number = 62;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked63(object sender, EventArgs e)
        {

            try
            {
                int number = 63;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked64(object sender, EventArgs e)
        {

            try
            {
                int number = 64;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked65(object sender, EventArgs e)
        {

            try
            {
                int number = 65;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked66(object sender, EventArgs e)
        {

            try
            {
                int number = 66;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked67(object sender, EventArgs e)
        {

            try
            {
                int number = 67;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked68(object sender, EventArgs e)
        {

            try
            {
                int number = 68;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked69(object sender, EventArgs e)
        {

            try
            {
                int number = 69;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked70(object sender, EventArgs e)
        {

            try
            {
                int number = 70;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked71(object sender, EventArgs e)
        {

            try
            {
                int number = 71;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked72(object sender, EventArgs e)
        {

            try
            {
                int number = 72;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked73(object sender, EventArgs e)
        {

            try
            {
                int number = 73;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked74(object sender, EventArgs e)
        {

            try
            {
                int number = 74;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked75(object sender, EventArgs e)
        {

            try
            {
                int number = 75;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked76(object sender, EventArgs e)
        {

            try
            {
                int number = 76;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked77(object sender, EventArgs e)
        {

            try
            {
                int number = 77;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }


        private async void Button_Clicked78(object sender, EventArgs e)
        {

            try
            {
                int number = 78;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private async void Button_Clicked79(object sender, EventArgs e)
        {

            try
            {
                int number = 79;
                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new InfoPage(_lecture, number)));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

   



        //статистика
        private async void Button_Clicked3(object sender, EventArgs e)
        {

            try
            {

                await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new StatisticsPage()));
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
            // await App.Current.MainPage.Navigation.PushAsync(new NavigationPage(new LearnApp.Pages.LectureP(test.Discription)));
            //await Application.Current.MainPage.DisplayAlert("Selected", lecture.Title, "OK");

            // Application.Current.MainPage.DisplayAlert("Инфа", "Здесь будет страница тестов", "OK");
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            Uri uri = new Uri($"{_lecture.VideoLink}");
            await Browser.OpenAsync(uri);
        }
    }
}