﻿using System;

namespace Modul008_VirtualWithProperties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class MyBaseClass
    {
        // virtual auto-implemented property. Overrides can only
        // provide specialized behavior if they implement get and set accessors.
        public virtual string Name { get; set; }

        // ordinary virtual property with backing field
        private int _num;
        public virtual int Number
        {
            get { return _num; }
            set { _num = value; }
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        private string _name;

        // Override auto-implemented property with ordinary property
        // to provide specialized accessor behavior.
        public override string Name //get und set wurden nochmals spezialisiert 
        {
            get
            {
                return _name;
            }
            set
            {
                //Valdierung können wir in der abgeleiten Klasse hinzufügen 
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    _name = "Unknown";
                }
            }
        }
    }
}
