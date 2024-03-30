// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Entities.Concrete;

static void SelamVer(string isim="isimsiz")
{
    Console.WriteLine("Merhaba" + isim);
}
SelamVer(" Bulut");
SelamVer(" Betül");
SelamVer();


int sonuc = Topla(3,5);

static int Topla(int sayi1= 5 , int sayi2 = 8)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : "+sonuc.ToString());
    return sonuc;
}


void Degiskenler()
{
    string mesaj = "Selam";
    Console.WriteLine(mesaj);
    double tutar = 100000; //db den gelir
    int sayi =100;
    bool girisYapmisMi = false;

    string ad = "Bulut Çağrı";
    string soyad = "Çiftçi";
    int dogumyili = 2001;
    long tcNo = 12345678910;

    Console.WriteLine(tutar*1.35);

   

}

//Degiskenler();

Vatandas vatandas1 = new Vatandas();

Console.ReadLine();

//Diziler / arrays

string ogrenci1 = "Bulut";
string ogrenci2 = "Betül";
string ogrenci3 = "Selda";

string[] ogrenciler = new string[3];
ogrenciler[0] = "Bulut";
ogrenciler[1] = "Betül";
ogrenciler[2] = "Selda";

ogrenciler = new string[4];
ogrenciler[3] = "Ali";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = new[] { "ankara", "istanbul", "izmir" };
string[] sehirler2 = new[] { "Bursa", "antalya", "manisa" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.FirstName = "Bulut";

Person person2 = new Person();
person2.FirstName = "Betül";

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string>{"Ankara 1","istanbul 1","izmir 1"};
yeniSehirler1.Add("Adana 1");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

PttManager pttManager = new PttManager(new ForeignerManager());
pttManager.GiveMask(person1);



//Pascal Casing
public class Vatandas
{
    public string Ad  { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}
