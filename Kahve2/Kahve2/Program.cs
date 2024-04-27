using Kahve2;

class Program
{
    static void Main(string[] args)
    {
        Kahve kahve = new Kahve();
        kahve.FiltreFiyati = 30;
        kahve.LatteFiyati = 30;
        kahve.MochaFiyati = 30;
        kahve.kurabiyeFiyati = 30;
        kahve.KekFiyati = 30;
        kahve.FiltreMiktar = 50;
        kahve.LatteMiktar = 50;
        kahve.MochaMiktar = 50;
        kahve.KekMiktar = 50;
        kahve.kurabiyeMiktar = 50;

        Kurabiye kurabiye = new Kurabiye();
        kurabiye.cikolatalıFiyatı = 30;
        kurabiye.damlaCikolataFiyatı = 30;
        kurabiye.karamelFiyatı = 30;
        kurabiye.cikolatalıMiktar = 50;
        kurabiye.damlaCikolataMiktar = 50;
        kurabiye.karamelMiktar = 50;

        int bakiye = 500;

        do
        {
            Console.WriteLine("Kafe Satış Takip");
            Console.WriteLine(".................");
            Console.WriteLine("1-Ürün Fiyatı");
            Console.WriteLine("2-Ürün Fiyatı Güncelle");
            Console.WriteLine("3-Kahve Satışı yap");
            Console.WriteLine("4-Ek Satışlara bak");
            Console.WriteLine("5-Toplam Kahve Satışı");
            Console.WriteLine("6-Kafeden Çık");
            Console.WriteLine("Bir Seçim Yapınız...[1,2,3,4,5,6]:");

            char anaMenu = Convert.ToChar(Console.ReadLine());

            switch (anaMenu)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine(">>Seçiminiz '1'");
                    Console.WriteLine("----Ürün Fiyatı Listesi----");
                    Console.WriteLine($"Filtre (F): {kahve.FiltreFiyati} TL");
                    Console.WriteLine($"Latte (L): {kahve.LatteFiyati} TL");
                    Console.WriteLine($"Mocha (M): {kahve.MochaFiyati} TL");
                    Console.WriteLine($"Çikolatalı(Ç): {kurabiye.cikolatalıFiyatı} TL");
                    Console.WriteLine($"DamlaÇikolatalı(D): {kurabiye.damlaCikolataFiyatı} TL");
                    Console.WriteLine($"Karamel(K): {kurabiye.karamelFiyatı} TL");




                    Console.WriteLine("Seçiminizi Yapınız [1:Menüye Dön 2:Programı Kapat]:");
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
                    break;

                case '2':
                    Console.Clear();
                    Console.WriteLine(">>Seçiminiz '2'");
                    Console.WriteLine("----Kahve Fiyatlarını Güncelle-----");
                    Console.WriteLine("Ürün Türü Seçin: [F,L,M,C,K,D]");
                    char KahveMiktarDüzelt = Convert.ToChar(Console.ReadLine().ToUpper());
                    switch (KahveMiktarDüzelt)
                    {
                        case 'F':
                            Console.WriteLine("FİLTRE(F):{0} TL", kahve.FiltreFiyati);
                            Console.WriteLine("Filtre Kahve Fiyat Düzeltiniz:");
                            kahve.FiltreFiyati = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Değişiklik Yapılmıştır");
                            Console.WriteLine("Filtre (F): {0} TL", kahve.FiltreFiyati);
                            break;

                        case 'L':
                            Console.WriteLine("FİLTRE(L):{0} TL", kahve.LatteFiyati);
                            Console.WriteLine(" Latte Fiyat Düzeltiniz:");
                            kahve.LatteFiyati = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Değişiklik Yapılmıştır");
                            Console.WriteLine("Latte (L): {0} TL", kahve.LatteFiyati);
                            break;

                        case 'M':
                            Console.WriteLine("Mocha(M):{0} TL", kahve.MochaFiyati);
                            Console.WriteLine("Filtre Kahve Fiyat Düzeltiniz:");
                            kahve.MochaFiyati = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Değişiklik Yapılmıştır");
                            Console.WriteLine("Mocha (M): {0} TL", kahve.MochaFiyati);
                            break;
                        case 'C':
                            Console.WriteLine("Çikolatalı:{0} TL", kurabiye.cikolatalıFiyatı);
                            Console.WriteLine("Çikolatalı kurabiye fiyatını düzeltiniz:");
                            kurabiye.cikolatalıFiyatı = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("değişiklik yapılmıştır");
                            Console.WriteLine("Çikolatalı C(c) {0}", kurabiye.cikolatalıFiyatı);
                            break;
                        case 'K':
                            Console.WriteLine("karamelli:{0} TL", kurabiye.karamelFiyatı);
                            Console.WriteLine("Karamelli kurabiye fiyatını düzeltiniz:");
                            kurabiye.karamelFiyatı = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("değişiklik yapılmıştır");
                            Console.WriteLine("Karamelli K(K) {0}", kurabiye.karamelFiyatı);
                            break;
                        case 'D':
                            Console.WriteLine("Damla çikolatalı:{0} TL", kurabiye.damlaCikolataFiyatı);
                            Console.WriteLine("Damla Çikolatalı kurabiye fiyatını düzeltiniz:");
                            kurabiye.damlaCikolataFiyatı = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("değişiklik yapılmıştır");
                            Console.WriteLine("Damla Çikolatalı D(D) {0}", kurabiye.damlaCikolataFiyatı);
                            break;

                        default:
                            Console.WriteLine("Geçersiz seçim.");
                            break;
                    }

                    Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön  2: Programı kapat]:");
                    Altmenu = Convert.ToChar(Console.ReadLine().ToUpper());
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
                    break;

                case '3':
                    Console.Clear();
                    Console.WriteLine(">>>>seçiminiz:3");
                    Console.WriteLine("Kahve satış yeri");

                    Console.WriteLine("kahve türü seçiniz: [F,L,M]");
                    char kahveTuru = Convert.ToChar(Console.ReadLine().ToUpper());
                    int kahveSatis = 0;

                    switch (kahveTuru)
                    {
                        case 'F':
                            if (kahve.FiltreMiktar == 0)
                            {
                                Console.WriteLine("Kahve Kalmamıştır");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kaç Adet Filtre Kahve alacaksınız?");
                                kahveSatis = Convert.ToInt32(Console.ReadLine());

                                if (kahve.FiltreMiktar < kahveSatis)
                                {
                                    Console.WriteLine("Kahve miktarı yetersiz");
                                    break;
                                }
                                else if (kahveSatis <= kahve.FiltreMiktar)
                                {
                                    int toplamTutar = kahveSatis * kahve.FiltreFiyati;
                                    if (toplamTutar > bakiye)
                                    {
                                        Console.WriteLine("Paranız yetersiz.");
                                        break;
                                    }
                                    else
                                    {
                                        kahve.FiltreMiktar = kahve.FiltreMiktar - kahveSatis;
                                        Console.WriteLine("Kahve Satılmıştır");
                                        Console.WriteLine("Filtre kahve {0} tane kahve kaldı.", kahve.FiltreMiktar);
                                        bakiye -= toplamTutar;
                                        Console.WriteLine("Kalan bakiye: {0}", bakiye);
                                    }
                                }
                            }
                            break;

                        case 'L':
                            if (kahve.LatteMiktar == 0)
                            {
                                Console.WriteLine("Kahve Kalmamıştır");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kaç Adet Latte Kahve alacaksınız?");
                                kahveSatis = Convert.ToInt32(Console.ReadLine());

                                if (kahve.LatteMiktar < kahveSatis)
                                {
                                    Console.WriteLine("Kahve miktarı yetersiz");
                                    break;
                                }
                                else if (kahveSatis <= kahve.LatteMiktar)
                                {
                                    int toplamTutar = kahveSatis * kahve.LatteFiyati;
                                    if (toplamTutar > bakiye)
                                    {
                                        Console.WriteLine("Paranız yetersiz.");
                                        break;
                                    }
                                    else
                                    {
                                        kahve.LatteMiktar = kahve.LatteMiktar - kahveSatis;
                                        Console.WriteLine("Kahve Satılmıştır");
                                        Console.WriteLine("Latte kahve {0} tane kahve kaldı.", kahve.LatteMiktar);
                                        bakiye -= toplamTutar;
                                        Console.WriteLine("Kalan bakiye: {0}", bakiye);
                                    }
                                }
                            }
                            break;

                        case 'M':
                            if (kahve.MochaMiktar == 0)
                            {
                                Console.WriteLine("Kahve Kalmamıştır");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kaç Adet Mocha Kahve alacaksınız?");
                                kahveSatis = Convert.ToInt32(Console.ReadLine());

                                if (kahve.MochaMiktar < kahveSatis)
                                {
                                    Console.WriteLine("Kahve miktarı yetersiz");
                                    break;
                                }
                                else if (kahveSatis <= kahve.MochaMiktar)
                                {
                                    int toplamTutar = kahveSatis * kahve.MochaFiyati;
                                    if (toplamTutar > bakiye)
                                    {
                                        Console.WriteLine("Paranız yetersiz.");
                                        break;
                                    }
                                    else
                                    {
                                        kahve.MochaMiktar = kahve.MochaMiktar - kahveSatis;
                                        Console.WriteLine("Kahve Satılmıştır");
                                        Console.WriteLine("Mocha kahve {0} tane kahve kaldı.", kahve.MochaMiktar);
                                        bakiye -= toplamTutar;
                                        Console.WriteLine("Kalan bakiye: {0}", bakiye);
                                    }
                                }

                            }


                            Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön  2: Programı kapat]:");
                            Altmenu = Convert.ToChar(Console.ReadLine().ToUpper());
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
                            break;

                        default:
                            Console.WriteLine("Geçersiz seçim.");
                            break;
                    }
                    break;

