using System;

namespace DictionaryYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.Add("Nurullah Özsoy", 1);
            myDictionary.Add("Ferhat ", 2);
            myDictionary.Add("Ezgi", 3);
            myDictionary.List();
        }
    }
}
