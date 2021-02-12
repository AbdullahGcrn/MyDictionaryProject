using System;

namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary = new MyDictionary<string, string>();
            myDictionary.Add("Ayakkabı","Bot");
            myDictionary.Add("Takı", "Bileklik");
            myDictionary.List();

            Console.WriteLine("\nTanımlanan Katagori Sayısı : " + myDictionary.Count());
        }
    }
}
