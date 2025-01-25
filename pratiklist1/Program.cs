using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Yönetim isimlerini içeren bir liste oluşturuyoruz
        List<string> davetliler = new List<string>
        {
            "Bülent Ersoy",
            "Ajda Pekkan",
            "Ebru Gündeş",
            "Hadise",
            "Hande Yener",
            "Tarkan",
            "Funda Arar",
            "Demet Akalın"
        };

        // foreach döngüsü ile isimleri ekrana yazdırıyoruz
        foreach (string davetli in davetliler)
        {
            Console.WriteLine(davetli);
        }
    }
}
