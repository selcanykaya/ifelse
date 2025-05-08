// See https://aka.ms/new-console-template for more information
Console.Write("bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine()); //kullanıcıdan sayı alıyoruz.
if (sayi == 10) //sayı 10'a eşit mi diye kontrol ediyoruz.
{
    Console.WriteLine("Girdiğiniz sayı 10'a eşittir.");
}
else if (sayi < 10) //sayı 10'dan küçük mü diye kontrol ediyoruz.
{
    Console.WriteLine("Girdiğiniz sayı 10'dan küçüktür.");
}
else //sayı 10'dan büyük mü diye kontrol ediyoruz.
{
    Console.WriteLine("Girdiğiniz sayı 10'dan büyüktür.");

}

if (sayi % 2 == 0) //sayı çift mi tek mi kontrol ediyoruz.
{
    Console.WriteLine("Girdiğiniz sayı çifttir.");
}
else
{
    Console.WriteLine("Girdiğiniz sayı tektir.");
}