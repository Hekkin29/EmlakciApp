using EmlakciLib;

namespace EmlakciApp

{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Ev evim = new Ev();
            //Console.WriteLine("Oda sayısı giriniz");
            //evim.Setodasayisi(int.Parse(Console.ReadLine()));
            //Console.WriteLine("Kat no giriniz");
            //evim.KatNo = int.Parse(Console.ReadLine());
            //Console.WriteLine("Semt giriniz");
            //evim.Semt(Console.ReadLine());
            //Console.WriteLine("Alan giriniz");
            //evim.Alan = double.Parse(Console.ReadLine());

            //Console.WriteLine($"Girilen ev bilgileri:\n{evim.EvBilgileri()}");
            //Console.WriteLine($"Girilen oda sayısı bilgisi:\n{evim.GetOdaSayisi()}");
            //Console.WriteLine($"Girilen semt bilgisi:\n{evim.GetSemt()}");

            //Ev evim = new Ev();//ev tipinde evim isminde referans ve yeni bir nesne
            //evim.semt = "Gazi";
            //evim.alan = 120;
            //evim.odaSayisi = 3;
            //evim.KatNo = 1;
            //string bilgi = evim.evBilgileri();
            //Console.WriteLine("ev1: \n" + bilgi);


            //Ev evim2 = new Ev();
            //evim2.semt = "kazan";
            //evim2.alan = 152;
            //evim2.odaSayisi = 4;
            //evim2.KatNo = 3;
            //Console.WriteLine("ev2: \n" + evim2.evBilgileri());

            //Console.WriteLine("hangi evi görmek istersiniz: ");
            //string ev = Console.ReadLine();
            //switch (ev)
            //{
            //    case "ev1":
            //        Console.WriteLine("semt: " + evim.semt + "\nOda sayısı: " + evim.odaSayısı + "\nalan: " + evim.alan + "\nkat no: " + evim.KatNo);
            //        break;
            //    case "ev2":
            //        Console.WriteLine("semt: " + evim2.semt + "\nOda sayısı: " + evim2.odaSayısı + "\nalan: " + evim2.alan + "\nkat no: " + evim2.KatNo);
            //        break;
            //    default:
            //        Console.WriteLine("hatalı giris");
            //        break;

            //Ev ev = new Ev();
            //ev Setalan

            //Console.WriteLine($"Girilen evin büyüklüğü:{ev.Buyukluk()}");



        } 
    }
}
//Not
//Kapsülleme ilkesi (Encapsulation): Bir Class içerisinde yapılan işlemlerin, diğer classlardan gizlenmesi ilkesidir.
//property:Private fieldlara ulaşmak için kullanılan yapılardır.Get ve opsiyanel olarak set yapıları içerir.
//Referanslar belleğin stack bölümünde tutulur.
//Referanslar, heap bölgesindeki nesnelerin adresini tutar.
//Nesneler belleğin heap bölümünde tutulur.
//Nesne olultururken kullanılan new anahtar sözcüğü, heap bölgesinde alan ayırma işlemi yaparken, nesne içerisinde bulunan field'lara varsayılan değerlerini de atamasını sağlar.*(Constructor Method)
//Classların bir diğer kullanım amacı da ,başka projelerde tekrar tekrar kullanılabilir olmalarıdır.
//Static:Class'a ait olan üyeler(field, method..)static olarak tanımlanır ve class adıyla erişilir.EvBilgileri() gibi.
//Nesneye ait olan üyeler static olarak tanımlanmaz.Mesela oda sayısı katno vb. static olamaz.Çünkü her nesnenin odasayısı, katno gibi değerleri olması gerekir(Nesneye ait).Bu durumda EvBilgileri() methodu da, her evin bilgisini ayrı ayrı getirmesi gerektiğinden dolayı, nesnelere ait olması yani static olmaması daha doğru olur.
//Static olmayan üyelere nesne referansı ile erişilir.
//Class library projeleri derlendikten sonra dll doyası oluşturur.
//emlakcilib build yap --> emlakciapp-add-project reference -->classı kullanmak için class ismini yazıp ctrl+. yapıp oluşturuyoruz.


