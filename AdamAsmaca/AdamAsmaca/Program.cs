using System;

namespace AdamAsmaca
{
    class Program
    {
        static void Main(string[] args)
        {
            // ************Adam asmaca oyunu**************
            /*
             * oyunda Gerçekleşecek olan kurallar
             * 1.Bir kelime grubundan rastegele bir kelime seç
             * 2.Seçtiğin bu kelimenin her harfini * işaretine dönüştür
             * 3.bu blmacayı ekranda göster
             * 4. Ouyncudan harf iste 
             * 5.Harf kelimede var mı kontrol et.
             * 6.a. Girilen harf eğer varsa o harfinin blunduğu * işaretini harfe çevir (örnek a**a)
             *   b. yoksa bir hakını azalt
             * 7.oyuncudan kelimeyi tahmin etmesini iste 
             * bilirse oyunu bittir 
             * bilmezse 3. adımı dön 
             */
            bool oyunuKayıpEtin = false;
            string[] kelimeler = { "armut", "elma", "ayna", "masa", "eldivan" };
            while (!oyunuKayıpEtin)
            {
                string secilenKelime = kelimeSec(kelimeler);
                string bulmaca = degistirToStar(secilenKelime);

                Console.WriteLine(bulmaca);
                bool kelimeBulma = false;
                while (!kelimeBulma)
                {
                    Console.WriteLine("Bir Harf Tahmin Ediniz !");
                    string girilenHarf = Console.ReadLine();
                    bool harfKelimeVarMı = kelimedekiHarfıKontrolEt(secilenKelime,girilenHarf);


                    if (true)
                    {

                        bulmaca = degistirStarToHarf(secilenKelime, bulmaca, girilenHarf);
                        Console.WriteLine(bulmaca);
                    }
                    Console.WriteLine("Kelimeyi Tahmin Etmek İster Misiniz(E/H)");
                    string CevabTahmin = Console.ReadLine();
                    if (CevabTahmin.ToUpper() == "E")
                    {
                        Console.WriteLine("Tahmininizi giriniz:");
                        string tahminEtmek = Console.ReadLine();

                        kelimeBulma = tahminVeSeçilenKelimeyikarşılaştırın(tahminEtmek, secilenKelime);

                    }

                }
                Console.WriteLine("Oyunu Devam Etmek İster Misinişz !(E/H)");
                oyunuKayıpEtin = Console.ReadLine().ToUpper() == "H";
            }
        }

        private static bool tahminVeSeçilenKelimeyikarşılaştırın(string tahminEtmek, string secilenKelime)
        {
            return tahminEtmek == secilenKelime;
        }

        private static string degistirStarToHarf(string secilenKelime, string bulmaca, string girilenHarf)
        {
            int baslaİndex = 0;
            char[] baslaBulmaca = bulmaca.ToCharArray();
            while (secilenKelime.IndexOf(girilenHarf, baslaİndex) != -1)
            {
                int indexBulma = secilenKelime.IndexOf(girilenHarf, baslaİndex);
                baslaBulmaca[indexBulma] = Convert.ToChar(girilenHarf);
                baslaİndex = indexBulma + 1;
            }
            string sonuc = string.Empty;
            foreach (var item in baslaBulmaca)
            {
                sonuc += item.ToString();
            }
            return sonuc;
        }

        private static bool kelimedekiHarfıKontrolEt(string secilenKelime,string girilenHarf)
        {
            return secilenKelime.Contains(girilenHarf);
        }

        private static string degistirToStar(string secilenKelime)
        {
            string bulmacaSonucu = string.Empty;
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                bulmacaSonucu += "*";
            }
            return bulmacaSonucu;
        }

        private static string kelimeSec(string[] kelimeler)
        {
            Random random = new Random();
            string kelime = kelimeler[random.Next(0, kelimeler.Length)];
            return kelime;
        }
    }
}
