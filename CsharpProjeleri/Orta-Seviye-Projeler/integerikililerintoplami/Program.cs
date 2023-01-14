
Console.WriteLine("Girmek istediğiniz sayıların adedi(Çift sayı olmalıdır):");
int sayi = Convert.ToInt32(Console.ReadLine());
int[] sayiList = new int[sayi];

if (sayi % 2 == 0)
{
    Console.WriteLine($"{sayi} belirtiğiniz sayıları giriniz.");
    for (int i = 0; i < sayi; i++)
    {
        Console.WriteLine("{0}. sayınız: ", i + 1);
        sayiList[i] = Convert.ToInt32(Console.ReadLine());
    }


    for (int i = 0; i < sayiList.Length; i += 2)
    {
        if (sayiList[i] == sayiList[i + 1])
        {
            int toplam = sayiList[i] + sayiList[i + 1];
            Console.Write(" " + toplam * toplam + " ");
        }
        else
        {
            int toplam = sayiList[i] + sayiList[i + 1];
            Console.Write(" " + toplam + " ");
        }
    }
}
else
{
    Console.WriteLine("\a Hata! Lütfen çift sayı giriniz.");
}
