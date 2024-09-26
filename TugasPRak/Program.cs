//232410101086
using System;
//kelas hewan 
public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

//Kelas Mamalia yang mewarisi Hewan
public class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki} kaki";
    }
}

//Kelas Reptil yang mewarisi Hewan
public class Reptil : Hewan
{
    public double PanjangTubuh;
    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

// Kelas Singa yang mewarisi Mamalia
public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }
    public override string Suara()
    {
        return "Singa mengaummmm!!";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} sedang mengaumm dengan keras aummmmmmmm");
    }
}

// Kelas Gajah yang mewarisi Mamalia
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }
    public override string Suara()
    {
        return "Gajah menderummmmm!!";
    }
}

// Kelas Ular yang mewarisi Reptil
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }
    public override string Suara()
    {
        return "Ular mendesisssssssssss!!";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap ingin memangsa lawan dengan diam-diam. ");
    }
}

// Kelas Buaya yang mewarisi Reptil
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }
    public override string Suara()
    {
        return "Buaya menggerammmmmm!!";
    }
}

// kelas kebun binatang yang memiliki koleksi Hewan
public class KebunBinatang
{
    public List<Hewan> KoleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        KoleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in KoleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine(hewan.Suara());
            Console.WriteLine();
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //buat objek kebun binatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        Console.WriteLine("SELAMAT DATANG DI KEBUNBINATANGKU");
        Console.WriteLine("HEWAN BUAS, KAMI LEMAS");
        Console.WriteLine("----------------------------------");

        //membuat objek dari berbagai jenis hewan
        Singa singa = new Singa("Lion samba", 6, 4);
        Gajah gajah = new Gajah("Opet", 10, 4);
        Ular ular = new Ular("Garaga", 2, 10);
        Buaya buaya = new Buaya("Panji", 7, 4.5);

        //menambahkan hewan ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        //menampilkan daftar hewan di kebun binatang
        kebunBinatang.DaftarHewan();

        //demonstransikan polymorphism dengan memanggil method
        Console.WriteLine("\nDemonstrasi Polymorphism: ");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        //method khusus untuk mengaum dan merayap
        Console.WriteLine("\nAksi Khusus Dari Hewan kami : ");
        singa.Mengaum();
        ular.Merayap();
    }
}