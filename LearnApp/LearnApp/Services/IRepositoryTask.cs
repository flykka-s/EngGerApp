using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Services
{
    public interface IIdentifiableTask
    {
        string Id { get; set; }
         string Task1 { get; set; }
         string Task2 { get; set; }
         string Task3 { get; set; }
         string Task4 { get; set; }
         string Task5 { get; set; }
         string Task6 { get; set; }
         string Task7 { get; set; }
         string Task8 { get; set; }
         string Task9 { get; set; }
         string Task10 { get; set; }
        string Task11 { get; set; }
        string Task12 { get; set; }
        string Task13 { get; set; }
        string Task14 { get; set; }
        string Task15 { get; set; }
        string Task16 { get; set; }
        string Task17 { get; set; }
        string Task18 { get; set; }
        string Task19 { get; set; }
        string Task20 { get; set; }
        string Task1_comp { get; set; }
        string Task2_comp { get; set; }
        string Task3_comp { get; set; }
        string Task4_comp { get; set; }
        string Task5_comp { get; set; }
        string Task6_comp { get; set; }
        string Task7_comp { get; set; }
        string Task8_comp { get; set; }
        string Task9_comp { get; set; }
        string Task10_comp { get; set; }
        string Task11_comp { get; set; }
        string Task12_comp { get; set; }
        string Task13_comp { get; set; }
        string Task14_comp { get; set; }
        string Task15_comp { get; set; }
        string Task16_comp { get; set; }
        string Task17_comp { get; set; }
        string Task18_comp { get; set; }
        string Task19_comp { get; set; }
        string Task20_comp { get; set; }
        string Task1_answer { get; set; }
        string Task2_answer { get; set; }
        string Task3_answer { get; set; }
        string Task4_answer { get; set; }
        string Task5_answer { get; set; }
        string Task6_answer { get; set; }
        string Task7_answer { get; set; }
        string Task8_answer { get; set; }
        string Task9_answer { get; set; }
        string Task10_answer { get; set; }
        string Task11_answer { get; set; }
        string Task12_answer { get; set; }
        string Task13_answer { get; set; }
        string Task14_answer { get; set; }
        string Task15_answer { get; set; }
        string Task16_answer { get; set; }
        string Task17_answer { get; set; }
        string Task18_answer { get; set; }
        string Task19_answer { get; set; }
        string Task20_answer { get; set; }

    }

    public interface IRepositoryTask<T> where T : IIdentifiableTask
    {
        Task<T> Get(string id);
        Task<IList<T>> GetAll();
        Task<string> Save(T item);
        Task<bool> Delete(T item);
        Task<bool> Update(T item);

    }
}
