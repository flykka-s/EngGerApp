using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace LearnApp.Models
{
    [DataContract]
    public class Lecture
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Chapter { get; set; }
        public string Title { get; set; }
        public string Discription1 { get; set; }
        public string Image1 { get; set; }
        public string Discription2 { get; set; }
        public string Discription3 { get; set; }
        public string Discription4 { get; set; }
        public string Discription5 { get; set; }
        public string Discription6 { get; set; }
        public string Discription7 { get; set; }
        public string Discription8 { get; set; }
        public string Discription9 { get; set; }
        public string Discription10 { get; set; }
        public string Discription11 { get; set; }
        public string Discription12 { get; set; }
        public string Discription13 { get; set; }
        public string Discription14 { get; set; }
        public string Discription15 { get; set; }
        public string Discription16 { get; set; }
        public string Discription17 { get; set; }
        public string Discription18 { get; set; }
        public string Discription19 { get; set; }
        public string Discription20 { get; set; }
        public string Discription21 { get; set; }
        public string Discription22 { get; set; }
        public string Discription23 { get; set; }
        public string Discription24 { get; set; }
        public string Discription25 { get; set; }
        public string Discription26 { get; set; }
        public string Discription27 { get; set; }
        public string Discription28 { get; set; }
        public string Discription29 { get; set; }
        public string Discription30 { get; set; }
        public string Discription31 { get; set; }
        public string Discription32 { get; set; }
        public string Discription33 { get; set; }
        public string Discription34 { get; set; }
        public string Discription35 { get; set; }
        public string Discription36 { get; set; }
        public string Discription37 { get; set; }
        public string Discription38 { get; set; }
        public string Discription39 { get; set; }
        public string Discription40 { get; set; }
        public string Discription41 { get; set; }
        public string Discription42 { get; set; }
        public string Discription43 { get; set; }
        public string Discription44 { get; set; }
        public string Discription45 { get; set; }
        public string Discription46 { get; set; }
        public string Discription47 { get; set; }
        public string Discription48 { get; set; }
        public string Discription49 { get; set; }
        public string Discription50 { get; set; }
        public string Discription51 { get; set; }
        public string Discription52 { get; set; }
        public string Discription53 { get; set; }
        public string Discription54 { get; set; }
        public string Discription55 { get; set; }
        public string Discription56 { get; set; }
        public string Discription57 { get; set; }
        public string Discription58 { get; set; }
        public string Discription59 { get; set; }
        public string Discription60 { get; set; }
        public string Discription61 { get; set; }
        public string Discription62 { get; set; }
        public string Discription63 { get; set; }
        public string Discription64 { get; set; }
        public string Discription65 { get; set; }
        public string Discription66 { get; set; }
        public string Discription67 { get; set; }
        public string Discription68 { get; set; }
        public string Discription69 { get; set; }
        public string Discription70 { get; set; }
        public string Discription71 { get; set; }
        public string Discription72 { get; set; }
        public string Discription73 { get; set; }
        public string Discription74 { get; set; }
        public string Discription75 { get; set; }
        public string Discription76 { get; set; }
        public string Discription77 { get; set; }
        public string Discription78 { get; set; }
        public string Discription79 { get; set; }
        


        public string Image2 { get; set; }
        public string VideoLink { get; set; }
        public string Complited { get; set; }
        public List<QuestionTrueFalse> QuestionTrueFalse { get; set; }
        public QuestionTrueFalse currentQuestion;
        public int currentindexquestion;
        public string Preload { get; set; }
        public int CorrectCount { get; set; }
        public string TestNumber { get; set; }
        public int WrongCount { get; set; }

        public Lecture()
        {
            QuestionTrueFalse = new List<QuestionTrueFalse>();
        }

        public void generateQuestion()
        {
            currentindexquestion++;
            currentQuestion = QuestionTrueFalse[currentindexquestion];
        }

        public QuestionTrueFalse getCurrentQuestion()
        {
            return currentQuestion;
        }

        public Boolean checkAnswer(string answerArg)
        {
            if (answerArg == this.currentQuestion.getAnswer())
            {
                CorrectCount++;
                return true;
            }
            else
            {
                WrongCount++;
                return false;
            }
        }
    }
}
