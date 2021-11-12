using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using core_project.Models;
namespace core_project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()   // This is a method
        {
            return View();
        }

        //Index'e sağ tıklanıp addview eklenir.
        public IActionResult Index2()
        {

            return View();

        }
        //Dönüş Tipleri
        public int Index3()
        {
            return 24;
        }

        public string Index4()
        {
            return "Merhaba Bugün Hava Çok Soğuk";
        }

        public IActionResult Index5()
        {
            var ktp = new List<Kitap>()
            {
                new Kitap(){ID=1,KitapAd="80 Günde DevriAlem",Yazar="Jules Verne" },
                new Kitap(){ID=2,KitapAd="Bilinmeyen Bir Kitabın Mektubu",Yazar="Zweig" },
                new Kitap(){ID=3,KitapAd="Bir Noel Hikayesi",Yazar="Charles Dickens" },

            };
            return View(ktp);
        }

        public IActionResult Index6()
        {
            ViewBag.deger1 = "Merhaba Core dersleri devam ediyor";
            /*Viewbag hatayı runtime anında döndürür eğer hata var ise*/
            ViewBag.deger2 = "Sizden Bir Ricam Var";
            ViewBag.deger3 = "Elinize Sağlık Hocam";
            return View();
        }


    }
}
