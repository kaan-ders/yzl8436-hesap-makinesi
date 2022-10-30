namespace HesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 0, sayi2 = 0, sonuc = 0;
            string islem;

            // Lütfen işlem seçin:
            // 1) toplama
            // 2) çıkarma
            // 5) çıkış

            //sayı 1: 
            // sayı2: 
            //sonuc bu:


            //tek sefer çalışan versiyon
            //-----------------------------------------------

            //Console.Write("Lütfen ilk sayıyı giriniz: ");
            //sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen ikinci sayıyı giriniz: ");
            //sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Lütfen işlemi giriniz: ");
            //islem = Console.ReadLine();

            //switch(islem)
            //{
            //    case "+":
            //        sonuc = sayi1 + sayi2;
            //        break;
            //    case "-":
            //        sonuc = sayi1 - sayi2;
            //        break;
            //    case "*":
            //        sonuc = sayi1 * sayi2;
            //        break;
            //    case "/":
            //        sonuc = sayi1 / sayi2;
            //        break;
            //}

            //Console.WriteLine("İşleminizin sonucu: " + sonuc);
            //Console.Read();

            //---------------------------------------
            //menülü versiyon

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1) Toplama");
                Console.WriteLine("2) Çıkarma");
                Console.WriteLine("3) Çarpma");
                Console.WriteLine("4) Bölme");
                Console.WriteLine("5) Çıkış");

                Console.Write("Lütfen işlem seçin: ");
                islem = Console.ReadLine();

                if (islem != "1" && islem != "2" && islem != "3" && islem != "4" && islem != "5")
                {
                    Console.WriteLine("Yanlış işlem");
                    Console.Write("Devam etmek için bir tuşa basınız");
                    Console.ReadLine();
                    continue;
                }

                if (islem == "5")
                    break;

                Console.Write("Lütfen ilk sayıyı giriniz: ");
                sayi1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lütfen ikinci sayıyı giriniz: ");
                sayi2 = Convert.ToInt32(Console.ReadLine());

                if (islem == "1")
                    sonuc = sayi1 + sayi2;
                else if (islem == "2")
                    sonuc = sayi1 - sayi2;
                else if (islem == "3")
                    sonuc = sayi1 * sayi2;
                else if (islem == "4")
                    sonuc = sayi1 / sayi2;

                Console.WriteLine("İşleminizin sonucu: " + sonuc);
                Console.Write("Devam etmek için bir tuşa basınız");
                Console.ReadLine();
            }
        }
    }
}