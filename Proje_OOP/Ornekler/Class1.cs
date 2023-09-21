using Proje_OOP.Entity;

namespace Proje_OOP.Ornekler
{
    //Sınıfların içindeki ögelere  erişim sağlamak için sınıftan bir nesne türetilir
    //SınıfAdı nesneAdı=new SınıfAdı();
    public class Class1
    {
        internal void Topla()
        {
            throw new NotImplementedException();
        }

        void Metot()
        {
            void Topla()
            {
                int sayi1 = 10;
                int sayi2 = 20;
                int sonuc = sayi1 + sayi2;
            }
            void Carp()
            {
                int s1 = 10;
                int s2 = 20;
                int sonuc = s1 * s2;
            }
        } 
    }
}
