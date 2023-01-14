
Console.WriteLine("Girmek istediğiniz sayıların adedi(Çift sayı olmalıdır):");
int sayı = Convert.ToInt32(Console.ReadLine());
int[] sayıListesi = new int[sayı];

if (sayı % 2 == 0)
{
    Console.WriteLine($"{sayı} belirtiğiniz sayıları giriniz.");
    for (int i = 0; i < sayı; i++)
    {
        Console.WriteLine("{0}. sayınız: ", i + 1);
        sayıListesi[i] = Convert.ToInt32(Console.ReadLine());
    }


    for (int i = 0; i < sayıListesi.Length; i += 2)
    {
        if (sayıListesi[i] == sayıListesi[i + 1])
        {
            int toplam = sayıListesi[i] + sayıListesi[i + 1];
            Console.Write(" " + toplam * toplam + " ");
        }
        else
        {
            int toplam = sayıListesi[i] + sayıListesi[i + 1];
            Console.Write(" " + toplam + " ");
        }
    }
}
else
{
    Console.WriteLine("\a Hata! Lütfen çift sayı giriniz.");
}
