using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{
    public class TxtFileAnalyzer : FileAnalyzer , IFileAnalysis 
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string fileString = File.ReadAllText(fileInfo.FullName);//read the full path
            AnalysisResults results = new AnalysisResults();
            var word = fileString.Split(new char[] { ' ', '\n', '\r' });//To delete all spaces and lines
            results.WordCount = word.Length;
            results.CharcterCount = fileString.Length;
            var lines = fileString.Split(new char[] { '\n', });
            results.LineCount = lines.Length;
            SetResults(results);
        }
    }
}
