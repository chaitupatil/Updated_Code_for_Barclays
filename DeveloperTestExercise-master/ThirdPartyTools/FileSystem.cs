using System;

namespace ThirdPartyTools
{
    public abstract class FileSystem
    {
        private readonly Random _random = new Random();

        protected string _fileName;

        protected int getSize()
        {
            return _random.Next(100000) + 100000;
        }

        protected string getVersion()
        {
            return string.Format("{0}.{1}.{2}.{3}", _random.Next(5), _random.Next(8), _random.Next(22), _random.Next(50));
        }

        protected DateTime createDate()
        {
            return DateTime.MinValue;
        }
    }
}
