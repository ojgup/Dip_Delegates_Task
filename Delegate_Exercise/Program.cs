using System;
using System.Collections.Generic;

public delegate List<List<string>> Parser(List<List<string>> data);

namespace Delegate_Exercise
{
    class Delegate_Exercise
    {
        static void Main(string[] args)
        {

/**            CsvHandler csvHandler = new CsvHandler();

            DataParser dataParser = new DataParser();

            Func<List<List<string>>, List<List<string>>> tResult = dataParser.StripQuotes;

            tResult += dataParser.StripWhiteSpace;
            tResult += RemoveHashes;
            tResult += captializeData;


            csvHandler.ProcessCsv("data.csv", "processed_data.csv", tResult);

            Parser parser = new Parser(captializeData);

            parserMethod(parser);**/
        }

        public static void parserMethod(Parser parser)
        {
            /*
            DataParser dataParser = new DataParser();
            FileHandler fileHandler = new FileHandler();

            parser += dataParser.StripQuotes;
            parser += dataParser.StripWhiteSpace;
            parser += RemoveHashes;

            List<string> fileContents = fileHandler.ReadFile("data.csv");
            List<List<string>> parseCsv = fileHandler.ParseCsv(fileContents);

            fileHandler.WriteFile("processed_data.csv", ',', parser(parseCsv));
            */
        }



    }
}
