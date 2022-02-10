using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    //Hier arbeitet kein Source-Generator
    public partial class Person
    {
        //Für den Entwickler -> Erweiterungen können hier implementiert werden
        public string Wohnort { get; set; }
    }
}
