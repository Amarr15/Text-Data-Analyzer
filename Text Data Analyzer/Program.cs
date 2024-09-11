namespace Text_Data_Analyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To File Analyzer (:");
            Console.WriteLine("Please Enter Folder Path To Analze");

            string inputFolder = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);

            if (directoryInfo.Exists == false)
            {
                Console.WriteLine("The Folder does not Exist");
                return;
            }
            var fileNames = directoryInfo.GetFiles();
            IFileAnalysis fileAnalysis = null;//here we created a new fileAnalysis
            foreach (var file in fileNames)
            {
                if (file.ISTextFile())
                {//If it is True, he will be a new analyzer but i don't know the type (.txt or .csv)
                    fileAnalysis = new TxtFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);
                    var results =((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine($"File Name: {file.Name}");
                    Console.WriteLine($"Word Count: {results.WordCount}");
                    Console.WriteLine($"Charcter Count: {results.CharcterCount}");
                    Console.WriteLine($"Line Count: {results.LineCount}");
                }
                else if (file.IsCSVFile())
                {
                    fileAnalysis = new CSVFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);
                    var results = ((FileAnalyzer)fileAnalysis).GetResults();
                    Console.WriteLine($"File Name: {file.Name}");
                    Console.WriteLine($"Field Count: {results.FiledCount}");
                }

            }







        }
    }
}
