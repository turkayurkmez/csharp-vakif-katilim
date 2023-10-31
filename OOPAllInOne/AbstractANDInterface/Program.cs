namespace AbstractANDInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PdfDocument pdfDocument = new PdfDocument();
            ExcelDocument excelDocument = new ExcelDocument();
            WordDocument wordDocument = new WordDocument();

            DocumentSaver documentSaver = new DocumentSaver();
            documentSaver.SaveDocument(pdfDocument);

            documentSaver.SaveDocument(excelDocument);
            documentSaver.SaveDocument(wordDocument);

            DocumentPrinter documentPrinter = new DocumentPrinter();
            documentPrinter.Print(wordDocument);
            documentPrinter.Print(excelDocument);
            //documentPrinter.Print(pdfDocument);

        }
    }
}