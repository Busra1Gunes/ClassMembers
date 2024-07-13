using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers
{
    //Biz yazılımcılar nesnelerimiz içerisindeki field'lara direkt erişilmesini istemeyiz
    //**Dolayısıyla field'lar da ki verileri kontrollü bir şekilde dışarıya açmak isteriz 
    //İşte böyle bir durumda metodaları kullanabiliriz
    //Böyle bir durumda C#programlama dilinde metot yerine property yaqpıları geliştirilmiştir
    //Yani property yapıları özünde nesne içerisindeki bir field'ın dışarıya kontrollü açılmasını br kontrollü bir şekilde
    //dışarıdan değer almasını sağlayan yapılardır
    //Biz propertylerin bu işlevine Enkcapsulation (Kapsülleme/ Sarmalama) diyeceğiz
    public class ExampleClass
    {
        public ExampleClass( string ad1,string soyad1)
        {
            _ad=ad1;
            _soyad=soyad1;
            
        }
        string ad="Kübra "; 
        string soyad="Aslan ";
        public string _ad
        {
            get
            {
                return ad.Trim();
            }

            set
            {
                if (value == "Büşra")
                    Console.WriteLine("Büşra adı var");
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
                if (value == "Güneş")
                    Console.WriteLine("Güneş olmasın");
                else soyad = value;
            }
        }
        public void Person()
        {
            Console.WriteLine(_ad + " " + _soyad);


        }
    }
    //Encapsulation: Bir nesne içindeki dataların(fieldlardaki verilerin) dışırıya kontrollü bir şekilde açılması ve kontrollü
    //bir şekilde veri almasıdır
}
