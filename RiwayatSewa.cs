using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRent
{
    public class RiwayatSewa : SewaKendaraan
    {
        public List<RiwayatSewa> riwayat = new List<RiwayatSewa>();

        public string jenisPaket;
        public string tanggalSewa;
        public int lamaHari;

        public RiwayatSewa(string namaPenyewa, int idSewa, string tipeMobil, string tanggalSewa, string jenisPaket) : base(namaPenyewa, idSewa, tipeMobil)
        {
            this.jenisPaket = jenisPaket;
            this.tanggalSewa = tanggalSewa;
        }

        public void TambahSewa(int lamaHari, int hargaPerHari, int biayaSopir)
        {
            hitungTotalSewa(lamaHari, hargaPerHari, biayaSopir);
        }

        public void CetakRiwayat(int lamaHari, int hargaPerHari, int biayaSopir)
        {
            TampilkanInfo();
            Console.WriteLine($"Total Sewa: {hitungTotalSewa(lamaHari, hargaPerHari, biayaSopir)}");
            Console.WriteLine($"{jenisPaket} |  {lamaHari} Hari | {tanggalSewa}");
        }

        public override int hitungTotalSewa(int lamaHari, int hargaPerHari, int biayaSopir)
        {
            int total = 0;
            total = lamaHari * hargaPerHari + biayaSopir;
            return total;
        }
    }
}
