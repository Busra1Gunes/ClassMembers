using ClassMembers;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        MyClass  myClass= new MyClass();
        //field'ların defaul değerleri vardır
        Console.WriteLine(myClass.a);



       ExampleClass exampleClass= new ExampleClass("Büşra", "Güneş");
        exampleClass.Person();
    }
    class MyClass
    {
        //fiald
       public int a;
        //field
       public string b;
        public void metod()
        {
            //field degil
            string c;
            //field değil
            int d;
            //metod içinde tanımlanan değişkenler field değerdir başlangıç degerleri tanımlanmadan
            //yazdırılmaya çalışılırsa hata verir başlangıç değeri atamak gerekir
           // Console.WriteLine(d);
        }
        //property
        //Nesne içerisinde özeliik property sağlar 
        //Property esasında özünde bir metottur, yani programatik/algoritmik kodlarımızı inşa
        //ettiğimiz bir metod
        //Lakin fiziksel olarak mettottan farkı parametre almamakta ve içerisinde get ve set olma üzere 
        //iki adet blok almaktadır
        public int MyProperty {
            //property
            //property'nin işlevsel olarak metottan farkı yoktur, lakin davranışsal olarak nesne üzerinde bir değer okuma
            //ve değer atama işlemlerinde kullanırlır 
            //keza bu metodlar compile neticesinde get ve set isimli metodlar olarak karşımıza çıkmaktadır

            get
            {
                //property'nin degeri çağrildiğinda get bloğu tetiklenir ve değeri return edilir
                return 0;
            }
            set
            {
                //property'e bir değer atandıında set blogunda bu değeri yakalarız
                //atanan veri burada yakalanır
            }
        }
        //method
        public int MyMethod()
        {
            return 0;
            
        }

    }
}