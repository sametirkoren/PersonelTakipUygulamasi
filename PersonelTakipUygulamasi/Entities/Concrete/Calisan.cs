using PersonelTakipUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi.Entities.Concrete
{
    public class Calisan : IBaseEntity
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public string SoyAdi { get; set; }
        public string TCKimlikNo { get; set; }

        public string PersonelNo { get; set; }

        public DateTime DogumTarihi { get; set; }

        public string Departman { get; set; }

        public string Unvan { get; set; }

        public string Durumu { get; set; }
    }
}
