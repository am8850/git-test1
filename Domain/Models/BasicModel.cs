using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{


    public class Rootobject
    {
        public int[] array { get; set; }
        public bool boolean { get; set; }
        public object _null { get; set; }
        public int number { get; set; }
        public InnerObject _object { get; set; }
        public string _string { get; set; }
    }

    public class InnerObject
    {
        public string a { get; set; }
        public string c { get; set; }
        public string e { get; set; }
    }


    class BasicModel
    {
    }
}
