using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int i;

        do
        {
            Console.Clear();
            Console.WriteLine("Oyun Seçimi:");
            Console.WriteLine("1. Zar Atma Oyunu");
            Console.WriteLine("2. Bozuk Para Oyunu");
            Console.WriteLine("3. Sayı Tahmin Oyunu");
            Console.WriteLine("4. Kelime Tahmin Oyunu");
            Console.WriteLine("5. Taş, Kağıt, Makas Oyunu");
            Console.WriteLine("6. Matematik Sorusu Oyunu");
            Console.WriteLine("Çıkmak için 0'ı seçin.");
            i = int.Parse(Console.ReadLine());
            Console.WriteLine("==========================");

            switch (i)
            {
                case 1:
                    Console.Clear();
                    Console.Write("İki zarın toplamını tahmin edin (2-12): ");
                    int tahmin1;
                    while (!int.TryParse(Console.ReadLine(), out tahmin1) || tahmin1 < 2 || tahmin1 > 12)
                    {
                        Console.Write("Geçersiz giriş. Lütfen 2 ile 12 arasında bir sayı girin: ");
                    }

                    int sayı1 = rnd.Next(1, 7);
                    int sayı2 = rnd.Next(1, 7);
                    int toplam = sayı1 + sayı2;

                    Console.WriteLine("1. zar = " + sayı1);
                    Console.WriteLine("2. zar = " + sayı2);
                    Console.WriteLine("Zarların toplamı = " + toplam);

                    if (tahmin1 == toplam)
                    {
                        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüz, yanlış tahmin. Tekrar deneyin.");
                    }

                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Paranın yazı mı tura mı geleceğini tahmin edin (Yazı için 0, Tura için 1): ");
                    int tahmin2;
                    while (!int.TryParse(Console.ReadLine(), out tahmin2) || tahmin2 < 0 || tahmin2 > 1)
                    {
                        Console.WriteLine("Geçersiz Seçim. Lütfen Yazı için '0', Tura için '1' seçiniz: ");
                    }

                    int sonuc = rnd.Next(0, 2);

                    if (sonuc == 0)
                    {
                        Console.WriteLine("Sonuç: Yazı");
                    }
                    else
                    {
                        Console.WriteLine("Sonuç: Tura");
                    }

                    if (tahmin2 == sonuc)
                    {
                        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüz, yanlış tahmin. Tekrar deneyin.");
                    }

                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Sayı Tahmin Oyunu: 1 ile 100 arasında bir sayı tahmin edin.");
                    int sayi = rnd.Next(1, 101);
                    int tahmin3;
                    int deneme = 0;

                    do
                    {
                        Console.Write("Tahmininiz: ");
                        while (!int.TryParse(Console.ReadLine(), out tahmin3))
                        {
                            Console.Write("Geçersiz giriş. Lütfen bir sayı girin: ");
                        }

                        deneme++;

                        if (tahmin3 < sayi)
                        {
                            Console.WriteLine("Daha büyük bir sayı girin.");
                        }
                        else if (tahmin3 > sayi)
                        {
                            Console.WriteLine("Daha küçük bir sayı girin.");
                        }
                        else
                        {
                            Console.WriteLine($"Tebrikler! {deneme} denemede doğru tahmin ettiniz.");
                        }
                    } while (tahmin3 != sayi);

                    break;

                case 4:
                    Console.Clear();
                    string[] kelimeler = { "elma", "armut", "muz", "çilek", "kiraz" };
                    string secilenKelime = kelimeler[rnd.Next(kelimeler.Length)];
                    char[] tahminKelime = new string('_', secilenKelime.Length).ToCharArray();
                    int kalanHak = 6;
                    bool kelimeBulundu = false;

                    Console.WriteLine("Kelime Tahmin Oyunu: Bir meyve ismini tahmin edin.");

                    while (kalanHak > 0 && !kelimeBulundu)
                    {
                        Console.Write("Tahmininiz (Bir harf veya kelime): ");
                        string tahmin4 = Console.ReadLine().ToLower();

                        if (tahmin4.Length == 1)
                        {
                            char harf = tahmin4[0];
                            bool harfBulundu = false;

                            for (int j = 0; j < secilenKelime.Length; j++)
                            {
                                if (secilenKelime[j] == harf)
                                {
                                    tahminKelime[j] = harf;
                                    harfBulundu = true;
                                }
                            }

                            if (!harfBulundu)
                            {
                                kalanHak--;
                                Console.WriteLine($"Yanlış tahmin. Kalan hak: {kalanHak}");
                            }
                        }
                        else if (tahmin4 == secilenKelime)
                        {
                            kelimeBulundu = true;
                        }
                        else
                        {
                            kalanHak--;
                            Console.WriteLine($"Yanlış tahmin. Kalan hak: {kalanHak}");
                        }

                        Console.WriteLine("Kelime: " + new string(tahminKelime));

                        if (new string(tahminKelime) == secilenKelime)
                        {
                            kelimeBulundu = true;
                        }
                    }

                    if (kelimeBulundu)
                    {
                        Console.WriteLine("Tebrikler! Kelimeyi doğru tahmin ettiniz.");
                    }
                    else
                    {
                        Console.WriteLine($"Üzgünüz, bilemediniz. Kelime: {secilenKelime}");
                    }

                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine("Taş, Kağıt, Makas Oyunu: Taş için 1, Kağıt için 2, Makas için 3 seçin.");
                    int kullaniciSecim;


                    while (!int.TryParse(Console.ReadLine(), out kullaniciSecim) || kullaniciSecim < 1 || kullaniciSecim > 3)
                    {
                        Console.WriteLine("Geçersiz giriş. Lütfen Taş için 1, Kağıt için 2, Makas için 3 seçin: ");
                    }

                    int bilgisayarSecim = rnd.Next(1, 4);
                    string[] secimler = { "Taş", "Kağıt", "Makas" };

                    Console.WriteLine($"Sizin seçiminiz: {secimler[kullaniciSecim - 1]}");
                    Console.WriteLine($"Bilgisayarın seçimi: {secimler[bilgisayarSecim - 1]}");

                    if (kullaniciSecim == bilgisayarSecim)
                    {
                        Console.WriteLine("Berabere!");
                    }
                    else if ((kullaniciSecim == 1 && bilgisayarSecim == 3) || (kullaniciSecim == 2 && bilgisayarSecim == 1) || (kullaniciSecim == 3 && bilgisayarSecim == 2))
                    {
                        Console.WriteLine("Tebrikler! Kazandınız.");
                    }
                    else
                    {
                        Console.WriteLine("Üzgünüz, kaybettiniz.");
                    }

                    break;

                case 6:
                    int zorluk = 1;
                    bool devamEt = true;
                    while (devamEt)
                    {
                        Console.Clear();
                        Console.WriteLine($"Matematik Sorusu Oyunu - Zorluk Seviyesi: {zorluk}");

                        int sayi1Mat = rnd.Next(1, 10 * zorluk);
                        int sayi2Mat = rnd.Next(1, 10 * zorluk);
                        string[] islemler = { "+", "-", "*", "/" };
                        string islem = islemler[rnd.Next(islemler.Length)];

                        double sonucMat = 0;
                        switch (islem)
                        {
                            case "+":
                                sonucMat = sayi1Mat + sayi2Mat;
                                break;
                            case "-":
                                sonucMat = sayi1Mat - sayi2Mat;
                                break;
                            case "*":
                                sonucMat = sayi1Mat * sayi2Mat;
                                break;
                            case "/":
                                sonucMat = Math.Round((double)sayi1Mat / sayi2Mat, 2);
                                break;
                        }

                        Console.Write($"Soru: {sayi1Mat} {islem} {sayi2Mat} = ? ");
                        double kullaniciCevap;
                        bool cevapAlindi = false;
                        int kalanSure = 15;

                        Timer timer = new Timer(_ =>
                        {
                            lock (Console.Out)
                            {
                                try
                                {
                                    if (!cevapAlindi)
                                    {
                                        kalanSure--;
                                        Console.SetCursorPosition(0, Console.CursorTop);
                                        Console.Write($"Kalan süre: {kalanSure} saniye  ");
                                        if (kalanSure == 0)
                                        {
                                            timer.Dispose(); //hata alınan kısım
                                            Console.WriteLine("\nSüre doldu! Yanlış cevap.");
                                            Console.WriteLine($"Doğru cevap: {sonucMat}");
                                            Console.WriteLine("Yeni bir soru ister misiniz? [E/H]");
                                            if (Console.ReadLine().ToUpper() == "H")
                                            {
                                                devamEt = false;
                                            }
                                            zorluk = 1;
                                            return;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine($"Hata: {ex.Message}");
                                    timer.Dispose();
                                }
                            }
                        }, null, 1000, 1000);

                        if (double.TryParse(Console.ReadLine(), out kullaniciCevap))
                        {
                            lock (Console.Out)
                            {
                                cevapAlindi = true;
                                timer.Dispose();
                                if (Math.Abs(kullaniciCevap - sonucMat) < 0.01)
                                {
                                    Console.WriteLine("Tebrikler! Doğru cevap.");
                                    zorluk++;
                                }
                                else
                                {
                                    Console.WriteLine($"Yanlış cevap. Doğru cevap: {sonucMat}");
                                    zorluk = 1;
                                }
                            }
                        }
                        else
                        {
                            lock (Console.Out)
                            {
                                timer.Dispose();
                            }
                        }

                        Console.WriteLine("Yeni bir soru ister misiniz? [E/H]");
                        if (Console.ReadLine().ToUpper() == "H")
                        {
                            devamEt = false;
                        }
                    }
                    break;

                case 0:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen 0, 1, 2, 3, 4, 5 veya 6'yı seçin.");
                    break;
            }

            if (i != 0)
            {
                Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı kapat]:");
                char Altmenu = Convert.ToChar(Console.ReadLine());
                if (Altmenu == '1')
                {
                    Console.Clear();
                }
                else if (Altmenu == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Geçersiz seçim.");
                }
            }

        } while (i != 0);
    }
}

