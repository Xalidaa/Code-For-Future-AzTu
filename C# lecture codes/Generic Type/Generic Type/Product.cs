namespace Generic_Type
{
    class Product<T>
    {
        public T Quality { get; set; }

        public Product(T quality)
        {
            Quality = quality;
        }
    }
}

// eger gonderilen deyerin tipini bilmirikse(yeni int de ola biler, string de, bool da ve s.)
//o zaman generic typelardan istifade olunur;
//normalda generic type olmasa idi, overloadlar yazacaqdiq bu da yaddasda elave yer tutur
// amma generic typelarda eledir ki gonderdiyin deyere baxir ve tipini deyisir
//meselen 50 gondermisense onu integer kimi gorur; true gondermisense bool kimi gorur ve s.

// Generic typelari class adindan sonra "<>" bu isarenin icinde istenilen ad qoyaraq teyin edirik
// daha sonra propertymizin tipine de generic qoyuruq ve ctorda verdiyimiz deyiseni de o tip qoyuruq
// bizim halda bu T-dir