                case '4':
                    Console.Clear();
                    Console.WriteLine(">>>>seçiminiz:4");
                    Console.WriteLine("Ek Satılan Malzemeler");
                    Console.WriteLine("Kurabiye türü seçiniz: [C,K,D]");
                    char kurabiyetürü = Convert.ToChar(Console.ReadLine().ToUpper());
                    int kurabiyesatıs = 0;

                    switch (kurabiyetürü)
                    {
                        case 'C':
                            if (kurabiye.cikolatalıMiktar == 0)
                            {
                                Console.WriteLine("kurabiye Kalmamıştır");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kaç Adet çikolatalı kurabiye alacaksınız?");
                                kurabiyesatıs = Convert.ToInt32(Console.ReadLine());

                                if (kurabiyesatıs <= 0)
                                {
                                    Console.WriteLine("Geçersiz miktar");
                                    break;
                                }

                                if (kurabiye.cikolatalıMiktar < kurabiyesatıs)
                                {
                                    Console.WriteLine("kurabiye miktarı yetersiz");
                                    break;
                                }
                                else
                                {
                                    int toplamTutar = kurabiyesatıs * kurabiye.cikolatalıFiyatı;
                                    if (toplamTutar > bakiye)
                                    {
                                        Console.WriteLine("Paranız yetersiz.");
                                        break;
                                    }
                                    else
                                    {
                                        kurabiye.cikolatalıMiktar = kurabiye.cikolatalıMiktar - kurabiyesatıs;
                                        Console.WriteLine("Kurabiye Satılmıştır");
                                        Console.WriteLine("çikolatalı {0} tane kurabiye kaldı.", kurabiye.cikolatalıMiktar);
                                        bakiye -= toplamTutar;
                                        Console.WriteLine("Kalan bakiye: {0}", bakiye);
                                    }
                                }
                            }
                            break;

                        case 'K':
                            if (kurabiye.karamelMiktar == 0)
                            {
                                Console.WriteLine("karamelli kurabiye Kalmamıştır");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kaç Adet karamelli kurabiye alacaksınız?");
                                kurabiyesatıs = Convert.ToInt32(Console.ReadLine());

                                if (kurabiyesatıs <= 0)
                                {
                                    Console.WriteLine("Geçersiz miktar");
                                    break;
                                }

                                if (kurabiye.karamelMiktar < kurabiyesatıs)
                                {
                                    Console.WriteLine("kurabie miktarı yetersiz");
                                    break;
                                }
                                else
                                {
                                    int toplamTutar = kurabiyesatıs * kurabiye.karamelFiyatı;
                                    if (toplamTutar > bakiye)
                                    {
                                        Console.WriteLine("Paranız yetersiz.");
                                        break;
                                    }
                                    else
                                    {
                                        kurabiye.karamelMiktar = kurabiye.karamelMiktar - kurabiyesatıs;
                                        Console.WriteLine("kurabiye Satılmıştır");
                                        Console.WriteLine("karamelli  {0} tane kurabiye kaldı.", kurabiye.karamelMiktar);
                                        bakiye -= toplamTutar;
                                        Console.WriteLine("Kalan bakiye: {0}", bakiye);
                                    }
                                }
                            }
                            break;

                        case 'D':
                            if (kurabiye.damlaCikolataMiktar == 0)
                            {
                                Console.WriteLine("damla çikolatalı kurabiye Kalmamıştır");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Kaç Adet damla çikolatalı kurabiye alacaksınız?");
                                kurabiyesatıs = Convert.ToInt32(Console.ReadLine());

                                if (kurabiyesatıs <= 0)
                                {
                                    Console.WriteLine("Geçersiz miktar");
                                    break;
                                }

                                if (kurabiye.damlaCikolataMiktar < kurabiyesatıs)
                                {
                                    Console.WriteLine("kurabie miktarı yetersiz");
                                    break;
                                }
                                else
                                {
                                    int toplamTutar = kurabiyesatıs * kurabiye.damlaCikolataFiyatı;
                                    if (toplamTutar > bakiye)
                                    {
                                        Console.WriteLine("Paranız yetersiz.");
                                        break;
                                    }
                                    else
                                    {
                                        kurabiye.damlaCikolataMiktar = kurabiye.damlaCikolataMiktar - kurabiyesatıs;
                                        Console.WriteLine("kurabiye Satılmıştır");
                                        Console.WriteLine("damla çikolatalı  {0} tane kurabiye kaldı.", kurabiye.damlaCikolataMiktar);
                                        bakiye -= toplamTutar;
                                        Console.WriteLine("Kalan bakiye: {0}", bakiye);
                                    }
                                } break;
                            }



                    }
                    break;

                    




