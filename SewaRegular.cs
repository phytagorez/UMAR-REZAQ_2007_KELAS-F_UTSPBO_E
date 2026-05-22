using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRent
{
    public class SewaRegular : SewaKendaraan
    {
        public double _hargaPerHari;

        public SewaRegular(string namaPenyewa, int idSewa, string tipeMobil,double hargaPerHari) : base(namaPenyewa, idSewa, tipeMobil)
        {
            this._hargaPerHari = hargaPerHari;
        }

        //○ SewaRegular: total = lamaHari × hargaPerHari
        public override int hitungTotalSewa(int lamaHari, int hargaPerHari, int biayaSopir)
        {
            int total = 0;
            total = lamaHari * hargaPerHari;
            return total;
        }
    }
}
