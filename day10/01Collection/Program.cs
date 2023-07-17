using _01Collection;

class Program
{
    static void Main(string[] args)
    {
        List<Book> myBookList = new List<Book>();
        myBookList.Add(new Roman("Bumi Manusia", "Pramodya Anantha Toer", 1980, 4));
        myBookList.Add(new Roman("Arus Balik", "Pramodya Anantha Toer", 1995, 1));
        myBookList.Add(new SelfDevelopment("Rich Dad Poor Dad", "Robert T Kiyosaki", 1997, "English"));
        myBookList.Add(new SelfDevelopment("Atomic Habits", "James Clear" , 2018, "English"));
        myBookList.Add(new Kitab("Muroqil Ubudiyyah", "Imam Ghozali", 1100, "Tasawwuf"));
        myBookList.Add(new Kitab("Kasyfati saja", "Syeikh Nawawi Banten", 1900, "Fiqihi"));

        Console.WriteLine("=====Buku KOleksi=====");
        foreach (var book in myBookList)
        {
            Console.WriteLine($"Judul : {book.title}\nAuthor : {book.author}\nTahun Terbit : {book.datePublish}\n");

            if (book is Roman BookRoman)
            {
                Console.WriteLine($"Jumlah Jilid buku {book.title} : {BookRoman.jilid}\n");
            }
            if (book is SelfDevelopment BookDev)
            {
                Console.WriteLine($"Bahasa : {BookDev.language}\n");
            }
            if (book is Kitab BookKitab)
            {
                Console.WriteLine($"Tema Kitab : {BookKitab.tema}\n");
            }
        }
        //akses method buku :
        myBookList[0].Synopsis("Menceritakan kisah tentang Minke seorang anak bupati yang hidup bersama anak-anak Belanda ");
        myBookList[1].Synopsis("Menceritakan kisah Pemuda berkelana demi wanita yang diacinta");
        myBookList[2].Synopsis("The difference between Rich Dad and Poor Dad about Money");
        myBookList[3].Synopsis("Cara Merubah Diri lebih baik adalah dengan Mengubah kebiasaan Kecil");
    }
}       

