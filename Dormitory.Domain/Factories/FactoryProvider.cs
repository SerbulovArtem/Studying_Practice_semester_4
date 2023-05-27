using Dormitory.Domain.Enums;
using Dormitory.Domain.Factories.Abstract;
using Dormitory.Domain.Factories.Concreate;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dormitory.Domain.Factories
{
    public class FactoryProvider
    {
        private FactoryType type;
        private const string _sourceFileName = "C: \\Users\\Артем\\source\\repos\\Studying_Practice_semester_4\\Dormitory.Domain\\Data\\Txt\\FactoryType.txt";

        public FactoryProvider(FactoryType type)
        {
            this.type = type;
        }

        /*public FactoryProvider(string file = _sourceFileName)
        {

        }

        public static int ReadFromFile()
        {
            int num;
            using (var sr = new StreamReader("C: \\Users\\Артем\\source\\repos\\Studying_Practice_semester_4\\Dormitory.Domain\\Data\\Txt\\FactoryType.txt", true))
            {
                num = sr.Read();
            }
            return num;
        }*/

        public IRepositoryFactory GetRepositoryFactory()
        {
            if (type == FactoryType.Memory)
                return new MemoryRepositoryFactory();
            else if (type == FactoryType.Mock)
                return new MockRepositoryFactory();
            else if (type == FactoryType.Txt) 
                return new TxtRepositoryFactory();
            else
                throw new Exception("Invalid factory type");
        }
    }
}
