using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuursion
{
    static class GetTheSizeOfDirctory
    {
        public static long CalculateSize(string dirPath)
        {
            long size = 0;
            foreach(var fileName in Directory.GetFiles(dirPath))
            {
                size += new FileInfo(fileName).Length;
            }
            foreach(var dirNam in Directory.GetDirectories(dirPath)) {

                size += CalculateSize(dirNam);
            }
            return size;

        }
    }
}
