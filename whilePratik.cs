int sayac = 0;
while(sayac < 10)
{
    Console.WriteLine("Kendime inanıyorum ben bu yazılım işini hallederim");
    sayac++;
}
int sayac2 = 0;
int sayi = 0;
while(sayac2 < 21)
{
    Console.WriteLine(sayi);
    sayac2++;
    sayi++;
}
int sayac3 =0;
int sayi2 = 0;
while (sayac3 < 11)
{
    Console.WriteLine(sayi2);
    sayac3++;
    sayi2 += 2;

}
int sayac4 = 50;
int toplam = 0;
while (sayac4 < 151)
{
    toplam += sayac4;
    sayac4++;
}
Console.WriteLine("50-150 arasında ki sayıların toplamı: " + toplam);
int tekToplam = 0;
int ciftToplam = 0;
int sayac5 = 1;
while (sayac5 < 121)
{
    if (sayac5 % 2 == 0)
    {
        ciftToplam += sayac5;
    }
    else
    {
        tekToplam += sayac5;
    }
    sayac5++;
}
Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);
