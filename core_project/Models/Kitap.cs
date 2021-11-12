using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_project.Models
{
    public class Kitap
    {
        //Sınıflarda değişken yapısı kullanılmaz -Dolayısı ile property ler tanımlanmalıdır.
        public int ID { get; set; }
        public string KitapAd { get; set; }
        public string Yazar { get; set; }
    }
}
