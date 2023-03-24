namespace PatternAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Document html = new HTMLdocumnet();

            html.print();

            Document xml = new XMLdocument();

            xml.print();

        }
    }
}
