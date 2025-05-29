using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LearnApp.Services
{
    public interface IIdentifiableTests
    {
         string Id { get; set; }
         string Test1 { get; set; }
         string Test2 { get; set; }
         string Test3 { get; set; }
         string Test4 { get; set; }
         string Test5 { get; set; }
         string Test6 { get; set; }
         string Test7 { get; set; }
         string Test8 { get; set; }
         string Test9 { get; set; }
         string Test10 { get; set; }
         string Test11 { get; set; }
         string Test12 { get; set; }
         string Test13 { get; set; }
         string Test14 { get; set; }
         string Test15 { get; set; }
         string Test16 { get; set; }
         string Test17 { get; set; }
         string Test18 { get; set; }
         string Test19 { get; set; }
         string Test20 { get; set; }
         string Test21 { get; set; }
         string Test22 { get; set; }
         string Test23 { get; set; }
         string Test24 { get; set; }
         string Test25 { get; set; }
         string Test26 { get; set; }
         string Test27 { get; set; }
        string Test28 { get; set; }
        string Test29 { get; set; }
        string Test30 { get; set; }
        string Test31 { get; set; }
        string Test32 { get; set; }
        string Test33 { get; set; }
        string Test34 { get; set; }
        string Test35 { get; set; }
        string Test36 { get; set; }
        string Test37 { get; set; }
        string Test38 { get; set; }
        string Test39 { get; set; }
        string Test40 { get; set; }
        
       

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
        string Task21_comp { get; set; }
        string Task22_comp { get; set; }
        string Task23_comp { get; set; }
        string Task24_comp { get; set; }
        string Task25_comp { get; set; }
        string Task26_comp { get; set; }
        string Task27_comp { get; set; }
        string Task28_comp { get; set; }
        string Task29_comp { get; set; }
        string Task30_comp { get; set; }
        string Task31_comp { get; set; }
        string Task32_comp { get; set; }
        string Task33_comp { get; set; }
        string Task34_comp { get; set; }
        string Task35_comp { get; set; }
        string Task36_comp { get; set; }
        string Task37_comp { get; set; }
        string Task38_comp { get; set; }
        string Task39_comp { get; set; }
        string Task40_comp { get; set; }

        
        
    }
    public interface IRepositoryTests<T> where T : IIdentifiableTests
    {
        Task<T> Get(string id);
        Task<IList<T>> GetAll();
        Task<string> Save(T item);
        Task<bool> Delete(T item);
        Task<bool> Update(T item);

    }
}
