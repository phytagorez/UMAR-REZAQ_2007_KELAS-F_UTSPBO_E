using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRent
{
    public class SewaPremium : SewaKendaraan
    {
        public double _hargaPerHari;
        public double _biayaSopir;

        public SewaPremium(string namaPenyewa, int idSewa, string tipeMobil, double hargaPerHari, double biayaSopir) : base(namaPenyewa, idSewa, tipeMobil)
        {
            this._hargaPerHari = hargaPerHari;
            this._biayaSopir = biayaSopir;
        }

        //○ SewaPremium: total = (lamaHari × hargaPerHari) + biayaSopir
        public override int hitungTotalSewa(int lamaHari, int hargaPerHari, int biayaSopir)
        {
            int total = 0;
            total = lamaHari * hargaPerHari + biayaSopir;
            return total;
        }
    }
}
