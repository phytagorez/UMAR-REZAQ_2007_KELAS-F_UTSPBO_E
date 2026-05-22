using System;
using System.Collections.Generic;
using System.Text;

namespace OOPRent
{
    public abstract class SewaKendaraan
    {
        private string _namaPenyewa;
        private int _idSewa;
        private string _tipeMobil;

        public string namaPenyewa
        {
            get { return _namaPenyewa; }
            set
            {
                if (string.IsNullOrWhiteSpace(_namaPenyewa))
                {
                    Console.WriteLine("nama pengguna tidak boleh kosong");
                }
                _namaPenyewa = value;
            }
        }

        public int idSewa
        {
            get { return _idSewa; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("id sewa tidak boleh 0");
                }
                _idSewa = value;
            }
        }

        public string tipeMobil
        {
            get { return _tipeMobil; }
            set
            {
                if (string.IsNullOrWhiteSpace(_tipeMobil))
                {
                    Console.WriteLine("nama pengguna tidak boleh kosong");
                }
                _tipeMobil = value;
            }
        }

        public virtual void TampilkanInfo()
        {
            Console.WriteLine($"Penyewa: {namaPenyewa} | ID: {idSewa} | Mobil: {tipeMobil}");
        }

        public SewaKendaraan(string namaPenyewa, int idSewa, string tipeMobil)
        {
            this._namaPenyewa = namaPenyewa;
            this._idSewa = idSewa;
            this._tipeMobil = tipeMobil;
        }

        public abstract int hitungTotalSewa(int lamaHari, int hargaPerHari, int biayaSopir);
    }
}