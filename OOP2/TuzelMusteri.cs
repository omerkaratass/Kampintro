using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //CoorporateCustomer
    //Miras = inheriatence
    // TuzelMusteri kardeşim artık sen bir müşterisin. Müşterinin içerisinde olan tüm özellikler Tüzel'dede var kabul edilir.
    class TuzelMusteri:Musteri
    {

        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
