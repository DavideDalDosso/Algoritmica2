using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgramBitcoin
{
    public static void Main(string[] args)
    {
        string path = "Input.txt";

        byte[] buffer = new byte[1024];
        int offset = 0;

        //VVarning! Visual studio creates builds in a subdirectory of the solution folder.
        //The builds cannot access the resources in the solution files so a work around would
        //be to copy the file to the build directory on compile on visualstudio post-build event
        //by running the command COPY or XCOPY
        //but I ran out of time to figure that out...
        using (FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read))
        {
            while(stream.Read(buffer, offset, buffer.Length) > 0){
                offset += buffer.Length;
                Console.WriteLine(buffer);
            }
        }
    }
}
