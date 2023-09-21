using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Proje_OOP.Ornekler;
using System;
using System.Security.Cryptography.X509Certificates;

namespace Proje_OOP.Controllers
{
    public class DefaultController : Controller
    {
        //void Islemler()
        //{
        //    Class1 c = new Class1();
        //    c.Topla();
        //}
        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesi";
            ViewBag.m2 = "Merhaba Proje çok iyi duruyor";
            ViewBag.m3 = "Selamlar ";
        }
        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int sonuc1= s1+ s2;
            return sonuc1;
        }
        int Cevre()
        {
            int kisakenar = 10;
            int uzunkenar = 20;
            int cevre = 2*(kisakenar+uzunkenar);
            return cevre;
        }
        int Faktoriyel(int p)
        {
            int f = 1;
            for(int i = 1;i<=p; i++)
            {
                f = f * i;
            }
            return f;
        }
        string cumle()
        {
            string c = "Tadic > ALL";
            return c;
        }
        void MesajListesi(string p)
        {
            ViewBag.v = p;
        }
        void Kullanici(string kullaniciAdi)
        {
            ViewBag.v=kullaniciAdi;
        }
        int Topla(int s1, int s2)
        {
            int sonuc = s1 + s2;
            return sonuc;
        }
        public IActionResult Index()
        {
            mesajlar();
            MesajListesi("Parametre ismi");
            Kullanici("Tadic On Fire");
            ViewBag.tp = Topla(20, 31);
           return View();
        }
        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            ViewBag.sonuc1=Cevre();
            Kullanici("Dzekoooo");
            ViewBag.faktor=Faktoriyel(6);
            return View();
        }
        public IActionResult musteriler()
        {
            ViewBag.d = cumle();
            Kullanici("Şimanskiiiii");
            return View();
        }
        public IActionResult Deneme()
        {
            Sehirler sehirler= new Sehirler();
            Bayrak bayrak = new Bayrak();
            sehirler.ID = 1;
            sehirler.Adi = "İstanbul";
            sehirler.Nufus = 25000000;
            sehirler.Ulke = "Türkiye";
            sehirler.Renk1 = "Kırmızı";
            sehirler.Renk2 = "Beyaz";
            ViewBag.v1 = sehirler.ID;
            ViewBag.v2 = sehirler.Adi;
            ViewBag.v3 = sehirler.Nufus;
            ViewBag.v4 = sehirler.Ulke;
            ViewBag.v5 = sehirler.Renk1;
            ViewBag.v6 = sehirler.Renk2;
            ViewBag.v7 = sehirler.Renk3;
            sehirler.ID = 2;
            sehirler.Adi = "Adana";
            sehirler.Ulke = "Türkiye";
            sehirler.Nufus = 3000000;
            ViewBag.z1= sehirler.Adi;
            ViewBag.z2 = sehirler.ID;
            ViewBag.z3 = sehirler.Ulke;
            ViewBag.z4 = sehirler.Nufus;
            ViewBag.z5=sehirler.Renk1;
            ViewBag.z6=sehirler.Renk2;
            ViewBag.z7=sehirler.Renk3;
            return View();
        }

    }
    
}