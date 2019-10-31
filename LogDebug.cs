using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DxPropPages
{

    class LogDebug
    {
        string filePath = "logs/log.log";

        public void createLogFile(){
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filePath);
            fileInfo.Directory.Create();
        }

        public void writeLog(string log) {
            System.IO.File.AppendAllText(@"logs/log.log", log + Environment.NewLine);
        }
    }
}
