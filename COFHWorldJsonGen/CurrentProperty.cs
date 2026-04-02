using System;
using System.Collections.Generic;
using System.Text;

namespace COFHWorldJsonGen
{

    internal sealed class CurrentProperty
    {
        private string NameValue { get; set; } 
        private static CurrentProperty _instance = null;
        public static CurrentProperty GetInstance()
        {
            if(_instance == null)
            {
                _instance = new CurrentProperty();
            }
            return _instance;
        }
        private CurrentProperty()
        {
            NameValue = string.Empty;
        }
        public string getNameValue()
        {
            return NameValue;
        }

        public void setNameValue(string nameValue)
        {
            NameValue = nameValue;
            Console.WriteLine(NameValue);
        }
    }
}
