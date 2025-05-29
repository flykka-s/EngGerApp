using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Services
{
    public interface IIdentifiableLectureLecture
    {
         string Id { get; set; }
        string Lecture1_test { get; set; }
        string Lecture2_test { get; set; }
        string Lecture3_test { get; set; }
        string Lecture4_test { get; set; }
        string Lecture5_test { get; set; }
        string Lecture6_test { get; set; }
        string Lecture7_test { get; set; }
        string Lecture8_test { get; set; }
        string Lecture9_test { get; set; }
        string Lecture10_test { get; set; }
        string Lecture11_test { get; set; }
        string Lecture12_test { get; set; }
        string Lecture13_test { get; set; }
        string Lecture14_test { get; set; }
        string Lecture15_test { get; set; }
        string Lecture16_test { get; set; }
        string Lecture17_test { get; set; }
        string Lecture18_test { get; set; }
        string Lecture19_test { get; set; }
        string Lecture20_test { get; set; }
        string Lecture21_test { get; set; }
        string Lecture22_test { get; set; }
        string Lecture23_test { get; set; }
        string Lecture24_test { get; set; }
        string Lecture25_test { get; set; }
        string Lecture26_test { get; set; }
        string Lecture1_comp { get; set; }
        string Lecture2_comp { get; set; }
        string Lecture3_comp { get; set; }
        string Lecture4_comp { get; set; }
        string Lecture5_comp { get; set; }
        string Lecture6_comp { get; set; }
        string Lecture7_comp { get; set; }
        string Lecture8_comp { get; set; }
        string Lecture9_comp { get; set; }
        string Lecture10_comp { get; set; }
        string Lecture11_comp { get; set; }
        string Lecture12_comp { get; set; }
        string Lecture13_comp { get; set; }
        string Lecture14_comp { get; set; }
        string Lecture15_comp { get; set; }
        string Lecture16_comp { get; set; }
        string Lecture17_comp { get; set; }
        string Lecture18_comp { get; set; }
        string Lecture19_comp { get; set; }
        string Lecture20_comp { get; set; }
        string Lecture21_comp { get; set; }
        string Lecture22_comp { get; set; }
        string Lecture23_comp { get; set; }
        string Lecture24_comp { get; set; }
        string Lecture25_comp { get; set; }
        string Lecture26_comp { get; set; }

    }
    public interface IRepositoryLectures<T> where T : IIdentifiableLectureLecture
    {
        Task<T> Get(string id);
        Task<IList<T>> GetAll();
        Task<string> Save(T item);
        Task<bool> Delete(T item);
        Task<bool> Update(T item);

    }
}
