using PersonelTakipUygulamasi.Entities.Concrete;
using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipUygulamasi.DataAccess.Abstract
{
    public interface ICalisanDal
    {
        List<Calisan> Listele(string kosulCumlesi);
        Calisan Getir(string kosulCumlesi);

        bool Kaydet(Calisan calisan);

        bool Guncelle(Calisan calisan);

        bool Sil(string kosulCumlesi);
        bool Sil(int id);
    }
}
