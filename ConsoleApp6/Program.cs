
int dogruCevaplar = 0;
int yanliscevaplar = 0;

// 1. Soru
Console.WriteLine("1 -> Kızınca tüküren hayvan hangisidir?");
Console.WriteLine("A) Lama");
Console.WriteLine("B) Deve");
string cevap1 = Console.ReadLine().Trim().ToLower();

if (cevap1 == "a")
{
    dogruCevaplar++;
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap!");
    Console.WriteLine("Elendiniz");
}

// 2. Soru
Console.WriteLine("2 -> Dünya'ya en yakın gezegen hangisidir?");
Console.WriteLine("A) Venüs");
Console.WriteLine("B) Mars");
string cevap2 = Console.ReadLine().Trim().ToLower();

if (cevap2 == "a")
{
    dogruCevaplar++;
    Console.WriteLine("Doğru cevap!");
}
else
{
    Console.WriteLine("Yanlış cevap!");
    Console.WriteLine("Elendiniz");
}
if (cevap2 == "b")

// Eğer ilk 2 soruda büyük ödül kazanma ihtimali ortadan kalktıysa, 3. soruyu sormayız
if (yanliscevaplar <2)
    {
        Console.WriteLine("Kazanmak İçin Bu Soruyu Doğru Yapmalısınız");
       
     

    }



        // 3. Soru

        Console.WriteLine("3 -> 5 * 2 + 8 / 2 - 2 işleminin sonucu kaçtır?");
        Console.WriteLine("A) 7");
        Console.WriteLine("B) 12");
        string cevap3 = Console.ReadLine().Trim().ToLower();

        if (cevap3 == "b")
        {
            dogruCevaplar++;
            Console.WriteLine("Doğru cevap!");
        }
        else
        {
            Console.WriteLine("Yanlış cevap!");
        }





// Final sonucu
if (dogruCevaplar >= 2)
{
    Console.WriteLine("Tebrikler! 1 Milyon TL'lik büyük ödülü kazandınız!");
}

    
