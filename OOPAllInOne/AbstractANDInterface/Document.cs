using AbstractANDInterface;

namespace AbstractANDInterface
{
    public abstract class Document
    {

        public string Title { get; set; }
        public string Owner { get; set; }
        public void Copy(string from, string to)
        {
            Console.WriteLine("Dosya kopyalandı...");
        }

        public abstract void Save();
        public abstract void Open();
        //public abstract void Print();

    }

    public interface IPrintable
    {
        void Print();
    }

    public class PdfDocument : Document
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }



        public override void Save()
        {
            Console.WriteLine("PDF Kaydedildi");
        }
    }

    public class ExcelDocument : Document, IPrintable
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Excel çıktısı alındı");
        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save()
        {
            Console.WriteLine("Excel Kaydedildi");
        }
    }

    public class WordDocument : Document, IPrintable
    {
        public override void Open()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("Word çıktısı alındı");

        }

        //public override void Print()
        //{
        //    throw new NotImplementedException();
        //}

        public override void Save()
        {
            Console.WriteLine("Word Kaydedildi");
        }
    }
}
/*
 * Sıvı ürünler şişeye
 * Katılar poşete
 *     paketlenir bu markette :)
 */

public class DocumentSaver
{
    public void SaveDocument(Document document)
    {
        document.Save();
    }
}

public class DocumentPrinter
{
    public void Print(IPrintable document)
    {
        document.Print();
    }
}