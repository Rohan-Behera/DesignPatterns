namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PDFprinter pdf = new ReportPrinter()
                .setHeader("this is head")
                .setContent("this is content")
                .setFooter("this is footer")
                .PDFbuild();

            pdf.printHeader();
        }
    }
}