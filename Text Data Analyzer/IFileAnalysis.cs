using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Data_Analyzer
{
    //It is not possible to inherit from more than one class, but it is permissible with interfaces.
    public interface IFileAnalysis //This is a contract that requires the classes you are inhirit to implement what is in it.
    {
        void AnalyzeFile(FileInfo fileInfo);
    }
}
