using System;
using System.Collections.Generic;

namespace PropertiesLabs
{
    public class Person
    {
        private readonly string _name;
        private readonly List<Person> _children = new List<Person>();
        private DateTime _birthDate;

        //public void SetName(string name)
        //{
        //    _name = name;
        //}

        //public string GetName()
        //{
        //    return _name;
        //}

        public Person(string name)
        {
            this._name = name;
        }

        void DoSomethin()
        {
           // _name = "new Value";
        }
      
        public string Name
        {
            get { return _name; }
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - _birthDate.Year;
            }
        }

        public string Nationality { get; set; }
    }
}
