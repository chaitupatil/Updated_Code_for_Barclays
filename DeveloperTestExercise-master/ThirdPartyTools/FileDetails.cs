using System;

namespace ThirdPartyTools
{
    public class FileDetails:FileSystem
    {
        public FileDetails(string FileName)
        {
            this._fileName = FileName;
        }
        
        public int Size()
        {
            return this.getSize();
        }

        public string Version()
        {
            return this.getVersion();
        }

        public DateTime CreateDate()
        {
            return this.createDate();
        }

        
    }
}
