//3. Menentukan indeks nilai Mahasiswa

using System;
class IndeksNilai
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indeks Nilai Mahasiswa");
        Console.Write("Masukkan nilai : ");
        double nilai = Convert.ToDouble(Console.ReadLine());

        
        if (nilai >= 80)
        {
            Console.WriteLine("Indeks Nilai = A");
        }
        else if (nilai < 80 && nilai >= 70)
        {
            Console.WriteLine("Indeks Nilai = B");
        }
        else if (nilai < 70 && nilai >= 55)
        {
            Console.WriteLine("Indeks Nilai = C");
        }
        else if (nilai < 55 && nilai >= 40)
        {
            Console.WriteLine("Indeks Nilai = D");
        }
        else
        {
            Console.WriteLine("Indeks Nilai = E");
        }
    }
}