                case '5':
                    Console.Clear();
                    Console.WriteLine(">>>>seçiminiz:5");
                    Console.WriteLine("Toplam Kahve Satışı");
                    int toplamFiltreSatışı = (50 - kahve.FiltreMiktar);
                    int toplamLatteSatışı = (50 - kahve.LatteMiktar);
                    int toplamMochaSatışı = (50 - kahve.MochaMiktar);
                    int toplamSatış = (toplamFiltreSatışı * kahve.FiltreFiyati) + (toplamLatteSatışı * kahve.LatteFiyati) + (toplamMochaSatışı * kahve.MochaFiyati);
                    Console.WriteLine("Filtre Kahve Satışı: {0}", toplamFiltreSatışı * kahve.FiltreFiyati);
                    Console.WriteLine("Latte Kahve Satışı: {0}", toplamLatteSatışı * kahve.LatteFiyati);
                    Console.WriteLine("Mocha Kahve Satışı: {0}", toplamMochaSatışı * kahve.MochaFiyati);
                    Console.WriteLine("çikolatalı kurabiye satılan miktarı:" + (50 - kurabiye.cikolatalıMiktar));
                    Console.WriteLine("karamelli kurabiye satılan miktarı:" + (50 - kurabiye.karamelMiktar));
                    Console.WriteLine("damla çikolatalı kurabiye satılan miktarı:" + (50 - kurabiye.damlaCikolataMiktar));
                    Console.WriteLine("Toplam Satış: {0}", toplamSatış);
                    Console.WriteLine("Seçiminizi Yapınız [1: Ana Menüye Dön 2: Programı kapat]:");
                    Altmenu = Convert.ToChar(Console.ReadLine());
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
                    break;

                case '6':
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim.");
                    break;
            }
        } while (true);
    }
}