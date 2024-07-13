using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    //#3 26.27
    public class ExampleClass
    {
        public ExampleClass(string ad1, string soyad1)
        {
            //
            // _ad sete git 
            _ad = ad1;
            //_soyad sete git 
            _soyad = soyad1;

        }
        public int Yas { get; set; }

        public string Meslek { get; set; }
        string ad = "Kübra ";
        string soyad = "Aslan ";
        public string _ad
        {
            get
            {
                return ad;
            }
           

            set
            {
                if (value == "Büşra")
                {
                    Console.WriteLine("Büşra adı var");
                    _ad = ad;

                }
                   
                else value = ad;
            }
        }
        public string _soyad
        {
            get
            {
                return soyad.Trim();
            }

            set
            {
                if (value == "Güüneş")
                    Console.WriteLine("Güneş olmasın");
                else soyad = value;
            }
        }
        public void Person()
        {
            _ad = "Burcu";
            _soyad = "Taş";
            ad = "Ali";
            soyad = "yılmaz";
            Console.WriteLine(_ad + " " + _soyad);


        }
       
    }
}
