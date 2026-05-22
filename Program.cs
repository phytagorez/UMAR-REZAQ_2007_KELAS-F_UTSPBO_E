using System;

namespace OOPRent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RiwayatSewa rs = new RiwayatSewa("Ejak", 001, "Avanza", "14-10-2025", "Premium");
            rs.CetakRiwayat(10, 6000, 5000);

            Console.WriteLine();

            RiwayatSewa rs1 = new RiwayatSewa("Mas Tunggul SMANSAMORE", 002, "Civic", "5-22-2026", "Premium");
            rs1.CetakRiwayat(9, 54000, 8700);

            Console.WriteLine();

            RiwayatSewa rs2 = new RiwayatSewa("Tung Tung Sahur", 003, "Civic", "5-22-2026", "Regular");
            rs2.CetakRiwayat(54, 2000, 0);
        }
    }
}