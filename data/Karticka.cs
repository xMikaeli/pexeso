using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pexeso.data
{
    class Karticka
    {
        public string CardName { get; set; }
        public bool Selected { get; set; }
        public System.Drawing.Image Picture { get; set;}
        public int Count { get; set;}

        public Karticka  () { }
    }
}
