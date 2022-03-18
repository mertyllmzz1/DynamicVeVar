using System;

namespace DynamicVSVar
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //dynamic toplam = BasicMath.Topla(10.5M, "HATA");
            dynamic toplam = BasicMath.Topla(10.5M, 7);
            var toplam2 = BasicMath.Topla(10.5M, 7);// dikkat ettiyseniz bir hata meydana gelmedi çünkü BasicMath.Topla metodu geriye decimal bir değer döneceğini belirtiyor. 
            Console.WriteLine("TOPLAM: "+toplam);
            Console.WriteLine("TOPLAM2: "+toplam2);
            Console.ReadKey();
        }

    }

    public class BasicMath
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ff"> eğer ff veya qq değişkeni var ile tanımlansaydı
        /// Derleme esnasında ilk değer almadığı için hata meydana gelirdi</param>
        /// <param name="qq"> dynamic ise derleme zamanında herhangi bir atamaya ihtiyaç duymadığı için
        /// fonksiyon içerisinde kullanılmasında sakınca yok.
        /// Bu sayede JSON ,XML gibi formatların kullanımında oldukça avantajlıdır
        /// Ancak kullanımında dikkatli olunmalıdır. 
        /// Örneğin aşağıdaki gibi bir toplama işleminde qq değişkeni decimal bir ifade gelmez ise hata meydana gelecektir
        /// </param>
        public static decimal Topla(decimal ff , dynamic qq) 
        {
            return ff + qq;
        }
    }
}
