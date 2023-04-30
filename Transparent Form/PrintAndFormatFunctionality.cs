using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bridge Pattern
namespace Transparent_Form
{
    //Abstract Bridge Component
    public interface Formatter
    {
        string format();
    }

    //concrete formatter
    public class HtmlPrintFormatter : Formatter
    {
        public string format()
        {
            return ("This is HTML formatted List (HtmlPrintFormatter)");
        }
    }
    //concrete formatter
    public class PdfPrintFormatter : Formatter
    {
        public string format()
        {
            return ("This is PDF formatted List (PdfPrintFormatter)");
        }
    }

    //Abstract Logic Class
    public abstract class Printer
    {
        public Formatter _formatter;
        public abstract string print(Formatter _formatter);
    }

    //concrete logic class
    public class HtmlPrinter : Printer
    {
        public override string print(Formatter _formatter)
        {
            return (_formatter.format());
        }
    }

    //concrete logic class
    public class PdfPrinter : Printer
    {
        public override string print(Formatter _formatter)
        {
            return (_formatter.format());
        }
    }
    //comment to run bridge pattern
    class PrintAndFormatFunctionality
    {
        public PrintAndFormatFunctionality()
        {
            Console.WriteLine("PRINT");
        }

    
    }

    //uncomment to run bridge pattern
    /*static class PrintAndFormatFunctionality
    {

        
        
        /*static void Main()
        {
            Formatter formatter = new HtmlPrintFormatter();
            String resultList = new HtmlPrinter().print(formatter);
            Console.WriteLine(resultList);
            System.Console.ReadKey();
        }
    }*/

    }
